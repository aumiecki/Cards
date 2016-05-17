Public Class Card
    Public Suit As String
    Public Value As Integer
    Public Front As Image
    Public Sub New(SuitNumber As String, number As Integer)
        Dim Suits As String() = {"joker", "club", "diamond", "heart", "spade"}
        Suit = Suits(SuitNumber)
        If Suit = "joker" Then
            Value = 0
        ElseIf number > 10 Then
            Value = 10
        Else
            Value = number
        End If
        Dim filename As String
        filename = "..\..\" & Suit
        If (number < 10) Then
            filename &= "0"
        End If
        filename &= number.ToString() & ".jpg"
        If Suit = "joker" Then
            Front = Image.FromFile("..\..\joker.jpg")
        Else
            Front = Image.FromFile(filename)
        End If
    End Sub
End Class
