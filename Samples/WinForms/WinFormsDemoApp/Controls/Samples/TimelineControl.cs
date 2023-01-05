﻿/* Copyright 1998-2023 by Northwoods Software Corporation. */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Northwoods.Go;
using Northwoods.Go.Layouts;
using Northwoods.Go.Models;

namespace Demo.Samples.Timeline {
  [ToolboxItem(false)]
  public partial class TimelineControl : DemoControl {
    private Diagram myDiagram;

    public TimelineControl() {
      InitializeComponent();
      myDiagram = diagramControl1.Diagram;
      Setup();

      goWebBrowser1.Html = @"
        <p>
      This sample demonstrates an example usage of a <a href=""intro/graduatedPanels.html"">Graduated Panel</a> to draw ticks and text labels along a timeline.
        </p>

        <p>
      The Panel uses a <a>Panel.GraduatedTickUnit</a> of 1 to represent one day, and ticks are drawn at <a>Shape.Interval</a>s of 7 to represent weeks.
        </p>

        <p>
      Labels are drawn at <a>TextBlock.Interval</a>s of 14, or every two weeks. As the timeline is resized, the interval is updated to prevent overlaps.
      Text strings are generated by setting the <a>TextBlock.GraduatedFunction</a> to convert from values in the graduated range to date strings.
      Also notice that labels use the <a>GraphObject.AlignmentFocus</a>, <a>GraphObject.SegmentOrientation</a>,
      and <a>GraphObject.SegmentOffset</a> properties to place text below the timeline bar.
        </p>

        <p>
      Try resizing the timeline: select the timeline and drag the resize handle that is on the right side. Event nodes
      will automatically be laid out relative to the timeline using the <code>TimelineLayout</code>. TimelineLayout converts
      a date to a value, then uses <a>Panel.GraduatedPointForValue</a> to help determine where event nodes will be placed.
        </p>
";
    }

