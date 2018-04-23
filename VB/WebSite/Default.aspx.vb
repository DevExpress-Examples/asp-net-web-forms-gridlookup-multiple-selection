Imports System
Imports System.Collections.Generic
Imports DevExpress.Web.ASPxGridLookup

Partial Public Class _Default
	Inherits System.Web.UI.Page

	Private Const DataItemsCount As Integer = 200

	Protected Sub gridLookup_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim gl As ASPxGridLookup = DirectCast(sender, ASPxGridLookup)

		gl.DataSource = CreateDataSource()
		gl.DataBind()
	End Sub

	Private Function CreateDataSource() As List(Of LookUpDataItem)
		Dim dataSource As New List(Of LookUpDataItem)()

		For i As Integer = 0 To DataItemsCount - 1
			dataSource.Add(New LookUpDataItem() With {.ID = i, .Text = "Text - " & i.ToString()})
		Next i

		Return dataSource
	End Function
End Class
Public Class LookUpDataItem
	Public Property ID() As Integer
	Public Property Text() As String
End Class