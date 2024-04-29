<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        TextBox1 = New TextBox()
        marSmithButton = New Button()
        billJonesButton = New Button()
        cindyBrownButton = New Button()
        paulWellsButton = New Button()
        jimFranksButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(75, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 32)
        Label1.TabIndex = 0
        Label1.Text = "Phone#"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(324, 83)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(200, 39)
        TextBox1.TabIndex = 1
        ' 
        ' marSmithButton
        ' 
        marSmithButton.Location = New Point(222, 204)
        marSmithButton.Name = "marSmithButton"
        marSmithButton.Size = New Size(150, 46)
        marSmithButton.TabIndex = 2
        marSmithButton.Text = "Mary Smith"
        marSmithButton.UseVisualStyleBackColor = True
        ' 
        ' billJonesButton
        ' 
        billJonesButton.Location = New Point(222, 269)
        billJonesButton.Name = "billJonesButton"
        billJonesButton.Size = New Size(150, 46)
        billJonesButton.TabIndex = 3
        billJonesButton.Text = "Bill Jones"
        billJonesButton.UseVisualStyleBackColor = True
        ' 
        ' cindyBrownButton
        ' 
        cindyBrownButton.Font = New Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cindyBrownButton.Location = New Point(222, 371)
        cindyBrownButton.Name = "cindyBrownButton"
        cindyBrownButton.Size = New Size(150, 46)
        cindyBrownButton.TabIndex = 4
        cindyBrownButton.Text = "Cindy Brown"
        cindyBrownButton.UseVisualStyleBackColor = True
        ' 
        ' paulWellsButton
        ' 
        paulWellsButton.Location = New Point(222, 436)
        paulWellsButton.Name = "paulWellsButton"
        paulWellsButton.Size = New Size(150, 46)
        paulWellsButton.TabIndex = 5
        paulWellsButton.Text = "Paul Wells"
        paulWellsButton.UseVisualStyleBackColor = True
        ' 
        ' jimFranksButton
        ' 
        jimFranksButton.Location = New Point(222, 511)
        jimFranksButton.Name = "jimFranksButton"
        jimFranksButton.Size = New Size(150, 46)
        jimFranksButton.TabIndex = 6
        jimFranksButton.Text = "Jim Franks"
        jimFranksButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(632, 648)
        Controls.Add(jimFranksButton)
        Controls.Add(paulWellsButton)
        Controls.Add(cindyBrownButton)
        Controls.Add(billJonesButton)
        Controls.Add(marSmithButton)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Telephone Directory"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents marSmithButton As Button
    Friend WithEvents billJonesButton As Button
    Friend WithEvents cindyBrownButton As Button
    Friend WithEvents paulWellsButton As Button
    Friend WithEvents jimFranksButton As Button


End Class
