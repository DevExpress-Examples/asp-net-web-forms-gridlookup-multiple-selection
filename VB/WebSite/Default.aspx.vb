Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxGridLookup
Imports DevExpress.Web.ASPxGridView
Imports DevExpress.Web.ASPxEditors

Partial Public Class _Default
    Inherits System.Web.UI.Page
    Private Const DataItemsCount As Integer = 200

    Protected Sub gridLookup_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim gl As ASPxGridLookup = CType(sender, ASPxGridLookup)

        Dim gv As ASPxGridView = gl.GridView
        AddHandler gv.CustomJSProperties, AddressOf gv_CustomJSProperties
        gv.ClientSideEvents.SelectionChanged = "OnGridViewSelectionChanged"

        gl.DataSource = CreateDataSource()
        gl.DataBind()
    End Sub

    Private Sub gv_CustomJSProperties(ByVal sender As Object, ByVal e As ASPxGridViewClientJSPropertiesEventArgs)
        Dim gv As ASPxGridView = CType(sender, ASPxGridView)
        e.Properties("cpVisibleRowCount") = gv.VisibleRowCount
    End Sub

    Protected Sub checkBoxSelectAll_Init(ByVal sender As Object, ByVal e As EventArgs)
        Dim cb As ASPxCheckBox = CType(sender, ASPxCheckBox)

        Dim gv As ASPxGridView = (TryCast(cb.NamingContainer, GridViewHeaderTemplateContainer)).Grid

        If gv.Selection.Count = gv.VisibleRowCount Then
            cb.Checked = True
        ElseIf gv.Selection.Count > 0 Then
            cb.CheckState = DevExpress.Web.ASPxClasses.CheckState.Indeterminate
        Else
            cb.Checked = False
        End If
    End Sub

    Private Function CreateDataSource() As List(Of LookUpDataItem)
        Dim dataSource As List(Of LookUpDataItem) = New List(Of LookUpDataItem)()

        For i As Integer = 0 To DataItemsCount - 1
            Dim item As LookUpDataItem = New LookUpDataItem()

            With item
                .ID = i
                .Text = "Text - " & i.ToString()
            End With

            dataSource.Add(item)
        Next

        Return dataSource
    End Function
End Class
Public Class LookUpDataItem
    Private privateID As Integer
    Public Property ID() As Integer
        Get
            Return privateID
        End Get
        Set(ByVal value As Integer)
            privateID = value
        End Set
    End Property
    Private privateText As String
    Public Property Text() As String
        Get
            Return privateText
        End Get
        Set(ByVal value As String)
            privateText = value
        End Set
    End Property
End Class