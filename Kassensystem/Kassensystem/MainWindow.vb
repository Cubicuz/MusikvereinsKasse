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
    End Sub

    Private Sub CloseProject()
        If MainTableLayoutPanel.Controls.Contains(_DiningPlanPanel) Then
            MainTableLayoutPanel.Controls.Remove(_DiningPlanPanel)
        End If
    End Sub

    Private Sub SpeichernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeichernToolStripMenuItem.Click

        FileIO.saveOrders()
    End Sub

    Private Sub SpeichernUnterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeichernUnterToolStripMenuItem.Click

        Dim fd As SaveFileDialog = New SaveFileDialog()
        fd.Title = "Speichern"
        fd.InitialDirectory = SpecialDirectories.Desktop
        fd.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"
        fd.FilterIndex = 1
        fd.RestoreDirectory = True
        If fd.ShowDialog() = DialogResult.OK Then
            FileIO.OrderFile = fd.FileName
            FileIO.saveOrders()
        End If

    End Sub

    Private Sub LoadingDiningPlanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadDiningPlanToolStripMenuItem.Click
        If isSessionOpen Then
            'TODO: ask to save Session
        End If
        Dim fd As OpenFileDialog = New OpenFileDialog()
        fd.Title = "Menüplan laden"
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
                isSessionOpen = True
            Catch ex As Exception
                MsgBox("fehler beim laden der Datei" & vbNewLine & ex.Message)
            End Try
        End If

    End Sub

    Private Sub SaveDiningPlanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveDiningPlanToolStripMenuItem.Click
        If DiningPlan.DiningPlanInstance IsNot Nothing Then
            Dim fd As SaveFileDialog = New SaveFileDialog()
            fd.Title = "Menüplan speichern"
            fd.InitialDirectory = SpecialDirectories.Desktop
            fd.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"
            fd.FilterIndex = 1
            fd.RestoreDirectory = True
            If fd.ShowDialog() = DialogResult.OK Then
                FileIO.saveDiningPlan(fd.FileName, DiningPlan.DiningPlanInstance)
            End If
        End If
    End Sub
End Class
