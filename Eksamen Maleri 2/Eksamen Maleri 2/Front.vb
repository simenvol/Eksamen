Public Class Frontform
    Public mainarray(4, 1, 1) As String
    Public issold(4) As Boolean


    Private Sub Frontform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Maleridropdown.SelectedIndex = 0 'set painting 1 as default
        MakeList() 'calls sub to poupulate list
    End Sub

    ''' <summary>
    ''' Updates mainarray after checking input
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim painting As Integer
        Dim inputbid, inputnumber As String
        painting = Maleridropdown.Text

        If issold(painting - 1) = False Then

            inputbid = InputBox("Vennligst legg inn ønsket bud")
            inputnumber = InputBox("Vennligst legg inn ditt telefonnummer")

            If IsNumeric(inputbid) = True And IsNumeric(inputnumber) = True Then


                If inputbid > CInt(mainarray(painting - 1, 0, 0)) Then

                    mainarray(painting - 1, 1, 0) = mainarray(painting - 1, 0, 0)
                    mainarray(painting - 1, 1, 1) = mainarray(painting - 1, 0, 1)

                    mainarray(painting - 1, 0, 0) = inputbid
                    mainarray(painting - 1, 0, 1) = inputnumber

                Else

                    MsgBox("Ditt bud var ikke høyt nok")

                End If

            Else
                MsgBox("Du la ikke inn gyldige verdier")
            End If
        Else
            MsgBox("Auksjonen for dette maleriet er stengt")
        End If
        MakeList()
    End Sub
    ''' <summary>
    ''' populates listbox with values
    ''' </summary>
    Private Sub MakeList()
        Dim soldstatus, raisestatus As String
        Paintinglist.Items.Clear()


        For i = 0 To 4
            If mainarray(i, 0, 1) = mainarray(i, 1, 1) Then
                raisestatus = " Økning"
            Else
                raisestatus = ""
            End If
            If mainarray(i, 1, 1) = "" Then
                raisestatus = ""
            End If

            If issold(i) = True Then
                soldstatus = "Maleri Solgt"
            Else
                soldstatus = "Ikke solgt"
            End If

            If mainarray(i, 0, 0) = "" Then
                mainarray(i, 0, 0) = 0
            End If
            Paintinglist.Items.Add("Maleri " & i + 1)
            Paintinglist.Items.Add(soldstatus & vbTab & " Høyeste bud er " & mainarray(i, 0, 0) & vbTab & raisestatus)
            Paintinglist.Items.Add(" ")

        Next i

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'requires password to open adminform
        Dim password As String
        password = InputBox("Vennligst legg inn passord(ntnu)")
        If password = "ntnu" Then
            Admin.ShowDialog()
        Else
            MsgBox("Feil passord oppgitt")
        End If
    End Sub

    Public Sub updatestatus(painting As Integer) 'updates status sold/not sold for given painting
        issold(painting - 1) = True
        MakeList()
    End Sub

    Public Sub Resetauctio(painting As Integer) 'sets all values associated with given painting to "" and false
        mainarray(painting - 1, 0, 0) = ""
        mainarray(painting - 1, 0, 1) = ""
        mainarray(painting - 1, 1, 0) = ""
        mainarray(painting - 1, 1, 1) = ""
        issold(painting - 1) = False
        MakeList()
    End Sub

    Public Function getbid(ByVal painting As Integer, number As Integer, info As Integer) As String 'return arrayvalue of given array position
        Return mainarray(painting, number, info)
    End Function

    Public Function getstatus(ByVal painting As Integer) As Boolean 'returns status sold/not sold of given painting

        Return issold(painting)
    End Function

End Class
