Public Class Board

    Private 
    Private State(,) As BoardPiece

    Sub New()

        ReDim Me.State(9, 19) ' // 10 wide 20 tall

    End Sub

    Public Function GetState() As BoardPiece(,)
        Return Me.State
    End Function

End Class
