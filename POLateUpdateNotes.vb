Public Class POLateUpdateNotes
    Dim tmpNew As Boolean = True

    Private Sub UpdateNotesPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(1000, 250)

        txtNewNote.Text = tmpNewNote
    End Sub

    Private Sub btnSaveNote_Click(sender As Object, e As EventArgs) Handles btnSaveNote.Click
        If Len(Open_All.txtPONote.Text) > 0 Then tmpNew = False Else tmpNew = True

        Open_All.txtPONote.Text = txtNewNote.Text & vbCrLf & "--------------------------------" & vbCrLf & Open_All.txtPONote.Text
        Open_All.SaveNote(tmpNew)
        tmpNewNote = Nothing
        Me.Close()
    End Sub

    Private Sub btnNotNow_Click(sender As Object, e As EventArgs) Handles btnNotNow.Click
        Me.Close()
    End Sub

    Private Sub CheckedChanged(sender As Object, e As EventArgs) Handles chkCopyElec.CheckedChanged, chkCopyMech.CheckedChanged
        If chkCopyElec.Checked = True Then
            Open_All.chkCopyElec.Checked = True
        Else
            Open_All.chkCopyElec.Checked = False
        End If

        If chkCopyMech.Checked = True Then
            Open_All.chkCopyMech.Checked = True
        Else
            Open_All.chkCopyMech.Checked = False

        End If
    End Sub

End Class