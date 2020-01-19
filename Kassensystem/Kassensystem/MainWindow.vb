Imports Kassensystem_Logic.Saving
Imports Kassensystem_Logic.Dining
Imports Microsoft.VisualBasic.FileIO
Imports System.IO

Public Class MainWindow
    Private Shared statisticsBasePath = SpecialDirectories.Desktop
    Private Shared diningplanPath = SpecialDirectories.Desktop & "\Menueplan.xml"
    Private isSessionOpen As Boolean = False
    Private _DiningPlanPanel As DiningPlanPanel

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        OpenStandartDiningPlan()
        If isSessionOpen Then
            EvaluateStatisticsPath()
        End If
        'Dim DNP As DiningPlan = FileIO.LoadDiningPlan("exampleDiningPlan.xml") 'New DiningPlan(MG)
        'DiningPlan.DiningPlanInstance = DNP
        'Dim DNPP As DiningPlanPanel = New DiningPlanPanel(DNP)
        'MainTableLayoutPanel.Controls.Add(DNPP, 0, 0)
        'DNPP.Dock = DockStyle.Fill
        'CurrentOrderPanel1.InitializeCurrentOrderPanel(DNP)
        'FileIO.loadDiningPlan("C:\Users\PegaMenis\ownCloud\Musikverein\Kassensystem\exampleDiningPlan.xml")
    End Sub



    Private Sub CloseProject()
        If MainTableLayoutPanel.Controls.Contains(_DiningPlanPanel) Then
            MainTableLayoutPanel.Controls.Remove(_DiningPlanPanel)
        End If
    End Sub

    Private Sub LoadStatisticsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim fd As OpenFileDialog = New OpenFileDialog()
        fd.Title = "Statistik laden"
        fd.InitialDirectory = SpecialDirectories.Desktop
        fd.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"
        fd.FilterIndex = 1
        fd.RestoreDirectory = True
        If fd.ShowDialog() = DialogResult.OK Then
            Try
                If Not FileIO.loadOrders(fd.FileName) Then
                    MsgBox("Es muss zuerst ein Menüplan geöffnet werden")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Public Function EvaluateStatisticsPath() As String
        Dim time = DateTime.Now
        If time.Hour < 7 Then 'Tageswechsel um 7, somit muss keiner was speichern
            time = time.AddDays(-1)
        End If
        Dim culture = New System.Globalization.CultureInfo("de-DE")
        Dim germanDay As String = culture.DateTimeFormat.GetDayName(time.DayOfWeek)
        Dim pathToStatistics = statisticsBasePath & "\" & time.Year & "\" & germanDay & ".csv"
        If File.Exists(pathToStatistics) Then
            FileIO.loadOrders(pathToStatistics)
        Else
            FileIO.saveOrders(pathToStatistics)
        End If
        Return pathToStatistics
    End Function

    Public Sub OpenStandartDiningPlan()
        If File.Exists(diningplanPath) Then
            Try

                DiningPlan.DiningPlanInstance = FileIO.LoadDiningPlan(diningplanPath)
                _DiningPlanPanel = New DiningPlanPanel(DiningPlan.DiningPlanInstance)
                CurrentOrderPanel1.InitializeCurrentOrderPanel(DiningPlan.DiningPlanInstance)
                MainTableLayoutPanel.Controls.Add(_DiningPlanPanel, 0, 0)
                _DiningPlanPanel.Dock = DockStyle.Fill
                isSessionOpen = True
            Catch ex As Exception
                MsgBox("fehler beim laden der Datei" & vbNewLine & ex.Message)
            End Try
        Else
            LoadingDiningPlanToolStripMenuItem_Click()
        End If
    End Sub

    Private Sub SaveStatisticToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            If FileIO.OrderOpen Then
                FileIO.saveOrders()
            Else
                SaveStatisticUnderToolStripMenuItem_Click(Nothing, Nothing)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SaveStatisticUnderToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Dim fd As SaveFileDialog = New SaveFileDialog()
        fd.Title = "Speichern"
        fd.InitialDirectory = SpecialDirectories.Desktop
        fd.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"
        fd.FilterIndex = 1
        fd.RestoreDirectory = True
        If fd.ShowDialog() = DialogResult.OK Then
            FileIO.OrderFilePath = fd.FileName
            Try
                FileIO.saveOrders()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Private Sub LoadingDiningPlanToolStripMenuItem_Click(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles LoadDiningPlanToolStripMenuItem.Click
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

    Private Sub SaveDiningPlanToolStripMenuItem_Click(sender As Object, e As EventArgs)
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
