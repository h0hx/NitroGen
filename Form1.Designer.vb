<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm1))
        btnGenerate = New Button()
        TitlePicture = New PictureBox()
        Exitbtn = New Button()
        GenerateBox = New TextBox()
        CType(TitlePicture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnGenerate
        ' 
        btnGenerate.BackColor = Color.FromArgb(CByte(0), CByte(180), CByte(255))
        btnGenerate.FlatStyle = FlatStyle.Popup
        btnGenerate.ForeColor = Color.White
        btnGenerate.Location = New Point(113, 74)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(83, 36)
        btnGenerate.TabIndex = 0
        btnGenerate.Text = "Generate"
        btnGenerate.UseVisualStyleBackColor = False
        ' 
        ' TitlePicture
        ' 
        TitlePicture.Image = CType(resources.GetObject("TitlePicture.Image"), Image)
        TitlePicture.Location = New Point(46, 2)
        TitlePicture.Name = "TitlePicture"
        TitlePicture.Size = New Size(206, 51)
        TitlePicture.SizeMode = PictureBoxSizeMode.Zoom
        TitlePicture.TabIndex = 1
        TitlePicture.TabStop = False
        ' 
        ' Exitbtn
        ' 
        Exitbtn.BackColor = Color.FromArgb(CByte(0), CByte(180), CByte(255))
        Exitbtn.FlatStyle = FlatStyle.Popup
        Exitbtn.ForeColor = Color.White
        Exitbtn.Location = New Point(259, 2)
        Exitbtn.Name = "Exitbtn"
        Exitbtn.Size = New Size(50, 29)
        Exitbtn.TabIndex = 2
        Exitbtn.Text = "Exit"
        Exitbtn.UseVisualStyleBackColor = False
        ' 
        ' GenerateBox
        ' 
        GenerateBox.BackColor = Color.FromArgb(CByte(0), CByte(180), CByte(255))
        GenerateBox.BorderStyle = BorderStyle.None
        GenerateBox.Location = New Point(12, 116)
        GenerateBox.Multiline = True
        GenerateBox.Name = "GenerateBox"
        GenerateBox.ReadOnly = True
        GenerateBox.ScrollBars = ScrollBars.Vertical
        GenerateBox.Size = New Size(285, 29)
        GenerateBox.TabIndex = 3
        ' 
        ' MainForm1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(309, 241)
        Controls.Add(GenerateBox)
        Controls.Add(Exitbtn)
        Controls.Add(TitlePicture)
        Controls.Add(btnGenerate)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "MainForm1"
        Text = "NitroGen"
        CType(TitlePicture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGenerate As Button
    Friend WithEvents TitlePicture As PictureBox
    Friend WithEvents Exitbtn As Button
    Friend WithEvents GenerateBox As TextBox

End Class
