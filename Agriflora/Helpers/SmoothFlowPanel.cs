using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Agriflora.Helpers
{
    public class SmoothFlowPanel : FlowLayoutPanel
    {
        // Windows API to show/hide scrollbars
        [DllImport("user32.dll")]
        private static extern int ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);

        private const int SB_HORZ = 0; // horizontal scrollbar
        private const int SB_VERT = 1; // vertical scrollbar
        private const int SB_BOTH = 3; // both scrollbars

        public SmoothFlowPanel()
        {
            // enable mouse wheel scrolling
            this.MouseWheel += SmoothFlowPanel_MouseWheel;
        }

        // hide scrollbars every time the panel redraws
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            ShowScrollBar(this.Handle, SB_BOTH, false);
        }

        // allow scrolling with mouse wheel
        private void SmoothFlowPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            int scrollAmount = e.Delta > 0 ? -60 : 60;
            this.VerticalScroll.Value = Math.Max(
                this.VerticalScroll.Minimum,
                Math.Min(
                    this.VerticalScroll.Maximum,
                    this.VerticalScroll.Value + scrollAmount
                )
            );
            this.PerformLayout();
        }
    }
}