    private void Setup() {
      // diagram properties
      myDiagram.AnimationManager.IsEnabled = false;
      myDiagram.CommandHandler = new CustomCommandHandler();
      myDiagram.Layout = new TimelineLayout();
      myDiagram.IsTreePathToChildren = false;  // arrows from children (events) to the parent (timeline bar)

      // node template
      myDiagram.NodeTemplate =
        new Node("Table") {
            LocationSpot = Spot.Center, Movable = false
          }
          .Add(
            new Panel("Auto")
              .Add(
                new Shape("RoundedRectangle") { Fill = "#252526", Stroke = "#519ABA", StrokeWidth = 3 },
                new Panel("Table")
                  .Add(
                    new TextBlock {
                        Row = 0,
                        Stroke = "#CCCCCC",
                        Wrap = Wrap.Fit,
                        Font = new Font("Segoe UI", 12, FontWeight.Bold),
                        TextAlign = TextAlign.Center, Margin = 4
                      }
                      .Bind("Text", "Event"),
                    new TextBlock {
                        Row = 1,
                        Stroke = "#A074C4",
                        TextAlign = TextAlign.Center, Margin = 4
                      }
                      .Bind("Text", "Date", (d) => ((DateTime)d).ToShortDateString())
                  )
              )
          );

      myDiagram.NodeTemplateMap.Add("Line",
        new Node("Graduated") {
            Movable = false, Copyable = false,
            Resizable = true, ResizeElementName = "MAIN",
            Background = "transparent",
            GraduatedMin = 0,
            GraduatedMax = 365,
            GraduatedTickUnit = 1,
            ResizeAdornmentTemplate =  // only resizing at right end
              new Adornment("Spot")
                .Add(
                  new Placeholder(),
                  new Shape { Alignment = Spot.Right, Cursor = "e-resize", DesiredSize = new Size(4, 16), Fill = "lightblue", Stroke = "deepskyblue" }
                )
          }
          .Bind("GraduatedMax", "", TimelineDays)
          .Add(
            new Shape("LineH") {
                Name = "MAIN", Stroke = "#519ABA", Height = 1, StrokeWidth = 3
              }
              .Bind("Width", "Length",
                (l, shape) => { return (double)l * ((shape as Shape).Diagram.Model.SharedData as SharedData).Scale; },
                (w, data, model) => { return (double)w / (model.SharedData as SharedData).Scale; }
              ),
            new Shape { GeometryString = "M0 0 V10", Interval = 7, Stroke = "#519ABA", StrokeWidth = 2 },
            new TextBlock {
                Font = new Font("Segoe UI", 10),
                Stroke = "#CCCCCC",
                Interval = 14,
                AlignmentFocus = Spot.Right,
                SegmentOrientation = Orientation.Minus90,
                SegmentOffset = new Point(0, 12),
                GraduatedFunction = ValueToDate
              }
              .Bind("Interval", "Length", CalculateLabelInterval)
        )
      );

      object CalculateLabelInterval(object lenIn, object _) {
        var len = (double)lenIn;
        if (len >= 800) return 7;
        else if (400 <= len && len < 800) return 14;
        else if (200 <= len && len < 400) return 21;
        else if (140 <= len && len < 200) return 28;
        else if (110 <= len && len < 140) return 35;
        else return 365;
      }

      // The template for the link connecting the event node with the timeline bar node:
      myDiagram.LinkTemplate =
        new BarLink {  // defined below
            ToShortLength = 2, LayerName = "Background"
          }
          .Add(new Shape { Stroke = "#E37933", StrokeWidth = 2 });

      // model data

      var nodeDataSource = new List<NodeData> {
        new NodeData { // this defines the actual time "Line" bar
          Key = "timeline", Category = "Line",
          LineSpacing = 30,  // distance between timeline and event nodes
          Length = 700,  // the width of the timeline
          Start = new DateTime(2016, 1, 1),
          End = new DateTime(2016, 12, 31)
        },
        // the rest are just "events" --
        // you can add as much information as you want on each and extend the
        // default nodeTemplate to show as much information as you want
        new NodeData { Event = "New Year's Day", Date = new DateTime(2016, 1, 1) },
        new NodeData { Event = "MLK Jr. Day", Date = new DateTime(2016, 1, 18) },
        new NodeData { Event = "Presidents Day", Date = new DateTime(2016, 2, 15) },
        new NodeData { Event = "Memorial Day", Date = new DateTime(2016, 5, 30) },
        new NodeData { Event = "Independence Day", Date = new DateTime(2016, 7, 4) },
        new NodeData { Event = "Labor Day", Date = new DateTime(2016, 9, 5) },
        new NodeData { Event = "Columbus Day", Date = new DateTime(2016, 10, 10) },
        new NodeData { Event = "Veterans Day", Date = new DateTime(2016, 11, 11) },
        new NodeData { Event = "Thanksgiving", Date = new DateTime(2016, 11, 24) },
        new NodeData { Event = "Christmas", Date = new DateTime(2016, 12, 25) }
      };

      // prepare the model by adding links to the Line
      for (var i = 0; i < nodeDataSource.Count; i++) {
        var d = nodeDataSource[i];
        if (d.Key != "timeline") d.Parent = "timeline";
      }

      myDiagram.Model = new Model {
        SharedData = new(),
        NodeDataSource = nodeDataSource
      };
    }

    private object TimelineDays(object _, object __) {
      var timeline = myDiagram.Model.FindNodeDataForKey("timeline") as NodeData;
      var startDate = (DateTime)timeline.Start;
      var endDate = (DateTime)timeline.End;

      static int DaysBetween(DateTime startDate, DateTime endDate) {
        var timeBetween = endDate.ToUniversalTime().Subtract(startDate.ToUniversalTime());
        return timeBetween.Days;
      }

      return DaysBetween(startDate, endDate);
    }

    private string ValueToDate(double n, GraphObject _) {
      var timeline = myDiagram.Model.FindNodeDataForKey("timeline") as NodeData;
      var startDate = (DateTime)timeline.Start;
      return startDate.AddDays(n).ToShortDateString();
    }

  }

  // define the model data
  public class Model : TreeModel<NodeData, string, SharedData> { }
  public class NodeData : Model.NodeData {
    public DateTime? Date { get; set; }
    public string Event { get; set; }
    public double? LineSpacing { get; set; }
    public double? Length { get; set; }
    public DateTime? Start { get; set; }
    public DateTime? End { get; set; }
  }
  public class SharedData {
    public double Scale { get; set; } = 1;
  }

  public class CustomCommandHandler : CommandHandler {
    public override void DecreaseZoom(double factor = -1) { _ChangeScale(1 / 1.05); }
    public override void IncreaseZoom(double factor = -1) { _ChangeScale(1.05); }
    public override void ResetZoom(double newscale = -1) { _SetScale(1.0); }

