Module Module1
    Public appPath1 As String = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase
    Public appPath As String = System.IO.Path.GetDirectoryName(appPath1)
    Public Connect_String As String = "Driver={Microsoft Access Driver (*.mdb)};DBQ=" & appPath.Replace("file:\", "") & "\Data\ScaleDB.mdb"
    Public MyConnection As New Odbc.OdbcConnection(Connect_String)
End Module
