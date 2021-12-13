Public Class Eléments_de_commande__d_information

   
    Private Sub Eléments_de_commande__d_information_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        header.Width = Me.Width
        header.Height = 100

        lblInspectionNo.Text = Handler.InspNo
        lblInspectorID.Text = Handler.InspectorID
        lblPlate.Text = Handler.Plate
    End Sub

    Private Sub btnFeuxRoute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFeuxRoute.Click
        'Témoin_de_feux_de_route.Label1.Text = Label1.Text
        Témoin_de_feux_de_route.Label2.Text = Label2.Text
        Témoin_de_feux_de_route.Label3.Text = Label3.Text
        Témoin_de_feux_de_route.Label4.Text = Label5.Text

        Témoin_de_feux_de_route.Show()
       Me.Dispose()


    End Sub


    Private Sub btnSignalDetresse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignalDetresse.Click
        'Témoin_de_signal_de_détresse.Label1.Text = Label1.Text
        Témoin_de_signal_de_détresse.Label2.Text = Label2.Text
        Témoin_de_signal_de_détresse.Label3.Text = Label3.Text
        Témoin_de_signal_de_détresse.Label4.Text = Label6.Text

        Témoin_de_signal_de_détresse.Show()
       Me.Dispose()
    End Sub

    Private Sub btnBrouillardAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrouillardAR.Click
        '  Témoin_de_feux_de_brouillard_AR.Label1.Text = Label1.Text
        Témoin_de_feux_de_brouillard_AR.Label2.Text = Label2.Text
        Témoin_de_feux_de_brouillard_AR.Label3.Text = Label3.Text
        Témoin_de_feux_de_brouillard_AR.Label4.Text = Label7.Text

        Témoin_de_feux_de_brouillard_AR.Show()
       Me.Dispose()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        '  Temoindeclairageetdesignalisation.Label1.Text = Label1.Text
        Temoindeclairageetdesignalisation.Label2.Text = Label2.Text
        Temoindeclairageetdesignalisation.Label3.Text = Label3.Text
        Temoindeclairageetdesignalisation.Label4.Text = Label8.Text

        Temoindeclairageetdesignalisation.Show()
       Me.Dispose()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ' Témoin_indicateur_de_direction.Label1.Text = Label1.Text
        Témoin_indicateur_de_direction.Label2.Text = Label2.Text
        Témoin_indicateur_de_direction.Label3.Text = Label3.Text
        Témoin_indicateur_de_direction.Label4.Text = Label9.Text

        Témoin_indicateur_de_direction.Show()
       Me.Dispose()
    End Sub


    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        'My.Forms.Defects.lblCarDefect.Text = Label1.Text
        Defects.Show()
       Me.Dispose()
    End Sub
End Class