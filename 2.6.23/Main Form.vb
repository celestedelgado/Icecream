Public Class frmMain
    Private Sub lbFlavors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbFlavors.SelectedIndexChanged
        If lbFlavors.SelectedIndex = 0 Then
            picFlavors.Image = My.Resources.vanilla
        ElseIf lbFlavors.SelectedIndex = 1 Then
            picFlavors.Image = My.Resources.chocolate_icecream
        ElseIf lbFlavors.SelectedIndex = 2 Then
            picFlavors.Image = My.Resources.strawberry_icecream
        ElseIf lbFlavors.SelectedIndex = 3 Then
            picFlavors.Image = My.Resources.Cookies_and_Cream_Ice_Cream_1_3
        ElseIf lbFlavors.SelectedIndex = 4 Then
            picFlavors.Image = My.Resources.cookie_dough_ice_cream

        End If
    End Sub
End Class
