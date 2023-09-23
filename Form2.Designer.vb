<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        Panel1 = New Panel()
        Button8 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button8)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 423)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(757, 125)
        Panel1.TabIndex = 0
        ' 
        ' Button8
        ' 
        Button8.Dock = DockStyle.Right
        Button8.Location = New Point(663, 0)
        Button8.Name = "Button8"
        Button8.Size = New Size(94, 125)
        Button8.TabIndex = 4
        Button8.Text = "종료"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Dock = DockStyle.Left
        Button4.Location = New Point(282, 0)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 125)
        Button4.TabIndex = 3
        Button4.Text = "랜덤추천"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Dock = DockStyle.Left
        Button3.Location = New Point(188, 0)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 125)
        Button3.TabIndex = 2
        Button3.Text = "선호설정"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Dock = DockStyle.Left
        Button2.Location = New Point(94, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 125)
        Button2.TabIndex = 1
        Button2.Text = "한눈에보기"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Dock = DockStyle.Left
        Button1.Location = New Point(0, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 125)
        Button1.TabIndex = 0
        Button1.Text = "공부할곳"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(757, 423)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Button5
        ' 
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.Location = New Point(200, 69)
        Button5.Name = "Button5"
        Button5.Size = New Size(40, 50)
        Button5.TabIndex = 2
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Image = CType(resources.GetObject("Button6.Image"), Image)
        Button6.Location = New Point(131, 78)
        Button6.Name = "Button6"
        Button6.Size = New Size(40, 50)
        Button6.TabIndex = 3
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.BackgroundImageLayout = ImageLayout.None
        Button7.Image = CType(resources.GetObject("Button7.Image"), Image)
        Button7.Location = New Point(605, 203)
        Button7.Name = "Button7"
        Button7.Size = New Size(40, 50)
        Button7.TabIndex = 4
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 5000
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(757, 548)
        ControlBox = False
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "main"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Timer1 As Timer
End Class
