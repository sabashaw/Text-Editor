Public Class TextForm
    'Get or set the text on the status bar
    Public Property StatusText() As String
        Get
            Return sslStatus.Text
        End Get
        Set(value As String)
            sslStatus.Text = value
        End Set
    End Property

    'Get or set the text that you're editing
    Public Property EditText() As String
        Get
            Return txtEdit.Text
        End Get
        Set(value As String)
            txtEdit.Text = value
        End Set
    End Property

    'clears the txtEdit control
    Public Sub ClearEditBox()
        'set the editText property
        EditText = String.Empty

        'reset the font color
        txtEdit.ForeColor = Color.Black
        'set the status bar text
        StatusText = "Text box cleared"
    End Sub

    Public Sub RedText()
        'make the text red
        txtEdit.ForeColor = Color.Red

        'update the status 
        StatusText = "The text is Red"
    End Sub

    Public Sub BlueText()
        'make the text blue
        txtEdit.ForeColor = Color.Blue

        'update the status
        StatusText = "The text is blue"
    End Sub

    Public Sub UpperCaseText()
        EditText = EditText.ToUpper

        'update status
        StatusText = "The text is Upper Case"
    End Sub

    Public Sub LowerCaseText()
        EditText = EditText.ToLower

        'update status
        StatusText = "The text is lower case"
    End Sub

    Public Sub ShowAboutBox()
        'display the about dialog box
        Using objAbout As New About
            objAbout.ShowDialog(Me)
        End Using
    End Sub

    Private Sub txtEdit_TextChanged(sender As Object, e As EventArgs) Handles txtEdit.TextChanged
        'reset the status bar text
        StatusText = "Ready"
    End Sub

    Private Sub tbrClear_Click(sender As Object, e As EventArgs) Handles tbrClear.Click
        'clear the edit box
        ClearEditBox()
    End Sub

    Private Sub tbrRed_Click(sender As Object, e As EventArgs) Handles tbrRed.Click
        'make the text red
        RedText()
    End Sub

    Private Sub tbrBlue_Click(sender As Object, e As EventArgs) Handles tbrBlue.Click
        BlueText()
    End Sub

    Private Sub tbrUpperCase_Click(sender As Object, e As EventArgs) Handles tbrUpperCase.Click
        UpperCaseText()
    End Sub

    Private Sub tbrLowerCase_Click(sender As Object, e As EventArgs) Handles tbrLowerCase.Click
        LowerCaseText()
    End Sub

    Private Sub tbrHelpAbout_Click(sender As Object, e As EventArgs) Handles tbrHelpAbout.Click
        ShowAboutBox()
    End Sub
End Class