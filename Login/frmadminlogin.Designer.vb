<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmadminlogin
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
        Me.CloudHeader3 = New CloudToolkitN6.CloudHeader()
        Me.txttitle = New CloudToolkitN6.CloudHeader()
        Me.Btnmin = New System.Windows.Forms.PictureBox()
        Me.Btnclose = New System.Windows.Forms.PictureBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.toolcancel = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.Btnmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CloudHeader3
        '
        Me.CloudHeader3.BackColor = System.Drawing.Color.Transparent
        Me.CloudHeader3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CloudHeader3.BorderColor = System.Drawing.Color.Transparent
        Me.CloudHeader3.BorderWidth = 1.0!
        Me.CloudHeader3.Cursor = System.Windows.Forms.Cursors.Default
        Me.CloudHeader3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CloudHeader3.FillColor1 = System.Drawing.Color.Black
        Me.CloudHeader3.FillColor2 = System.Drawing.Color.Black
        Me.CloudHeader3.FillColor2_1 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CloudHeader3.FillColor2_2 = System.Drawing.Color.Gray
        Me.CloudHeader3.FontColorMouseOn = System.Drawing.Color.White
        Me.CloudHeader3.FontColorNormal = System.Drawing.Color.White
        Me.CloudHeader3.ForeColor = System.Drawing.Color.White
        Me.CloudHeader3.HeaderText = "Only authorized users are allowed to login"
        Me.CloudHeader3.Icon = Nothing
        Me.CloudHeader3.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Right
        Me.CloudHeader3.IconPadding = 5
        Me.CloudHeader3.ImageHeader = False
        Me.CloudHeader3.Location = New System.Drawing.Point(0, 116)
        Me.CloudHeader3.Name = "CloudHeader3"
        Me.CloudHeader3.Size = New System.Drawing.Size(336, 27)
        Me.CloudHeader3.TabIndex = 20
        '
        'txttitle
        '
        Me.txttitle.BackColor = System.Drawing.Color.Transparent
        Me.txttitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txttitle.BorderColor = System.Drawing.Color.Transparent
        Me.txttitle.BorderWidth = 1.0!
        Me.txttitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.txttitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.txttitle.FillColor1 = System.Drawing.Color.Gray
        Me.txttitle.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txttitle.FillColor2_1 = System.Drawing.Color.Black
        Me.txttitle.FillColor2_2 = System.Drawing.Color.Black
        Me.txttitle.FontColorMouseOn = System.Drawing.Color.White
        Me.txttitle.FontColorNormal = System.Drawing.Color.White
        Me.txttitle.ForeColor = System.Drawing.Color.White
        Me.txttitle.HeaderText = "Administrator Login"
        Me.txttitle.Icon = Nothing
        Me.txttitle.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Right
        Me.txttitle.IconPadding = 5
        Me.txttitle.ImageHeader = False
        Me.txttitle.Location = New System.Drawing.Point(0, 0)
        Me.txttitle.Name = "txttitle"
        Me.txttitle.Size = New System.Drawing.Size(336, 27)
        Me.txttitle.TabIndex = 19
        '
        'Btnmin
        '
        Me.Btnmin.BackColor = System.Drawing.Color.Black
        Me.Btnmin.BackgroundImage = Global.Login.My.Resources.Resources.min
        Me.Btnmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnmin.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btnmin.Location = New System.Drawing.Point(286, 0)
        Me.Btnmin.Name = "Btnmin"
        Me.Btnmin.Size = New System.Drawing.Size(25, 25)
        Me.Btnmin.TabIndex = 22
        Me.Btnmin.TabStop = False
        '
        'Btnclose
        '
        Me.Btnclose.BackColor = System.Drawing.Color.Black
        Me.Btnclose.BackgroundImage = Global.Login.My.Resources.Resources.close
        Me.Btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnclose.Cursor = System.Windows.Forms.Cursors.Default
        Me.Btnclose.Location = New System.Drawing.Point(311, 1)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(25, 25)
        Me.Btnclose.TabIndex = 21
        Me.Btnclose.TabStop = False
        '
        'txtusername
        '
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtusername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(78, 44)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(166, 25)
        Me.txtusername.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Password"
        '
        'txtpass
        '
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(78, 71)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(166, 25)
        Me.txtpass.TabIndex = 2
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btncancel.Location = New System.Drawing.Point(250, 70)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 25)
        Me.btncancel.TabIndex = 4
        Me.btncancel.Text = "Cancel"
        Me.btncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.White
        Me.btnlogin.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnlogin.Location = New System.Drawing.Point(250, 43)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(75, 25)
        Me.btnlogin.TabIndex = 3
        Me.btnlogin.Text = "Login"
        Me.btnlogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolcancel})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 27)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(336, 24)
        Me.MenuStrip1.TabIndex = 79
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'toolcancel
        '
        Me.toolcancel.Name = "toolcancel"
        Me.toolcancel.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.toolcancel.Size = New System.Drawing.Size(128, 20)
        Me.toolcancel.Text = "ToolStripMenuItem1"
        '
        'frmadminlogin
        '
        Me.AcceptButton = Me.btnlogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(336, 143)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.Btnmin)
        Me.Controls.Add(Me.Btnclose)
        Me.Controls.Add(Me.CloudHeader3)
        Me.Controls.Add(Me.txttitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmadminlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrator Login"
        CType(Me.Btnmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btnmin As System.Windows.Forms.PictureBox
    Friend WithEvents Btnclose As System.Windows.Forms.PictureBox
    Friend WithEvents CloudHeader3 As CloudToolkitN6.CloudHeader
    Friend WithEvents txttitle As CloudToolkitN6.CloudHeader
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents toolcancel As System.Windows.Forms.ToolStripMenuItem
End Class
