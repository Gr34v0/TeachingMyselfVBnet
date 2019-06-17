Module CSV_Manipulation

    Function ReadFile()
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("..\..\data.csv")
        Return fileReader
    End Function

    Function SortNumbs(numbers As String)
        Dim numberList As ArrayList = New ArrayList()
        For Each number As String In numbers.Split(",")
            numberList.Add(Convert.ToInt32(number))
        Next
        Return numberList
    End Function

End Module
