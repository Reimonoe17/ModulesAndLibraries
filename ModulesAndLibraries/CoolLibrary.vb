Module CoolLibrary
    ''' <summary>
    ''' A full featured function to say hello...
    ''' </summary>
    ''' <returns>A string "Hello World!"</returns>
    Function SayHello() As String
        Return "Hello World!"
    End Function

    ''' <summary>
    ''' Displays the content of arguement displayMessage then returns the user response.
    ''' </summary>
    ''' <param name="displayMessage"></param>
    ''' <returns>string: user response</returns>
    Public Function Prompt(ByVal Optional displayMessage As String = "<blank>") As String
        Console.WriteLine(displayMessage)
        Return Console.ReadLine()
    End Function

    Public Function RandomWithInRange(max As Integer, min As Integer) As Integer
        Randomize(DateTime.Now.Millisecond)
        max = max - min
        Return CInt(Rnd() * max)
    End Function

End Module
