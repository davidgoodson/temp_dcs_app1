Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load


    End Sub

    Protected Sub ButtonClicked(sender As Object, e As EventArgs) Handles Button1.Click
        txtShow.Text = "Someone Clicked The Button"
    End Sub
End Class