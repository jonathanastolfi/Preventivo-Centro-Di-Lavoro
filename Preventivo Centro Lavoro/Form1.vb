Imports Microsoft.VisualBasic.FileIO
Imports System.IO
Imports Microsoft.Win32

Public Class Form1

    Function salvaFile()
        Dim saveWindow As SaveFileDialog = New SaveFileDialog
        Dim PercorsoCartella As String
        Dim vettore(dgw_lav.RowCount - 1, 10) As String
        Dim Separatore As String = ";"
        Dim NomeFileCSV As String

        If dgw_lav.RowCount > 0 Then
            For j As Integer = 0 To dgw_lav.RowCount - 1
                For i As Integer = 0 To 10
                    vettore(j, i) = dgw_lav.Rows(j).Cells(i).Value
                Next
            Next
        End If



        If txt_idlav.Text <> "" Then
            NomeFileCSV = txt_idlav.Text + ".pcl"
        Else
            NomeFileCSV = "lav.pcl"
            txt_idlav.Text = "lav"
        End If

        saveWindow.FileName = txt_idlav.Text
        saveWindow.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        saveWindow.Filter = "pcl files (*.pcl)|*.pcl"
        If saveWindow.ShowDialog = Windows.Forms.DialogResult.OK Then
            PercorsoCartella = System.IO.Path.GetDirectoryName(saveWindow.FileName)
            NomeFileCSV = System.IO.Path.GetFileName(saveWindow.FileName)
            If CreaFileCSV(PercorsoCartella, "\" & NomeFileCSV, vettore, Separatore) Then
                Debug.Print("Caricato file")
                End
            End If
        End If


    End Function
    Function calcolaTotale()
        Dim d As DateTime
        Dim s As String
        Dim totale As Double
        Dim totale2 As Double

        ' MISURE
        Dim V_Av As Integer = New Integer
        Dim N_Pa As Integer = New Integer
        Dim L_Pa As Integer = New Integer
        Dim T_La As Double = New Double
        ' RAPIDO
        Dim V_Ra As Integer = New Integer


        If dgw_lav.Rows.Count > 0 Then
            For j As Integer = 0 To dgw_lav.Rows.Count - 1
                If (dgw_lav.Rows(j).Cells(2).Value <> 0) Then
                    V_Av = dgw_lav.Rows(j).Cells(2).Value
                    N_Pa = dgw_lav.Rows(j).Cells(8).Value
                    L_Pa = dgw_lav.Rows(j).Cells(9).Value
                    V_Ra = trb_rapido.Value * 1000
                    If chk_norapido.Checked Then
                        T_La = (N_Pa * L_Pa) / V_Av + (N_Pa * L_Pa) / V_Ra
                    Else
                        T_La = (N_Pa * L_Pa) / V_Av
                    End If
                    dgw_lav.Rows(j).Cells(10).Value = T_La
                Else
                    ' MsgBox("Per la riga " + Str(j + 1) + " non posso fare il calcolo completo perchè alla cella 3 non può mai esserci 0")
                    dgw_lav.Rows(j).Cells(10).Value = "0"
                End If
            Next

            For j As Integer = 0 To dgw_lav.Rows.Count - 1
                totale2 = totale2 + dgw_lav.Rows(j).Cells(10).Value
            Next

            For j As Integer = 0 To dgw_lav.Rows.Count - 1
                d = (New DateTime()).AddMinutes(dgw_lav.Rows(j).Cells(10).Value)
                s = d.ToString("HH:mm:ss.fff")
                dgw_lav.Rows(j).Cells(10).Value = s
            Next

            d = (New DateTime()).AddMinutes(totale2)
            s = d.ToString("HH:mm:ss.fff")
            txt_tot.Text = s

        End If
    End Function

    Function clearForm()

        If dgw_lav.Rows.Count > 0 Then
            For j As Integer = dgw_lav.Rows.Count - 1 To 0 Step -1
                dgw_lav.Rows.RemoveAt(j)
            Next
        End If

        cmb_lav.SelectedIndex = -1
        txt_commento.Clear()
        txt_idlav.Clear()
        txt_tot.Clear()

    End Function

    Function CreaFileCSV(ByVal CartellaDestinaione As String, ByVal NomeFileCSV As String, ByVal ArrayDati(,) As String, ByVal Separatore As String) As Boolean
        CreaFileCSV = False
        Try
            'Verifico che esiste la cartella di DestinazioneFile
            If IO.Directory.Exists(CartellaDestinaione) = False Then
                'Se la cartella non esiste la crea
                MkDir(CartellaDestinaione)
            End If

            'Aggiungo il PercorsoCompletoFile ex: c:\Nome Cartella\NomeFile.pcl
            Dim csvFile As String = CartellaDestinaione & NomeFileCSV

            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)

            'Dim data As Date = Date.Now()
            'ora la variabile "data" contiene la data e l'ora corrente

            'outFile.WriteLine("Creazione File il " & data)
            'outFile.WriteLine("")

            ' Prendi Lunghezza Max Riga e Collonna dell'Array.
            Dim riga As Integer = ArrayDati.GetUpperBound(0)
            Dim colonna As Integer = ArrayDati.GetUpperBound(1)

            ' Ciclo di tuto l'aray
            For i As Integer = 0 To riga
                For x As Integer = 0 To colonna
                    ' Prendo l'elemento che si trova nella riga = i e colonna = x.
                    Dim cella As String = """" & ArrayDati(i, x) & """"
                    outFile.Write(cella)
                    If x <> colonna Then
                        outFile.Write(Separatore)
                    End If
                Next
                If i <> riga Then
                    outFile.WriteLine()
                End If
            Next

            outFile.Close()

            'Se si vuoe visualizzare il contenuto del file appena creato
            'Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFile))

            'Apri Cartella dove contine il file CSV 
            'System.Diagnostics.Process.Start(CartellaDestinaione)

            Return CreaFileCSV = True
        Catch
            MsgBox("Errore Creazione file CSV", vbCritical, "ERRORE")
            Return CreaFileCSV
        End Try
    End Function

    Function apriFile(Optional nomefile As String = "#")

        Dim apriIlcsv As OpenFileDialog = New OpenFileDialog

        If nomefile = "#" Then
            apriIlcsv.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            apriIlcsv.Filter = "pcl files (*.pcl)|*.pcl"
            apriIlcsv.Multiselect = False

            If (apriIlcsv.ShowDialog() = DialogResult.OK) Then
                txt_idlav.Text = System.IO.Path.GetFileNameWithoutExtension(apriIlcsv.FileName)
                Dim FileName As String = apriIlcsv.FileName

                Using CSVReaderComma As New TextFieldParser(FileName)
                    CSVReaderComma.TextFieldType = FileIO.FieldType.Delimited
                    CSVReaderComma.SetDelimiters(";")

                    Dim numeroRighe As Integer = File.ReadAllLines(FileName).Length
                    Dim vettoreApertura(numeroRighe - 1, 10) As String

                    Dim currentRow As String()
                    Dim j As Integer = 0
                    Dim i As Integer = 0
                    While Not CSVReaderComma.EndOfData
                        Try
                            i = 0
                            currentRow = CSVReaderComma.ReadFields()
                            Dim currentField As String
                            For Each currentField In currentRow
                                vettoreApertura(j, i) = currentField
                                i = i + 1
                            Next
                            j = j + 1
                        Catch ex As MalformedLineException
                            MessageBox.Show("Unknown telemetry file read error. Possible corrupt file", "Read error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End While

                    dgw_lav.Rows.Add(numeroRighe)
                    For k As Integer = 0 To numeroRighe - 1
                        For l As Integer = 0 To 10
                            dgw_lav.Rows(k).Cells(l).Value = vettoreApertura(k, l)
                        Next
                    Next
                End Using
            End If
        Else
            txt_idlav.Text = System.IO.Path.GetFileNameWithoutExtension(nomefile)
            Dim FileName As String = nomefile

            Using CSVReaderComma As New TextFieldParser(FileName)
                CSVReaderComma.TextFieldType = FileIO.FieldType.Delimited
                CSVReaderComma.SetDelimiters(";")

                Dim numeroRighe As Integer = File.ReadAllLines(FileName).Length
                Dim vettoreApertura(numeroRighe - 1, 10) As String

                Dim currentRow As String()
                Dim j As Integer = 0
                Dim i As Integer = 0
                While Not CSVReaderComma.EndOfData
                    Try
                        i = 0
                        currentRow = CSVReaderComma.ReadFields()
                        Dim currentField As String
                        For Each currentField In currentRow
                            vettoreApertura(j, i) = currentField
                            i = i + 1
                        Next
                        j = j + 1
                    Catch ex As MalformedLineException
                        MessageBox.Show("Unknown telemetry file read error. Possible corrupt file", "Read error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End While

                dgw_lav.Rows.Add(numeroRighe)
                For k As Integer = 0 To numeroRighe - 1
                    For l As Integer = 0 To 10
                        dgw_lav.Rows(k).Cells(l).Value = vettoreApertura(k, l)
                    Next
                Next
            End Using
        End If

        calcolaTotale()
    End Function

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        dgw_lav.Rows.Add(cmb_lav.SelectedItem + " - " + txt_commento.Text, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
        cmb_lav.SelectedIndex = -1
        txt_commento.Clear()
        txt_commentoSurplus.Clear()
        txt_ore_surplus.Text = "00"
        txt_minuti_surplus.Text = "00"
        txt_tot.Clear()
        If txt_idlav.Text = "" Then
            txt_idlav.Text = "lav"
        End If
    End Sub
    Private Sub FOGLIOAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FOGLIOAToolStripMenuItem.Click
        tabella_1_foglio_1.Show()
    End Sub

    Private Sub FOGLIOBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FOGLIOBToolStripMenuItem.Click
        tabella_1_foglio_2.Show()
    End Sub

    Private Sub FOGLIOAToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FOGLIOAToolStripMenuItem1.Click
        tabella_2_foglio_1.Show()
    End Sub

    Private Sub FOGLIOBToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FOGLIOBToolStripMenuItem1.Click
        tabella_2_foglio_2.Show()
    End Sub

    Private Sub FOGLIOAToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles FOGLIOAToolStripMenuItem2.Click
        tabella_3_foglio_1.Show()
    End Sub

    Private Sub FOGLIOBToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles FOGLIOBToolStripMenuItem2.Click
        tabella_3_foglio_2.Show()
    End Sub

    Private Sub SalvaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalvaToolStripMenuItem.Click
        salvaFile()
    End Sub

    Private Sub NuovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuovoToolStripMenuItem.Click
        If (MsgBox("È consigliato il salvataggio su file prima di proseguire ,vuoi salvare?", MsgBoxStyle.YesNo, "SALVATAGGIO DI SICUREZZA") = MsgBoxResult.Yes) Then
            salvaFile()
        End If
        clearForm()
    End Sub

    Private Sub ChiudiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiudiToolStripMenuItem.Click
        If (MsgBox("È consigliato il salvataggio su file prima di proseguire ,vuoi salvare?", MsgBoxStyle.YesNo, "SALVATAGGIO DI SICUREZZA") = MsgBoxResult.Yes) Then
            salvaFile()
        End If
        End
    End Sub

    Private Sub ApriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApriToolStripMenuItem.Click
        If (MsgBox("È consigliato il salvataggio su file prima di proseguire ,vuoi salvare?", MsgBoxStyle.YesNo, "SALVATAGGIO DI SICUREZZA") = MsgBoxResult.Yes) Then
            salvaFile()
        End If
        clearForm()
        apriFile()
    End Sub

    Private Sub btn_calc_Click(sender As Object, e As EventArgs) Handles btn_calc.Click
        calcolaTotale()
    End Sub

    Private Sub trb_rapido_Scroll(sender As Object, e As EventArgs) Handles trb_rapido.Scroll
        lbl_speed.Text = trb_rapido.Value
    End Sub

    Private Sub chk_norapido_CheckedChanged(sender As Object, e As EventArgs) Handles chk_norapido.CheckedChanged
        If chk_norapido.Checked Then
            trb_rapido.Enabled = True
        Else
            trb_rapido.Enabled = False
        End If
        calcolaTotale()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If (MsgBox("È consigliato il salvataggio su file prima di proseguire ,vuoi salvare?", MsgBoxStyle.YesNo, "SALVATAGGIO DI SICUREZZA") = MsgBoxResult.Yes) Then
            salvaFile()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            apriFile(My.Application.CommandLineArgs.First())
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_surplus_Click(sender As Object, e As EventArgs) Handles btn_surplus.Click
        txt_commentoSurplus.Text = cmb_lav.SelectedItem + " - " + txt_commento.Text
    End Sub

    Private Sub btn_conferma_surplus_Click(sender As Object, e As EventArgs) Handles btn_conferma_surplus.Click
        'determino il totale dei minuti
        Dim passata_surplus As Integer = New Integer

        passata_surplus = txt_ore_surplus.Text * 60 + txt_minuti_surplus.Text

        dgw_lav.Rows.Add(txt_commentoSurplus.Text, 0, 1, 0, 0, 0, 0, 0, 1, passata_surplus, txt_ore_surplus.Text + ":" + txt_minuti_surplus.Text + ":00.000")
        cmb_lav.SelectedIndex = -1
        txt_commento.Clear()
        txt_commentoSurplus.Clear()
        txt_ore_surplus.Text = "00"
        txt_minuti_surplus.Text = "00"
        txt_tot.Clear()
        If txt_idlav.Text = "" Then
            txt_idlav.Text = "lav"
        End If
    End Sub
End Class
