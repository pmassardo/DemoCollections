Option Strict On

Public Class Student

    Private Shared studentCount As Integer = 0 ' Field to hold the number of created students
    Private studentName As String = String.Empty ' Field to hold a student's name
    Private yearsToGraduation As Integer = 0 ' Field to hold the number of years before a student graduates 
    Private studentIdentificationNumber As Integer = 0

    Public Sub New() ' Default Constructor 
        studentCount += 1 ' During instantiation add a student to the count
        studentIdentificationNumber = studentCount ' Set the studentIdentificationNumber 
        yearsToGraduation = 3 ' If the default constructor is called set the yearsToGraduation field to 3
    End Sub


    Public Sub New(years As Integer) ' Parameterized Constructor
        studentCount += 1 ' During instantiation add a student to the count
        studentIdentificationNumber = studentCount ' Set the studentIdentificationNumber 
        yearsToGraduation = years ' If the parameterized constructor is called set the yearsToGraduation to years
    End Sub


    Public Property Name() As String
        Get
            Return studentName ' Return the value that is in the private studentName field
        End Get
        Set(ByVal value As String)

            studentName = value ' Set the studentName field to the value that is passed in
        End Set
    End Property '

    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return studentIdentificationNumber ' Return the value that is in the private studentIdentificationNumber field
        End Get
    End Property '

    Public ReadOnly Property Count() As Integer
        Get
            Return studentCount ' Return the value that is in the private studentCount field
        End Get
    End Property '


    Public Function GetStudentData() As String ' Function to return all the students data
        Return "Student- ID- " & studentIdentificationNumber.ToString() & " " & studentName & " will graduate in " & yearsToGraduation.ToString() & " years."
    End Function

End Class
