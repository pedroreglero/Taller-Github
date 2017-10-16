Option Strict On
Module Module1

    Sub Main()
        Dim contrasena1, contrasena2 As String
        Dim aceptado As Boolean = False
        Console.WriteLine("Introduzca su contraseña")
        contrasena1 = Console.ReadLine()
        Console.WriteLine("Repita la contraseña")
        contrasena2 = Console.ReadLine()
        'aceptado = contrasena1 = contrasena2'
        'Igual a:'
        If contrasena1 = contrasena2 Then
            aceptado = True
        Else
            aceptado = False
        End If
        'Como las varibles booleanas siempre se inicializan como False, no hace falta poner aceptado = False'
        If aceptado Then
                Console.WriteLine("¡Contraseñas correctas!")
            Else
                Console.WriteLine("Contraseñas incorrectas")
            End If
            Console.ReadLine()
    End Sub

End Module
