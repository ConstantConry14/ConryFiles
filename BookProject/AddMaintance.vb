Imports BookProjectBusiness.OrderBO
Imports System.IO
 Structure  MainInfo(  )
    Dim objWrite As StreamReader
    Dim objRead As StreamReader

End Structure

Module AddMaintance
    Private objRead As StreamWriter
    Private objWrite As StreamWriter

    Public Sub objInfo(FileName As String)

        objWrite = File.CreateText(FileName)

        Dim count As Integer = RichTextBoxLanguageOptions.AutoKeyboard.ToString()

        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(0))
        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(1))
        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(2))
        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(3))
        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(4))
        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(5))
        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(6))
        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(7))
        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(8))
        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(9))
        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(10))
        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(11))
        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(12))
        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(13))
        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(14))
        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(15))
        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(16))
        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(17))
        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(18))
        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(19))
        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(20))
        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(21))
        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(22))
        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(23))
        objWrite.WriteLine(RichTextBoxLanguageOptions.AutoKeyboard.ToString(24))

    End Sub

    Public Sub objRRead(Infromation As String)

        If File.Exists(Infromation) Then
            objRead = File.OpenText(Infromation)



        End If


    End Sub


End Module
