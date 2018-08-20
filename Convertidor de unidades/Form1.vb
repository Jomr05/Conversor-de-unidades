Public Class Form1


    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        If opcion1.Text = "Kilogramos" And opcion2.Text = "kilogramos" Then
            Lbr.Text = Val(nc.Text)
            um.Text = "Kgs"
        ElseIf opcion1.Text = "Kilogramos" And opcion2.Text = "Libras" Then
            Lbr.Text = Val(nc.Text) * 2.2
            um.Text = "LBs"
        ElseIf opcion1.Text = "Kilogramos" And opcion2.Text = "Gramos" Then
            Lbr.Text = Val(nc.Text) * 1000
            um.Text = "Gs"
        ElseIf opcion1.Text = "Libras" And opcion2.Text = "Libras" Then
            Lbr.Text = Val(nc.Text)
            um.Text = "LBs"
        ElseIf opcion1.Text = "Libras" And opcion2.Text = "kilogramos" Then
            Lbr.Text = Val(nc.Text) / 2.2
            um.Text = "Kgs"
        ElseIf opcion1.Text = "Libras" And opcion2.Text = "Gramos" Then
            Lbr.Text = Val(nc.Text) * 453.6
            um.Text = "Gs"
        ElseIf opcion1.Text = "Gramos" And opcion2.Text = "Gramos" Then
            Lbr.Text = Val(nc.Text)
            um.Text = "Gs"
        ElseIf opcion1.Text = "Gramos" And opcion2.Text = "Kilogramos" Then
            Lbr.Text = Val(nc.Text) / 1000
            um.Text = "kgs"
        ElseIf opcion1.Text = "Gramos" And opcion2.Text = "Libras" Then
            Lbr.Text = Val(nc.Text) / 453.6
            um.Text = "Lbs"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Lbr.Text = ""
        um.Text = ""
        nc.Text = ""
    End Sub

    Private Sub um_Click(sender As Object, e As EventArgs) Handles um.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
