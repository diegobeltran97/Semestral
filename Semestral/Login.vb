Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports GlobalVariables
Public Class Login
    Public dbconn As New MySqlConnection
    Public sql As String
    Public dbcomm As New MySqlCommand
    Public dbread As MySqlDataReader



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        dbconn = New MySqlConnection("server=localhost;user=admin;password=123456;database=clinica;")

        Try
            dbconn.Open()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try
    End Sub
    Private Sub buttonLogin_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click
        Dim email As String = inputEmail.Text
        Dim password As String = inputPassword.Text

        sql = "SELECT * FROM usuario where email ='" + email + " ' "


        Try
            dbcomm = New MySqlCommand(sql, dbconn)
            dbread = dbcomm.ExecuteReader()

            If (dbread.HasRows) Then
                While dbread.Read
                    If (Decrypt(dbread("password").ToString()) = password) Then
                        If (dbread("tipo").ToString() = "1") Then

                            GlobalVariables.userId = dbread("id")
                            GlobalVariables.userName = dbread("nombre")
                            enterHomeDoctor()

                        ElseIf (dbread("tipo").ToString() = "2") Then
                            GlobalVariables.userId = dbread("id")
                            GlobalVariables.userName = dbread("nombre")
                            enterHomeUser()
                        End If

                        MessageBox.Show("Login sucess Welcome to Homepage " + dbread("nombre").ToString())
                    Else
                        MessageBox.Show("Contrasena Incorrecta ")
                    End If

                End While

            Else
                MessageBox.Show("Incorrect  email")
            End If
        Catch ex As Exception
            MsgBox("Problem loading data: " & ex.Message.ToString)
        End Try
        dbread.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub RegistrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarToolStripMenuItem.Click
        Registrar.Show()
    End Sub

    Public Function Decrypt(ByVal cipherText As String) As String
        Dim passPhrase As String = "yourPassPhrase"
        Dim saltValue As String = "mySaltValue"
        Dim hashAlgorithm As String = "SHA1"

        Dim passwordIterations As Integer = 2
        Dim initVector As String = "@1B2c3D4e5F6g7H8"
        Dim keySize As Integer = 256
        ' Convert strings defining encryption key characteristics into byte
        ' arrays. Let us assume that strings only contain ASCII codes.
        ' If strings include Unicode characters, use Unicode, UTF7, or UTF8
        ' encoding.
        Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
        Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)

        ' Convert our ciphertext into a byte array.
        Dim cipherTextBytes As Byte() = Convert.FromBase64String(cipherText)

        ' First, we must create a password, from which the key will be 
        ' derived. This password will be generated from the specified 
        ' passphrase and salt value. The password will be created using
        ' the specified hash algorithm. Password creation can be done in
        ' several iterations.
        Dim password As New PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)

        ' Use the password to generate pseudo-random bytes for the encryption
        ' key. Specify the size of the key in bytes (instead of bits).
        Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)

        ' Create uninitialized Rijndael encryption object.
        Dim symmetricKey As New RijndaelManaged()

        ' It is reasonable to set encryption mode to Cipher Block Chaining
        ' (CBC). Use default options for other symmetric key parameters.
        symmetricKey.Mode = CipherMode.CBC

        ' Generate decryptor from the existing key bytes and initialization 
        ' vector. Key size will be defined based on the number of the key 
        ' bytes.
        Dim decryptor As ICryptoTransform = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes)

        ' Define memory stream which will be used to hold encrypted data.
        Dim memoryStream As New MemoryStream(cipherTextBytes)

        ' Define cryptographic stream (always use Read mode for encryption).
        Dim cryptoStream As New CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)

        ' Since at this point we don't know what the size of decrypted data
        ' will be, allocate the buffer long enough to hold ciphertext;
        ' plaintext is never longer than ciphertext.
        Dim plainTextBytes As Byte() = New Byte(cipherTextBytes.Length - 1) {}

        ' Start decrypting.
        Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)

        ' Close both streams.
        memoryStream.Close()
        cryptoStream.Close()

        ' Convert decrypted data into a string. 
        ' Let us assume that the original plaintext string was UTF8-encoded.
        Dim plainText As String = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount)

        ' Return decrypted string.   
        Return plainText
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        HomeUser.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        HomeDoctor.Show()
    End Sub

    Private Sub enterHomeDoctor()
        Me.Hide()
        HomeDoctor.Show()

    End Sub

    Private Sub enterHomeUser()
        Me.Hide()
        HomeUser.Show()

    End Sub




End Class