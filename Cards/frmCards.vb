Public Class frmCards
    Public Deck As New List(Of Card)
    Dim tempDeck As New List(Of Card)
    Public CardBack As Image
    Dim tablePictures As New List(Of PictureBox)

    Private Sub frmCards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For suitNumber As Integer = 1 To 4
            For cardNumber As Integer = 1 To 13
                Deck.Add(New Card(suitNumber, cardNumber))
            Next
        Next
        Deck.Add(New Card(0, 0))
        CardBack = Image.FromFile("..\..\back.jpg")
        tablePictures.Add(Pic1)
        tablePictures.Add(Pic2)
        tablePictures.Add(Pic3)
        tablePictures.Add(Pic4)
        tablePictures.Add(Pic5)
        For Each picbox As PictureBox In tablePictures
            picbox.Image = CardBack
        Next
    End Sub

    Private Sub btnPic5_Click(sender As Object, e As EventArgs) Handles btnPic5.Click
        For Each item As Card In Deck
            tempDeck.Add(item)
        Next
        Dim table As New List(Of Card)
        Randomize()
        Dim RandomPicker As New Random
        Dim number As Integer
        For x As Integer = 0 To 4
            number = RandomPicker.Next(tempDeck.Count)
            table.Add(tempDeck(number))
            tempDeck.Remove(tempDeck(number))
            tablePictures(x).Image = table(x).Front
        Next
        Dim value As Integer = 0
        For Each tableCard As Card In table
            value += tableCard.Value
        Next
        lblValue.Text = value.ToString()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        System.Environment.Exit(0)
    End Sub
End Class
