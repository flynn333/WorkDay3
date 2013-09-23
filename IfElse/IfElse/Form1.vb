Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim Num1 As Double
        Dim Num2 As Double
        Num1 = CDbl(txtFirstNum.Text)
        Num2 = CDbl(txtSecondNum.Text)


        If Num1 = Num2 Then
            txtResult.Text = "They are the same"
        ElseIf Num1 < Num2 Then
            txtResult.Text = CStr(Num2) + " Is the larger number"
        ElseIf Num2 < Num1 Then
            txtResult.Text = CStr(Num1) + " Is the larger number"

        End If


    End Sub

    Private Sub IgnoreNumbers(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFirstNum.KeyPress, txtSecondNum.KeyPress
        Static i As Integer
        If i > 25 Then
            MsgBox("Please use numbers only", MsgBoxStyle.OkOnly, "Which is bigger help")
            i = 0
        End If
        If IsNumeric(e.KeyChar) = False Then
            i = i + 1
            e.Handled = True
        End If
    End Sub
End Class
