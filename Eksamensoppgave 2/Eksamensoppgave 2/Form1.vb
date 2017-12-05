Public Class Form1
    Public array(0, 3) As String
    Public counter As Integer

    Public Function antall(ByVal handling As Integer) As Integer 'finner antallet barn og voksne, skriver deretter ut i label. Teller også antall kaker samt regner ut forventet inntekt
        Dim kaker, voksne, barn, budsjett As Integer


        For i = 0 To counter - 1
            voksne = voksne + CInt(array(i, 2))
            barn = barn + 1 + CInt(array(i, 1))
            If array(i, 3) = "Tar med kake" Then
                kaker = kaker + 1
            End If
        Next i

        Select Case handling
            Case 0
                Label7.Text = voksne
                Label5.Text = barn
                Label9.Text = voksne + barn
                Label11.Text = kaker

            Case 1
                budsjett = (voksne * 50) + (barn * 25) - (kaker * 20)
                Return budsjett
        End Select
    End Function

    Public Sub makelist()
        Dim navn As String
        Dim karakterer As Integer

        navn = UCase(TextBox1.Text)
        karakterer = navn.Length

        ListBox1.Items.Clear()

        If navn = "" Then 'sjekker om en må filtrere på navn

            If CheckBox1.Checked = False Then 'sjekker om vanlig liste skal lages, eller liste kun med kaker
                For i = 0 To counter - 1
                    tolistbox(i)
                Next i
            Else
                For i = 0 To counter - 1

                    If array(i, 3) = "Tar med kake" Then
                        tolistbox(i)
                    End If

                Next i
            End If

        Else

            If CheckBox1.Checked = False Then 'sjekker om vanlig liste skal lages, eller liste kun med kaker
                For i = 0 To counter - 1
                    If navn = Mid(array(i, 0), 1, karakterer) Then
                        tolistbox(i)
                    End If
                Next i
            Else
                For i = 0 To counter - 1
                    If navn = Mid(array(i, 0), 1, karakterer) Then
                        If array(i, 3) = "Tar med kake" Then
                            tolistbox(i)
                        End If
                    End If
                Next i
            End If

        End If


    End Sub

    Public Sub tolistbox(ByVal i As String)
        ListBox1.Items.Add(array(i, 0))
        ListBox1.Items.Add("Antall ekstra barn: " & array(i, 1) & vbTab & "Antall voksne: " & array(i, 2) & vbTab & array(i, 3))
        ListBox1.Items.Add("")
    End Sub

    Public Function Winner() As String
        Dim vinnertall As Integer

        vinnertall = Int((UBound(array) - LBound(array)) * Rnd() + LBound(array))
        Return array(vinnertall, 0)
    End Function

    Public Sub language(ByVal lang As String)
        Select Case lang

            Case "eng"
                Label1.Text = "Sign up for our Christmas Party"
                Button1.Text = "Sign up here"
                Label2.Text = "Search attendees"
                Label3.Text = "Attendees"
                Label4.Text = "Attending kids"
                Label6.Text = "Attending adults"
                Button2.Text = "Admin log in"
                Label10.Text = "Number of cakes"
                Label8.Text = "Attending"
                CheckBox1.Text = "Show only attendees with cake"

            Case "no"
                Label1.Text = "Påmelding til juletrefest"
                Button1.Text = "Meld dere på her"
                Label2.Text = "Søk blant påmeldte"
                Label3.Text = "Påmeldte"
                Label4.Text = "Påmeldte barn"
                Label6.Text = "Påmeldte voksne"
                Button2.Text = "Admininnlogging"
                Label10.Text = "Antall kaker"
                CheckBox1.Text = "Kun påmeldte med kake"

        End Select

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim marray(UBound(array) + 1, 3), navn, barn, voksne, kake As String

        Dim navnetest As Integer

        navn = InputBox("Vennligst legg inn navn på barn")
        barn = InputBox("Antall barn som kommer i tillegg")
        voksne = InputBox("Antall voksne som kommer i tillegg")
        kake = MessageBox.Show("Kan dere ta med kake?", "Kake", MessageBoxButtons.YesNo)


        If kake = 6 Then 'gjør om tallverdi til ja/nei
            kake = "Tar med kake"
        Else
            kake = "Tar ikke med kake"
        End If


        If IsNumeric(barn + voksne) And navn <> "" Then
            'MsgBox(counter)

            For i = 0 To counter - 1 'sammenlikner innlagt navn med navn i array
                If UCase(navn) = array(i, 0) Then
                    navnetest = 1
                End If
            Next

            If navnetest = 1 Then
                navnetest = MessageBox.Show("Et barn ved navn " & navn & " er allerede påmeldt. Ønsker dere fortsatt å melde på " & navn, "Kake", MessageBoxButtons.YesNo)
            End If

            If navnetest <> 7 Then 'om man velger nei i messagebox over, hoppes registrering over

                If counter <> 0 Then 'man trenger ikke redimme for første tuppel

                    For i = 0 To counter - 1 'overfører array til midlertidig lagring for å redime med ny størrelse
                        For j = 0 To 3
                            marray(i, j) = array(i, j)
                        Next j
                    Next i
                    ReDim array(counter + 1, 3)

                    For i = 0 To counter - 1
                        For j = 0 To 3
                            array(i, j) = marray(i, j)
                        Next j
                    Next i
                End If

                'MsgBox(array(0, 0) & marray(0, 0) & array(0, 3) & marray(0, 3))

                array(counter, 0) = UCase(navn)
                array(counter, 1) = barn
                array(counter, 2) = voksne
                array(counter, 3) = kake

                'MsgBox(array(0, 0) & marray(0, 0) & array(0, 3) & marray(0, 3))
                counter = counter + 1
                makelist()

                antall(0)
            End If

        Else
            MsgBox("Verdier ble ikke korrekt fylt inn. Påmelding er ikke registrert, vennligst forsøk igjen")

        End If



    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        makelist() 'kaller makelist hver gang noe legges inn i søkefeltet
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        language("eng") 'kaller funksjon language med eng
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        language("no") 'kaller funksjonen language med no
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If counter <> 0 Then
            makelist() 'endrer liste ved endring i avsjekking
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim brukernavn, passord As String
        brukernavn = InputBox("Legg inn brukernavn")
        passord = InputBox("Legg inn passord")

        If brukernavn = "jule" And passord = "nisse" Then
            Form2.ShowDialog()
        Else
            MsgBox("Feil brukernavn eller passord oppgitt")
        End If
    End Sub
End Class
