﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCetakNotaReturPDF
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim InstanceReportSource1 As Telerik.Reporting.InstanceReportSource = New Telerik.Reporting.InstanceReportSource()
        Me.ReportViewer1 = New Telerik.ReportViewer.WinForms.ReportViewer()
        Me.ReportNotaReturToPDF1 = New Program_Penjualan_V2.ReportNotaReturToPDF()
        CType(Me.ReportNotaReturToPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        InstanceReportSource1.ReportDocument = Me.ReportNotaReturToPDF1
        Me.ReportViewer1.ReportSource = InstanceReportSource1
        Me.ReportViewer1.Size = New System.Drawing.Size(792, 450)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.ViewMode = Telerik.ReportViewer.WinForms.ViewMode.PrintPreview
        '
        'ReportNotaReturToPDF1
        '
        Me.ReportNotaReturToPDF1.Name = "NotaReturPenjualan"
        '
        'FormCetaNotaReturPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormCetaNotaReturPDF"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCetaNotaReturPDF"
        CType(Me.ReportNotaReturToPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Telerik.ReportViewer.WinForms.ReportViewer
    Friend WithEvents ReportNotaReturToPDF1 As Program_Penjualan_V2.ReportNotaReturToPDF
End Class