    private void _ChangeScale(double factor) {
      var oldscale = (Diagram.Model.SharedData as SharedData).Scale;
      var newscale = factor != 0 ? oldscale * factor : 1;
      _SetScale(newscale);
    }

    private void _SetScale(double scale) {
      var docpt = Diagram.LastInput.DocumentPoint;
      Node line = null;
      Diagram.Commit(diag => {
        diag.Model.Set(diag.Model.SharedData, "Scale", scale);
        foreach (var n in diag.Nodes) {
          if (n.Category == "Line") {
            line = n;
            n.UpdateTargetBindings();
            continue;
          }
        }
      }, null);  // no UndoManager
      if (line != null && docpt.X > line.Position.X) {
        Diagram.Position = new Point(docpt.X - (docpt.X - line.Position.X) / scale, Diagram.Position.Y);
      }
    }
  }

  // extend layout
  public class TimelineLayout : Layout {
    // helper
    private double DateToValue(DateTime d) {
      var timeline = Diagram.Model.FindNodeDataForKey("timeline") as NodeData;
      var startDate = ((DateTime)timeline.Start).ToUniversalTime();
      var date = d.ToUniversalTime();
      var diff = date.Subtract(startDate);
      return diff.Days;
    }

    public override void DoLayout(IEnumerable<Part> coll) {
      var diagram = Diagram;
      if (diagram == null) return;

      if (coll != null) {
        coll = CollectParts(coll);
      } else if (Group != null) {
        coll = CollectParts(Group);
      } else if (diagram != null) {
        coll = CollectParts(diagram.Nodes);
      } else {
        return; // Nothing to layout!
      }

      diagram.StartTransaction("TimelineLayout");

      Part line = null;
      var parts = new List<Part>();
      var it = coll.GetEnumerator();
      while (it.MoveNext()) {
        var part = it.Current;
        if (part is Link) continue;
        if (part.Category == "Line") {
          line = part; continue;
        }
        parts.Add(part);
      }
      if (line == null) throw new Exception("No node of category 'Line' for TimelineLayout");

      line.Location = new Point(0, 0);

      // lay out the events above the timeline
      if (parts.Count > 0) {
        // determine the offset from the main shape to the timeline's boundaries
        var main = line.FindMainElement() as Shape;
        var sw = main.StrokeWidth;
        var mainOffX = main.ActualBounds.X;
        var mainOffY = main.ActualBounds.Y;
        // spacing is between the Line and the closest Nodes, defaults to 30
        var spacing = (line.Data as NodeData).LineSpacing;
        if (spacing == null) spacing = 30.0;
        for (var i = 0; i < parts.Count; i++) {
          var part = parts[i];
          var bnds = part.ActualBounds;
          var dt = (part.Data as NodeData).Date;
          var val = DateToValue((DateTime)dt);
          var pt = line.GraduatedPointForValue(val);
          var tempLoc = new Point(pt.X, pt.Y - (bnds.Height / 2) - (double)spacing);
          // check if this node will overlap with previously placed events, and offset if needed
          for (var j = 0; j < i; j++) {
            var partRect = new Rect(tempLoc.X, tempLoc.Y, bnds.Width, bnds.Height);
            var otherLoc = parts[j].Location;
            var otherBnds = parts[j].ActualBounds;
            var otherRect = new Rect(otherLoc.X, otherLoc.Y, otherBnds.Width, otherBnds.Height);
            if (partRect.Intersects(otherRect)) {
              tempLoc = tempLoc.Offset(0, -otherBnds.Height - 10);
              j = 0; // now that we have a new location, we need to recheck in case we overlap with an event we didn't overlap before
            }
          }
          part.Location = tempLoc;
        }
      }

      diagram.CommitTransaction("TimelineLayout");
    }
  }

  // extend Link
  public class BarLink : Link {
    public override Point GetLinkPoint(Node node, GraphObject port, Spot spot, bool from, bool ortho, Node othernode, GraphObject otherport) {
      var r = port.GetDocumentBounds();
      var op = otherport.GetDocumentPoint(Spot.Center);
      var main = node.Category == "Line" ? node.FindMainElement() : othernode.FindMainElement();
      var mainOffY = main.ActualBounds.Y;
      var y = r.Top;
      if (node.Category == "Line") {
        y += mainOffY;
        if (op.X < r.Left) return new Point(r.Left, y);
        if (op.X > r.Right) return new Point(r.Right, y);
        return new Point(op.X, y);
      } else {
        return new Point(r.CenterX, r.Bottom);
      }
    }
  }

}
