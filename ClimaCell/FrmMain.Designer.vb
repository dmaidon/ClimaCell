﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.TmrUpdateNowcast = New System.Timers.Timer()
        Me.TmrUpdateHourly = New System.Timers.Timer()
        Me.TsslVer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsslNextDaily = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsslNextHourly = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsslNextNowcast = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsslCpy = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsslClock = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TsslNextRt = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TpAbout = New System.Windows.Forms.TabPage()
        Me.PnlAbout = New System.Windows.Forms.Panel()
        Me.LblAbout = New System.Windows.Forms.Label()
        Me.TpOptions = New System.Windows.Forms.TabPage()
        Me.TcOpt = New System.Windows.Forms.TabControl()
        Me.TpOptMain = New System.Windows.Forms.TabPage()
        Me.PnlSettings = New System.Windows.Forms.Panel()
        Me.PnlMainOpt = New System.Windows.Forms.Panel()
        Me.TlpMainOpt = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumLongitude = New System.Windows.Forms.NumericUpDown()
        Me.RbUnitSI = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.NumDailyInterval = New System.Windows.Forms.NumericUpDown()
        Me.NumHourlyInterval = New System.Windows.Forms.NumericUpDown()
        Me.NumNowcastInterval = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ChkFetchDaily = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtApiKey = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.NumRtInterval = New System.Windows.Forms.NumericUpDown()
        Me.ChkFetchRt = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumLatiutude = New System.Windows.Forms.NumericUpDown()
        Me.RbUnitUS = New System.Windows.Forms.RadioButton()
        Me.ChkFetchHourly = New System.Windows.Forms.CheckBox()
        Me.ChkFetchNowcast = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ChkLogHeaders = New System.Windows.Forms.CheckBox()
        Me.ChkLogImages = New System.Windows.Forms.CheckBox()
        Me.TpOptDaily = New System.Windows.Forms.TabPage()
        Me.PnlDailyForecast = New System.Windows.Forms.Panel()
        Me.FlpDaily = New System.Windows.Forms.FlowLayoutPanel()
        Me.ChkTemp = New System.Windows.Forms.CheckBox()
        Me.ChkFeelsLike = New System.Windows.Forms.CheckBox()
        Me.ChkDewpoint = New System.Windows.Forms.CheckBox()
        Me.ChkHumidity = New System.Windows.Forms.CheckBox()
        Me.ChkWindSpeed = New System.Windows.Forms.CheckBox()
        Me.ChkWindDir = New System.Windows.Forms.CheckBox()
        Me.ChkBP = New System.Windows.Forms.CheckBox()
        Me.ChkVis = New System.Windows.Forms.CheckBox()
        Me.ChkPrecip = New System.Windows.Forms.CheckBox()
        Me.ChkPrecipAcc = New System.Windows.Forms.CheckBox()
        Me.ChkPrecipProb = New System.Windows.Forms.CheckBox()
        Me.ChkWxCode = New System.Windows.Forms.CheckBox()
        Me.ChkSunrise = New System.Windows.Forms.CheckBox()
        Me.ChkSunset = New System.Windows.Forms.CheckBox()
        Me.ChkMoonPhase = New System.Windows.Forms.CheckBox()
        Me.ChkUncheckAllDaily = New System.Windows.Forms.CheckBox()
        Me.ChkAllDaily = New System.Windows.Forms.CheckBox()
        Me.TpOptHourly = New System.Windows.Forms.TabPage()
        Me.PnlHourlyForecast = New System.Windows.Forms.Panel()
        Me.FlpHourly = New System.Windows.Forms.FlowLayoutPanel()
        Me.ChkHrTemp = New System.Windows.Forms.CheckBox()
        Me.ChkHrFeelsLike = New System.Windows.Forms.CheckBox()
        Me.ChkHrRH = New System.Windows.Forms.CheckBox()
        Me.ChkHrDewpoint = New System.Windows.Forms.CheckBox()
        Me.ChkHrWindDir = New System.Windows.Forms.CheckBox()
        Me.ChkHrWindGust = New System.Windows.Forms.CheckBox()
        Me.ChkHrWindSpeed = New System.Windows.Forms.CheckBox()
        Me.ChkHrPrecip = New System.Windows.Forms.CheckBox()
        Me.ChkHrPrecipType = New System.Windows.Forms.CheckBox()
        Me.ChkHrPrecipProb = New System.Windows.Forms.CheckBox()
        Me.ChkHrCloudCover = New System.Windows.Forms.CheckBox()
        Me.ChkHrCloudCeil = New System.Windows.Forms.CheckBox()
        Me.ChkHrCloudBase = New System.Windows.Forms.CheckBox()
        Me.ChkHrWxCode = New System.Windows.Forms.CheckBox()
        Me.ChkHrSunrise = New System.Windows.Forms.CheckBox()
        Me.ChkHrSunset = New System.Windows.Forms.CheckBox()
        Me.ChkHrMoonPhase = New System.Windows.Forms.CheckBox()
        Me.ChkHrBP = New System.Windows.Forms.CheckBox()
        Me.ChkHrVis = New System.Windows.Forms.CheckBox()
        Me.ChkHrSSR = New System.Windows.Forms.CheckBox()
        Me.ChkHrHailRisk = New System.Windows.Forms.CheckBox()
        Me.ChkHrTreePollen = New System.Windows.Forms.CheckBox()
        Me.ChkHrWeedPollen = New System.Windows.Forms.CheckBox()
        Me.ChkHrGrassPollen = New System.Windows.Forms.CheckBox()
        Me.ChkHrTreeAcacia = New System.Windows.Forms.CheckBox()
        Me.ChkHrTreeAsh = New System.Windows.Forms.CheckBox()
        Me.ChkHrTreeBeech = New System.Windows.Forms.CheckBox()
        Me.ChkHrTreeBirch = New System.Windows.Forms.CheckBox()
        Me.ChkHrTreeCedar = New System.Windows.Forms.CheckBox()
        Me.ChkHrTreeCottonwood = New System.Windows.Forms.CheckBox()
        Me.ChkHrTreeCypress = New System.Windows.Forms.CheckBox()
        Me.ChkHrTreeElder = New System.Windows.Forms.CheckBox()
        Me.ChkHrTreeElm = New System.Windows.Forms.CheckBox()
        Me.ChkHrTreeHemlock = New System.Windows.Forms.CheckBox()
        Me.ChkHrTreeHickory = New System.Windows.Forms.CheckBox()
        Me.ChkHrTreeJuniper = New System.Windows.Forms.CheckBox()
        Me.ChkHrTreeMahogany = New System.Windows.Forms.CheckBox()
        Me.ChkHrTreeMaple = New System.Windows.Forms.CheckBox()
        Me.ChkHrTreeMulberry = New System.Windows.Forms.CheckBox()
        Me.ChkHrTreeOak = New System.Windows.Forms.CheckBox()
        Me.ChkHrTreePine = New System.Windows.Forms.CheckBox()
        Me.ChkHrTreeSpruce = New System.Windows.Forms.CheckBox()
        Me.ChkHrTreeSycamore = New System.Windows.Forms.CheckBox()
        Me.ChkHrTreeWalnut = New System.Windows.Forms.CheckBox()
        Me.ChkHrTreeWillow = New System.Windows.Forms.CheckBox()
        Me.ChkHrRagweed = New System.Windows.Forms.CheckBox()
        Me.ChkHrGrass = New System.Windows.Forms.CheckBox()
        Me.ChkHrAqiPm10 = New System.Windows.Forms.CheckBox()
        Me.ChkHrAqiPm25 = New System.Windows.Forms.CheckBox()
        Me.ChkHrAqiO3 = New System.Windows.Forms.CheckBox()
        Me.ChkHrAqiCo = New System.Windows.Forms.CheckBox()
        Me.ChkHrAqiSo2 = New System.Windows.Forms.CheckBox()
        Me.ChkHrAqiNo2 = New System.Windows.Forms.CheckBox()
        Me.ChkHrEpaAqi = New System.Windows.Forms.CheckBox()
        Me.ChkHrEpaConcern = New System.Windows.Forms.CheckBox()
        Me.ChkHrEpaPollutant = New System.Windows.Forms.CheckBox()
        Me.ChkHrChinaAqi = New System.Windows.Forms.CheckBox()
        Me.ChkHrChinaConcern = New System.Windows.Forms.CheckBox()
        Me.ChkHrChinaPollutant = New System.Windows.Forms.CheckBox()
        Me.ChkHrRoadRisk = New System.Windows.Forms.CheckBox()
        Me.ChkHrRiskScore = New System.Windows.Forms.CheckBox()
        Me.ChkHrRiskConfidence = New System.Windows.Forms.CheckBox()
        Me.ChkHrRiskCondition = New System.Windows.Forms.CheckBox()
        Me.ChkUncheckAllHr = New System.Windows.Forms.CheckBox()
        Me.ChkAllHourly = New System.Windows.Forms.CheckBox()
        Me.TpOptNowCast = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlpNowcast = New System.Windows.Forms.FlowLayoutPanel()
        Me.ChkNcTemp = New System.Windows.Forms.CheckBox()
        Me.ChkNcFeelsLike = New System.Windows.Forms.CheckBox()
        Me.ChkNcRH = New System.Windows.Forms.CheckBox()
        Me.ChkNcDewpoint = New System.Windows.Forms.CheckBox()
        Me.ChkNcWindDir = New System.Windows.Forms.CheckBox()
        Me.ChkNcWindSpeed = New System.Windows.Forms.CheckBox()
        Me.ChkNcWindGust = New System.Windows.Forms.CheckBox()
        Me.ChkNcPrecipType = New System.Windows.Forms.CheckBox()
        Me.ChkNcPrecip = New System.Windows.Forms.CheckBox()
        Me.ChkNcCloudCover = New System.Windows.Forms.CheckBox()
        Me.ChkNcCloudCeil = New System.Windows.Forms.CheckBox()
        Me.ChkNcCloudBase = New System.Windows.Forms.CheckBox()
        Me.ChkNcWxCode = New System.Windows.Forms.CheckBox()
        Me.ChkNcVis = New System.Windows.Forms.CheckBox()
        Me.ChkNcSunrise = New System.Windows.Forms.CheckBox()
        Me.ChkNcSunset = New System.Windows.Forms.CheckBox()
        Me.ChkNcBP = New System.Windows.Forms.CheckBox()
        Me.ChkNcSSR = New System.Windows.Forms.CheckBox()
        Me.ChkNcHailRisk = New System.Windows.Forms.CheckBox()
        Me.ChkNcTreePollen = New System.Windows.Forms.CheckBox()
        Me.ChkNcWeedPollen = New System.Windows.Forms.CheckBox()
        Me.ChkNcGrassPollen = New System.Windows.Forms.CheckBox()
        Me.ChkNcAcacia = New System.Windows.Forms.CheckBox()
        Me.ChkNcAsh = New System.Windows.Forms.CheckBox()
        Me.ChkNcBeech = New System.Windows.Forms.CheckBox()
        Me.ChkNcBirch = New System.Windows.Forms.CheckBox()
        Me.ChkNcCedar = New System.Windows.Forms.CheckBox()
        Me.ChkNcCottonwood = New System.Windows.Forms.CheckBox()
        Me.ChkNcCypress = New System.Windows.Forms.CheckBox()
        Me.ChkNcElder = New System.Windows.Forms.CheckBox()
        Me.ChkNcElm = New System.Windows.Forms.CheckBox()
        Me.ChkNcHemlock = New System.Windows.Forms.CheckBox()
        Me.ChkNcHickory = New System.Windows.Forms.CheckBox()
        Me.ChkNcJuniper = New System.Windows.Forms.CheckBox()
        Me.ChkNcMahogany = New System.Windows.Forms.CheckBox()
        Me.ChkNcMaple = New System.Windows.Forms.CheckBox()
        Me.ChkNcMulberry = New System.Windows.Forms.CheckBox()
        Me.ChkNcOak = New System.Windows.Forms.CheckBox()
        Me.ChkNcPine = New System.Windows.Forms.CheckBox()
        Me.ChkNcSpruce = New System.Windows.Forms.CheckBox()
        Me.ChkNcSycamore = New System.Windows.Forms.CheckBox()
        Me.ChkNcWalnut = New System.Windows.Forms.CheckBox()
        Me.ChkNcWillow = New System.Windows.Forms.CheckBox()
        Me.ChkNcGrass = New System.Windows.Forms.CheckBox()
        Me.ChkNcRagweed = New System.Windows.Forms.CheckBox()
        Me.ChkNcPm10 = New System.Windows.Forms.CheckBox()
        Me.ChkNcPm25 = New System.Windows.Forms.CheckBox()
        Me.ChkNcO3 = New System.Windows.Forms.CheckBox()
        Me.ChkNcCo = New System.Windows.Forms.CheckBox()
        Me.ChkNcSo2 = New System.Windows.Forms.CheckBox()
        Me.ChkNcNo2 = New System.Windows.Forms.CheckBox()
        Me.ChkNcEpaAqi = New System.Windows.Forms.CheckBox()
        Me.ChkNcEpaConcern = New System.Windows.Forms.CheckBox()
        Me.ChkNcEpaPollutant = New System.Windows.Forms.CheckBox()
        Me.ChkNcChinaAqi = New System.Windows.Forms.CheckBox()
        Me.ChkNcChinaConcern = New System.Windows.Forms.CheckBox()
        Me.ChkNcChinaPollutant = New System.Windows.Forms.CheckBox()
        Me.ChkNcRoadRisk = New System.Windows.Forms.CheckBox()
        Me.ChkNcRiskScore = New System.Windows.Forms.CheckBox()
        Me.ChkNcRiskConfidence = New System.Windows.Forms.CheckBox()
        Me.ChkNcRiskCondition = New System.Windows.Forms.CheckBox()
        Me.NumNcTimeStep = New System.Windows.Forms.NumericUpDown()
        Me.ChkUncheckAllNowcast = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ChkAllNowcast = New System.Windows.Forms.CheckBox()
        Me.TpOptRealtime = New System.Windows.Forms.TabPage()
        Me.PnlOptRealtime = New System.Windows.Forms.Panel()
        Me.ChkRtUncheckAll = New System.Windows.Forms.CheckBox()
        Me.ChkRtCheckAll = New System.Windows.Forms.CheckBox()
        Me.FlpRtOpt = New System.Windows.Forms.FlowLayoutPanel()
        Me.ChkRtCore0 = New System.Windows.Forms.CheckBox()
        Me.ChkRtCore1 = New System.Windows.Forms.CheckBox()
        Me.ChkRtCore2 = New System.Windows.Forms.CheckBox()
        Me.ChkRtCore3 = New System.Windows.Forms.CheckBox()
        Me.ChkRtCore4 = New System.Windows.Forms.CheckBox()
        Me.ChkRtCore5 = New System.Windows.Forms.CheckBox()
        Me.ChkRtCore6 = New System.Windows.Forms.CheckBox()
        Me.ChkRtCore7 = New System.Windows.Forms.CheckBox()
        Me.ChkRtCore8 = New System.Windows.Forms.CheckBox()
        Me.ChkRtCore9 = New System.Windows.Forms.CheckBox()
        Me.ChkRtCore10 = New System.Windows.Forms.CheckBox()
        Me.ChkRtCore11 = New System.Windows.Forms.CheckBox()
        Me.ChkRtCore12 = New System.Windows.Forms.CheckBox()
        Me.ChkRtCore13 = New System.Windows.Forms.CheckBox()
        Me.ChkRtCore14 = New System.Windows.Forms.CheckBox()
        Me.ChkRtCore15 = New System.Windows.Forms.CheckBox()
        Me.ChkRtCore16 = New System.Windows.Forms.CheckBox()
        Me.ChkRtCore17 = New System.Windows.Forms.CheckBox()
        Me.ChkRtCore18 = New System.Windows.Forms.CheckBox()
        Me.ChkRtCore19 = New System.Windows.Forms.CheckBox()
        Me.ChkRtCore20 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol0 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol1 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol2 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol3 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol4 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol5 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol6 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol7 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol8 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol9 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol10 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol11 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol12 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol13 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol14 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol15 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol16 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol17 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol18 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol19 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol20 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol21 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol22 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol23 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol24 = New System.Windows.Forms.CheckBox()
        Me.ChkRtPol25 = New System.Windows.Forms.CheckBox()
        Me.ChkRtRoad0 = New System.Windows.Forms.CheckBox()
        Me.ChkRtRoad1 = New System.Windows.Forms.CheckBox()
        Me.ChkRtRoad2 = New System.Windows.Forms.CheckBox()
        Me.ChkRtRoad3 = New System.Windows.Forms.CheckBox()
        Me.ChkRtFire0 = New System.Windows.Forms.CheckBox()
        Me.ChkRtHail0 = New System.Windows.Forms.CheckBox()
        Me.ChkRtAqi0 = New System.Windows.Forms.CheckBox()
        Me.ChkRtAqi1 = New System.Windows.Forms.CheckBox()
        Me.ChkRtAqi2 = New System.Windows.Forms.CheckBox()
        Me.ChkRtAqi3 = New System.Windows.Forms.CheckBox()
        Me.ChkRtAqi4 = New System.Windows.Forms.CheckBox()
        Me.ChkRtAqi5 = New System.Windows.Forms.CheckBox()
        Me.ChkRtAqi6 = New System.Windows.Forms.CheckBox()
        Me.ChkRtAqi7 = New System.Windows.Forms.CheckBox()
        Me.ChkRtAqi8 = New System.Windows.Forms.CheckBox()
        Me.ChkRtAqi9 = New System.Windows.Forms.CheckBox()
        Me.ChkRtAqi10 = New System.Windows.Forms.CheckBox()
        Me.ChkRtAqi11 = New System.Windows.Forms.CheckBox()
        Me.TpLogs = New System.Windows.Forms.TabPage()
        Me.TcLogs = New System.Windows.Forms.TabControl()
        Me.TpLogLog = New System.Windows.Forms.TabPage()
        Me.RtbLog = New System.Windows.Forms.RichTextBox()
        Me.TpLogError = New System.Windows.Forms.TabPage()
        Me.RtbError = New System.Windows.Forms.RichTextBox()
        Me.TpNowcast = New System.Windows.Forms.TabPage()
        Me.DgvNowcast = New System.Windows.Forms.DataGridView()
        Me.c1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.c4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TpHourly = New System.Windows.Forms.TabPage()
        Me.DgvHourly = New System.Windows.Forms.DataGridView()
        Me.hr0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hr1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hr2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.hr3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TpDaily = New System.Windows.Forms.TabPage()
        Me.DgvDaily = New System.Windows.Forms.DataGridView()
        Me.TC = New System.Windows.Forms.TabControl()
        Me.TpRealtime = New System.Windows.Forms.TabPage()
        Me.DgvRt = New System.Windows.Forms.DataGridView()
        Me.rt0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rt1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TmrClock = New System.Timers.Timer()
        Me.TmrUpdateDaily = New System.Timers.Timer()
        Me.TmrMidnight = New System.Timers.Timer()
        Me.TmrUpdateRt = New System.Timers.Timer()
        CType(Me.TmrUpdateNowcast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TmrUpdateHourly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.TpAbout.SuspendLayout()
        Me.PnlAbout.SuspendLayout()
        Me.TpOptions.SuspendLayout()
        Me.TcOpt.SuspendLayout()
        Me.TpOptMain.SuspendLayout()
        Me.PnlSettings.SuspendLayout()
        Me.PnlMainOpt.SuspendLayout()
        Me.TlpMainOpt.SuspendLayout()
        CType(Me.NumLongitude, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumDailyInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumHourlyInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumNowcastInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumRtInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumLatiutude, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpOptDaily.SuspendLayout()
        Me.PnlDailyForecast.SuspendLayout()
        Me.FlpDaily.SuspendLayout()
        Me.TpOptHourly.SuspendLayout()
        Me.PnlHourlyForecast.SuspendLayout()
        Me.FlpHourly.SuspendLayout()
        Me.TpOptNowCast.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlpNowcast.SuspendLayout()
        CType(Me.NumNcTimeStep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpOptRealtime.SuspendLayout()
        Me.PnlOptRealtime.SuspendLayout()
        Me.FlpRtOpt.SuspendLayout()
        Me.TpLogs.SuspendLayout()
        Me.TcLogs.SuspendLayout()
        Me.TpLogLog.SuspendLayout()
        Me.TpLogError.SuspendLayout()
        Me.TpNowcast.SuspendLayout()
        CType(Me.DgvNowcast, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpHourly.SuspendLayout()
        CType(Me.DgvHourly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpDaily.SuspendLayout()
        CType(Me.DgvDaily, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TC.SuspendLayout()
        Me.TpRealtime.SuspendLayout()
        CType(Me.DgvRt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TmrClock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TmrUpdateDaily, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TmrMidnight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TmrUpdateRt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TmrUpdateNowcast
        '
        Me.TmrUpdateNowcast.SynchronizingObject = Me
        '
        'TmrUpdateHourly
        '
        Me.TmrUpdateHourly.SynchronizingObject = Me
        '
        'TsslVer
        '
        Me.TsslVer.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TsslVer.ForeColor = System.Drawing.Color.Navy
        Me.TsslVer.Name = "TsslVer"
        Me.TsslVer.Size = New System.Drawing.Size(18, 21)
        Me.TsslVer.Text = "v"
        Me.TsslVer.ToolTipText = "Application version"
        '
        'TsslNextDaily
        '
        Me.TsslNextDaily.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TsslNextDaily.ForeColor = System.Drawing.Color.Maroon
        Me.TsslNextDaily.Name = "TsslNextDaily"
        Me.TsslNextDaily.Size = New System.Drawing.Size(53, 21)
        Me.TsslNextDaily.Text = "Dly: 0"
        Me.TsslNextDaily.ToolTipText = "Time to next daily update"
        '
        'TsslNextHourly
        '
        Me.TsslNextHourly.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TsslNextHourly.ForeColor = System.Drawing.Color.ForestGreen
        Me.TsslNextHourly.Name = "TsslNextHourly"
        Me.TsslNextHourly.Size = New System.Drawing.Size(46, 21)
        Me.TsslNextHourly.Text = "Hr: 0"
        Me.TsslNextHourly.ToolTipText = "Time to next hourly updatre"
        '
        'TsslNextNowcast
        '
        Me.TsslNextNowcast.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TsslNextNowcast.ForeColor = System.Drawing.Color.Purple
        Me.TsslNextNowcast.Name = "TsslNextNowcast"
        Me.TsslNextNowcast.Size = New System.Drawing.Size(48, 21)
        Me.TsslNextNowcast.Text = "Nc: 0"
        Me.TsslNextNowcast.ToolTipText = "Time to next nowcast update"
        '
        'TsslCpy
        '
        Me.TsslCpy.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Italic)
        Me.TsslCpy.ForeColor = System.Drawing.Color.DarkRed
        Me.TsslCpy.Name = "TsslCpy"
        Me.TsslCpy.Size = New System.Drawing.Size(1126, 21)
        Me.TsslCpy.Spring = True
        Me.TsslCpy.Text = "cpy"
        '
        'TsslClock
        '
        Me.TsslClock.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.TsslClock.Name = "TsslClock"
        Me.TsslClock.Size = New System.Drawing.Size(50, 21)
        Me.TsslClock.Text = "h:mm"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.GripMargin = New System.Windows.Forms.Padding(0)
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsslVer, Me.TsslNextDaily, Me.TsslNextHourly, Me.TsslNextNowcast, Me.TsslNextRt, Me.TsslCpy, Me.TsslClock})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1042)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 14, 0)
        Me.StatusStrip1.ShowItemToolTips = True
        Me.StatusStrip1.Size = New System.Drawing.Size(1400, 28)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TsslNextRt
        '
        Me.TsslNextRt.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TsslNextRt.ForeColor = System.Drawing.Color.Blue
        Me.TsslNextRt.Name = "TsslNextRt"
        Me.TsslNextRt.Size = New System.Drawing.Size(43, 21)
        Me.TsslNextRt.Text = "Rt: 0"
        '
        'TTip
        '
        Me.TTip.IsBalloon = True
        Me.TTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'TpAbout
        '
        Me.TpAbout.Controls.Add(Me.PnlAbout)
        Me.TpAbout.Location = New System.Drawing.Point(4, 29)
        Me.TpAbout.Name = "TpAbout"
        Me.TpAbout.Size = New System.Drawing.Size(1392, 1037)
        Me.TpAbout.TabIndex = 4
        Me.TpAbout.Text = "About"
        Me.TpAbout.UseVisualStyleBackColor = True
        '
        'PnlAbout
        '
        Me.PnlAbout.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PnlAbout.BackgroundImage = Global.psClimaCell.My.Resources.Resources.powered_by_climacell_halo
        Me.PnlAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PnlAbout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlAbout.Controls.Add(Me.LblAbout)
        Me.PnlAbout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlAbout.ForeColor = System.Drawing.SystemColors.Info
        Me.PnlAbout.Location = New System.Drawing.Point(0, 0)
        Me.PnlAbout.Name = "PnlAbout"
        Me.PnlAbout.Size = New System.Drawing.Size(1392, 1037)
        Me.PnlAbout.TabIndex = 24
        '
        'LblAbout
        '
        Me.LblAbout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAbout.Location = New System.Drawing.Point(394, 348)
        Me.LblAbout.Name = "LblAbout"
        Me.LblAbout.Size = New System.Drawing.Size(600, 337)
        Me.LblAbout.TabIndex = 0
        Me.LblAbout.Text = "-"
        Me.LblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TpOptions
        '
        Me.TpOptions.Controls.Add(Me.TcOpt)
        Me.TpOptions.Location = New System.Drawing.Point(4, 29)
        Me.TpOptions.Name = "TpOptions"
        Me.TpOptions.Size = New System.Drawing.Size(1392, 1037)
        Me.TpOptions.TabIndex = 3
        Me.TpOptions.Text = "Settings"
        Me.TpOptions.UseVisualStyleBackColor = True
        '
        'TcOpt
        '
        Me.TcOpt.Controls.Add(Me.TpOptMain)
        Me.TcOpt.Controls.Add(Me.TpOptDaily)
        Me.TcOpt.Controls.Add(Me.TpOptHourly)
        Me.TcOpt.Controls.Add(Me.TpOptNowCast)
        Me.TcOpt.Controls.Add(Me.TpOptRealtime)
        Me.TcOpt.Dock = System.Windows.Forms.DockStyle.Top
        Me.TcOpt.Location = New System.Drawing.Point(0, 0)
        Me.TcOpt.Name = "TcOpt"
        Me.TcOpt.SelectedIndex = 0
        Me.TcOpt.Size = New System.Drawing.Size(1392, 1006)
        Me.TcOpt.TabIndex = 0
        '
        'TpOptMain
        '
        Me.TpOptMain.Controls.Add(Me.PnlSettings)
        Me.TpOptMain.Location = New System.Drawing.Point(4, 29)
        Me.TpOptMain.Name = "TpOptMain"
        Me.TpOptMain.Size = New System.Drawing.Size(1384, 973)
        Me.TpOptMain.TabIndex = 2
        Me.TpOptMain.Text = "Main Settings"
        Me.TpOptMain.UseVisualStyleBackColor = True
        '
        'PnlSettings
        '
        Me.PnlSettings.BackColor = System.Drawing.Color.Linen
        Me.PnlSettings.BackgroundImage = Global.psClimaCell.My.Resources.Resources.powered_by_climacell_halo_sml
        Me.PnlSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlSettings.Controls.Add(Me.PnlMainOpt)
        Me.PnlSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlSettings.Location = New System.Drawing.Point(0, 0)
        Me.PnlSettings.Name = "PnlSettings"
        Me.PnlSettings.Size = New System.Drawing.Size(1384, 970)
        Me.PnlSettings.TabIndex = 1
        '
        'PnlMainOpt
        '
        Me.PnlMainOpt.BackColor = System.Drawing.Color.Silver
        Me.PnlMainOpt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlMainOpt.Controls.Add(Me.TlpMainOpt)
        Me.PnlMainOpt.Location = New System.Drawing.Point(280, 267)
        Me.PnlMainOpt.Name = "PnlMainOpt"
        Me.PnlMainOpt.Size = New System.Drawing.Size(820, 528)
        Me.PnlMainOpt.TabIndex = 25
        '
        'TlpMainOpt
        '
        Me.TlpMainOpt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TlpMainOpt.ColumnCount = 6
        Me.TlpMainOpt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TlpMainOpt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TlpMainOpt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TlpMainOpt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TlpMainOpt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TlpMainOpt.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TlpMainOpt.Controls.Add(Me.Label3, 1, 0)
        Me.TlpMainOpt.Controls.Add(Me.Label2, 3, 1)
        Me.TlpMainOpt.Controls.Add(Me.Label7, 1, 3)
        Me.TlpMainOpt.Controls.Add(Me.NumLongitude, 3, 2)
        Me.TlpMainOpt.Controls.Add(Me.RbUnitSI, 3, 12)
        Me.TlpMainOpt.Controls.Add(Me.Label15, 1, 11)
        Me.TlpMainOpt.Controls.Add(Me.NumDailyInterval, 1, 10)
        Me.TlpMainOpt.Controls.Add(Me.NumHourlyInterval, 2, 10)
        Me.TlpMainOpt.Controls.Add(Me.NumNowcastInterval, 3, 10)
        Me.TlpMainOpt.Controls.Add(Me.Label13, 3, 9)
        Me.TlpMainOpt.Controls.Add(Me.Label12, 2, 9)
        Me.TlpMainOpt.Controls.Add(Me.Label5, 1, 9)
        Me.TlpMainOpt.Controls.Add(Me.Label11, 1, 8)
        Me.TlpMainOpt.Controls.Add(Me.ChkFetchDaily, 1, 7)
        Me.TlpMainOpt.Controls.Add(Me.Label10, 1, 6)
        Me.TlpMainOpt.Controls.Add(Me.TxtApiKey, 1, 5)
        Me.TlpMainOpt.Controls.Add(Me.Label4, 2, 4)
        Me.TlpMainOpt.Controls.Add(Me.Label16, 4, 9)
        Me.TlpMainOpt.Controls.Add(Me.NumRtInterval, 4, 10)
        Me.TlpMainOpt.Controls.Add(Me.ChkFetchRt, 4, 7)
        Me.TlpMainOpt.Controls.Add(Me.Label1, 2, 1)
        Me.TlpMainOpt.Controls.Add(Me.NumLatiutude, 2, 2)
        Me.TlpMainOpt.Controls.Add(Me.RbUnitUS, 2, 12)
        Me.TlpMainOpt.Controls.Add(Me.ChkFetchHourly, 2, 7)
        Me.TlpMainOpt.Controls.Add(Me.ChkFetchNowcast, 3, 7)
        Me.TlpMainOpt.Controls.Add(Me.Label6, 2, 13)
        Me.TlpMainOpt.Controls.Add(Me.ChkLogHeaders, 3, 14)
        Me.TlpMainOpt.Controls.Add(Me.ChkLogImages, 2, 14)
        Me.TlpMainOpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TlpMainOpt.Location = New System.Drawing.Point(18, 19)
        Me.TlpMainOpt.MaximumSize = New System.Drawing.Size(780, 450)
        Me.TlpMainOpt.MinimumSize = New System.Drawing.Size(780, 450)
        Me.TlpMainOpt.Name = "TlpMainOpt"
        Me.TlpMainOpt.RowCount = 15
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TlpMainOpt.Size = New System.Drawing.Size(780, 450)
        Me.TlpMainOpt.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.TlpMainOpt.SetColumnSpan(Me.Label3, 4)
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Brown
        Me.Label3.Location = New System.Drawing.Point(131, 1)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(518, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Location"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(391, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Longitude"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoEllipsis = True
        Me.Label7.AutoSize = True
        Me.TlpMainOpt.SetColumnSpan(Me.Label7, 4)
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Brown
        Me.Label7.Location = New System.Drawing.Point(131, 91)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(518, 28)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Security"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumLongitude
        '
        Me.NumLongitude.DecimalPlaces = 7
        Me.NumLongitude.Location = New System.Drawing.Point(391, 61)
        Me.NumLongitude.Margin = New System.Windows.Forms.Padding(1)
        Me.NumLongitude.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.NumLongitude.Minimum = New Decimal(New Integer() {180, 0, 0, -2147483648})
        Me.NumLongitude.Name = "NumLongitude"
        Me.NumLongitude.Size = New System.Drawing.Size(125, 23)
        Me.NumLongitude.TabIndex = 4
        Me.NumLongitude.Tag = "1"
        '
        'RbUnitSI
        '
        Me.RbUnitSI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.RbUnitSI.AutoSize = True
        Me.RbUnitSI.Location = New System.Drawing.Point(432, 363)
        Me.RbUnitSI.Name = "RbUnitSI"
        Me.RbUnitSI.Size = New System.Drawing.Size(45, 24)
        Me.RbUnitSI.TabIndex = 1
        Me.RbUnitSI.TabStop = True
        Me.RbUnitSI.Tag = "1"
        Me.RbUnitSI.Text = "SI"
        Me.RbUnitSI.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoEllipsis = True
        Me.Label15.AutoSize = True
        Me.TlpMainOpt.SetColumnSpan(Me.Label15, 4)
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Brown
        Me.Label15.Location = New System.Drawing.Point(131, 331)
        Me.Label15.Margin = New System.Windows.Forms.Padding(1)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(518, 28)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Unit Type"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumDailyInterval
        '
        Me.NumDailyInterval.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.NumDailyInterval.Location = New System.Drawing.Point(151, 301)
        Me.NumDailyInterval.Margin = New System.Windows.Forms.Padding(1)
        Me.NumDailyInterval.Maximum = New Decimal(New Integer() {240, 0, 0, 0})
        Me.NumDailyInterval.Name = "NumDailyInterval"
        Me.NumDailyInterval.Size = New System.Drawing.Size(88, 23)
        Me.NumDailyInterval.TabIndex = 3
        Me.NumDailyInterval.Tag = "0"
        '
        'NumHourlyInterval
        '
        Me.NumHourlyInterval.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.NumHourlyInterval.Location = New System.Drawing.Point(281, 301)
        Me.NumHourlyInterval.Margin = New System.Windows.Forms.Padding(1)
        Me.NumHourlyInterval.Maximum = New Decimal(New Integer() {240, 0, 0, 0})
        Me.NumHourlyInterval.Name = "NumHourlyInterval"
        Me.NumHourlyInterval.Size = New System.Drawing.Size(88, 23)
        Me.NumHourlyInterval.TabIndex = 5
        Me.NumHourlyInterval.Tag = "1"
        '
        'NumNowcastInterval
        '
        Me.NumNowcastInterval.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.NumNowcastInterval.Location = New System.Drawing.Point(411, 301)
        Me.NumNowcastInterval.Margin = New System.Windows.Forms.Padding(1)
        Me.NumNowcastInterval.Maximum = New Decimal(New Integer() {240, 0, 0, 0})
        Me.NumNowcastInterval.Name = "NumNowcastInterval"
        Me.NumNowcastInterval.Size = New System.Drawing.Size(88, 23)
        Me.NumNowcastInterval.TabIndex = 7
        Me.NumNowcastInterval.Tag = "2"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(391, 271)
        Me.Label13.Margin = New System.Windows.Forms.Padding(1)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 28)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Nowcast"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(261, 271)
        Me.Label12.Margin = New System.Windows.Forms.Padding(1)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 28)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Hourly"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(131, 271)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 28)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Daily"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoEllipsis = True
        Me.Label11.AutoSize = True
        Me.TlpMainOpt.SetColumnSpan(Me.Label11, 4)
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Brown
        Me.Label11.Location = New System.Drawing.Point(131, 241)
        Me.Label11.Margin = New System.Windows.Forms.Padding(1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(518, 28)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Update Intervals (minutes)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkFetchDaily
        '
        Me.ChkFetchDaily.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkFetchDaily.Location = New System.Drawing.Point(131, 211)
        Me.ChkFetchDaily.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkFetchDaily.Name = "ChkFetchDaily"
        Me.ChkFetchDaily.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkFetchDaily.Size = New System.Drawing.Size(128, 28)
        Me.ChkFetchDaily.TabIndex = 0
        Me.ChkFetchDaily.Tag = "0"
        Me.ChkFetchDaily.Text = "Daily"
        Me.ChkFetchDaily.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoEllipsis = True
        Me.Label10.AutoSize = True
        Me.TlpMainOpt.SetColumnSpan(Me.Label10, 4)
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Brown
        Me.Label10.Location = New System.Drawing.Point(131, 181)
        Me.Label10.Margin = New System.Windows.Forms.Padding(1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(518, 28)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Fetch Data Type"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtApiKey
        '
        Me.TlpMainOpt.SetColumnSpan(Me.TxtApiKey, 4)
        Me.TxtApiKey.Location = New System.Drawing.Point(131, 151)
        Me.TxtApiKey.Margin = New System.Windows.Forms.Padding(1)
        Me.TxtApiKey.MaxLength = 40
        Me.TxtApiKey.Name = "TxtApiKey"
        Me.TxtApiKey.Size = New System.Drawing.Size(518, 23)
        Me.TxtApiKey.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoEllipsis = True
        Me.Label4.AutoSize = True
        Me.TlpMainOpt.SetColumnSpan(Me.Label4, 2)
        Me.Label4.Location = New System.Drawing.Point(261, 121)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(258, 28)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "API Key"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(521, 271)
        Me.Label16.Margin = New System.Windows.Forms.Padding(1)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 28)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Realtime"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumRtInterval
        '
        Me.NumRtInterval.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.NumRtInterval.Location = New System.Drawing.Point(541, 301)
        Me.NumRtInterval.Margin = New System.Windows.Forms.Padding(1)
        Me.NumRtInterval.Maximum = New Decimal(New Integer() {240, 0, 0, 0})
        Me.NumRtInterval.Name = "NumRtInterval"
        Me.NumRtInterval.Size = New System.Drawing.Size(88, 23)
        Me.NumRtInterval.TabIndex = 10
        Me.NumRtInterval.Tag = "3"
        '
        'ChkFetchRt
        '
        Me.ChkFetchRt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkFetchRt.AutoSize = True
        Me.ChkFetchRt.Location = New System.Drawing.Point(521, 211)
        Me.ChkFetchRt.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkFetchRt.Name = "ChkFetchRt"
        Me.ChkFetchRt.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkFetchRt.Size = New System.Drawing.Size(128, 28)
        Me.ChkFetchRt.TabIndex = 11
        Me.ChkFetchRt.Tag = "3"
        Me.ChkFetchRt.Text = "Realtime"
        Me.ChkFetchRt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(261, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Latitude"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumLatiutude
        '
        Me.NumLatiutude.DecimalPlaces = 7
        Me.NumLatiutude.Location = New System.Drawing.Point(261, 61)
        Me.NumLatiutude.Margin = New System.Windows.Forms.Padding(1)
        Me.NumLatiutude.Maximum = New Decimal(New Integer() {89, 0, 0, 0})
        Me.NumLatiutude.Minimum = New Decimal(New Integer() {87, 0, 0, -2147483648})
        Me.NumLatiutude.Name = "NumLatiutude"
        Me.NumLatiutude.Size = New System.Drawing.Size(123, 23)
        Me.NumLatiutude.TabIndex = 3
        Me.NumLatiutude.Tag = "0"
        '
        'RbUnitUS
        '
        Me.RbUnitUS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.RbUnitUS.AutoSize = True
        Me.RbUnitUS.Location = New System.Drawing.Point(299, 363)
        Me.RbUnitUS.Name = "RbUnitUS"
        Me.RbUnitUS.Size = New System.Drawing.Size(52, 24)
        Me.RbUnitUS.TabIndex = 0
        Me.RbUnitUS.TabStop = True
        Me.RbUnitUS.Tag = "0"
        Me.RbUnitUS.Text = "US"
        Me.RbUnitUS.UseVisualStyleBackColor = True
        '
        'ChkFetchHourly
        '
        Me.ChkFetchHourly.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkFetchHourly.AutoSize = True
        Me.ChkFetchHourly.Location = New System.Drawing.Point(261, 211)
        Me.ChkFetchHourly.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkFetchHourly.Name = "ChkFetchHourly"
        Me.ChkFetchHourly.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkFetchHourly.Size = New System.Drawing.Size(128, 28)
        Me.ChkFetchHourly.TabIndex = 1
        Me.ChkFetchHourly.Tag = "1"
        Me.ChkFetchHourly.Text = "Hourly"
        Me.ChkFetchHourly.UseVisualStyleBackColor = True
        '
        'ChkFetchNowcast
        '
        Me.ChkFetchNowcast.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkFetchNowcast.AutoSize = True
        Me.ChkFetchNowcast.Location = New System.Drawing.Point(391, 211)
        Me.ChkFetchNowcast.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkFetchNowcast.Name = "ChkFetchNowcast"
        Me.ChkFetchNowcast.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkFetchNowcast.Size = New System.Drawing.Size(128, 28)
        Me.ChkFetchNowcast.TabIndex = 2
        Me.ChkFetchNowcast.Tag = "2"
        Me.ChkFetchNowcast.Text = "Nowcast"
        Me.ChkFetchNowcast.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.TlpMainOpt.SetColumnSpan(Me.Label6, 2)
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Brown
        Me.Label6.Location = New System.Drawing.Point(261, 391)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(258, 28)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Booleans"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkLogHeaders
        '
        Me.ChkLogHeaders.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkLogHeaders.AutoSize = True
        Me.TlpMainOpt.SetColumnSpan(Me.ChkLogHeaders, 2)
        Me.ChkLogHeaders.Location = New System.Drawing.Point(391, 421)
        Me.ChkLogHeaders.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkLogHeaders.Name = "ChkLogHeaders"
        Me.ChkLogHeaders.Size = New System.Drawing.Size(258, 28)
        Me.ChkLogHeaders.TabIndex = 14
        Me.ChkLogHeaders.Tag = "5"
        Me.ChkLogHeaders.Text = "Log Headers"
        Me.ChkLogHeaders.UseVisualStyleBackColor = True
        '
        'ChkLogImages
        '
        Me.ChkLogImages.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkLogImages.AutoSize = True
        Me.ChkLogImages.Location = New System.Drawing.Point(261, 421)
        Me.ChkLogImages.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkLogImages.Name = "ChkLogImages"
        Me.ChkLogImages.Size = New System.Drawing.Size(128, 28)
        Me.ChkLogImages.TabIndex = 13
        Me.ChkLogImages.Tag = "4"
        Me.ChkLogImages.Text = "Log Images"
        Me.ChkLogImages.UseVisualStyleBackColor = True
        '
        'TpOptDaily
        '
        Me.TpOptDaily.BackColor = System.Drawing.Color.Linen
        Me.TpOptDaily.BackgroundImage = Global.psClimaCell.My.Resources.Resources.data_layers_6
        Me.TpOptDaily.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TpOptDaily.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TpOptDaily.Controls.Add(Me.PnlDailyForecast)
        Me.TpOptDaily.Location = New System.Drawing.Point(4, 29)
        Me.TpOptDaily.Name = "TpOptDaily"
        Me.TpOptDaily.Padding = New System.Windows.Forms.Padding(3)
        Me.TpOptDaily.Size = New System.Drawing.Size(1384, 973)
        Me.TpOptDaily.TabIndex = 0
        Me.TpOptDaily.Text = "Daily"
        '
        'PnlDailyForecast
        '
        Me.PnlDailyForecast.BackColor = System.Drawing.Color.Silver
        Me.PnlDailyForecast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlDailyForecast.Controls.Add(Me.FlpDaily)
        Me.PnlDailyForecast.Controls.Add(Me.ChkUncheckAllDaily)
        Me.PnlDailyForecast.Controls.Add(Me.ChkAllDaily)
        Me.PnlDailyForecast.Location = New System.Drawing.Point(194, 391)
        Me.PnlDailyForecast.Name = "PnlDailyForecast"
        Me.PnlDailyForecast.Size = New System.Drawing.Size(993, 187)
        Me.PnlDailyForecast.TabIndex = 21
        '
        'FlpDaily
        '
        Me.FlpDaily.BackColor = System.Drawing.Color.Silver
        Me.FlpDaily.Controls.Add(Me.ChkTemp)
        Me.FlpDaily.Controls.Add(Me.ChkFeelsLike)
        Me.FlpDaily.Controls.Add(Me.ChkDewpoint)
        Me.FlpDaily.Controls.Add(Me.ChkHumidity)
        Me.FlpDaily.Controls.Add(Me.ChkWindSpeed)
        Me.FlpDaily.Controls.Add(Me.ChkWindDir)
        Me.FlpDaily.Controls.Add(Me.ChkBP)
        Me.FlpDaily.Controls.Add(Me.ChkVis)
        Me.FlpDaily.Controls.Add(Me.ChkPrecip)
        Me.FlpDaily.Controls.Add(Me.ChkPrecipAcc)
        Me.FlpDaily.Controls.Add(Me.ChkPrecipProb)
        Me.FlpDaily.Controls.Add(Me.ChkWxCode)
        Me.FlpDaily.Controls.Add(Me.ChkSunrise)
        Me.FlpDaily.Controls.Add(Me.ChkSunset)
        Me.FlpDaily.Controls.Add(Me.ChkMoonPhase)
        Me.FlpDaily.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlpDaily.Location = New System.Drawing.Point(29, 11)
        Me.FlpDaily.Name = "FlpDaily"
        Me.FlpDaily.Padding = New System.Windows.Forms.Padding(5)
        Me.FlpDaily.Size = New System.Drawing.Size(931, 118)
        Me.FlpDaily.TabIndex = 22
        '
        'ChkTemp
        '
        Me.ChkTemp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkTemp.Location = New System.Drawing.Point(6, 6)
        Me.ChkTemp.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkTemp.Name = "ChkTemp"
        Me.ChkTemp.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkTemp.Size = New System.Drawing.Size(225, 24)
        Me.ChkTemp.TabIndex = 0
        Me.ChkTemp.Tag = "0"
        Me.ChkTemp.Text = "Temperature"
        Me.ChkTemp.UseVisualStyleBackColor = False
        '
        'ChkFeelsLike
        '
        Me.ChkFeelsLike.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkFeelsLike.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkFeelsLike.Location = New System.Drawing.Point(233, 6)
        Me.ChkFeelsLike.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkFeelsLike.Name = "ChkFeelsLike"
        Me.ChkFeelsLike.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkFeelsLike.Size = New System.Drawing.Size(225, 24)
        Me.ChkFeelsLike.TabIndex = 1
        Me.ChkFeelsLike.Tag = "1"
        Me.ChkFeelsLike.Text = "Feels Like"
        Me.ChkFeelsLike.UseVisualStyleBackColor = False
        '
        'ChkDewpoint
        '
        Me.ChkDewpoint.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkDewpoint.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkDewpoint.Location = New System.Drawing.Point(460, 6)
        Me.ChkDewpoint.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkDewpoint.Name = "ChkDewpoint"
        Me.ChkDewpoint.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkDewpoint.Size = New System.Drawing.Size(225, 24)
        Me.ChkDewpoint.TabIndex = 2
        Me.ChkDewpoint.Tag = "2"
        Me.ChkDewpoint.Text = "Dewpoint"
        Me.ChkDewpoint.UseVisualStyleBackColor = False
        '
        'ChkHumidity
        '
        Me.ChkHumidity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkHumidity.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHumidity.Location = New System.Drawing.Point(687, 6)
        Me.ChkHumidity.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHumidity.Name = "ChkHumidity"
        Me.ChkHumidity.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHumidity.Size = New System.Drawing.Size(225, 24)
        Me.ChkHumidity.TabIndex = 3
        Me.ChkHumidity.Tag = "3"
        Me.ChkHumidity.Text = "Humidity"
        Me.ChkHumidity.UseVisualStyleBackColor = False
        '
        'ChkWindSpeed
        '
        Me.ChkWindSpeed.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkWindSpeed.Location = New System.Drawing.Point(6, 32)
        Me.ChkWindSpeed.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkWindSpeed.Name = "ChkWindSpeed"
        Me.ChkWindSpeed.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkWindSpeed.Size = New System.Drawing.Size(225, 24)
        Me.ChkWindSpeed.TabIndex = 4
        Me.ChkWindSpeed.Tag = "4"
        Me.ChkWindSpeed.Text = "Wind Speed"
        Me.ChkWindSpeed.UseVisualStyleBackColor = False
        '
        'ChkWindDir
        '
        Me.ChkWindDir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkWindDir.Location = New System.Drawing.Point(233, 32)
        Me.ChkWindDir.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkWindDir.Name = "ChkWindDir"
        Me.ChkWindDir.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkWindDir.Size = New System.Drawing.Size(225, 24)
        Me.ChkWindDir.TabIndex = 5
        Me.ChkWindDir.Tag = "5"
        Me.ChkWindDir.Text = "Wind Direction"
        Me.ChkWindDir.UseVisualStyleBackColor = False
        '
        'ChkBP
        '
        Me.ChkBP.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkBP.Location = New System.Drawing.Point(460, 32)
        Me.ChkBP.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkBP.Name = "ChkBP"
        Me.ChkBP.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkBP.Size = New System.Drawing.Size(225, 24)
        Me.ChkBP.TabIndex = 6
        Me.ChkBP.Tag = "6"
        Me.ChkBP.Text = "Barometric Pressure"
        Me.ChkBP.UseVisualStyleBackColor = False
        '
        'ChkVis
        '
        Me.ChkVis.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkVis.Location = New System.Drawing.Point(687, 32)
        Me.ChkVis.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkVis.Name = "ChkVis"
        Me.ChkVis.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkVis.Size = New System.Drawing.Size(225, 24)
        Me.ChkVis.TabIndex = 7
        Me.ChkVis.Tag = "12"
        Me.ChkVis.Text = "Visibility"
        Me.ChkVis.UseVisualStyleBackColor = False
        '
        'ChkPrecip
        '
        Me.ChkPrecip.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkPrecip.Location = New System.Drawing.Point(6, 58)
        Me.ChkPrecip.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkPrecip.Name = "ChkPrecip"
        Me.ChkPrecip.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkPrecip.Size = New System.Drawing.Size(225, 24)
        Me.ChkPrecip.TabIndex = 8
        Me.ChkPrecip.Tag = "7"
        Me.ChkPrecip.Text = "Precipitation"
        Me.ChkPrecip.UseVisualStyleBackColor = False
        '
        'ChkPrecipAcc
        '
        Me.ChkPrecipAcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkPrecipAcc.Location = New System.Drawing.Point(233, 58)
        Me.ChkPrecipAcc.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkPrecipAcc.Name = "ChkPrecipAcc"
        Me.ChkPrecipAcc.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkPrecipAcc.Size = New System.Drawing.Size(225, 24)
        Me.ChkPrecipAcc.TabIndex = 9
        Me.ChkPrecipAcc.Tag = "9"
        Me.ChkPrecipAcc.Text = "Precipitation Accumulation"
        Me.ChkPrecipAcc.UseVisualStyleBackColor = False
        '
        'ChkPrecipProb
        '
        Me.ChkPrecipProb.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkPrecipProb.Location = New System.Drawing.Point(460, 58)
        Me.ChkPrecipProb.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkPrecipProb.Name = "ChkPrecipProb"
        Me.ChkPrecipProb.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkPrecipProb.Size = New System.Drawing.Size(225, 24)
        Me.ChkPrecipProb.TabIndex = 10
        Me.ChkPrecipProb.Tag = "8"
        Me.ChkPrecipProb.Text = "Precipitation Probability"
        Me.ChkPrecipProb.UseVisualStyleBackColor = False
        '
        'ChkWxCode
        '
        Me.ChkWxCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkWxCode.Location = New System.Drawing.Point(687, 58)
        Me.ChkWxCode.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkWxCode.Name = "ChkWxCode"
        Me.ChkWxCode.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkWxCode.Size = New System.Drawing.Size(225, 24)
        Me.ChkWxCode.TabIndex = 11
        Me.ChkWxCode.Tag = "13"
        Me.ChkWxCode.Text = "Weather Code"
        Me.ChkWxCode.UseVisualStyleBackColor = False
        '
        'ChkSunrise
        '
        Me.ChkSunrise.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkSunrise.Location = New System.Drawing.Point(6, 84)
        Me.ChkSunrise.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkSunrise.Name = "ChkSunrise"
        Me.ChkSunrise.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkSunrise.Size = New System.Drawing.Size(225, 24)
        Me.ChkSunrise.TabIndex = 12
        Me.ChkSunrise.Tag = "10"
        Me.ChkSunrise.Text = "Sunrise"
        Me.ChkSunrise.UseVisualStyleBackColor = False
        '
        'ChkSunset
        '
        Me.ChkSunset.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkSunset.Location = New System.Drawing.Point(233, 84)
        Me.ChkSunset.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkSunset.Name = "ChkSunset"
        Me.ChkSunset.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkSunset.Size = New System.Drawing.Size(225, 24)
        Me.ChkSunset.TabIndex = 13
        Me.ChkSunset.Tag = "11"
        Me.ChkSunset.Text = "Sunset"
        Me.ChkSunset.UseVisualStyleBackColor = False
        '
        'ChkMoonPhase
        '
        Me.ChkMoonPhase.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkMoonPhase.Location = New System.Drawing.Point(460, 84)
        Me.ChkMoonPhase.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkMoonPhase.Name = "ChkMoonPhase"
        Me.ChkMoonPhase.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkMoonPhase.Size = New System.Drawing.Size(225, 24)
        Me.ChkMoonPhase.TabIndex = 14
        Me.ChkMoonPhase.Tag = "14"
        Me.ChkMoonPhase.Text = "Moon Phase"
        Me.ChkMoonPhase.UseVisualStyleBackColor = False
        '
        'ChkUncheckAllDaily
        '
        Me.ChkUncheckAllDaily.AutoSize = True
        Me.ChkUncheckAllDaily.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkUncheckAllDaily.Location = New System.Drawing.Point(536, 145)
        Me.ChkUncheckAllDaily.Name = "ChkUncheckAllDaily"
        Me.ChkUncheckAllDaily.Size = New System.Drawing.Size(130, 24)
        Me.ChkUncheckAllDaily.TabIndex = 1
        Me.ChkUncheckAllDaily.Text = "Uncheck All"
        Me.ChkUncheckAllDaily.UseVisualStyleBackColor = True
        '
        'ChkAllDaily
        '
        Me.ChkAllDaily.AutoSize = True
        Me.ChkAllDaily.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAllDaily.Location = New System.Drawing.Point(323, 145)
        Me.ChkAllDaily.Name = "ChkAllDaily"
        Me.ChkAllDaily.Size = New System.Drawing.Size(110, 24)
        Me.ChkAllDaily.TabIndex = 0
        Me.ChkAllDaily.Text = "Check All"
        Me.ChkAllDaily.UseVisualStyleBackColor = True
        '
        'TpOptHourly
        '
        Me.TpOptHourly.BackColor = System.Drawing.Color.Linen
        Me.TpOptHourly.BackgroundImage = Global.psClimaCell.My.Resources.Resources.data_layers_6
        Me.TpOptHourly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TpOptHourly.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TpOptHourly.Controls.Add(Me.PnlHourlyForecast)
        Me.TpOptHourly.Location = New System.Drawing.Point(4, 29)
        Me.TpOptHourly.Name = "TpOptHourly"
        Me.TpOptHourly.Padding = New System.Windows.Forms.Padding(3)
        Me.TpOptHourly.Size = New System.Drawing.Size(1384, 973)
        Me.TpOptHourly.TabIndex = 1
        Me.TpOptHourly.Text = "Hourly"
        '
        'PnlHourlyForecast
        '
        Me.PnlHourlyForecast.BackColor = System.Drawing.Color.Silver
        Me.PnlHourlyForecast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PnlHourlyForecast.Controls.Add(Me.FlpHourly)
        Me.PnlHourlyForecast.Controls.Add(Me.ChkUncheckAllHr)
        Me.PnlHourlyForecast.Controls.Add(Me.ChkAllHourly)
        Me.PnlHourlyForecast.Location = New System.Drawing.Point(94, 270)
        Me.PnlHourlyForecast.Name = "PnlHourlyForecast"
        Me.PnlHourlyForecast.Size = New System.Drawing.Size(1193, 428)
        Me.PnlHourlyForecast.TabIndex = 22
        '
        'FlpHourly
        '
        Me.FlpHourly.Controls.Add(Me.ChkHrTemp)
        Me.FlpHourly.Controls.Add(Me.ChkHrFeelsLike)
        Me.FlpHourly.Controls.Add(Me.ChkHrRH)
        Me.FlpHourly.Controls.Add(Me.ChkHrDewpoint)
        Me.FlpHourly.Controls.Add(Me.ChkHrWindDir)
        Me.FlpHourly.Controls.Add(Me.ChkHrWindGust)
        Me.FlpHourly.Controls.Add(Me.ChkHrWindSpeed)
        Me.FlpHourly.Controls.Add(Me.ChkHrPrecip)
        Me.FlpHourly.Controls.Add(Me.ChkHrPrecipType)
        Me.FlpHourly.Controls.Add(Me.ChkHrPrecipProb)
        Me.FlpHourly.Controls.Add(Me.ChkHrCloudCover)
        Me.FlpHourly.Controls.Add(Me.ChkHrCloudCeil)
        Me.FlpHourly.Controls.Add(Me.ChkHrCloudBase)
        Me.FlpHourly.Controls.Add(Me.ChkHrWxCode)
        Me.FlpHourly.Controls.Add(Me.ChkHrSunrise)
        Me.FlpHourly.Controls.Add(Me.ChkHrSunset)
        Me.FlpHourly.Controls.Add(Me.ChkHrMoonPhase)
        Me.FlpHourly.Controls.Add(Me.ChkHrBP)
        Me.FlpHourly.Controls.Add(Me.ChkHrVis)
        Me.FlpHourly.Controls.Add(Me.ChkHrSSR)
        Me.FlpHourly.Controls.Add(Me.ChkHrHailRisk)
        Me.FlpHourly.Controls.Add(Me.ChkHrTreePollen)
        Me.FlpHourly.Controls.Add(Me.ChkHrWeedPollen)
        Me.FlpHourly.Controls.Add(Me.ChkHrGrassPollen)
        Me.FlpHourly.Controls.Add(Me.ChkHrTreeAcacia)
        Me.FlpHourly.Controls.Add(Me.ChkHrTreeAsh)
        Me.FlpHourly.Controls.Add(Me.ChkHrTreeBeech)
        Me.FlpHourly.Controls.Add(Me.ChkHrTreeBirch)
        Me.FlpHourly.Controls.Add(Me.ChkHrTreeCedar)
        Me.FlpHourly.Controls.Add(Me.ChkHrTreeCottonwood)
        Me.FlpHourly.Controls.Add(Me.ChkHrTreeCypress)
        Me.FlpHourly.Controls.Add(Me.ChkHrTreeElder)
        Me.FlpHourly.Controls.Add(Me.ChkHrTreeElm)
        Me.FlpHourly.Controls.Add(Me.ChkHrTreeHemlock)
        Me.FlpHourly.Controls.Add(Me.ChkHrTreeHickory)
        Me.FlpHourly.Controls.Add(Me.ChkHrTreeJuniper)
        Me.FlpHourly.Controls.Add(Me.ChkHrTreeMahogany)
        Me.FlpHourly.Controls.Add(Me.ChkHrTreeMaple)
        Me.FlpHourly.Controls.Add(Me.ChkHrTreeMulberry)
        Me.FlpHourly.Controls.Add(Me.ChkHrTreeOak)
        Me.FlpHourly.Controls.Add(Me.ChkHrTreePine)
        Me.FlpHourly.Controls.Add(Me.ChkHrTreeSpruce)
        Me.FlpHourly.Controls.Add(Me.ChkHrTreeSycamore)
        Me.FlpHourly.Controls.Add(Me.ChkHrTreeWalnut)
        Me.FlpHourly.Controls.Add(Me.ChkHrTreeWillow)
        Me.FlpHourly.Controls.Add(Me.ChkHrRagweed)
        Me.FlpHourly.Controls.Add(Me.ChkHrGrass)
        Me.FlpHourly.Controls.Add(Me.ChkHrAqiPm10)
        Me.FlpHourly.Controls.Add(Me.ChkHrAqiPm25)
        Me.FlpHourly.Controls.Add(Me.ChkHrAqiO3)
        Me.FlpHourly.Controls.Add(Me.ChkHrAqiCo)
        Me.FlpHourly.Controls.Add(Me.ChkHrAqiSo2)
        Me.FlpHourly.Controls.Add(Me.ChkHrAqiNo2)
        Me.FlpHourly.Controls.Add(Me.ChkHrEpaAqi)
        Me.FlpHourly.Controls.Add(Me.ChkHrEpaConcern)
        Me.FlpHourly.Controls.Add(Me.ChkHrEpaPollutant)
        Me.FlpHourly.Controls.Add(Me.ChkHrChinaAqi)
        Me.FlpHourly.Controls.Add(Me.ChkHrChinaConcern)
        Me.FlpHourly.Controls.Add(Me.ChkHrChinaPollutant)
        Me.FlpHourly.Controls.Add(Me.ChkHrRoadRisk)
        Me.FlpHourly.Controls.Add(Me.ChkHrRiskScore)
        Me.FlpHourly.Controls.Add(Me.ChkHrRiskConfidence)
        Me.FlpHourly.Controls.Add(Me.ChkHrRiskCondition)
        Me.FlpHourly.Location = New System.Drawing.Point(13, 15)
        Me.FlpHourly.Name = "FlpHourly"
        Me.FlpHourly.Size = New System.Drawing.Size(1163, 364)
        Me.FlpHourly.TabIndex = 23
        '
        'ChkHrTemp
        '
        Me.ChkHrTemp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrTemp.Location = New System.Drawing.Point(1, 1)
        Me.ChkHrTemp.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrTemp.Name = "ChkHrTemp"
        Me.ChkHrTemp.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrTemp.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrTemp.TabIndex = 0
        Me.ChkHrTemp.Tag = "0"
        Me.ChkHrTemp.Text = "Temperature"
        Me.ChkHrTemp.UseVisualStyleBackColor = False
        '
        'ChkHrFeelsLike
        '
        Me.ChkHrFeelsLike.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrFeelsLike.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrFeelsLike.Location = New System.Drawing.Point(229, 1)
        Me.ChkHrFeelsLike.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrFeelsLike.Name = "ChkHrFeelsLike"
        Me.ChkHrFeelsLike.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrFeelsLike.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrFeelsLike.TabIndex = 1
        Me.ChkHrFeelsLike.Tag = "1"
        Me.ChkHrFeelsLike.Text = "Feels Like"
        Me.ChkHrFeelsLike.UseVisualStyleBackColor = False
        '
        'ChkHrRH
        '
        Me.ChkHrRH.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrRH.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrRH.Location = New System.Drawing.Point(457, 1)
        Me.ChkHrRH.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrRH.Name = "ChkHrRH"
        Me.ChkHrRH.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrRH.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrRH.TabIndex = 2
        Me.ChkHrRH.Tag = "3"
        Me.ChkHrRH.Text = "Humidity"
        Me.ChkHrRH.UseVisualStyleBackColor = False
        '
        'ChkHrDewpoint
        '
        Me.ChkHrDewpoint.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrDewpoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrDewpoint.Location = New System.Drawing.Point(685, 1)
        Me.ChkHrDewpoint.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrDewpoint.Name = "ChkHrDewpoint"
        Me.ChkHrDewpoint.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrDewpoint.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrDewpoint.TabIndex = 3
        Me.ChkHrDewpoint.Tag = "2"
        Me.ChkHrDewpoint.Text = "Dewpoint"
        Me.ChkHrDewpoint.UseVisualStyleBackColor = False
        '
        'ChkHrWindDir
        '
        Me.ChkHrWindDir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrWindDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrWindDir.Location = New System.Drawing.Point(913, 1)
        Me.ChkHrWindDir.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrWindDir.Name = "ChkHrWindDir"
        Me.ChkHrWindDir.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrWindDir.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrWindDir.TabIndex = 4
        Me.ChkHrWindDir.Tag = "5"
        Me.ChkHrWindDir.Text = "Wind Direction"
        Me.ChkHrWindDir.UseVisualStyleBackColor = False
        '
        'ChkHrWindGust
        '
        Me.ChkHrWindGust.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrWindGust.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrWindGust.Location = New System.Drawing.Point(1, 28)
        Me.ChkHrWindGust.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrWindGust.Name = "ChkHrWindGust"
        Me.ChkHrWindGust.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrWindGust.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrWindGust.TabIndex = 5
        Me.ChkHrWindGust.Tag = "6"
        Me.ChkHrWindGust.Text = "Wind Gust"
        Me.ChkHrWindGust.UseVisualStyleBackColor = False
        '
        'ChkHrWindSpeed
        '
        Me.ChkHrWindSpeed.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrWindSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrWindSpeed.Location = New System.Drawing.Point(229, 28)
        Me.ChkHrWindSpeed.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrWindSpeed.Name = "ChkHrWindSpeed"
        Me.ChkHrWindSpeed.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrWindSpeed.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrWindSpeed.TabIndex = 6
        Me.ChkHrWindSpeed.Tag = "4"
        Me.ChkHrWindSpeed.Text = "Wind Speed"
        Me.ChkHrWindSpeed.UseVisualStyleBackColor = False
        '
        'ChkHrPrecip
        '
        Me.ChkHrPrecip.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrPrecip.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrPrecip.Location = New System.Drawing.Point(457, 28)
        Me.ChkHrPrecip.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrPrecip.Name = "ChkHrPrecip"
        Me.ChkHrPrecip.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrPrecip.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrPrecip.TabIndex = 7
        Me.ChkHrPrecip.Tag = "8"
        Me.ChkHrPrecip.Text = "Precipitation"
        Me.ChkHrPrecip.UseVisualStyleBackColor = False
        '
        'ChkHrPrecipType
        '
        Me.ChkHrPrecipType.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrPrecipType.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrPrecipType.Location = New System.Drawing.Point(685, 28)
        Me.ChkHrPrecipType.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrPrecipType.Name = "ChkHrPrecipType"
        Me.ChkHrPrecipType.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrPrecipType.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrPrecipType.TabIndex = 8
        Me.ChkHrPrecipType.Tag = "9"
        Me.ChkHrPrecipType.Text = "Precipitation Type"
        Me.ChkHrPrecipType.UseVisualStyleBackColor = False
        '
        'ChkHrPrecipProb
        '
        Me.ChkHrPrecipProb.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrPrecipProb.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrPrecipProb.Location = New System.Drawing.Point(913, 28)
        Me.ChkHrPrecipProb.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrPrecipProb.Name = "ChkHrPrecipProb"
        Me.ChkHrPrecipProb.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrPrecipProb.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrPrecipProb.TabIndex = 9
        Me.ChkHrPrecipProb.Tag = "10"
        Me.ChkHrPrecipProb.Text = "Precipitation Probability"
        Me.ChkHrPrecipProb.UseVisualStyleBackColor = False
        '
        'ChkHrCloudCover
        '
        Me.ChkHrCloudCover.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrCloudCover.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrCloudCover.Location = New System.Drawing.Point(1, 55)
        Me.ChkHrCloudCover.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrCloudCover.Name = "ChkHrCloudCover"
        Me.ChkHrCloudCover.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrCloudCover.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrCloudCover.TabIndex = 10
        Me.ChkHrCloudCover.Tag = "14"
        Me.ChkHrCloudCover.Text = "Cloud Cover"
        Me.ChkHrCloudCover.UseVisualStyleBackColor = False
        '
        'ChkHrCloudCeil
        '
        Me.ChkHrCloudCeil.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrCloudCeil.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrCloudCeil.Location = New System.Drawing.Point(229, 55)
        Me.ChkHrCloudCeil.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrCloudCeil.Name = "ChkHrCloudCeil"
        Me.ChkHrCloudCeil.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrCloudCeil.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrCloudCeil.TabIndex = 11
        Me.ChkHrCloudCeil.Tag = "16"
        Me.ChkHrCloudCeil.Text = "Cloud Ceiling"
        Me.ChkHrCloudCeil.UseVisualStyleBackColor = False
        '
        'ChkHrCloudBase
        '
        Me.ChkHrCloudBase.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrCloudBase.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrCloudBase.Location = New System.Drawing.Point(457, 55)
        Me.ChkHrCloudBase.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrCloudBase.Name = "ChkHrCloudBase"
        Me.ChkHrCloudBase.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrCloudBase.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrCloudBase.TabIndex = 12
        Me.ChkHrCloudBase.Tag = "15"
        Me.ChkHrCloudBase.Text = "Cloud Base"
        Me.ChkHrCloudBase.UseVisualStyleBackColor = False
        '
        'ChkHrWxCode
        '
        Me.ChkHrWxCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrWxCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrWxCode.Location = New System.Drawing.Point(685, 55)
        Me.ChkHrWxCode.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrWxCode.Name = "ChkHrWxCode"
        Me.ChkHrWxCode.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrWxCode.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrWxCode.TabIndex = 13
        Me.ChkHrWxCode.Tag = "19"
        Me.ChkHrWxCode.Text = "Weather Code"
        Me.ChkHrWxCode.UseVisualStyleBackColor = False
        '
        'ChkHrSunrise
        '
        Me.ChkHrSunrise.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrSunrise.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrSunrise.Location = New System.Drawing.Point(913, 55)
        Me.ChkHrSunrise.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrSunrise.Name = "ChkHrSunrise"
        Me.ChkHrSunrise.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrSunrise.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrSunrise.TabIndex = 14
        Me.ChkHrSunrise.Tag = "11"
        Me.ChkHrSunrise.Text = "Sunrise"
        Me.ChkHrSunrise.UseVisualStyleBackColor = False
        '
        'ChkHrSunset
        '
        Me.ChkHrSunset.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrSunset.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrSunset.Location = New System.Drawing.Point(1, 82)
        Me.ChkHrSunset.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrSunset.Name = "ChkHrSunset"
        Me.ChkHrSunset.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrSunset.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrSunset.TabIndex = 15
        Me.ChkHrSunset.Tag = "12"
        Me.ChkHrSunset.Text = "Sunset"
        Me.ChkHrSunset.UseVisualStyleBackColor = False
        '
        'ChkHrMoonPhase
        '
        Me.ChkHrMoonPhase.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrMoonPhase.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrMoonPhase.Location = New System.Drawing.Point(229, 82)
        Me.ChkHrMoonPhase.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrMoonPhase.Name = "ChkHrMoonPhase"
        Me.ChkHrMoonPhase.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrMoonPhase.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrMoonPhase.TabIndex = 16
        Me.ChkHrMoonPhase.Tag = "18"
        Me.ChkHrMoonPhase.Text = "Moon Phase"
        Me.ChkHrMoonPhase.UseVisualStyleBackColor = False
        '
        'ChkHrBP
        '
        Me.ChkHrBP.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrBP.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrBP.Location = New System.Drawing.Point(457, 82)
        Me.ChkHrBP.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrBP.Name = "ChkHrBP"
        Me.ChkHrBP.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrBP.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrBP.TabIndex = 17
        Me.ChkHrBP.Tag = "7"
        Me.ChkHrBP.Text = "Barometric Pressure"
        Me.ChkHrBP.UseVisualStyleBackColor = False
        '
        'ChkHrVis
        '
        Me.ChkHrVis.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrVis.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrVis.Location = New System.Drawing.Point(685, 82)
        Me.ChkHrVis.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrVis.Name = "ChkHrVis"
        Me.ChkHrVis.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrVis.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrVis.TabIndex = 18
        Me.ChkHrVis.Tag = "13"
        Me.ChkHrVis.Text = "Visibility"
        Me.ChkHrVis.UseVisualStyleBackColor = False
        '
        'ChkHrSSR
        '
        Me.ChkHrSSR.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrSSR.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrSSR.Location = New System.Drawing.Point(913, 82)
        Me.ChkHrSSR.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrSSR.Name = "ChkHrSSR"
        Me.ChkHrSSR.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrSSR.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrSSR.TabIndex = 19
        Me.ChkHrSSR.Tag = "17"
        Me.ChkHrSSR.Text = "Surface Shortwave Radiation"
        Me.ChkHrSSR.UseVisualStyleBackColor = False
        '
        'ChkHrHailRisk
        '
        Me.ChkHrHailRisk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrHailRisk.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrHailRisk.Location = New System.Drawing.Point(1, 109)
        Me.ChkHrHailRisk.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrHailRisk.Name = "ChkHrHailRisk"
        Me.ChkHrHailRisk.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrHailRisk.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrHailRisk.TabIndex = 20
        Me.ChkHrHailRisk.Tag = "62"
        Me.ChkHrHailRisk.Text = "Hail Risk"
        Me.ChkHrHailRisk.UseVisualStyleBackColor = False
        '
        'ChkHrTreePollen
        '
        Me.ChkHrTreePollen.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrTreePollen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrTreePollen.Location = New System.Drawing.Point(229, 109)
        Me.ChkHrTreePollen.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrTreePollen.Name = "ChkHrTreePollen"
        Me.ChkHrTreePollen.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrTreePollen.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrTreePollen.TabIndex = 21
        Me.ChkHrTreePollen.Tag = "20"
        Me.ChkHrTreePollen.Text = "Tree Pollen"
        Me.ChkHrTreePollen.UseVisualStyleBackColor = False
        '
        'ChkHrWeedPollen
        '
        Me.ChkHrWeedPollen.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrWeedPollen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrWeedPollen.Location = New System.Drawing.Point(457, 109)
        Me.ChkHrWeedPollen.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrWeedPollen.Name = "ChkHrWeedPollen"
        Me.ChkHrWeedPollen.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrWeedPollen.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrWeedPollen.TabIndex = 22
        Me.ChkHrWeedPollen.Tag = "21"
        Me.ChkHrWeedPollen.Text = "Weed Pollen"
        Me.ChkHrWeedPollen.UseVisualStyleBackColor = False
        '
        'ChkHrGrassPollen
        '
        Me.ChkHrGrassPollen.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrGrassPollen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrGrassPollen.Location = New System.Drawing.Point(685, 109)
        Me.ChkHrGrassPollen.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrGrassPollen.Name = "ChkHrGrassPollen"
        Me.ChkHrGrassPollen.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrGrassPollen.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrGrassPollen.TabIndex = 23
        Me.ChkHrGrassPollen.Tag = "22"
        Me.ChkHrGrassPollen.Text = "Grass Pollen"
        Me.ChkHrGrassPollen.UseVisualStyleBackColor = False
        '
        'ChkHrTreeAcacia
        '
        Me.ChkHrTreeAcacia.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrTreeAcacia.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrTreeAcacia.Location = New System.Drawing.Point(913, 109)
        Me.ChkHrTreeAcacia.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrTreeAcacia.Name = "ChkHrTreeAcacia"
        Me.ChkHrTreeAcacia.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrTreeAcacia.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrTreeAcacia.TabIndex = 24
        Me.ChkHrTreeAcacia.Tag = "23"
        Me.ChkHrTreeAcacia.Text = "Acacia"
        Me.ChkHrTreeAcacia.UseVisualStyleBackColor = False
        '
        'ChkHrTreeAsh
        '
        Me.ChkHrTreeAsh.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrTreeAsh.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrTreeAsh.Location = New System.Drawing.Point(1, 136)
        Me.ChkHrTreeAsh.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrTreeAsh.Name = "ChkHrTreeAsh"
        Me.ChkHrTreeAsh.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrTreeAsh.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrTreeAsh.TabIndex = 25
        Me.ChkHrTreeAsh.Tag = "24"
        Me.ChkHrTreeAsh.Text = "Ash "
        Me.ChkHrTreeAsh.UseVisualStyleBackColor = False
        '
        'ChkHrTreeBeech
        '
        Me.ChkHrTreeBeech.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrTreeBeech.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrTreeBeech.Location = New System.Drawing.Point(229, 136)
        Me.ChkHrTreeBeech.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrTreeBeech.Name = "ChkHrTreeBeech"
        Me.ChkHrTreeBeech.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrTreeBeech.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrTreeBeech.TabIndex = 26
        Me.ChkHrTreeBeech.Tag = "25"
        Me.ChkHrTreeBeech.Text = "Beech"
        Me.ChkHrTreeBeech.UseVisualStyleBackColor = False
        '
        'ChkHrTreeBirch
        '
        Me.ChkHrTreeBirch.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrTreeBirch.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrTreeBirch.Location = New System.Drawing.Point(457, 136)
        Me.ChkHrTreeBirch.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrTreeBirch.Name = "ChkHrTreeBirch"
        Me.ChkHrTreeBirch.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrTreeBirch.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrTreeBirch.TabIndex = 27
        Me.ChkHrTreeBirch.Tag = "26"
        Me.ChkHrTreeBirch.Text = "Birch"
        Me.ChkHrTreeBirch.UseVisualStyleBackColor = False
        '
        'ChkHrTreeCedar
        '
        Me.ChkHrTreeCedar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrTreeCedar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrTreeCedar.Location = New System.Drawing.Point(685, 136)
        Me.ChkHrTreeCedar.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrTreeCedar.Name = "ChkHrTreeCedar"
        Me.ChkHrTreeCedar.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrTreeCedar.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrTreeCedar.TabIndex = 28
        Me.ChkHrTreeCedar.Tag = "27"
        Me.ChkHrTreeCedar.Text = "Cedar"
        Me.ChkHrTreeCedar.UseVisualStyleBackColor = False
        '
        'ChkHrTreeCottonwood
        '
        Me.ChkHrTreeCottonwood.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrTreeCottonwood.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrTreeCottonwood.Location = New System.Drawing.Point(913, 136)
        Me.ChkHrTreeCottonwood.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrTreeCottonwood.Name = "ChkHrTreeCottonwood"
        Me.ChkHrTreeCottonwood.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrTreeCottonwood.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrTreeCottonwood.TabIndex = 29
        Me.ChkHrTreeCottonwood.Tag = "39"
        Me.ChkHrTreeCottonwood.Text = "Cottonwood"
        Me.ChkHrTreeCottonwood.UseVisualStyleBackColor = False
        '
        'ChkHrTreeCypress
        '
        Me.ChkHrTreeCypress.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrTreeCypress.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrTreeCypress.Location = New System.Drawing.Point(1, 163)
        Me.ChkHrTreeCypress.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrTreeCypress.Name = "ChkHrTreeCypress"
        Me.ChkHrTreeCypress.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrTreeCypress.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrTreeCypress.TabIndex = 30
        Me.ChkHrTreeCypress.Tag = "28"
        Me.ChkHrTreeCypress.Text = "Cypress"
        Me.ChkHrTreeCypress.UseVisualStyleBackColor = False
        '
        'ChkHrTreeElder
        '
        Me.ChkHrTreeElder.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrTreeElder.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrTreeElder.Location = New System.Drawing.Point(229, 163)
        Me.ChkHrTreeElder.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrTreeElder.Name = "ChkHrTreeElder"
        Me.ChkHrTreeElder.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrTreeElder.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrTreeElder.TabIndex = 31
        Me.ChkHrTreeElder.Tag = "29"
        Me.ChkHrTreeElder.Text = "Elder"
        Me.ChkHrTreeElder.UseVisualStyleBackColor = False
        '
        'ChkHrTreeElm
        '
        Me.ChkHrTreeElm.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrTreeElm.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrTreeElm.Location = New System.Drawing.Point(457, 163)
        Me.ChkHrTreeElm.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrTreeElm.Name = "ChkHrTreeElm"
        Me.ChkHrTreeElm.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrTreeElm.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrTreeElm.TabIndex = 32
        Me.ChkHrTreeElm.Tag = "30"
        Me.ChkHrTreeElm.Text = "Elm"
        Me.ChkHrTreeElm.UseVisualStyleBackColor = False
        '
        'ChkHrTreeHemlock
        '
        Me.ChkHrTreeHemlock.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrTreeHemlock.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrTreeHemlock.Location = New System.Drawing.Point(685, 163)
        Me.ChkHrTreeHemlock.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrTreeHemlock.Name = "ChkHrTreeHemlock"
        Me.ChkHrTreeHemlock.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrTreeHemlock.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrTreeHemlock.TabIndex = 33
        Me.ChkHrTreeHemlock.Tag = "31"
        Me.ChkHrTreeHemlock.Text = "Hemlock"
        Me.ChkHrTreeHemlock.UseVisualStyleBackColor = False
        '
        'ChkHrTreeHickory
        '
        Me.ChkHrTreeHickory.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrTreeHickory.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrTreeHickory.Location = New System.Drawing.Point(913, 163)
        Me.ChkHrTreeHickory.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrTreeHickory.Name = "ChkHrTreeHickory"
        Me.ChkHrTreeHickory.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrTreeHickory.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrTreeHickory.TabIndex = 34
        Me.ChkHrTreeHickory.Tag = "32"
        Me.ChkHrTreeHickory.Text = "Hickory"
        Me.ChkHrTreeHickory.UseVisualStyleBackColor = False
        '
        'ChkHrTreeJuniper
        '
        Me.ChkHrTreeJuniper.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrTreeJuniper.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrTreeJuniper.Location = New System.Drawing.Point(1, 190)
        Me.ChkHrTreeJuniper.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrTreeJuniper.Name = "ChkHrTreeJuniper"
        Me.ChkHrTreeJuniper.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrTreeJuniper.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrTreeJuniper.TabIndex = 35
        Me.ChkHrTreeJuniper.Tag = "33"
        Me.ChkHrTreeJuniper.Text = "Juniper"
        Me.ChkHrTreeJuniper.UseVisualStyleBackColor = False
        '
        'ChkHrTreeMahogany
        '
        Me.ChkHrTreeMahogany.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrTreeMahogany.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrTreeMahogany.Location = New System.Drawing.Point(229, 190)
        Me.ChkHrTreeMahogany.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrTreeMahogany.Name = "ChkHrTreeMahogany"
        Me.ChkHrTreeMahogany.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrTreeMahogany.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrTreeMahogany.TabIndex = 36
        Me.ChkHrTreeMahogany.Tag = "34"
        Me.ChkHrTreeMahogany.Text = "Mahogany"
        Me.ChkHrTreeMahogany.UseVisualStyleBackColor = False
        '
        'ChkHrTreeMaple
        '
        Me.ChkHrTreeMaple.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrTreeMaple.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrTreeMaple.Location = New System.Drawing.Point(457, 190)
        Me.ChkHrTreeMaple.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrTreeMaple.Name = "ChkHrTreeMaple"
        Me.ChkHrTreeMaple.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrTreeMaple.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrTreeMaple.TabIndex = 37
        Me.ChkHrTreeMaple.Tag = "35"
        Me.ChkHrTreeMaple.Text = "Maple"
        Me.ChkHrTreeMaple.UseVisualStyleBackColor = False
        '
        'ChkHrTreeMulberry
        '
        Me.ChkHrTreeMulberry.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrTreeMulberry.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrTreeMulberry.Location = New System.Drawing.Point(685, 190)
        Me.ChkHrTreeMulberry.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrTreeMulberry.Name = "ChkHrTreeMulberry"
        Me.ChkHrTreeMulberry.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrTreeMulberry.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrTreeMulberry.TabIndex = 38
        Me.ChkHrTreeMulberry.Tag = "36"
        Me.ChkHrTreeMulberry.Text = "Mulberry"
        Me.ChkHrTreeMulberry.UseVisualStyleBackColor = False
        '
        'ChkHrTreeOak
        '
        Me.ChkHrTreeOak.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrTreeOak.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrTreeOak.Location = New System.Drawing.Point(913, 190)
        Me.ChkHrTreeOak.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrTreeOak.Name = "ChkHrTreeOak"
        Me.ChkHrTreeOak.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrTreeOak.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrTreeOak.TabIndex = 39
        Me.ChkHrTreeOak.Tag = "37"
        Me.ChkHrTreeOak.Text = "Oak"
        Me.ChkHrTreeOak.UseVisualStyleBackColor = False
        '
        'ChkHrTreePine
        '
        Me.ChkHrTreePine.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrTreePine.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrTreePine.Location = New System.Drawing.Point(1, 217)
        Me.ChkHrTreePine.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrTreePine.Name = "ChkHrTreePine"
        Me.ChkHrTreePine.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrTreePine.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrTreePine.TabIndex = 40
        Me.ChkHrTreePine.Tag = "38"
        Me.ChkHrTreePine.Text = "Pine"
        Me.ChkHrTreePine.UseVisualStyleBackColor = False
        '
        'ChkHrTreeSpruce
        '
        Me.ChkHrTreeSpruce.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrTreeSpruce.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrTreeSpruce.Location = New System.Drawing.Point(229, 217)
        Me.ChkHrTreeSpruce.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrTreeSpruce.Name = "ChkHrTreeSpruce"
        Me.ChkHrTreeSpruce.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrTreeSpruce.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrTreeSpruce.TabIndex = 41
        Me.ChkHrTreeSpruce.Tag = "40"
        Me.ChkHrTreeSpruce.Text = "Spruce"
        Me.ChkHrTreeSpruce.UseVisualStyleBackColor = False
        '
        'ChkHrTreeSycamore
        '
        Me.ChkHrTreeSycamore.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrTreeSycamore.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrTreeSycamore.Location = New System.Drawing.Point(457, 217)
        Me.ChkHrTreeSycamore.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrTreeSycamore.Name = "ChkHrTreeSycamore"
        Me.ChkHrTreeSycamore.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrTreeSycamore.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrTreeSycamore.TabIndex = 42
        Me.ChkHrTreeSycamore.Tag = "41"
        Me.ChkHrTreeSycamore.Text = "Sycamore"
        Me.ChkHrTreeSycamore.UseVisualStyleBackColor = False
        '
        'ChkHrTreeWalnut
        '
        Me.ChkHrTreeWalnut.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrTreeWalnut.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrTreeWalnut.Location = New System.Drawing.Point(685, 217)
        Me.ChkHrTreeWalnut.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrTreeWalnut.Name = "ChkHrTreeWalnut"
        Me.ChkHrTreeWalnut.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrTreeWalnut.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrTreeWalnut.TabIndex = 43
        Me.ChkHrTreeWalnut.Tag = "42"
        Me.ChkHrTreeWalnut.Text = "Walnut"
        Me.ChkHrTreeWalnut.UseVisualStyleBackColor = False
        '
        'ChkHrTreeWillow
        '
        Me.ChkHrTreeWillow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrTreeWillow.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrTreeWillow.Location = New System.Drawing.Point(913, 217)
        Me.ChkHrTreeWillow.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrTreeWillow.Name = "ChkHrTreeWillow"
        Me.ChkHrTreeWillow.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrTreeWillow.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrTreeWillow.TabIndex = 44
        Me.ChkHrTreeWillow.Tag = "43"
        Me.ChkHrTreeWillow.Text = "Willow"
        Me.ChkHrTreeWillow.UseVisualStyleBackColor = False
        '
        'ChkHrRagweed
        '
        Me.ChkHrRagweed.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrRagweed.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrRagweed.Location = New System.Drawing.Point(1, 244)
        Me.ChkHrRagweed.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrRagweed.Name = "ChkHrRagweed"
        Me.ChkHrRagweed.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrRagweed.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrRagweed.TabIndex = 45
        Me.ChkHrRagweed.Tag = "44"
        Me.ChkHrRagweed.Text = "Ragweed"
        Me.ChkHrRagweed.UseVisualStyleBackColor = False
        '
        'ChkHrGrass
        '
        Me.ChkHrGrass.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrGrass.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrGrass.Location = New System.Drawing.Point(229, 244)
        Me.ChkHrGrass.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrGrass.Name = "ChkHrGrass"
        Me.ChkHrGrass.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrGrass.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrGrass.TabIndex = 46
        Me.ChkHrGrass.Tag = "45"
        Me.ChkHrGrass.Text = "Grass"
        Me.ChkHrGrass.UseVisualStyleBackColor = False
        '
        'ChkHrAqiPm10
        '
        Me.ChkHrAqiPm10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrAqiPm10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrAqiPm10.Location = New System.Drawing.Point(457, 244)
        Me.ChkHrAqiPm10.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrAqiPm10.Name = "ChkHrAqiPm10"
        Me.ChkHrAqiPm10.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrAqiPm10.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrAqiPm10.TabIndex = 47
        Me.ChkHrAqiPm10.Tag = "46"
        Me.ChkHrAqiPm10.Text = "PM10"
        Me.ChkHrAqiPm10.UseVisualStyleBackColor = False
        '
        'ChkHrAqiPm25
        '
        Me.ChkHrAqiPm25.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrAqiPm25.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrAqiPm25.Location = New System.Drawing.Point(685, 244)
        Me.ChkHrAqiPm25.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrAqiPm25.Name = "ChkHrAqiPm25"
        Me.ChkHrAqiPm25.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrAqiPm25.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrAqiPm25.TabIndex = 48
        Me.ChkHrAqiPm25.Tag = "47"
        Me.ChkHrAqiPm25.Text = "PM25"
        Me.ChkHrAqiPm25.UseVisualStyleBackColor = False
        '
        'ChkHrAqiO3
        '
        Me.ChkHrAqiO3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrAqiO3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrAqiO3.Location = New System.Drawing.Point(913, 244)
        Me.ChkHrAqiO3.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrAqiO3.Name = "ChkHrAqiO3"
        Me.ChkHrAqiO3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrAqiO3.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrAqiO3.TabIndex = 49
        Me.ChkHrAqiO3.Tag = "48"
        Me.ChkHrAqiO3.Text = "O3"
        Me.ChkHrAqiO3.UseVisualStyleBackColor = False
        '
        'ChkHrAqiCo
        '
        Me.ChkHrAqiCo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrAqiCo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrAqiCo.Location = New System.Drawing.Point(1, 271)
        Me.ChkHrAqiCo.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrAqiCo.Name = "ChkHrAqiCo"
        Me.ChkHrAqiCo.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrAqiCo.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrAqiCo.TabIndex = 50
        Me.ChkHrAqiCo.Tag = "49"
        Me.ChkHrAqiCo.Text = "CO"
        Me.ChkHrAqiCo.UseVisualStyleBackColor = False
        '
        'ChkHrAqiSo2
        '
        Me.ChkHrAqiSo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrAqiSo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrAqiSo2.Location = New System.Drawing.Point(229, 271)
        Me.ChkHrAqiSo2.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrAqiSo2.Name = "ChkHrAqiSo2"
        Me.ChkHrAqiSo2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrAqiSo2.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrAqiSo2.TabIndex = 51
        Me.ChkHrAqiSo2.Tag = "50"
        Me.ChkHrAqiSo2.Text = "SO2"
        Me.ChkHrAqiSo2.UseVisualStyleBackColor = False
        '
        'ChkHrAqiNo2
        '
        Me.ChkHrAqiNo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrAqiNo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrAqiNo2.Location = New System.Drawing.Point(457, 271)
        Me.ChkHrAqiNo2.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrAqiNo2.Name = "ChkHrAqiNo2"
        Me.ChkHrAqiNo2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrAqiNo2.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrAqiNo2.TabIndex = 52
        Me.ChkHrAqiNo2.Tag = "51"
        Me.ChkHrAqiNo2.Text = "NO2"
        Me.ChkHrAqiNo2.UseVisualStyleBackColor = False
        '
        'ChkHrEpaAqi
        '
        Me.ChkHrEpaAqi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrEpaAqi.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrEpaAqi.Location = New System.Drawing.Point(685, 271)
        Me.ChkHrEpaAqi.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrEpaAqi.Name = "ChkHrEpaAqi"
        Me.ChkHrEpaAqi.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrEpaAqi.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrEpaAqi.TabIndex = 53
        Me.ChkHrEpaAqi.Tag = "52"
        Me.ChkHrEpaAqi.Text = "EPA AQI"
        Me.ChkHrEpaAqi.UseVisualStyleBackColor = False
        '
        'ChkHrEpaConcern
        '
        Me.ChkHrEpaConcern.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrEpaConcern.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrEpaConcern.Location = New System.Drawing.Point(913, 271)
        Me.ChkHrEpaConcern.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrEpaConcern.Name = "ChkHrEpaConcern"
        Me.ChkHrEpaConcern.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrEpaConcern.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrEpaConcern.TabIndex = 54
        Me.ChkHrEpaConcern.Tag = "53"
        Me.ChkHrEpaConcern.Text = "EPA Health Concern"
        Me.ChkHrEpaConcern.UseVisualStyleBackColor = False
        '
        'ChkHrEpaPollutant
        '
        Me.ChkHrEpaPollutant.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrEpaPollutant.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrEpaPollutant.Location = New System.Drawing.Point(1, 298)
        Me.ChkHrEpaPollutant.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrEpaPollutant.Name = "ChkHrEpaPollutant"
        Me.ChkHrEpaPollutant.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrEpaPollutant.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrEpaPollutant.TabIndex = 55
        Me.ChkHrEpaPollutant.Tag = "54"
        Me.ChkHrEpaPollutant.Text = "EPA Primary Pollutant"
        Me.ChkHrEpaPollutant.UseVisualStyleBackColor = False
        '
        'ChkHrChinaAqi
        '
        Me.ChkHrChinaAqi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrChinaAqi.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrChinaAqi.Location = New System.Drawing.Point(229, 298)
        Me.ChkHrChinaAqi.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrChinaAqi.Name = "ChkHrChinaAqi"
        Me.ChkHrChinaAqi.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrChinaAqi.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrChinaAqi.TabIndex = 56
        Me.ChkHrChinaAqi.Tag = "55"
        Me.ChkHrChinaAqi.Text = "China AQI"
        Me.ChkHrChinaAqi.UseVisualStyleBackColor = False
        '
        'ChkHrChinaConcern
        '
        Me.ChkHrChinaConcern.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrChinaConcern.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrChinaConcern.Location = New System.Drawing.Point(457, 298)
        Me.ChkHrChinaConcern.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrChinaConcern.Name = "ChkHrChinaConcern"
        Me.ChkHrChinaConcern.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrChinaConcern.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrChinaConcern.TabIndex = 57
        Me.ChkHrChinaConcern.Tag = "56"
        Me.ChkHrChinaConcern.Text = "China Health Concern"
        Me.ChkHrChinaConcern.UseVisualStyleBackColor = False
        '
        'ChkHrChinaPollutant
        '
        Me.ChkHrChinaPollutant.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkHrChinaPollutant.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrChinaPollutant.Location = New System.Drawing.Point(685, 298)
        Me.ChkHrChinaPollutant.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrChinaPollutant.Name = "ChkHrChinaPollutant"
        Me.ChkHrChinaPollutant.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrChinaPollutant.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrChinaPollutant.TabIndex = 58
        Me.ChkHrChinaPollutant.Tag = "57"
        Me.ChkHrChinaPollutant.Text = "China Primary Pollutant"
        Me.ChkHrChinaPollutant.UseVisualStyleBackColor = False
        '
        'ChkHrRoadRisk
        '
        Me.ChkHrRoadRisk.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrRoadRisk.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrRoadRisk.Location = New System.Drawing.Point(913, 298)
        Me.ChkHrRoadRisk.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrRoadRisk.Name = "ChkHrRoadRisk"
        Me.ChkHrRoadRisk.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrRoadRisk.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrRoadRisk.TabIndex = 59
        Me.ChkHrRoadRisk.Tag = "58"
        Me.ChkHrRoadRisk.Text = "Road Risk"
        Me.ChkHrRoadRisk.UseVisualStyleBackColor = False
        '
        'ChkHrRiskScore
        '
        Me.ChkHrRiskScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrRiskScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrRiskScore.Location = New System.Drawing.Point(1, 325)
        Me.ChkHrRiskScore.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrRiskScore.Name = "ChkHrRiskScore"
        Me.ChkHrRiskScore.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrRiskScore.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrRiskScore.TabIndex = 60
        Me.ChkHrRiskScore.Tag = "59"
        Me.ChkHrRiskScore.Text = "Risk Score"
        Me.ChkHrRiskScore.UseVisualStyleBackColor = False
        '
        'ChkHrRiskConfidence
        '
        Me.ChkHrRiskConfidence.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrRiskConfidence.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrRiskConfidence.Location = New System.Drawing.Point(229, 325)
        Me.ChkHrRiskConfidence.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrRiskConfidence.Name = "ChkHrRiskConfidence"
        Me.ChkHrRiskConfidence.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrRiskConfidence.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrRiskConfidence.TabIndex = 61
        Me.ChkHrRiskConfidence.Tag = "60"
        Me.ChkHrRiskConfidence.Text = "Risk Confidence"
        Me.ChkHrRiskConfidence.UseVisualStyleBackColor = False
        '
        'ChkHrRiskCondition
        '
        Me.ChkHrRiskCondition.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkHrRiskCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHrRiskCondition.Location = New System.Drawing.Point(457, 325)
        Me.ChkHrRiskCondition.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkHrRiskCondition.Name = "ChkHrRiskCondition"
        Me.ChkHrRiskCondition.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkHrRiskCondition.Size = New System.Drawing.Size(226, 25)
        Me.ChkHrRiskCondition.TabIndex = 62
        Me.ChkHrRiskCondition.Tag = "61"
        Me.ChkHrRiskCondition.Text = "Risk Condition"
        Me.ChkHrRiskCondition.UseVisualStyleBackColor = False
        '
        'ChkUncheckAllHr
        '
        Me.ChkUncheckAllHr.AutoSize = True
        Me.ChkUncheckAllHr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkUncheckAllHr.Location = New System.Drawing.Point(648, 385)
        Me.ChkUncheckAllHr.Name = "ChkUncheckAllHr"
        Me.ChkUncheckAllHr.Size = New System.Drawing.Size(130, 24)
        Me.ChkUncheckAllHr.TabIndex = 1
        Me.ChkUncheckAllHr.Text = "Uncheck All"
        Me.ChkUncheckAllHr.UseVisualStyleBackColor = True
        '
        'ChkAllHourly
        '
        Me.ChkAllHourly.AutoSize = True
        Me.ChkAllHourly.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAllHourly.Location = New System.Drawing.Point(411, 385)
        Me.ChkAllHourly.Name = "ChkAllHourly"
        Me.ChkAllHourly.Size = New System.Drawing.Size(110, 24)
        Me.ChkAllHourly.TabIndex = 0
        Me.ChkAllHourly.Text = "Check All"
        Me.ChkAllHourly.UseVisualStyleBackColor = True
        '
        'TpOptNowCast
        '
        Me.TpOptNowCast.BackColor = System.Drawing.Color.Linen
        Me.TpOptNowCast.BackgroundImage = Global.psClimaCell.My.Resources.Resources.data_layers_6
        Me.TpOptNowCast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TpOptNowCast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TpOptNowCast.Controls.Add(Me.Panel1)
        Me.TpOptNowCast.Location = New System.Drawing.Point(4, 29)
        Me.TpOptNowCast.Name = "TpOptNowCast"
        Me.TpOptNowCast.Size = New System.Drawing.Size(1384, 973)
        Me.TpOptNowCast.TabIndex = 3
        Me.TpOptNowCast.Text = "Nowcast"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.FlpNowcast)
        Me.Panel1.Controls.Add(Me.NumNcTimeStep)
        Me.Panel1.Controls.Add(Me.ChkUncheckAllNowcast)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.ChkAllNowcast)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(95, 251)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1191, 467)
        Me.Panel1.TabIndex = 23
        '
        'FlpNowcast
        '
        Me.FlpNowcast.Controls.Add(Me.ChkNcTemp)
        Me.FlpNowcast.Controls.Add(Me.ChkNcFeelsLike)
        Me.FlpNowcast.Controls.Add(Me.ChkNcRH)
        Me.FlpNowcast.Controls.Add(Me.ChkNcDewpoint)
        Me.FlpNowcast.Controls.Add(Me.ChkNcWindDir)
        Me.FlpNowcast.Controls.Add(Me.ChkNcWindSpeed)
        Me.FlpNowcast.Controls.Add(Me.ChkNcWindGust)
        Me.FlpNowcast.Controls.Add(Me.ChkNcPrecipType)
        Me.FlpNowcast.Controls.Add(Me.ChkNcPrecip)
        Me.FlpNowcast.Controls.Add(Me.ChkNcCloudCover)
        Me.FlpNowcast.Controls.Add(Me.ChkNcCloudCeil)
        Me.FlpNowcast.Controls.Add(Me.ChkNcCloudBase)
        Me.FlpNowcast.Controls.Add(Me.ChkNcWxCode)
        Me.FlpNowcast.Controls.Add(Me.ChkNcVis)
        Me.FlpNowcast.Controls.Add(Me.ChkNcSunrise)
        Me.FlpNowcast.Controls.Add(Me.ChkNcSunset)
        Me.FlpNowcast.Controls.Add(Me.ChkNcBP)
        Me.FlpNowcast.Controls.Add(Me.ChkNcSSR)
        Me.FlpNowcast.Controls.Add(Me.ChkNcHailRisk)
        Me.FlpNowcast.Controls.Add(Me.ChkNcTreePollen)
        Me.FlpNowcast.Controls.Add(Me.ChkNcWeedPollen)
        Me.FlpNowcast.Controls.Add(Me.ChkNcGrassPollen)
        Me.FlpNowcast.Controls.Add(Me.ChkNcAcacia)
        Me.FlpNowcast.Controls.Add(Me.ChkNcAsh)
        Me.FlpNowcast.Controls.Add(Me.ChkNcBeech)
        Me.FlpNowcast.Controls.Add(Me.ChkNcBirch)
        Me.FlpNowcast.Controls.Add(Me.ChkNcCedar)
        Me.FlpNowcast.Controls.Add(Me.ChkNcCottonwood)
        Me.FlpNowcast.Controls.Add(Me.ChkNcCypress)
        Me.FlpNowcast.Controls.Add(Me.ChkNcElder)
        Me.FlpNowcast.Controls.Add(Me.ChkNcElm)
        Me.FlpNowcast.Controls.Add(Me.ChkNcHemlock)
        Me.FlpNowcast.Controls.Add(Me.ChkNcHickory)
        Me.FlpNowcast.Controls.Add(Me.ChkNcJuniper)
        Me.FlpNowcast.Controls.Add(Me.ChkNcMahogany)
        Me.FlpNowcast.Controls.Add(Me.ChkNcMaple)
        Me.FlpNowcast.Controls.Add(Me.ChkNcMulberry)
        Me.FlpNowcast.Controls.Add(Me.ChkNcOak)
        Me.FlpNowcast.Controls.Add(Me.ChkNcPine)
        Me.FlpNowcast.Controls.Add(Me.ChkNcSpruce)
        Me.FlpNowcast.Controls.Add(Me.ChkNcSycamore)
        Me.FlpNowcast.Controls.Add(Me.ChkNcWalnut)
        Me.FlpNowcast.Controls.Add(Me.ChkNcWillow)
        Me.FlpNowcast.Controls.Add(Me.ChkNcGrass)
        Me.FlpNowcast.Controls.Add(Me.ChkNcRagweed)
        Me.FlpNowcast.Controls.Add(Me.ChkNcPm10)
        Me.FlpNowcast.Controls.Add(Me.ChkNcPm25)
        Me.FlpNowcast.Controls.Add(Me.ChkNcO3)
        Me.FlpNowcast.Controls.Add(Me.ChkNcCo)
        Me.FlpNowcast.Controls.Add(Me.ChkNcSo2)
        Me.FlpNowcast.Controls.Add(Me.ChkNcNo2)
        Me.FlpNowcast.Controls.Add(Me.ChkNcEpaAqi)
        Me.FlpNowcast.Controls.Add(Me.ChkNcEpaConcern)
        Me.FlpNowcast.Controls.Add(Me.ChkNcEpaPollutant)
        Me.FlpNowcast.Controls.Add(Me.ChkNcChinaAqi)
        Me.FlpNowcast.Controls.Add(Me.ChkNcChinaConcern)
        Me.FlpNowcast.Controls.Add(Me.ChkNcChinaPollutant)
        Me.FlpNowcast.Controls.Add(Me.ChkNcRoadRisk)
        Me.FlpNowcast.Controls.Add(Me.ChkNcRiskScore)
        Me.FlpNowcast.Controls.Add(Me.ChkNcRiskConfidence)
        Me.FlpNowcast.Controls.Add(Me.ChkNcRiskCondition)
        Me.FlpNowcast.Location = New System.Drawing.Point(18, 14)
        Me.FlpNowcast.Name = "FlpNowcast"
        Me.FlpNowcast.Size = New System.Drawing.Size(1150, 380)
        Me.FlpNowcast.TabIndex = 24
        '
        'ChkNcTemp
        '
        Me.ChkNcTemp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcTemp.Location = New System.Drawing.Point(1, 1)
        Me.ChkNcTemp.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcTemp.Name = "ChkNcTemp"
        Me.ChkNcTemp.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcTemp.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcTemp.TabIndex = 0
        Me.ChkNcTemp.Tag = "0"
        Me.ChkNcTemp.Text = "Temperature"
        Me.ChkNcTemp.UseVisualStyleBackColor = False
        '
        'ChkNcFeelsLike
        '
        Me.ChkNcFeelsLike.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcFeelsLike.Location = New System.Drawing.Point(229, 1)
        Me.ChkNcFeelsLike.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcFeelsLike.Name = "ChkNcFeelsLike"
        Me.ChkNcFeelsLike.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcFeelsLike.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcFeelsLike.TabIndex = 1
        Me.ChkNcFeelsLike.Tag = "1"
        Me.ChkNcFeelsLike.Text = "Feels Like"
        Me.ChkNcFeelsLike.UseVisualStyleBackColor = False
        '
        'ChkNcRH
        '
        Me.ChkNcRH.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcRH.Location = New System.Drawing.Point(457, 1)
        Me.ChkNcRH.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcRH.Name = "ChkNcRH"
        Me.ChkNcRH.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcRH.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcRH.TabIndex = 2
        Me.ChkNcRH.Tag = "2"
        Me.ChkNcRH.Text = "Humidity"
        Me.ChkNcRH.UseVisualStyleBackColor = False
        '
        'ChkNcDewpoint
        '
        Me.ChkNcDewpoint.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcDewpoint.Location = New System.Drawing.Point(685, 1)
        Me.ChkNcDewpoint.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcDewpoint.Name = "ChkNcDewpoint"
        Me.ChkNcDewpoint.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcDewpoint.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcDewpoint.TabIndex = 3
        Me.ChkNcDewpoint.Tag = "13"
        Me.ChkNcDewpoint.Text = "Dewpoint"
        Me.ChkNcDewpoint.UseVisualStyleBackColor = False
        '
        'ChkNcWindDir
        '
        Me.ChkNcWindDir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcWindDir.Location = New System.Drawing.Point(913, 1)
        Me.ChkNcWindDir.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcWindDir.Name = "ChkNcWindDir"
        Me.ChkNcWindDir.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcWindDir.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcWindDir.TabIndex = 4
        Me.ChkNcWindDir.Tag = "3"
        Me.ChkNcWindDir.Text = "Wind Direction"
        Me.ChkNcWindDir.UseVisualStyleBackColor = False
        '
        'ChkNcWindSpeed
        '
        Me.ChkNcWindSpeed.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcWindSpeed.Location = New System.Drawing.Point(1, 28)
        Me.ChkNcWindSpeed.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcWindSpeed.Name = "ChkNcWindSpeed"
        Me.ChkNcWindSpeed.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcWindSpeed.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcWindSpeed.TabIndex = 5
        Me.ChkNcWindSpeed.Tag = "14"
        Me.ChkNcWindSpeed.Text = "Wind Speed"
        Me.ChkNcWindSpeed.UseVisualStyleBackColor = False
        '
        'ChkNcWindGust
        '
        Me.ChkNcWindGust.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcWindGust.Location = New System.Drawing.Point(229, 28)
        Me.ChkNcWindGust.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcWindGust.Name = "ChkNcWindGust"
        Me.ChkNcWindGust.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcWindGust.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcWindGust.TabIndex = 6
        Me.ChkNcWindGust.Tag = "4"
        Me.ChkNcWindGust.Text = "Wind Gust"
        Me.ChkNcWindGust.UseVisualStyleBackColor = False
        '
        'ChkNcPrecipType
        '
        Me.ChkNcPrecipType.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcPrecipType.Location = New System.Drawing.Point(457, 28)
        Me.ChkNcPrecipType.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcPrecipType.Name = "ChkNcPrecipType"
        Me.ChkNcPrecipType.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcPrecipType.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcPrecipType.TabIndex = 7
        Me.ChkNcPrecipType.Tag = "6"
        Me.ChkNcPrecipType.Text = "Precipitation Type"
        Me.ChkNcPrecipType.UseVisualStyleBackColor = False
        '
        'ChkNcPrecip
        '
        Me.ChkNcPrecip.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcPrecip.Location = New System.Drawing.Point(685, 28)
        Me.ChkNcPrecip.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcPrecip.Name = "ChkNcPrecip"
        Me.ChkNcPrecip.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcPrecip.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcPrecip.TabIndex = 8
        Me.ChkNcPrecip.Tag = "5"
        Me.ChkNcPrecip.Text = "Precipitation"
        Me.ChkNcPrecip.UseVisualStyleBackColor = False
        '
        'ChkNcCloudCover
        '
        Me.ChkNcCloudCover.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcCloudCover.Location = New System.Drawing.Point(913, 28)
        Me.ChkNcCloudCover.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcCloudCover.Name = "ChkNcCloudCover"
        Me.ChkNcCloudCover.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcCloudCover.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcCloudCover.TabIndex = 9
        Me.ChkNcCloudCover.Tag = "9"
        Me.ChkNcCloudCover.Text = "Cloud Cover"
        Me.ChkNcCloudCover.UseVisualStyleBackColor = False
        '
        'ChkNcCloudCeil
        '
        Me.ChkNcCloudCeil.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcCloudCeil.Location = New System.Drawing.Point(1, 55)
        Me.ChkNcCloudCeil.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcCloudCeil.Name = "ChkNcCloudCeil"
        Me.ChkNcCloudCeil.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcCloudCeil.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcCloudCeil.TabIndex = 10
        Me.ChkNcCloudCeil.Tag = "10"
        Me.ChkNcCloudCeil.Text = "Cloud Ceiling"
        Me.ChkNcCloudCeil.UseVisualStyleBackColor = False
        '
        'ChkNcCloudBase
        '
        Me.ChkNcCloudBase.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcCloudBase.Location = New System.Drawing.Point(229, 55)
        Me.ChkNcCloudBase.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcCloudBase.Name = "ChkNcCloudBase"
        Me.ChkNcCloudBase.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcCloudBase.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcCloudBase.TabIndex = 11
        Me.ChkNcCloudBase.Tag = "15"
        Me.ChkNcCloudBase.Text = "Cloud Base"
        Me.ChkNcCloudBase.UseVisualStyleBackColor = False
        '
        'ChkNcWxCode
        '
        Me.ChkNcWxCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcWxCode.Location = New System.Drawing.Point(457, 55)
        Me.ChkNcWxCode.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcWxCode.Name = "ChkNcWxCode"
        Me.ChkNcWxCode.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcWxCode.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcWxCode.TabIndex = 12
        Me.ChkNcWxCode.Tag = "11"
        Me.ChkNcWxCode.Text = "Weather Code"
        Me.ChkNcWxCode.UseVisualStyleBackColor = False
        '
        'ChkNcVis
        '
        Me.ChkNcVis.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcVis.Location = New System.Drawing.Point(685, 55)
        Me.ChkNcVis.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcVis.Name = "ChkNcVis"
        Me.ChkNcVis.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcVis.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcVis.TabIndex = 13
        Me.ChkNcVis.Tag = "8"
        Me.ChkNcVis.Text = "Visibility"
        Me.ChkNcVis.UseVisualStyleBackColor = False
        '
        'ChkNcSunrise
        '
        Me.ChkNcSunrise.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcSunrise.Location = New System.Drawing.Point(913, 55)
        Me.ChkNcSunrise.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcSunrise.Name = "ChkNcSunrise"
        Me.ChkNcSunrise.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcSunrise.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcSunrise.TabIndex = 14
        Me.ChkNcSunrise.Tag = "7"
        Me.ChkNcSunrise.Text = "Sunrise"
        Me.ChkNcSunrise.UseVisualStyleBackColor = False
        '
        'ChkNcSunset
        '
        Me.ChkNcSunset.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcSunset.Location = New System.Drawing.Point(1, 82)
        Me.ChkNcSunset.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcSunset.Name = "ChkNcSunset"
        Me.ChkNcSunset.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcSunset.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcSunset.TabIndex = 15
        Me.ChkNcSunset.Tag = "12"
        Me.ChkNcSunset.Text = "Sunset"
        Me.ChkNcSunset.UseVisualStyleBackColor = False
        '
        'ChkNcBP
        '
        Me.ChkNcBP.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcBP.Location = New System.Drawing.Point(229, 82)
        Me.ChkNcBP.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcBP.Name = "ChkNcBP"
        Me.ChkNcBP.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcBP.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcBP.TabIndex = 16
        Me.ChkNcBP.Tag = "16"
        Me.ChkNcBP.Text = "Barometric Pressure"
        Me.ChkNcBP.UseVisualStyleBackColor = False
        '
        'ChkNcSSR
        '
        Me.ChkNcSSR.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcSSR.Location = New System.Drawing.Point(457, 82)
        Me.ChkNcSSR.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcSSR.Name = "ChkNcSSR"
        Me.ChkNcSSR.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcSSR.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcSSR.TabIndex = 17
        Me.ChkNcSSR.Tag = "17"
        Me.ChkNcSSR.Text = "Surface Shortwave Radiation"
        Me.ChkNcSSR.UseVisualStyleBackColor = False
        '
        'ChkNcHailRisk
        '
        Me.ChkNcHailRisk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcHailRisk.Location = New System.Drawing.Point(685, 82)
        Me.ChkNcHailRisk.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcHailRisk.Name = "ChkNcHailRisk"
        Me.ChkNcHailRisk.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcHailRisk.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcHailRisk.TabIndex = 18
        Me.ChkNcHailRisk.Tag = "18"
        Me.ChkNcHailRisk.Text = "Hail Risk"
        Me.ChkNcHailRisk.UseVisualStyleBackColor = False
        '
        'ChkNcTreePollen
        '
        Me.ChkNcTreePollen.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcTreePollen.Location = New System.Drawing.Point(913, 82)
        Me.ChkNcTreePollen.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcTreePollen.Name = "ChkNcTreePollen"
        Me.ChkNcTreePollen.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcTreePollen.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcTreePollen.TabIndex = 19
        Me.ChkNcTreePollen.Tag = "19"
        Me.ChkNcTreePollen.Text = "Tree Pollen"
        Me.ChkNcTreePollen.UseVisualStyleBackColor = False
        '
        'ChkNcWeedPollen
        '
        Me.ChkNcWeedPollen.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcWeedPollen.Location = New System.Drawing.Point(1, 109)
        Me.ChkNcWeedPollen.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcWeedPollen.Name = "ChkNcWeedPollen"
        Me.ChkNcWeedPollen.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcWeedPollen.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcWeedPollen.TabIndex = 20
        Me.ChkNcWeedPollen.Tag = "20"
        Me.ChkNcWeedPollen.Text = "Weed Pollen"
        Me.ChkNcWeedPollen.UseVisualStyleBackColor = False
        '
        'ChkNcGrassPollen
        '
        Me.ChkNcGrassPollen.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcGrassPollen.Location = New System.Drawing.Point(229, 109)
        Me.ChkNcGrassPollen.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcGrassPollen.Name = "ChkNcGrassPollen"
        Me.ChkNcGrassPollen.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcGrassPollen.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcGrassPollen.TabIndex = 21
        Me.ChkNcGrassPollen.Tag = "21"
        Me.ChkNcGrassPollen.Text = "Grass Pollen"
        Me.ChkNcGrassPollen.UseVisualStyleBackColor = False
        '
        'ChkNcAcacia
        '
        Me.ChkNcAcacia.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcAcacia.Location = New System.Drawing.Point(457, 109)
        Me.ChkNcAcacia.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcAcacia.Name = "ChkNcAcacia"
        Me.ChkNcAcacia.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcAcacia.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcAcacia.TabIndex = 22
        Me.ChkNcAcacia.Tag = "22"
        Me.ChkNcAcacia.Text = "Acacia"
        Me.ChkNcAcacia.UseVisualStyleBackColor = False
        '
        'ChkNcAsh
        '
        Me.ChkNcAsh.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcAsh.Location = New System.Drawing.Point(685, 109)
        Me.ChkNcAsh.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcAsh.Name = "ChkNcAsh"
        Me.ChkNcAsh.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcAsh.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcAsh.TabIndex = 23
        Me.ChkNcAsh.Tag = "28"
        Me.ChkNcAsh.Text = "Ash "
        Me.ChkNcAsh.UseVisualStyleBackColor = False
        '
        'ChkNcBeech
        '
        Me.ChkNcBeech.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcBeech.Location = New System.Drawing.Point(913, 109)
        Me.ChkNcBeech.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcBeech.Name = "ChkNcBeech"
        Me.ChkNcBeech.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcBeech.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcBeech.TabIndex = 24
        Me.ChkNcBeech.Tag = "34"
        Me.ChkNcBeech.Text = "Beech"
        Me.ChkNcBeech.UseVisualStyleBackColor = False
        '
        'ChkNcBirch
        '
        Me.ChkNcBirch.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcBirch.Location = New System.Drawing.Point(1, 136)
        Me.ChkNcBirch.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcBirch.Name = "ChkNcBirch"
        Me.ChkNcBirch.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcBirch.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcBirch.TabIndex = 25
        Me.ChkNcBirch.Tag = "23"
        Me.ChkNcBirch.Text = "Birch"
        Me.ChkNcBirch.UseVisualStyleBackColor = False
        '
        'ChkNcCedar
        '
        Me.ChkNcCedar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcCedar.Location = New System.Drawing.Point(229, 136)
        Me.ChkNcCedar.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcCedar.Name = "ChkNcCedar"
        Me.ChkNcCedar.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcCedar.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcCedar.TabIndex = 26
        Me.ChkNcCedar.Tag = "29"
        Me.ChkNcCedar.Text = "Cedar"
        Me.ChkNcCedar.UseVisualStyleBackColor = False
        '
        'ChkNcCottonwood
        '
        Me.ChkNcCottonwood.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcCottonwood.Location = New System.Drawing.Point(457, 136)
        Me.ChkNcCottonwood.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcCottonwood.Name = "ChkNcCottonwood"
        Me.ChkNcCottonwood.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcCottonwood.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcCottonwood.TabIndex = 27
        Me.ChkNcCottonwood.Tag = "41"
        Me.ChkNcCottonwood.Text = "Cottonwood"
        Me.ChkNcCottonwood.UseVisualStyleBackColor = False
        '
        'ChkNcCypress
        '
        Me.ChkNcCypress.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcCypress.Location = New System.Drawing.Point(685, 136)
        Me.ChkNcCypress.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcCypress.Name = "ChkNcCypress"
        Me.ChkNcCypress.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcCypress.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcCypress.TabIndex = 28
        Me.ChkNcCypress.Tag = "35"
        Me.ChkNcCypress.Text = "Cypress"
        Me.ChkNcCypress.UseVisualStyleBackColor = False
        '
        'ChkNcElder
        '
        Me.ChkNcElder.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcElder.Location = New System.Drawing.Point(913, 136)
        Me.ChkNcElder.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcElder.Name = "ChkNcElder"
        Me.ChkNcElder.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcElder.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcElder.TabIndex = 29
        Me.ChkNcElder.Tag = "24"
        Me.ChkNcElder.Text = "Elder"
        Me.ChkNcElder.UseVisualStyleBackColor = False
        '
        'ChkNcElm
        '
        Me.ChkNcElm.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcElm.Location = New System.Drawing.Point(1, 163)
        Me.ChkNcElm.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcElm.Name = "ChkNcElm"
        Me.ChkNcElm.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcElm.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcElm.TabIndex = 30
        Me.ChkNcElm.Tag = "30"
        Me.ChkNcElm.Text = "Elm"
        Me.ChkNcElm.UseVisualStyleBackColor = False
        '
        'ChkNcHemlock
        '
        Me.ChkNcHemlock.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcHemlock.Location = New System.Drawing.Point(229, 163)
        Me.ChkNcHemlock.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcHemlock.Name = "ChkNcHemlock"
        Me.ChkNcHemlock.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcHemlock.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcHemlock.TabIndex = 31
        Me.ChkNcHemlock.Tag = "36"
        Me.ChkNcHemlock.Text = "Hemlock"
        Me.ChkNcHemlock.UseVisualStyleBackColor = False
        '
        'ChkNcHickory
        '
        Me.ChkNcHickory.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcHickory.Location = New System.Drawing.Point(457, 163)
        Me.ChkNcHickory.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcHickory.Name = "ChkNcHickory"
        Me.ChkNcHickory.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcHickory.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcHickory.TabIndex = 32
        Me.ChkNcHickory.Tag = "25"
        Me.ChkNcHickory.Text = "Hickory"
        Me.ChkNcHickory.UseVisualStyleBackColor = False
        '
        'ChkNcJuniper
        '
        Me.ChkNcJuniper.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcJuniper.Location = New System.Drawing.Point(685, 163)
        Me.ChkNcJuniper.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcJuniper.Name = "ChkNcJuniper"
        Me.ChkNcJuniper.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcJuniper.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcJuniper.TabIndex = 33
        Me.ChkNcJuniper.Tag = "31"
        Me.ChkNcJuniper.Text = "Juniper"
        Me.ChkNcJuniper.UseVisualStyleBackColor = False
        '
        'ChkNcMahogany
        '
        Me.ChkNcMahogany.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcMahogany.Location = New System.Drawing.Point(913, 163)
        Me.ChkNcMahogany.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcMahogany.Name = "ChkNcMahogany"
        Me.ChkNcMahogany.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcMahogany.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcMahogany.TabIndex = 34
        Me.ChkNcMahogany.Tag = "37"
        Me.ChkNcMahogany.Text = "Mahogany"
        Me.ChkNcMahogany.UseVisualStyleBackColor = False
        '
        'ChkNcMaple
        '
        Me.ChkNcMaple.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcMaple.Location = New System.Drawing.Point(1, 190)
        Me.ChkNcMaple.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcMaple.Name = "ChkNcMaple"
        Me.ChkNcMaple.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcMaple.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcMaple.TabIndex = 35
        Me.ChkNcMaple.Tag = "26"
        Me.ChkNcMaple.Text = "Maple"
        Me.ChkNcMaple.UseVisualStyleBackColor = False
        '
        'ChkNcMulberry
        '
        Me.ChkNcMulberry.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcMulberry.Location = New System.Drawing.Point(229, 190)
        Me.ChkNcMulberry.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcMulberry.Name = "ChkNcMulberry"
        Me.ChkNcMulberry.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcMulberry.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcMulberry.TabIndex = 36
        Me.ChkNcMulberry.Tag = "32"
        Me.ChkNcMulberry.Text = "Mulberry"
        Me.ChkNcMulberry.UseVisualStyleBackColor = False
        '
        'ChkNcOak
        '
        Me.ChkNcOak.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcOak.Location = New System.Drawing.Point(457, 190)
        Me.ChkNcOak.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcOak.Name = "ChkNcOak"
        Me.ChkNcOak.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcOak.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcOak.TabIndex = 37
        Me.ChkNcOak.Tag = "38"
        Me.ChkNcOak.Text = "Oak"
        Me.ChkNcOak.UseVisualStyleBackColor = False
        '
        'ChkNcPine
        '
        Me.ChkNcPine.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcPine.Location = New System.Drawing.Point(685, 190)
        Me.ChkNcPine.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcPine.Name = "ChkNcPine"
        Me.ChkNcPine.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcPine.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcPine.TabIndex = 38
        Me.ChkNcPine.Tag = "40"
        Me.ChkNcPine.Text = "Pine"
        Me.ChkNcPine.UseVisualStyleBackColor = False
        '
        'ChkNcSpruce
        '
        Me.ChkNcSpruce.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcSpruce.Location = New System.Drawing.Point(913, 190)
        Me.ChkNcSpruce.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcSpruce.Name = "ChkNcSpruce"
        Me.ChkNcSpruce.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcSpruce.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcSpruce.TabIndex = 39
        Me.ChkNcSpruce.Tag = "42"
        Me.ChkNcSpruce.Text = "Spruce"
        Me.ChkNcSpruce.UseVisualStyleBackColor = False
        '
        'ChkNcSycamore
        '
        Me.ChkNcSycamore.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcSycamore.Location = New System.Drawing.Point(1, 217)
        Me.ChkNcSycamore.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcSycamore.Name = "ChkNcSycamore"
        Me.ChkNcSycamore.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcSycamore.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcSycamore.TabIndex = 40
        Me.ChkNcSycamore.Tag = "43"
        Me.ChkNcSycamore.Text = "Sycamore"
        Me.ChkNcSycamore.UseVisualStyleBackColor = False
        '
        'ChkNcWalnut
        '
        Me.ChkNcWalnut.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcWalnut.Location = New System.Drawing.Point(229, 217)
        Me.ChkNcWalnut.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcWalnut.Name = "ChkNcWalnut"
        Me.ChkNcWalnut.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcWalnut.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcWalnut.TabIndex = 41
        Me.ChkNcWalnut.Tag = "44"
        Me.ChkNcWalnut.Text = "Walnut"
        Me.ChkNcWalnut.UseVisualStyleBackColor = False
        '
        'ChkNcWillow
        '
        Me.ChkNcWillow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcWillow.Location = New System.Drawing.Point(457, 217)
        Me.ChkNcWillow.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcWillow.Name = "ChkNcWillow"
        Me.ChkNcWillow.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcWillow.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcWillow.TabIndex = 42
        Me.ChkNcWillow.Tag = "27"
        Me.ChkNcWillow.Text = "Willow"
        Me.ChkNcWillow.UseVisualStyleBackColor = False
        '
        'ChkNcGrass
        '
        Me.ChkNcGrass.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcGrass.Location = New System.Drawing.Point(685, 217)
        Me.ChkNcGrass.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcGrass.Name = "ChkNcGrass"
        Me.ChkNcGrass.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcGrass.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcGrass.TabIndex = 43
        Me.ChkNcGrass.Tag = "39"
        Me.ChkNcGrass.Text = "Grass"
        Me.ChkNcGrass.UseVisualStyleBackColor = False
        '
        'ChkNcRagweed
        '
        Me.ChkNcRagweed.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcRagweed.Location = New System.Drawing.Point(913, 217)
        Me.ChkNcRagweed.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcRagweed.Name = "ChkNcRagweed"
        Me.ChkNcRagweed.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcRagweed.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcRagweed.TabIndex = 44
        Me.ChkNcRagweed.Tag = "33"
        Me.ChkNcRagweed.Text = "Ragweed"
        Me.ChkNcRagweed.UseVisualStyleBackColor = False
        '
        'ChkNcPm10
        '
        Me.ChkNcPm10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcPm10.Location = New System.Drawing.Point(1, 244)
        Me.ChkNcPm10.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcPm10.Name = "ChkNcPm10"
        Me.ChkNcPm10.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcPm10.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcPm10.TabIndex = 45
        Me.ChkNcPm10.Tag = "45"
        Me.ChkNcPm10.Text = "PM10"
        Me.ChkNcPm10.UseVisualStyleBackColor = False
        '
        'ChkNcPm25
        '
        Me.ChkNcPm25.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcPm25.Location = New System.Drawing.Point(229, 244)
        Me.ChkNcPm25.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcPm25.Name = "ChkNcPm25"
        Me.ChkNcPm25.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcPm25.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcPm25.TabIndex = 46
        Me.ChkNcPm25.Tag = "46"
        Me.ChkNcPm25.Text = "PM25"
        Me.ChkNcPm25.UseVisualStyleBackColor = False
        '
        'ChkNcO3
        '
        Me.ChkNcO3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcO3.Location = New System.Drawing.Point(457, 244)
        Me.ChkNcO3.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcO3.Name = "ChkNcO3"
        Me.ChkNcO3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcO3.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcO3.TabIndex = 47
        Me.ChkNcO3.Tag = "47"
        Me.ChkNcO3.Text = "O3"
        Me.ChkNcO3.UseVisualStyleBackColor = False
        '
        'ChkNcCo
        '
        Me.ChkNcCo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcCo.Location = New System.Drawing.Point(685, 244)
        Me.ChkNcCo.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcCo.Name = "ChkNcCo"
        Me.ChkNcCo.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcCo.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcCo.TabIndex = 48
        Me.ChkNcCo.Tag = "48"
        Me.ChkNcCo.Text = "CO"
        Me.ChkNcCo.UseVisualStyleBackColor = False
        '
        'ChkNcSo2
        '
        Me.ChkNcSo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcSo2.Location = New System.Drawing.Point(913, 244)
        Me.ChkNcSo2.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcSo2.Name = "ChkNcSo2"
        Me.ChkNcSo2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcSo2.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcSo2.TabIndex = 49
        Me.ChkNcSo2.Tag = "49"
        Me.ChkNcSo2.Text = "SO2"
        Me.ChkNcSo2.UseVisualStyleBackColor = False
        '
        'ChkNcNo2
        '
        Me.ChkNcNo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcNo2.Location = New System.Drawing.Point(1, 271)
        Me.ChkNcNo2.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcNo2.Name = "ChkNcNo2"
        Me.ChkNcNo2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcNo2.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcNo2.TabIndex = 50
        Me.ChkNcNo2.Tag = "50"
        Me.ChkNcNo2.Text = "NO2"
        Me.ChkNcNo2.UseVisualStyleBackColor = False
        '
        'ChkNcEpaAqi
        '
        Me.ChkNcEpaAqi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcEpaAqi.Location = New System.Drawing.Point(229, 271)
        Me.ChkNcEpaAqi.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcEpaAqi.Name = "ChkNcEpaAqi"
        Me.ChkNcEpaAqi.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcEpaAqi.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcEpaAqi.TabIndex = 51
        Me.ChkNcEpaAqi.Tag = "51"
        Me.ChkNcEpaAqi.Text = "EPA AQI"
        Me.ChkNcEpaAqi.UseVisualStyleBackColor = False
        '
        'ChkNcEpaConcern
        '
        Me.ChkNcEpaConcern.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcEpaConcern.Location = New System.Drawing.Point(457, 271)
        Me.ChkNcEpaConcern.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcEpaConcern.Name = "ChkNcEpaConcern"
        Me.ChkNcEpaConcern.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcEpaConcern.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcEpaConcern.TabIndex = 52
        Me.ChkNcEpaConcern.Tag = "52"
        Me.ChkNcEpaConcern.Text = "EPA Health Concern"
        Me.ChkNcEpaConcern.UseVisualStyleBackColor = False
        '
        'ChkNcEpaPollutant
        '
        Me.ChkNcEpaPollutant.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcEpaPollutant.Location = New System.Drawing.Point(685, 271)
        Me.ChkNcEpaPollutant.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcEpaPollutant.Name = "ChkNcEpaPollutant"
        Me.ChkNcEpaPollutant.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcEpaPollutant.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcEpaPollutant.TabIndex = 53
        Me.ChkNcEpaPollutant.Tag = "53"
        Me.ChkNcEpaPollutant.Text = "EPA Primary Pollutant"
        Me.ChkNcEpaPollutant.UseVisualStyleBackColor = False
        '
        'ChkNcChinaAqi
        '
        Me.ChkNcChinaAqi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcChinaAqi.Location = New System.Drawing.Point(913, 271)
        Me.ChkNcChinaAqi.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcChinaAqi.Name = "ChkNcChinaAqi"
        Me.ChkNcChinaAqi.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcChinaAqi.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcChinaAqi.TabIndex = 54
        Me.ChkNcChinaAqi.Tag = "54"
        Me.ChkNcChinaAqi.Text = "China AQI"
        Me.ChkNcChinaAqi.UseVisualStyleBackColor = False
        '
        'ChkNcChinaConcern
        '
        Me.ChkNcChinaConcern.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcChinaConcern.Location = New System.Drawing.Point(1, 298)
        Me.ChkNcChinaConcern.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcChinaConcern.Name = "ChkNcChinaConcern"
        Me.ChkNcChinaConcern.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcChinaConcern.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcChinaConcern.TabIndex = 55
        Me.ChkNcChinaConcern.Tag = "55"
        Me.ChkNcChinaConcern.Text = "China Health Concern"
        Me.ChkNcChinaConcern.UseVisualStyleBackColor = False
        '
        'ChkNcChinaPollutant
        '
        Me.ChkNcChinaPollutant.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkNcChinaPollutant.Location = New System.Drawing.Point(229, 298)
        Me.ChkNcChinaPollutant.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcChinaPollutant.Name = "ChkNcChinaPollutant"
        Me.ChkNcChinaPollutant.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcChinaPollutant.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcChinaPollutant.TabIndex = 56
        Me.ChkNcChinaPollutant.Tag = "56"
        Me.ChkNcChinaPollutant.Text = "China Primary Pollutant"
        Me.ChkNcChinaPollutant.UseVisualStyleBackColor = False
        '
        'ChkNcRoadRisk
        '
        Me.ChkNcRoadRisk.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcRoadRisk.Enabled = False
        Me.ChkNcRoadRisk.Location = New System.Drawing.Point(457, 298)
        Me.ChkNcRoadRisk.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcRoadRisk.Name = "ChkNcRoadRisk"
        Me.ChkNcRoadRisk.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcRoadRisk.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcRoadRisk.TabIndex = 57
        Me.ChkNcRoadRisk.TabStop = False
        Me.ChkNcRoadRisk.Tag = "57"
        Me.ChkNcRoadRisk.Text = "Road Risk"
        Me.ChkNcRoadRisk.UseVisualStyleBackColor = False
        '
        'ChkNcRiskScore
        '
        Me.ChkNcRiskScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcRiskScore.Location = New System.Drawing.Point(685, 298)
        Me.ChkNcRiskScore.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcRiskScore.Name = "ChkNcRiskScore"
        Me.ChkNcRiskScore.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcRiskScore.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcRiskScore.TabIndex = 57
        Me.ChkNcRiskScore.Tag = "58"
        Me.ChkNcRiskScore.Text = "Risk Score"
        Me.ChkNcRiskScore.UseVisualStyleBackColor = False
        '
        'ChkNcRiskConfidence
        '
        Me.ChkNcRiskConfidence.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcRiskConfidence.Location = New System.Drawing.Point(913, 298)
        Me.ChkNcRiskConfidence.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcRiskConfidence.Name = "ChkNcRiskConfidence"
        Me.ChkNcRiskConfidence.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcRiskConfidence.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcRiskConfidence.TabIndex = 58
        Me.ChkNcRiskConfidence.Tag = "59"
        Me.ChkNcRiskConfidence.Text = "Risk Confidence"
        Me.ChkNcRiskConfidence.UseVisualStyleBackColor = False
        '
        'ChkNcRiskCondition
        '
        Me.ChkNcRiskCondition.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkNcRiskCondition.Location = New System.Drawing.Point(1, 325)
        Me.ChkNcRiskCondition.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkNcRiskCondition.Name = "ChkNcRiskCondition"
        Me.ChkNcRiskCondition.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkNcRiskCondition.Size = New System.Drawing.Size(226, 25)
        Me.ChkNcRiskCondition.TabIndex = 59
        Me.ChkNcRiskCondition.Tag = "60"
        Me.ChkNcRiskCondition.Text = "Risk Condition"
        Me.ChkNcRiskCondition.UseVisualStyleBackColor = False
        '
        'NumNcTimeStep
        '
        Me.NumNcTimeStep.Location = New System.Drawing.Point(398, 411)
        Me.NumNcTimeStep.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NumNcTimeStep.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumNcTimeStep.Name = "NumNcTimeStep"
        Me.NumNcTimeStep.Size = New System.Drawing.Size(65, 23)
        Me.NumNcTimeStep.TabIndex = 1
        Me.NumNcTimeStep.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ChkUncheckAllNowcast
        '
        Me.ChkUncheckAllNowcast.AutoSize = True
        Me.ChkUncheckAllNowcast.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkUncheckAllNowcast.Location = New System.Drawing.Point(856, 409)
        Me.ChkUncheckAllNowcast.Name = "ChkUncheckAllNowcast"
        Me.ChkUncheckAllNowcast.Size = New System.Drawing.Size(119, 21)
        Me.ChkUncheckAllNowcast.TabIndex = 3
        Me.ChkUncheckAllNowcast.Text = "Uncheck All"
        Me.ChkUncheckAllNowcast.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(211, 411)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(152, 17)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Time step (minutes)"
        '
        'ChkAllNowcast
        '
        Me.ChkAllNowcast.AutoSize = True
        Me.ChkAllNowcast.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAllNowcast.Location = New System.Drawing.Point(627, 409)
        Me.ChkAllNowcast.Name = "ChkAllNowcast"
        Me.ChkAllNowcast.Size = New System.Drawing.Size(101, 21)
        Me.ChkAllNowcast.TabIndex = 2
        Me.ChkAllNowcast.Text = "Check All"
        Me.ChkAllNowcast.UseVisualStyleBackColor = True
        '
        'TpOptRealtime
        '
        Me.TpOptRealtime.BackColor = System.Drawing.Color.Linen
        Me.TpOptRealtime.BackgroundImage = Global.psClimaCell.My.Resources.Resources.data_layers_6
        Me.TpOptRealtime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TpOptRealtime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TpOptRealtime.Controls.Add(Me.PnlOptRealtime)
        Me.TpOptRealtime.Location = New System.Drawing.Point(4, 29)
        Me.TpOptRealtime.Name = "TpOptRealtime"
        Me.TpOptRealtime.Padding = New System.Windows.Forms.Padding(3)
        Me.TpOptRealtime.Size = New System.Drawing.Size(1384, 973)
        Me.TpOptRealtime.TabIndex = 4
        Me.TpOptRealtime.Text = "RealTime"
        '
        'PnlOptRealtime
        '
        Me.PnlOptRealtime.BackColor = System.Drawing.Color.Silver
        Me.PnlOptRealtime.Controls.Add(Me.ChkRtUncheckAll)
        Me.PnlOptRealtime.Controls.Add(Me.ChkRtCheckAll)
        Me.PnlOptRealtime.Controls.Add(Me.FlpRtOpt)
        Me.PnlOptRealtime.Location = New System.Drawing.Point(61, 262)
        Me.PnlOptRealtime.Name = "PnlOptRealtime"
        Me.PnlOptRealtime.Size = New System.Drawing.Size(1258, 444)
        Me.PnlOptRealtime.TabIndex = 0
        '
        'ChkRtUncheckAll
        '
        Me.ChkRtUncheckAll.AutoSize = True
        Me.ChkRtUncheckAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtUncheckAll.Location = New System.Drawing.Point(689, 406)
        Me.ChkRtUncheckAll.Name = "ChkRtUncheckAll"
        Me.ChkRtUncheckAll.Size = New System.Drawing.Size(130, 24)
        Me.ChkRtUncheckAll.TabIndex = 28
        Me.ChkRtUncheckAll.Text = "Uncheck All"
        Me.ChkRtUncheckAll.UseVisualStyleBackColor = True
        '
        'ChkRtCheckAll
        '
        Me.ChkRtCheckAll.AutoSize = True
        Me.ChkRtCheckAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtCheckAll.Location = New System.Drawing.Point(444, 406)
        Me.ChkRtCheckAll.Name = "ChkRtCheckAll"
        Me.ChkRtCheckAll.Size = New System.Drawing.Size(110, 24)
        Me.ChkRtCheckAll.TabIndex = 27
        Me.ChkRtCheckAll.Text = "Check All"
        Me.ChkRtCheckAll.UseVisualStyleBackColor = True
        '
        'FlpRtOpt
        '
        Me.FlpRtOpt.BackColor = System.Drawing.Color.Silver
        Me.FlpRtOpt.Controls.Add(Me.ChkRtCore0)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtCore1)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtCore2)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtCore3)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtCore4)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtCore5)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtCore6)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtCore7)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtCore8)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtCore9)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtCore10)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtCore11)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtCore12)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtCore13)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtCore14)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtCore15)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtCore16)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtCore17)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtCore18)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtCore19)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtCore20)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol0)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol1)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol2)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol3)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol4)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol5)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol6)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol7)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol8)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol9)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol10)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol11)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol12)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol13)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol14)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol15)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol16)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol17)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol18)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol19)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol20)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol21)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol22)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol23)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol24)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtPol25)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtRoad0)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtRoad1)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtRoad2)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtRoad3)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtFire0)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtHail0)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtAqi0)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtAqi1)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtAqi2)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtAqi3)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtAqi4)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtAqi5)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtAqi6)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtAqi7)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtAqi8)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtAqi9)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtAqi10)
        Me.FlpRtOpt.Controls.Add(Me.ChkRtAqi11)
        Me.FlpRtOpt.Location = New System.Drawing.Point(29, 23)
        Me.FlpRtOpt.MaximumSize = New System.Drawing.Size(1200, 370)
        Me.FlpRtOpt.MinimumSize = New System.Drawing.Size(1200, 370)
        Me.FlpRtOpt.Name = "FlpRtOpt"
        Me.FlpRtOpt.Padding = New System.Windows.Forms.Padding(5, 5, 0, 5)
        Me.FlpRtOpt.Size = New System.Drawing.Size(1200, 370)
        Me.FlpRtOpt.TabIndex = 0
        '
        'ChkRtCore0
        '
        Me.ChkRtCore0.AutoSize = True
        Me.ChkRtCore0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtCore0.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtCore0.Location = New System.Drawing.Point(6, 6)
        Me.ChkRtCore0.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtCore0.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore0.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore0.Name = "ChkRtCore0"
        Me.ChkRtCore0.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtCore0.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtCore0.TabIndex = 0
        Me.ChkRtCore0.Tag = "0"
        Me.ChkRtCore0.Text = "Temp"
        Me.ChkRtCore0.UseVisualStyleBackColor = False
        '
        'ChkRtCore1
        '
        Me.ChkRtCore1.AutoSize = True
        Me.ChkRtCore1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtCore1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtCore1.Location = New System.Drawing.Point(243, 6)
        Me.ChkRtCore1.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtCore1.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore1.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore1.Name = "ChkRtCore1"
        Me.ChkRtCore1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtCore1.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtCore1.TabIndex = 1
        Me.ChkRtCore1.Tag = "1"
        Me.ChkRtCore1.Text = "Feels Like"
        Me.ChkRtCore1.UseVisualStyleBackColor = False
        '
        'ChkRtCore2
        '
        Me.ChkRtCore2.AutoSize = True
        Me.ChkRtCore2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtCore2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtCore2.Location = New System.Drawing.Point(480, 6)
        Me.ChkRtCore2.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtCore2.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore2.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore2.Name = "ChkRtCore2"
        Me.ChkRtCore2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtCore2.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtCore2.TabIndex = 2
        Me.ChkRtCore2.Tag = "2"
        Me.ChkRtCore2.Text = "Dewpoint"
        Me.ChkRtCore2.UseVisualStyleBackColor = False
        '
        'ChkRtCore3
        '
        Me.ChkRtCore3.AutoSize = True
        Me.ChkRtCore3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtCore3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtCore3.Location = New System.Drawing.Point(717, 6)
        Me.ChkRtCore3.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtCore3.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore3.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore3.Name = "ChkRtCore3"
        Me.ChkRtCore3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtCore3.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtCore3.TabIndex = 3
        Me.ChkRtCore3.Tag = "3"
        Me.ChkRtCore3.Text = "Humidity"
        Me.ChkRtCore3.UseVisualStyleBackColor = False
        '
        'ChkRtCore4
        '
        Me.ChkRtCore4.AutoSize = True
        Me.ChkRtCore4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtCore4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtCore4.Location = New System.Drawing.Point(954, 6)
        Me.ChkRtCore4.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtCore4.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore4.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore4.Name = "ChkRtCore4"
        Me.ChkRtCore4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtCore4.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtCore4.TabIndex = 4
        Me.ChkRtCore4.Tag = "4"
        Me.ChkRtCore4.Text = "Wind Speed"
        Me.ChkRtCore4.UseVisualStyleBackColor = False
        '
        'ChkRtCore5
        '
        Me.ChkRtCore5.AutoSize = True
        Me.ChkRtCore5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtCore5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtCore5.Location = New System.Drawing.Point(6, 32)
        Me.ChkRtCore5.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtCore5.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore5.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore5.Name = "ChkRtCore5"
        Me.ChkRtCore5.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtCore5.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtCore5.TabIndex = 5
        Me.ChkRtCore5.Tag = "5"
        Me.ChkRtCore5.Text = "Wind Direction"
        Me.ChkRtCore5.UseVisualStyleBackColor = False
        '
        'ChkRtCore6
        '
        Me.ChkRtCore6.AutoSize = True
        Me.ChkRtCore6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtCore6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtCore6.Location = New System.Drawing.Point(243, 32)
        Me.ChkRtCore6.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtCore6.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore6.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore6.Name = "ChkRtCore6"
        Me.ChkRtCore6.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtCore6.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtCore6.TabIndex = 6
        Me.ChkRtCore6.Tag = "6"
        Me.ChkRtCore6.Text = "Wind Gust"
        Me.ChkRtCore6.UseVisualStyleBackColor = False
        '
        'ChkRtCore7
        '
        Me.ChkRtCore7.AutoCheck = False
        Me.ChkRtCore7.AutoSize = True
        Me.ChkRtCore7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtCore7.Enabled = False
        Me.ChkRtCore7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtCore7.Location = New System.Drawing.Point(480, 32)
        Me.ChkRtCore7.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtCore7.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore7.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore7.Name = "ChkRtCore7"
        Me.ChkRtCore7.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtCore7.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtCore7.TabIndex = 7
        Me.ChkRtCore7.Tag = "7"
        Me.ChkRtCore7.Text = "Barometer"
        Me.ChkRtCore7.UseVisualStyleBackColor = False
        '
        'ChkRtCore8
        '
        Me.ChkRtCore8.AutoSize = True
        Me.ChkRtCore8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtCore8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtCore8.Location = New System.Drawing.Point(717, 32)
        Me.ChkRtCore8.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtCore8.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore8.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore8.Name = "ChkRtCore8"
        Me.ChkRtCore8.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtCore8.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtCore8.TabIndex = 8
        Me.ChkRtCore8.Tag = "8"
        Me.ChkRtCore8.Text = "Precipitation"
        Me.ChkRtCore8.UseVisualStyleBackColor = False
        '
        'ChkRtCore9
        '
        Me.ChkRtCore9.AutoSize = True
        Me.ChkRtCore9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtCore9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtCore9.Location = New System.Drawing.Point(954, 32)
        Me.ChkRtCore9.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtCore9.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore9.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore9.Name = "ChkRtCore9"
        Me.ChkRtCore9.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtCore9.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtCore9.TabIndex = 9
        Me.ChkRtCore9.Tag = "9"
        Me.ChkRtCore9.Text = "Precip Type"
        Me.ChkRtCore9.UseVisualStyleBackColor = False
        '
        'ChkRtCore10
        '
        Me.ChkRtCore10.AutoCheck = False
        Me.ChkRtCore10.AutoSize = True
        Me.ChkRtCore10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtCore10.Enabled = False
        Me.ChkRtCore10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtCore10.Location = New System.Drawing.Point(6, 58)
        Me.ChkRtCore10.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtCore10.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore10.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore10.Name = "ChkRtCore10"
        Me.ChkRtCore10.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtCore10.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtCore10.TabIndex = 10
        Me.ChkRtCore10.Tag = "10"
        Me.ChkRtCore10.Text = "Precip Probability"
        Me.ChkRtCore10.UseVisualStyleBackColor = False
        '
        'ChkRtCore11
        '
        Me.ChkRtCore11.AutoCheck = False
        Me.ChkRtCore11.AutoSize = True
        Me.ChkRtCore11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtCore11.Enabled = False
        Me.ChkRtCore11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtCore11.Location = New System.Drawing.Point(243, 58)
        Me.ChkRtCore11.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtCore11.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore11.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore11.Name = "ChkRtCore11"
        Me.ChkRtCore11.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtCore11.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtCore11.TabIndex = 11
        Me.ChkRtCore11.Tag = "11"
        Me.ChkRtCore11.Text = "Precip Accumulation"
        Me.ChkRtCore11.UseVisualStyleBackColor = False
        '
        'ChkRtCore12
        '
        Me.ChkRtCore12.AutoSize = True
        Me.ChkRtCore12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtCore12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtCore12.Location = New System.Drawing.Point(480, 58)
        Me.ChkRtCore12.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtCore12.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore12.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore12.Name = "ChkRtCore12"
        Me.ChkRtCore12.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtCore12.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtCore12.TabIndex = 12
        Me.ChkRtCore12.Tag = "12"
        Me.ChkRtCore12.Text = "Sunrise"
        Me.ChkRtCore12.UseVisualStyleBackColor = False
        '
        'ChkRtCore13
        '
        Me.ChkRtCore13.AutoSize = True
        Me.ChkRtCore13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtCore13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtCore13.Location = New System.Drawing.Point(717, 58)
        Me.ChkRtCore13.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtCore13.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore13.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore13.Name = "ChkRtCore13"
        Me.ChkRtCore13.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtCore13.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtCore13.TabIndex = 13
        Me.ChkRtCore13.Tag = "13"
        Me.ChkRtCore13.Text = "Sunset"
        Me.ChkRtCore13.UseVisualStyleBackColor = False
        '
        'ChkRtCore14
        '
        Me.ChkRtCore14.AutoSize = True
        Me.ChkRtCore14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtCore14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtCore14.Location = New System.Drawing.Point(954, 58)
        Me.ChkRtCore14.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtCore14.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore14.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore14.Name = "ChkRtCore14"
        Me.ChkRtCore14.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtCore14.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtCore14.TabIndex = 14
        Me.ChkRtCore14.Tag = "14"
        Me.ChkRtCore14.Text = "Moon Phase"
        Me.ChkRtCore14.UseVisualStyleBackColor = False
        '
        'ChkRtCore15
        '
        Me.ChkRtCore15.AutoSize = True
        Me.ChkRtCore15.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtCore15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtCore15.Location = New System.Drawing.Point(6, 84)
        Me.ChkRtCore15.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtCore15.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore15.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore15.Name = "ChkRtCore15"
        Me.ChkRtCore15.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtCore15.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtCore15.TabIndex = 15
        Me.ChkRtCore15.Tag = "15"
        Me.ChkRtCore15.Text = "Visibility"
        Me.ChkRtCore15.UseVisualStyleBackColor = False
        '
        'ChkRtCore16
        '
        Me.ChkRtCore16.AutoSize = True
        Me.ChkRtCore16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtCore16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtCore16.Location = New System.Drawing.Point(243, 84)
        Me.ChkRtCore16.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtCore16.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore16.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore16.Name = "ChkRtCore16"
        Me.ChkRtCore16.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtCore16.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtCore16.TabIndex = 16
        Me.ChkRtCore16.Tag = "16"
        Me.ChkRtCore16.Text = "Cloud Cover"
        Me.ChkRtCore16.UseVisualStyleBackColor = False
        '
        'ChkRtCore17
        '
        Me.ChkRtCore17.AutoSize = True
        Me.ChkRtCore17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtCore17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtCore17.Location = New System.Drawing.Point(480, 84)
        Me.ChkRtCore17.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtCore17.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore17.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore17.Name = "ChkRtCore17"
        Me.ChkRtCore17.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtCore17.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtCore17.TabIndex = 17
        Me.ChkRtCore17.Tag = "17"
        Me.ChkRtCore17.Text = "Cloud Base"
        Me.ChkRtCore17.UseVisualStyleBackColor = False
        '
        'ChkRtCore18
        '
        Me.ChkRtCore18.AutoSize = True
        Me.ChkRtCore18.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtCore18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtCore18.Location = New System.Drawing.Point(717, 84)
        Me.ChkRtCore18.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtCore18.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore18.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore18.Name = "ChkRtCore18"
        Me.ChkRtCore18.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtCore18.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtCore18.TabIndex = 18
        Me.ChkRtCore18.Tag = "18"
        Me.ChkRtCore18.Text = "Cloud Ceiling"
        Me.ChkRtCore18.UseVisualStyleBackColor = False
        '
        'ChkRtCore19
        '
        Me.ChkRtCore19.AutoSize = True
        Me.ChkRtCore19.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtCore19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtCore19.Location = New System.Drawing.Point(954, 84)
        Me.ChkRtCore19.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtCore19.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore19.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore19.Name = "ChkRtCore19"
        Me.ChkRtCore19.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtCore19.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtCore19.TabIndex = 19
        Me.ChkRtCore19.Tag = "19"
        Me.ChkRtCore19.Text = "Surface Shortware Radiation"
        Me.ChkRtCore19.UseVisualStyleBackColor = False
        '
        'ChkRtCore20
        '
        Me.ChkRtCore20.AutoSize = True
        Me.ChkRtCore20.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtCore20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtCore20.Location = New System.Drawing.Point(6, 110)
        Me.ChkRtCore20.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtCore20.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore20.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtCore20.Name = "ChkRtCore20"
        Me.ChkRtCore20.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtCore20.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtCore20.TabIndex = 20
        Me.ChkRtCore20.Tag = "20"
        Me.ChkRtCore20.Text = "Weather Code"
        Me.ChkRtCore20.UseVisualStyleBackColor = False
        '
        'ChkRtPol0
        '
        Me.ChkRtPol0.AutoSize = True
        Me.ChkRtPol0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol0.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol0.Location = New System.Drawing.Point(243, 110)
        Me.ChkRtPol0.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol0.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol0.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol0.Name = "ChkRtPol0"
        Me.ChkRtPol0.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol0.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol0.TabIndex = 21
        Me.ChkRtPol0.Tag = "21"
        Me.ChkRtPol0.Text = "Tree Pollen"
        Me.ChkRtPol0.UseVisualStyleBackColor = False
        '
        'ChkRtPol1
        '
        Me.ChkRtPol1.AutoSize = True
        Me.ChkRtPol1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol1.Location = New System.Drawing.Point(480, 110)
        Me.ChkRtPol1.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol1.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol1.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol1.Name = "ChkRtPol1"
        Me.ChkRtPol1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol1.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol1.TabIndex = 22
        Me.ChkRtPol1.Tag = "22"
        Me.ChkRtPol1.Text = "Weed Pollen"
        Me.ChkRtPol1.UseVisualStyleBackColor = False
        '
        'ChkRtPol2
        '
        Me.ChkRtPol2.AutoSize = True
        Me.ChkRtPol2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol2.Location = New System.Drawing.Point(717, 110)
        Me.ChkRtPol2.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol2.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol2.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol2.Name = "ChkRtPol2"
        Me.ChkRtPol2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol2.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol2.TabIndex = 23
        Me.ChkRtPol2.Tag = "23"
        Me.ChkRtPol2.Text = "Grass Pollen"
        Me.ChkRtPol2.UseVisualStyleBackColor = False
        '
        'ChkRtPol3
        '
        Me.ChkRtPol3.AutoSize = True
        Me.ChkRtPol3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol3.Location = New System.Drawing.Point(954, 110)
        Me.ChkRtPol3.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol3.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol3.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol3.Name = "ChkRtPol3"
        Me.ChkRtPol3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol3.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol3.TabIndex = 24
        Me.ChkRtPol3.Tag = "24"
        Me.ChkRtPol3.Text = "Ragweed"
        Me.ChkRtPol3.UseVisualStyleBackColor = False
        '
        'ChkRtPol4
        '
        Me.ChkRtPol4.AutoSize = True
        Me.ChkRtPol4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol4.Location = New System.Drawing.Point(6, 136)
        Me.ChkRtPol4.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol4.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol4.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol4.Name = "ChkRtPol4"
        Me.ChkRtPol4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol4.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol4.TabIndex = 25
        Me.ChkRtPol4.Tag = "25"
        Me.ChkRtPol4.Text = "Grass"
        Me.ChkRtPol4.UseVisualStyleBackColor = False
        '
        'ChkRtPol5
        '
        Me.ChkRtPol5.AutoSize = True
        Me.ChkRtPol5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol5.Location = New System.Drawing.Point(243, 136)
        Me.ChkRtPol5.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol5.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol5.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol5.Name = "ChkRtPol5"
        Me.ChkRtPol5.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol5.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol5.TabIndex = 26
        Me.ChkRtPol5.Tag = "26"
        Me.ChkRtPol5.Text = "Acacia"
        Me.ChkRtPol5.UseVisualStyleBackColor = False
        '
        'ChkRtPol6
        '
        Me.ChkRtPol6.AutoSize = True
        Me.ChkRtPol6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol6.Location = New System.Drawing.Point(480, 136)
        Me.ChkRtPol6.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol6.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol6.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol6.Name = "ChkRtPol6"
        Me.ChkRtPol6.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol6.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol6.TabIndex = 27
        Me.ChkRtPol6.Tag = "27"
        Me.ChkRtPol6.Text = "Ash"
        Me.ChkRtPol6.UseVisualStyleBackColor = False
        '
        'ChkRtPol7
        '
        Me.ChkRtPol7.AutoSize = True
        Me.ChkRtPol7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol7.Location = New System.Drawing.Point(717, 136)
        Me.ChkRtPol7.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol7.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol7.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol7.Name = "ChkRtPol7"
        Me.ChkRtPol7.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol7.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol7.TabIndex = 28
        Me.ChkRtPol7.Tag = "28"
        Me.ChkRtPol7.Text = "Beech"
        Me.ChkRtPol7.UseVisualStyleBackColor = False
        '
        'ChkRtPol8
        '
        Me.ChkRtPol8.AutoSize = True
        Me.ChkRtPol8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol8.Location = New System.Drawing.Point(954, 136)
        Me.ChkRtPol8.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol8.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol8.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol8.Name = "ChkRtPol8"
        Me.ChkRtPol8.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol8.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol8.TabIndex = 29
        Me.ChkRtPol8.Tag = "29"
        Me.ChkRtPol8.Text = "Birch"
        Me.ChkRtPol8.UseVisualStyleBackColor = False
        '
        'ChkRtPol9
        '
        Me.ChkRtPol9.AutoSize = True
        Me.ChkRtPol9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol9.Location = New System.Drawing.Point(6, 162)
        Me.ChkRtPol9.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol9.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol9.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol9.Name = "ChkRtPol9"
        Me.ChkRtPol9.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol9.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol9.TabIndex = 30
        Me.ChkRtPol9.Tag = "30"
        Me.ChkRtPol9.Text = "Cedar"
        Me.ChkRtPol9.UseVisualStyleBackColor = False
        '
        'ChkRtPol10
        '
        Me.ChkRtPol10.AutoSize = True
        Me.ChkRtPol10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol10.Location = New System.Drawing.Point(243, 162)
        Me.ChkRtPol10.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol10.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol10.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol10.Name = "ChkRtPol10"
        Me.ChkRtPol10.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol10.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol10.TabIndex = 31
        Me.ChkRtPol10.Tag = "31"
        Me.ChkRtPol10.Text = "Cypress"
        Me.ChkRtPol10.UseVisualStyleBackColor = False
        '
        'ChkRtPol11
        '
        Me.ChkRtPol11.AutoSize = True
        Me.ChkRtPol11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol11.Location = New System.Drawing.Point(480, 162)
        Me.ChkRtPol11.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol11.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol11.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol11.Name = "ChkRtPol11"
        Me.ChkRtPol11.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol11.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol11.TabIndex = 32
        Me.ChkRtPol11.Tag = "32"
        Me.ChkRtPol11.Text = "Elder"
        Me.ChkRtPol11.UseVisualStyleBackColor = False
        '
        'ChkRtPol12
        '
        Me.ChkRtPol12.AutoSize = True
        Me.ChkRtPol12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol12.Location = New System.Drawing.Point(717, 162)
        Me.ChkRtPol12.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol12.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol12.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol12.Name = "ChkRtPol12"
        Me.ChkRtPol12.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol12.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol12.TabIndex = 33
        Me.ChkRtPol12.Tag = "33"
        Me.ChkRtPol12.Text = "Elm"
        Me.ChkRtPol12.UseVisualStyleBackColor = False
        '
        'ChkRtPol13
        '
        Me.ChkRtPol13.AutoSize = True
        Me.ChkRtPol13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol13.Location = New System.Drawing.Point(954, 162)
        Me.ChkRtPol13.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol13.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol13.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol13.Name = "ChkRtPol13"
        Me.ChkRtPol13.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol13.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol13.TabIndex = 34
        Me.ChkRtPol13.Tag = "34"
        Me.ChkRtPol13.Text = "Hemlock"
        Me.ChkRtPol13.UseVisualStyleBackColor = False
        '
        'ChkRtPol14
        '
        Me.ChkRtPol14.AutoSize = True
        Me.ChkRtPol14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol14.Location = New System.Drawing.Point(6, 188)
        Me.ChkRtPol14.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol14.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol14.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol14.Name = "ChkRtPol14"
        Me.ChkRtPol14.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol14.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol14.TabIndex = 35
        Me.ChkRtPol14.Tag = "35"
        Me.ChkRtPol14.Text = "Hickory"
        Me.ChkRtPol14.UseVisualStyleBackColor = False
        '
        'ChkRtPol15
        '
        Me.ChkRtPol15.AutoSize = True
        Me.ChkRtPol15.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol15.Location = New System.Drawing.Point(243, 188)
        Me.ChkRtPol15.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol15.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol15.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol15.Name = "ChkRtPol15"
        Me.ChkRtPol15.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol15.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol15.TabIndex = 36
        Me.ChkRtPol15.Tag = "36"
        Me.ChkRtPol15.Text = "Juniper"
        Me.ChkRtPol15.UseVisualStyleBackColor = False
        '
        'ChkRtPol16
        '
        Me.ChkRtPol16.AutoSize = True
        Me.ChkRtPol16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol16.Location = New System.Drawing.Point(480, 188)
        Me.ChkRtPol16.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol16.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol16.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol16.Name = "ChkRtPol16"
        Me.ChkRtPol16.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol16.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol16.TabIndex = 37
        Me.ChkRtPol16.Tag = "37"
        Me.ChkRtPol16.Text = "Mahogany"
        Me.ChkRtPol16.UseVisualStyleBackColor = False
        '
        'ChkRtPol17
        '
        Me.ChkRtPol17.AutoSize = True
        Me.ChkRtPol17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol17.Location = New System.Drawing.Point(717, 188)
        Me.ChkRtPol17.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol17.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol17.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol17.Name = "ChkRtPol17"
        Me.ChkRtPol17.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol17.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol17.TabIndex = 38
        Me.ChkRtPol17.Tag = "38"
        Me.ChkRtPol17.Text = "Maple"
        Me.ChkRtPol17.UseVisualStyleBackColor = False
        '
        'ChkRtPol18
        '
        Me.ChkRtPol18.AutoSize = True
        Me.ChkRtPol18.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol18.Location = New System.Drawing.Point(954, 188)
        Me.ChkRtPol18.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol18.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol18.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol18.Name = "ChkRtPol18"
        Me.ChkRtPol18.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol18.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol18.TabIndex = 39
        Me.ChkRtPol18.Tag = "39"
        Me.ChkRtPol18.Text = "Mulberry"
        Me.ChkRtPol18.UseVisualStyleBackColor = False
        '
        'ChkRtPol19
        '
        Me.ChkRtPol19.AutoSize = True
        Me.ChkRtPol19.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol19.Location = New System.Drawing.Point(6, 214)
        Me.ChkRtPol19.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol19.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol19.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol19.Name = "ChkRtPol19"
        Me.ChkRtPol19.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol19.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol19.TabIndex = 40
        Me.ChkRtPol19.Tag = "40"
        Me.ChkRtPol19.Text = "Oak"
        Me.ChkRtPol19.UseVisualStyleBackColor = False
        '
        'ChkRtPol20
        '
        Me.ChkRtPol20.AutoSize = True
        Me.ChkRtPol20.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol20.Location = New System.Drawing.Point(243, 214)
        Me.ChkRtPol20.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol20.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol20.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol20.Name = "ChkRtPol20"
        Me.ChkRtPol20.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol20.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol20.TabIndex = 41
        Me.ChkRtPol20.Tag = "41"
        Me.ChkRtPol20.Text = "Pine"
        Me.ChkRtPol20.UseVisualStyleBackColor = False
        '
        'ChkRtPol21
        '
        Me.ChkRtPol21.AutoSize = True
        Me.ChkRtPol21.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol21.Location = New System.Drawing.Point(480, 214)
        Me.ChkRtPol21.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol21.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol21.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol21.Name = "ChkRtPol21"
        Me.ChkRtPol21.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol21.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol21.TabIndex = 42
        Me.ChkRtPol21.Tag = "42"
        Me.ChkRtPol21.Text = "Cottonwood"
        Me.ChkRtPol21.UseVisualStyleBackColor = False
        '
        'ChkRtPol22
        '
        Me.ChkRtPol22.AutoSize = True
        Me.ChkRtPol22.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol22.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol22.Location = New System.Drawing.Point(717, 214)
        Me.ChkRtPol22.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol22.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol22.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol22.Name = "ChkRtPol22"
        Me.ChkRtPol22.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol22.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol22.TabIndex = 43
        Me.ChkRtPol22.Tag = "43"
        Me.ChkRtPol22.Text = "Spruce"
        Me.ChkRtPol22.UseVisualStyleBackColor = False
        '
        'ChkRtPol23
        '
        Me.ChkRtPol23.AutoSize = True
        Me.ChkRtPol23.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol23.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol23.Location = New System.Drawing.Point(954, 214)
        Me.ChkRtPol23.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol23.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol23.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol23.Name = "ChkRtPol23"
        Me.ChkRtPol23.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol23.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol23.TabIndex = 44
        Me.ChkRtPol23.Tag = "44"
        Me.ChkRtPol23.Text = "Sycamore"
        Me.ChkRtPol23.UseVisualStyleBackColor = False
        '
        'ChkRtPol24
        '
        Me.ChkRtPol24.AutoSize = True
        Me.ChkRtPol24.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol24.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol24.Location = New System.Drawing.Point(6, 240)
        Me.ChkRtPol24.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol24.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol24.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol24.Name = "ChkRtPol24"
        Me.ChkRtPol24.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol24.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol24.TabIndex = 45
        Me.ChkRtPol24.Tag = "45"
        Me.ChkRtPol24.Text = "Walnut"
        Me.ChkRtPol24.UseVisualStyleBackColor = False
        '
        'ChkRtPol25
        '
        Me.ChkRtPol25.AutoSize = True
        Me.ChkRtPol25.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtPol25.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtPol25.Location = New System.Drawing.Point(243, 240)
        Me.ChkRtPol25.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtPol25.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol25.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtPol25.Name = "ChkRtPol25"
        Me.ChkRtPol25.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtPol25.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtPol25.TabIndex = 46
        Me.ChkRtPol25.Tag = "46"
        Me.ChkRtPol25.Text = "Willow"
        Me.ChkRtPol25.UseVisualStyleBackColor = False
        '
        'ChkRtRoad0
        '
        Me.ChkRtRoad0.AutoSize = True
        Me.ChkRtRoad0.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtRoad0.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtRoad0.Location = New System.Drawing.Point(480, 240)
        Me.ChkRtRoad0.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtRoad0.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtRoad0.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtRoad0.Name = "ChkRtRoad0"
        Me.ChkRtRoad0.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtRoad0.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtRoad0.TabIndex = 47
        Me.ChkRtRoad0.Tag = "47"
        Me.ChkRtRoad0.Text = "Road Risk Score"
        Me.ChkRtRoad0.UseVisualStyleBackColor = False
        '
        'ChkRtRoad1
        '
        Me.ChkRtRoad1.AutoSize = True
        Me.ChkRtRoad1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtRoad1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtRoad1.Location = New System.Drawing.Point(717, 240)
        Me.ChkRtRoad1.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtRoad1.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtRoad1.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtRoad1.Name = "ChkRtRoad1"
        Me.ChkRtRoad1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtRoad1.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtRoad1.TabIndex = 48
        Me.ChkRtRoad1.Tag = "48"
        Me.ChkRtRoad1.Text = "Road Risk"
        Me.ChkRtRoad1.UseVisualStyleBackColor = False
        '
        'ChkRtRoad2
        '
        Me.ChkRtRoad2.AutoSize = True
        Me.ChkRtRoad2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtRoad2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtRoad2.Location = New System.Drawing.Point(954, 240)
        Me.ChkRtRoad2.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtRoad2.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtRoad2.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtRoad2.Name = "ChkRtRoad2"
        Me.ChkRtRoad2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtRoad2.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtRoad2.TabIndex = 49
        Me.ChkRtRoad2.Tag = "49"
        Me.ChkRtRoad2.Text = "Road Risk Confidence"
        Me.ChkRtRoad2.UseVisualStyleBackColor = False
        '
        'ChkRtRoad3
        '
        Me.ChkRtRoad3.AutoSize = True
        Me.ChkRtRoad3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkRtRoad3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtRoad3.Location = New System.Drawing.Point(6, 266)
        Me.ChkRtRoad3.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtRoad3.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtRoad3.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtRoad3.Name = "ChkRtRoad3"
        Me.ChkRtRoad3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtRoad3.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtRoad3.TabIndex = 50
        Me.ChkRtRoad3.Tag = "50"
        Me.ChkRtRoad3.Text = "Road Risk Conditions"
        Me.ChkRtRoad3.UseVisualStyleBackColor = False
        '
        'ChkRtFire0
        '
        Me.ChkRtFire0.AutoSize = True
        Me.ChkRtFire0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtFire0.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtFire0.Location = New System.Drawing.Point(243, 266)
        Me.ChkRtFire0.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtFire0.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtFire0.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtFire0.Name = "ChkRtFire0"
        Me.ChkRtFire0.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtFire0.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtFire0.TabIndex = 51
        Me.ChkRtFire0.Tag = "51"
        Me.ChkRtFire0.Text = "Fire Index"
        Me.ChkRtFire0.UseVisualStyleBackColor = False
        '
        'ChkRtHail0
        '
        Me.ChkRtHail0.AutoSize = True
        Me.ChkRtHail0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtHail0.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtHail0.Location = New System.Drawing.Point(480, 266)
        Me.ChkRtHail0.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtHail0.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtHail0.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtHail0.Name = "ChkRtHail0"
        Me.ChkRtHail0.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtHail0.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtHail0.TabIndex = 52
        Me.ChkRtHail0.Tag = "52"
        Me.ChkRtHail0.Text = "Hail Risk"
        Me.ChkRtHail0.UseVisualStyleBackColor = False
        '
        'ChkRtAqi0
        '
        Me.ChkRtAqi0.AutoSize = True
        Me.ChkRtAqi0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtAqi0.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtAqi0.Location = New System.Drawing.Point(717, 266)
        Me.ChkRtAqi0.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtAqi0.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi0.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi0.Name = "ChkRtAqi0"
        Me.ChkRtAqi0.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtAqi0.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi0.TabIndex = 53
        Me.ChkRtAqi0.Tag = "53"
        Me.ChkRtAqi0.Text = "PM25"
        Me.ChkRtAqi0.UseVisualStyleBackColor = False
        '
        'ChkRtAqi1
        '
        Me.ChkRtAqi1.AutoSize = True
        Me.ChkRtAqi1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtAqi1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtAqi1.Location = New System.Drawing.Point(954, 266)
        Me.ChkRtAqi1.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtAqi1.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi1.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi1.Name = "ChkRtAqi1"
        Me.ChkRtAqi1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtAqi1.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi1.TabIndex = 54
        Me.ChkRtAqi1.Tag = "54"
        Me.ChkRtAqi1.Text = "PM10"
        Me.ChkRtAqi1.UseVisualStyleBackColor = False
        '
        'ChkRtAqi2
        '
        Me.ChkRtAqi2.AutoSize = True
        Me.ChkRtAqi2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtAqi2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtAqi2.Location = New System.Drawing.Point(6, 292)
        Me.ChkRtAqi2.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtAqi2.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi2.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi2.Name = "ChkRtAqi2"
        Me.ChkRtAqi2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtAqi2.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi2.TabIndex = 55
        Me.ChkRtAqi2.Tag = "55"
        Me.ChkRtAqi2.Text = "O3"
        Me.ChkRtAqi2.UseVisualStyleBackColor = False
        '
        'ChkRtAqi3
        '
        Me.ChkRtAqi3.AutoSize = True
        Me.ChkRtAqi3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtAqi3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtAqi3.Location = New System.Drawing.Point(243, 292)
        Me.ChkRtAqi3.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtAqi3.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi3.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi3.Name = "ChkRtAqi3"
        Me.ChkRtAqi3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtAqi3.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi3.TabIndex = 56
        Me.ChkRtAqi3.Tag = "56"
        Me.ChkRtAqi3.Text = "NO2"
        Me.ChkRtAqi3.UseVisualStyleBackColor = False
        '
        'ChkRtAqi4
        '
        Me.ChkRtAqi4.AutoSize = True
        Me.ChkRtAqi4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtAqi4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtAqi4.Location = New System.Drawing.Point(480, 292)
        Me.ChkRtAqi4.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtAqi4.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi4.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi4.Name = "ChkRtAqi4"
        Me.ChkRtAqi4.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtAqi4.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi4.TabIndex = 57
        Me.ChkRtAqi4.Tag = "57"
        Me.ChkRtAqi4.Text = "CO"
        Me.ChkRtAqi4.UseVisualStyleBackColor = False
        '
        'ChkRtAqi5
        '
        Me.ChkRtAqi5.AutoSize = True
        Me.ChkRtAqi5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtAqi5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtAqi5.Location = New System.Drawing.Point(717, 292)
        Me.ChkRtAqi5.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtAqi5.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi5.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi5.Name = "ChkRtAqi5"
        Me.ChkRtAqi5.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtAqi5.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi5.TabIndex = 58
        Me.ChkRtAqi5.Tag = "58"
        Me.ChkRtAqi5.Text = "SO2"
        Me.ChkRtAqi5.UseVisualStyleBackColor = False
        '
        'ChkRtAqi6
        '
        Me.ChkRtAqi6.AutoSize = True
        Me.ChkRtAqi6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtAqi6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtAqi6.Location = New System.Drawing.Point(954, 292)
        Me.ChkRtAqi6.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtAqi6.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi6.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi6.Name = "ChkRtAqi6"
        Me.ChkRtAqi6.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtAqi6.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi6.TabIndex = 59
        Me.ChkRtAqi6.Tag = "59"
        Me.ChkRtAqi6.Text = "Epa Aqi"
        Me.ChkRtAqi6.UseVisualStyleBackColor = False
        '
        'ChkRtAqi7
        '
        Me.ChkRtAqi7.AutoSize = True
        Me.ChkRtAqi7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtAqi7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtAqi7.Location = New System.Drawing.Point(6, 318)
        Me.ChkRtAqi7.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtAqi7.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi7.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi7.Name = "ChkRtAqi7"
        Me.ChkRtAqi7.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtAqi7.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi7.TabIndex = 60
        Me.ChkRtAqi7.Tag = "60"
        Me.ChkRtAqi7.Text = "Epa Primary Pollutant"
        Me.ChkRtAqi7.UseVisualStyleBackColor = False
        '
        'ChkRtAqi8
        '
        Me.ChkRtAqi8.AutoSize = True
        Me.ChkRtAqi8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtAqi8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtAqi8.Location = New System.Drawing.Point(243, 318)
        Me.ChkRtAqi8.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtAqi8.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi8.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi8.Name = "ChkRtAqi8"
        Me.ChkRtAqi8.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtAqi8.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi8.TabIndex = 61
        Me.ChkRtAqi8.Tag = "61"
        Me.ChkRtAqi8.Text = "Epa Health Concern"
        Me.ChkRtAqi8.UseVisualStyleBackColor = False
        '
        'ChkRtAqi9
        '
        Me.ChkRtAqi9.AutoSize = True
        Me.ChkRtAqi9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtAqi9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtAqi9.Location = New System.Drawing.Point(480, 318)
        Me.ChkRtAqi9.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtAqi9.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi9.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi9.Name = "ChkRtAqi9"
        Me.ChkRtAqi9.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtAqi9.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi9.TabIndex = 62
        Me.ChkRtAqi9.Tag = "62"
        Me.ChkRtAqi9.Text = "China Aqi"
        Me.ChkRtAqi9.UseVisualStyleBackColor = False
        '
        'ChkRtAqi10
        '
        Me.ChkRtAqi10.AutoSize = True
        Me.ChkRtAqi10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtAqi10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtAqi10.Location = New System.Drawing.Point(717, 318)
        Me.ChkRtAqi10.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtAqi10.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi10.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi10.Name = "ChkRtAqi10"
        Me.ChkRtAqi10.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtAqi10.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi10.TabIndex = 63
        Me.ChkRtAqi10.Tag = "63"
        Me.ChkRtAqi10.Text = "China Primary Pollutant"
        Me.ChkRtAqi10.UseVisualStyleBackColor = False
        '
        'ChkRtAqi11
        '
        Me.ChkRtAqi11.AutoSize = True
        Me.ChkRtAqi11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ChkRtAqi11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkRtAqi11.Location = New System.Drawing.Point(954, 318)
        Me.ChkRtAqi11.Margin = New System.Windows.Forms.Padding(1)
        Me.ChkRtAqi11.MaximumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi11.MinimumSize = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi11.Name = "ChkRtAqi11"
        Me.ChkRtAqi11.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.ChkRtAqi11.Size = New System.Drawing.Size(235, 24)
        Me.ChkRtAqi11.TabIndex = 64
        Me.ChkRtAqi11.Tag = "64"
        Me.ChkRtAqi11.Text = "China Health Concern"
        Me.ChkRtAqi11.UseVisualStyleBackColor = False
        '
        'TpLogs
        '
        Me.TpLogs.Controls.Add(Me.TcLogs)
        Me.TpLogs.Location = New System.Drawing.Point(4, 29)
        Me.TpLogs.Name = "TpLogs"
        Me.TpLogs.Padding = New System.Windows.Forms.Padding(3)
        Me.TpLogs.Size = New System.Drawing.Size(1392, 1037)
        Me.TpLogs.TabIndex = 1
        Me.TpLogs.Text = "Logs"
        Me.TpLogs.UseVisualStyleBackColor = True
        '
        'TcLogs
        '
        Me.TcLogs.Alignment = System.Windows.Forms.TabAlignment.Right
        Me.TcLogs.Controls.Add(Me.TpLogLog)
        Me.TcLogs.Controls.Add(Me.TpLogError)
        Me.TcLogs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TcLogs.Location = New System.Drawing.Point(3, 3)
        Me.TcLogs.Multiline = True
        Me.TcLogs.Name = "TcLogs"
        Me.TcLogs.SelectedIndex = 0
        Me.TcLogs.Size = New System.Drawing.Size(1386, 1031)
        Me.TcLogs.TabIndex = 0
        '
        'TpLogLog
        '
        Me.TpLogLog.Controls.Add(Me.RtbLog)
        Me.TpLogLog.Location = New System.Drawing.Point(4, 4)
        Me.TpLogLog.Name = "TpLogLog"
        Me.TpLogLog.Padding = New System.Windows.Forms.Padding(3)
        Me.TpLogLog.Size = New System.Drawing.Size(1354, 1023)
        Me.TpLogLog.TabIndex = 0
        Me.TpLogLog.Text = "Log"
        Me.TpLogLog.UseVisualStyleBackColor = True
        '
        'RtbLog
        '
        Me.RtbLog.BackColor = System.Drawing.SystemColors.Info
        Me.RtbLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RtbLog.Location = New System.Drawing.Point(3, 3)
        Me.RtbLog.Name = "RtbLog"
        Me.RtbLog.ReadOnly = True
        Me.RtbLog.ShowSelectionMargin = True
        Me.RtbLog.Size = New System.Drawing.Size(1348, 1017)
        Me.RtbLog.TabIndex = 0
        Me.RtbLog.Text = ""
        '
        'TpLogError
        '
        Me.TpLogError.Controls.Add(Me.RtbError)
        Me.TpLogError.Location = New System.Drawing.Point(4, 4)
        Me.TpLogError.Name = "TpLogError"
        Me.TpLogError.Size = New System.Drawing.Size(1354, 1023)
        Me.TpLogError.TabIndex = 2
        Me.TpLogError.Text = "Error"
        Me.TpLogError.UseVisualStyleBackColor = True
        '
        'RtbError
        '
        Me.RtbError.BackColor = System.Drawing.SystemColors.Info
        Me.RtbError.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RtbError.Location = New System.Drawing.Point(0, 0)
        Me.RtbError.Name = "RtbError"
        Me.RtbError.ReadOnly = True
        Me.RtbError.ShowSelectionMargin = True
        Me.RtbError.Size = New System.Drawing.Size(1354, 1023)
        Me.RtbError.TabIndex = 1
        Me.RtbError.Text = ""
        '
        'TpNowcast
        '
        Me.TpNowcast.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TpNowcast.Controls.Add(Me.DgvNowcast)
        Me.TpNowcast.Location = New System.Drawing.Point(4, 29)
        Me.TpNowcast.Name = "TpNowcast"
        Me.TpNowcast.Size = New System.Drawing.Size(1392, 1037)
        Me.TpNowcast.TabIndex = 6
        Me.TpNowcast.Text = "Nowcast"
        '
        'DgvNowcast
        '
        Me.DgvNowcast.AllowUserToAddRows = False
        Me.DgvNowcast.AllowUserToDeleteRows = False
        Me.DgvNowcast.AllowUserToResizeColumns = False
        Me.DgvNowcast.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvNowcast.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvNowcast.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvNowcast.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.DgvNowcast.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DgvNowcast.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DgvNowcast.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DgvNowcast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvNowcast.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.c1, Me.c2, Me.c3, Me.c4})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvNowcast.DefaultCellStyle = DataGridViewCellStyle8
        Me.DgvNowcast.Dock = System.Windows.Forms.DockStyle.Top
        Me.DgvNowcast.Location = New System.Drawing.Point(0, 0)
        Me.DgvNowcast.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.DgvNowcast.MultiSelect = False
        Me.DgvNowcast.Name = "DgvNowcast"
        Me.DgvNowcast.ReadOnly = True
        Me.DgvNowcast.RowHeadersVisible = False
        Me.DgvNowcast.RowHeadersWidth = 62
        Me.DgvNowcast.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvNowcast.RowTemplate.Height = 125
        Me.DgvNowcast.RowTemplate.ReadOnly = True
        Me.DgvNowcast.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvNowcast.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvNowcast.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvNowcast.ShowEditingIcon = False
        Me.DgvNowcast.Size = New System.Drawing.Size(1392, 1004)
        Me.DgvNowcast.TabIndex = 6
        '
        'c1
        '
        Me.c1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.c1.HeaderText = "Day"
        Me.c1.MinimumWidth = 8
        Me.c1.Name = "c1"
        Me.c1.ReadOnly = True
        Me.c1.Width = 69
        '
        'c2
        '
        Me.c2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.c2.HeaderText = "Time"
        Me.c2.MinimumWidth = 8
        Me.c2.Name = "c2"
        Me.c2.ReadOnly = True
        Me.c2.Width = 75
        '
        'c3
        '
        Me.c3.HeaderText = "Weather"
        Me.c3.MinimumWidth = 8
        Me.c3.Name = "c3"
        Me.c3.ReadOnly = True
        Me.c3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.c3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'c4
        '
        Me.c4.HeaderText = "Forecast"
        Me.c4.MinimumWidth = 8
        Me.c4.Name = "c4"
        Me.c4.ReadOnly = True
        '
        'TpHourly
        '
        Me.TpHourly.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TpHourly.Controls.Add(Me.DgvHourly)
        Me.TpHourly.Location = New System.Drawing.Point(4, 29)
        Me.TpHourly.Name = "TpHourly"
        Me.TpHourly.Size = New System.Drawing.Size(1392, 1037)
        Me.TpHourly.TabIndex = 5
        Me.TpHourly.Text = "Hourly"
        '
        'DgvHourly
        '
        Me.DgvHourly.AllowUserToAddRows = False
        Me.DgvHourly.AllowUserToDeleteRows = False
        Me.DgvHourly.AllowUserToResizeColumns = False
        Me.DgvHourly.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvHourly.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvHourly.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvHourly.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.DgvHourly.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DgvHourly.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DgvHourly.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvHourly.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvHourly.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.hr0, Me.hr1, Me.hr2, Me.hr3})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvHourly.DefaultCellStyle = DataGridViewCellStyle5
        Me.DgvHourly.Dock = System.Windows.Forms.DockStyle.Top
        Me.DgvHourly.Location = New System.Drawing.Point(0, 0)
        Me.DgvHourly.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.DgvHourly.MultiSelect = False
        Me.DgvHourly.Name = "DgvHourly"
        Me.DgvHourly.ReadOnly = True
        Me.DgvHourly.RowHeadersVisible = False
        Me.DgvHourly.RowHeadersWidth = 62
        Me.DgvHourly.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvHourly.RowTemplate.Height = 125
        Me.DgvHourly.RowTemplate.ReadOnly = True
        Me.DgvHourly.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvHourly.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DgvHourly.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvHourly.ShowEditingIcon = False
        Me.DgvHourly.Size = New System.Drawing.Size(1392, 1004)
        Me.DgvHourly.TabIndex = 6
        '
        'hr0
        '
        Me.hr0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.hr0.HeaderText = "Day"
        Me.hr0.MinimumWidth = 8
        Me.hr0.Name = "hr0"
        Me.hr0.ReadOnly = True
        Me.hr0.Width = 69
        '
        'hr1
        '
        Me.hr1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.hr1.HeaderText = "Hour"
        Me.hr1.MinimumWidth = 8
        Me.hr1.Name = "hr1"
        Me.hr1.ReadOnly = True
        Me.hr1.Width = 75
        '
        'hr2
        '
        Me.hr2.HeaderText = "Weather"
        Me.hr2.MinimumWidth = 8
        Me.hr2.Name = "hr2"
        Me.hr2.ReadOnly = True
        Me.hr2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.hr2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'hr3
        '
        Me.hr3.HeaderText = "Forecast"
        Me.hr3.MinimumWidth = 8
        Me.hr3.Name = "hr3"
        Me.hr3.ReadOnly = True
        '
        'TpDaily
        '
        Me.TpDaily.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TpDaily.Controls.Add(Me.DgvDaily)
        Me.TpDaily.Location = New System.Drawing.Point(4, 29)
        Me.TpDaily.Name = "TpDaily"
        Me.TpDaily.Padding = New System.Windows.Forms.Padding(3)
        Me.TpDaily.Size = New System.Drawing.Size(1392, 1037)
        Me.TpDaily.TabIndex = 0
        Me.TpDaily.Text = "Daily"
        '
        'DgvDaily
        '
        Me.DgvDaily.AllowUserToAddRows = False
        Me.DgvDaily.AllowUserToDeleteRows = False
        Me.DgvDaily.AllowUserToResizeColumns = False
        Me.DgvDaily.AllowUserToResizeRows = False
        Me.DgvDaily.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvDaily.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.DgvDaily.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DgvDaily.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DgvDaily.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDaily.ColumnHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDaily.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvDaily.Dock = System.Windows.Forms.DockStyle.Top
        Me.DgvDaily.Enabled = False
        Me.DgvDaily.EnableHeadersVisualStyles = False
        Me.DgvDaily.Location = New System.Drawing.Point(3, 3)
        Me.DgvDaily.Margin = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.DgvDaily.MultiSelect = False
        Me.DgvDaily.Name = "DgvDaily"
        Me.DgvDaily.ReadOnly = True
        Me.DgvDaily.RowHeadersVisible = False
        Me.DgvDaily.RowHeadersWidth = 62
        Me.DgvDaily.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvDaily.RowTemplate.Height = 30
        Me.DgvDaily.RowTemplate.ReadOnly = True
        Me.DgvDaily.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvDaily.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DgvDaily.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvDaily.ShowEditingIcon = False
        Me.DgvDaily.Size = New System.Drawing.Size(1386, 1004)
        Me.DgvDaily.TabIndex = 5
        '
        'TC
        '
        Me.TC.Controls.Add(Me.TpDaily)
        Me.TC.Controls.Add(Me.TpHourly)
        Me.TC.Controls.Add(Me.TpNowcast)
        Me.TC.Controls.Add(Me.TpRealtime)
        Me.TC.Controls.Add(Me.TpOptions)
        Me.TC.Controls.Add(Me.TpLogs)
        Me.TC.Controls.Add(Me.TpAbout)
        Me.TC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TC.Location = New System.Drawing.Point(0, 0)
        Me.TC.Name = "TC"
        Me.TC.SelectedIndex = 0
        Me.TC.Size = New System.Drawing.Size(1400, 1070)
        Me.TC.TabIndex = 5
        '
        'TpRealtime
        '
        Me.TpRealtime.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TpRealtime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TpRealtime.Controls.Add(Me.DgvRt)
        Me.TpRealtime.Location = New System.Drawing.Point(4, 29)
        Me.TpRealtime.Name = "TpRealtime"
        Me.TpRealtime.Size = New System.Drawing.Size(1392, 1037)
        Me.TpRealtime.TabIndex = 7
        Me.TpRealtime.Text = "Realtime"
        '
        'DgvRt
        '
        Me.DgvRt.AllowUserToAddRows = False
        Me.DgvRt.AllowUserToDeleteRows = False
        Me.DgvRt.AllowUserToResizeColumns = False
        Me.DgvRt.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvRt.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DgvRt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvRt.BackgroundColor = System.Drawing.Color.LightSkyBlue
        Me.DgvRt.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.InactiveBorder
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvRt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DgvRt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rt0, Me.rt1})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvRt.DefaultCellStyle = DataGridViewCellStyle13
        Me.DgvRt.Location = New System.Drawing.Point(314, 42)
        Me.DgvRt.Name = "DgvRt"
        Me.DgvRt.RowHeadersVisible = False
        Me.DgvRt.RowHeadersWidth = 62
        Me.DgvRt.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DgvRt.RowTemplate.Height = 28
        Me.DgvRt.RowTemplate.ReadOnly = True
        Me.DgvRt.Size = New System.Drawing.Size(760, 948)
        Me.DgvRt.TabIndex = 0
        '
        'rt0
        '
        Me.rt0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        Me.rt0.DefaultCellStyle = DataGridViewCellStyle11
        Me.rt0.FillWeight = 170.4545!
        Me.rt0.HeaderText = "Name"
        Me.rt0.MinimumWidth = 150
        Me.rt0.Name = "rt0"
        Me.rt0.Width = 150
        '
        'rt1
        '
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.rt1.DefaultCellStyle = DataGridViewCellStyle12
        Me.rt1.FillWeight = 29.54545!
        Me.rt1.HeaderText = "Value"
        Me.rt1.MinimumWidth = 250
        Me.rt1.Name = "rt1"
        '
        'TmrClock
        '
        Me.TmrClock.Interval = 999.0R
        Me.TmrClock.SynchronizingObject = Me
        '
        'TmrUpdateDaily
        '
        Me.TmrUpdateDaily.SynchronizingObject = Me
        '
        'TmrMidnight
        '
        Me.TmrMidnight.SynchronizingObject = Me
        '
        'TmrUpdateRt
        '
        Me.TmrUpdateRt.SynchronizingObject = Me
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1400, 1070)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TC)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.psClimaCell.My.MySettings.Default, "MainFormLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = Global.psClimaCell.My.MySettings.Default.MainFormLocation
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1422, 1126)
        Me.MinimumSize = New System.Drawing.Size(1422, 1126)
        Me.Name = "FrmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Form1"
        CType(Me.TmrUpdateNowcast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TmrUpdateHourly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TpAbout.ResumeLayout(False)
        Me.PnlAbout.ResumeLayout(False)
        Me.TpOptions.ResumeLayout(False)
        Me.TcOpt.ResumeLayout(False)
        Me.TpOptMain.ResumeLayout(False)
        Me.PnlSettings.ResumeLayout(False)
        Me.PnlMainOpt.ResumeLayout(False)
        Me.TlpMainOpt.ResumeLayout(False)
        Me.TlpMainOpt.PerformLayout()
        CType(Me.NumLongitude, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumDailyInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumHourlyInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumNowcastInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumRtInterval, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumLatiutude, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpOptDaily.ResumeLayout(False)
        Me.PnlDailyForecast.ResumeLayout(False)
        Me.PnlDailyForecast.PerformLayout()
        Me.FlpDaily.ResumeLayout(False)
        Me.TpOptHourly.ResumeLayout(False)
        Me.PnlHourlyForecast.ResumeLayout(False)
        Me.PnlHourlyForecast.PerformLayout()
        Me.FlpHourly.ResumeLayout(False)
        Me.TpOptNowCast.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlpNowcast.ResumeLayout(False)
        CType(Me.NumNcTimeStep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpOptRealtime.ResumeLayout(False)
        Me.PnlOptRealtime.ResumeLayout(False)
        Me.PnlOptRealtime.PerformLayout()
        Me.FlpRtOpt.ResumeLayout(False)
        Me.FlpRtOpt.PerformLayout()
        Me.TpLogs.ResumeLayout(False)
        Me.TcLogs.ResumeLayout(False)
        Me.TpLogLog.ResumeLayout(False)
        Me.TpLogError.ResumeLayout(False)
        Me.TpNowcast.ResumeLayout(False)
        CType(Me.DgvNowcast, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpHourly.ResumeLayout(False)
        CType(Me.DgvHourly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpDaily.ResumeLayout(False)
        CType(Me.DgvDaily, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TC.ResumeLayout(False)
        Me.TpRealtime.ResumeLayout(False)
        CType(Me.DgvRt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TmrClock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TmrUpdateDaily, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TmrMidnight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TmrUpdateRt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TmrUpdateNowcast As Timers.Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TsslVer As ToolStripStatusLabel
    Friend WithEvents TsslNextDaily As ToolStripStatusLabel
    Friend WithEvents TsslNextHourly As ToolStripStatusLabel
    Friend WithEvents TsslNextNowcast As ToolStripStatusLabel
    Friend WithEvents TsslCpy As ToolStripStatusLabel
    Friend WithEvents TsslClock As ToolStripStatusLabel
    Friend WithEvents TC As TabControl
    Friend WithEvents TpDaily As TabPage
    Friend WithEvents DgvDaily As DataGridView
    Friend WithEvents TpHourly As TabPage
    Friend WithEvents DgvHourly As DataGridView
    Friend WithEvents hr0 As DataGridViewTextBoxColumn
    Friend WithEvents hr1 As DataGridViewTextBoxColumn
    Friend WithEvents hr2 As DataGridViewImageColumn
    Friend WithEvents hr3 As DataGridViewTextBoxColumn
    Friend WithEvents TpNowcast As TabPage
    Friend WithEvents DgvNowcast As DataGridView
    Friend WithEvents c1 As DataGridViewTextBoxColumn
    Friend WithEvents c2 As DataGridViewTextBoxColumn
    Friend WithEvents c3 As DataGridViewImageColumn
    Friend WithEvents c4 As DataGridViewTextBoxColumn
    Friend WithEvents TpLogs As TabPage
    Friend WithEvents TcLogs As TabControl
    Friend WithEvents TpLogLog As TabPage
    Friend WithEvents RtbLog As RichTextBox
    Friend WithEvents TpLogError As TabPage
    Friend WithEvents RtbError As RichTextBox
    Friend WithEvents TpOptions As TabPage
    Friend WithEvents TcOpt As TabControl
    Friend WithEvents TpOptMain As TabPage
    Friend WithEvents PnlSettings As Panel
    Friend WithEvents PnlMainOpt As Panel
    Friend WithEvents TlpMainOpt As TableLayoutPanel
    Friend WithEvents RbUnitSI As RadioButton
    Friend WithEvents Label15 As Label
    Friend WithEvents RbUnitUS As RadioButton
    Friend WithEvents NumNowcastInterval As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents NumHourlyInterval As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents NumDailyInterval As NumericUpDown
    Friend WithEvents ChkFetchHourly As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtApiKey As TextBox
    Friend WithEvents NumLongitude As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents ChkFetchDaily As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NumLatiutude As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ChkFetchNowcast As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TpOptDaily As TabPage
    Friend WithEvents PnlDailyForecast As Panel
    Friend WithEvents ChkUncheckAllDaily As CheckBox
    Friend WithEvents ChkMoonPhase As CheckBox
    Friend WithEvents ChkTemp As CheckBox
    Friend WithEvents ChkWxCode As CheckBox
    Friend WithEvents ChkFeelsLike As CheckBox
    Friend WithEvents ChkVis As CheckBox
    Friend WithEvents ChkPrecip As CheckBox
    Friend WithEvents ChkSunset As CheckBox
    Friend WithEvents ChkSunrise As CheckBox
    Friend WithEvents ChkPrecipAcc As CheckBox
    Friend WithEvents ChkPrecipProb As CheckBox
    Friend WithEvents ChkDewpoint As CheckBox
    Friend WithEvents ChkHumidity As CheckBox
    Friend WithEvents ChkBP As CheckBox
    Friend WithEvents ChkWindDir As CheckBox
    Friend WithEvents ChkWindSpeed As CheckBox
    Friend WithEvents ChkAllDaily As CheckBox
    Friend WithEvents TpOptHourly As TabPage
    Friend WithEvents PnlHourlyForecast As Panel
    Friend WithEvents ChkUncheckAllHr As CheckBox
    Friend WithEvents ChkHrRiskCondition As CheckBox
    Friend WithEvents ChkHrRiskConfidence As CheckBox
    Friend WithEvents ChkHrRiskScore As CheckBox
    Friend WithEvents ChkHrHailRisk As CheckBox
    Friend WithEvents ChkHrTemp As CheckBox
    Friend WithEvents ChkHrFeelsLike As CheckBox
    Friend WithEvents ChkHrRoadRisk As CheckBox
    Friend WithEvents ChkHrRH As CheckBox
    Friend WithEvents ChkHrChinaPollutant As CheckBox
    Friend WithEvents ChkHrChinaConcern As CheckBox
    Friend WithEvents ChkHrChinaAqi As CheckBox
    Friend WithEvents ChkHrEpaPollutant As CheckBox
    Friend WithEvents ChkHrEpaAqi As CheckBox
    Friend WithEvents ChkHrEpaConcern As CheckBox
    Friend WithEvents ChkHrAqiNo2 As CheckBox
    Friend WithEvents ChkHrAqiO3 As CheckBox
    Friend WithEvents ChkHrAqiSo2 As CheckBox
    Friend WithEvents ChkHrAqiCo As CheckBox
    Friend WithEvents ChkHrAqiPm25 As CheckBox
    Friend WithEvents ChkHrWindDir As CheckBox
    Friend WithEvents ChkHrWindGust As CheckBox
    Friend WithEvents ChkHrPrecip As CheckBox
    Friend WithEvents ChkHrPrecipType As CheckBox
    Friend WithEvents ChkHrPrecipProb As CheckBox
    Friend WithEvents ChkHrSunrise As CheckBox
    Friend WithEvents ChkHrVis As CheckBox
    Friend WithEvents ChkHrCloudCover As CheckBox
    Friend WithEvents ChkHrCloudCeil As CheckBox
    Friend WithEvents ChkHrMoonPhase As CheckBox
    Friend WithEvents ChkHrWxCode As CheckBox
    Friend WithEvents ChkHrAqiPm10 As CheckBox
    Friend WithEvents ChkHrSunset As CheckBox
    Friend WithEvents ChkHrTreeWalnut As CheckBox
    Friend WithEvents ChkHrTreeSycamore As CheckBox
    Friend WithEvents ChkHrTreeSpruce As CheckBox
    Friend WithEvents ChkHrTreeCottonwood As CheckBox
    Friend WithEvents ChkHrTreePine As CheckBox
    Friend WithEvents ChkHrGrass As CheckBox
    Friend WithEvents ChkHrDewpoint As CheckBox
    Friend WithEvents ChkHrTreeOak As CheckBox
    Friend WithEvents ChkHrTreeMahogany As CheckBox
    Friend WithEvents ChkHrTreeHemlock As CheckBox
    Friend WithEvents ChkHrTreeCypress As CheckBox
    Friend WithEvents ChkHrTreeBeech As CheckBox
    Friend WithEvents ChkHrRagweed As CheckBox
    Friend WithEvents ChkHrWindSpeed As CheckBox
    Friend WithEvents ChkHrTreeAsh As CheckBox
    Friend WithEvents ChkHrTreeCedar As CheckBox
    Friend WithEvents ChkHrTreeElm As CheckBox
    Friend WithEvents ChkHrTreeJuniper As CheckBox
    Friend WithEvents ChkHrTreeMulberry As CheckBox
    Friend WithEvents ChkHrCloudBase As CheckBox
    Friend WithEvents ChkHrBP As CheckBox
    Friend WithEvents ChkHrTreeBirch As CheckBox
    Friend WithEvents ChkHrSSR As CheckBox
    Friend WithEvents ChkHrTreeElder As CheckBox
    Friend WithEvents ChkHrTreePollen As CheckBox
    Friend WithEvents ChkHrTreeHickory As CheckBox
    Friend WithEvents ChkHrWeedPollen As CheckBox
    Friend WithEvents ChkHrTreeMaple As CheckBox
    Friend WithEvents ChkHrGrassPollen As CheckBox
    Friend WithEvents ChkHrTreeAcacia As CheckBox
    Friend WithEvents ChkHrTreeWillow As CheckBox
    Friend WithEvents ChkAllHourly As CheckBox
    Friend WithEvents TpOptNowCast As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ChkNcRiskCondition As CheckBox
    Friend WithEvents ChkNcRiskConfidence As CheckBox
    Friend WithEvents ChkNcHailRisk As CheckBox
    Friend WithEvents ChkNcTemp As CheckBox
    Friend WithEvents ChkNcFeelsLike As CheckBox
    Friend WithEvents ChkNcRH As CheckBox
    Friend WithEvents ChkNcChinaPollutant As CheckBox
    Friend WithEvents ChkNcChinaConcern As CheckBox
    Friend WithEvents ChkNcChinaAqi As CheckBox
    Friend WithEvents ChkNcEpaPollutant As CheckBox
    Friend WithEvents ChkNcEpaAqi As CheckBox
    Friend WithEvents ChkNcEpaConcern As CheckBox
    Friend WithEvents ChkNcNo2 As CheckBox
    Friend WithEvents ChkNcO3 As CheckBox
    Friend WithEvents ChkNcSo2 As CheckBox
    Friend WithEvents ChkNcCo As CheckBox
    Friend WithEvents ChkNcPm25 As CheckBox
    Friend WithEvents ChkNcWindDir As CheckBox
    Friend WithEvents ChkNcWindGust As CheckBox
    Friend WithEvents ChkNcPrecip As CheckBox
    Friend WithEvents ChkNcPrecipType As CheckBox
    Friend WithEvents ChkNcSunrise As CheckBox
    Friend WithEvents ChkNcVis As CheckBox
    Friend WithEvents ChkNcCloudCover As CheckBox
    Friend WithEvents ChkNcCloudCeil As CheckBox
    Friend WithEvents ChkNcWxCode As CheckBox
    Friend WithEvents ChkNcSunset As CheckBox
    Friend WithEvents ChkNcDewpoint As CheckBox
    Friend WithEvents ChkNcPm10 As CheckBox
    Friend WithEvents ChkNcWindSpeed As CheckBox
    Friend WithEvents ChkNcWalnut As CheckBox
    Friend WithEvents ChkNcSycamore As CheckBox
    Friend WithEvents ChkNcSpruce As CheckBox
    Friend WithEvents ChkNcCottonwood As CheckBox
    Friend WithEvents ChkNcPine As CheckBox
    Friend WithEvents ChkNcGrass As CheckBox
    Friend WithEvents ChkNcCloudBase As CheckBox
    Friend WithEvents ChkNcOak As CheckBox
    Friend WithEvents ChkNcMahogany As CheckBox
    Friend WithEvents ChkNcHemlock As CheckBox
    Friend WithEvents ChkNcCypress As CheckBox
    Friend WithEvents ChkNcBeech As CheckBox
    Friend WithEvents ChkNcRagweed As CheckBox
    Friend WithEvents ChkNcBP As CheckBox
    Friend WithEvents ChkNcAsh As CheckBox
    Friend WithEvents ChkNcCedar As CheckBox
    Friend WithEvents ChkNcElm As CheckBox
    Friend WithEvents ChkNcJuniper As CheckBox
    Friend WithEvents ChkNcMulberry As CheckBox
    Friend WithEvents ChkNcSSR As CheckBox
    Friend WithEvents ChkNcTreePollen As CheckBox
    Friend WithEvents ChkNcBirch As CheckBox
    Friend WithEvents ChkNcWeedPollen As CheckBox
    Friend WithEvents ChkNcElder As CheckBox
    Friend WithEvents ChkNcGrassPollen As CheckBox
    Friend WithEvents ChkNcHickory As CheckBox
    Friend WithEvents ChkNcAcacia As CheckBox
    Friend WithEvents ChkNcMaple As CheckBox
    Friend WithEvents ChkNcWillow As CheckBox
    Friend WithEvents ChkNcRoadRisk As CheckBox
    Friend WithEvents ChkNcRiskScore As CheckBox
    Friend WithEvents ChkUncheckAllNowcast As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ChkAllNowcast As CheckBox
    Friend WithEvents TpAbout As TabPage
    Friend WithEvents PnlAbout As Panel
    Friend WithEvents LblAbout As Label
    Friend WithEvents TmrUpdateHourly As Timers.Timer
    Friend WithEvents TTip As ToolTip
    Friend WithEvents TmrClock As Timers.Timer
    Friend WithEvents TmrUpdateDaily As Timers.Timer
    Friend WithEvents TmrMidnight As Timers.Timer
    Friend WithEvents NumNcTimeStep As NumericUpDown
    Friend WithEvents TpOptRealtime As TabPage
    Friend WithEvents PnlOptRealtime As Panel
    Friend WithEvents FlpRtOpt As FlowLayoutPanel
    Friend WithEvents ChkRtCore0 As CheckBox
    Friend WithEvents ChkRtCore1 As CheckBox
    Friend WithEvents ChkRtCore2 As CheckBox
    Friend WithEvents ChkRtCore3 As CheckBox
    Friend WithEvents ChkRtCore4 As CheckBox
    Friend WithEvents ChkRtCore5 As CheckBox
    Friend WithEvents ChkRtCore6 As CheckBox
    Friend WithEvents ChkRtCore7 As CheckBox
    Friend WithEvents ChkRtCore8 As CheckBox
    Friend WithEvents ChkRtCore9 As CheckBox
    Friend WithEvents ChkRtCore10 As CheckBox
    Friend WithEvents ChkRtCore11 As CheckBox
    Friend WithEvents ChkRtCore12 As CheckBox
    Friend WithEvents ChkRtCore13 As CheckBox
    Friend WithEvents ChkRtCore14 As CheckBox
    Friend WithEvents ChkRtCore15 As CheckBox
    Friend WithEvents ChkRtCore16 As CheckBox
    Friend WithEvents ChkRtCore17 As CheckBox
    Friend WithEvents ChkRtCore18 As CheckBox
    Friend WithEvents ChkRtCore19 As CheckBox
    Friend WithEvents ChkRtCore20 As CheckBox
    Friend WithEvents ChkRtPol0 As CheckBox
    Friend WithEvents ChkRtPol1 As CheckBox
    Friend WithEvents ChkRtPol2 As CheckBox
    Friend WithEvents ChkRtPol3 As CheckBox
    Friend WithEvents ChkRtPol4 As CheckBox
    Friend WithEvents ChkRtPol5 As CheckBox
    Friend WithEvents ChkRtPol6 As CheckBox
    Friend WithEvents ChkRtPol7 As CheckBox
    Friend WithEvents ChkRtPol8 As CheckBox
    Friend WithEvents ChkRtPol9 As CheckBox
    Friend WithEvents ChkRtPol10 As CheckBox
    Friend WithEvents ChkRtPol11 As CheckBox
    Friend WithEvents ChkRtPol12 As CheckBox
    Friend WithEvents ChkRtPol13 As CheckBox
    Friend WithEvents ChkRtPol14 As CheckBox
    Friend WithEvents ChkRtPol15 As CheckBox
    Friend WithEvents ChkRtPol16 As CheckBox
    Friend WithEvents ChkRtPol17 As CheckBox
    Friend WithEvents ChkRtPol18 As CheckBox
    Friend WithEvents ChkRtPol19 As CheckBox
    Friend WithEvents ChkRtPol20 As CheckBox
    Friend WithEvents ChkRtPol21 As CheckBox
    Friend WithEvents ChkRtPol22 As CheckBox
    Friend WithEvents ChkRtPol23 As CheckBox
    Friend WithEvents ChkRtPol24 As CheckBox
    Friend WithEvents ChkRtPol25 As CheckBox
    Friend WithEvents ChkRtRoad0 As CheckBox
    Friend WithEvents ChkRtRoad1 As CheckBox
    Friend WithEvents ChkRtRoad2 As CheckBox
    Friend WithEvents ChkRtRoad3 As CheckBox
    Friend WithEvents ChkRtFire0 As CheckBox
    Friend WithEvents ChkRtHail0 As CheckBox
    Friend WithEvents ChkRtAqi0 As CheckBox
    Friend WithEvents ChkRtAqi1 As CheckBox
    Friend WithEvents ChkRtAqi2 As CheckBox
    Friend WithEvents ChkRtAqi3 As CheckBox
    Friend WithEvents ChkRtAqi4 As CheckBox
    Friend WithEvents ChkRtAqi5 As CheckBox
    Friend WithEvents ChkRtAqi6 As CheckBox
    Friend WithEvents ChkRtAqi7 As CheckBox
    Friend WithEvents ChkRtAqi8 As CheckBox
    Friend WithEvents ChkRtAqi9 As CheckBox
    Friend WithEvents ChkRtAqi10 As CheckBox
    Friend WithEvents ChkRtAqi11 As CheckBox
    Friend WithEvents Label16 As Label
    Friend WithEvents NumRtInterval As NumericUpDown
    Friend WithEvents ChkFetchRt As CheckBox
    Friend WithEvents TmrUpdateRt As Timers.Timer
    Friend WithEvents ChkRtUncheckAll As CheckBox
    Friend WithEvents ChkRtCheckAll As CheckBox
    Friend WithEvents TsslNextRt As ToolStripStatusLabel
    Friend WithEvents TpRealtime As TabPage
    Friend WithEvents DgvRt As DataGridView
    Friend WithEvents rt0 As DataGridViewTextBoxColumn
    Friend WithEvents rt1 As DataGridViewTextBoxColumn
    Friend WithEvents FlpDaily As FlowLayoutPanel
    Friend WithEvents FlpHourly As FlowLayoutPanel
    Friend WithEvents FlpNowcast As FlowLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents ChkLogImages As CheckBox
    Friend WithEvents ChkLogHeaders As CheckBox
End Class
