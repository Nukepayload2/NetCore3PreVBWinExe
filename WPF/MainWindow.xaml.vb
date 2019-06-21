Imports System.Windows

Partial Class MainWindow
    Private Sub ButtonExit_Click(sender As Object, e As RoutedEventArgs) Handles ButtonExit.Click
        If MsgBox("Are you sure you want to exit?", vbQuestion Or vbYesNo) = vbYes Then
            Application.Current.Shutdown()
        End If
    End Sub
End Class
