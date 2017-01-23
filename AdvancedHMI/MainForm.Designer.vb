<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '   <System.Diagnostics.DebuggerNonUserCode()> _
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
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.DF1Com1 = New AdvancedHMIDrivers.DF1Com(Me.components)
        Me.MomentaryButton1 = New AdvancedHMIControls.MomentaryButton()
        Me.MomentaryButton2 = New AdvancedHMIControls.MomentaryButton()
        Me.PilotLight1 = New AdvancedHMIControls.PilotLight()
        Me.Tank1 = New AdvancedHMIControls.Tank()
        Me.BasicLabel7 = New AdvancedHMIControls.BasicLabel()
        Me.PilotLight2 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight3 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight5 = New AdvancedHMIControls.PilotLight()
        Me.BasicButton3 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton4 = New AdvancedHMIControls.BasicButton()
        Me.PilotLight6 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight7 = New AdvancedHMIControls.PilotLight()
        Me.BasicButton5 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton6 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton7 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton8 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton9 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton10 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton11 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton12 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton13 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton14 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton15 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton16 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton17 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton18 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton19 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton20 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton21 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton22 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton23 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton24 = New AdvancedHMIControls.BasicButton()
        Me.BasicButton25 = New AdvancedHMIControls.BasicButton()
        Me.BasicLabel8 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel9 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel10 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel11 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel12 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel13 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel14 = New AdvancedHMIControls.BasicLabel()
        Me.MessageDisplayByValue1 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MessageDisplayByValue2 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MessageDisplayByValue3 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MessageDisplayByValue4 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MessageDisplayByValue5 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MessageDisplayByValue6 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.MessageDisplayByValue7 = New AdvancedHMIControls.MessageDisplayByValue()
        Me.BasicButton26 = New AdvancedHMIControls.BasicButton()
        Me.BasicLabel5 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel6 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel15 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel16 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel17 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel18 = New AdvancedHMIControls.BasicLabel()
        Me.PilotLight4 = New AdvancedHMIControls.PilotLight()
        Me.BasicLabel1 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel2 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel3 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel4 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel19 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel20 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel21 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel22 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel23 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel24 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel25 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel26 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel27 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel28 = New AdvancedHMIControls.BasicLabel()
        Me.SuspendLayout()
        '
        'DF1Com1
        '
        Me.DF1Com1.BaudRate = "AUTO"
        Me.DF1Com1.CheckSumType = MfgControl.AdvancedHMI.Drivers.DF1Transport.ChecksumOptions.Crc
        Me.DF1Com1.ComPort = "COM5"
        Me.DF1Com1.DisableSubscriptions = False
        Me.DF1Com1.MyNode = 0
        Me.DF1Com1.Parity = System.IO.Ports.Parity.None
        Me.DF1Com1.PollRateOverride = 500
        Me.DF1Com1.SynchronizingObject = Me
        Me.DF1Com1.TargetNode = 0
        '
        'MomentaryButton1
        '
        Me.MomentaryButton1.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green
        Me.MomentaryButton1.CommComponent = Me.DF1Com1
        Me.MomentaryButton1.Cursor = System.Windows.Forms.Cursors.Default
        Me.MomentaryButton1.ForeColor = System.Drawing.Color.Black
        Me.MomentaryButton1.LegendPlate = MfgControl.AdvancedHMI.Controls.PushButton.LegendPlates.Large
        Me.MomentaryButton1.Location = New System.Drawing.Point(14, 12)
        Me.MomentaryButton1.Name = "MomentaryButton1"
        Me.MomentaryButton1.OutputType = MfgControl.AdvancedHMI.Controls.PushButton.OutputTypes.MomentarySet
        Me.MomentaryButton1.PLCAddressClick = "B3:3/3"
        Me.MomentaryButton1.PLCAddressVisible = ""
        Me.MomentaryButton1.Size = New System.Drawing.Size(75, 110)
        Me.MomentaryButton1.TabIndex = 43
        Me.MomentaryButton1.Text = "Start"
        '
        'MomentaryButton2
        '
        Me.MomentaryButton2.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Red
        Me.MomentaryButton2.CommComponent = Me.DF1Com1
        Me.MomentaryButton2.ForeColor = System.Drawing.Color.Black
        Me.MomentaryButton2.LegendPlate = MfgControl.AdvancedHMI.Controls.PushButton.LegendPlates.Large
        Me.MomentaryButton2.Location = New System.Drawing.Point(95, 12)
        Me.MomentaryButton2.Name = "MomentaryButton2"
        Me.MomentaryButton2.OutputType = MfgControl.AdvancedHMI.Controls.PushButton.OutputTypes.MomentarySet
        Me.MomentaryButton2.PLCAddressClick = "B3:3/2"
        Me.MomentaryButton2.PLCAddressVisible = ""
        Me.MomentaryButton2.Size = New System.Drawing.Size(75, 110)
        Me.MomentaryButton2.TabIndex = 46
        Me.MomentaryButton2.Text = "Stop"
        '
        'PilotLight1
        '
        Me.PilotLight1.Blink = False
        Me.PilotLight1.CommComponent = Me.DF1Com1
        Me.PilotLight1.ForeColor = System.Drawing.Color.Black
        Me.PilotLight1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight1.Location = New System.Drawing.Point(208, 12)
        Me.PilotLight1.Name = "PilotLight1"
        Me.PilotLight1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight1.PLCAddressClick = ""
        Me.PilotLight1.PLCAddressText = ""
        Me.PilotLight1.PLCAddressValue = "B3:3/8"
        Me.PilotLight1.PLCAddressVisible = ""
        Me.PilotLight1.Size = New System.Drawing.Size(75, 110)
        Me.PilotLight1.TabIndex = 48
        Me.PilotLight1.Text = "System Running"
        Me.PilotLight1.Value = False
        '
        'Tank1
        '
        Me.Tank1.CommComponent = Me.DF1Com1
        Me.Tank1.ForeColor = System.Drawing.Color.White
        Me.Tank1.HighlightColor = System.Drawing.Color.Red
        Me.Tank1.HighlightKeyCharacter = "!"
        Me.Tank1.KeypadText = Nothing
        Me.Tank1.Location = New System.Drawing.Point(14, 144)
        Me.Tank1.MaxValue = 100
        Me.Tank1.MinValue = 0
        Me.Tank1.Name = "Tank1"
        Me.Tank1.NumericFormat = Nothing
        Me.Tank1.PLCAddressKeypad = ""
        Me.Tank1.PLCAddressText = ""
        Me.Tank1.PLCAddressValue = "F8:2"
        Me.Tank1.PLCAddressVisible = ""
        Me.Tank1.ScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Tank1.Size = New System.Drawing.Size(159, 249)
        Me.Tank1.TabIndex = 49
        Me.Tank1.TankContentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Tank1.TextPrefix = Nothing
        Me.Tank1.TextSuffix = Nothing
        Me.Tank1.Value = 0.0!
        Me.Tank1.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'BasicLabel7
        '
        Me.BasicLabel7.AutoSize = True
        Me.BasicLabel7.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel7.CommComponent = Me.DF1Com1
        Me.BasicLabel7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel7.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel7.HighlightKeyCharacter = "!"
        Me.BasicLabel7.KeypadAlpahNumeric = False
        Me.BasicLabel7.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel7.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel7.KeypadMaxValue = 0.0R
        Me.BasicLabel7.KeypadMinValue = 0.0R
        Me.BasicLabel7.KeypadScaleFactor = 1.0R
        Me.BasicLabel7.KeypadShowCurrentValue = False
        Me.BasicLabel7.KeypadText = Nothing
        Me.BasicLabel7.KeypadWidth = 300
        Me.BasicLabel7.Location = New System.Drawing.Point(286, 135)
        Me.BasicLabel7.Name = "BasicLabel7"
        Me.BasicLabel7.NumericFormat = Nothing
        Me.BasicLabel7.PLCAddressKeypad = ""
        Me.BasicLabel7.PLCAddressValue = "N7:7"
        Me.BasicLabel7.PLCAddressVisible = "B3:4/6"
        Me.BasicLabel7.PollRate = 0
        Me.BasicLabel7.Size = New System.Drawing.Size(69, 13)
        Me.BasicLabel7.TabIndex = 66
        Me.BasicLabel7.Text = "BasicLabel"
        Me.BasicLabel7.Value = "BasicLabel"
        Me.BasicLabel7.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel7.ValueLeftPadLength = 0
        Me.BasicLabel7.ValuePrefix = Nothing
        Me.BasicLabel7.ValueScaleFactor = 1.0R
        Me.BasicLabel7.ValueSuffix = Nothing
        '
        'PilotLight2
        '
        Me.PilotLight2.Blink = False
        Me.PilotLight2.CommComponent = Me.DF1Com1
        Me.PilotLight2.ForeColor = System.Drawing.Color.Black
        Me.PilotLight2.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.PilotLight2.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red
        Me.PilotLight2.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight2.Location = New System.Drawing.Point(829, 12)
        Me.PilotLight2.Name = "PilotLight2"
        Me.PilotLight2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight2.PLCAddressClick = ""
        Me.PilotLight2.PLCAddressText = ""
        Me.PilotLight2.PLCAddressValue = "B3:4/14"
        Me.PilotLight2.PLCAddressVisible = ""
        Me.PilotLight2.Size = New System.Drawing.Size(75, 79)
        Me.PilotLight2.TabIndex = 67
        Me.PilotLight2.Text = "Level HH"
        Me.PilotLight2.Value = False
        '
        'PilotLight3
        '
        Me.PilotLight3.Blink = False
        Me.PilotLight3.CommComponent = Me.DF1Com1
        Me.PilotLight3.ForeColor = System.Drawing.Color.Black
        Me.PilotLight3.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.PilotLight3.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red
        Me.PilotLight3.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight3.Location = New System.Drawing.Point(829, 267)
        Me.PilotLight3.Name = "PilotLight3"
        Me.PilotLight3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight3.PLCAddressClick = ""
        Me.PilotLight3.PLCAddressText = ""
        Me.PilotLight3.PLCAddressValue = "B3:4/10"
        Me.PilotLight3.PLCAddressVisible = ""
        Me.PilotLight3.Size = New System.Drawing.Size(75, 79)
        Me.PilotLight3.TabIndex = 68
        Me.PilotLight3.Text = "Low Flow"
        Me.PilotLight3.Value = False
        '
        'PilotLight5
        '
        Me.PilotLight5.Blink = False
        Me.PilotLight5.CommComponent = Me.DF1Com1
        Me.PilotLight5.ForeColor = System.Drawing.Color.Black
        Me.PilotLight5.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.PilotLight5.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red
        Me.PilotLight5.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight5.Location = New System.Drawing.Point(829, 97)
        Me.PilotLight5.Name = "PilotLight5"
        Me.PilotLight5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight5.PLCAddressClick = ""
        Me.PilotLight5.PLCAddressText = ""
        Me.PilotLight5.PLCAddressValue = "B3:4/12"
        Me.PilotLight5.PLCAddressVisible = ""
        Me.PilotLight5.Size = New System.Drawing.Size(75, 79)
        Me.PilotLight5.TabIndex = 70
        Me.PilotLight5.Text = "Level LL"
        Me.PilotLight5.Value = False
        '
        'BasicButton3
        '
        Me.BasicButton3.BackColor = System.Drawing.Color.Black
        Me.BasicButton3.CommComponent = Me.DF1Com1
        Me.BasicButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicButton3.ForeColor = System.Drawing.Color.Red
        Me.BasicButton3.Highlight = False
        Me.BasicButton3.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton3.Location = New System.Drawing.Point(829, 391)
        Me.BasicButton3.MaximumHoldTime = 3000
        Me.BasicButton3.MinimumHoldTime = 500
        Me.BasicButton3.Name = "BasicButton3"
        Me.BasicButton3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton3.PLCAddressClick = "B3:3/10"
        Me.BasicButton3.SelectTextAlternate = False
        Me.BasicButton3.Size = New System.Drawing.Size(75, 23)
        Me.BasicButton3.TabIndex = 64
        Me.BasicButton3.Text = "Silence"
        Me.BasicButton3.TextAlternate = Nothing
        Me.BasicButton3.UseVisualStyleBackColor = False
        Me.BasicButton3.ValueToWrite = 0
        '
        'BasicButton4
        '
        Me.BasicButton4.BackColor = System.Drawing.Color.Black
        Me.BasicButton4.CommComponent = Me.DF1Com1
        Me.BasicButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicButton4.ForeColor = System.Drawing.Color.Red
        Me.BasicButton4.Highlight = False
        Me.BasicButton4.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton4.Location = New System.Drawing.Point(829, 420)
        Me.BasicButton4.MaximumHoldTime = 3000
        Me.BasicButton4.MinimumHoldTime = 500
        Me.BasicButton4.Name = "BasicButton4"
        Me.BasicButton4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton4.PLCAddressClick = "B3:3/9"
        Me.BasicButton4.SelectTextAlternate = False
        Me.BasicButton4.Size = New System.Drawing.Size(75, 23)
        Me.BasicButton4.TabIndex = 71
        Me.BasicButton4.Text = "Reset"
        Me.BasicButton4.TextAlternate = Nothing
        Me.BasicButton4.UseVisualStyleBackColor = False
        Me.BasicButton4.ValueToWrite = 0
        '
        'PilotLight6
        '
        Me.PilotLight6.Blink = False
        Me.PilotLight6.CommComponent = Me.DF1Com1
        Me.PilotLight6.ForeColor = System.Drawing.Color.Black
        Me.PilotLight6.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight6.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Yellow
        Me.PilotLight6.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight6.Location = New System.Drawing.Point(370, 12)
        Me.PilotLight6.Name = "PilotLight6"
        Me.PilotLight6.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight6.PLCAddressClick = ""
        Me.PilotLight6.PLCAddressText = ""
        Me.PilotLight6.PLCAddressValue = "B3:4/5"
        Me.PilotLight6.PLCAddressVisible = ""
        Me.PilotLight6.Size = New System.Drawing.Size(75, 110)
        Me.PilotLight6.TabIndex = 72
        Me.PilotLight6.Text = "Backwash Pending"
        Me.PilotLight6.Value = False
        '
        'PilotLight7
        '
        Me.PilotLight7.Blink = False
        Me.PilotLight7.CommComponent = Me.DF1Com1
        Me.PilotLight7.ForeColor = System.Drawing.Color.Black
        Me.PilotLight7.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight7.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Blue
        Me.PilotLight7.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight7.Location = New System.Drawing.Point(289, 12)
        Me.PilotLight7.Name = "PilotLight7"
        Me.PilotLight7.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight7.PLCAddressClick = ""
        Me.PilotLight7.PLCAddressText = ""
        Me.PilotLight7.PLCAddressValue = "B3:4/6"
        Me.PilotLight7.PLCAddressVisible = ""
        Me.PilotLight7.Size = New System.Drawing.Size(75, 110)
        Me.PilotLight7.TabIndex = 73
        Me.PilotLight7.Text = "Backwash Running"
        Me.PilotLight7.Value = False
        '
        'BasicButton5
        '
        Me.BasicButton5.BackColor = System.Drawing.Color.Black
        Me.BasicButton5.CommComponent = Me.DF1Com1
        Me.BasicButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicButton5.ForeColor = System.Drawing.Color.White
        Me.BasicButton5.Highlight = False
        Me.BasicButton5.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton5.Location = New System.Drawing.Point(498, 12)
        Me.BasicButton5.MaximumHoldTime = 3000
        Me.BasicButton5.MinimumHoldTime = 500
        Me.BasicButton5.Name = "BasicButton5"
        Me.BasicButton5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton5.PLCAddressClick = "B3:0/9"
        Me.BasicButton5.SelectTextAlternate = False
        Me.BasicButton5.Size = New System.Drawing.Size(75, 23)
        Me.BasicButton5.TabIndex = 74
        Me.BasicButton5.Text = "HAND"
        Me.BasicButton5.TextAlternate = Nothing
        Me.BasicButton5.UseVisualStyleBackColor = False
        Me.BasicButton5.ValueToWrite = 1
        '
        'BasicButton6
        '
        Me.BasicButton6.BackColor = System.Drawing.Color.Black
        Me.BasicButton6.CommComponent = Me.DF1Com1
        Me.BasicButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicButton6.ForeColor = System.Drawing.Color.White
        Me.BasicButton6.Highlight = False
        Me.BasicButton6.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton6.Location = New System.Drawing.Point(660, 12)
        Me.BasicButton6.MaximumHoldTime = 3000
        Me.BasicButton6.MinimumHoldTime = 500
        Me.BasicButton6.Name = "BasicButton6"
        Me.BasicButton6.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton6.PLCAddressClick = "B3:0/10"
        Me.BasicButton6.SelectTextAlternate = False
        Me.BasicButton6.Size = New System.Drawing.Size(75, 23)
        Me.BasicButton6.TabIndex = 75
        Me.BasicButton6.Text = "AUTO"
        Me.BasicButton6.TextAlternate = Nothing
        Me.BasicButton6.UseVisualStyleBackColor = False
        Me.BasicButton6.ValueToWrite = 1
        '
        'BasicButton7
        '
        Me.BasicButton7.BackColor = System.Drawing.Color.Black
        Me.BasicButton7.CommComponent = Me.DF1Com1
        Me.BasicButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicButton7.ForeColor = System.Drawing.Color.White
        Me.BasicButton7.Highlight = False
        Me.BasicButton7.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton7.Location = New System.Drawing.Point(579, 12)
        Me.BasicButton7.MaximumHoldTime = 3000
        Me.BasicButton7.MinimumHoldTime = 500
        Me.BasicButton7.Name = "BasicButton7"
        Me.BasicButton7.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton7.PLCAddressClick = "B3:0/8"
        Me.BasicButton7.SelectTextAlternate = False
        Me.BasicButton7.Size = New System.Drawing.Size(75, 23)
        Me.BasicButton7.TabIndex = 76
        Me.BasicButton7.Text = "OFF"
        Me.BasicButton7.TextAlternate = Nothing
        Me.BasicButton7.UseVisualStyleBackColor = False
        Me.BasicButton7.ValueToWrite = 1
        '
        'BasicButton8
        '
        Me.BasicButton8.BackColor = System.Drawing.Color.Black
        Me.BasicButton8.CommComponent = Me.DF1Com1
        Me.BasicButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicButton8.ForeColor = System.Drawing.Color.White
        Me.BasicButton8.Highlight = False
        Me.BasicButton8.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton8.Location = New System.Drawing.Point(579, 41)
        Me.BasicButton8.MaximumHoldTime = 3000
        Me.BasicButton8.MinimumHoldTime = 500
        Me.BasicButton8.Name = "BasicButton8"
        Me.BasicButton8.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton8.PLCAddressClick = "B3:0/11"
        Me.BasicButton8.SelectTextAlternate = False
        Me.BasicButton8.Size = New System.Drawing.Size(75, 23)
        Me.BasicButton8.TabIndex = 79
        Me.BasicButton8.Text = "OFF"
        Me.BasicButton8.TextAlternate = Nothing
        Me.BasicButton8.UseVisualStyleBackColor = False
        Me.BasicButton8.ValueToWrite = 1
        '
        'BasicButton9
        '
        Me.BasicButton9.BackColor = System.Drawing.Color.Black
        Me.BasicButton9.CommComponent = Me.DF1Com1
        Me.BasicButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicButton9.ForeColor = System.Drawing.Color.White
        Me.BasicButton9.Highlight = False
        Me.BasicButton9.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton9.Location = New System.Drawing.Point(660, 41)
        Me.BasicButton9.MaximumHoldTime = 3000
        Me.BasicButton9.MinimumHoldTime = 500
        Me.BasicButton9.Name = "BasicButton9"
        Me.BasicButton9.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton9.PLCAddressClick = "B3:0/13"
        Me.BasicButton9.SelectTextAlternate = False
        Me.BasicButton9.Size = New System.Drawing.Size(75, 23)
        Me.BasicButton9.TabIndex = 78
        Me.BasicButton9.Text = "AUTO"
        Me.BasicButton9.TextAlternate = Nothing
        Me.BasicButton9.UseVisualStyleBackColor = False
        Me.BasicButton9.ValueToWrite = 1
        '
        'BasicButton10
        '
        Me.BasicButton10.BackColor = System.Drawing.Color.Black
        Me.BasicButton10.CommComponent = Me.DF1Com1
        Me.BasicButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicButton10.ForeColor = System.Drawing.Color.White
        Me.BasicButton10.Highlight = False
        Me.BasicButton10.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton10.Location = New System.Drawing.Point(498, 41)
        Me.BasicButton10.MaximumHoldTime = 3000
        Me.BasicButton10.MinimumHoldTime = 500
        Me.BasicButton10.Name = "BasicButton10"
        Me.BasicButton10.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton10.PLCAddressClick = "B3:0/12"
        Me.BasicButton10.SelectTextAlternate = False
        Me.BasicButton10.Size = New System.Drawing.Size(75, 23)
        Me.BasicButton10.TabIndex = 77
        Me.BasicButton10.Text = "HAND"
        Me.BasicButton10.TextAlternate = Nothing
        Me.BasicButton10.UseVisualStyleBackColor = False
        Me.BasicButton10.ValueToWrite = 1
        '
        'BasicButton11
        '
        Me.BasicButton11.BackColor = System.Drawing.Color.Black
        Me.BasicButton11.CommComponent = Me.DF1Com1
        Me.BasicButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicButton11.ForeColor = System.Drawing.Color.White
        Me.BasicButton11.Highlight = False
        Me.BasicButton11.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton11.Location = New System.Drawing.Point(579, 70)
        Me.BasicButton11.MaximumHoldTime = 3000
        Me.BasicButton11.MinimumHoldTime = 500
        Me.BasicButton11.Name = "BasicButton11"
        Me.BasicButton11.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton11.PLCAddressClick = "B3:0/14"
        Me.BasicButton11.SelectTextAlternate = False
        Me.BasicButton11.Size = New System.Drawing.Size(75, 23)
        Me.BasicButton11.TabIndex = 82
        Me.BasicButton11.Text = "OFF"
        Me.BasicButton11.TextAlternate = Nothing
        Me.BasicButton11.UseVisualStyleBackColor = False
        Me.BasicButton11.ValueToWrite = 1
        '
        'BasicButton12
        '
        Me.BasicButton12.BackColor = System.Drawing.Color.Black
        Me.BasicButton12.CommComponent = Me.DF1Com1
        Me.BasicButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicButton12.ForeColor = System.Drawing.Color.White
        Me.BasicButton12.Highlight = False
        Me.BasicButton12.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton12.Location = New System.Drawing.Point(660, 70)
        Me.BasicButton12.MaximumHoldTime = 3000
        Me.BasicButton12.MinimumHoldTime = 500
        Me.BasicButton12.Name = "BasicButton12"
        Me.BasicButton12.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton12.PLCAddressClick = "B3:1/0"
        Me.BasicButton12.SelectTextAlternate = False
        Me.BasicButton12.Size = New System.Drawing.Size(75, 23)
        Me.BasicButton12.TabIndex = 81
        Me.BasicButton12.Text = "AUTO"
        Me.BasicButton12.TextAlternate = Nothing
        Me.BasicButton12.UseVisualStyleBackColor = False
        Me.BasicButton12.ValueToWrite = 1
        '
        'BasicButton13
        '
        Me.BasicButton13.BackColor = System.Drawing.Color.Black
        Me.BasicButton13.CommComponent = Me.DF1Com1
        Me.BasicButton13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicButton13.ForeColor = System.Drawing.Color.White
        Me.BasicButton13.Highlight = False
        Me.BasicButton13.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton13.Location = New System.Drawing.Point(498, 70)
        Me.BasicButton13.MaximumHoldTime = 3000
        Me.BasicButton13.MinimumHoldTime = 500
        Me.BasicButton13.Name = "BasicButton13"
        Me.BasicButton13.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton13.PLCAddressClick = "B3:0/15"
        Me.BasicButton13.SelectTextAlternate = False
        Me.BasicButton13.Size = New System.Drawing.Size(75, 23)
        Me.BasicButton13.TabIndex = 80
        Me.BasicButton13.Text = "HAND"
        Me.BasicButton13.TextAlternate = Nothing
        Me.BasicButton13.UseVisualStyleBackColor = False
        Me.BasicButton13.ValueToWrite = 1
        '
        'BasicButton14
        '
        Me.BasicButton14.BackColor = System.Drawing.Color.Black
        Me.BasicButton14.CommComponent = Me.DF1Com1
        Me.BasicButton14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicButton14.ForeColor = System.Drawing.Color.White
        Me.BasicButton14.Highlight = False
        Me.BasicButton14.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton14.Location = New System.Drawing.Point(579, 99)
        Me.BasicButton14.MaximumHoldTime = 3000
        Me.BasicButton14.MinimumHoldTime = 500
        Me.BasicButton14.Name = "BasicButton14"
        Me.BasicButton14.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton14.PLCAddressClick = "B3:1/1"
        Me.BasicButton14.SelectTextAlternate = False
        Me.BasicButton14.Size = New System.Drawing.Size(75, 23)
        Me.BasicButton14.TabIndex = 85
        Me.BasicButton14.Text = "OFF"
        Me.BasicButton14.TextAlternate = Nothing
        Me.BasicButton14.UseVisualStyleBackColor = False
        Me.BasicButton14.ValueToWrite = 1
        '
        'BasicButton15
        '
        Me.BasicButton15.BackColor = System.Drawing.Color.Black
        Me.BasicButton15.CommComponent = Me.DF1Com1
        Me.BasicButton15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicButton15.ForeColor = System.Drawing.Color.White
        Me.BasicButton15.Highlight = False
        Me.BasicButton15.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton15.Location = New System.Drawing.Point(660, 99)
        Me.BasicButton15.MaximumHoldTime = 3000
        Me.BasicButton15.MinimumHoldTime = 500
        Me.BasicButton15.Name = "BasicButton15"
        Me.BasicButton15.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton15.PLCAddressClick = "B3:1/3"
        Me.BasicButton15.SelectTextAlternate = False
        Me.BasicButton15.Size = New System.Drawing.Size(75, 23)
        Me.BasicButton15.TabIndex = 84
        Me.BasicButton15.Text = "AUTO"
        Me.BasicButton15.TextAlternate = Nothing
        Me.BasicButton15.UseVisualStyleBackColor = False
        Me.BasicButton15.ValueToWrite = 1
        '
        'BasicButton16
        '
        Me.BasicButton16.BackColor = System.Drawing.Color.Black
        Me.BasicButton16.CommComponent = Me.DF1Com1
        Me.BasicButton16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicButton16.ForeColor = System.Drawing.Color.White
        Me.BasicButton16.Highlight = False
        Me.BasicButton16.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton16.Location = New System.Drawing.Point(498, 99)
        Me.BasicButton16.MaximumHoldTime = 3000
        Me.BasicButton16.MinimumHoldTime = 500
        Me.BasicButton16.Name = "BasicButton16"
        Me.BasicButton16.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton16.PLCAddressClick = "B3:1/2"
        Me.BasicButton16.SelectTextAlternate = False
        Me.BasicButton16.Size = New System.Drawing.Size(75, 23)
        Me.BasicButton16.TabIndex = 83
        Me.BasicButton16.Text = "HAND"
        Me.BasicButton16.TextAlternate = Nothing
        Me.BasicButton16.UseVisualStyleBackColor = False
        Me.BasicButton16.ValueToWrite = 1
        '
        'BasicButton17
        '
        Me.BasicButton17.BackColor = System.Drawing.Color.Black
        Me.BasicButton17.CommComponent = Me.DF1Com1
        Me.BasicButton17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicButton17.ForeColor = System.Drawing.Color.White
        Me.BasicButton17.Highlight = False
        Me.BasicButton17.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton17.Location = New System.Drawing.Point(579, 128)
        Me.BasicButton17.MaximumHoldTime = 3000
        Me.BasicButton17.MinimumHoldTime = 500
        Me.BasicButton17.Name = "BasicButton17"
        Me.BasicButton17.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton17.PLCAddressClick = "B3:1/4"
        Me.BasicButton17.SelectTextAlternate = False
        Me.BasicButton17.Size = New System.Drawing.Size(75, 23)
        Me.BasicButton17.TabIndex = 88
        Me.BasicButton17.Text = "OFF"
        Me.BasicButton17.TextAlternate = Nothing
        Me.BasicButton17.UseVisualStyleBackColor = False
        Me.BasicButton17.ValueToWrite = 1
        '
        'BasicButton18
        '
        Me.BasicButton18.BackColor = System.Drawing.Color.Black
        Me.BasicButton18.CommComponent = Me.DF1Com1
        Me.BasicButton18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicButton18.ForeColor = System.Drawing.Color.White
        Me.BasicButton18.Highlight = False
        Me.BasicButton18.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton18.Location = New System.Drawing.Point(660, 128)
        Me.BasicButton18.MaximumHoldTime = 3000
        Me.BasicButton18.MinimumHoldTime = 500
        Me.BasicButton18.Name = "BasicButton18"
        Me.BasicButton18.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton18.PLCAddressClick = "B3:1/6"
        Me.BasicButton18.SelectTextAlternate = False
        Me.BasicButton18.Size = New System.Drawing.Size(75, 23)
        Me.BasicButton18.TabIndex = 87
        Me.BasicButton18.Text = "AUTO"
        Me.BasicButton18.TextAlternate = Nothing
        Me.BasicButton18.UseVisualStyleBackColor = False
        Me.BasicButton18.ValueToWrite = 1
        '
        'BasicButton19
        '
        Me.BasicButton19.BackColor = System.Drawing.Color.Black
        Me.BasicButton19.CommComponent = Me.DF1Com1
        Me.BasicButton19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicButton19.ForeColor = System.Drawing.Color.White
        Me.BasicButton19.Highlight = False
        Me.BasicButton19.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton19.Location = New System.Drawing.Point(498, 128)
        Me.BasicButton19.MaximumHoldTime = 3000
        Me.BasicButton19.MinimumHoldTime = 500
        Me.BasicButton19.Name = "BasicButton19"
        Me.BasicButton19.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton19.PLCAddressClick = "B3:1/5"
        Me.BasicButton19.SelectTextAlternate = False
        Me.BasicButton19.Size = New System.Drawing.Size(75, 23)
        Me.BasicButton19.TabIndex = 86
        Me.BasicButton19.Text = "HAND"
        Me.BasicButton19.TextAlternate = Nothing
        Me.BasicButton19.UseVisualStyleBackColor = False
        Me.BasicButton19.ValueToWrite = 1
        '
        'BasicButton20
        '
        Me.BasicButton20.BackColor = System.Drawing.Color.Black
        Me.BasicButton20.CommComponent = Me.DF1Com1
        Me.BasicButton20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicButton20.ForeColor = System.Drawing.Color.White
        Me.BasicButton20.Highlight = False
        Me.BasicButton20.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton20.Location = New System.Drawing.Point(579, 157)
        Me.BasicButton20.MaximumHoldTime = 3000
        Me.BasicButton20.MinimumHoldTime = 500
        Me.BasicButton20.Name = "BasicButton20"
        Me.BasicButton20.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton20.PLCAddressClick = "B3:1/7"
        Me.BasicButton20.SelectTextAlternate = False
        Me.BasicButton20.Size = New System.Drawing.Size(75, 23)
        Me.BasicButton20.TabIndex = 91
        Me.BasicButton20.Text = "OFF"
        Me.BasicButton20.TextAlternate = Nothing
        Me.BasicButton20.UseVisualStyleBackColor = False
        Me.BasicButton20.ValueToWrite = 1
        '
        'BasicButton21
        '
        Me.BasicButton21.BackColor = System.Drawing.Color.Black
        Me.BasicButton21.CommComponent = Me.DF1Com1
        Me.BasicButton21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicButton21.ForeColor = System.Drawing.Color.White
        Me.BasicButton21.Highlight = False
        Me.BasicButton21.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton21.Location = New System.Drawing.Point(660, 157)
        Me.BasicButton21.MaximumHoldTime = 3000
        Me.BasicButton21.MinimumHoldTime = 500
        Me.BasicButton21.Name = "BasicButton21"
        Me.BasicButton21.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton21.PLCAddressClick = "B3:1/9"
        Me.BasicButton21.SelectTextAlternate = False
        Me.BasicButton21.Size = New System.Drawing.Size(75, 23)
        Me.BasicButton21.TabIndex = 90
        Me.BasicButton21.Text = "AUTO"
        Me.BasicButton21.TextAlternate = Nothing
        Me.BasicButton21.UseVisualStyleBackColor = False
        Me.BasicButton21.ValueToWrite = 1
        '
        'BasicButton22
        '
        Me.BasicButton22.BackColor = System.Drawing.Color.Black
        Me.BasicButton22.CommComponent = Me.DF1Com1
        Me.BasicButton22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicButton22.ForeColor = System.Drawing.Color.White
        Me.BasicButton22.Highlight = False
        Me.BasicButton22.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton22.Location = New System.Drawing.Point(498, 157)
        Me.BasicButton22.MaximumHoldTime = 3000
        Me.BasicButton22.MinimumHoldTime = 500
        Me.BasicButton22.Name = "BasicButton22"
        Me.BasicButton22.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton22.PLCAddressClick = "B3:1/8"
        Me.BasicButton22.SelectTextAlternate = False
        Me.BasicButton22.Size = New System.Drawing.Size(75, 23)
        Me.BasicButton22.TabIndex = 89
        Me.BasicButton22.Text = "HAND"
        Me.BasicButton22.TextAlternate = Nothing
        Me.BasicButton22.UseVisualStyleBackColor = False
        Me.BasicButton22.ValueToWrite = 1
        '
        'BasicButton23
        '
        Me.BasicButton23.BackColor = System.Drawing.Color.Black
        Me.BasicButton23.CommComponent = Me.DF1Com1
        Me.BasicButton23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicButton23.ForeColor = System.Drawing.Color.White
        Me.BasicButton23.Highlight = False
        Me.BasicButton23.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton23.Location = New System.Drawing.Point(579, 186)
        Me.BasicButton23.MaximumHoldTime = 3000
        Me.BasicButton23.MinimumHoldTime = 500
        Me.BasicButton23.Name = "BasicButton23"
        Me.BasicButton23.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton23.PLCAddressClick = "B3:1/10"
        Me.BasicButton23.SelectTextAlternate = False
        Me.BasicButton23.Size = New System.Drawing.Size(75, 23)
        Me.BasicButton23.TabIndex = 94
        Me.BasicButton23.Text = "OFF"
        Me.BasicButton23.TextAlternate = Nothing
        Me.BasicButton23.UseVisualStyleBackColor = False
        Me.BasicButton23.ValueToWrite = 1
        '
        'BasicButton24
        '
        Me.BasicButton24.BackColor = System.Drawing.Color.Black
        Me.BasicButton24.CommComponent = Me.DF1Com1
        Me.BasicButton24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicButton24.ForeColor = System.Drawing.Color.White
        Me.BasicButton24.Highlight = False
        Me.BasicButton24.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton24.Location = New System.Drawing.Point(660, 186)
        Me.BasicButton24.MaximumHoldTime = 3000
        Me.BasicButton24.MinimumHoldTime = 500
        Me.BasicButton24.Name = "BasicButton24"
        Me.BasicButton24.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton24.PLCAddressClick = "B3:1/12"
        Me.BasicButton24.SelectTextAlternate = False
        Me.BasicButton24.Size = New System.Drawing.Size(75, 23)
        Me.BasicButton24.TabIndex = 93
        Me.BasicButton24.Text = "AUTO"
        Me.BasicButton24.TextAlternate = Nothing
        Me.BasicButton24.UseVisualStyleBackColor = False
        Me.BasicButton24.ValueToWrite = 1
        '
        'BasicButton25
        '
        Me.BasicButton25.BackColor = System.Drawing.Color.Black
        Me.BasicButton25.CommComponent = Me.DF1Com1
        Me.BasicButton25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicButton25.ForeColor = System.Drawing.Color.White
        Me.BasicButton25.Highlight = False
        Me.BasicButton25.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton25.Location = New System.Drawing.Point(498, 186)
        Me.BasicButton25.MaximumHoldTime = 3000
        Me.BasicButton25.MinimumHoldTime = 500
        Me.BasicButton25.Name = "BasicButton25"
        Me.BasicButton25.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton25.PLCAddressClick = "B3:1/11"
        Me.BasicButton25.SelectTextAlternate = False
        Me.BasicButton25.Size = New System.Drawing.Size(75, 23)
        Me.BasicButton25.TabIndex = 92
        Me.BasicButton25.Text = "HAND"
        Me.BasicButton25.TextAlternate = Nothing
        Me.BasicButton25.UseVisualStyleBackColor = False
        Me.BasicButton25.ValueToWrite = 1
        '
        'BasicLabel8
        '
        Me.BasicLabel8.AutoSize = True
        Me.BasicLabel8.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel8.CommComponent = Me.DF1Com1
        Me.BasicLabel8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel8.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel8.HighlightKeyCharacter = "!"
        Me.BasicLabel8.KeypadAlpahNumeric = False
        Me.BasicLabel8.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel8.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel8.KeypadMaxValue = 0.0R
        Me.BasicLabel8.KeypadMinValue = 0.0R
        Me.BasicLabel8.KeypadScaleFactor = 1.0R
        Me.BasicLabel8.KeypadShowCurrentValue = False
        Me.BasicLabel8.KeypadText = Nothing
        Me.BasicLabel8.KeypadWidth = 300
        Me.BasicLabel8.Location = New System.Drawing.Point(458, 17)
        Me.BasicLabel8.Name = "BasicLabel8"
        Me.BasicLabel8.NumericFormat = Nothing
        Me.BasicLabel8.PLCAddressKeypad = ""
        Me.BasicLabel8.PLCAddressValue = "N7:7"
        Me.BasicLabel8.PLCAddressVisible = "B3:4/8"
        Me.BasicLabel8.PollRate = 0
        Me.BasicLabel8.Size = New System.Drawing.Size(34, 13)
        Me.BasicLabel8.TabIndex = 95
        Me.BasicLabel8.Text = "SV-1"
        Me.BasicLabel8.Value = "SV-1"
        Me.BasicLabel8.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel8.ValueLeftPadLength = 0
        Me.BasicLabel8.ValuePrefix = Nothing
        Me.BasicLabel8.ValueScaleFactor = 1.0R
        Me.BasicLabel8.ValueSuffix = Nothing
        '
        'BasicLabel9
        '
        Me.BasicLabel9.AutoSize = True
        Me.BasicLabel9.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel9.CommComponent = Me.DF1Com1
        Me.BasicLabel9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel9.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel9.HighlightKeyCharacter = "!"
        Me.BasicLabel9.KeypadAlpahNumeric = False
        Me.BasicLabel9.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel9.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel9.KeypadMaxValue = 0.0R
        Me.BasicLabel9.KeypadMinValue = 0.0R
        Me.BasicLabel9.KeypadScaleFactor = 1.0R
        Me.BasicLabel9.KeypadShowCurrentValue = False
        Me.BasicLabel9.KeypadText = Nothing
        Me.BasicLabel9.KeypadWidth = 300
        Me.BasicLabel9.Location = New System.Drawing.Point(458, 104)
        Me.BasicLabel9.Name = "BasicLabel9"
        Me.BasicLabel9.NumericFormat = Nothing
        Me.BasicLabel9.PLCAddressKeypad = ""
        Me.BasicLabel9.PollRate = 0
        Me.BasicLabel9.Size = New System.Drawing.Size(34, 13)
        Me.BasicLabel9.TabIndex = 96
        Me.BasicLabel9.Text = "SV-4"
        Me.BasicLabel9.Value = "SV-4"
        Me.BasicLabel9.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel9.ValueLeftPadLength = 0
        Me.BasicLabel9.ValuePrefix = Nothing
        Me.BasicLabel9.ValueScaleFactor = 1.0R
        Me.BasicLabel9.ValueSuffix = Nothing
        '
        'BasicLabel10
        '
        Me.BasicLabel10.AutoSize = True
        Me.BasicLabel10.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel10.CommComponent = Me.DF1Com1
        Me.BasicLabel10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel10.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel10.HighlightKeyCharacter = "!"
        Me.BasicLabel10.KeypadAlpahNumeric = False
        Me.BasicLabel10.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel10.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel10.KeypadMaxValue = 0.0R
        Me.BasicLabel10.KeypadMinValue = 0.0R
        Me.BasicLabel10.KeypadScaleFactor = 1.0R
        Me.BasicLabel10.KeypadShowCurrentValue = False
        Me.BasicLabel10.KeypadText = Nothing
        Me.BasicLabel10.KeypadWidth = 300
        Me.BasicLabel10.Location = New System.Drawing.Point(458, 75)
        Me.BasicLabel10.Name = "BasicLabel10"
        Me.BasicLabel10.NumericFormat = Nothing
        Me.BasicLabel10.PLCAddressKeypad = ""
        Me.BasicLabel10.PollRate = 0
        Me.BasicLabel10.Size = New System.Drawing.Size(34, 13)
        Me.BasicLabel10.TabIndex = 97
        Me.BasicLabel10.Text = "SV-3"
        Me.BasicLabel10.Value = "SV-3"
        Me.BasicLabel10.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel10.ValueLeftPadLength = 0
        Me.BasicLabel10.ValuePrefix = Nothing
        Me.BasicLabel10.ValueScaleFactor = 1.0R
        Me.BasicLabel10.ValueSuffix = Nothing
        '
        'BasicLabel11
        '
        Me.BasicLabel11.AutoSize = True
        Me.BasicLabel11.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel11.CommComponent = Me.DF1Com1
        Me.BasicLabel11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel11.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel11.HighlightKeyCharacter = "!"
        Me.BasicLabel11.KeypadAlpahNumeric = False
        Me.BasicLabel11.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel11.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel11.KeypadMaxValue = 0.0R
        Me.BasicLabel11.KeypadMinValue = 0.0R
        Me.BasicLabel11.KeypadScaleFactor = 1.0R
        Me.BasicLabel11.KeypadShowCurrentValue = False
        Me.BasicLabel11.KeypadText = Nothing
        Me.BasicLabel11.KeypadWidth = 300
        Me.BasicLabel11.Location = New System.Drawing.Point(458, 162)
        Me.BasicLabel11.Name = "BasicLabel11"
        Me.BasicLabel11.NumericFormat = Nothing
        Me.BasicLabel11.PLCAddressKeypad = ""
        Me.BasicLabel11.PollRate = 0
        Me.BasicLabel11.Size = New System.Drawing.Size(34, 13)
        Me.BasicLabel11.TabIndex = 98
        Me.BasicLabel11.Text = "SV-6"
        Me.BasicLabel11.Value = "SV-6"
        Me.BasicLabel11.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel11.ValueLeftPadLength = 0
        Me.BasicLabel11.ValuePrefix = Nothing
        Me.BasicLabel11.ValueScaleFactor = 1.0R
        Me.BasicLabel11.ValueSuffix = Nothing
        '
        'BasicLabel12
        '
        Me.BasicLabel12.AutoSize = True
        Me.BasicLabel12.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel12.CommComponent = Me.DF1Com1
        Me.BasicLabel12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel12.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel12.HighlightKeyCharacter = "!"
        Me.BasicLabel12.KeypadAlpahNumeric = False
        Me.BasicLabel12.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel12.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel12.KeypadMaxValue = 0.0R
        Me.BasicLabel12.KeypadMinValue = 0.0R
        Me.BasicLabel12.KeypadScaleFactor = 1.0R
        Me.BasicLabel12.KeypadShowCurrentValue = False
        Me.BasicLabel12.KeypadText = Nothing
        Me.BasicLabel12.KeypadWidth = 300
        Me.BasicLabel12.Location = New System.Drawing.Point(458, 130)
        Me.BasicLabel12.Name = "BasicLabel12"
        Me.BasicLabel12.NumericFormat = Nothing
        Me.BasicLabel12.PLCAddressKeypad = ""
        Me.BasicLabel12.PollRate = 0
        Me.BasicLabel12.Size = New System.Drawing.Size(34, 13)
        Me.BasicLabel12.TabIndex = 99
        Me.BasicLabel12.Text = "SV-5"
        Me.BasicLabel12.Value = "SV-5"
        Me.BasicLabel12.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel12.ValueLeftPadLength = 0
        Me.BasicLabel12.ValuePrefix = Nothing
        Me.BasicLabel12.ValueScaleFactor = 1.0R
        Me.BasicLabel12.ValueSuffix = Nothing
        '
        'BasicLabel13
        '
        Me.BasicLabel13.AutoSize = True
        Me.BasicLabel13.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel13.CommComponent = Me.DF1Com1
        Me.BasicLabel13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel13.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel13.HighlightKeyCharacter = "!"
        Me.BasicLabel13.KeypadAlpahNumeric = False
        Me.BasicLabel13.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel13.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel13.KeypadMaxValue = 0.0R
        Me.BasicLabel13.KeypadMinValue = 0.0R
        Me.BasicLabel13.KeypadScaleFactor = 1.0R
        Me.BasicLabel13.KeypadShowCurrentValue = False
        Me.BasicLabel13.KeypadText = Nothing
        Me.BasicLabel13.KeypadWidth = 300
        Me.BasicLabel13.Location = New System.Drawing.Point(458, 45)
        Me.BasicLabel13.Name = "BasicLabel13"
        Me.BasicLabel13.NumericFormat = Nothing
        Me.BasicLabel13.PLCAddressKeypad = ""
        Me.BasicLabel13.PollRate = 0
        Me.BasicLabel13.Size = New System.Drawing.Size(34, 13)
        Me.BasicLabel13.TabIndex = 100
        Me.BasicLabel13.Text = "SV-2"
        Me.BasicLabel13.Value = "SV-2"
        Me.BasicLabel13.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel13.ValueLeftPadLength = 0
        Me.BasicLabel13.ValuePrefix = Nothing
        Me.BasicLabel13.ValueScaleFactor = 1.0R
        Me.BasicLabel13.ValueSuffix = Nothing
        '
        'BasicLabel14
        '
        Me.BasicLabel14.AutoSize = True
        Me.BasicLabel14.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel14.CommComponent = Me.DF1Com1
        Me.BasicLabel14.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel14.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel14.HighlightKeyCharacter = "!"
        Me.BasicLabel14.KeypadAlpahNumeric = False
        Me.BasicLabel14.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel14.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel14.KeypadMaxValue = 0.0R
        Me.BasicLabel14.KeypadMinValue = 0.0R
        Me.BasicLabel14.KeypadScaleFactor = 1.0R
        Me.BasicLabel14.KeypadShowCurrentValue = False
        Me.BasicLabel14.KeypadText = Nothing
        Me.BasicLabel14.KeypadWidth = 300
        Me.BasicLabel14.Location = New System.Drawing.Point(458, 191)
        Me.BasicLabel14.Name = "BasicLabel14"
        Me.BasicLabel14.NumericFormat = Nothing
        Me.BasicLabel14.PLCAddressKeypad = ""
        Me.BasicLabel14.PollRate = 0
        Me.BasicLabel14.Size = New System.Drawing.Size(26, 13)
        Me.BasicLabel14.TabIndex = 101
        Me.BasicLabel14.Text = "P-1"
        Me.BasicLabel14.Value = "P-1"
        Me.BasicLabel14.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel14.ValueLeftPadLength = 0
        Me.BasicLabel14.ValuePrefix = Nothing
        Me.BasicLabel14.ValueScaleFactor = 1.0R
        Me.BasicLabel14.ValueSuffix = Nothing
        '
        'MessageDisplayByValue1
        '
        Me.MessageDisplayByValue1.AutoSize = True
        Me.MessageDisplayByValue1.BackColor = System.Drawing.Color.Black
        Me.MessageDisplayByValue1.CommComponent = Me.DF1Com1
        Me.MessageDisplayByValue1.ForeColor = System.Drawing.Color.Black
        Me.MessageDisplayByValue1.HighlightColor = System.Drawing.Color.Red
        Me.MessageDisplayByValue1.HighlightColor2 = System.Drawing.Color.Red
        Me.MessageDisplayByValue1.HighlightKeyCharacter = "!"
        Me.MessageDisplayByValue1.HighlightKeyCharacter2 = "."
        Me.MessageDisplayByValue1.IniFileName = Nothing
        Me.MessageDisplayByValue1.Location = New System.Drawing.Point(742, 16)
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Messages.Add(CType(resources.GetObject("MessageDisplayByValue1.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue1.Name = "MessageDisplayByValue1"
        Me.MessageDisplayByValue1.PLCAddressValue = "N7:0"
        Me.MessageDisplayByValue1.PLCAddressVisible = ""
        Me.MessageDisplayByValue1.ShowMessageNumber = False
        Me.MessageDisplayByValue1.Size = New System.Drawing.Size(24, 13)
        Me.MessageDisplayByValue1.SpeakMessage = False
        Me.MessageDisplayByValue1.TabIndex = 102
        Me.MessageDisplayByValue1.Text = "Off"
        Me.MessageDisplayByValue1.Value = 0
        '
        'MessageDisplayByValue2
        '
        Me.MessageDisplayByValue2.AutoSize = True
        Me.MessageDisplayByValue2.BackColor = System.Drawing.Color.Black
        Me.MessageDisplayByValue2.CommComponent = Me.DF1Com1
        Me.MessageDisplayByValue2.ForeColor = System.Drawing.Color.Black
        Me.MessageDisplayByValue2.HighlightColor = System.Drawing.Color.Red
        Me.MessageDisplayByValue2.HighlightColor2 = System.Drawing.Color.Red
        Me.MessageDisplayByValue2.HighlightKeyCharacter = "!"
        Me.MessageDisplayByValue2.HighlightKeyCharacter2 = "."
        Me.MessageDisplayByValue2.IniFileName = Nothing
        Me.MessageDisplayByValue2.Location = New System.Drawing.Point(742, 45)
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Messages.Add(CType(resources.GetObject("MessageDisplayByValue2.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue2.Name = "MessageDisplayByValue2"
        Me.MessageDisplayByValue2.PLCAddressValue = "N7:1"
        Me.MessageDisplayByValue2.PLCAddressVisible = ""
        Me.MessageDisplayByValue2.ShowMessageNumber = False
        Me.MessageDisplayByValue2.Size = New System.Drawing.Size(24, 13)
        Me.MessageDisplayByValue2.SpeakMessage = False
        Me.MessageDisplayByValue2.TabIndex = 103
        Me.MessageDisplayByValue2.Text = "Off"
        Me.MessageDisplayByValue2.Value = 0
        '
        'MessageDisplayByValue3
        '
        Me.MessageDisplayByValue3.AutoSize = True
        Me.MessageDisplayByValue3.BackColor = System.Drawing.Color.Black
        Me.MessageDisplayByValue3.CommComponent = Me.DF1Com1
        Me.MessageDisplayByValue3.ForeColor = System.Drawing.Color.Black
        Me.MessageDisplayByValue3.HighlightColor = System.Drawing.Color.Red
        Me.MessageDisplayByValue3.HighlightColor2 = System.Drawing.Color.Red
        Me.MessageDisplayByValue3.HighlightKeyCharacter = "!"
        Me.MessageDisplayByValue3.HighlightKeyCharacter2 = "."
        Me.MessageDisplayByValue3.IniFileName = Nothing
        Me.MessageDisplayByValue3.Location = New System.Drawing.Point(742, 191)
        Me.MessageDisplayByValue3.Messages.Add(CType(resources.GetObject("MessageDisplayByValue3.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue3.Messages.Add(CType(resources.GetObject("MessageDisplayByValue3.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue3.Messages.Add(CType(resources.GetObject("MessageDisplayByValue3.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue3.Name = "MessageDisplayByValue3"
        Me.MessageDisplayByValue3.PLCAddressValue = "N7:6"
        Me.MessageDisplayByValue3.PLCAddressVisible = ""
        Me.MessageDisplayByValue3.ShowMessageNumber = False
        Me.MessageDisplayByValue3.Size = New System.Drawing.Size(24, 13)
        Me.MessageDisplayByValue3.SpeakMessage = False
        Me.MessageDisplayByValue3.TabIndex = 104
        Me.MessageDisplayByValue3.Text = "Off"
        Me.MessageDisplayByValue3.Value = 0
        '
        'MessageDisplayByValue4
        '
        Me.MessageDisplayByValue4.AutoSize = True
        Me.MessageDisplayByValue4.BackColor = System.Drawing.Color.Black
        Me.MessageDisplayByValue4.CommComponent = Me.DF1Com1
        Me.MessageDisplayByValue4.ForeColor = System.Drawing.Color.Black
        Me.MessageDisplayByValue4.HighlightColor = System.Drawing.Color.Red
        Me.MessageDisplayByValue4.HighlightColor2 = System.Drawing.Color.Red
        Me.MessageDisplayByValue4.HighlightKeyCharacter = "!"
        Me.MessageDisplayByValue4.HighlightKeyCharacter2 = "."
        Me.MessageDisplayByValue4.IniFileName = Nothing
        Me.MessageDisplayByValue4.Location = New System.Drawing.Point(742, 162)
        Me.MessageDisplayByValue4.Messages.Add(CType(resources.GetObject("MessageDisplayByValue4.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue4.Messages.Add(CType(resources.GetObject("MessageDisplayByValue4.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue4.Messages.Add(CType(resources.GetObject("MessageDisplayByValue4.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue4.Name = "MessageDisplayByValue4"
        Me.MessageDisplayByValue4.PLCAddressValue = "N7:5"
        Me.MessageDisplayByValue4.PLCAddressVisible = ""
        Me.MessageDisplayByValue4.ShowMessageNumber = False
        Me.MessageDisplayByValue4.Size = New System.Drawing.Size(24, 13)
        Me.MessageDisplayByValue4.SpeakMessage = False
        Me.MessageDisplayByValue4.TabIndex = 105
        Me.MessageDisplayByValue4.Text = "Off"
        Me.MessageDisplayByValue4.Value = 0
        '
        'MessageDisplayByValue5
        '
        Me.MessageDisplayByValue5.AutoSize = True
        Me.MessageDisplayByValue5.BackColor = System.Drawing.Color.Black
        Me.MessageDisplayByValue5.CommComponent = Me.DF1Com1
        Me.MessageDisplayByValue5.ForeColor = System.Drawing.Color.Black
        Me.MessageDisplayByValue5.HighlightColor = System.Drawing.Color.Red
        Me.MessageDisplayByValue5.HighlightColor2 = System.Drawing.Color.Red
        Me.MessageDisplayByValue5.HighlightKeyCharacter = "!"
        Me.MessageDisplayByValue5.HighlightKeyCharacter2 = "."
        Me.MessageDisplayByValue5.IniFileName = Nothing
        Me.MessageDisplayByValue5.Location = New System.Drawing.Point(742, 130)
        Me.MessageDisplayByValue5.Messages.Add(CType(resources.GetObject("MessageDisplayByValue5.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue5.Messages.Add(CType(resources.GetObject("MessageDisplayByValue5.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue5.Messages.Add(CType(resources.GetObject("MessageDisplayByValue5.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue5.Name = "MessageDisplayByValue5"
        Me.MessageDisplayByValue5.PLCAddressValue = "N7:4"
        Me.MessageDisplayByValue5.PLCAddressVisible = ""
        Me.MessageDisplayByValue5.ShowMessageNumber = False
        Me.MessageDisplayByValue5.Size = New System.Drawing.Size(24, 13)
        Me.MessageDisplayByValue5.SpeakMessage = False
        Me.MessageDisplayByValue5.TabIndex = 106
        Me.MessageDisplayByValue5.Text = "Off"
        Me.MessageDisplayByValue5.Value = 0
        '
        'MessageDisplayByValue6
        '
        Me.MessageDisplayByValue6.AutoSize = True
        Me.MessageDisplayByValue6.BackColor = System.Drawing.Color.Black
        Me.MessageDisplayByValue6.CommComponent = Me.DF1Com1
        Me.MessageDisplayByValue6.ForeColor = System.Drawing.Color.Black
        Me.MessageDisplayByValue6.HighlightColor = System.Drawing.Color.Red
        Me.MessageDisplayByValue6.HighlightColor2 = System.Drawing.Color.Red
        Me.MessageDisplayByValue6.HighlightKeyCharacter = "!"
        Me.MessageDisplayByValue6.HighlightKeyCharacter2 = "."
        Me.MessageDisplayByValue6.IniFileName = Nothing
        Me.MessageDisplayByValue6.Location = New System.Drawing.Point(742, 104)
        Me.MessageDisplayByValue6.Messages.Add(CType(resources.GetObject("MessageDisplayByValue6.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue6.Messages.Add(CType(resources.GetObject("MessageDisplayByValue6.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue6.Messages.Add(CType(resources.GetObject("MessageDisplayByValue6.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue6.Name = "MessageDisplayByValue6"
        Me.MessageDisplayByValue6.PLCAddressValue = "N7:3"
        Me.MessageDisplayByValue6.PLCAddressVisible = ""
        Me.MessageDisplayByValue6.ShowMessageNumber = False
        Me.MessageDisplayByValue6.Size = New System.Drawing.Size(24, 13)
        Me.MessageDisplayByValue6.SpeakMessage = False
        Me.MessageDisplayByValue6.TabIndex = 107
        Me.MessageDisplayByValue6.Text = "Off"
        Me.MessageDisplayByValue6.Value = 0
        '
        'MessageDisplayByValue7
        '
        Me.MessageDisplayByValue7.AutoSize = True
        Me.MessageDisplayByValue7.BackColor = System.Drawing.Color.Black
        Me.MessageDisplayByValue7.CommComponent = Me.DF1Com1
        Me.MessageDisplayByValue7.ForeColor = System.Drawing.Color.Black
        Me.MessageDisplayByValue7.HighlightColor = System.Drawing.Color.Red
        Me.MessageDisplayByValue7.HighlightColor2 = System.Drawing.Color.Red
        Me.MessageDisplayByValue7.HighlightKeyCharacter = "!"
        Me.MessageDisplayByValue7.HighlightKeyCharacter2 = "."
        Me.MessageDisplayByValue7.IniFileName = Nothing
        Me.MessageDisplayByValue7.Location = New System.Drawing.Point(742, 75)
        Me.MessageDisplayByValue7.Messages.Add(CType(resources.GetObject("MessageDisplayByValue7.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue7.Messages.Add(CType(resources.GetObject("MessageDisplayByValue7.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue7.Messages.Add(CType(resources.GetObject("MessageDisplayByValue7.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.MessageDisplayByValue7.Name = "MessageDisplayByValue7"
        Me.MessageDisplayByValue7.PLCAddressValue = "N7:2"
        Me.MessageDisplayByValue7.PLCAddressVisible = ""
        Me.MessageDisplayByValue7.ShowMessageNumber = False
        Me.MessageDisplayByValue7.Size = New System.Drawing.Size(24, 13)
        Me.MessageDisplayByValue7.SpeakMessage = False
        Me.MessageDisplayByValue7.TabIndex = 108
        Me.MessageDisplayByValue7.Text = "Off"
        Me.MessageDisplayByValue7.Value = 0
        '
        'BasicButton26
        '
        Me.BasicButton26.BackColor = System.Drawing.Color.Black
        Me.BasicButton26.CommComponent = Me.DF1Com1
        Me.BasicButton26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BasicButton26.ForeColor = System.Drawing.Color.White
        Me.BasicButton26.Highlight = False
        Me.BasicButton26.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton26.Location = New System.Drawing.Point(498, 220)
        Me.BasicButton26.MaximumHoldTime = 3000
        Me.BasicButton26.MinimumHoldTime = 500
        Me.BasicButton26.Name = "BasicButton26"
        Me.BasicButton26.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.BasicButton26.PLCAddressClick = "B3:5/13"
        Me.BasicButton26.SelectTextAlternate = False
        Me.BasicButton26.Size = New System.Drawing.Size(237, 34)
        Me.BasicButton26.TabIndex = 116
        Me.BasicButton26.Text = "All Devices AUTO"
        Me.BasicButton26.TextAlternate = Nothing
        Me.BasicButton26.UseVisualStyleBackColor = False
        Me.BasicButton26.ValueToWrite = 1
        '
        'BasicLabel5
        '
        Me.BasicLabel5.AutoSize = True
        Me.BasicLabel5.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel5.CommComponent = Me.DF1Com1
        Me.BasicLabel5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel5.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel5.HighlightKeyCharacter = "!"
        Me.BasicLabel5.KeypadAlpahNumeric = False
        Me.BasicLabel5.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel5.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel5.KeypadMaxValue = 0.0R
        Me.BasicLabel5.KeypadMinValue = 0.0R
        Me.BasicLabel5.KeypadScaleFactor = 1.0R
        Me.BasicLabel5.KeypadShowCurrentValue = False
        Me.BasicLabel5.KeypadText = Nothing
        Me.BasicLabel5.KeypadWidth = 300
        Me.BasicLabel5.Location = New System.Drawing.Point(443, 275)
        Me.BasicLabel5.Name = "BasicLabel5"
        Me.BasicLabel5.NumericFormat = Nothing
        Me.BasicLabel5.PLCAddressKeypad = ""
        Me.BasicLabel5.PLCAddressValue = "F8:0"
        Me.BasicLabel5.PollRate = 0
        Me.BasicLabel5.Size = New System.Drawing.Size(69, 13)
        Me.BasicLabel5.TabIndex = 117
        Me.BasicLabel5.Text = "BasicLabel"
        Me.BasicLabel5.Value = "BasicLabel"
        Me.BasicLabel5.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel5.ValueLeftPadLength = 0
        Me.BasicLabel5.ValuePrefix = Nothing
        Me.BasicLabel5.ValueScaleFactor = 1.0R
        Me.BasicLabel5.ValueSuffix = Nothing
        '
        'BasicLabel6
        '
        Me.BasicLabel6.AutoSize = True
        Me.BasicLabel6.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel6.CommComponent = Me.DF1Com1
        Me.BasicLabel6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel6.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel6.HighlightKeyCharacter = "!"
        Me.BasicLabel6.KeypadAlpahNumeric = False
        Me.BasicLabel6.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel6.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel6.KeypadMaxValue = 0.0R
        Me.BasicLabel6.KeypadMinValue = 0.0R
        Me.BasicLabel6.KeypadScaleFactor = 1.0R
        Me.BasicLabel6.KeypadShowCurrentValue = False
        Me.BasicLabel6.KeypadText = Nothing
        Me.BasicLabel6.KeypadWidth = 300
        Me.BasicLabel6.Location = New System.Drawing.Point(350, 275)
        Me.BasicLabel6.Name = "BasicLabel6"
        Me.BasicLabel6.NumericFormat = Nothing
        Me.BasicLabel6.PLCAddressKeypad = ""
        Me.BasicLabel6.PollRate = 0
        Me.BasicLabel6.Size = New System.Drawing.Size(87, 13)
        Me.BasicLabel6.TabIndex = 118
        Me.BasicLabel6.Text = "PT-1 Pressure"
        Me.BasicLabel6.Value = "PT-1 Pressure"
        Me.BasicLabel6.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel6.ValueLeftPadLength = 0
        Me.BasicLabel6.ValuePrefix = Nothing
        Me.BasicLabel6.ValueScaleFactor = 1.0R
        Me.BasicLabel6.ValueSuffix = Nothing
        '
        'BasicLabel15
        '
        Me.BasicLabel15.AutoSize = True
        Me.BasicLabel15.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel15.CommComponent = Me.DF1Com1
        Me.BasicLabel15.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel15.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel15.HighlightKeyCharacter = "!"
        Me.BasicLabel15.KeypadAlpahNumeric = False
        Me.BasicLabel15.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel15.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel15.KeypadMaxValue = 0.0R
        Me.BasicLabel15.KeypadMinValue = 0.0R
        Me.BasicLabel15.KeypadScaleFactor = 1.0R
        Me.BasicLabel15.KeypadShowCurrentValue = False
        Me.BasicLabel15.KeypadText = Nothing
        Me.BasicLabel15.KeypadWidth = 300
        Me.BasicLabel15.Location = New System.Drawing.Point(350, 303)
        Me.BasicLabel15.Name = "BasicLabel15"
        Me.BasicLabel15.NumericFormat = Nothing
        Me.BasicLabel15.PLCAddressKeypad = ""
        Me.BasicLabel15.PollRate = 0
        Me.BasicLabel15.Size = New System.Drawing.Size(87, 13)
        Me.BasicLabel15.TabIndex = 120
        Me.BasicLabel15.Text = "PT-2 Pressure"
        Me.BasicLabel15.Value = "PT-2 Pressure"
        Me.BasicLabel15.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel15.ValueLeftPadLength = 0
        Me.BasicLabel15.ValuePrefix = Nothing
        Me.BasicLabel15.ValueScaleFactor = 1.0R
        Me.BasicLabel15.ValueSuffix = Nothing
        '
        'BasicLabel16
        '
        Me.BasicLabel16.AutoSize = True
        Me.BasicLabel16.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel16.CommComponent = Me.DF1Com1
        Me.BasicLabel16.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel16.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel16.HighlightKeyCharacter = "!"
        Me.BasicLabel16.KeypadAlpahNumeric = False
        Me.BasicLabel16.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel16.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel16.KeypadMaxValue = 0.0R
        Me.BasicLabel16.KeypadMinValue = 0.0R
        Me.BasicLabel16.KeypadScaleFactor = 1.0R
        Me.BasicLabel16.KeypadShowCurrentValue = False
        Me.BasicLabel16.KeypadText = Nothing
        Me.BasicLabel16.KeypadWidth = 300
        Me.BasicLabel16.Location = New System.Drawing.Point(443, 303)
        Me.BasicLabel16.Name = "BasicLabel16"
        Me.BasicLabel16.NumericFormat = Nothing
        Me.BasicLabel16.PLCAddressKeypad = ""
        Me.BasicLabel16.PLCAddressValue = "F8:1"
        Me.BasicLabel16.PollRate = 0
        Me.BasicLabel16.Size = New System.Drawing.Size(69, 13)
        Me.BasicLabel16.TabIndex = 119
        Me.BasicLabel16.Text = "BasicLabel"
        Me.BasicLabel16.Value = "BasicLabel"
        Me.BasicLabel16.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel16.ValueLeftPadLength = 0
        Me.BasicLabel16.ValuePrefix = Nothing
        Me.BasicLabel16.ValueScaleFactor = 1.0R
        Me.BasicLabel16.ValueSuffix = Nothing
        '
        'BasicLabel17
        '
        Me.BasicLabel17.AutoSize = True
        Me.BasicLabel17.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel17.CommComponent = Me.DF1Com1
        Me.BasicLabel17.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel17.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel17.HighlightKeyCharacter = "!"
        Me.BasicLabel17.KeypadAlpahNumeric = False
        Me.BasicLabel17.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel17.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel17.KeypadMaxValue = 0.0R
        Me.BasicLabel17.KeypadMinValue = 0.0R
        Me.BasicLabel17.KeypadScaleFactor = 1.0R
        Me.BasicLabel17.KeypadShowCurrentValue = False
        Me.BasicLabel17.KeypadText = Nothing
        Me.BasicLabel17.KeypadWidth = 300
        Me.BasicLabel17.Location = New System.Drawing.Point(350, 333)
        Me.BasicLabel17.Name = "BasicLabel17"
        Me.BasicLabel17.NumericFormat = Nothing
        Me.BasicLabel17.PLCAddressKeypad = ""
        Me.BasicLabel17.PollRate = 0
        Me.BasicLabel17.Size = New System.Drawing.Size(87, 13)
        Me.BasicLabel17.TabIndex = 122
        Me.BasicLabel17.Text = "DIFF Pressure"
        Me.BasicLabel17.Value = "DIFF Pressure"
        Me.BasicLabel17.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel17.ValueLeftPadLength = 0
        Me.BasicLabel17.ValuePrefix = Nothing
        Me.BasicLabel17.ValueScaleFactor = 1.0R
        Me.BasicLabel17.ValueSuffix = Nothing
        '
        'BasicLabel18
        '
        Me.BasicLabel18.AutoSize = True
        Me.BasicLabel18.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel18.CommComponent = Me.DF1Com1
        Me.BasicLabel18.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel18.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel18.HighlightKeyCharacter = "!"
        Me.BasicLabel18.KeypadAlpahNumeric = False
        Me.BasicLabel18.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel18.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel18.KeypadMaxValue = 0.0R
        Me.BasicLabel18.KeypadMinValue = 0.0R
        Me.BasicLabel18.KeypadScaleFactor = 1.0R
        Me.BasicLabel18.KeypadShowCurrentValue = False
        Me.BasicLabel18.KeypadText = Nothing
        Me.BasicLabel18.KeypadWidth = 300
        Me.BasicLabel18.Location = New System.Drawing.Point(443, 333)
        Me.BasicLabel18.Name = "BasicLabel18"
        Me.BasicLabel18.NumericFormat = Nothing
        Me.BasicLabel18.PLCAddressKeypad = ""
        Me.BasicLabel18.PLCAddressValue = "F8:3"
        Me.BasicLabel18.PollRate = 0
        Me.BasicLabel18.Size = New System.Drawing.Size(69, 13)
        Me.BasicLabel18.TabIndex = 121
        Me.BasicLabel18.Text = "BasicLabel"
        Me.BasicLabel18.Value = "BasicLabel"
        Me.BasicLabel18.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel18.ValueLeftPadLength = 0
        Me.BasicLabel18.ValuePrefix = Nothing
        Me.BasicLabel18.ValueScaleFactor = 1.0R
        Me.BasicLabel18.ValueSuffix = Nothing
        '
        'PilotLight4
        '
        Me.PilotLight4.Blink = False
        Me.PilotLight4.CommComponent = Me.DF1Com1
        Me.PilotLight4.ForeColor = System.Drawing.Color.Black
        Me.PilotLight4.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.PilotLight4.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red
        Me.PilotLight4.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.White
        Me.PilotLight4.Location = New System.Drawing.Point(829, 182)
        Me.PilotLight4.Name = "PilotLight4"
        Me.PilotLight4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight4.PLCAddressClick = ""
        Me.PilotLight4.PLCAddressText = ""
        Me.PilotLight4.PLCAddressValue = "B3:4/8"
        Me.PilotLight4.PLCAddressVisible = ""
        Me.PilotLight4.Size = New System.Drawing.Size(75, 79)
        Me.PilotLight4.TabIndex = 123
        Me.PilotLight4.Text = "Pres HH"
        Me.PilotLight4.Value = False
        '
        'BasicLabel1
        '
        Me.BasicLabel1.AutoSize = True
        Me.BasicLabel1.BackColor = System.Drawing.Color.Lime
        Me.BasicLabel1.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel1.CommComponent = Me.DF1Com1
        Me.BasicLabel1.ForeColor = System.Drawing.Color.Black
        Me.BasicLabel1.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel1.HighlightKeyCharacter = "!"
        Me.BasicLabel1.KeypadAlpahNumeric = False
        Me.BasicLabel1.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel1.KeypadMaxValue = 0.0R
        Me.BasicLabel1.KeypadMinValue = 0.0R
        Me.BasicLabel1.KeypadScaleFactor = 1.0R
        Me.BasicLabel1.KeypadShowCurrentValue = False
        Me.BasicLabel1.KeypadText = Nothing
        Me.BasicLabel1.KeypadWidth = 300
        Me.BasicLabel1.Location = New System.Drawing.Point(777, 17)
        Me.BasicLabel1.Name = "BasicLabel1"
        Me.BasicLabel1.NumericFormat = Nothing
        Me.BasicLabel1.PLCAddressKeypad = ""
        Me.BasicLabel1.PLCAddressVisible = "B3:0/1"
        Me.BasicLabel1.PollRate = 0
        Me.BasicLabel1.Size = New System.Drawing.Size(27, 13)
        Me.BasicLabel1.TabIndex = 124
        Me.BasicLabel1.Text = " On"
        Me.BasicLabel1.Value = " On"
        Me.BasicLabel1.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel1.ValueLeftPadLength = 0
        Me.BasicLabel1.ValuePrefix = Nothing
        Me.BasicLabel1.ValueScaleFactor = 1.0R
        Me.BasicLabel1.ValueSuffix = Nothing
        '
        'BasicLabel2
        '
        Me.BasicLabel2.AutoSize = True
        Me.BasicLabel2.BackColor = System.Drawing.Color.Red
        Me.BasicLabel2.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel2.CommComponent = Me.DF1Com1
        Me.BasicLabel2.ForeColor = System.Drawing.Color.Black
        Me.BasicLabel2.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel2.HighlightKeyCharacter = "!"
        Me.BasicLabel2.KeypadAlpahNumeric = False
        Me.BasicLabel2.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel2.KeypadMaxValue = 0.0R
        Me.BasicLabel2.KeypadMinValue = 0.0R
        Me.BasicLabel2.KeypadScaleFactor = 1.0R
        Me.BasicLabel2.KeypadShowCurrentValue = False
        Me.BasicLabel2.KeypadText = Nothing
        Me.BasicLabel2.KeypadWidth = 300
        Me.BasicLabel2.Location = New System.Drawing.Point(780, 17)
        Me.BasicLabel2.Name = "BasicLabel2"
        Me.BasicLabel2.NumericFormat = Nothing
        Me.BasicLabel2.PLCAddressKeypad = ""
        Me.BasicLabel2.PollRate = 0
        Me.BasicLabel2.Size = New System.Drawing.Size(24, 13)
        Me.BasicLabel2.TabIndex = 125
        Me.BasicLabel2.Text = "Off"
        Me.BasicLabel2.Value = "Off"
        Me.BasicLabel2.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel2.ValueLeftPadLength = 0
        Me.BasicLabel2.ValuePrefix = Nothing
        Me.BasicLabel2.ValueScaleFactor = 1.0R
        Me.BasicLabel2.ValueSuffix = Nothing
        '
        'BasicLabel3
        '
        Me.BasicLabel3.AutoSize = True
        Me.BasicLabel3.BackColor = System.Drawing.Color.Red
        Me.BasicLabel3.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel3.CommComponent = Me.DF1Com1
        Me.BasicLabel3.ForeColor = System.Drawing.Color.Black
        Me.BasicLabel3.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel3.HighlightKeyCharacter = "!"
        Me.BasicLabel3.KeypadAlpahNumeric = False
        Me.BasicLabel3.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel3.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel3.KeypadMaxValue = 0.0R
        Me.BasicLabel3.KeypadMinValue = 0.0R
        Me.BasicLabel3.KeypadScaleFactor = 1.0R
        Me.BasicLabel3.KeypadShowCurrentValue = False
        Me.BasicLabel3.KeypadText = Nothing
        Me.BasicLabel3.KeypadWidth = 300
        Me.BasicLabel3.Location = New System.Drawing.Point(781, 45)
        Me.BasicLabel3.Name = "BasicLabel3"
        Me.BasicLabel3.NumericFormat = Nothing
        Me.BasicLabel3.PLCAddressKeypad = ""
        Me.BasicLabel3.PollRate = 0
        Me.BasicLabel3.Size = New System.Drawing.Size(24, 13)
        Me.BasicLabel3.TabIndex = 126
        Me.BasicLabel3.Text = "Off"
        Me.BasicLabel3.Value = "Off"
        Me.BasicLabel3.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel3.ValueLeftPadLength = 0
        Me.BasicLabel3.ValuePrefix = Nothing
        Me.BasicLabel3.ValueScaleFactor = 1.0R
        Me.BasicLabel3.ValueSuffix = Nothing
        '
        'BasicLabel4
        '
        Me.BasicLabel4.AutoSize = True
        Me.BasicLabel4.BackColor = System.Drawing.Color.Red
        Me.BasicLabel4.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel4.CommComponent = Me.DF1Com1
        Me.BasicLabel4.ForeColor = System.Drawing.Color.Black
        Me.BasicLabel4.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel4.HighlightKeyCharacter = "!"
        Me.BasicLabel4.KeypadAlpahNumeric = False
        Me.BasicLabel4.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel4.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel4.KeypadMaxValue = 0.0R
        Me.BasicLabel4.KeypadMinValue = 0.0R
        Me.BasicLabel4.KeypadScaleFactor = 1.0R
        Me.BasicLabel4.KeypadShowCurrentValue = False
        Me.BasicLabel4.KeypadText = Nothing
        Me.BasicLabel4.KeypadWidth = 300
        Me.BasicLabel4.Location = New System.Drawing.Point(781, 75)
        Me.BasicLabel4.Name = "BasicLabel4"
        Me.BasicLabel4.NumericFormat = Nothing
        Me.BasicLabel4.PLCAddressKeypad = ""
        Me.BasicLabel4.PollRate = 0
        Me.BasicLabel4.Size = New System.Drawing.Size(24, 13)
        Me.BasicLabel4.TabIndex = 127
        Me.BasicLabel4.Text = "Off"
        Me.BasicLabel4.Value = "Off"
        Me.BasicLabel4.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel4.ValueLeftPadLength = 0
        Me.BasicLabel4.ValuePrefix = Nothing
        Me.BasicLabel4.ValueScaleFactor = 1.0R
        Me.BasicLabel4.ValueSuffix = Nothing
        '
        'BasicLabel19
        '
        Me.BasicLabel19.AutoSize = True
        Me.BasicLabel19.BackColor = System.Drawing.Color.Red
        Me.BasicLabel19.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel19.CommComponent = Me.DF1Com1
        Me.BasicLabel19.ForeColor = System.Drawing.Color.Black
        Me.BasicLabel19.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel19.HighlightKeyCharacter = "!"
        Me.BasicLabel19.KeypadAlpahNumeric = False
        Me.BasicLabel19.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel19.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel19.KeypadMaxValue = 0.0R
        Me.BasicLabel19.KeypadMinValue = 0.0R
        Me.BasicLabel19.KeypadScaleFactor = 1.0R
        Me.BasicLabel19.KeypadShowCurrentValue = False
        Me.BasicLabel19.KeypadText = Nothing
        Me.BasicLabel19.KeypadWidth = 300
        Me.BasicLabel19.Location = New System.Drawing.Point(781, 104)
        Me.BasicLabel19.Name = "BasicLabel19"
        Me.BasicLabel19.NumericFormat = Nothing
        Me.BasicLabel19.PLCAddressKeypad = ""
        Me.BasicLabel19.PollRate = 0
        Me.BasicLabel19.Size = New System.Drawing.Size(24, 13)
        Me.BasicLabel19.TabIndex = 128
        Me.BasicLabel19.Text = "Off"
        Me.BasicLabel19.Value = "Off"
        Me.BasicLabel19.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel19.ValueLeftPadLength = 0
        Me.BasicLabel19.ValuePrefix = Nothing
        Me.BasicLabel19.ValueScaleFactor = 1.0R
        Me.BasicLabel19.ValueSuffix = Nothing
        '
        'BasicLabel20
        '
        Me.BasicLabel20.AutoSize = True
        Me.BasicLabel20.BackColor = System.Drawing.Color.Red
        Me.BasicLabel20.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel20.CommComponent = Me.DF1Com1
        Me.BasicLabel20.ForeColor = System.Drawing.Color.Black
        Me.BasicLabel20.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel20.HighlightKeyCharacter = "!"
        Me.BasicLabel20.KeypadAlpahNumeric = False
        Me.BasicLabel20.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel20.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel20.KeypadMaxValue = 0.0R
        Me.BasicLabel20.KeypadMinValue = 0.0R
        Me.BasicLabel20.KeypadScaleFactor = 1.0R
        Me.BasicLabel20.KeypadShowCurrentValue = False
        Me.BasicLabel20.KeypadText = Nothing
        Me.BasicLabel20.KeypadWidth = 300
        Me.BasicLabel20.Location = New System.Drawing.Point(781, 130)
        Me.BasicLabel20.Name = "BasicLabel20"
        Me.BasicLabel20.NumericFormat = Nothing
        Me.BasicLabel20.PLCAddressKeypad = ""
        Me.BasicLabel20.PollRate = 0
        Me.BasicLabel20.Size = New System.Drawing.Size(24, 13)
        Me.BasicLabel20.TabIndex = 129
        Me.BasicLabel20.Text = "Off"
        Me.BasicLabel20.Value = "Off"
        Me.BasicLabel20.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel20.ValueLeftPadLength = 0
        Me.BasicLabel20.ValuePrefix = Nothing
        Me.BasicLabel20.ValueScaleFactor = 1.0R
        Me.BasicLabel20.ValueSuffix = Nothing
        '
        'BasicLabel21
        '
        Me.BasicLabel21.AutoSize = True
        Me.BasicLabel21.BackColor = System.Drawing.Color.Red
        Me.BasicLabel21.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel21.CommComponent = Me.DF1Com1
        Me.BasicLabel21.ForeColor = System.Drawing.Color.Black
        Me.BasicLabel21.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel21.HighlightKeyCharacter = "!"
        Me.BasicLabel21.KeypadAlpahNumeric = False
        Me.BasicLabel21.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel21.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel21.KeypadMaxValue = 0.0R
        Me.BasicLabel21.KeypadMinValue = 0.0R
        Me.BasicLabel21.KeypadScaleFactor = 1.0R
        Me.BasicLabel21.KeypadShowCurrentValue = False
        Me.BasicLabel21.KeypadText = Nothing
        Me.BasicLabel21.KeypadWidth = 300
        Me.BasicLabel21.Location = New System.Drawing.Point(781, 191)
        Me.BasicLabel21.Name = "BasicLabel21"
        Me.BasicLabel21.NumericFormat = Nothing
        Me.BasicLabel21.PLCAddressKeypad = ""
        Me.BasicLabel21.PollRate = 0
        Me.BasicLabel21.Size = New System.Drawing.Size(24, 13)
        Me.BasicLabel21.TabIndex = 130
        Me.BasicLabel21.Text = "Off"
        Me.BasicLabel21.Value = "Off"
        Me.BasicLabel21.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel21.ValueLeftPadLength = 0
        Me.BasicLabel21.ValuePrefix = Nothing
        Me.BasicLabel21.ValueScaleFactor = 1.0R
        Me.BasicLabel21.ValueSuffix = Nothing
        '
        'BasicLabel22
        '
        Me.BasicLabel22.AutoSize = True
        Me.BasicLabel22.BackColor = System.Drawing.Color.Red
        Me.BasicLabel22.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel22.CommComponent = Me.DF1Com1
        Me.BasicLabel22.ForeColor = System.Drawing.Color.Black
        Me.BasicLabel22.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel22.HighlightKeyCharacter = "!"
        Me.BasicLabel22.KeypadAlpahNumeric = False
        Me.BasicLabel22.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel22.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel22.KeypadMaxValue = 0.0R
        Me.BasicLabel22.KeypadMinValue = 0.0R
        Me.BasicLabel22.KeypadScaleFactor = 1.0R
        Me.BasicLabel22.KeypadShowCurrentValue = False
        Me.BasicLabel22.KeypadText = Nothing
        Me.BasicLabel22.KeypadWidth = 300
        Me.BasicLabel22.Location = New System.Drawing.Point(781, 162)
        Me.BasicLabel22.Name = "BasicLabel22"
        Me.BasicLabel22.NumericFormat = Nothing
        Me.BasicLabel22.PLCAddressKeypad = ""
        Me.BasicLabel22.PollRate = 0
        Me.BasicLabel22.Size = New System.Drawing.Size(24, 13)
        Me.BasicLabel22.TabIndex = 131
        Me.BasicLabel22.Text = "Off"
        Me.BasicLabel22.Value = "Off"
        Me.BasicLabel22.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel22.ValueLeftPadLength = 0
        Me.BasicLabel22.ValuePrefix = Nothing
        Me.BasicLabel22.ValueScaleFactor = 1.0R
        Me.BasicLabel22.ValueSuffix = Nothing
        '
        'BasicLabel23
        '
        Me.BasicLabel23.AutoSize = True
        Me.BasicLabel23.BackColor = System.Drawing.Color.Lime
        Me.BasicLabel23.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel23.CommComponent = Me.DF1Com1
        Me.BasicLabel23.ForeColor = System.Drawing.Color.Black
        Me.BasicLabel23.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel23.HighlightKeyCharacter = "!"
        Me.BasicLabel23.KeypadAlpahNumeric = False
        Me.BasicLabel23.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel23.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel23.KeypadMaxValue = 0.0R
        Me.BasicLabel23.KeypadMinValue = 0.0R
        Me.BasicLabel23.KeypadScaleFactor = 1.0R
        Me.BasicLabel23.KeypadShowCurrentValue = False
        Me.BasicLabel23.KeypadText = Nothing
        Me.BasicLabel23.KeypadWidth = 300
        Me.BasicLabel23.Location = New System.Drawing.Point(778, 45)
        Me.BasicLabel23.Name = "BasicLabel23"
        Me.BasicLabel23.NumericFormat = Nothing
        Me.BasicLabel23.PLCAddressKeypad = ""
        Me.BasicLabel23.PLCAddressVisible = "B3:0/2"
        Me.BasicLabel23.PollRate = 0
        Me.BasicLabel23.Size = New System.Drawing.Size(27, 13)
        Me.BasicLabel23.TabIndex = 132
        Me.BasicLabel23.Text = " On"
        Me.BasicLabel23.Value = " On"
        Me.BasicLabel23.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel23.ValueLeftPadLength = 0
        Me.BasicLabel23.ValuePrefix = Nothing
        Me.BasicLabel23.ValueScaleFactor = 1.0R
        Me.BasicLabel23.ValueSuffix = Nothing
        '
        'BasicLabel24
        '
        Me.BasicLabel24.AutoSize = True
        Me.BasicLabel24.BackColor = System.Drawing.Color.Lime
        Me.BasicLabel24.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel24.CommComponent = Me.DF1Com1
        Me.BasicLabel24.ForeColor = System.Drawing.Color.Black
        Me.BasicLabel24.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel24.HighlightKeyCharacter = "!"
        Me.BasicLabel24.KeypadAlpahNumeric = False
        Me.BasicLabel24.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel24.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel24.KeypadMaxValue = 0.0R
        Me.BasicLabel24.KeypadMinValue = 0.0R
        Me.BasicLabel24.KeypadScaleFactor = 1.0R
        Me.BasicLabel24.KeypadShowCurrentValue = False
        Me.BasicLabel24.KeypadText = Nothing
        Me.BasicLabel24.KeypadWidth = 300
        Me.BasicLabel24.Location = New System.Drawing.Point(778, 130)
        Me.BasicLabel24.Name = "BasicLabel24"
        Me.BasicLabel24.NumericFormat = Nothing
        Me.BasicLabel24.PLCAddressKeypad = ""
        Me.BasicLabel24.PLCAddressVisible = "B3:0/5"
        Me.BasicLabel24.PollRate = 0
        Me.BasicLabel24.Size = New System.Drawing.Size(27, 13)
        Me.BasicLabel24.TabIndex = 133
        Me.BasicLabel24.Text = " On"
        Me.BasicLabel24.Value = " On"
        Me.BasicLabel24.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel24.ValueLeftPadLength = 0
        Me.BasicLabel24.ValuePrefix = Nothing
        Me.BasicLabel24.ValueScaleFactor = 1.0R
        Me.BasicLabel24.ValueSuffix = Nothing
        '
        'BasicLabel25
        '
        Me.BasicLabel25.AutoSize = True
        Me.BasicLabel25.BackColor = System.Drawing.Color.Lime
        Me.BasicLabel25.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel25.CommComponent = Me.DF1Com1
        Me.BasicLabel25.ForeColor = System.Drawing.Color.Black
        Me.BasicLabel25.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel25.HighlightKeyCharacter = "!"
        Me.BasicLabel25.KeypadAlpahNumeric = False
        Me.BasicLabel25.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel25.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel25.KeypadMaxValue = 0.0R
        Me.BasicLabel25.KeypadMinValue = 0.0R
        Me.BasicLabel25.KeypadScaleFactor = 1.0R
        Me.BasicLabel25.KeypadShowCurrentValue = False
        Me.BasicLabel25.KeypadText = Nothing
        Me.BasicLabel25.KeypadWidth = 300
        Me.BasicLabel25.Location = New System.Drawing.Point(778, 104)
        Me.BasicLabel25.Name = "BasicLabel25"
        Me.BasicLabel25.NumericFormat = Nothing
        Me.BasicLabel25.PLCAddressKeypad = ""
        Me.BasicLabel25.PLCAddressVisible = "B3:0/4"
        Me.BasicLabel25.PollRate = 0
        Me.BasicLabel25.Size = New System.Drawing.Size(27, 13)
        Me.BasicLabel25.TabIndex = 134
        Me.BasicLabel25.Text = " On"
        Me.BasicLabel25.Value = " On"
        Me.BasicLabel25.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel25.ValueLeftPadLength = 0
        Me.BasicLabel25.ValuePrefix = Nothing
        Me.BasicLabel25.ValueScaleFactor = 1.0R
        Me.BasicLabel25.ValueSuffix = Nothing
        '
        'BasicLabel26
        '
        Me.BasicLabel26.AutoSize = True
        Me.BasicLabel26.BackColor = System.Drawing.Color.Lime
        Me.BasicLabel26.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel26.CommComponent = Me.DF1Com1
        Me.BasicLabel26.ForeColor = System.Drawing.Color.Black
        Me.BasicLabel26.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel26.HighlightKeyCharacter = "!"
        Me.BasicLabel26.KeypadAlpahNumeric = False
        Me.BasicLabel26.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel26.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel26.KeypadMaxValue = 0.0R
        Me.BasicLabel26.KeypadMinValue = 0.0R
        Me.BasicLabel26.KeypadScaleFactor = 1.0R
        Me.BasicLabel26.KeypadShowCurrentValue = False
        Me.BasicLabel26.KeypadText = Nothing
        Me.BasicLabel26.KeypadWidth = 300
        Me.BasicLabel26.Location = New System.Drawing.Point(778, 75)
        Me.BasicLabel26.Name = "BasicLabel26"
        Me.BasicLabel26.NumericFormat = Nothing
        Me.BasicLabel26.PLCAddressKeypad = ""
        Me.BasicLabel26.PLCAddressVisible = "B3:0/3"
        Me.BasicLabel26.PollRate = 0
        Me.BasicLabel26.Size = New System.Drawing.Size(27, 13)
        Me.BasicLabel26.TabIndex = 135
        Me.BasicLabel26.Text = " On"
        Me.BasicLabel26.Value = " On"
        Me.BasicLabel26.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel26.ValueLeftPadLength = 0
        Me.BasicLabel26.ValuePrefix = Nothing
        Me.BasicLabel26.ValueScaleFactor = 1.0R
        Me.BasicLabel26.ValueSuffix = Nothing
        '
        'BasicLabel27
        '
        Me.BasicLabel27.AutoSize = True
        Me.BasicLabel27.BackColor = System.Drawing.Color.Lime
        Me.BasicLabel27.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel27.CommComponent = Me.DF1Com1
        Me.BasicLabel27.ForeColor = System.Drawing.Color.Black
        Me.BasicLabel27.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel27.HighlightKeyCharacter = "!"
        Me.BasicLabel27.KeypadAlpahNumeric = False
        Me.BasicLabel27.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel27.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel27.KeypadMaxValue = 0.0R
        Me.BasicLabel27.KeypadMinValue = 0.0R
        Me.BasicLabel27.KeypadScaleFactor = 1.0R
        Me.BasicLabel27.KeypadShowCurrentValue = False
        Me.BasicLabel27.KeypadText = Nothing
        Me.BasicLabel27.KeypadWidth = 300
        Me.BasicLabel27.Location = New System.Drawing.Point(778, 162)
        Me.BasicLabel27.Name = "BasicLabel27"
        Me.BasicLabel27.NumericFormat = Nothing
        Me.BasicLabel27.PLCAddressKeypad = ""
        Me.BasicLabel27.PLCAddressVisible = "B3:0/6"
        Me.BasicLabel27.PollRate = 0
        Me.BasicLabel27.Size = New System.Drawing.Size(27, 13)
        Me.BasicLabel27.TabIndex = 136
        Me.BasicLabel27.Text = " On"
        Me.BasicLabel27.Value = " On"
        Me.BasicLabel27.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel27.ValueLeftPadLength = 0
        Me.BasicLabel27.ValuePrefix = Nothing
        Me.BasicLabel27.ValueScaleFactor = 1.0R
        Me.BasicLabel27.ValueSuffix = Nothing
        '
        'BasicLabel28
        '
        Me.BasicLabel28.AutoSize = True
        Me.BasicLabel28.BackColor = System.Drawing.Color.Lime
        Me.BasicLabel28.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel28.CommComponent = Me.DF1Com1
        Me.BasicLabel28.ForeColor = System.Drawing.Color.Black
        Me.BasicLabel28.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel28.HighlightKeyCharacter = "!"
        Me.BasicLabel28.KeypadAlpahNumeric = False
        Me.BasicLabel28.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel28.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel28.KeypadMaxValue = 0.0R
        Me.BasicLabel28.KeypadMinValue = 0.0R
        Me.BasicLabel28.KeypadScaleFactor = 1.0R
        Me.BasicLabel28.KeypadShowCurrentValue = False
        Me.BasicLabel28.KeypadText = Nothing
        Me.BasicLabel28.KeypadWidth = 300
        Me.BasicLabel28.Location = New System.Drawing.Point(778, 191)
        Me.BasicLabel28.Name = "BasicLabel28"
        Me.BasicLabel28.NumericFormat = Nothing
        Me.BasicLabel28.PLCAddressKeypad = ""
        Me.BasicLabel28.PLCAddressVisible = "B3:0/7"
        Me.BasicLabel28.PollRate = 0
        Me.BasicLabel28.Size = New System.Drawing.Size(27, 13)
        Me.BasicLabel28.TabIndex = 137
        Me.BasicLabel28.Text = " On"
        Me.BasicLabel28.Value = " On"
        Me.BasicLabel28.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(0)
        Me.BasicLabel28.ValueLeftPadLength = 0
        Me.BasicLabel28.ValuePrefix = Nothing
        Me.BasicLabel28.ValueScaleFactor = 1.0R
        Me.BasicLabel28.ValueSuffix = Nothing
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(916, 562)
        Me.Controls.Add(Me.BasicLabel28)
        Me.Controls.Add(Me.BasicLabel27)
        Me.Controls.Add(Me.BasicLabel26)
        Me.Controls.Add(Me.BasicLabel25)
        Me.Controls.Add(Me.BasicLabel24)
        Me.Controls.Add(Me.BasicLabel23)
        Me.Controls.Add(Me.BasicLabel21)
        Me.Controls.Add(Me.BasicLabel1)
        Me.Controls.Add(Me.PilotLight4)
        Me.Controls.Add(Me.PilotLight5)
        Me.Controls.Add(Me.PilotLight2)
        Me.Controls.Add(Me.BasicLabel17)
        Me.Controls.Add(Me.BasicLabel18)
        Me.Controls.Add(Me.BasicLabel15)
        Me.Controls.Add(Me.BasicLabel16)
        Me.Controls.Add(Me.BasicLabel6)
        Me.Controls.Add(Me.BasicLabel5)
        Me.Controls.Add(Me.BasicButton26)
        Me.Controls.Add(Me.MessageDisplayByValue7)
        Me.Controls.Add(Me.MessageDisplayByValue6)
        Me.Controls.Add(Me.MessageDisplayByValue5)
        Me.Controls.Add(Me.MessageDisplayByValue4)
        Me.Controls.Add(Me.MessageDisplayByValue3)
        Me.Controls.Add(Me.MessageDisplayByValue2)
        Me.Controls.Add(Me.MessageDisplayByValue1)
        Me.Controls.Add(Me.BasicLabel14)
        Me.Controls.Add(Me.BasicLabel13)
        Me.Controls.Add(Me.BasicLabel12)
        Me.Controls.Add(Me.BasicLabel11)
        Me.Controls.Add(Me.BasicLabel10)
        Me.Controls.Add(Me.BasicLabel9)
        Me.Controls.Add(Me.BasicLabel8)
        Me.Controls.Add(Me.BasicButton23)
        Me.Controls.Add(Me.BasicButton24)
        Me.Controls.Add(Me.BasicButton25)
        Me.Controls.Add(Me.BasicButton20)
        Me.Controls.Add(Me.BasicButton21)
        Me.Controls.Add(Me.BasicButton22)
        Me.Controls.Add(Me.BasicButton17)
        Me.Controls.Add(Me.BasicButton18)
        Me.Controls.Add(Me.BasicButton19)
        Me.Controls.Add(Me.BasicButton14)
        Me.Controls.Add(Me.BasicButton15)
        Me.Controls.Add(Me.BasicButton16)
        Me.Controls.Add(Me.BasicButton11)
        Me.Controls.Add(Me.BasicButton12)
        Me.Controls.Add(Me.BasicButton13)
        Me.Controls.Add(Me.BasicButton8)
        Me.Controls.Add(Me.BasicButton9)
        Me.Controls.Add(Me.BasicButton10)
        Me.Controls.Add(Me.BasicButton7)
        Me.Controls.Add(Me.BasicButton6)
        Me.Controls.Add(Me.BasicButton5)
        Me.Controls.Add(Me.PilotLight7)
        Me.Controls.Add(Me.PilotLight6)
        Me.Controls.Add(Me.BasicButton4)
        Me.Controls.Add(Me.BasicButton3)
        Me.Controls.Add(Me.PilotLight3)
        Me.Controls.Add(Me.BasicLabel7)
        Me.Controls.Add(Me.Tank1)
        Me.Controls.Add(Me.PilotLight1)
        Me.Controls.Add(Me.MomentaryButton2)
        Me.Controls.Add(Me.MomentaryButton1)
        Me.Controls.Add(Me.BasicLabel2)
        Me.Controls.Add(Me.BasicLabel22)
        Me.Controls.Add(Me.BasicLabel20)
        Me.Controls.Add(Me.BasicLabel19)
        Me.Controls.Add(Me.BasicLabel4)
        Me.Controls.Add(Me.BasicLabel3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AdvancedHMI v3.99d"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DF1Com1 As AdvancedHMIDrivers.DF1Com
    Friend WithEvents MomentaryButton1 As AdvancedHMIControls.MomentaryButton
    Friend WithEvents MomentaryButton2 As AdvancedHMIControls.MomentaryButton
    Friend WithEvents PilotLight1 As AdvancedHMIControls.PilotLight
    Friend WithEvents Tank1 As AdvancedHMIControls.Tank
    Friend WithEvents BasicLabel7 As AdvancedHMIControls.BasicLabel
    Friend WithEvents PilotLight5 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight3 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight2 As AdvancedHMIControls.PilotLight
    Friend WithEvents BasicButton4 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton3 As AdvancedHMIControls.BasicButton
    Friend WithEvents PilotLight7 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight6 As AdvancedHMIControls.PilotLight
    Friend WithEvents BasicButton23 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton24 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton25 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton20 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton21 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton22 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton17 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton18 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton19 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton14 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton15 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton16 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton11 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton12 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton13 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton8 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton9 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton10 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton7 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton6 As AdvancedHMIControls.BasicButton
    Friend WithEvents BasicButton5 As AdvancedHMIControls.BasicButton
    Friend WithEvents MessageDisplayByValue7 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MessageDisplayByValue6 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MessageDisplayByValue5 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MessageDisplayByValue4 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MessageDisplayByValue3 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MessageDisplayByValue2 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents MessageDisplayByValue1 As AdvancedHMIControls.MessageDisplayByValue
    Friend WithEvents BasicLabel14 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel13 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel12 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel11 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel10 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel9 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel8 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel17 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel18 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel15 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel16 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel6 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel5 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicButton26 As AdvancedHMIControls.BasicButton
    Friend WithEvents PilotLight4 As AdvancedHMIControls.PilotLight
    Friend WithEvents BasicLabel22 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel21 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel20 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel19 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel4 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel3 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel2 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel1 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel28 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel27 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel26 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel25 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel24 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel23 As AdvancedHMIControls.BasicLabel
End Class
