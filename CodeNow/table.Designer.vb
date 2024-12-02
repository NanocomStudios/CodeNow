<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class table
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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.addrowb = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.addcoloumb = New System.Windows.Forms.Button
        Me.colspanb = New System.Windows.Forms.Button
        Me.rowspanb = New System.Windows.Forms.Button
        Me.span_t = New System.Windows.Forms.TextBox
        Me.caption_t = New System.Windows.Forms.TextBox
        Me.border_t = New System.Windows.Forms.TextBox
        Me.height_t = New System.Windows.Forms.TextBox
        Me.width_t = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cellp_t = New System.Windows.Forms.TextBox
        Me.cells_t = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.createtb = New System.Windows.Forms.Button
        Me.data_t = New System.Windows.Forms.TextBox
        Me.addb = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(390, 12)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(702, 459)
        Me.WebBrowser1.TabIndex = 0
        '
        'addrowb
        '
        Me.addrowb.Location = New System.Drawing.Point(30, 285)
        Me.addrowb.Name = "addrowb"
        Me.addrowb.Size = New System.Drawing.Size(129, 40)
        Me.addrowb.TabIndex = 1
        Me.addrowb.Text = "Add a row"
        Me.addrowb.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 477)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1080, 20)
        Me.TextBox1.TabIndex = 2
        '
        'addcoloumb
        '
        Me.addcoloumb.Location = New System.Drawing.Point(31, 331)
        Me.addcoloumb.Name = "addcoloumb"
        Me.addcoloumb.Size = New System.Drawing.Size(129, 56)
        Me.addcoloumb.TabIndex = 3
        Me.addcoloumb.Text = "Add coloum"
        Me.addcoloumb.UseVisualStyleBackColor = True
        '
        'colspanb
        '
        Me.colspanb.Location = New System.Drawing.Point(167, 331)
        Me.colspanb.Name = "colspanb"
        Me.colspanb.Size = New System.Drawing.Size(144, 23)
        Me.colspanb.TabIndex = 4
        Me.colspanb.Text = "colspan"
        Me.colspanb.UseVisualStyleBackColor = True
        '
        'rowspanb
        '
        Me.rowspanb.Location = New System.Drawing.Point(166, 362)
        Me.rowspanb.Name = "rowspanb"
        Me.rowspanb.Size = New System.Drawing.Size(145, 25)
        Me.rowspanb.TabIndex = 5
        Me.rowspanb.Text = "rowspan"
        Me.rowspanb.UseVisualStyleBackColor = True
        '
        'span_t
        '
        Me.span_t.Location = New System.Drawing.Point(317, 350)
        Me.span_t.Name = "span_t"
        Me.span_t.Size = New System.Drawing.Size(45, 20)
        Me.span_t.TabIndex = 6
        '
        'caption_t
        '
        Me.caption_t.Location = New System.Drawing.Point(110, 29)
        Me.caption_t.Name = "caption_t"
        Me.caption_t.Size = New System.Drawing.Size(146, 20)
        Me.caption_t.TabIndex = 7
        '
        'border_t
        '
        Me.border_t.Location = New System.Drawing.Point(110, 62)
        Me.border_t.Name = "border_t"
        Me.border_t.Size = New System.Drawing.Size(145, 20)
        Me.border_t.TabIndex = 8
        '
        'height_t
        '
        Me.height_t.Location = New System.Drawing.Point(111, 92)
        Me.height_t.Name = "height_t"
        Me.height_t.Size = New System.Drawing.Size(144, 20)
        Me.height_t.TabIndex = 9
        '
        'width_t
        '
        Me.width_t.Location = New System.Drawing.Point(112, 127)
        Me.width_t.Name = "width_t"
        Me.width_t.Size = New System.Drawing.Size(143, 20)
        Me.width_t.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Caption"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Border"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Height"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Width"
        '
        'cellp_t
        '
        Me.cellp_t.Location = New System.Drawing.Point(112, 155)
        Me.cellp_t.Name = "cellp_t"
        Me.cellp_t.Size = New System.Drawing.Size(143, 20)
        Me.cellp_t.TabIndex = 15
        '
        'cells_t
        '
        Me.cells_t.Location = New System.Drawing.Point(112, 183)
        Me.cells_t.Name = "cells_t"
        Me.cells_t.Size = New System.Drawing.Size(142, 20)
        Me.cells_t.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Cell padding"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Cell spacing"
        '
        'createtb
        '
        Me.createtb.Location = New System.Drawing.Point(30, 232)
        Me.createtb.Name = "createtb"
        Me.createtb.Size = New System.Drawing.Size(225, 47)
        Me.createtb.TabIndex = 19
        Me.createtb.Text = "Create a table"
        Me.createtb.UseVisualStyleBackColor = True
        '
        'data_t
        '
        Me.data_t.Location = New System.Drawing.Point(33, 415)
        Me.data_t.Name = "data_t"
        Me.data_t.Size = New System.Drawing.Size(126, 20)
        Me.data_t.TabIndex = 20
        '
        'addb
        '
        Me.addb.Enabled = False
        Me.addb.Location = New System.Drawing.Point(184, 408)
        Me.addb.Name = "addb"
        Me.addb.Size = New System.Drawing.Size(127, 26)
        Me.addb.TabIndex = 21
        Me.addb.Text = "Add data"
        Me.addb.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(12, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = """"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(187, 287)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 37)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Delet Coloum"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'table
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 509)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.addb)
        Me.Controls.Add(Me.data_t)
        Me.Controls.Add(Me.createtb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cells_t)
        Me.Controls.Add(Me.cellp_t)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.width_t)
        Me.Controls.Add(Me.height_t)
        Me.Controls.Add(Me.border_t)
        Me.Controls.Add(Me.caption_t)
        Me.Controls.Add(Me.span_t)
        Me.Controls.Add(Me.rowspanb)
        Me.Controls.Add(Me.colspanb)
        Me.Controls.Add(Me.addcoloumb)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.addrowb)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Name = "table"
        Me.Text = "Delet coloum"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents addrowb As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents addcoloumb As System.Windows.Forms.Button
    Friend WithEvents colspanb As System.Windows.Forms.Button
    Friend WithEvents rowspanb As System.Windows.Forms.Button
    Friend WithEvents span_t As System.Windows.Forms.TextBox
    Friend WithEvents caption_t As System.Windows.Forms.TextBox
    Friend WithEvents border_t As System.Windows.Forms.TextBox
    Friend WithEvents height_t As System.Windows.Forms.TextBox
    Friend WithEvents width_t As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cellp_t As System.Windows.Forms.TextBox
    Friend WithEvents cells_t As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents createtb As System.Windows.Forms.Button
    Friend WithEvents data_t As System.Windows.Forms.TextBox
    Friend WithEvents addb As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
