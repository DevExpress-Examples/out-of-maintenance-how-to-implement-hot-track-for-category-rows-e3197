using System;
using System.Windows.Forms;
using DevExpress.XtraVerticalGrid.Events;
using System.Drawing;
using DevExpress.XtraVerticalGrid.Rows;
using DevExpress.XtraVerticalGrid;
using DevExpress.Utils;
using DevExpress.Utils.Paint;
using DevExpress.XtraVerticalGrid.ViewInfo;

namespace VerticalGridGroupHotTrack {
    public partial class Form1 :Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nwindDataSet.Products);

        }

        private void OnCustomDrawRowHeaderCell(object sender, CustomDrawRowHeaderCellEventArgs e) {
            Point hitPoint = MousePosition;
            //if (!(e.Row is CategoryRow)) return;
            VGridControl grid = (VGridControl)sender;
            VGridHitInfo hitInfo = ((VGridControl)sender).CalcHitInfo(grid.PointToClient(hitPoint));
            if (hitInfo.Row != e.Row) return;
            BaseRowViewInfo rowInfo = null;
            foreach (BaseRowViewInfo info in grid.ViewInfo.RowsViewInfo) {
                if (info is CategoryRowViewInfo) continue;
                rowInfo = info;
                break;
            }
            if (rowInfo == null) return;
            RowValueInfo valueInfo = null;
            foreach (RowValueInfo info in rowInfo.ValuesInfo)
                if (info.Bounds.X < hitInfo.PtMouse.X &&
                    info.Bounds.Right > hitInfo.PtMouse.X) {
                    valueInfo = info;
                    break;
                }
            if (valueInfo == null) return;
            e.Handled = true;
            e.Appearance.DrawBackground(e.Cache, e.Bounds);
            e.Appearance.DrawString(e.Cache, e.Caption, e.CaptionRect);
            if (e.ImageIndex > 0)
                ImageCollection.DrawImageListImage(e.Cache, e.Row.Properties.Images, e.ImageIndex,
                    e.ImageRect);
            if (e.Focused)
                XPaint.Graphics.DrawFocusRectangle(e.Graphics, e.FocusRect, e.Appearance.ForeColor,
                    e.Appearance.BackColor);
            Rectangle hotTrackRect = new Rectangle(valueInfo.Bounds.X, e.Bounds.Y,
                valueInfo.Bounds.Width, e.Bounds.Height);
            hotTrackRect.Inflate(-1, -1);
            e.Graphics.FillRectangle(Brushes.AliceBlue, hotTrackRect);
            e.Graphics.DrawRectangle(Pens.Blue, hotTrackRect);
        }

        private void OnVGridControlMouseMove(object sender, MouseEventArgs e) {
            ((VGridControl)sender).Invalidate();
        }
    }
}