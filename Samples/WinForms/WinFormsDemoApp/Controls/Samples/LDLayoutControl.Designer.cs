/* Copyright (c) Northwoods Software Corporation. */

namespace Demo.Samples.LDLayout {
  partial class LDLayout {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
      label1 = new System.Windows.Forms.Label();
      label2 = new System.Windows.Forms.Label();
      minNodes = new System.Windows.Forms.TextBox();
      label3 = new System.Windows.Forms.Label();
      maxNodes = new System.Windows.Forms.TextBox();
      generateBtn = new System.Windows.Forms.Button();
      flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
      label4 = new System.Windows.Forms.Label();
      label5 = new System.Windows.Forms.Label();
      direction = new System.Windows.Forms.FlowLayoutPanel();
      right = new System.Windows.Forms.RadioButton();
      down = new System.Windows.Forms.RadioButton();
      left = new System.Windows.Forms.RadioButton();
      up = new System.Windows.Forms.RadioButton();
      label6 = new System.Windows.Forms.Label();
      layerSpacing = new System.Windows.Forms.TextBox();
      label7 = new System.Windows.Forms.Label();
      columnSpacing = new System.Windows.Forms.TextBox();
      label8 = new System.Windows.Forms.Label();
      cycleRemove = new System.Windows.Forms.FlowLayoutPanel();
      depthFirst = new System.Windows.Forms.RadioButton();
      greedy = new System.Windows.Forms.RadioButton();
      label9 = new System.Windows.Forms.Label();
      layering = new System.Windows.Forms.FlowLayoutPanel();
      optimalLinkLength = new System.Windows.Forms.RadioButton();
      longestPathSource = new System.Windows.Forms.RadioButton();
      longestPathSink = new System.Windows.Forms.RadioButton();
      label10 = new System.Windows.Forms.Label();
      initialize = new System.Windows.Forms.FlowLayoutPanel();
      depthFirstOut = new System.Windows.Forms.RadioButton();
      depthFirstIn = new System.Windows.Forms.RadioButton();
      naive = new System.Windows.Forms.RadioButton();
      label11 = new System.Windows.Forms.Label();
      aggressive = new System.Windows.Forms.FlowLayoutPanel();
      none = new System.Windows.Forms.RadioButton();
      less = new System.Windows.Forms.RadioButton();
      more = new System.Windows.Forms.RadioButton();
      label12 = new System.Windows.Forms.Label();
      median = new System.Windows.Forms.CheckBox();
      straighten = new System.Windows.Forms.CheckBox();
      expand = new System.Windows.Forms.CheckBox();
      label13 = new System.Windows.Forms.Label();
      upperLeft = new System.Windows.Forms.CheckBox();
      upperRight = new System.Windows.Forms.CheckBox();
      lowerLeft = new System.Windows.Forms.CheckBox();
      lowerRight = new System.Windows.Forms.CheckBox();
      setsPortSpots = new System.Windows.Forms.CheckBox();
      diagramControl1 = new Northwoods.Go.WinForms.DiagramControl();
      desc1 = new WinFormsDemoApp.GoWebBrowser();
      tableLayoutPanel1.SuspendLayout();
      flowLayoutPanel1.SuspendLayout();
      flowLayoutPanel2.SuspendLayout();
      flowLayoutPanel3.SuspendLayout();
      direction.SuspendLayout();
      cycleRemove.SuspendLayout();
      layering.SuspendLayout();
      initialize.SuspendLayout();
      aggressive.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)desc1).BeginInit();
      SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      tableLayoutPanel1.AutoScroll = true;
      tableLayoutPanel1.ColumnCount = 1;
      tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
      tableLayoutPanel1.Controls.Add(diagramControl1, 0, 1);
      tableLayoutPanel1.Controls.Add(desc1, 0, 2);
      tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
      tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      tableLayoutPanel1.Name = "tableLayoutPanel1";
      tableLayoutPanel1.RowCount = 3;
      tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      tableLayoutPanel1.Size = new System.Drawing.Size(1000, 923);
      tableLayoutPanel1.TabIndex = 0;
      // 
      // flowLayoutPanel1
      // 
      flowLayoutPanel1.AutoSize = true;
      flowLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
      flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
      flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
      flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
      flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
      flowLayoutPanel1.Name = "flowLayoutPanel1";
      flowLayoutPanel1.Size = new System.Drawing.Size(994, 331);
      flowLayoutPanel1.TabIndex = 4;
      // 
      // flowLayoutPanel2
      // 
      flowLayoutPanel2.AutoSize = true;
      flowLayoutPanel2.Controls.Add(label1);
      flowLayoutPanel2.Controls.Add(label2);
      flowLayoutPanel2.Controls.Add(minNodes);
      flowLayoutPanel2.Controls.Add(label3);
      flowLayoutPanel2.Controls.Add(maxNodes);
      flowLayoutPanel2.Controls.Add(generateBtn);
      flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
      flowLayoutPanel2.Name = "flowLayoutPanel2";
      flowLayoutPanel2.Size = new System.Drawing.Size(191, 112);
      flowLayoutPanel2.TabIndex = 0;
      // 
      // label1
      // 
      label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      label1.AutoSize = true;
      flowLayoutPanel2.SetFlowBreak(label1, true);
      label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      label1.Location = new System.Drawing.Point(3, 0);
      label1.Name = "label1";
      label1.Size = new System.Drawing.Size(76, 17);
      label1.TabIndex = 0;
      label1.Text = "New Graph";
      // 
      // label2
      // 
      label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      label2.AutoSize = true;
      label2.Location = new System.Drawing.Point(3, 24);
      label2.Name = "label2";
      label2.Size = new System.Drawing.Size(76, 17);
      label2.TabIndex = 1;
      label2.Text = "Min Nodes:";
      // 
      // minNodes
      // 
      flowLayoutPanel2.SetFlowBreak(minNodes, true);
      minNodes.Location = new System.Drawing.Point(85, 20);
      minNodes.Name = "minNodes";
      minNodes.Size = new System.Drawing.Size(100, 25);
      minNodes.TabIndex = 2;
      minNodes.Text = "20";
      // 
      // label3
      // 
      label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
      label3.AutoSize = true;
      label3.Location = new System.Drawing.Point(3, 55);
      label3.Name = "label3";
      label3.Size = new System.Drawing.Size(79, 17);
      label3.TabIndex = 3;
      label3.Text = "Max Nodes:";
      // 
      // maxNodes
      // 
      flowLayoutPanel2.SetFlowBreak(maxNodes, true);
      maxNodes.Location = new System.Drawing.Point(88, 51);
      maxNodes.Name = "maxNodes";
      maxNodes.Size = new System.Drawing.Size(100, 25);
      maxNodes.TabIndex = 4;
      maxNodes.Text = "100";
      // 
      // generateBtn
      // 
      generateBtn.AutoSize = true;
      generateBtn.Location = new System.Drawing.Point(3, 82);
      generateBtn.Name = "generateBtn";
      generateBtn.Size = new System.Drawing.Size(122, 27);
      generateBtn.TabIndex = 5;
      generateBtn.Text = "Generate Digraph";
      generateBtn.UseVisualStyleBackColor = true;
      // 
      // flowLayoutPanel3
      // 
      flowLayoutPanel3.AutoSize = true;
      flowLayoutPanel3.Controls.Add(label4);
      flowLayoutPanel3.Controls.Add(label5);
      flowLayoutPanel3.Controls.Add(direction);
      flowLayoutPanel3.Controls.Add(label6);
      flowLayoutPanel3.Controls.Add(layerSpacing);
      flowLayoutPanel3.Controls.Add(label7);
      flowLayoutPanel3.Controls.Add(columnSpacing);
      flowLayoutPanel3.Controls.Add(label8);
      flowLayoutPanel3.Controls.Add(cycleRemove);
      flowLayoutPanel3.Controls.Add(label9);
      flowLayoutPanel3.Controls.Add(layering);
      flowLayoutPanel3.Controls.Add(label10);
      flowLayoutPanel3.Controls.Add(initialize);
      flowLayoutPanel3.Controls.Add(label11);
      flowLayoutPanel3.Controls.Add(aggressive);
      flowLayoutPanel3.Controls.Add(label12);
      flowLayoutPanel3.Controls.Add(median);
      flowLayoutPanel3.Controls.Add(straighten);
      flowLayoutPanel3.Controls.Add(expand);
      flowLayoutPanel3.Controls.Add(label13);
      flowLayoutPanel3.Controls.Add(upperLeft);
      flowLayoutPanel3.Controls.Add(upperRight);
      flowLayoutPanel3.Controls.Add(lowerLeft);
      flowLayoutPanel3.Controls.Add(lowerRight);
      flowLayoutPanel3.Controls.Add(setsPortSpots);
      flowLayoutPanel3.Location = new System.Drawing.Point(200, 3);
      flowLayoutPanel3.Name = "flowLayoutPanel3";
      flowLayoutPanel3.Size = new System.Drawing.Size(480, 325);
      flowLayoutPanel3.TabIndex = 1;
      // 
      // label4
      // 
      label4.AutoSize = true;
      flowLayoutPanel3.SetFlowBreak(label4, true);
      label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
      label4.Location = new System.Drawing.Point(3, 0);
      label4.Name = "label4";
      label4.Size = new System.Drawing.Size(215, 17);
      label4.TabIndex = 0;
      label4.Text = "LayeredDigraphLayout Properties";
      // 
      // label5
      // 
      label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
      label5.AutoSize = true;
      label5.Location = new System.Drawing.Point(3, 25);
      label5.Name = "label5";
      label5.Size = new System.Drawing.Size(63, 17);
      label5.TabIndex = 1;
      label5.Text = "Direction:";
      // 
      // direction
      // 
      direction.AutoSize = true;
      direction.Controls.Add(right);
      direction.Controls.Add(down);
      direction.Controls.Add(left);
      direction.Controls.Add(up);
      flowLayoutPanel3.SetFlowBreak(direction, true);
      direction.Location = new System.Drawing.Point(72, 20);
      direction.Name = "direction";
      direction.Size = new System.Drawing.Size(340, 27);
      direction.TabIndex = 2;
      // 
      // right
      // 
      right.AutoSize = true;
      right.Checked = true;
      right.Location = new System.Drawing.Point(3, 3);
      right.Name = "right";
      right.Size = new System.Drawing.Size(75, 21);
      right.TabIndex = 0;
      right.TabStop = true;
      right.Text = "Right (0)";
      right.UseVisualStyleBackColor = true;
      // 
      // down
      // 
      down.AutoSize = true;
      down.Location = new System.Drawing.Point(84, 3);
      down.Name = "down";
      down.Size = new System.Drawing.Size(85, 21);
      down.TabIndex = 1;
      down.Text = "Down (90)";
      down.UseVisualStyleBackColor = true;
      // 
      // left
      // 
      left.AutoSize = true;
      left.Location = new System.Drawing.Point(175, 3);
      left.Name = "left";
      left.Size = new System.Drawing.Size(80, 21);
      left.TabIndex = 2;
      left.Text = "Left (180)";
      left.UseVisualStyleBackColor = true;
      // 
      // up
      // 
      up.AutoSize = true;
      up.Location = new System.Drawing.Point(261, 3);
      up.Name = "up";
      up.Size = new System.Drawing.Size(76, 21);
      up.TabIndex = 3;
      up.Text = "Up (270)";
      up.UseVisualStyleBackColor = true;
      // 
      // label6
      // 
      label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
      label6.AutoSize = true;
      label6.Location = new System.Drawing.Point(3, 57);
      label6.Name = "label6";
      label6.Size = new System.Drawing.Size(88, 17);
      label6.TabIndex = 3;
      label6.Text = "LayerSpacing:";
      // 
      // layerSpacing
      // 
      flowLayoutPanel3.SetFlowBreak(layerSpacing, true);
      layerSpacing.Location = new System.Drawing.Point(97, 53);
      layerSpacing.Name = "layerSpacing";
      layerSpacing.Size = new System.Drawing.Size(100, 25);
      layerSpacing.TabIndex = 4;
      layerSpacing.Text = "25";
      // 
      // label7
      // 
      label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
      label7.AutoSize = true;
      label7.Location = new System.Drawing.Point(3, 88);
      label7.Name = "label7";
      label7.Size = new System.Drawing.Size(101, 17);
      label7.TabIndex = 5;
      label7.Text = "ColumnSpacing:";
      // 
      // columnSpacing
      // 
      flowLayoutPanel3.SetFlowBreak(columnSpacing, true);
      columnSpacing.Location = new System.Drawing.Point(110, 84);
      columnSpacing.Name = "columnSpacing";
      columnSpacing.Size = new System.Drawing.Size(100, 25);
      columnSpacing.TabIndex = 6;
      columnSpacing.Text = "25";
      // 
      // label8
      // 
      label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
      label8.AutoSize = true;
      label8.Location = new System.Drawing.Point(3, 120);
      label8.Name = "label8";
      label8.Size = new System.Drawing.Size(88, 17);
      label8.TabIndex = 7;
      label8.Text = "CycleRemove:";
      // 
      // cycleRemove
      // 
      cycleRemove.AutoSize = true;
      cycleRemove.Controls.Add(depthFirst);
      cycleRemove.Controls.Add(greedy);
      flowLayoutPanel3.SetFlowBreak(cycleRemove, true);
      cycleRemove.Location = new System.Drawing.Point(97, 115);
      cycleRemove.Name = "cycleRemove";
      cycleRemove.Size = new System.Drawing.Size(165, 27);
      cycleRemove.TabIndex = 8;
      // 
      // depthFirst
      // 
      depthFirst.AutoSize = true;
      depthFirst.Checked = true;
      depthFirst.Location = new System.Drawing.Point(3, 3);
      depthFirst.Name = "depthFirst";
      depthFirst.Size = new System.Drawing.Size(85, 21);
      depthFirst.TabIndex = 0;
      depthFirst.TabStop = true;
      depthFirst.Text = "DepthFirst";
      depthFirst.UseVisualStyleBackColor = true;
      // 
      // greedy
      // 
      greedy.AutoSize = true;
      greedy.Location = new System.Drawing.Point(94, 3);
      greedy.Name = "greedy";
      greedy.Size = new System.Drawing.Size(68, 21);
      greedy.TabIndex = 1;
      greedy.Text = "Greedy";
      greedy.UseVisualStyleBackColor = true;
      // 
      // label9
      // 
      label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
      label9.AutoSize = true;
      label9.Location = new System.Drawing.Point(3, 153);
      label9.Name = "label9";
      label9.Size = new System.Drawing.Size(60, 17);
      label9.TabIndex = 9;
      label9.Text = "Layering:";
      // 
      // layering
      // 
      layering.AutoSize = true;
      layering.Controls.Add(optimalLinkLength);
      layering.Controls.Add(longestPathSource);
      layering.Controls.Add(longestPathSink);
      flowLayoutPanel3.SetFlowBreak(layering, true);
      layering.Location = new System.Drawing.Point(69, 148);
      layering.Name = "layering";
      layering.Size = new System.Drawing.Size(408, 27);
      layering.TabIndex = 10;
      // 
      // optimalLinkLength
      // 
      optimalLinkLength.AutoSize = true;
      optimalLinkLength.Checked = true;
      optimalLinkLength.Location = new System.Drawing.Point(3, 3);
      optimalLinkLength.Name = "optimalLinkLength";
      optimalLinkLength.Size = new System.Drawing.Size(133, 21);
      optimalLinkLength.TabIndex = 0;
      optimalLinkLength.TabStop = true;
      optimalLinkLength.Text = "OptimalLinkLength";
      optimalLinkLength.UseVisualStyleBackColor = true;
      // 
      // longestPathSource
      // 
      longestPathSource.AutoSize = true;
      longestPathSource.Location = new System.Drawing.Point(142, 3);
      longestPathSource.Name = "longestPathSource";
      longestPathSource.Size = new System.Drawing.Size(137, 21);
      longestPathSource.TabIndex = 1;
      longestPathSource.Text = "LongestPathSource";
      longestPathSource.UseVisualStyleBackColor = true;
      // 
      // longestPathSink
      // 
      longestPathSink.AutoSize = true;
      longestPathSink.Location = new System.Drawing.Point(285, 3);
      longestPathSink.Name = "longestPathSink";
      longestPathSink.Size = new System.Drawing.Size(120, 21);
      longestPathSink.TabIndex = 2;
      longestPathSink.Text = "LongestPathSink";
      longestPathSink.UseVisualStyleBackColor = true;
      // 
      // label10
      // 
      label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
      label10.AutoSize = true;
      label10.Location = new System.Drawing.Point(3, 186);
      label10.Name = "label10";
      label10.Size = new System.Drawing.Size(57, 17);
      label10.TabIndex = 11;
      label10.Text = "Initialize:";
      // 
      // initialize
      // 
      initialize.AutoSize = true;
      initialize.Controls.Add(depthFirstOut);
      initialize.Controls.Add(depthFirstIn);
      initialize.Controls.Add(naive);
      flowLayoutPanel3.SetFlowBreak(initialize, true);
      initialize.Location = new System.Drawing.Point(66, 181);
      initialize.Name = "initialize";
      initialize.Size = new System.Drawing.Size(278, 27);
      initialize.TabIndex = 12;
      // 
      // depthFirstOut
      // 
      depthFirstOut.AutoSize = true;
      depthFirstOut.Checked = true;
      depthFirstOut.Location = new System.Drawing.Point(3, 3);
      depthFirstOut.Name = "depthFirstOut";
      depthFirstOut.Size = new System.Drawing.Size(106, 21);
      depthFirstOut.TabIndex = 0;
      depthFirstOut.TabStop = true;
      depthFirstOut.Text = "DepthFirstOut";
      depthFirstOut.UseVisualStyleBackColor = true;
      // 
      // depthFirstIn
      // 
      depthFirstIn.AutoSize = true;
      depthFirstIn.Location = new System.Drawing.Point(115, 3);
      depthFirstIn.Name = "depthFirstIn";
      depthFirstIn.Size = new System.Drawing.Size(95, 21);
      depthFirstIn.TabIndex = 1;
      depthFirstIn.Text = "DepthFirstIn";
      depthFirstIn.UseVisualStyleBackColor = true;
      // 
      // naive
      // 
      naive.AutoSize = true;
      naive.Location = new System.Drawing.Point(216, 3);
      naive.Name = "naive";
      naive.Size = new System.Drawing.Size(59, 21);
      naive.TabIndex = 2;
      naive.Text = "Naive";
      naive.UseVisualStyleBackColor = true;
      // 
      // label11
      // 
      label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
      label11.AutoSize = true;
      label11.Location = new System.Drawing.Point(3, 219);
      label11.Name = "label11";
      label11.Size = new System.Drawing.Size(75, 17);
      label11.TabIndex = 13;
      label11.Text = "Aggressive:";
      // 
      // aggressive
      // 
      aggressive.AutoSize = true;
      aggressive.Controls.Add(none);
      aggressive.Controls.Add(less);
      aggressive.Controls.Add(more);
      flowLayoutPanel3.SetFlowBreak(aggressive, true);
      aggressive.Location = new System.Drawing.Point(84, 214);
      aggressive.Name = "aggressive";
      aggressive.Size = new System.Drawing.Size(185, 27);
      aggressive.TabIndex = 14;
      // 
      // none
      // 
      none.AutoSize = true;
      none.Location = new System.Drawing.Point(3, 3);
      none.Name = "none";
      none.Size = new System.Drawing.Size(58, 21);
      none.TabIndex = 0;
      none.Text = "None";
      none.UseVisualStyleBackColor = true;
      // 
      // less
      // 
      less.AutoSize = true;
      less.Checked = true;
      less.Location = new System.Drawing.Point(67, 3);
      less.Name = "less";
      less.Size = new System.Drawing.Size(51, 21);
      less.TabIndex = 1;
      less.TabStop = true;
      less.Text = "Less";
      less.UseVisualStyleBackColor = true;
      // 
      // more
      // 
      more.AutoSize = true;
      more.Location = new System.Drawing.Point(124, 3);
      more.Name = "more";
      more.Size = new System.Drawing.Size(58, 21);
      more.TabIndex = 2;
      more.Text = "More";
      more.UseVisualStyleBackColor = true;
      // 
      // label12
      // 
      label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
      label12.AutoSize = true;
      label12.Location = new System.Drawing.Point(3, 249);
      label12.Name = "label12";
      label12.Size = new System.Drawing.Size(37, 17);
      label12.TabIndex = 15;
      label12.Text = "Pack:";
      // 
      // median
      // 
      median.AutoSize = true;
      median.Checked = true;
      median.CheckState = System.Windows.Forms.CheckState.Checked;
      median.Location = new System.Drawing.Point(46, 247);
      median.Name = "median";
      median.Size = new System.Drawing.Size(71, 21);
      median.TabIndex = 16;
      median.Text = "Median";
      median.UseVisualStyleBackColor = true;
      // 
      // straighten
      // 
      straighten.AutoSize = true;
      straighten.Checked = true;
      straighten.CheckState = System.Windows.Forms.CheckState.Checked;
      straighten.Location = new System.Drawing.Point(123, 247);
      straighten.Name = "straighten";
      straighten.Size = new System.Drawing.Size(86, 21);
      straighten.TabIndex = 17;
      straighten.Text = "Straighten";
      straighten.UseVisualStyleBackColor = true;
      // 
      // expand
      // 
      expand.AutoSize = true;
      expand.Checked = true;
      expand.CheckState = System.Windows.Forms.CheckState.Checked;
      flowLayoutPanel3.SetFlowBreak(expand, true);
      expand.Location = new System.Drawing.Point(215, 247);
      expand.Name = "expand";
      expand.Size = new System.Drawing.Size(70, 21);
      expand.TabIndex = 18;
      expand.Text = "Expand";
      expand.UseVisualStyleBackColor = true;
      // 
      // label13
      // 
      label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
      label13.AutoSize = true;
      label13.Location = new System.Drawing.Point(3, 276);
      label13.Name = "label13";
      label13.Size = new System.Drawing.Size(40, 17);
      label13.TabIndex = 19;
      label13.Text = "Align:";
      // 
      // upperLeft
      // 
      upperLeft.AutoSize = true;
      upperLeft.Checked = true;
      upperLeft.CheckState = System.Windows.Forms.CheckState.Checked;
      upperLeft.Location = new System.Drawing.Point(49, 274);
      upperLeft.Name = "upperLeft";
      upperLeft.Size = new System.Drawing.Size(85, 21);
      upperLeft.TabIndex = 20;
      upperLeft.Text = "UpperLeft";
      upperLeft.UseVisualStyleBackColor = true;
      // 
      // upperRight
      // 
      upperRight.AutoSize = true;
      upperRight.Checked = true;
      upperRight.CheckState = System.Windows.Forms.CheckState.Checked;
      upperRight.Location = new System.Drawing.Point(140, 274);
      upperRight.Name = "upperRight";
      upperRight.Size = new System.Drawing.Size(94, 21);
      upperRight.TabIndex = 21;
      upperRight.Text = "UpperRight";
      upperRight.UseVisualStyleBackColor = true;
      // 
      // lowerLeft
      // 
      lowerLeft.AutoSize = true;
      lowerLeft.Checked = true;
      lowerLeft.CheckState = System.Windows.Forms.CheckState.Checked;
      lowerLeft.Location = new System.Drawing.Point(240, 274);
      lowerLeft.Name = "lowerLeft";
      lowerLeft.Size = new System.Drawing.Size(83, 21);
      lowerLeft.TabIndex = 22;
      lowerLeft.Text = "LowerLeft";
      lowerLeft.UseVisualStyleBackColor = true;
      // 
      // lowerRight
      // 
      lowerRight.AutoSize = true;
      lowerRight.Checked = true;
      lowerRight.CheckState = System.Windows.Forms.CheckState.Checked;
      flowLayoutPanel3.SetFlowBreak(lowerRight, true);
      lowerRight.Location = new System.Drawing.Point(329, 274);
      lowerRight.Name = "lowerRight";
      lowerRight.Size = new System.Drawing.Size(92, 21);
      lowerRight.TabIndex = 23;
      lowerRight.Text = "LowerRight";
      lowerRight.UseVisualStyleBackColor = true;
      // 
      // setsPortSpots
      // 
      setsPortSpots.AutoSize = true;
      setsPortSpots.Checked = true;
      setsPortSpots.CheckState = System.Windows.Forms.CheckState.Checked;
      setsPortSpots.Location = new System.Drawing.Point(3, 301);
      setsPortSpots.Name = "setsPortSpots";
      setsPortSpots.Size = new System.Drawing.Size(108, 21);
      setsPortSpots.TabIndex = 24;
      setsPortSpots.Text = "SetsPortSpots";
      setsPortSpots.UseVisualStyleBackColor = true;
      // 
      // diagramControl1
      // 
      diagramControl1.AllowDrop = true;
      diagramControl1.BackColor = System.Drawing.Color.White;
      diagramControl1.Dock = System.Windows.Forms.DockStyle.Top;
      diagramControl1.Location = new System.Drawing.Point(4, 340);
      diagramControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      diagramControl1.Name = "diagramControl1";
      diagramControl1.Size = new System.Drawing.Size(992, 494);
      diagramControl1.TabIndex = 2;
      // 
      // desc1
      // 
      desc1.AllowExternalDrop = true;
      desc1.CreationProperties = null;
      desc1.DefaultBackgroundColor = System.Drawing.Color.White;
      desc1.Dock = System.Windows.Forms.DockStyle.Top;
      desc1.Location = new System.Drawing.Point(3, 840);
      desc1.Name = "desc1";
      desc1.Size = new System.Drawing.Size(994, 60);
      desc1.TabIndex = 3;
      desc1.ZoomFactor = 1D;
      // 
      // LDLayout
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      Controls.Add(tableLayoutPanel1);
      Name = "LDLayout";
      Size = new System.Drawing.Size(1000, 923);
      tableLayoutPanel1.ResumeLayout(false);
      tableLayoutPanel1.PerformLayout();
      flowLayoutPanel1.ResumeLayout(false);
      flowLayoutPanel1.PerformLayout();
      flowLayoutPanel2.ResumeLayout(false);
      flowLayoutPanel2.PerformLayout();
      flowLayoutPanel3.ResumeLayout(false);
      flowLayoutPanel3.PerformLayout();
      direction.ResumeLayout(false);
      direction.PerformLayout();
      cycleRemove.ResumeLayout(false);
      cycleRemove.PerformLayout();
      layering.ResumeLayout(false);
      layering.PerformLayout();
      initialize.ResumeLayout(false);
      initialize.PerformLayout();
      aggressive.ResumeLayout(false);
      aggressive.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)desc1).EndInit();
      ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private Northwoods.Go.WinForms.DiagramControl diagramControl1;
    private WinFormsDemoApp.GoWebBrowser desc1;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox minNodes;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox maxNodes;
    private System.Windows.Forms.Button generateBtn;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.FlowLayoutPanel direction;
    private System.Windows.Forms.RadioButton right;
    private System.Windows.Forms.RadioButton down;
    private System.Windows.Forms.RadioButton left;
    private System.Windows.Forms.RadioButton up;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox layerSpacing;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox columnSpacing;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.FlowLayoutPanel cycleRemove;
    private System.Windows.Forms.RadioButton depthFirst;
    private System.Windows.Forms.RadioButton greedy;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.FlowLayoutPanel layering;
    private System.Windows.Forms.RadioButton optimalLinkLength;
    private System.Windows.Forms.RadioButton longestPathSource;
    private System.Windows.Forms.RadioButton longestPathSink;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.FlowLayoutPanel initialize;
    private System.Windows.Forms.RadioButton depthFirstOut;
    private System.Windows.Forms.RadioButton depthFirstIn;
    private System.Windows.Forms.RadioButton naive;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.FlowLayoutPanel aggressive;
    private System.Windows.Forms.RadioButton none;
    private System.Windows.Forms.RadioButton less;
    private System.Windows.Forms.RadioButton more;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.CheckBox median;
    private System.Windows.Forms.CheckBox straighten;
    private System.Windows.Forms.CheckBox expand;
    private System.Windows.Forms.CheckBox setsPortSpots;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.CheckBox upperLeft;
    private System.Windows.Forms.CheckBox upperRight;
    private System.Windows.Forms.CheckBox lowerLeft;
    private System.Windows.Forms.CheckBox lowerRight;
  }
}
