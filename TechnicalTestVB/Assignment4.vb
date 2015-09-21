Imports System.Text

Public Class Assignment4

    Public Shared Function Flatten(array As Char()) As Char()
        Dim builder As New StringBuilder()

        For Each item As Char In array
            If [Char].IsDigit(item) Then
                builder.Append(item)
            End If
        Next

        Return builder.ToString().ToCharArray()
    End Function
End Class
