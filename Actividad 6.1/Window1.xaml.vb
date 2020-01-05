Class Window1

    Public Sub New()

        InitializeComponent()

        ReportViewer.Owner = Me
        ReportViewer2.Owner = Me


        Dim informe As New InformeClientes
        Dim informe2 As New InformePorPaises
        Dim informe3 As New InformePedidos
        'Dim informe4 As New InformeGrafico 


        informe.SetDatabaseLogon("administrador", "admin123.")
        ReportViewer.ViewerCore.ReportSource = informe

        informe2.SetDatabaseLogon("administrador", "admin123.")
        ReportViewer2.ViewerCore.ReportSource = informe2

        informe3.SetDatabaseLogon("administrador", "admin123.")
        ReportViewer3.ViewerCore.ReportSource = informe3

        'informe4.SetDatabaseLogon("administrador", "admin123.")
        'ReportViewer4.ViewerCore.ReportSource = informe4

    End Sub
End Class
