''' <summary>
''' Author:         A.P. Massardo
''' Project:        DemoCollections
''' Date:           15-Feb-2018
''' Description:    Application to demonstrate the basec use of some Visual Basic collections.
'''                 Collections are...
'''                 
'''                     -Similar to arrays in that they can hold one to many elements, 
'''                      but a collection is dynamic so you do not need to specify the 
'''                      size of a collection. You can just keep adding to it, when needed.
'''                      
'''                     -Typed Collections are similar to arrays in that once typed you 
'''                      can only put a variable/object of that type into one of its elements.
'''                      
'''                     -Untyped Collections do not require you to specify the datatype of what
'''                      will be stored in the elements of the collection. But, even when using an
'''                      untyped collection it is not recommended to put variables/object of 
'''                      different datatypes into an untyped Collection. But, never say never, 
'''                      I've seen it done.
'''                                         
''' </summary>

Public Class frmDemoCollections

#Region "List"

    ''' <summary>
    ''' Form/Class level List Object
    ''' Namespace - System.Collections.Generic
    ''' </summary>
    Private studentList As New List(Of Student)

    ''' <summary>
    ''' btnAdd_Click - demonstrates adding student objects to a list
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAddList.Click

        Dim student As New Student()        ' create a new student object

        student.Name = txtNameList.Text     ' assign the name in the text box to the name property

        studentList.Add(student)            ' add a student to the List object

        txtOutputList.Clear()               ' clear the output text box

        For Each student In studentList     ' loop the studentlist

            txtOutputList.Text += student.GetStudentData() & vbCrLf ' append the GetStudentData function data to the output text box

        Next student

        txtNameList.Clear()                 ' clear the input text box
        txtNameList.Focus()                 ' set focus to the input text box

    End Sub

    ''' <summary>
    ''' btnSelect_Click - demonstrates selecting a an object from the list
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSelectList_Click(sender As Object, e As EventArgs) Handles btnSelectList.Click

        Dim identificationNumber As String = txtListIdentificationNumber.Text.Trim()    ' get the input from the text box
        Dim found As Boolean = False    ' declare a boolean to determine if the data input was found in the list

        txtOutputList.Clear()           ' clear the output text box

        For index As Integer = 0 To studentList.Count - 1   ' loop the studentList

            If studentList(index).IdentificationNumber.ToString() = identificationNumber Then   ' check if the current object id is the same is the input

                txtOutputList.Text = studentList(index).GetStudentData  ' display the data from the GetStudentData function

                found = True    ' set the found boolean to true

                index = studentList.Count   ' set the loop index to the studentList.Count to exit the loop early

            End If

        Next index

        If found = False Then ' if the object was not found in the list

            txtOutputList.Text = "This identification number does not exist.!"  ' tell the user

        End If

    End Sub

#End Region

#Region "ArrayList"

    ''' <summary>
    ''' Form/Class level ArrayList Object
    ''' Namespace - System.Collections
    ''' </summary>
    Private studentArrayList As New ArrayList

    ''' <summary>
    ''' btnAdd_Click - demonstrates adding student objects to an ArrayList
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddArrayList_Click(sender As Object, e As EventArgs) Handles btnAddArrayList.Click

        Dim student As New Student()            ' create a new student object

        student.Name = txtNameArrayList.Text    ' assign the name in the text box to the name property

        studentArrayList.Add(student)           ' add a student to the ArrayList object

        txtOutputArrayList.Clear()              ' clear the output text box

        For Each student In studentArrayList    ' loop the studentArrayList

            txtOutputArrayList.Text += student.GetStudentData() & vbCrLf    ' append the GetStudentData function data to the output text box

        Next student

        txtNameArrayList.Clear()    ' clear the input text box
        txtNameArrayList.Focus()    ' set focus to the input text box

    End Sub

    ''' <summary>
    ''' btnSelect_Click - demonstrates selecting a an object from the ArrayList
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSelectArrayList_Click(sender As Object, e As EventArgs) Handles btnSelectArrayList.Click

        Dim identificationNumber As String = txtArrayListIdentificationNumber.Text.Trim() ' get the input from the text box
        Dim found As Boolean = False ' declare a boolean to determine if the data input was found in the ArrayList

        txtOutputArrayList.Clear()  ' clear the output text box

        For index As Integer = 0 To studentArrayList.Count - 1 ' loop the studentArrayList

            If studentArrayList(index).IdentificationNumber.ToString() = identificationNumber Then  ' check if the current object id is the same is the input

                txtOutputArrayList.Text = studentArrayList(index).GetStudentData()  ' display the data from the GetStudentData function

                found = True        ' set the found boolean to true

                index = studentArrayList.Count  ' set the loop index to the studentArrayList.Count to exit the loop early

            End If

        Next index

        If found = False Then   ' if the object was not found in the studentArrayList

            txtOutputArrayList.Text = "This identification number does not exist.!" ' tell the user

        End If

    End Sub

#End Region

#Region "SortedList"

    ''' <summary>
    ''' Form/Class level SortedList Object
    ''' Namespace - System.Collections.Generic
    ''' </summary>
    Private studentSortedListKey As New SortedList()

    ''' <summary>
    ''' btnAdd_Click - demonstrates adding student objects to a SortedList
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddSortedListKey_Click(sender As Object, e As EventArgs) Handles btnAddSortedListKey.Click

        Dim student As New Student()                ' create a new student object

        student.Name = txtNameSortedListKey.Text    ' assign the name in the text box to the name property

        studentSortedListKey.Add(student.IdentificationNumber.ToString(), student) ' add a student to the SortedList object with a Key of the student identification number converted to string

        txtOutputSortedListKey.Clear()              ' clear the output text box

        For Each studentEntry As DictionaryEntry In studentSortedListKey    ' loop the studentSortedListKey

            txtOutputSortedListKey.Text += CType(studentEntry.Value, Student).GetStudentData() & vbCrLf ' append the GetStudentData function data to the output text box

        Next studentEntry

        txtNameSortedListKey.Clear()    ' clear the input text box
        txtNameSortedListKey.Focus()    ' set focus to the input text box

    End Sub

    ''' <summary>
    ''' btnSelect_Click - demonstrates selecting a an object from the SortedList
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSelectSortedListKey_Click(sender As Object, e As EventArgs) Handles btnSelectSortedListKey.Click

        Dim identificationNumber As String = txtSortedListKeyIdentificationNumber.Text  ' get the input from the text box

        txtOutputSortedListKey.Clear()  ' clear the output text box

        If studentSortedListKey.ContainsKey(identificationNumber) Then  ' check if the SortedList has the key matching the input

            txtOutputSortedListKey.Text = CType(studentSortedListKey(identificationNumber), Student).GetStudentData()   ' display the data from the GetStudentData function

        Else    ' if the object was not found in the SortedList

            txtOutputSortedListKey.Text = "This identification number does not exist.!" ' tell the user

        End If

    End Sub

#End Region

#Region "Collection (Not mentioned in the book)"

    ''' <summary>
    ''' Form/Class level Collection Object
    '''     - If working with Visual Basic you may also come 
    '''       across this type of collection object just called Collection
    ''' Namespace - Microsoft.VisualBasic
    ''' </summary>
    Private studentCollection As New Collection

    ''' <summary>
    ''' btnAdd_Click - demonstrates adding student objects to a Collection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddCollection_Click(sender As Object, e As EventArgs) Handles btnAddCollection.Click

        Dim student As New Student()            ' create a new student object

        student.Name = txtNameCollection.Text   ' assign the name in the text box to the name property

        studentCollection.Add(student, student.IdentificationNumber.ToString()) ' add a student to the Colection object with a Key of the student 

        txtOutputCollection.Clear()             ' clear the output text box

        For Each studentLoop As Student In studentCollection ' loop the studentCollection

            txtOutputCollection.Text += studentLoop.GetStudentData() & vbCrLf   ' append the GetStudentData function data to the output text box

        Next studentLoop

        txtNameCollection.Clear()   ' clear the input text box
        txtNameCollection.Focus()   ' set focus to the input text box

    End Sub

    ''' <summary>
    ''' btnSelect_Click - demonstrates selecting a an object from the Collection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSelectCollection_Click(sender As Object, e As EventArgs) Handles btnSelectCollection.Click

        Dim identificationNumber As String = txtCollectionIdentificationNumber.Text     ' get the input from the text box

        txtOutputCollection.Clear()     ' clear the output text box

        If studentCollection.Contains(identificationNumber) Then    ' check if the Collection has the key matching the input

            txtOutputCollection.Text = CType(studentCollection(identificationNumber), Student).GetStudentData()     ' display the data from the GetStudentData function

        Else    ' if the object was not found in the Collection

            txtOutputCollection.Text = "This identification number does not exist.!"    ' tell the user

        End If

    End Sub

#End Region

#Region "Queue"

    ''' <summary>
    '''  Queue - First In First Out - Like a line at the bank, 
    '''                         - the first person who lines up
    '''                         - is the first person to get service
    '''                         - is the first person to leave
    ''' Namespace - System.Collections.Generic
    ''' </summary>
    Private studentQueue As New Queue(Of Student)

    ''' <summary>
    ''' btnAdd_Click - demonstrates adding student objects to a Queue
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddQueue_Click(sender As Object, e As EventArgs) Handles btnAddQueue.Click

        Dim student As New Student()        ' create a new student object

        student.Name = txtNameQueue.Text    ' assign the name in the text box to the name property

        studentQueue.Enqueue(student)       ' add/enqueue a student to the List object

        txtOutputQueue.Clear()              ' clear the output text box

        For Each studentLoop As Student In studentQueue     ' loop the studentQueue

            txtOutputQueue.Text += studentLoop.GetStudentData() & vbCrLf    ' append the GetStudentData function data to the output text box

        Next studentLoop

        txtNameQueue.Clear()    ' clear the input text box
        txtNameQueue.Focus()    ' set focus to the input text box

    End Sub

    ''' <summary>
    ''' btnDequeue_Click - demonstrate the Dequeue of the Queue object
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnDequeue_Click(sender As Object, e As EventArgs) Handles btnDequeue.Click

        Dim student As Student ' declare a student object

        txtOutputQueue.Clear()  ' clear the output text box

        If studentQueue.Count > 0 Then  ' check if the Queue has any objects in it

            student = studentQueue.Dequeue() ' set the student object and remove it from the queue

            txtOutputQueue.Text = "Dequeue-Look and Remove the next in line." & vbCrLf & student.GetStudentData() ' display the message to the user

        End If

    End Sub

    ''' <summary>
    ''' btnQueuePeek_Click -  demonstrate the Peek of the Queue object
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnQueuePeek_Click(sender As Object, e As EventArgs) Handles btnQueuePeek.Click

        Dim student As Student  ' declare a student object

        txtOutputQueue.Clear()  ' clear the output text box

        If studentQueue.Count > 0 Then   ' check if the Queue has any objects in it

            student = studentQueue.Peek()   ' set the student object

            txtOutputQueue.Text = "Peek-Look and do not Remove the next in line." & vbCrLf & student.GetStudentData() ' display the message to the user

        End If

    End Sub



