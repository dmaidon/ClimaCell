﻿Imports System.Text.Json.Serialization

Partial Public Class FieldUnitsModel
    Public Property CloudBase As String
    Public Property CloudCeiling As String
    Public Property CloudCover As String
    Public Property EpaBgColor() As Dictionary(Of String, String)
    Public Property EpaConcernText() As Dictionary(Of String, String)
    Public Property EpaFgColor() As Dictionary(Of String, String)
    Public Property HealthConcern() As Dictionary(Of String, String)
    Public Property EpaIndex As String
    Public Property PrimaryPollutant() As Dictionary(Of String, String)
    Public Property FireIndex As String
    Public Property HailBinary As String
    Public Property Humidity As String
    Public Property MepIndex As String
    Public Property MoonPhase() As Dictionary(Of String, String)
    Public Property ParticulateMatter10() As String
    Public Property ParticulateMatter25() As String
    Public Property PollenIndex() As Dictionary(Of String, String)
    Public Property PollutantCO As String
    Public Property PollutantNO2 As String
    Public Property PollutantO3 As String
    Public Property PollutantSO2 As String
    Public Property PrecipitationIntensity() As String
    Public Property PrecipitationProbability() As String
    Public Property PrecipitationType() As Dictionary(Of String, String)
    Public Property PressureSeaLevel As String
    Public Property PressureSurfaceLevel As String
    Public Property SoilMoistureVolume As String
    Public Property Solar As String
    Public Property Temperature As String
    Public Property Visibility As String
    Public Property WeatherCode() As Dictionary(Of String, String)
    Public Property WindDirection As String
    Public Property WindGust As String
    Public Property WindSpeed As String
End Class