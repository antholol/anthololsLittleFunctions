Imports System
Imports System.Net.Http.Headers
Imports System.Numerics
Module myToolbox
    Sub Main(args As String())

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

End Module