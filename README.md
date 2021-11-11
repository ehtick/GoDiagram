GoDiagram, a .NET Library for Diagrams
============================================

<h1><i>Note: GoDiagram is currently in pre-alpha</i></h1>

<img align="right" height="150" src="https://www.nwoods.com/images/go.png">

[GoDiagram](https://gojs.net) is a .NET library for creating and manipulating diagrams, charts, and graphs.

[![open issues](https://img.shields.io/github/issues-raw/NorthwoodsSoftware/GoDiagram.svg)](https://github.com/NorthwoodsSoftware/GoDiagram/issues)
[![last commit](https://img.shields.io/github/last-commit/NorthwoodsSoftware/GoDiagram.svg)](https://github.com/NorthwoodsSoftware/GoDiagram/commits/master)
[![Twitter Follow](https://img.shields.io/twitter/follow/NorthwoodsGo.svg?style=social&label=Follow)](https://twitter.com/NorthwoodsGo)

[Get Started with GoDiagram](https://godiagram.com/learn)


GoDiagram is a flexible library that can be used to create a number of different kinds of interactive diagrams, including data visualizations, drawing tools, and graph editors. GoDiagram includes a number of built in layouts including tree layout, force directed, radial, and layered digraph layout, and a number of custom layout examples.

Read more about GoDiagram at [godiagram.com](https://godiagram.com)

This repository contains the sources for all samples and extensions.
You can use the GitHub repository to quickly [search through all of the sources](https://github.com/NorthwoodsSoftware/GoDiagram/search?q=FindNodeDataForKey&type=Code).

<h2>Minimal Sample</h2>

Graphs are constructed by creating one or more templates, with desired properties data-bound, and adding model data.

```cs
  ...

  private void Setup() {
    _Diagram = diagramControl1.Diagram;

    // diagram properties
    _Diagram.UndoManager.IsEnabled = true;  // enable undo & redo

    // define a simple Node template
    _Diagram.NodeTemplate =
      new Node(PanelLayoutAuto.Instance)  // the Shape will go around the TextBlock
        .Add(
          new Shape("RoundedRectangle") { StrokeWidth = 0 }
            .Bind("Fill", "Color"),
          new TextBlock {
              Font = "Segoe UI, 14px, style=bold", Stroke = "#333", Margin = 8, // Specify a margin to add some room around the text
              Editable = true
            }
            .Bind("Text")
        );

    // but use the default Link template, by not setting Diagram.LinkTemplate

    // create the model data that will be represented by Nodes and Links
    _Diagram.Model = new Model {
      NodeDataSource = new List<NodeData> {
        new NodeData { Key = "n0", Text = "Alpha", Color = "lightblue" },
        new NodeData { Key = "n1", Text = "Beta", Color = "orange" },
        new NodeData { Key = "n2", Text = "Gamma", Color = "lightgreen" },
        new NodeData { Key = "n3", Text = "Delta", Color = "pink" }
      },
      LinkDataSource = new List<LinkData> {
        new LinkData { From = "n0", To = "n1" },
        new LinkData { From = "n0", To = "n2" },
        new LinkData { From = "n1", To = "n1" },
        new LinkData { From = "n2", To = "n3" },
        new LinkData { From = "n3", To = "n0" }
      }
    };
  }

  // define the model data
  public class Model : GraphLinksModel<NodeData, string, object, LinkData, string, string> { }
  public class NodeData : Model.NodeData {
    public string Color { get; set; }
  }
  public class LinkData : Model.LinkData { }

  ...
```

The above diagram and model code creates the following graph.

<img width="200" height="200" src="https://godiagram.com/assets/images/screenshots/minimal.png">


<h2>License</h2>

The GoDiagram <a href="https://godiagram.com/license.html">software license</a>.


Copyright (c) Northwoods Software Corporation