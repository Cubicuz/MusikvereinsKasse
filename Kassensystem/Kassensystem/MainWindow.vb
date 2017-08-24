Imports Kassensystem_Logic.Saving
Imports Kassensystem_Logic.Dining
Imports Microsoft.VisualBasic.FileIO

Public Class MainWindow

    Private isSessionOpen As Boolean = False
    Private _DiningPlanPanel As DiningPlanPanel

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        'Dim DNP As DiningPlan = FileIO.LoadDiningPlan("exampleDiningPlan.xml") 'New DiningPlan(MG)
        'DiningPlan.DiningPlanInstance = DNP
        'Dim DNPP As DiningPlanPanel = New DiningPlanPanel(DNP)
        'MainTableLayoutPanel.Controls.Add(DNPP, 0, 0)
        'DNPP.Dock = DockStyle.Fill
        'CurrentOrderPanel1.InitializeCurrentOrderPanel(DNP)
        'FileIO.loadDiningPlan("C:\Users\PegaMenis\ownCloud\Musikverein\Kassensystem\exampleDiningPlan.xml")
    End Sub

    Private Sub ÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖffnenToolStripMenuItem.Click
        If isSessionOpen Then
            'TODO: ask to save Session
        End If
        Dim fd As OpenFileDialog = New OpenFileDialog()
        fd.Title = "Kasse öffnen"
        fd.InitialDirectory = SpecialDirectories.Desktop
        fd.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"
        fd.FilterIndex = 1
        fd.RestoreDirectory = True
        If fd.ShowDialog() = DialogResult.OK Then
            CloseProject()
            Try
                DiningPlan.DiningPlanInstance = FileIO.LoadDiningPlan(fd.FileName)
                _DiningPlanPanel = New DiningPlanPanel(DiningPlan.DiningPlanInstance)
                CurrentOrderPanel1.InitializeCurrentOrderPanel(DiningPlan.DiningPlanInstance)
                MainTableLayoutPanel.Controls.Add(_DiningPlanPanel, 0, 0)
                _DiningPlanPanel.Dock = DockStyle.Fill
            Catch ex As Exception
                MsgBox("fehler beim laden der Datei")
            End Try
        End If
    End Sub

    Private Sub CloseProject()
        If MainTableLayoutPanel.Controls.Contains(_DiningPlanPanel) Then
            MainTableLayoutPanel.Controls.Remove(_DiningPlanPanel)
        End If
    End Sub
End Class
