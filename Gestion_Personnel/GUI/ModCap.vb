Option Strict On
Option Explicit On
'Imports DirectX.Capture
Imports System
Imports System.IO

Module ModCap


    Public Structure Active2
        ' Dim Camera As Filter
        ' Dim CaptureInfo As DirectX.Capture.Capture '' l'ancienne declaration etait Dim CaptureInfo as Capture
        Dim Counter As Integer
        Dim CounterFrames As Integer
        Dim PathVideo As String
    End Structure

    'le streaming en cours
    Public CaptureInformation2 As Active2
    'le filtre en cours
    'Public Dispositivos As New Filters()

End Module