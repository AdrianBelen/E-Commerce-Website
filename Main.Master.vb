Imports System.Data
Imports System.Data.SqlClient
Public Class Site1
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strConn As String = System.Configuration.ConfigurationManager.ConnectionStrings("ConnectionStringECommerceProject").ConnectionString
        Dim connMainCategory As SqlConnection
        Dim cmdMainCategory As SqlCommand
        Dim drMainCategory As SqlDataReader
        Dim strSQL As String = "Select * from Category Where Parent = 0"
        connMainCategory = New SqlConnection(strConn)
        cmdMainCategory = New SqlCommand(strSQL, connMainCategory)
        connMainCategory.Open()
        drMainCategory = cmdMainCategory.ExecuteReader(CommandBehavior.CloseConnection)
        Dim strMainCategory As String = ""
        Do While drMainCategory.Read()
            strMainCategory = strMainCategory + "<li><a href=''>" + Trim(drMainCategory("CategoryName")) + "</a></li>"
        Loop
        lblMainCategory.Text = strMainCategory
    End Sub

    Protected Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'If tbSearch.Text <> "" Then
        ' check if there is a match in the ProductNo field of the Product table
        ' all three database classes
        ' the sql = select * from Product Where ProductNo = tbSearch.Text
        ' execute it
        ' if datareader.read() then
        '    Dim strRedirectString as String = "ProductDetail.aspx?ProductNo=" & tbSearch.Text
        '    Response.Redirect(strRedirectString)
        ' Else
        '    all three database classes
        '    the sql = select * from Product Where ProductName Like = tbSearch.Text
        '    execute it
        '    if datareader.read() then
        '       Dim strRedirectString as String = "Category.aspx?SearchString=" & tbSearch.Text
        '       Response.Redirect(strRedirectString)
        '    End If
        ' End If
        ' End If




    End Sub
End Class
