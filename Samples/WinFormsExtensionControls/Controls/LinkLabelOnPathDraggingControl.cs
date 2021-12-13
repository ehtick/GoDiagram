﻿using System.Collections.Generic;
using System.ComponentModel;
using Northwoods.Go;
using Northwoods.Go.Layouts;
using Northwoods.Go.Models;
using Northwoods.Go.Tools.Extensions;

namespace WinFormsExtensionControls.LinkLabelOnPathDragging {
  [ToolboxItem(false)]
  public partial class LinkLabelOnPathDraggingControl : System.Windows.Forms.UserControl {
    private Diagram myDiagram;
    
    public LinkLabelOnPathDraggingControl() {
      InitializeComponent();

      diagramControl1.AfterRender = Setup;

      goWebBrowser1.Html = @"
  <p>
    This sample demonstrates a custom Tool, LinkLabelOnPathDraggingTool, that allows the user to drag the label of a Link,
    but that keeps the label exactly on the path of the link.
    The tool is defined at <a href=""https://github.com/NorthwoodsSoftware/GoDiagram/blob/main/Extensions/Tools/LinkLabelOnPathDragging/LinkLabelOnPathDraggingTool.cs"">LinkLabelOnPathDraggingTool.cs</a>.
  </p>
  <p>
    The label on the link can be any arbitrarily complex object.
    It is positioned by the <a>GraphObject.SegmentIndex</a> and <a>GraphObject.SegmentFraction</a> properties.
    The SegmentIndex is set to NaN such that the whole link path acts as the segment, and the SegmentFraction is set by the LinkLabelOnPathDraggingTool.
    A two-way data binding on SegmentFraction automatically remembers any modified value on the link data object in the model.
  </p>
  <p>
    The tool is derived from a similar tool, <a href=""https://github.com/NorthwoodsSoftware/GoDiagram/blob/main/Extensions/Tools/LinkLabelDragging/LinkLabelDraggingTool.cs"">LinkLabelDraggingTool.cs</a>,
    that allows the user to drag the label in any direction from the mid-point of the Link path.
  </p>
";

    }

    private void Setup() {

      myDiagram = diagramControl1.Diagram;

      myDiagram.UndoManager.IsEnabled = true;
      myDiagram.Layout = new ForceDirectedLayout() { DefaultSpringLength = 50, DefaultElectricalCharge = 50 };

      // install the LinkLabelOnPathDraggingTool as a mouse-move tool
      myDiagram.ToolManager.MouseMoveTools.Insert(0, new LinkLabelOnPathDraggingTool());


      // node template
      myDiagram.NodeTemplate =
        new Node(PanelLayoutAuto.Instance) {
          LocationSpot = Spot.Center
        }.Add(
          new Shape {
            Fill = "orange",
            PortId = "",
            FromLinkable = true,
            FromSpot = Spot.AllSides,
            ToLinkable = true,
            ToSpot = Spot.AllSides,
            Cursor = "pointer"
          }.Bind(new Binding("Fill", "Color")),
          new TextBlock {
            Margin = 10,
            Font = "Segoe UI, 12px, style=bold"
          }.Bind(
            new Binding("Text")
          )
        );

      var panel =
        new Panel(PanelLayoutAuto.Instance) {
          SegmentIndex = double.NaN,
          SegmentFraction = 0.5
        }.Add(
          new Shape {
            Fill = "white"
          },
          new TextBlock {
            Text = "?",
            Margin = 3
          }.Bind(
            new Binding("Text", "Color")
          )).Bind(
          // remember any modified segment properties in the link data object
          new Binding("SegmentFraction").MakeTwoWay()
        );
      // add _IsLinkLabel ad-hoc property
      panel["_IsLinkLabel"] = true;


      // link template
      myDiagram.LinkTemplate =
        new Link {
          Routing = LinkRouting.AvoidsNodes,
          Corner = 5,
          RelinkableFrom = true,
          RelinkableTo = true,
          Reshapable = true,
          Resegmentable = true
        }.Add(
          new Shape(),
          new Shape {
            ToArrow = "OpenTriangle"
          },
          panel
        );

      // create a few nodes and links
      myDiagram.Model = new Model {
        NodeDataSource = new List<NodeData> {
          new NodeData { Key = 1, Text = "one", Color = "lightyellow" },
          new NodeData { Key = 2, Text = "two", Color = "brown" },
          new NodeData { Key = 3, Text = "three", Color = "green" },
          new NodeData { Key = 4, Text = "four", Color = "slateblue" },
          new NodeData { Key = 5, Text = "five", Color = "aquamarine" },
          new NodeData { Key = 6, Text = "six", Color = "lightgreen" },
          new NodeData { Key = 7, Text = "seven" }
        },
        LinkDataSource = new List<LinkData> {
          new LinkData { From = 5, To = 6, Color = "orange" },
          new LinkData { From = 1, To = 2, Color = "red" },
          new LinkData { From = 1, To = 3, Color = "blue" },
          new LinkData { From = 1, To = 4, Color = "goldenrod" },
          new LinkData { From = 2, To = 5, Color = "fuchsia" },
          new LinkData { From = 3, To = 5, Color = "green" },
          new LinkData { From = 4, To = 5, Color = "black" },
          new LinkData { From = 6, To = 7 },
        }
      };
    }

  }

  // define the model data
  public class Model : GraphLinksModel<NodeData, int, object, LinkData, int, string> { }
  public class NodeData : Model.NodeData {
    public string Color { get; set; }
  }
  public class LinkData : Model.LinkData {
    public string Color { get; set; }
    public double SegmentFraction { get; set; } = .5;
  }

}
