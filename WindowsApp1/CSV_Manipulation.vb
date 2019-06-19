Module CSV_Manipulation

    Function ReadFile()
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("..\..\data.csv")
        Return fileReader
    End Function

    Function CSVToIntList(numbers As String)
        Dim numberList As ArrayList = New ArrayList()
        For Each number As String In numbers.Split(",")
            Try
                numberList.Add(Convert.ToInt32(number))
            Catch ex As Exception
                MsgBox("TEXT IS NOT ONE OR MORE INTEGER(S).")
                Exit For
            End Try
        Next number
        Return numberList
    End Function

    Function IntListToCSV(intList As ArrayList)
        Dim allNumbs As String = ""
        For Each number As Integer In intList
            allNumbs += number.ToString + ", "
        Next number
        Return allNumbs
    End Function

End Module