Module CustomMath


    Function CalcMean(numbList As ArrayList)
        Dim newList As ArrayList = New ArrayList()
    End Function


    Function CalcMedian(numbList As ArrayList)
        Dim newList As ArrayList = New ArrayList()
    End Function


    Function CalcRange(numbList As ArrayList)
        numbList.Sort()
        Dim firstNumb As Integer = numbList.Item(0)
        Dim lastNumb As Integer = numbList.Item(numbList.Count - 1)

        Dim range As Integer = lastNumb - firstNumb

        Return range
    End Function


End Module
