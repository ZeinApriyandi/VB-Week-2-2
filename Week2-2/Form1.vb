﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Hello " + TextBox1.Text, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
