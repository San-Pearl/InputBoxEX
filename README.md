﻿# InputBoxEX
Expanded InputBox

標準のInputBoxを使ってテキストボックスに文字を入力しないで「OK」ボタンを押した場合、「Cancel」ボタンが押されたのか「OK」ボタンが押されたのかの区別がつかない。
入力文字と押したボタンを返すInputBoxをフォームを継承して作成した。

If you press the "OK" button without entering characters in the input box using the standard InputBox, you can not know whether the "Cancel" button was pressed or the "OK" button was pressed.
I created an InputBox that inherits the FORM and can retrieve the entered letters and pressed buttons.


USAGE

Dim InpBox As New InputBoxEX("InputBoxEX", "Input word", True, 220, 150)
Dim Res As Integer = InpBox.ShowDialog
Dim Mes As String = InpBox.InputTxt
If Res = DialogResult.OK Then
    MsgBox("Press OK & Input Word is " & Mes)
ElseIf Res = DialogResult.Cancel Then
    MsgBox("Press Cancel & Input Word is " & mes)
End If