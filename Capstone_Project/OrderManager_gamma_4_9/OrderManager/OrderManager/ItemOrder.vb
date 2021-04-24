Public Class ItemOrder

    Public id As Long
    Public orderId As Long
    Public itemId As Integer
    Public quantity As Integer
    Public notes As String = ""

    Public Sub New(obj() As Object)
        With Me
            If obj.Count > 0 Then
                .id = obj(0)
                If obj.Count >= 2 Then
                    .orderId = obj(1)
                    If obj.Count >= 3 Then
                        .itemId = obj(2)
                        If obj.Count >= 4 Then
                            .quantity = obj(3)
                            If obj.Count >= 5 Then
                                .notes = obj(4)
                            End If
                        End If
                    End If
                End If
            End If
        End With
    End Sub

End Class
