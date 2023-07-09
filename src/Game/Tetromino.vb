Public MustInherit Class Tetromino

    Private Type As TetrominoType

    Sub New(TypeIn As TetrominoType)
        Me.Type = TypeIn
    End Sub

    ' // Shape + Orientation of Tetromino based on 2D 4x4 Boolean array
    Public MustOverride Function UpState() As Boolean(,)
    Public MustOverride Function RightState() As Boolean(,)
    Public MustOverride Function DownState() As Boolean(,)
    Public MustOverride Function LeftState() As Boolean(,)

End Class

Public Enum TetrominoType
    I
    J
    L
    S
    Z
    T
    O
End Enum
