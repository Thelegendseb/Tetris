Public Class TetrominoJ
    Inherits Tetromino

    Sub New()
        MyBase.New(TetrominoType.J)
    End Sub

    Public Overrides Function UpState() As Boolean(,)
        Return {
            {False, False, False, False},
            {True, False, False, False},
            {True, True, True, False},
            {False, False, False, False}
        }
    End Function

    Public Overrides Function RightState() As Boolean(,)
        Return {
            {False, False, False, False},
            {False, True, True, False},
            {False, True, False, False},
            {False, True, False, False}
        }
    End Function

    Public Overrides Function DownState() As Boolean(,)
        Return {
            {False, False, False, False},
            {False, False, False, False},
            {True, True, True, False},
            {False, False, True, False}
        }
    End Function

    Public Overrides Function LeftState() As Boolean(,)
        Return {
            {False, False, False, False},
            {False, True, False, False},
            {False, True, False, False},
            {True, True, False, False}
        }
    End Function
End Class