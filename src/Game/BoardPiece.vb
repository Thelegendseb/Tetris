Public Class BoardPiece

    Private x As Integer
    Private y As Integer
    Private occupiedBy As TetrominoType

    Sub New(xPos As Integer, yPos As Integer)
        Me.x = xPos
        Me.y = yPos
        Me.occupiedBy = Nothing
    End Sub

    Public Sub SetOccupant(val As TetrominoType)
        Me.occupiedBy = val
    End Sub

    Public Function GetOccupant() As TetrominoType
        Return Me.occupiedBy
    End Function

    Public Function GetX() As Integer
        Return Me.x
    End Function

    Public Function GetY() As Integer
        Return Me.y
    End Function

End Class
