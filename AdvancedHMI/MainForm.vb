Public Class MainForm
    Private NotFirstShow As Boolean
    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        If NotFirstShow Then
            AdvancedHMIDrivers.Utilities.StopComsOnHidden(components, Me)
        Else
            NotFirstShow = True
        End If
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub HydraulicCylinder1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BasicLabel2_Click(sender As Object, e As EventArgs) Handles BasicLabel2.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GraphicIndicator1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PilotLight3_Click(sender As Object, e As EventArgs) Handles PilotLight3.Click

    End Sub
End Class
