<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDemoCollections
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpList = New System.Windows.Forms.GroupBox()
        Me.btnSelectList = New System.Windows.Forms.Button()
        Me.lblListIdentificationNumber = New System.Windows.Forms.Label()
        Me.txtListIdentificationNumber = New System.Windows.Forms.TextBox()
        Me.txtOutputList = New System.Windows.Forms.TextBox()
        Me.lblNameList = New System.Windows.Forms.Label()
        Me.txtNameList = New System.Windows.Forms.TextBox()
        Me.btnAddList = New System.Windows.Forms.Button()
        Me.grpArrayList = New System.Windows.Forms.GroupBox()
        Me.btnSelectArrayList = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtArrayListIdentificationNumber = New System.Windows.Forms.TextBox()
        Me.txtOutputArrayList = New System.Windows.Forms.TextBox()
        Me.lblNameArrayList = New System.Windows.Forms.Label()
        Me.txtNameArrayList = New System.Windows.Forms.TextBox()
        Me.btnAddArrayList = New System.Windows.Forms.Button()
        Me.grpSortedListKey = New System.Windows.Forms.GroupBox()
        Me.btnSelectSortedListKey = New System.Windows.Forms.Button()
        Me.lblSortedListKeyIdentificationNumber = New System.Windows.Forms.Label()
        Me.txtSortedListKeyIdentificationNumber = New System.Windows.Forms.TextBox()
        Me.txtOutputSortedListKey = New System.Windows.Forms.TextBox()
        Me.lblNameSortedListKey = New System.Windows.Forms.Label()
        Me.txtNameSortedListKey = New System.Windows.Forms.TextBox()
        Me.btnAddSortedListKey = New System.Windows.Forms.Button()
        Me.grpCollection = New System.Windows.Forms.GroupBox()
        Me.btnSelectCollection = New System.Windows.Forms.Button()
        Me.lblCollectionIdentificationNumber = New System.Windows.Forms.Label()
        Me.txtCollectionIdentificationNumber = New System.Windows.Forms.TextBox()
        Me.txtOutputCollection = New System.Windows.Forms.TextBox()
        Me.lblNameCollection = New System.Windows.Forms.Label()
        Me.txtNameCollection = New System.Windows.Forms.TextBox()
        Me.btnAddCollection = New System.Windows.Forms.Button()
        Me.grpQueue = New System.Windows.Forms.GroupBox()
        Me.btnQueuePeek = New System.Windows.Forms.Button()
        Me.btnDequeue = New System.Windows.Forms.Button()
        Me.txtOutputQueue = New System.Windows.Forms.TextBox()
        Me.lblNameQueue = New System.Windows.Forms.Label()
        Me.txtNameQueue = New System.Windows.Forms.TextBox()
        Me.btnAddQueue = New System.Windows.Forms.Button()
        Me.grpStack = New System.Windows.Forms.GroupBox()
        Me.btnStackPeek = New System.Windows.Forms.Button()
        Me.btnPop = New System.Windows.Forms.Button()
        Me.txtOutputStack = New System.Windows.Forms.TextBox()
        Me.lblNameStack = New System.Windows.Forms.Label()
        Me.txtNameStack = New System.Windows.Forms.TextBox()
        Me.btnAddStack = New System.Windows.Forms.Button()
        Me.grpList.SuspendLayout()
        Me.grpArrayList.SuspendLayout()
        Me.grpSortedListKey.SuspendLayout()
        Me.grpCollection.SuspendLayout()
        Me.grpQueue.SuspendLayout()
        Me.grpStack.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpList
        '
        Me.grpList.Controls.Add(Me.btnSelectList)
        Me.grpList.Controls.Add(Me.lblListIdentificationNumber)
        Me.grpList.Controls.Add(Me.txtListIdentificationNumber)
        Me.grpList.Controls.Add(Me.txtOutputList)
        Me.grpList.Controls.Add(Me.lblNameList)
        Me.grpList.Controls.Add(Me.txtNameList)
        Me.grpList.Controls.Add(Me.btnAddList)
        Me.grpList.Location = New System.Drawing.Point(7, 1)
        Me.grpList.Name = "grpList"
        Me.grpList.Size = New System.Drawing.Size(248, 167)
        Me.grpList.TabIndex = 0
        Me.grpList.TabStop = False
        Me.grpList.Text = "&List"
        '
        'btnSelectList
        '
        Me.btnSelectList.Location = New System.Drawing.Point(167, 140)
        Me.btnSelectList.Name = "btnSelectList"
        Me.btnSelectList.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectList.TabIndex = 6
        Me.btnSelectList.Text = "&Select"
        Me.btnSelectList.UseVisualStyleBackColor = True
        '
        'lblListIdentificationNumber
        '
        Me.lblListIdentificationNumber.Location = New System.Drawing.Point(6, 140)
        Me.lblListIdentificationNumber.Name = "lblListIdentificationNumber"
        Me.lblListIdentificationNumber.Size = New System.Drawing.Size(50, 19)
        Me.lblListIdentificationNumber.TabIndex = 4
        Me.lblListIdentificationNumber.Text = "ID:"
        '
        'txtListIdentificationNumber
        '
        Me.txtListIdentificationNumber.Location = New System.Drawing.Point(62, 139)
        Me.txtListIdentificationNumber.Name = "txtListIdentificationNumber"
        Me.txtListIdentificationNumber.Size = New System.Drawing.Size(88, 20)
        Me.txtListIdentificationNumber.TabIndex = 5
        '
        'txtOutputList
        '
        Me.txtOutputList.Location = New System.Drawing.Point(6, 71)
        Me.txtOutputList.Multiline = True
        Me.txtOutputList.Name = "txtOutputList"
        Me.txtOutputList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutputList.Size = New System.Drawing.Size(236, 65)
        Me.txtOutputList.TabIndex = 3
        '
        'lblNameList
        '
        Me.lblNameList.Location = New System.Drawing.Point(15, 20)
        Me.lblNameList.Name = "lblNameList"
        Me.lblNameList.Size = New System.Drawing.Size(50, 19)
        Me.lblNameList.TabIndex = 0
        Me.lblNameList.Text = "Name:"
        '
        'txtNameList
        '
        Me.txtNameList.Location = New System.Drawing.Point(71, 19)
        Me.txtNameList.Name = "txtNameList"
        Me.txtNameList.Size = New System.Drawing.Size(171, 20)
        Me.txtNameList.TabIndex = 1
        '
        'btnAddList
        '
        Me.btnAddList.Location = New System.Drawing.Point(167, 44)
        Me.btnAddList.Name = "btnAddList"
        Me.btnAddList.Size = New System.Drawing.Size(75, 23)
        Me.btnAddList.TabIndex = 2
        Me.btnAddList.Text = "&Add"
        Me.btnAddList.UseVisualStyleBackColor = True
        '
        'grpArrayList
        '
        Me.grpArrayList.Controls.Add(Me.btnSelectArrayList)
        Me.grpArrayList.Controls.Add(Me.Label1)
        Me.grpArrayList.Controls.Add(Me.txtArrayListIdentificationNumber)
        Me.grpArrayList.Controls.Add(Me.txtOutputArrayList)
        Me.grpArrayList.Controls.Add(Me.lblNameArrayList)
        Me.grpArrayList.Controls.Add(Me.txtNameArrayList)
        Me.grpArrayList.Controls.Add(Me.btnAddArrayList)
        Me.grpArrayList.Location = New System.Drawing.Point(261, 1)
        Me.grpArrayList.Name = "grpArrayList"
        Me.grpArrayList.Size = New System.Drawing.Size(248, 168)
        Me.grpArrayList.TabIndex = 1
        Me.grpArrayList.TabStop = False
        Me.grpArrayList.Text = "&ArrayList"
        '
        'btnSelectArrayList
        '
        Me.btnSelectArrayList.Location = New System.Drawing.Point(167, 142)
        Me.btnSelectArrayList.Name = "btnSelectArrayList"
        Me.btnSelectArrayList.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectArrayList.TabIndex = 6
        Me.btnSelectArrayList.Text = "&Select"
        Me.btnSelectArrayList.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID:"
        '
        'txtArrayListIdentificationNumber
        '
        Me.txtArrayListIdentificationNumber.Location = New System.Drawing.Point(62, 141)
        Me.txtArrayListIdentificationNumber.Name = "txtArrayListIdentificationNumber"
        Me.txtArrayListIdentificationNumber.Size = New System.Drawing.Size(88, 20)
        Me.txtArrayListIdentificationNumber.TabIndex = 5
        '
        'txtOutputArrayList
        '
        Me.txtOutputArrayList.Location = New System.Drawing.Point(6, 72)
        Me.txtOutputArrayList.Multiline = True
        Me.txtOutputArrayList.Name = "txtOutputArrayList"
        Me.txtOutputArrayList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutputArrayList.Size = New System.Drawing.Size(236, 65)
        Me.txtOutputArrayList.TabIndex = 3
        '
        'lblNameArrayList
        '
        Me.lblNameArrayList.Location = New System.Drawing.Point(15, 20)
        Me.lblNameArrayList.Name = "lblNameArrayList"
        Me.lblNameArrayList.Size = New System.Drawing.Size(50, 19)
        Me.lblNameArrayList.TabIndex = 0
        Me.lblNameArrayList.Text = "Name:"
        '
        'txtNameArrayList
        '
        Me.txtNameArrayList.Location = New System.Drawing.Point(71, 19)
        Me.txtNameArrayList.Name = "txtNameArrayList"
        Me.txtNameArrayList.Size = New System.Drawing.Size(171, 20)
        Me.txtNameArrayList.TabIndex = 1
        '
        'btnAddArrayList
        '
        Me.btnAddArrayList.Location = New System.Drawing.Point(167, 44)
        Me.btnAddArrayList.Name = "btnAddArrayList"
        Me.btnAddArrayList.Size = New System.Drawing.Size(75, 23)
        Me.btnAddArrayList.TabIndex = 2
        Me.btnAddArrayList.Text = "&Add"
        Me.btnAddArrayList.UseVisualStyleBackColor = True
        '
        'grpSortedListKey
        '
        Me.grpSortedListKey.Controls.Add(Me.btnSelectSortedListKey)
        Me.grpSortedListKey.Controls.Add(Me.lblSortedListKeyIdentificationNumber)
        Me.grpSortedListKey.Controls.Add(Me.txtSortedListKeyIdentificationNumber)
        Me.grpSortedListKey.Controls.Add(Me.txtOutputSortedListKey)
        Me.grpSortedListKey.Controls.Add(Me.lblNameSortedListKey)
        Me.grpSortedListKey.Controls.Add(Me.txtNameSortedListKey)
        Me.grpSortedListKey.Controls.Add(Me.btnAddSortedListKey)
        Me.grpSortedListKey.Location = New System.Drawing.Point(7, 169)
        Me.grpSortedListKey.Name = "grpSortedListKey"
        Me.grpSortedListKey.Size = New System.Drawing.Size(248, 168)
        Me.grpSortedListKey.TabIndex = 2
        Me.grpSortedListKey.TabStop = False
        Me.grpSortedListKey.Text = "SortedList &Key"
        '
        'btnSelectSortedListKey
        '
        Me.btnSelectSortedListKey.Location = New System.Drawing.Point(167, 142)
        Me.btnSelectSortedListKey.Name = "btnSelectSortedListKey"
        Me.btnSelectSortedListKey.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectSortedListKey.TabIndex = 6
        Me.btnSelectSortedListKey.Text = "&Select"
        Me.btnSelectSortedListKey.UseVisualStyleBackColor = True
        '
        'lblSortedListKeyIdentificationNumber
        '
        Me.lblSortedListKeyIdentificationNumber.Location = New System.Drawing.Point(6, 143)
        Me.lblSortedListKeyIdentificationNumber.Name = "lblSortedListKeyIdentificationNumber"
        Me.lblSortedListKeyIdentificationNumber.Size = New System.Drawing.Size(50, 19)
        Me.lblSortedListKeyIdentificationNumber.TabIndex = 4
        Me.lblSortedListKeyIdentificationNumber.Text = "ID:"
        '
        'txtSortedListKeyIdentificationNumber
        '
        Me.txtSortedListKeyIdentificationNumber.Location = New System.Drawing.Point(62, 142)
        Me.txtSortedListKeyIdentificationNumber.Name = "txtSortedListKeyIdentificationNumber"
        Me.txtSortedListKeyIdentificationNumber.Size = New System.Drawing.Size(88, 20)
        Me.txtSortedListKeyIdentificationNumber.TabIndex = 5
        '
        'txtOutputSortedListKey
        '
        Me.txtOutputSortedListKey.Location = New System.Drawing.Point(6, 74)
        Me.txtOutputSortedListKey.Multiline = True
        Me.txtOutputSortedListKey.Name = "txtOutputSortedListKey"
        Me.txtOutputSortedListKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutputSortedListKey.Size = New System.Drawing.Size(236, 65)
        Me.txtOutputSortedListKey.TabIndex = 3
        '
        'lblNameSortedListKey
        '
        Me.lblNameSortedListKey.Location = New System.Drawing.Point(15, 20)
        Me.lblNameSortedListKey.Name = "lblNameSortedListKey"
        Me.lblNameSortedListKey.Size = New System.Drawing.Size(50, 19)
        Me.lblNameSortedListKey.TabIndex = 0
        Me.lblNameSortedListKey.Text = "Name:"
        '
        'txtNameSortedListKey
        '
        Me.txtNameSortedListKey.Location = New System.Drawing.Point(71, 19)
        Me.txtNameSortedListKey.Name = "txtNameSortedListKey"
        Me.txtNameSortedListKey.Size = New System.Drawing.Size(171, 20)
        Me.txtNameSortedListKey.TabIndex = 1
        '
        'btnAddSortedListKey
        '
        Me.btnAddSortedListKey.Location = New System.Drawing.Point(167, 45)
        Me.btnAddSortedListKey.Name = "btnAddSortedListKey"
        Me.btnAddSortedListKey.Size = New System.Drawing.Size(75, 23)
        Me.btnAddSortedListKey.TabIndex = 2
        Me.btnAddSortedListKey.Text = "&Add"
        Me.btnAddSortedListKey.UseVisualStyleBackColor = True
        '
        'grpCollection
        '
        Me.grpCollection.Controls.Add(Me.btnSelectCollection)
        Me.grpCollection.Controls.Add(Me.lblCollectionIdentificationNumber)
        Me.grpCollection.Controls.Add(Me.txtCollectionIdentificationNumber)
        Me.grpCollection.Controls.Add(Me.txtOutputCollection)
        Me.grpCollection.Controls.Add(Me.lblNameCollection)
        Me.grpCollection.Controls.Add(Me.txtNameCollection)
        Me.grpCollection.Controls.Add(Me.btnAddCollection)
        Me.grpCollection.Location = New System.Drawing.Point(261, 170)
        Me.grpCollection.Name = "grpCollection"
        Me.grpCollection.Size = New System.Drawing.Size(248, 168)
        Me.grpCollection.TabIndex = 3
        Me.grpCollection.TabStop = False
        Me.grpCollection.Text = "&Collection"
        '
        'btnSelectCollection
        '
        Me.btnSelectCollection.Location = New System.Drawing.Point(167, 142)
        Me.btnSelectCollection.Name = "btnSelectCollection"
        Me.btnSelectCollection.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectCollection.TabIndex = 6
        Me.btnSelectCollection.Text = "&Select"
        Me.btnSelectCollection.UseVisualStyleBackColor = True
        '
        'lblCollectionIdentificationNumber
        '
        Me.lblCollectionIdentificationNumber.Location = New System.Drawing.Point(6, 143)
        Me.lblCollectionIdentificationNumber.Name = "lblCollectionIdentificationNumber"
        Me.lblCollectionIdentificationNumber.Size = New System.Drawing.Size(50, 19)
        Me.lblCollectionIdentificationNumber.TabIndex = 4
        Me.lblCollectionIdentificationNumber.Text = "ID:"
        '
        'txtCollectionIdentificationNumber
        '
        Me.txtCollectionIdentificationNumber.Location = New System.Drawing.Point(62, 142)
        Me.txtCollectionIdentificationNumber.Name = "txtCollectionIdentificationNumber"
        Me.txtCollectionIdentificationNumber.Size = New System.Drawing.Size(88, 20)
        Me.txtCollectionIdentificationNumber.TabIndex = 5
        '
        'txtOutputCollection
        '
        Me.txtOutputCollection.Location = New System.Drawing.Point(6, 72)
        Me.txtOutputCollection.Multiline = True
        Me.txtOutputCollection.Name = "txtOutputCollection"
        Me.txtOutputCollection.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutputCollection.Size = New System.Drawing.Size(236, 65)
        Me.txtOutputCollection.TabIndex = 3
        '
        'lblNameCollection
        '
        Me.lblNameCollection.Location = New System.Drawing.Point(15, 20)
        Me.lblNameCollection.Name = "lblNameCollection"
        Me.lblNameCollection.Size = New System.Drawing.Size(50, 19)
        Me.lblNameCollection.TabIndex = 0
        Me.lblNameCollection.Text = "Name:"
        '
        'txtNameCollection
        '
        Me.txtNameCollection.Location = New System.Drawing.Point(71, 19)
        Me.txtNameCollection.Name = "txtNameCollection"
        Me.txtNameCollection.Size = New System.Drawing.Size(171, 20)
        Me.txtNameCollection.TabIndex = 1
        '
        'btnAddCollection
        '
        Me.btnAddCollection.Location = New System.Drawing.Point(167, 45)
        Me.btnAddCollection.Name = "btnAddCollection"
        Me.btnAddCollection.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCollection.TabIndex = 2
        Me.btnAddCollection.Text = "&Add"
        Me.btnAddCollection.UseVisualStyleBackColor = True
        '
        'grpQueue
        '
        Me.grpQueue.Controls.Add(Me.btnQueuePeek)
        Me.grpQueue.Controls.Add(Me.btnDequeue)
        Me.grpQueue.Controls.Add(Me.txtOutputQueue)
        Me.grpQueue.Controls.Add(Me.lblNameQueue)
        Me.grpQueue.Controls.Add(Me.txtNameQueue)
        Me.grpQueue.Controls.Add(Me.btnAddQueue)
        Me.grpQueue.Location = New System.Drawing.Point(7, 337)
        Me.grpQueue.Name = "grpQueue"
        Me.grpQueue.Size = New System.Drawing.Size(248, 168)
        Me.grpQueue.TabIndex = 4
        Me.grpQueue.TabStop = False
        Me.grpQueue.Text = "&Queue"
        '
        'btnQueuePeek
        '
        Me.btnQueuePeek.Location = New System.Drawing.Point(9, 139)
        Me.btnQueuePeek.Name = "btnQueuePeek"
        Me.btnQueuePeek.Size = New System.Drawing.Size(86, 23)
        Me.btnQueuePeek.TabIndex = 4
        Me.btnQueuePeek.Text = "&Peek"
        Me.btnQueuePeek.UseVisualStyleBackColor = True
        '
        'btnDequeue
        '
        Me.btnDequeue.Location = New System.Drawing.Point(125, 142)
        Me.btnDequeue.Name = "btnDequeue"
        Me.btnDequeue.Size = New System.Drawing.Size(117, 23)
        Me.btnDequeue.TabIndex = 5
        Me.btnDequeue.Text = "&Remove (Dequeue )"
        Me.btnDequeue.UseVisualStyleBackColor = True
        '
        'txtOutputQueue
        '
        Me.txtOutputQueue.Location = New System.Drawing.Point(6, 72)
        Me.txtOutputQueue.Multiline = True
        Me.txtOutputQueue.Name = "txtOutputQueue"
        Me.txtOutputQueue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutputQueue.Size = New System.Drawing.Size(236, 65)
        Me.txtOutputQueue.TabIndex = 3
        '
        'lblNameQueue
        '
        Me.lblNameQueue.Location = New System.Drawing.Point(15, 20)
        Me.lblNameQueue.Name = "lblNameQueue"
        Me.lblNameQueue.Size = New System.Drawing.Size(50, 19)
        Me.lblNameQueue.TabIndex = 0
        Me.lblNameQueue.Text = "Name:"
        '
        'txtNameQueue
        '
        Me.txtNameQueue.Location = New System.Drawing.Point(71, 19)
        Me.txtNameQueue.Name = "txtNameQueue"
        Me.txtNameQueue.Size = New System.Drawing.Size(171, 20)
        Me.txtNameQueue.TabIndex = 1
        '
        'btnAddQueue
        '
        Me.btnAddQueue.Location = New System.Drawing.Point(125, 45)
        Me.btnAddQueue.Name = "btnAddQueue"
        Me.btnAddQueue.Size = New System.Drawing.Size(117, 23)
        Me.btnAddQueue.TabIndex = 2
        Me.btnAddQueue.Text = "&Add (Enqueue)"
        Me.btnAddQueue.UseVisualStyleBackColor = True
        '
        'grpStack
        '
        Me.grpStack.Controls.Add(Me.btnStackPeek)
        Me.grpStack.Controls.Add(Me.btnPop)
        Me.grpStack.Controls.Add(Me.txtOutputStack)
        Me.grpStack.Controls.Add(Me.lblNameStack)
        Me.grpStack.Controls.Add(Me.txtNameStack)
        Me.grpStack.Controls.Add(Me.btnAddStack)
        Me.grpStack.Location = New System.Drawing.Point(261, 337)
        Me.grpStack.Name = "grpStack"
        Me.grpStack.Size = New System.Drawing.Size(248, 168)
        Me.grpStack.TabIndex = 5
        Me.grpStack.TabStop = False
        Me.grpStack.Text = "&Stack"
        '
        'btnStackPeek
        '
        Me.btnStackPeek.Location = New System.Drawing.Point(9, 139)
        Me.btnStackPeek.Name = "btnStackPeek"
        Me.btnStackPeek.Size = New System.Drawing.Size(86, 23)
        Me.btnStackPeek.TabIndex = 4
        Me.btnStackPeek.Text = "&Peek"
        Me.btnStackPeek.UseVisualStyleBackColor = True
        '
        'btnPop
        '
        Me.btnPop.Location = New System.Drawing.Point(125, 142)
        Me.btnPop.Name = "btnPop"
        Me.btnPop.Size = New System.Drawing.Size(117, 23)
        Me.btnPop.TabIndex = 5
        Me.btnPop.Text = "&Remove (Pop) "
        Me.btnPop.UseVisualStyleBackColor = True
        '
        'txtOutputStack
        '
        Me.txtOutputStack.Location = New System.Drawing.Point(6, 72)
        Me.txtOutputStack.Multiline = True
        Me.txtOutputStack.Name = "txtOutputStack"
        Me.txtOutputStack.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutputStack.Size = New System.Drawing.Size(236, 65)
        Me.txtOutputStack.TabIndex = 3
        '
        'lblNameStack
        '
        Me.lblNameStack.Location = New System.Drawing.Point(15, 20)
        Me.lblNameStack.Name = "lblNameStack"
        Me.lblNameStack.Size = New System.Drawing.Size(50, 19)
        Me.lblNameStack.TabIndex = 0
        Me.lblNameStack.Text = "Name:"
        '
        'txtNameStack
        '
        Me.txtNameStack.Location = New System.Drawing.Point(71, 19)
        Me.txtNameStack.Name = "txtNameStack"
        Me.txtNameStack.Size = New System.Drawing.Size(171, 20)
        Me.txtNameStack.TabIndex = 1
        '
        'btnAddStack
        '
        Me.btnAddStack.Location = New System.Drawing.Point(125, 45)
        Me.btnAddStack.Name = "btnAddStack"
        Me.btnAddStack.Size = New System.Drawing.Size(117, 23)
        Me.btnAddStack.TabIndex = 2
        Me.btnAddStack.Text = "&Add (Push)"
        Me.btnAddStack.UseVisualStyleBackColor = True
        '
        'frmDemoCollections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 510)
        Me.Controls.Add(Me.grpStack)
        Me.Controls.Add(Me.grpQueue)
        Me.Controls.Add(Me.grpCollection)
        Me.Controls.Add(Me.grpSortedListKey)
        Me.Controls.Add(Me.grpArrayList)
        Me.Controls.Add(Me.grpList)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDemoCollections"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Demo Collections"
        Me.grpList.ResumeLayout(False)
        Me.grpList.PerformLayout()
        Me.grpArrayList.ResumeLayout(False)
        Me.grpArrayList.PerformLayout()
        Me.grpSortedListKey.ResumeLayout(False)
        Me.grpSortedListKey.PerformLayout()
        Me.grpCollection.ResumeLayout(False)
        Me.grpCollection.PerformLayout()
        Me.grpQueue.ResumeLayout(False)
        Me.grpQueue.PerformLayout()
        Me.grpStack.ResumeLayout(False)
        Me.grpStack.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpList As GroupBox
    Friend WithEvents btnAddList As Button
    Friend WithEvents lblNameList As Label
    Friend WithEvents txtNameList As TextBox
    Friend WithEvents txtOutputList As TextBox
    Friend WithEvents grpArrayList As GroupBox
    Friend WithEvents txtOutputArrayList As TextBox
    Friend WithEvents lblNameArrayList As Label
    Friend WithEvents txtNameArrayList As TextBox
    Friend WithEvents btnAddArrayList As Button
    Friend WithEvents grpSortedListKey As GroupBox
    Friend WithEvents txtOutputSortedListKey As TextBox
    Friend WithEvents lblNameSortedListKey As Label
    Friend WithEvents txtNameSortedListKey As TextBox
    Friend WithEvents btnAddSortedListKey As Button
    Friend WithEvents btnSelectSortedListKey As Button
    Friend WithEvents lblSortedListKeyIdentificationNumber As Label
    Friend WithEvents txtSortedListKeyIdentificationNumber As TextBox
    Friend WithEvents btnSelectList As Button
    Friend WithEvents lblListIdentificationNumber As Label
    Friend WithEvents txtListIdentificationNumber As TextBox
    Friend WithEvents btnSelectArrayList As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtArrayListIdentificationNumber As TextBox
    Friend WithEvents grpCollection As GroupBox
    Friend WithEvents btnSelectCollection As Button
    Friend WithEvents lblCollectionIdentificationNumber As Label
    Friend WithEvents txtCollectionIdentificationNumber As TextBox
    Friend WithEvents txtOutputCollection As TextBox
    Friend WithEvents lblNameCollection As Label
    Friend WithEvents txtNameCollection As TextBox
    Friend WithEvents btnAddCollection As Button
    Friend WithEvents grpQueue As GroupBox
    Friend WithEvents btnDequeue As Button
    Friend WithEvents txtOutputQueue As TextBox
    Friend WithEvents lblNameQueue As Label
    Friend WithEvents txtNameQueue As TextBox
    Friend WithEvents btnAddQueue As Button
    Friend WithEvents btnQueuePeek As Button
    Friend WithEvents grpStack As GroupBox
    Friend WithEvents btnStackPeek As Button
    Friend WithEvents btnPop As Button
    Friend WithEvents txtOutputStack As TextBox
    Friend WithEvents lblNameStack As Label
    Friend WithEvents txtNameStack As TextBox
    Friend WithEvents btnAddStack As Button
End Class
