Imports System
Imports System.Net.Http.Headers
Imports System.Numerics
Module myToolbox
    Sub Main(args As String())
        Dim testData() As Integer = {7, 102, 9, 7, 36, 76, 92, 77, 64, 103, 102, 57, 19, 38, 88, 48, 68, 84, 94, 18, 59, 52, 70, 17, 85, 45, 82, 25, 97, 10, 74, 19, 32, 41, 17, 29, 89, 47, 7, 16, 32, 42, 12, 62, 84, 74, 99, 13, 31, 80, 97, 23, 92, 24, 50, 59, 104, 87, 99, 93, 75, 77, 78, 63, 98, 104, 17, 62, 99, 92, 69, 10, 66, 54, 105, 63, 83, 25, 12, 58, 99, 65, 34, 85, 64, 29, 72, 19, 60, 25, 81, 26, 11, 17, 66, 61, 69, 63, 43, 89}
        Dim moreTestData() As String = {"atattta", "aaaakaka", "ata", "aba", "zada", "ktar", "tusnao", "akaw", "para", "star", "sawk", "taro", "read", "undisturbed", "money", "clarity", "care", "intersection", "everything", "nineteen eighty four", "goals", "economic", "return", "change", "excacerbate", "cigarette", "candy", "and", "vanilla", "sky", "table", "safety", "boek", "book", "zebra", "couch", "close", "far"}
        'binomialExpansionCalc(1, 4, 6)

        'For x = 0 To 9
        '    For y = 0 To 9
        '        Console.Write(nCr(x, y))
        '        Console.Write(" ")
        '    Next
        '    Console.WriteLine("")
        'Next

        'For x = 1 To 100
        '   Console.WriteLine((factorial(x)))
        'Next x

        Console.WriteLine(DenToBin(255))
        Console.WriteLine(" ")
        universalBubbleSort(moreTestData)
    End Sub

    'literal maths shit
    Function factorial(ByVal num As Integer) As BigInteger
        Dim total As BigInteger = 1

        For x = 0 To (num - 1)
            total = total * (num - x)
        Next

        Return total
    End Function

    Function nCr(ByVal n As Integer, ByVal r As Integer)

        Return (factorial(n)) / ((factorial(r)) * (factorial(n - r)))

    End Function

    Sub binomialExpansionCalc(ByVal a As Decimal, ByVal b As Decimal, ByVal n As Integer)
        Dim r As Integer = -1
        Dim product As BigInteger = 0
        Dim isNull As Boolean = False

        Do While r < n
            r = r + 1
            product = (nCr(n, r)) * (a ^ (n - r)) * (b ^ (r))

            If product = 0 Then
                isNull = True
            End If

            If r = 0 Then
                Console.Write(Convert.ToString(product))
            Else
                Console.Write(" + " & Convert.ToString(product) & "x^" & Convert.ToString(r))
            End If

        Loop


    End Sub

    Function DenToBin(ByVal den As Integer) As String
        Dim register As Integer = 32 - 1 'dont remove the one the register is one longer than it is because 2^0
        Dim binNum As String = ""

        Do
            If den >= (2 ^ register) Then
                binNum = binNum + "1"
                den = den - (2 ^ register)
            ElseIf den < (2 ^ register) Then
                binNum = binNum + "0"
            End If
            register = register - 1
        Loop Until register = -1

        Return binNum

    End Function

    Function BinToDen(ByVal bin As String) As Integer
        Dim power As Integer = 1
        Dim sum As Integer = 0

        Do
            If (StrReverse(bin)).Substring((power - 1), 1) = "1" Then
                sum = sum + (2 ^ (power - 1))
            End If
            power = power + 1
        Loop Until (power - 1) = bin.Length

        Return sum

    End Function

    Function BinUnsignedToSignedConvertor(ByVal UnsignedBin As String) As String
        Dim length As Integer
        length = 8


        Return -1
    End Function

    Function universalBubbleSort(ByRef arrayToSort As Array) As Array
        Dim temporary As Object
        'sorry this isnt optimised lol
        For round = 1 To arrayToSort.Length - 1
            For swap = 1 To arrayToSort.Length - 2
                If arrayToSort(swap) > arrayToSort(swap + 1) Then
                    temporary = arrayToSort(swap + 1)
                    arrayToSort(swap + 1) = arrayToSort(swap)
                    arrayToSort(swap) = temporary
                End If
            Next swap
        Next round

        Return arrayToSort
    End Function

End Module