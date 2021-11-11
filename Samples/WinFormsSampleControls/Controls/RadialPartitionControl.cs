﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Northwoods.Go;
using Northwoods.Go.Layouts.Extensions;
using Northwoods.Go.Models;

namespace WinFormsSampleControls.RadialPartition {
  [ToolboxItem(false)]
  public partial class RadialPartitionControl : System.Windows.Forms.UserControl {
    private Diagram myDiagram;

    public RadialPartitionControl() {
      InitializeComponent();

      diagramControl1.AfterRender = Setup;

      goWebBrowser1.Html = @"
        <p>
      Click on a Node to center it and show its relationships.
        </p>
        <p>
      The <code>RadialLayout</code> class is an extension defined at <a href="".. / extensions / RadialLayout.js"">RadialLayout.js</a>.
      The override of the <code>RadialLayout.rotateNode</code> sets the <code>angle</code>,
      <code>sweep</code>, and <code>radius</code> data properties.
      Bindings in the node template use those properties to produce the appropriate <a href=""https://gojs.net/latest/intro/geometry.html#:~:text=The%20GoJS%20Geometry%20class%20controls,be%20used%20by%20setting%20Shape."">Shape.geometry</a>
      and the <a href=""https://gojs.net/latest/intro/sizing.html"">GraphObject.alignment</a> and <a href=""https://gojs.net/latest/api/symbols/RotatingTool.html"">GraphObject.angle</a> for each <a href=""https://gojs.net/latest/intro/textblocks.html"">TextBlock</a>.
        </p>
";

    }

    private int _LayerThickness = 70;

    private void Setup() {

      myDiagram = diagramControl1.Diagram;

      myDiagram.InitialAutoScale = AutoScaleType.Uniform;
      myDiagram.IsReadOnly = true;
      myDiagram.MaxSelectionCount = 1;

      myDiagram.Layout = new RadialPartitionLayout {
        MaxLayers = 5,
        LayerThickness = _LayerThickness
      };

      // ToolTips are not yet finished
      var commonToolTip = Builder.Make<Adornment>("ToolTip").Add(
        new Panel(PanelLayoutVertical.Instance) {
          Margin = 3
        }.Add(
          new TextBlock {
            Margin = 4, Font = "Segoe UI, 12px, style=bold"
          }.Bind("Text"),
          new TextBlock()
           .Bind("Text", "Color", (c, _) => "Color: " + c),
          new TextBlock() // bound to adornment because of call to Binding.OfObject
            .Bind(new Binding("Text", "", (ad, _) => "Connections: " + ((ad as Adornment).AdornedPart as Node).LinksConnected.Count()).OfElement())
        ) // end Vertical Panel
      ); // end Adornment

      Geometry makeAnnularWedge(object data, object obj) {
        var nodeData = data as NodeData;

        var angle = nodeData.Angle;
        var sweep = nodeData.Sweep;
        var radius = nodeData.Radius; // the inner radius

        // the Geometry will be centered about (0, 0)
        var outer = radius + _LayerThickness; // the outer radius
        var inner = radius;
        var p = new Point(outer, 0).Rotate(angle - sweep / 2);
        var q = new Point(inner, 0).Rotate(angle + sweep / 2);
        var geo = new Geometry()
          .Add(new PathFigure(-outer, -outer)) // always make sure the Geometry includes the top left corner
          .Add(new PathFigure(outer, outer)) // and the bottom right corner of the whole circular area
          .Add(new PathFigure(p.X, p.Y) // start at outer corner, go clockwise
            .Add(new PathSegment(SegmentType.Arc, angle - sweep / 2, sweep, 0, 0, outer, outer))
            .Add(new PathSegment(SegmentType.Line, q.X, q.Y)) // to opposite inner corner, then anticlockwise
            .Add(new PathSegment(SegmentType.Arc, angle + sweep / 2, -sweep, 0, 0, inner, inner).Close()));
        return geo;
      }

      Spot computeTextAlignment(object data, object obj) {
        var nodeData = data as NodeData;

        var angle = nodeData.Angle;
        var radius = nodeData.Radius;

        var p = new Point(radius + _LayerThickness / 2, 0).Rotate(angle);
        return new Spot(0.5, 0.5, p.X, p.Y);
      }

      double ensureUpright(object angle, object obj) {
        if ((double)angle > 90 && (double)angle < 270) return (double)angle + 180;
        return (double)angle;
      }

      // define the Node template
      myDiagram.NodeTemplate = new Node(PanelLayoutSpot.Instance) {
        LocationSpot = Spot.Center,
        SelectionAdorned = false,
        MouseEnter = (e, node, last) => (node as Node).LayerName = "Foreground",
        MouseLeave = (e, node, next) => (node as Node).LayerName = "",
        Click = nodeClicked,
        ToolTip = commonToolTip
      }.Add(
        new Shape { // this always occupies the full circle
          Fill = "lightgray",
          StrokeWidth = 0
        }.Bind(new Binding("Geometry", "", makeAnnularWedge))
         .Bind("Fill", "Color"),
        new TextBlock {
          Width = _LayerThickness,
          TextAlign = TextAlign.Center
        }.Bind(new Binding("Alignment", "", (data, obj) => computeTextAlignment(data, obj)))
         .Bind(new Binding("Angle", "Angle", (data, obj) => ensureUpright(data, obj)))
         .Bind("Text")
      );

      // this is the root node, at the center of the circular layers
      myDiagram.NodeTemplateMap.Add("Root",
        new Node(PanelLayoutAuto.Instance) {
          LocationSpot = Spot.Center,
          SelectionAdorned = false,
          ToolTip = commonToolTip,
          Width = _LayerThickness * 2,
          Height = _LayerThickness * 2
        }.Add(
          new Shape {
            Figure = "Circle",
            Fill = "white", StrokeWidth = 0.5, Spot1 = Spot.TopLeft, Spot2 = Spot.BottomRight
          },
          new TextBlock {
            Font = "Segoe UI, 14px, style=bold", TextAlign = TextAlign.Center
          }.Bind("Text")
        )
      );

      // define the Link template -- don't show anything!
      myDiagram.LinkTemplate = new Link();

      _GenerateGraph();
    }

