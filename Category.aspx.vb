Imports System.Data
Imports System.Data.SqlClient
Public Class Category
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Request.QueryString("SearchString") <> "" Then
            ' SqlDSProductList.SelectCommand = "Select * From Product Where ProductName Like = Request.QueryString("SearchString")
            ' SqlDSProductList.DataBind()
            ' lblProductList.Text = "Search result for " + Request.QueryString("SearchString")
        Else
            If Request.QueryString("MainCategoryID") <> "" Then
                lblCategory.Text = Request.QueryString("MainCategoryName")
                SqlDSSubCategory.SelectCommand = "Select * From Category Where Parent = " & CInt(Request.QueryString("MainCategoryID"))
                SqlDSSubCategory.DataBind()
                If Request.QueryString("SubCategoryID") <> "" Then
                    SqlDSProductList.SelectCommand = "Select * From Product Where SubCategoryID = " & CInt(Request.QueryString("SubCategoryID"))
                    SqlDSProductList.DataBind()
                    lblProductList.Text = "Products for " + Request.QueryString("SubCategoryName")
                Else
                    SqlDSProductList.SelectCommand = "Select * From Product Where MainCategoryID = " & CInt(Request.QueryString("MainCategoryID")) & " and Featured = 'Y'"
                    SqlDSProductList.DataBind()
                    lblProductList.Text = "Featured Product"
                End If
            End If
        End If
    End Sub

End Class
