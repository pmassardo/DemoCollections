Public Class frmDemoCollections

#Region "List"

    Private studentList As New List(Of Student)

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddList.Click


        Dim student As New Student()

        student.Name = txtNameList.Text

        studentList.Add(student)

        txtOutputList.Clear()

        For Each student In studentList

            txtOutputList.Text += student.GetStudentData() & vbCrLf

        Next student

        txtNameList.Clear()
        txtNameList.Focus()

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

#End Region

#Region "ArrayList"
    Private studentArrayList As New ArrayList

    Private Sub btnAddArrayList_Click(sender As Object, e As EventArgs) Handles btnAddArrayList.Click

        Dim student As New Student()

        student.Name = txtNameArrayList.Text

        studentArrayList.Add(student)

        txtOutputArrayList.Clear()

        For Each student In studentArrayList

            txtOutputArrayList.Text += student.GetStudentData() & vbCrLf

        Next student

        txtNameArrayList.Clear()
        txtNameArrayList.Focus()

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

#End Region

#Region "SortedList"

    Private studentSortedListKey As New SortedList()

    Private Sub btnAddSortedListKey_Click(sender As Object, e As EventArgs) Handles btnAddSortedListKey.Click

        Dim student As New Student()

        student.Name = txtNameSortedListKey.Text

        studentSortedListKey.Add(student.IdentificationNumber.ToString(), student)

        txtOutputSortedListKey.Clear()

        For Each studentEntry As DictionaryEntry In studentSortedListKey

            txtOutputSortedListKey.Text += CType(studentEntry.Value, Student).GetStudentData() & vbCrLf

        Next studentEntry

        txtNameSortedListKey.Clear()
        txtNameSortedListKey.Focus()

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

#End Region

#Region "Collection"

    Private studentCollection As New Collection

    Private Sub btnAddCollection_Click(sender As Object, e As EventArgs) Handles btnAddCollection.Click


        Dim student As New Student()

        student.Name = txtNameCollection.Text

        studentCollection.Add(student, student.IdentificationNumber.ToString())

        txtOutputCollection.Clear()

        For Each studentLoop As Student In studentCollection

            txtOutputCollection.Text += studentLoop.GetStudentData() & vbCrLf

        Next studentLoop

        txtNameCollection.Clear()
        txtNameCollection.Focus()

    End Sub

    Private Sub btnSelectCollection_Click(sender As Object, e As EventArgs) Handles btnSelectCollection.Click

        Dim identificationNumber As String = txtCollectionIdentificationNumber.Text

        txtOutputCollection.Clear()

        If studentCollection.Contains(identificationNumber) Then

            txtOutputCollection.Text = CType(studentCollection(identificationNumber), Student).GetStudentData()

        Else

            txtOutputCollection.Text = "This identification number does not exist.!"

        End If

    End Sub

#End Region

#Region "Queue"

    ''' <summary>
    '''  Queue - First In First Out - Like a line at the bank, 
    '''                         - the first person who lines up
    '''                         - is the first person to get service
    '''                         - is the first person to leave
    ''' </summary>

    Private studentQueue As New Queue(Of Student)

    Private Sub btnAddQueue_Click(sender As Object, e As EventArgs) Handles btnAddQueue.Click

        Dim student As New Student()

        student.Name = txtNameQueue.Text

        studentQueue.Enqueue(student)

        txtOutputQueue.Clear()

        For Each studentLoop As Student In studentQueue

            txtOutputQueue.Text += studentLoop.GetStudentData() & vbCrLf

        Next studentLoop

        txtNameQueue.Clear()
        txtNameQueue.Focus()

    End Sub

    Private Sub btnDequeue_Click(sender As Object, e As EventArgs) Handles btnDequeue.Click

        Dim student As Student

        txtOutputQueue.Clear()

        If studentQueue.Count > 0 Then

            student = studentQueue.Dequeue()

            txtOutputQueue.Text = "Dequeue-Look and Remove the next in line." & vbCrLf & student.GetStudentData()

        End If

    End Sub

    Private Sub btnQueuePeek_Click(sender As Object, e As EventArgs) Handles btnQueuePeek.Click

        Dim student As Student

        txtOutputQueue.Clear()

        If studentQueue.Count > 0 Then

            student = studentQueue.Peek()

            txtOutputQueue.Text = "Peek-Look and do not Remove the next in line." & vbCrLf & student.GetStudentData()

        End If



    End Sub



#End Region

#Region "Stack"

    Private studentStack As New Stack(Of Student)

    Private Sub btnAddStack_Click(sender As Object, e As EventArgs) Handles btnAddStack.Click


        Dim student As New Student()

        student.Name = txtNameStack.Text

        studentStack.Push(student)

        txtOutputStack.Clear()

        For Each studentLoop As Student In studentStack

            txtOutputStack.Text += studentLoop.GetStudentData() & vbCrLf

        Next studentLoop

        txtNameStack.Clear()
        txtNameStack.Focus()

    End Sub

    Private Sub btnPop_Click(sender As Object, e As EventArgs) Handles btnPop.Click

        Dim student As Student

        txtOutputStack.Clear()

        If studentStack.Count > 0 Then

            student = studentStack.Pop()

            txtOutputStack.Text = "Pop-Look and Remove the next in line." & vbCrLf & student.GetStudentData()

        End If

    End Sub

    Private Sub btnStackPeek_Click(sender As Object, e As EventArgs) Handles btnStackPeek.Click

        Dim student As Student

        txtOutputStack.Clear()

        If studentStack.Count > 0 Then

            student = studentStack.Peek()

            txtOutputStack.Text = "Peek-Look and do not Remove the next in line." & vbCrLf & student.GetStudentData()

        End If

    End Sub


#End Region

#Region "GotFocus"

    ''' <summary>
    ''' Captures the GotFocus event for a number of controls when a specific controls gets focus this reset the accept button
    ''' to the appropriate button on the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub input_GotFocus(sender As Object, e As EventArgs) Handles txtNameList.GotFocus,
                                                                            txtNameArrayList.GotFocus,
                                                                            txtNameSortedListKey.GotFocus,
                                                                            txtNameCollection.GotFocus,
                                                                            txtNameQueue.GotFocus,
                                                                            txtNameStack.GotFocus,
                                                                            txtListIdentificationNumber.GotFocus,
                                                                            txtArrayListIdentificationNumber.GotFocus,
                                                                            txtSortedListKeyIdentificationNumber.GotFocus,
                                                                            txtCollectionIdentificationNumber.GotFocus


        ' set the control name
        Dim controlName As String = CType(sender, TextBox).Name

        ' check which text box has focus
        If controlName = "txtNameList" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnAddList

        ElseIf controlName = "txtCollectionIdentificationNumber" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnSelectCollection

        ElseIf controlName = "txtSortedListKeyIdentificationNumber" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnSelectSortedListKey

        ElseIf controlName = "txtArrayListIdentificationNumber" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnSelectArrayList

        ElseIf controlName = "txtListIdentificationNumber" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnSelectList

        ElseIf controlName = "txtNameArrayList" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnAddArrayList

        ElseIf controlName = "txtNameSortedListKey" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnAddSortedListKey

        ElseIf controlName = "txtNameCollection" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnAddCollection

        ElseIf controlName = "txtNameQueue" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnAddQueue

        ElseIf controlName = "txtNameStack" Then

            ' set the accept button
            ' to the appropriate button
            Me.AcceptButton = btnAddStack

        End If

    End Sub

#End Region

End Class
