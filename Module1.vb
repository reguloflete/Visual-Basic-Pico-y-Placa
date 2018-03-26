Module Module1

    Sub Main()
        'Declaracion de variables
        'Variables de entrada
        Dim letrasplaca As String
        Dim numericoplaca As Integer
        Dim feriado As Integer
        Dim diasem As String
        Dim hh, mm, ss As Integer

        'Variables de proceso
        Dim band, band2, band3 As Integer 'Banderas para obtener el dia pico y placa
        Dim cent As Integer 'Centinela para el control de ciclo while
        Dim tiempoTotal As Integer

        Console.Write("Hay datos que procesar? 1 (si)/2 (no):  ")
        cent = Console.ReadLine
        'ciclo para datos desconocidos
        While cent = 1
            'Proceso de lectura
            Console.Write("Ingrese las letras de su placa: ")
            letrasplaca = Console.ReadLine
            Console.Write("Ingrese los numeros de su placa: ")
            numericoplaca = Console.ReadLine
            Console.Write("Ingrese el dia de la semana en mayusculas (ej: LUNES): ")
            diasem = Console.ReadLine
            Console.Write("Es feriado? 1 (si)/2 (no):  ")
            feriado = Console.ReadLine
            Console.Write("Hora: ") : hh = Console.ReadLine()
            Console.Write("Minutos: ") : mm = Console.ReadLine()
            Console.Write("Segundos: ") : ss = Console.ReadLine()


            'Cálculo del tiempo total 
            tiempoTotal = hh * 3600 + mm * 60 + ss

            'calculo del ultimo digito
            band = numericoplaca / 10
            band2 = Math.Round(band)
            band2 = band2 * 10

            If numericoplaca < band2 Then
                band2 = band2 - 10
                band3 = numericoplaca - band2
            ElseIf numericoplaca > band2 Then
                band3 = numericoplaca - band2
            Else
                band3 = 0
            End If


            'Verificar si le corresponde pico y placa
            If band3 < 3 Then
                If UCase(diasem) = "LUNES" Then
                    If feriado = 1 Then
                        Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                        
                    Else
                        If tiempoTotal < 25200 Then
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                        ElseIf tiempoTotal < 34200 Then
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " no puede estar en la carretera")
                        ElseIf tiempoTotal < 57600 Then
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                        ElseIf tiempoTotal < 70200 Then
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " no puede estar en la carretera")
                        Else
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                        End If
                    End If
                Else
                    Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                End If
            ElseIf band3 >= 3 And band3 < 5 Then
                If UCase(diasem) = "MARTES" Then
                    If feriado = 1 Then
                        Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                    Else
                        If tiempoTotal < 25200 Then
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                        ElseIf tiempoTotal < 34200 Then
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " no puede estar en la carretera")
                        ElseIf tiempoTotal < 57600 Then
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                        ElseIf tiempoTotal < 70200 Then
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " no puede estar en la carretera")
                        Else
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                        End If
                    End If
                Else
                    Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                End If
            ElseIf band3 >= 5 And band3 < 7 Then
                If UCase(diasem) = "MIERCOLES" Then
                    If feriado = 1 Then
                        Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                    Else
                        If tiempoTotal < 25200 Then
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                        ElseIf tiempoTotal < 34200 Then
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " no puede estar en la carretera")
                        ElseIf tiempoTotal < 57600 Then
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                        ElseIf tiempoTotal < 70200 Then
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " no puede estar en la carretera")
                        Else
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                        End If
                    End If
                Else
                    Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                End If
            ElseIf band3 >= 7 And band3 < 9 Then
                If UCase(diasem) = "JUEVES" Then
                    If feriado = 1 Then
                        Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                    Else
                        If tiempoTotal < 25200 Then
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                        ElseIf tiempoTotal < 34200 Then
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " no puede estar en la carretera")
                        ElseIf tiempoTotal < 57600 Then
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                        ElseIf tiempoTotal < 70200 Then
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " no puede estar en la carretera")
                        Else
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                        End If
                    End If
                Else
                    Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                End If
            ElseIf band3 = 9 Or band3 = 0 Then
                If UCase(diasem) = "VIERNES" Then
                    If feriado = 1 Then
                        Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                    Else
                        If tiempoTotal < 25200 Then
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                        ElseIf tiempoTotal < 34200 Then
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " no puede estar en la carretera")
                        ElseIf tiempoTotal < 57600 Then
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                        ElseIf tiempoTotal < 70200 Then
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " no puede estar en la carretera")
                        Else
                            Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                        End If
                    End If
                Else
                    Console.WriteLine("El automovil con placa " & letrasplaca & numericoplaca & " puede estar en la carretera")
                End If
            End If



            'pregunto si hay mas autos
            Console.WriteLine("Desea ingresar otra placa? (1)Si ,(2)No")
            cent = Console.ReadLine
        End While

        

        Console.WriteLine("Pulse una tecla para continuar")
        Console.ReadKey()
    End Sub

End Module