#End Region

#Region "Stack"

    ''' <summary>
    ''' Form/Class level Stack Object
    '''     - Last In First Out
    '''     - Push on top of the Stack.
    '''     - Popped off the top of the Stack.
    ''' Namespace - System.Collections.Generic
    ''' </summary>
    Private studentStack As New Stack(Of Student)

    ''' <summary>
    ''' btnAdd_Click - demonstrates adding student objects to a Stack
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAddStack_Click(sender As Object, e As EventArgs) Handles btnAddStack.Click

        Dim student As New Student()        ' create a new student object

        student.Name = txtNameStack.Text    ' assign the name in the text box to the name property

        studentStack.Push(student)          ' add/push a student to the Stack object

        txtOutputStack.Clear()              ' clear the output text box

        For Each studentLoop As Student In studentStack ' loop the studentStack

            txtOutputStack.Text += studentLoop.GetStudentData() & vbCrLf    ' append the GetStudentData function data to the output text box

        Next studentLoop

        txtNameStack.Clear()    ' clear the input text box
        txtNameStack.Focus()    ' set focus to the input text box

    End Sub

    ''' <summary>
    ''' btnPop_Click - demonstrate the Pop function of the Stack
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPop_Click(sender As Object, e As EventArgs) Handles btnPop.Click

        Dim student As Student  ' declare a student object

        txtOutputStack.Clear()  ' clear the output text box

        If studentStack.Count > 0 Then   ' check if the Stack has any objects in it

            student = studentStack.Pop()    ' set the student object and remove it from the top of the Stack

            txtOutputStack.Text = "Pop-Look and Remove the next in line." & vbCrLf & student.GetStudentData()   ' display the message to the user

        End If

    End Sub

    ''' <summary>
    ''' btnStackPeek_Click - demonstrate the Peek function of the Stack
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnStackPeek_Click(sender As Object, e As EventArgs) Handles btnStackPeek.Click

        Dim student As Student  ' declare a student object

        txtOutputStack.Clear()  ' clear the output text box

        If studentStack.Count > 0 Then  ' check if the Stack has any objects in it

            student = studentStack.Peek()   ' set the student object to the object on the top of the Stack

            txtOutputStack.Text = "Peek-Look and do not Remove the next in line." & vbCrLf & student.GetStudentData() ' display the message to the user

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
