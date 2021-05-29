Public Class ServiceRestart

    Protected Overrides Sub OnStart(ByVal args() As String)
        HandlerClass.ServiceAction()
    End Sub

    Protected Overrides Sub OnStop()

    End Sub

End Class

