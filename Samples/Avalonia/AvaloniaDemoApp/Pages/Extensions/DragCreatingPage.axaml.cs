/* Copyright 1998-2022 by Northwoods Software Corporation. */

namespace Demo.Extensions.DragCreating {
  public partial class DragCreating : DemoControl {
    // This is a stub for the designer.
    // See the SharedSamples project for sample implementation.

    private void _InitCheckBox() {
      enabledCb.Checked += (s, e) => _EnableTool(true);
      enabledCb.Unchecked += (s, e) => _EnableTool(false);
    }
  }
}
