Imports System.Speech

Public Class Form1
    Public synth As New Speech.Synthesis.SpeechSynthesizer
    Public WithEvents recognizer As New Speech.Recognition.SpeechRecognitionEngine
    Dim gram As New System.Speech.Recognition.DictationGrammar()

    Public Sub gotspeech(ByVal sender As Object, ByVal phrase As System.Speech.Recognition.RecognitionEventArgs) Handles recognizer.SpeechRecognized
        TextBox1.Text += phrase.Result.Text + " "
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.ForeColor = Color.NavajoWhite
        GroupBox1.ForeColor = Color.Navy
        GroupBox2.ForeColor = Color.Navy
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        AxWindowsMediaPlayer1.close()
        End
    End Sub

    Private Sub OPENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OPENToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
        recognizer.LoadGrammarAsync(gram)
        recognizer.SetInputToDefaultAudioDevice()
        recognizer.RecognizeAsync(Recognition.RecognizeMode.Multiple)
    End Sub

End Class

