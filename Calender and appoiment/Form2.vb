Public Class Form2
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str1 As Double = txt1.Text
        Dim str2 As Double = txt2.Text

        Dim str_add As String = str1 + str2
        Dim str_minus As String = str1 - str2
        Dim str_multiply As String = str1 * str2
        Dim str_divide As String = str1 / str2
        Dim str_modulus As String = str1 Mod str2

        Label3.Text = "result :" + Environment.NewLine _
        + "Sum :" + str_add + Environment.NewLine _
        + "Difference :" + str_minus + Environment.NewLine _
        + "Product : " + str_multiply + Environment.NewLine _
        + "Integer Quotient : " + str_modulus + Environment.NewLine _
        + "Division : " + str_divide

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txt2.TextChanged

    End Sub

    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class