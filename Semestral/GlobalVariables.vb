Public Class GlobalVariables
    Public Shared userId As Integer
    Public Shared userName As String

    Public Property user() As Integer
        Get
            Return userId
        End Get
        Set(ByVal value As Integer)
            userId = value
        End Set
    End Property

    Public Property name() As Integer
        Get
            Return userName
        End Get
        Set(ByVal value As Integer)
            userName = value
        End Set
    End Property


End Class
