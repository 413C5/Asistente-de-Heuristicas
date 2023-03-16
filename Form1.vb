Public Class frmPrincipal
    'Autor:Alejandro Gonzalez Zarate
#Region "Atributos"
    'Matricula de estudiante 620115859
    'Termina en 59->Impar
    'Private Posicion As Integer
    Dim componenteIPM() As String = {"Para los usuarios, es mucho más fácil reconocer lo que tienen que hacer, cuando el entorno provee pistas. Los usuarios perciben las pistas, las envían a la memoria de trabajo y esta les recuerda a los usuarios sobre el conocimiento que tienen almacenado en la memoria de largo plazo.",
        "Si la computadora, ya sea de manera visual o auditiva, no provee a los usuarios con información de su procesamiento, no tendrán el conocimiento necesario para comprender lo que esta pasando ni las funciones que está realizando el sistema.",
        "Hay varios motivos que hacen que el usuario cometa errores de percepción, deficiencia en la comprensión de lo que deben hacer, recuerdo de un aspecto de un comando en vez de recordar la sintaxis precisa—o en ocasiones cometen un error de dedo. Algunos de estos errores se pueden prevenir de la siguiente manera, que la interfaz muestre solamente las acciones que se puedan realizar en un momento dado (por ejemplo, sombreando los botones que no generan una acción válida en cierto momento). Otro tipo de errores se pueden detectar al momento que el usuario los comete ( por ejemplo, cuando una interfaz no permite que se utilice una abreviación incorrecta de un estado de la república en una dirección).",
        "Esta heurística está relacionada con el aspecto de búsqueda visual de la percepción y memoria. Entre más amontonada esté la pantalla, el usuario batallará más para encontrar la información deseada. Además, entre más información llegue a la memoria de trabajo a través de la percepción de la búsqueda visual, más trabajo tendrá la memoria de largo plazo para inferir que información es relevante y cual no.",
        "Los usuarios cometerán errores; así pues, necesitan una forma sencilla para recuperarse de estos errores."}
#End Region

#Region "Metodos"
    ''' <summary>
    ''' Asigna un IPM al cuadro de texto
    ''' </summary>
    ''' <param name="valor"></param>
    Private Sub AsignarIPM(ByVal valor As Integer)
        Dim indice As Integer = valor
        Try
            'Seleccion de texto
            Select Case indice
                Case 0
                    txtTexto.Text = componenteIPM(0)
                Case 1
                    txtTexto.Text = componenteIPM(1)
                Case 2
                    txtTexto.Text = componenteIPM(2)
                Case 3
                    txtTexto.Text = componenteIPM(3)
                Case 4
                    txtTexto.Text = componenteIPM(4)
            End Select
        Catch
        End Try
    End Sub

    ''' <summary>
    ''' Busca la primera coincidencia de un String de 3 caracteres o más, en todos los textos IPM
    ''' </summary>
    ''' <param name="palabra"></param>
    Private Sub Buscar(ByVal palabra As String)
        'Atributos
        Dim indice As Integer = 0
        Dim texto As String = ""
        Dim mensaje, estilo, titulo As String
        Dim respuesta As Integer = 0

        Try
            'Si no tengo texto en el txtPalabra
            If String.IsNullOrEmpty(palabra) Then
                Throw New ArgumentException

                'Si mi longitud de palabra es < a 3
            ElseIf palabra.Length < 3 Then
                mensaje = "Por favor ingrese un String que sea de 3 caracteres o más"
                estilo = vbInformation
                titulo = "String invalido"
                respuesta = MsgBox(mensaje, estilo, titulo)
                txtTexto.Text = "Por favor ingrese un String que sea de 3 caracteres o más"
                'Entra a buscar la palabra  
            Else
                mensaje = "Solamente se presenta la primera relación encontrada que contiene la palabra clave. Por lo tanto, se recomienda que las palabras claves sean tan auténticas como sea posible."
                estilo = vbInformation
                titulo = "Solo la primera"

                respuesta = MsgBox(mensaje, estilo, titulo)
                'Recorre en todos los arreglos
                While indice < 5
                    'Evalua si encuentra ocurrencia en un texto
                    If componenteIPM(indice).IndexOf(palabra, 0) <> -1 Then
                        Select Case indice
                            Case 0
                                texto = "Reconocer en vez de recordar:" + Environment.NewLine + Environment.NewLine
                            Case 1
                                texto = "Visibilidad de Estado del Sistema:" + Environment.NewLine + Environment.NewLine
                            Case 2
                                texto = "Prevencion de Errores:" + Environment.NewLine + Environment.NewLine
                            Case 3
                                texto = "Diseño Estetico y Minimalista:" + Environment.NewLine + Environment.NewLine
                            Case 4
                                texto = "Control y Libertad de Usuario:" + Environment.NewLine + Environment.NewLine
                        End Select
                        'Muestro texto y me salgo
                        txtTexto.Text = texto + componenteIPM(indice)
                        Exit While
                    Else
                        txtTexto.Text = "No se encontraron coincidencias"
                    End If
                    'Aumento indice para buscar en el siguiente
                    indice = indice + 1
                End While
                'Si no encuentra coincidencia

            End If
        Catch ex As ArgumentException
            mensaje = "Por favor ingrese un String de busqueda valido"
            estilo = vbInformation
            titulo = "String invalido"
            respuesta = MsgBox(mensaje, estilo, titulo)
            txtTexto.Text = "Por favor ingrese un String de busqueda valido"


        End Try
    End Sub
#End Region

#Region "Eventos"
    Private Sub btnReconocer_Click(sender As Object, e As EventArgs) Handles btnReconocer.Click
        AsignarIPM(0)
    End Sub
    Private Sub btnVisibilidad_Click(sender As Object, e As EventArgs) Handles btnVisibilidad.Click
        AsignarIPM(1)
    End Sub

    Private Sub btnPrevencion_Click(sender As Object, e As EventArgs) Handles btnPrevencion.Click
        AsignarIPM(2)
    End Sub

    Private Sub btnEstetico_Click(sender As Object, e As EventArgs) Handles btnEstetico.Click
        AsignarIPM(3)
    End Sub

    Private Sub btnControl_Click(sender As Object, e As EventArgs) Handles btnControl.Click
        AsignarIPM(4)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Buscar(txtPalabra.Text)
    End Sub

    Private Sub txtPalabra_TextChanged(sender As Object, e As EventArgs) Handles txtPalabra.TextChanged
        txtTexto.Clear()
    End Sub
#End Region
End Class
