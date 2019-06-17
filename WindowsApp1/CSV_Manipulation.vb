Module CSV_Manipulation

    Sub ReadFile()
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("..\..\data.csv")
        MsgBox(fileReader)
    End Sub

    Function SortNumbs(numbers As String)

    End Function


End Module
