Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Xml
Public Class Conexion_Manual
    Private aes As New AES()
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtCnString.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SavetoXML(aes.Encrypt(txtCnString.Text, appPwdUnique, Integer.Parse("256")))

    End Sub
    Public Sub SavetoXML(ByVal dbcnString)
        Dim doc As XmlDocument = New XmlDocument()
        doc.Load("ConnectionString.xml")
        Dim root As XmlElement = doc.DocumentElement
        root.Attributes.Item(0).Value = dbcnString
        Dim writer As XmlTextWriter = New XmlTextWriter("ConnectionString.xml", Nothing)
        writer.Formatting = Formatting.Indented
        doc.Save(writer)
        writer.Close()
    End Sub
    Dim dbcnString As String
    Public Sub ReadfromXML()
        Try
            Dim doc As XmlDocument = New XmlDocument()
            doc.Load("ConnectionString.xml")
            Dim root As XmlElement = doc.DocumentElement
            dbcnString = root.Attributes.Item(0).Value
            txtCnString.Text = (aes.Decrypt(dbcnString, appPwdUnique, Integer.Parse("256")))
        Catch ex As System.Security.Cryptography.CryptographicException
        End Try
    End Sub

    Private Sub Conexion_Manual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadfromXML()
    End Sub
End Class