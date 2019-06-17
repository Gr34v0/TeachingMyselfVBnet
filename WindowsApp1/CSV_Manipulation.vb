Module CSV_Manipulation

    Function ReadFile()
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("..\..\data.csv")
        Return fileReader
    End Function

    Function CSVToIntList(numbers As String)
        Dim numberList As ArrayList = New ArrayList()
        For Each number As String In numbers.Split(",")
            numberList.Add(Convert.ToInt32(number))
        Next
        Return numberList
    End Function

    Function IntListToCSV(intList As ArrayList)
        Dim allNumbs As String = ""
        For Each number As Integer In CSV_Manipulation.CSVToIntList(CSV_Manipulation.ReadFile())
            allNumbs += (number.ToString + ", ")
        Next
        Return allNumbs
    End Function

End Module
