Imports System.ServiceProcess

Public Class HandlerClass
    Public Shared Sub ServiceAction()
        Dim controller As New ServiceController("Solunix.WebServer")
        Dim controller2 As New ServiceController("SolunixWebServerResetConfig")
        Try
            controller.Stop()
            controller.WaitForStatus(ServiceControllerStatus.Stopped)
            controller.Start()
            'stop after the service is up not downb
            controller.WaitForStatus(ServiceControllerStatus.Running)
            controller2.Stop()
        Catch ex As Exception

        End Try
    End Sub
    Public Shared Sub Terminate()
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class
