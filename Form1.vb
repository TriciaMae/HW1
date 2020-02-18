Imports System.IO
Imports System.Text
Public Class Form1
    Private Sub TxtBtn_Click(sender As Object, e As EventArgs) Handles TxtBtn.Click
        'Creating .txt file with file path
        Dim path As String = "c:\temp\Text Format.txt"
        Dim fs As FileStream = File.Create(path)
        Dim name, age, address As String

        'Getting entered info
        name = NameBox.Text
        age = AgeBox.Text
        address = AddressBox.Text

        'Writing the entered info into the txt file
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("Name: " + name + vbCrLf + "Age: " + age + vbCrLf + "Address: " + address)
        fs.Write(info, 0, info.Length)
        MsgBox("Successfully created Text file!", MsgBoxStyle.Information, "Txt File")
        fs.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles XMLBtn.Click
        'Creating .txt file with file path
        Dim path As String = "c:\temp\XML Format.xml"
        Dim fs As FileStream = File.Create(path)
        Dim name, age, address As String

        'Getting entered info
        name = NameBox.Text
        age = AgeBox.Text
        address = AddressBox.Text

        'Writing the entered info into the txt file
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("<article lang=''''>" + vbCrLf + "     <para>Name: " + name + "</para>" + vbCrLf +
              "     <para>Age: " + age + "</para>" + vbCrLf + "     <para>Address: " + address + "</para>" +
               vbCrLf + "</article>")
        fs.Write(info, 0, info.Length)
        MsgBox("Successfully created XML file!", MsgBoxStyle.Information, "XML File")
        fs.Close()
    End Sub

    Private Sub JSONBtn_Click(sender As Object, e As EventArgs) Handles JSONBtn.Click
        'Creating .txt file with file path
        Dim path As String = "c:\temp\JSON Format.json"
        Dim fs As FileStream = File.Create(path)
        Dim name, age, address As String

        'Getting entered info
        name = NameBox.Text
        age = AgeBox.Text
        address = AddressBox.Text

        'Writing the entered info into the txt file
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("[""Name: " + name + """" + "," + """Age: " + age +
                                                             """" + "," + """Address: " + address + """]")
        fs.Write(info, 0, info.Length)
        MsgBox("Successfully created JSON file!", MsgBoxStyle.Information, "JSON File")
        fs.Close()
    End Sub
End Class
