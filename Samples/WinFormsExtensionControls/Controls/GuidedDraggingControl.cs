﻿using System.Collections.Generic;
using System.ComponentModel;
using Northwoods.Go;
using Northwoods.Go.Models;
using Northwoods.Go.Tools.Extensions;

namespace WinFormsExtensionControls.GuidedDragging {
  [ToolboxItem(false)]
  public partial class GuidedDraggingControl : System.Windows.Forms.UserControl {
    private Diagram myDiagram;
    
    public GuidedDraggingControl() {
      InitializeComponent();

      diagramControl1.AfterRender = Setup;

      goWebBrowser1.Html = @"
   <p>
    This custom <a>DraggingTool</a> class makes guidelines visible as a Part is dragged around a Diagram and is nearly aligned with another Part.
    If a locationObjectName is set, then this aligns <a>Part.locationObject</a>s instead.
    The tool is defined in its own file, as <a href=""GuidedDraggingTool.js"">GuidedDraggingTool.js</a>.
  </p>
  <p>
    Usage can also be seen in the <a href = ""FloorPlanEditor.html""> Floor Plan Editor</a> sample.
  </p>
";

    }

    private void Setup() {
      myDiagram = diagramControl1.Diagram;

      // defined in GuidedDraggingTool.cs
      myDiagram.ToolManager.DraggingTool = new GuidedDraggingTool {
        HorizontalGuidelineColor = "blue",
        VerticalGuidelineColor = "blue",
        CenterGuidelineColor = "green",
        GuidelineWidth = 1
      };
      myDiagram.UndoManager.IsEnabled = true;  // enable undo & redo

      // define a simple Node template
      myDiagram.NodeTemplate =
        new Node(PanelLayoutAuto.Instance).Add(  // the Shape will go around the TextBlock
          new Shape {
            Figure = "RoundedRectangle",
            StrokeWidth = 0
          }.Bind("Fill", "Color"),  // Shape.Fill is bound to Node.Data.Color
          new TextBlock {
            Margin = 8  // some room around the text
          }.Bind("Text", "Key")  // TextBlock.Text is bound to Node.Data.Key
        );

      // but use the default Link template, by not setting Diagram.LinkTemplate

      // Create the Diagram's Model:
      myDiagram.Model = new Model {
        NodeDataSource = new List<NodeData> {
          new NodeData { Key = "Alpha", Color = "lightblue" },
          new NodeData { Key = "Beta", Color = "orange" },
          new NodeData { Key = "Gamma", Color = "lightgreen" },
          new NodeData { Key = "Delta", Color = "pink" }
        },
        LinkDataSource = new List<LinkData> {
          new LinkData { From = "Alpha", To = "Beta" },
          new LinkData { From = "Alpha", To = "Gamma" },
          new LinkData { From = "Beta", To = "Beta" },
          new LinkData { From = "Gamma", To = "Delta" },
          new LinkData { From = "Delta", To = "Alpha" }
        }
      };
    }

  }

  // define the model types
  public class Model : GraphLinksModel<NodeData, string, object, LinkData, string, string> { }

  public class NodeData : Model.NodeData {
    public Brush Color { get; set; }
  }

  public class LinkData : Model.LinkData { }

}