    private void _GenerateGraph() {
      var names = new List<string> {
        "Joshua", "Daniel", "Robert", "Noah", "Anthony",
        "Elizabeth", "Addison", "Alexis", "Ella", "Samantha",
        "Joseph", "Scott", "James", "Ryan", "Benjamin",
        "Walter", "Gabriel", "Christian", "Nathan", "Simon",
        "Isabella", "Emma", "Olivia", "Sophia", "Ava",
        "Emily", "Madison", "Tina", "Elena", "Mia",
        "Jacob", "Ethan", "Michael", "Alexander", "William",
        "Natalie", "Grace", "Lily", "Alyssa", "Ashley",
        "Sarah", "Taylor", "Hannah", "Brianna", "Hailey",
        "Christopher", "Aiden", "Matthew", "David", "Andrew",
        "Kaylee", "Juliana", "Leah", "Anna", "Allison",
        "John", "Samuel", "Tyler", "Dylan", "Jonathan"
      };

      var nodeDataSource = new List<NodeData>();
      for (var i = 0; i < names.Count; i++) {
        nodeDataSource.Add(new NodeData {
          Key = i, Text = names[i], Color = Brush.RandomColor(128, 240)
        });
      }

      var rand = new Random();

      var linkDataSource = new List<LinkData>();
      var num = nodeDataSource.Count;
      for (var i = 0; i < num * 2; i++) {
        var a = rand.Next(num);
        var b = rand.Next(num / 4) + 1;
        linkDataSource.Add(new LinkData {
          From = a, To = (a + b) % num, Color = Brush.RandomColor(0, 127)
        });
      }

      diagramControl1.Diagram.Model = new Model {
        NodeDataSource = nodeDataSource,
        LinkDataSource = linkDataSource
      };

      // layout based on a random person
      var someone = nodeDataSource[rand.Next(nodeDataSource.Count)];
      var somenode = diagramControl1.Diagram.FindNodeForData(someone);
      nodeClicked(null, somenode);
    }

    private void nodeClicked(object e, object root) {
      var rootNode = root as Node;
      var diagram = rootNode.Diagram;
      if (diagram == null) return;
      // all other nodes should be visible and use the default category
      foreach (var n in diagram.Nodes) {
        n.Visible = true;
        if (n != rootNode) n.Category = "";
      }
      // make this Node the root
      rootNode.Category = "Root";
      // the root node always gets a full circle for itself, just in case the "Root"
      // template has any bindings using these properties
      diagram.Model.Set(rootNode.Data, "Angle", 0);
      diagram.Model.Set(rootNode.Data, "Sweep", 360);
      diagram.Model.Set(rootNode.Data, "Radius", 0);
      // tell the RadialLayout what the root node should be
      // setting this property will automatically invalidate the layout and then perform ita gain
      (diagram.Layout as RadialPartitionLayout).Root = rootNode;
    }

  }

  public class Model : GraphLinksModel<NodeData, int, object, LinkData, int, string> { }

  public class NodeData : Model.NodeData {
    public string Color { get; set; }
    public double Angle { get; set; }
    public double Sweep { get; set; }
    public double Radius { get; set; }
  }

  public class LinkData : Model.LinkData {
    public string Color { get; set; }
  }

  // A custom RadialLayout that centers all radial Nodes at the origin.
  // The base RadialLayout class is an imported Extension.
  public class RadialPartitionLayout : RadialLayout {
    public override void RotateNode(Node node, double angle, double sweep, double radius) {
      // all nodes are centered at the origin
      node.Location = ArrangementOrigin;
      // because the Shape.geometry will be centered at the origin --
      // see makeAnnularWedge, below
      node.Diagram.Model.Set(node.Data, "Angle", angle);
      node.Diagram.Model.Set(node.Data, "Sweep", sweep);
      node.Diagram.Model.Set(node.Data, "Radius", radius);
    }
  }

}