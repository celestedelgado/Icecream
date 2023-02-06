<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

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
        Me.picFlavors = New System.Windows.Forms.PictureBox()
        Me.lbFlavors = New System.Windows.Forms.ListBox()
        CType(Me.picFlavors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picFlavors
        '
        Me.picFlavors.Location = New System.Drawing.Point(163, 95)
        Me.picFlavors.Name = "picFlavors"
        Me.picFlavors.Size = New System.Drawing.Size(229, 220)
        Me.picFlavors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlavors.TabIndex = 1
        Me.picFlavors.TabStop = False
        '
        'lbFlavors
        '
        Me.lbFlavors.FormattingEnabled = True
        Me.lbFlavors.Items.AddRange(New Object() {"Vanilla", "Chocolate", "Strawberry", "Cookies and Cream", "Cookie Dough"})
        Me.lbFlavors.Location = New System.Drawing.Point(464, 146)
        Me.lbFlavors.Name = "lbFlavors"
        Me.lbFlavors.Size = New System.Drawing.Size(213, 134)
        Me.lbFlavors.TabIndex = 2
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbFlavors)
        Me.Controls.Add(Me.picFlavors)
        Me.Name = "frmMain"
        Me.Text = "2.6.23"
        CType(Me.picFlavors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picFlavors As PictureBox
    Friend WithEvents lbFlavors As ListBox
End Class
