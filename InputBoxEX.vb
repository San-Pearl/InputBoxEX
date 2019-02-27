Class InputBoxEX

    Inherits Form
    Public Property InputTxt As String
    WithEvents OkBtn As New Button
    WithEvents CancelBtn As New Button

    Private TBox As New TextBox
    Private Lbl As New Label

    Sub New(Title As String,
            Msg As String,
            Optional CancelBtnEnable As Boolean = False,
            Optional Width As Integer = 220,
            Optional Height As Integer = 150
            )

        Text = Title
        Size = New Size(Width, Height)
        ShowIcon = False
        ShowInTaskbar = False
        MinimizeBox = False
        MaximizeBox = False
        StartPosition = FormStartPosition.CenterScreen
        FormBorderStyle = FormBorderStyle.FixedDialog
        OkBtn.Text = "OK"
        OkBtn.Location = New Point(Width - 100, Height - 70)

        CancelBtn.Text = "Cancel"
        CancelBtn.Location = New Point(Width - 200, Height - 70)

        TBox.Font = New Font("MS UI Gothic", 11)
        TBox.Width = Width - 80
        TBox.Location = New Point(10, Height - 100)

        Lbl.Font = New Font("MS UI Gothic", 11)
        Lbl.Location = New Point(10, 10)
        Lbl.AutoSize = True
        'Controls.AddRange({TBox, Lbl, OkBtn, CancelBtn})

        TBox.Text = ""

        Lbl.Text = Msg

        ControlBox = False

        CancelBtn.Visible = CancelBtnEnable
        Controls.AddRange({TBox, Lbl, OkBtn, CancelBtn})

        AddHandler CancelBtn.Click,
            Sub()
                InputTxt = TBox.Text
                DialogResult = DialogResult.Cancel
                Close()
            End Sub

        AddHandler OkBtn.Click,
            Sub()
                InputTxt = TBox.Text
                DialogResult = DialogResult.OK
                Close()
            End Sub
    End Sub

End Class
