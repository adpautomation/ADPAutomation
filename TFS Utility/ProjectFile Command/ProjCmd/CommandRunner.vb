Imports System.IO
Imports Microsoft.Build.Evaluation
Imports Microsoft.VisualBasic.CompilerServices


Public Class CommandRunner
    Private args As String()

    Private commandName As String
    Private projectFolder As String
    Private distFolder As String
    Private projectFile As String
    Private tfsProjectFolder As String = "$/Mobile/Development"
    Private deploymentType As String = "1"

    Private delfiles As String = "D:\Builds\Scripts\delfiles.bat"
    Private addfiles As String = "D:\Builds\Scripts\addfiles.bat"
    Private tfsFileData As String = "D:\Builds\Scripts\tf_old_dev_files.txt"

    Private Function _Lambda1(ByVal pi As ProjectItem) As Boolean
        Return pi.EvaluatedInclude.ToLower.Contains((Me.args(2) & "\"))
    End Function


    Public Sub New(ByVal params As String())
        Me.args = params
        For Each p As String In params
            Console.WriteLine("Parameter: " & p)
        Next
    End Sub


    Private Function FixPath(ByVal filepath As String) As String
        filepath = filepath.Replace("\\", "\")
        If filepath.Contains("\\") Then
            Me.FixPath(filepath)
        End If
        filepath = filepath.Replace("..", ".")
        If filepath.Contains("..") Then
            Me.FixPath(filepath)
        End If
        filepath = filepath.Replace("""", "")
        If filepath.Contains("""") Then
            Me.FixPath(filepath)
        End If
        If filepath.Contains(":") Then
            Dim sourceArray As String() = filepath.Split(New Char() {":"c})
            If Not sourceArray(1).StartsWith("\") Then
                sourceArray(1) = (":\" & sourceArray(1))
            Else
                sourceArray(1) = (":" & sourceArray(1))
            End If
            filepath = Join(sourceArray, "")
        End If
        filepath = filepath.Replace("\ ", "\")
        If filepath.Contains("\ ") Then
            Me.FixPath(filepath)
        End If
        filepath = filepath.Replace(" \", "\")
        If filepath.Contains(" \") Then
            Me.FixPath(filepath)
        End If
        Return filepath.Trim
    End Function


    Public Function Run() As Integer

        Console.WriteLine("Running PRJCMD application @ " & DateTime.Now)

        If ((Me.args Is Nothing) OrElse (Me.args.Length < 4)) Then
            ' Error: missing parameter(s)"
            Return 1
        End If
        Dim totalArgs As Integer = (Enumerable.Count(Of String)(Me.args) - 1)
        Dim i As Integer = 0
        Do While (i <= totalArgs)
            Me.args(i) = Me.args(i).Replace("""", "").Trim
            i += 1
        Loop

        ' 0 - command (eval, add, etc)
        ' 1 - project folder
        ' 2 - dist folder
        ' 3 - project file
        ' 4 - deployment type
        ' 5 - tfs project folder

        commandName = args(0).ToLower.Trim
        projectFolder = args(1).Trim
        distFolder = Me.FixPath(projectFolder & "\" & args(2))
        projectFile = args(3)
        deploymentType = args(4).Trim
        tfsProjectFolder = args(5)

        Select Case deploymentType
            Case "1"
                tfsFileData = "D:\Builds\Scripts\tf_old_dev_files.txt"
            Case "2"
                tfsFileData = "D:\Builds\Scripts\tf_old_stg_files.txt"
            Case Else
                tfsFileData = "D:\Builds\Scripts\tf_old_files.txt"
        End Select

        delfiles = Replace(delfiles, ".bat", deploymentType & ".bat")
        addfiles = Replace(addfiles, ".bat", deploymentType & ".bat")

        Console.WriteLine("deployment Type: " & deploymentType)
        Console.WriteLine("projectFolder:" & projectFolder)
        Console.WriteLine("distFolder:" & distFolder)

        Dim project As Project = Nothing

        If File.Exists(projectFolder & "\" & projectFile) Then
            project = New Project(projectFolder & "\" & projectFile, Nothing, Nothing, New ProjectCollection)
        Else
            ' Error: Project file not found
            Return 1
        End If
        If (Not project Is Nothing) Then
            Select Case commandName
                Case "eval"

                    Console.WriteLine("Batch Locations: " & delfiles & "   " & addfiles)

                    Try
                        File.Delete(delfiles)
                    Catch ex As Exception
                        ' nothing
                    End Try

                    Try
                        File.Delete(addfiles)
                    Catch ex As Exception
                        ' nothing
                    End Try

                    ' make sure the files are deleted
                    If File.Exists(addfiles) Then Return 1
                    If File.Exists(delfiles) Then Return 1

                    ' old dist files from the project file
                    Dim list As List(Of ProjectItem) = Enumerable.ToList(Of ProjectItem)(project.GetItems("Content")).FindAll(New Predicate(Of ProjectItem)(AddressOf _Lambda1))

                    Dim totalold As Integer = list.Count - 1
                    ' remove all dist files from the project
                    For x As Integer = 0 To totalold
                        project.RemoveItem(list(x))
                    Next

                    ' add the new dist files to the project file
                    Dim newTfsFiles As String() = Directory.GetFiles(distFolder, "*.*", SearchOption.AllDirectories)
                    For x As Integer = 0 To newTfsFiles.Count - 1
                        project.AddItem("Content", newTfsFiles(x).Replace(distFolder, args(2)))
                    Next

#If Not DEBUG Then
                    project.Save()
#End If

                    ' read the old files from TFS (to find out differences)
                    Dim oldTfsFiles As New List(Of String)
                    Dim folder As String = ""
                    Dim filedata = File.ReadAllText(tfsFileData)
                    Dim Lines As String() = Split(filedata, vbCrLf)

                    For Each ln As String In Lines
                        If ln.Trim.Contains("$/") Then
                            'this is a folder
                            folder = mapFolderRename(ln)
                        ElseIf ln.Trim = "" Then
                            'new folder comming or end of file
                            Continue For
                        ElseIf ln.Contains("item(s)") Then
                            Continue For
                        Else
                            ' file
                            If Not ln.Contains("$") Then
                                oldTfsFiles.Add(folder & "\" & ln.Trim)
                            End If
                        End If
                    Next


                    Dim myFileCompare As New FileCompare

                    ''''' This query determines whether the two folders contain
                    ''''' identical file lists, based on the custom file comparer
                    ''''' that is defined in the FileCompare class.
                    ''''' The query executes immediately because it returns a bool.
                    ''''Dim areIdentical As Boolean = oldTfsFiles.SequenceEqual(newDistFiles.ToList, myFileCompare)
                    ''''If areIdentical = True Then
                    ''''    Console.WriteLine("The two folders are the same.")
                    ''''Else
                    ''''    Console.WriteLine("The two folders are not the same.")
                    ''''End If

                    ' Find the set difference between the two folders.
                    ' For this example we only check one way.
                    Dim oldVsNew = oldTfsFiles.Except(newTfsFiles.ToList, myFileCompare)
                    Console.WriteLine("The following files are in old project file but not in the new one")
                    For Each fi As String In oldVsNew
                        ' delete the file from tfs
                        If Not fi.Contains(distFolder) Then Continue For
                        File.AppendAllText(delfiles, "%1 delete /recursive " & fi & vbCrLf)
                        Console.WriteLine(fi)
                    Next


                    Dim newVsOld = newTfsFiles.Except(oldTfsFiles.ToList, myFileCompare)
                    Console.WriteLine("The following files are in new project file but not in old one")
                    For Each fi As String In newVsOld
                        ' add the file from tfs
                        If Not fi.Contains(distFolder) Then Continue For
                        File.AppendAllText(addfiles, "%1 add " & fi & " /recursive /noprompt" & vbCrLf)
                        Console.WriteLine(fi)
                    Next

                    Console.WriteLine("Finished PRJCMD application @ " & DateTime.Now & " with SUCCESS")

                    Return 0

                Case Else
                    Console.WriteLine("Finished PRJCMD application @ " & DateTime.Now & " with FAILURE")
                    Return 1
            End Select
        End If

        Console.WriteLine("Finished PRJCMD application @ " & DateTime.Now & " with FAILURE")
        Return 1

    End Function


    Private Function mapFolderRename(foldername As String) As String
        foldername = foldername.Replace(tfsProjectFolder, projectFolder)
        foldername = foldername.Replace("/", "\")
        foldername = foldername.TrimEnd(":")
        Return foldername
    End Function



End Class

Public Class FolderData
    Public Property FolderName As String
    Public Files As List(Of FileData)
    Public Sub New()
        Files = New List(Of FileData)
    End Sub
End Class

Public Class FileData
    Public Property FileName As String
End Class

' This implementation defines a very simple comparison
' between two FileInfo objects. 
Public Class FileCompare
    Implements System.Collections.Generic.IEqualityComparer(Of String)

    Public Function Equals1(ByVal x As String, ByVal y As String) _
            As Boolean Implements System.Collections.Generic.IEqualityComparer(Of String).Equals

        If (x.Trim.ToLower = y.Trim.ToLower) Then
            Return True
        Else
            Return False
        End If
    End Function

    ' Return a hash that reflects the comparison criteria. According to the 
    ' rules for IEqualityComparer(Of T), if Equals is true, then the hash codes must
    ' also be equal. Because equality as defined here is a simple value equality, not
    ' reference identity, it is possible that two or more objects will produce the same
    ' hash code.
    Public Function GetHashCode1(ByVal fi As String) _
            As Integer Implements System.Collections.Generic.IEqualityComparer(Of String).GetHashCode
        Dim s As String = fi
        Return s.GetHashCode()
    End Function

End Class