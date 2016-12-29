Public Class Base

    Public Shared Function conectar() As String
        Dim cnn As String
        cnn = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=asientos_contables.accdb; Jet OLEDB:Database Password=chmod-rwx;"
        Return cnn
    End Function

End Class
