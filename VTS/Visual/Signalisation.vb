Public Class Signalisation

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Forms.Feu_de_position.Label2.Text = Label2.Text
        My.Forms.Feu_de_position.Label3.Text = Label3.Text
        My.Forms.Feu_de_position.Label4.Text = Label8.Text
        Feu_de_position.Show()
        Me.Dispose()



    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        My.Forms.Feu_indicateur_de_direction.Label2.Text = Label2.Text
        My.Forms.Feu_indicateur_de_direction.Label3.Text = Label3.Text
        My.Forms.Feu_indicateur_de_direction.Label4.Text = Label9.Text
        Feu_indicateur_de_direction.Show()
        Me.Dispose()

    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        My.Forms.Signal_de_détresse_Flasher.Label2.Text = Label2.Text
        My.Forms.Signal_de_détresse_Flasher.Label3.Text = Label3.Text
        My.Forms.Signal_de_détresse_Flasher.Label4.Text = Label10.Text
        Signal_de_détresse_Flasher.Show()
        Me.Dispose()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        My.Forms.Feu_de_stop.Label2.Text = Label2.Text
        My.Forms.Feu_de_stop.Label3.Text = Label3.Text
        My.Forms.Feu_de_stop.Label4.Text = Label11.Text
        Feu_de_stop.Show()
        Me.Dispose()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        My.Forms.Troisiéme_feu_stop.Label2.Text = Label2.Text
        My.Forms.Troisiéme_feu_stop.Label3.Text = Label3.Text
        My.Forms.Troisiéme_feu_stop.Label4.Text = Label12.Text
        Troisiéme_feu_stop.Show()
        Me.Dispose()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        My.Forms.Feu_de_plaque_AR.Label2.Text = Label2.Text
        My.Forms.Feu_de_plaque_AR.Label3.Text = Label3.Text
        My.Forms.Feu_de_plaque_AR.Label4.Text = Label13.Text
        Feu_de_plaque_AR.Show()
        Me.Dispose()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        My.Forms.Feu_de_brouillard_AR.Label2.Text = Label2.Text
        My.Forms.Feu_de_brouillard_AR.Label3.Text = Label3.Text
        My.Forms.Feu_de_brouillard_AR.Label4.Text = Label14.Text
        Feu_de_brouillard_AR.Show()
        Me.Dispose()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        My.Forms.Feu_de_recul.Label2.Text = Label2.Text
        My.Forms.Feu_de_recul.Label3.Text = Label3.Text
        My.Forms.Feu_de_recul.Label4.Text = Label15.Text
        Feu_de_recul.Show()
        Me.Dispose()

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click


        My.Forms.Feu_de_gabarit.Label2.Text = Label2.Text
        My.Forms.Feu_de_gabarit.Label3.Text = Label3.Text
        My.Forms.Feu_de_gabarit.Label4.Text = Label16.Text
        Feu_de_gabarit.Show()
        Me.Dispose()

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        My.Forms.Catadioptre_AR.Label2.Text = Label2.Text
        My.Forms.Catadioptre_AR.Label3.Text = Label3.Text
        My.Forms.Catadioptre_AR.Label4.Text = Label17.Text
        Catadioptre_AR.Show()
        Me.Dispose()

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

        My.Forms.Catadioptre_lateral.Label2.Text = Label2.Text
        My.Forms.Catadioptre_lateral.Label3.Text = Label3.Text
        My.Forms.Catadioptre_lateral.Label4.Text = Label18.Text
        Catadioptre_lateral.Show()
        Me.Dispose()

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click

        My.Forms.Triangle_de_pré_signalisation__en_labsence_de_signal_de_détresse__.Label2.Text = Label2.Text
        My.Forms.Triangle_de_pré_signalisation__en_labsence_de_signal_de_détresse__.Label3.Text = Label3.Text
        My.Forms.Triangle_de_pré_signalisation__en_labsence_de_signal_de_détresse__.Label4.Text = Label19.Text
        Triangle_de_pré_signalisation__en_labsence_de_signal_de_détresse__.Show()
        Me.Dispose()

    End Sub


    Private Sub btnEscSign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEscSign.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
        Me.Dispose()
    End Sub

    Private Sub Signalisation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub
End Class