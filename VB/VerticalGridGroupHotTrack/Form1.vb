Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraVerticalGrid.Events
Imports System.Drawing
Imports DevExpress.XtraVerticalGrid.Rows
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.Utils
Imports DevExpress.Utils.Paint
Imports DevExpress.XtraVerticalGrid.ViewInfo

Namespace VerticalGridGroupHotTrack
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Products' table. You can move, or remove it, as needed.
			Me.productsTableAdapter.Fill(Me.nwindDataSet.Products)

		End Sub

		Private Sub OnCustomDrawRowHeaderCell(ByVal sender As Object, ByVal e As CustomDrawRowHeaderCellEventArgs) Handles verticalGrid.CustomDrawRowHeaderCell
			Dim hitPoint As Point = MousePosition
			'if (!(e.Row is CategoryRow)) return;
			Dim grid As VGridControl = CType(sender, VGridControl)
			Dim hitInfo As VGridHitInfo = (CType(sender, VGridControl)).CalcHitInfo(grid.PointToClient(hitPoint))
			If hitInfo.Row IsNot e.Row Then
				Return
			End If
			Dim rowInfo As BaseRowViewInfo = Nothing
			For Each info As BaseRowViewInfo In grid.ViewInfo.RowsViewInfo
				If TypeOf info Is CategoryRowViewInfo Then
					Continue For
				End If
				rowInfo = info
				Exit For
			Next info
			If rowInfo Is Nothing Then
				Return
			End If
			Dim valueInfo As RowValueInfo = Nothing
			For Each info As RowValueInfo In rowInfo.ValuesInfo
				If info.Bounds.X < hitInfo.PtMouse.X AndAlso info.Bounds.Right > hitInfo.PtMouse.X Then
					valueInfo = info
					Exit For
				End If
			Next info
			If valueInfo Is Nothing Then
				Return
			End If
			e.Handled = True
			e.Appearance.DrawBackground(e.Cache, e.Bounds)
			e.Appearance.DrawString(e.Cache, e.Caption, e.CaptionRect)
			If e.ImageIndex > 0 Then
				ImageCollection.DrawImageListImage(e.Cache, e.Row.Properties.Images, e.ImageIndex, e.ImageRect)
			End If
			If e.Focused Then
				XPaint.Graphics.DrawFocusRectangle(e.Graphics, e.FocusRect, e.Appearance.ForeColor, e.Appearance.BackColor)
			End If
			Dim hotTrackRect As New Rectangle(valueInfo.Bounds.X, e.Bounds.Y, valueInfo.Bounds.Width, e.Bounds.Height)
			hotTrackRect.Inflate(-1, -1)
			e.Graphics.FillRectangle(Brushes.AliceBlue, hotTrackRect)
			e.Graphics.DrawRectangle(Pens.Blue, hotTrackRect)
		End Sub

		Private Sub OnVGridControlMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles verticalGrid.MouseMove
			CType(sender, VGridControl).Invalidate()
		End Sub
	End Class
End Namespace