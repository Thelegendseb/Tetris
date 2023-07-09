Public Class TetrominoL
    Inherits Tetromino

    Sub New()
        MyBase.New(TetrominoType.L)
    End Sub

    Public Overrides Function UpState() As Boolean(,)
        Return {
            {False, False, False, False},
            {False, False, False, False},
            {False, False, False, False},
            {False, False, False, False}
        }
    End Function

    Public Overrides Function RightState() As Boolean(,)
        Return {
            {False, False, False, False},
            {False, False, False, False},
            {False, False, False, False},
            {False, False, False, False}
        }
    End Function

    Public Overrides Function DownState() As Boolean(,)
        Return {
            {False, False, False, False},
            {False, False, False, False},
            {False, False, False, False},
            {False, False, False, False}
        }
    End Function

    Public Overrides Function LeftState() As Boolean(,)
        Return {
            {False, False, False, False},
            {False, False, False, False},
            {False, False, False, False},
            {False, False, False, False}
        }
    End Function
End Class