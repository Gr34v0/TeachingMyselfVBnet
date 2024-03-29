﻿Module CustomMath


    Function CalcMean(numbList As ArrayList)
        Dim totalNumb As Integer
        For Each number As Integer In numbList
            totalNumb += number
        Next number

        Dim mean = totalNumb / numbList.Count

        Return mean
    End Function


    Function CalcMedian(numbList As ArrayList)
        numbList.Sort()
        Dim targetNumb = numbList.Count / 2

        If numbList.Count Mod 2 Then
            Dim targetArray As ArrayList = New ArrayList()
            targetArray.Add(numbList.Item(Math.Floor(targetNumb)))
            targetArray.Add(numbList.Item(Math.Ceiling(targetNumb)))

            targetNumb = CalcMean(targetArray)
        End If

        Return targetNumb

    End Function


    Function CalcRange(numbList As ArrayList)
        numbList.Sort()

        Dim firstNumb As Integer = numbList.Item(0)
        Dim lastNumb As Integer = numbList.Item(numbList.Count - 1)

        Dim range As Integer = lastNumb - firstNumb

        Return range
    End Function

    Function SortNumbsFunc(numbList As ArrayList)
        Dim sortedList As ArrayList = New ArrayList()
        numbList.Sort()
        For Each number In numbList
            sortedList.Add(number)
        Next number
        Return sortedList
    End Function

    Sub SortNumbs(numbList As ArrayList)
        numbList.Sort()
    End Sub


End Module