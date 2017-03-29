<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.btnOff = New System.Windows.Forms.Button()
        Me.lbPosições = New System.Windows.Forms.ListBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.lbMovimentos = New System.Windows.Forms.ListBox()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnExecutar = New System.Windows.Forms.Button()
        Me.txtEndereço = New System.Windows.Forms.TextBox()
        Me.txtPorta = New System.Windows.Forms.TextBox()
        Me.btnPausa = New System.Windows.Forms.Button()
        Me.btnAbrir = New System.Windows.Forms.Button()
        Me.btnParaCima = New System.Windows.Forms.Button()
        Me.btnParaBaixo = New System.Windows.Forms.Button()
        Me.btnExecutarPosições = New System.Windows.Forms.Button()
        Me.btnDesligar = New System.Windows.Forms.Button()
        Me.chkAtivar = New System.Windows.Forms.CheckBox()
        Me.txtQtExecutar = New System.Windows.Forms.TextBox()
        Me.btnReferenciar = New System.Windows.Forms.Button()
        Me.btnInicializar = New System.Windows.Forms.Button()
        Me.btnExecutarTudo = New System.Windows.Forms.Button()
        Me.txtPausaEntreEnvios = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPausaEntreEnvios = New System.Windows.Forms.Label()
        Me.Servo14 = New JARVIS_mgen.Slider()
        Me.Servo17 = New JARVIS_mgen.Slider()
        Me.Servo13 = New JARVIS_mgen.Slider()
        Me.Servo16 = New JARVIS_mgen.Slider()
        Me.Servo12 = New JARVIS_mgen.Slider()
        Me.Servo15 = New JARVIS_mgen.Slider()
        Me.Servo10 = New JARVIS_mgen.Slider()
        Me.Servo5 = New JARVIS_mgen.Slider()
        Me.Servo0 = New JARVIS_mgen.Slider()
        Me.Servo8 = New JARVIS_mgen.Slider()
        Me.Servo11 = New JARVIS_mgen.Slider()
        Me.Servo6 = New JARVIS_mgen.Slider()
        Me.Servo7 = New JARVIS_mgen.Slider()
        Me.Servo9 = New JARVIS_mgen.Slider()
        Me.Servo3 = New JARVIS_mgen.Slider()
        Me.Servo4 = New JARVIS_mgen.Slider()
        Me.Servo2 = New JARVIS_mgen.Slider()
        Me.Servo1 = New JARVIS_mgen.Slider()
        Me.lblQtExecutar = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOff
        '
        Me.btnOff.Location = New System.Drawing.Point(383, 9)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(161, 35)
        Me.btnOff.TabIndex = 1
        Me.btnOff.Text = "OFF"
        Me.btnOff.UseVisualStyleBackColor = True
        '
        'lbPosições
        '
        Me.lbPosições.FormattingEnabled = True
        Me.lbPosições.Location = New System.Drawing.Point(938, 56)
        Me.lbPosições.Name = "lbPosições"
        Me.lbPosições.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbPosições.Size = New System.Drawing.Size(172, 290)
        Me.lbPosições.TabIndex = 13
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(938, 436)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(209, 70)
        Me.btnRegistrar.TabIndex = 14
        Me.btnRegistrar.Text = "Inserir Todos"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnGravar
        '
        Me.btnGravar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGravar.Location = New System.Drawing.Point(1116, 305)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(82, 41)
        Me.btnGravar.TabIndex = 15
        Me.btnGravar.Text = ">>"
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'lbMovimentos
        '
        Me.lbMovimentos.FormattingEnabled = True
        Me.lbMovimentos.Location = New System.Drawing.Point(1214, 55)
        Me.lbMovimentos.Name = "lbMovimentos"
        Me.lbMovimentos.Size = New System.Drawing.Size(141, 290)
        Me.lbMovimentos.TabIndex = 16
        '
        'btnLimpar
        '
        Me.btnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.Location = New System.Drawing.Point(938, 16)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(126, 32)
        Me.btnLimpar.TabIndex = 17
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnExecutar
        '
        Me.btnExecutar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExecutar.Location = New System.Drawing.Point(1214, 350)
        Me.btnExecutar.Name = "btnExecutar"
        Me.btnExecutar.Size = New System.Drawing.Size(141, 50)
        Me.btnExecutar.TabIndex = 18
        Me.btnExecutar.Text = "Executar"
        Me.btnExecutar.UseVisualStyleBackColor = True
        '
        'txtEndereço
        '
        Me.txtEndereço.Location = New System.Drawing.Point(14, 12)
        Me.txtEndereço.Name = "txtEndereço"
        Me.txtEndereço.Size = New System.Drawing.Size(123, 21)
        Me.txtEndereço.TabIndex = 19
        Me.txtEndereço.Text = "192.168.0.155"
        '
        'txtPorta
        '
        Me.txtPorta.Location = New System.Drawing.Point(145, 12)
        Me.txtPorta.Name = "txtPorta"
        Me.txtPorta.Size = New System.Drawing.Size(70, 21)
        Me.txtPorta.TabIndex = 20
        Me.txtPorta.Text = "2390"
        '
        'btnPausa
        '
        Me.btnPausa.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPausa.Location = New System.Drawing.Point(938, 350)
        Me.btnPausa.Name = "btnPausa"
        Me.btnPausa.Size = New System.Drawing.Size(209, 32)
        Me.btnPausa.TabIndex = 21
        Me.btnPausa.Text = "Pausa"
        Me.btnPausa.UseVisualStyleBackColor = True
        '
        'btnAbrir
        '
        Me.btnAbrir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrir.Location = New System.Drawing.Point(1116, 260)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(82, 39)
        Me.btnAbrir.TabIndex = 28
        Me.btnAbrir.Text = "<<"
        Me.btnAbrir.UseVisualStyleBackColor = True
        '
        'btnParaCima
        '
        Me.btnParaCima.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParaCima.Location = New System.Drawing.Point(1116, 56)
        Me.btnParaCima.Name = "btnParaCima"
        Me.btnParaCima.Size = New System.Drawing.Size(92, 62)
        Me.btnParaCima.TabIndex = 29
        Me.btnParaCima.Text = "P/ Cima"
        Me.btnParaCima.UseVisualStyleBackColor = True
        '
        'btnParaBaixo
        '
        Me.btnParaBaixo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParaBaixo.Location = New System.Drawing.Point(1116, 124)
        Me.btnParaBaixo.Name = "btnParaBaixo"
        Me.btnParaBaixo.Size = New System.Drawing.Size(92, 62)
        Me.btnParaBaixo.TabIndex = 30
        Me.btnParaBaixo.Text = "P/ Baixo"
        Me.btnParaBaixo.UseVisualStyleBackColor = True
        '
        'btnExecutarPosições
        '
        Me.btnExecutarPosições.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExecutarPosições.Location = New System.Drawing.Point(938, 512)
        Me.btnExecutarPosições.Name = "btnExecutarPosições"
        Me.btnExecutarPosições.Size = New System.Drawing.Size(209, 50)
        Me.btnExecutarPosições.TabIndex = 31
        Me.btnExecutarPosições.Text = "Executar"
        Me.btnExecutarPosições.UseVisualStyleBackColor = True
        '
        'btnDesligar
        '
        Me.btnDesligar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesligar.Location = New System.Drawing.Point(938, 388)
        Me.btnDesligar.Name = "btnDesligar"
        Me.btnDesligar.Size = New System.Drawing.Size(209, 42)
        Me.btnDesligar.TabIndex = 32
        Me.btnDesligar.Text = "Desligar"
        Me.btnDesligar.UseVisualStyleBackColor = True
        '
        'chkAtivar
        '
        Me.chkAtivar.AutoSize = True
        Me.chkAtivar.Location = New System.Drawing.Point(551, 29)
        Me.chkAtivar.Name = "chkAtivar"
        Me.chkAtivar.Size = New System.Drawing.Size(60, 17)
        Me.chkAtivar.TabIndex = 33
        Me.chkAtivar.Text = "Ativar"
        Me.chkAtivar.UseVisualStyleBackColor = True
        '
        'txtQtExecutar
        '
        Me.txtQtExecutar.Location = New System.Drawing.Point(1153, 531)
        Me.txtQtExecutar.Name = "txtQtExecutar"
        Me.txtQtExecutar.Size = New System.Drawing.Size(55, 21)
        Me.txtQtExecutar.TabIndex = 35
        Me.txtQtExecutar.Text = "1"
        '
        'btnReferenciar
        '
        Me.btnReferenciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReferenciar.Location = New System.Drawing.Point(1116, 215)
        Me.btnReferenciar.Name = "btnReferenciar"
        Me.btnReferenciar.Size = New System.Drawing.Size(82, 39)
        Me.btnReferenciar.TabIndex = 36
        Me.btnReferenciar.Text = "<-"
        Me.btnReferenciar.UseVisualStyleBackColor = True
        '
        'btnInicializar
        '
        Me.btnInicializar.Location = New System.Drawing.Point(223, 9)
        Me.btnInicializar.Name = "btnInicializar"
        Me.btnInicializar.Size = New System.Drawing.Size(153, 35)
        Me.btnInicializar.TabIndex = 37
        Me.btnInicializar.Text = "INICIALIZAR"
        Me.btnInicializar.UseVisualStyleBackColor = True
        '
        'btnExecutarTudo
        '
        Me.btnExecutarTudo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExecutarTudo.Location = New System.Drawing.Point(938, 568)
        Me.btnExecutarTudo.Name = "btnExecutarTudo"
        Me.btnExecutarTudo.Size = New System.Drawing.Size(209, 50)
        Me.btnExecutarTudo.TabIndex = 42
        Me.btnExecutarTudo.Text = "Executar (TUDO)"
        Me.btnExecutarTudo.UseVisualStyleBackColor = True
        '
        'txtPausaEntreEnvios
        '
        Me.txtPausaEntreEnvios.Location = New System.Drawing.Point(765, 9)
        Me.txtPausaEntreEnvios.Name = "txtPausaEntreEnvios"
        Me.txtPausaEntreEnvios.Size = New System.Drawing.Size(100, 21)
        Me.txtPausaEntreEnvios.TabIndex = 46
        Me.txtPausaEntreEnvios.Text = "100"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.JARVIS_mgen.My.Resources.Resources.Bug6
        Me.PictureBox1.Location = New System.Drawing.Point(58, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(807, 658)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblPausaEntreEnvios
        '
        Me.lblPausaEntreEnvios.AutoSize = True
        Me.lblPausaEntreEnvios.Location = New System.Drawing.Point(640, 12)
        Me.lblPausaEntreEnvios.Name = "lblPausaEntreEnvios"
        Me.lblPausaEntreEnvios.Size = New System.Drawing.Size(121, 13)
        Me.lblPausaEntreEnvios.TabIndex = 56
        Me.lblPausaEntreEnvios.Text = "Pausa entre envios:"
        '
        'Servo14
        '
        Me.Servo14.AutoSize = True
        Me.Servo14.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Servo14.Inverse = False
        Me.Servo14.Location = New System.Drawing.Point(1, 269)
        Me.Servo14.MaxPulse = 0
        Me.Servo14.MinPulse = 0
        Me.Servo14.Name = "Servo14"
        Me.Servo14.PreviousValue = 90
        Me.Servo14.Selected = System.Windows.Forms.CheckState.Indeterminate
        Me.Servo14.ServoID = "O"
        Me.Servo14.Size = New System.Drawing.Size(195, 61)
        Me.Servo14.TabIndex = 55
        Me.Servo14.Value = 90
        '
        'Servo17
        '
        Me.Servo17.AutoSize = True
        Me.Servo17.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Servo17.Inverse = False
        Me.Servo17.Location = New System.Drawing.Point(736, 269)
        Me.Servo17.MaxPulse = 0
        Me.Servo17.MinPulse = 0
        Me.Servo17.Name = "Servo17"
        Me.Servo17.PreviousValue = 90
        Me.Servo17.Selected = System.Windows.Forms.CheckState.Indeterminate
        Me.Servo17.ServoID = "R"
        Me.Servo17.Size = New System.Drawing.Size(195, 61)
        Me.Servo17.TabIndex = 54
        Me.Servo17.Value = 90
        '
        'Servo13
        '
        Me.Servo13.AutoSize = True
        Me.Servo13.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Servo13.Inverse = False
        Me.Servo13.Location = New System.Drawing.Point(54, 392)
        Me.Servo13.MaxPulse = 0
        Me.Servo13.MinPulse = 0
        Me.Servo13.Name = "Servo13"
        Me.Servo13.PreviousValue = 90
        Me.Servo13.Selected = System.Windows.Forms.CheckState.Indeterminate
        Me.Servo13.ServoID = "N"
        Me.Servo13.Size = New System.Drawing.Size(195, 61)
        Me.Servo13.TabIndex = 53
        Me.Servo13.Value = 90
        '
        'Servo16
        '
        Me.Servo16.AutoSize = True
        Me.Servo16.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Servo16.Inverse = False
        Me.Servo16.Location = New System.Drawing.Point(671, 392)
        Me.Servo16.MaxPulse = 0
        Me.Servo16.MinPulse = 0
        Me.Servo16.Name = "Servo16"
        Me.Servo16.PreviousValue = 90
        Me.Servo16.Selected = System.Windows.Forms.CheckState.Indeterminate
        Me.Servo16.ServoID = "Q"
        Me.Servo16.Size = New System.Drawing.Size(195, 61)
        Me.Servo16.TabIndex = 52
        Me.Servo16.Value = 90
        '
        'Servo12
        '
        Me.Servo12.AutoSize = True
        Me.Servo12.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Servo12.Inverse = False
        Me.Servo12.Location = New System.Drawing.Point(255, 392)
        Me.Servo12.MaxPulse = 0
        Me.Servo12.MinPulse = 0
        Me.Servo12.Name = "Servo12"
        Me.Servo12.PreviousValue = 90
        Me.Servo12.Selected = System.Windows.Forms.CheckState.Indeterminate
        Me.Servo12.ServoID = "M"
        Me.Servo12.Size = New System.Drawing.Size(195, 61)
        Me.Servo12.TabIndex = 51
        Me.Servo12.Value = 90
        '
        'Servo15
        '
        Me.Servo15.AutoSize = True
        Me.Servo15.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Servo15.Inverse = False
        Me.Servo15.Location = New System.Drawing.Point(469, 392)
        Me.Servo15.MaxPulse = 0
        Me.Servo15.MinPulse = 0
        Me.Servo15.Name = "Servo15"
        Me.Servo15.PreviousValue = 90
        Me.Servo15.Selected = System.Windows.Forms.CheckState.Indeterminate
        Me.Servo15.ServoID = "P"
        Me.Servo15.Size = New System.Drawing.Size(195, 61)
        Me.Servo15.TabIndex = 50
        Me.Servo15.Value = 90
        '
        'Servo10
        '
        Me.Servo10.AutoSize = True
        Me.Servo10.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Servo10.Inverse = True
        Me.Servo10.Location = New System.Drawing.Point(71, 137)
        Me.Servo10.MaxPulse = 0
        Me.Servo10.MinPulse = 0
        Me.Servo10.Name = "Servo10"
        Me.Servo10.PreviousValue = 90
        Me.Servo10.Selected = System.Windows.Forms.CheckState.Indeterminate
        Me.Servo10.ServoID = "K"
        Me.Servo10.Size = New System.Drawing.Size(195, 61)
        Me.Servo10.TabIndex = 49
        Me.Servo10.Tag = ""
        Me.Servo10.Value = 90
        '
        'Servo5
        '
        Me.Servo5.AutoSize = True
        Me.Servo5.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Servo5.Inverse = False
        Me.Servo5.Location = New System.Drawing.Point(14, 644)
        Me.Servo5.MaxPulse = 0
        Me.Servo5.MinPulse = 0
        Me.Servo5.Name = "Servo5"
        Me.Servo5.PreviousValue = 90
        Me.Servo5.Selected = System.Windows.Forms.CheckState.Indeterminate
        Me.Servo5.ServoID = "F"
        Me.Servo5.Size = New System.Drawing.Size(195, 61)
        Me.Servo5.TabIndex = 43
        Me.Servo5.Tag = ""
        Me.Servo5.Value = 90
        '
        'Servo0
        '
        Me.Servo0.AutoSize = True
        Me.Servo0.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Servo0.Inverse = True
        Me.Servo0.Location = New System.Drawing.Point(716, 644)
        Me.Servo0.MaxPulse = 0
        Me.Servo0.MinPulse = 0
        Me.Servo0.Name = "Servo0"
        Me.Servo0.PreviousValue = 90
        Me.Servo0.Selected = System.Windows.Forms.CheckState.Indeterminate
        Me.Servo0.ServoID = "A"
        Me.Servo0.Size = New System.Drawing.Size(195, 61)
        Me.Servo0.TabIndex = 40
        Me.Servo0.Tag = ""
        Me.Servo0.Value = 90
        '
        'Servo8
        '
        Me.Servo8.AutoSize = True
        Me.Servo8.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Servo8.Inverse = False
        Me.Servo8.Location = New System.Drawing.Point(716, 55)
        Me.Servo8.MaxPulse = 0
        Me.Servo8.MinPulse = 0
        Me.Servo8.Name = "Servo8"
        Me.Servo8.PreviousValue = 90
        Me.Servo8.Selected = System.Windows.Forms.CheckState.Indeterminate
        Me.Servo8.ServoID = "I"
        Me.Servo8.Size = New System.Drawing.Size(195, 61)
        Me.Servo8.TabIndex = 26
        Me.Servo8.Tag = ""
        Me.Servo8.Value = 90
        '
        'Servo11
        '
        Me.Servo11.AutoSize = True
        Me.Servo11.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Servo11.Inverse = False
        Me.Servo11.Location = New System.Drawing.Point(16, 55)
        Me.Servo11.MaxPulse = 0
        Me.Servo11.MinPulse = 0
        Me.Servo11.Name = "Servo11"
        Me.Servo11.PreviousValue = 90
        Me.Servo11.Selected = System.Windows.Forms.CheckState.Indeterminate
        Me.Servo11.ServoID = "L"
        Me.Servo11.Size = New System.Drawing.Size(195, 61)
        Me.Servo11.TabIndex = 25
        Me.Servo11.Tag = ""
        Me.Servo11.Value = 90
        '
        'Servo6
        '
        Me.Servo6.AutoSize = True
        Me.Servo6.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Servo6.Inverse = False
        Me.Servo6.Location = New System.Drawing.Point(570, 204)
        Me.Servo6.MaxPulse = 0
        Me.Servo6.MinPulse = 0
        Me.Servo6.Name = "Servo6"
        Me.Servo6.PreviousValue = 90
        Me.Servo6.Selected = System.Windows.Forms.CheckState.Indeterminate
        Me.Servo6.ServoID = "G"
        Me.Servo6.Size = New System.Drawing.Size(195, 61)
        Me.Servo6.TabIndex = 24
        Me.Servo6.Tag = ""
        Me.Servo6.Value = 90
        '
        'Servo7
        '
        Me.Servo7.AutoSize = True
        Me.Servo7.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Servo7.Inverse = False
        Me.Servo7.Location = New System.Drawing.Point(656, 137)
        Me.Servo7.MaxPulse = 0
        Me.Servo7.MinPulse = 0
        Me.Servo7.Name = "Servo7"
        Me.Servo7.PreviousValue = 90
        Me.Servo7.Selected = System.Windows.Forms.CheckState.Indeterminate
        Me.Servo7.ServoID = "H"
        Me.Servo7.Size = New System.Drawing.Size(195, 61)
        Me.Servo7.TabIndex = 23
        Me.Servo7.Tag = ""
        Me.Servo7.Value = 90
        '
        'Servo9
        '
        Me.Servo9.AutoSize = True
        Me.Servo9.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Servo9.Inverse = False
        Me.Servo9.Location = New System.Drawing.Point(163, 204)
        Me.Servo9.MaxPulse = 0
        Me.Servo9.MinPulse = 0
        Me.Servo9.Name = "Servo9"
        Me.Servo9.PreviousValue = 90
        Me.Servo9.Selected = System.Windows.Forms.CheckState.Indeterminate
        Me.Servo9.ServoID = "J"
        Me.Servo9.Size = New System.Drawing.Size(195, 61)
        Me.Servo9.TabIndex = 22
        Me.Servo9.Tag = ""
        Me.Servo9.Value = 90
        '
        'Servo3
        '
        Me.Servo3.AutoSize = True
        Me.Servo3.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Servo3.Inverse = False
        Me.Servo3.Location = New System.Drawing.Point(163, 488)
        Me.Servo3.MaxPulse = 0
        Me.Servo3.MinPulse = 0
        Me.Servo3.Name = "Servo3"
        Me.Servo3.PreviousValue = 90
        Me.Servo3.Selected = System.Windows.Forms.CheckState.Indeterminate
        Me.Servo3.ServoID = "D"
        Me.Servo3.Size = New System.Drawing.Size(195, 61)
        Me.Servo3.TabIndex = 9
        Me.Servo3.Tag = ""
        Me.Servo3.Value = 90
        '
        'Servo4
        '
        Me.Servo4.AutoSize = True
        Me.Servo4.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Servo4.Inverse = False
        Me.Servo4.Location = New System.Drawing.Point(58, 555)
        Me.Servo4.MaxPulse = 0
        Me.Servo4.MinPulse = 0
        Me.Servo4.Name = "Servo4"
        Me.Servo4.PreviousValue = 90
        Me.Servo4.Selected = System.Windows.Forms.CheckState.Indeterminate
        Me.Servo4.ServoID = "E"
        Me.Servo4.Size = New System.Drawing.Size(195, 61)
        Me.Servo4.TabIndex = 8
        Me.Servo4.Tag = ""
        Me.Servo4.Value = 90
        '
        'Servo2
        '
        Me.Servo2.AutoSize = True
        Me.Servo2.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Servo2.Inverse = True
        Me.Servo2.Location = New System.Drawing.Point(570, 487)
        Me.Servo2.MaxPulse = 0
        Me.Servo2.MinPulse = 0
        Me.Servo2.Name = "Servo2"
        Me.Servo2.PreviousValue = 90
        Me.Servo2.Selected = System.Windows.Forms.CheckState.Indeterminate
        Me.Servo2.ServoID = "C"
        Me.Servo2.Size = New System.Drawing.Size(195, 62)
        Me.Servo2.TabIndex = 5
        Me.Servo2.Tag = ""
        Me.Servo2.Value = 90
        '
        'Servo1
        '
        Me.Servo1.AutoSize = True
        Me.Servo1.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Servo1.Inverse = True
        Me.Servo1.Location = New System.Drawing.Point(656, 555)
        Me.Servo1.MaxPulse = 0
        Me.Servo1.MinPulse = 0
        Me.Servo1.Name = "Servo1"
        Me.Servo1.PreviousValue = 90
        Me.Servo1.Selected = System.Windows.Forms.CheckState.Indeterminate
        Me.Servo1.ServoID = "B"
        Me.Servo1.Size = New System.Drawing.Size(195, 61)
        Me.Servo1.TabIndex = 4
        Me.Servo1.Tag = ""
        Me.Servo1.Value = 90
        '
        'lblQtExecutar
        '
        Me.lblQtExecutar.AutoSize = True
        Me.lblQtExecutar.Location = New System.Drawing.Point(1152, 513)
        Me.lblQtExecutar.Name = "lblQtExecutar"
        Me.lblQtExecutar.Size = New System.Drawing.Size(25, 13)
        Me.lblQtExecutar.TabIndex = 57
        Me.lblQtExecutar.Text = "Qt:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 731)
        Me.Controls.Add(Me.lblQtExecutar)
        Me.Controls.Add(Me.lblPausaEntreEnvios)
        Me.Controls.Add(Me.Servo14)
        Me.Controls.Add(Me.Servo17)
        Me.Controls.Add(Me.Servo13)
        Me.Controls.Add(Me.Servo16)
        Me.Controls.Add(Me.Servo12)
        Me.Controls.Add(Me.Servo15)
        Me.Controls.Add(Me.Servo10)
        Me.Controls.Add(Me.txtPausaEntreEnvios)
        Me.Controls.Add(Me.Servo5)
        Me.Controls.Add(Me.btnExecutarTudo)
        Me.Controls.Add(Me.Servo0)
        Me.Controls.Add(Me.btnInicializar)
        Me.Controls.Add(Me.btnReferenciar)
        Me.Controls.Add(Me.txtQtExecutar)
        Me.Controls.Add(Me.chkAtivar)
        Me.Controls.Add(Me.btnDesligar)
        Me.Controls.Add(Me.btnExecutarPosições)
        Me.Controls.Add(Me.btnParaBaixo)
        Me.Controls.Add(Me.btnParaCima)
        Me.Controls.Add(Me.btnAbrir)
        Me.Controls.Add(Me.Servo8)
        Me.Controls.Add(Me.Servo11)
        Me.Controls.Add(Me.Servo6)
        Me.Controls.Add(Me.Servo7)
        Me.Controls.Add(Me.Servo9)
        Me.Controls.Add(Me.btnPausa)
        Me.Controls.Add(Me.txtPorta)
        Me.Controls.Add(Me.txtEndereço)
        Me.Controls.Add(Me.btnExecutar)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.lbMovimentos)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.lbPosições)
        Me.Controls.Add(Me.Servo3)
        Me.Controls.Add(Me.Servo4)
        Me.Controls.Add(Me.Servo2)
        Me.Controls.Add(Me.Servo1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnOff)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.Text = "JARVIS mgen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOff As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Servo1 As Slider
    Friend WithEvents Servo2 As Slider
    Friend WithEvents Servo4 As Slider
    Friend WithEvents Servo3 As Slider
    Friend WithEvents lbPosições As ListBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnGravar As Button
    Friend WithEvents lbMovimentos As ListBox
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnExecutar As Button
    Friend WithEvents txtEndereço As TextBox
    Friend WithEvents txtPorta As TextBox
    Friend WithEvents btnPausa As Button
    Friend WithEvents Servo9 As Slider
    Friend WithEvents Servo7 As Slider
    Friend WithEvents Servo6 As Slider
    Friend WithEvents Servo11 As Slider
    Friend WithEvents Servo8 As Slider
    Friend WithEvents btnAbrir As Button
    Friend WithEvents btnParaCima As Button
    Friend WithEvents btnParaBaixo As Button
    Friend WithEvents btnExecutarPosições As Button
    Friend WithEvents btnDesligar As Button
    Friend WithEvents chkAtivar As CheckBox
    Friend WithEvents txtQtExecutar As TextBox
    Friend WithEvents btnReferenciar As Button
    Friend WithEvents btnInicializar As Button
    Friend WithEvents Servo0 As Slider
    Friend WithEvents btnExecutarTudo As Button
    Friend WithEvents Servo5 As Slider
    Friend WithEvents txtPausaEntreEnvios As TextBox
    Friend WithEvents Servo10 As Slider
    Friend WithEvents Servo15 As Slider
    Friend WithEvents Servo12 As Slider
    Friend WithEvents Servo16 As Slider
    Friend WithEvents Servo13 As Slider
    Friend WithEvents Servo17 As Slider
    Friend WithEvents Servo14 As Slider
    Friend WithEvents lblPausaEntreEnvios As Label
    Friend WithEvents lblQtExecutar As Label
End Class
