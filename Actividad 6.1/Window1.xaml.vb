Class Window1

    Public Sub New()

        InitializeComponent()


        ReportViewer.Owner = Me
        ReportViewer2.Owner = Me
        ReportViewer3.Owner = Me
        ReportViewer4.Owner = Me
        ReportViewer5.Owner = Me

        Dim informe As New InformeClientes
        informe.SetDatabaseLogon("administrador", "admin123.")
        ReportViewer.ViewerCore.ReportSource = informe


        Dim informe2 As New InformePorPaises
        informe2.SetDatabaseLogon("administrador", "admin123.")
        ReportViewer2.ViewerCore.ReportSource = informe2



        Dim informe3 As New InformePedidos
        informe3.SetDatabaseLogon("administrador", "admin123.")
        ReportViewer3.ViewerCore.ReportSource = informe3

    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Dim informe4 As New InformeGrafico
        informe4.SetDatabaseLogon("administrador", "admin123.")
        ReportViewer4.ViewerCore.ReportSource = informe4


        Dim informe5 As New InformeEnvios
        informe5.SetDatabaseLogon("administrador", "admin123.")
        ReportViewer5.ViewerCore.ReportSource = informe5
    End Sub
End Class
