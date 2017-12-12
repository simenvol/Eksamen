Public Class Admin
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'sets default for dropdown, and calls sub to populate adminlist
        Adminmaleridropdown.SelectedIndex = 0
        adminlist()
    End Sub

    Private Sub bacceptbid_Click(sender As Object, e As EventArgs) Handles BAcceptbid.Click 'updates status to sold for given painting, and updates income
        Dim painting As Integer
        painting = Adminmaleridropdown.Text

        Frontform.updatestatus(painting)
        updateincome()
    End Sub

    Private Sub BClearbids_Click(sender As Object, e As EventArgs) Handles BClearbids.Click 'reset auction for given painting, and updates income and adminlist
        Dim painting As Integer
        painting = Adminmaleridropdown.Text

        Frontform.Resetauctio(painting)
        updateincome()
        adminlist()
    End Sub
    'Magnus er nørd
    Private Sub updateincome() 'calculates total sales by adding up highest bid of paintings where status is sold
        Dim sumsales As String
        Dim newbid As String


        For i = 0 To 4
            newbid = Frontform.getbid(i, 0, 0)
            If IsNumeric(newbid) Then 'must set newbid "" to 0 to avoid compiler issues
            Else
                newbid = 0
            End If
            If Frontform.getstatus(i) = True Then
                sumsales = CInt(sumsales) + CInt(newbid)
            End If
        Next i
        If sumsales = "" Then
            sumsales = 0
        End If

        Profitinfo.Text = "Dagens inntekt så langt er " & sumsales & " kroner"
    End Sub

    Private Sub adminlist() 'populates adminlist
        Dim painting As Integer
        painting = Adminmaleridropdown.Text

        With Adminlistbox.Items
            .Clear()
            .Add("Høyeste bud er " & Frontform.getbid(painting - 1, 0, 0))
            .Add("Gitt av nummer " & Frontform.getbid(painting - 1, 0, 1))
            .Add(" ")
            .Add("Nest høyeste bud er " & Frontform.getbid(painting - 1, 1, 0))
            .Add("Gitt av nummer " & Frontform.getbid(painting - 1, 1, 1))

        End With
    End Sub

    Private Sub adminmaleridropdown_SelectedIndexChanged(ByVal sender As Object,'populates adminlist when painting is changed from dropdown
        ByVal e As System.EventArgs) Handles Adminmaleridropdown.SelectedIndexChanged
        adminlist()
    End Sub
End Class