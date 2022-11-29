Public Class Form3

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Add(ComboBox1.Text)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            CheckBox2.Enabled = False
            TextBox1.Enabled = False
            TextBox2.Enabled = False
        Else
            CheckBox2.Enabled = True
            TextBox1.Enabled = True
            TextBox2.Enabled = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.CheckState = CheckState.Checked Then
            CheckBox1.Enabled = False
        Else
            CheckBox1.Enabled = True
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.CheckState = CheckState.Checked Then
            CheckBox3.Enabled = False
            TextBox4.Enabled = False
        Else
            CheckBox3.Enabled = True
            TextBox4.Enabled = True
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.CheckState = CheckState.Checked Then
            CheckBox4.Enabled = False
        Else
            CheckBox4.Enabled = True
        End If
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.Hide()
        Form2.Hide()
        Articulos.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form2.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim x As Integer = -1
        x = ListBox1.FindString(ListBox1.Text)
        If CheckBox1.CheckState = CheckState.Checked And CheckBox4.CheckState = CheckState.Checked And x > -1 Then
            MsgBox("Tu compra ha sido registrada con éxito")
        ElseIf CheckBox1.CheckState = CheckState.Checked And CheckBox3.CheckState = CheckState.Checked And ListBox1.FindString(" ") Then
            MsgBox("Tu compra ha sido registrada con éxito")
        ElseIf CheckBox2.CheckState = CheckState.Checked And CheckBox3.CheckState = CheckState.Checked And ListBox1.FindString(" ") Then
            MsgBox("Tu compra ha sido registrada con éxito")
        ElseIf CheckBox2.CheckState = CheckState.Checked And CheckBox3.CheckState = CheckState.Checked And ListBox1.FindString(" ") Then
            MsgBox("Tu compra ha sido registrada con éxito")
        Else
            MsgBox("Falta seleccionar una opción o un producto")
        End If

    End Sub
End Class