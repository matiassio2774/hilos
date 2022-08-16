Imports System.Threading

Public Class Form1
    Inherits System.Windows.Forms.Form
    <STAThread()>
    Public Shared Sub Main()
        'crear 2 hilos diferentes, cada hilo se enlaza con un método para iniciar los formularios
        Dim hilo1 As New Thread(AddressOf Ventana1)
        Dim hilo2 As New Thread(AddressOf Ventana2)
        'después se arrancan los 2 hilos
        hilo1.Start()
        hilo2.Start()
    End Sub

    Public Shared Sub Ventana1()
        Application.Run(New Form1)
    End Sub
    'procedimiento que muestra el segundo formulario
    Public Shared Sub Ventana2()
        Application.Run(New Form2)
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Me.Show()
        Dim parar As Integer
        Do While parar < 1000
            Me.Label1.Text = parar.ToString()
            parar = parar + 1
        Loop
        Form2.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'posición del formulario
        Me.Top = 220
        Me.Left = 220
    End Sub
End Class
