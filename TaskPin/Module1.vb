Imports System.IO
Imports System.Net.Mime.MediaTypeNames
Imports System.Text

Module Module1

    Sub Main()
        If My.Computer.FileSystem.FileExists("FilePath.txt") Then
            Opener()
        Else
            Dim txt As String = "FilePath.txt"
            Dim path As String

            ' Create or overwrite the file.
            Dim fs As FileStream = File.Create(txt)

            Console.WriteLine("NO FILE PATH SELECTED, PLEASE INPUT FILE LOCATION INCLUDING .EXE FILE")
            Console.WriteLine("")
            path = Console.ReadLine()

            Dim info As Byte() = New UTF8Encoding(True).GetBytes(path)
            fs.Write(info, 0, info.Length)
            fs.Close()

            Console.WriteLine("")
            Console.WriteLine("SUCCESSFULLY CHANGED FILE PATH TO " & path)

            Console.WriteLine("")
            Console.WriteLine("TO CHANGE AGAIN, PLEASE EDIT THE TEXT FILE FOUND IN THE DIRECTORY OF THIS PROGRAM")

            Console.WriteLine("")
            Console.WriteLine("press enter to exit. . .")

            Console.ReadLine()
        End If
    End Sub

    Sub Opener()
        Dim path As String = System.IO.File.ReadAllLines("FilePath.txt")(0)
        Dim newPath As String
        Dim txt As String = "FilePath.txt"

        If My.Computer.FileSystem.FileExists(path) Then
            Process.Start(path)
        Else
            Console.WriteLine("INVALID FILE PATH, PLEASE ENTER CORRECT PATH. MAKE SURE YOU PUT IN A .EXE FILE")
            Console.WriteLine("")
            newPath = Console.ReadLine()

            Dim fs As FileStream = File.Create(txt)

            Dim info As Byte() = New UTF8Encoding(True).GetBytes(newPath)
            fs.Write(info, 0, info.Length)
            fs.Close()
            Console.WriteLine("")
            Console.WriteLine("SUCESSFULLY CHANGED FILE PATH")
            Console.WriteLine("press enter to exit. . .")
            Console.ReadLine()

        End If
    End Sub

End Module
