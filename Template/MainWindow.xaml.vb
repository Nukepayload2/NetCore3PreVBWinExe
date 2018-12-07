Imports System.Windows

Partial Class MainWindow
    Private Sub ButtonExit_Click(ByVal sender As Object, ByVal e As RoutedEventArgs) Handles ButtonExit.Click
        Application.Current.Shutdown()
    End Sub
End Class