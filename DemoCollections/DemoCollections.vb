Public Class frmDemoCollections

    Private studentList As New List(Of Student)

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddList.Click


        Dim student As New Student()

        student.Name = txtNameList.Text

        studentList.Add(student)

        txtOutputList.Clear()

        For Each student In studentList

            txtOutputList.Text += student.GetStudentData() & vbCrLf

        Next student



    End Sub

    Private Sub btnSelectList_Click(sender As Object, e As EventArgs) Handles btnSelectList.Click

        Dim identificationNumber As String = txtListIdentificationNumber.Text.Trim()
        Dim found As Boolean = False

        txtOutputList.Clear()

        For index As Integer = 0 To studentList.Count - 1

            If studentList(index).IdentificationNumber.ToString() = identificationNumber Then

                txtOutputList.Text = studentList(index).GetStudentData

                found = True

                index = studentList.Count

            End If


        Next index


        If found = False Then

            txtOutputList.Text = "This identification number does not exist.!"

        End If

    End Sub


    Private studentArrayList As New ArrayList

    Private Sub btnAddArrayList_Click(sender As Object, e As EventArgs) Handles btnAddArrayList.Click

        Dim student As New Student()

        student.Name = txtNameArrayList.Text

        studentArrayList.Add(student)

        txtOutputArrayList.Clear()

        For Each student In studentArrayList

            txtOutputArrayList.Text += student.GetStudentData() & vbCrLf

        Next student

    End Sub

    Private Sub btnSelectArrayList_Click(sender As Object, e As EventArgs) Handles btnSelectArrayList.Click

        Dim identificationNumber As String = txtArrayListIdentificationNumber.Text.Trim()
        Dim found As Boolean = False

        txtOutputArrayList.Clear()

        For index As Integer = 0 To studentArrayList.Count - 1

            If studentArrayList(index).IdentificationNumber.ToString() = identificationNumber Then

                txtOutputArrayList.Text = studentArrayList(index).GetStudentData

                found = True

                index = studentArrayList.Count

            End If

        Next index

        If found = False Then

            txtOutputArrayList.Text = "This identification number does not exist.!"

        End If

    End Sub

    Private studentSortedListKey As New SortedList()

    Private Sub btnAddSortedListKey_Click(sender As Object, e As EventArgs) Handles btnAddSortedListKey.Click

        Dim student As New Student()

        student.Name = txtNameSortedListKey.Text

        studentSortedListKey.Add(student.IdentificationNumber.ToString(), student)

        txtOutputSortedListKey.Clear()

        For Each studentEntry As DictionaryEntry In studentSortedListKey

            txtOutputSortedListKey.Text += CType(studentEntry.Value, Student).GetStudentData() & vbCrLf

        Next studentEntry

    End Sub

    Private Sub btnSelectSortedListKey_Click(sender As Object, e As EventArgs) Handles btnSelectSortedListKey.Click

        Dim identificationNumber As String = txtSortedListKeyIdentificationNumber.Text

        txtOutputSortedListKey.Clear()

        If studentSortedListKey.ContainsKey(identificationNumber) Then

            txtOutputSortedListKey.Text = CType(studentSortedListKey(identificationNumber), Student).GetStudentData()

        Else

            txtOutputSortedListKey.Text = "This identification number does not exist.!"

        End If

    End Sub

    Private studentSortedList As New SortedList()

    Private Sub btnAddSortedList_Click(sender As Object, e As EventArgs) Handles btnAddSortedList.Click


    End Sub

    Private Sub btnSelectSortedList_Click(sender As Object, e As EventArgs) Handles btnSelectSortedList.Click


    End Sub
End Class
