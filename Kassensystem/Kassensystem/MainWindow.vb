Imports Kassensystem_Logic.Saving

Public Class MainWindow
    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        FileIO.loadDiningPlan("C:\Users\PegaMenis\ownCloud\Musikverein\Kassensystem\exampleDiningPlan.xml")
    End Sub
End Class
