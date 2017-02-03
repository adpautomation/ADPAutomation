Imports System.IO
Imports TS.Core.Data
Imports TS.Core.Extensions


Module Module1
    Sub Main(args As String())

        Dim startTime As DateTime = DateTime.Now
        Dim consoleOuputText As String
        Dim batchFile As String = ""
        Dim packageName As String = ""
        Dim exitCode As Integer = 0

        Try
            If args Is Nothing OrElse args.Count <= 0 Then
                Throw New Exception("Missing/Empty Package Validator parameters: <Batch File Path> <Package Name>")
            End If

            batchFile = args(0).Replace("""", "")
            packageName = args(1)

            Dim psi As New Process
            With psi
                .StartInfo = New ProcessStartInfo(batchFile)
                With .StartInfo
                    .RedirectStandardError = True
                    .RedirectStandardOutput = True
                    .CreateNoWindow = False
                    .UseShellExecute = False
                    .WorkingDirectory = Path.GetDirectoryName(batchFile)
                End With
                .Start()
                Using oStreamReader As StreamReader = psi.StandardOutput
                    consoleOuputText = oStreamReader.ReadToEnd()
                End Using
                .WaitForExit()
                Console.WriteLine(consoleOuputText)
                exitCode = .ExitCode
                .Close()
            End With

            Dim isFailed = False
            Dim subjectOnFailure = ""

            consoleOuputText = String.Format("{0}{1}Exit Code: {2}", consoleOuputText, vbCrLf, exitCode)

            If exitCode = 1 Then
                subjectOnFailure = "finished with Exit Code 1 (Error)"
                isFailed = True
            Else
                Dim sql = String.Format("SELECT DISTINCT [EventType], [TaskEnd] FROM [BSGMART].[dbo].[DU_SSIS_EventLog] WHERE PackageName = '{0}' AND PackageStart >= CAST('{1:yyyy-MM-dd HH:mm:00.000}' AS DATETIME) ORDER BY TaskEnd DESC", packageName, startTime)
                Dim dt As DataTable = DataFacade.GetDataTable(ConnectionString.BSGMART, sql)
                If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                    ' got records, is there an error?
                    If dt.Rows.Cast(Of DataRow)().Any(Function(r) r("EventType").ToString.ToLower.Contains("onerror")) Then
                        isFailed = True
                        subjectOnFailure = "had Errors"
                    End If
                Else
                    ' no records returned!
                    isFailed = True
                    subjectOnFailure = "did not Run"
                End If
            End If

            If isFailed Then
                SendEmail(String.Format("*** ERROR SSIS (PROD) *** Package: {0} {1}. Date: {2:yyyy-MM-dd hh:mm:ss tt}", packageName, subjectOnFailure, startTime), consoleOuputText)
            Else
                SendEmail(String.Format("SSIS REPORT (PROD):   Package: {0} finished. Date: {1:yyyy-MM-dd HH:mm:ss}", packageName, startTime), consoleOuputText, "carlos.nunez@adp.com")
            End If

        Catch ex As Exception
            SendEmail("*** ERROR SSIS (PROD) *** Package Validator Exception: ", String.Format("{0}{1}", ex.Message, ex.StackTrace), "carlos.nunez@adp.com,carlos@nunez@adp.com")
        End Try
    End Sub

    Private Sub SendEmail(subject As String, body As String, Optional EmailTo As String = "")
        Try
            Dim em As New Emailer
            em.SmtpServer = TS.Core.Data.ApplicationString.SmtpServerUrl
#If DEBUG Then
            em.From = "carlos.nunez@adp.com"
            em.To = "carlos.nunez@adp.com"
#Else
            em.From = ApplicationString.BSGDotNetEmailAddress
            If EmailTo = "" Then
                em.To = Configuration.ConfigurationManager.AppSettings("EMAIL_TO")
            Else
                em.To = EmailTo
            End If
#End If
            em.Subject = subject
            em.Body = String.Format("{0}<br/><br/>{1}", subject, Replace(body, vbCrLf, "<br/>"))
            If Not em.Send() Then
                Throw New Exception("Error email could not be sent.")
            End If
        Catch ex As Exception
            File.AppendAllText("PackageValidatorErrors.log", String.Format("{0}/{1} @ {2}{3}", ex.Message, ex.StackTrace, DateTime.Now.ToString, vbCrLf))
        End Try
    End Sub

End Module
