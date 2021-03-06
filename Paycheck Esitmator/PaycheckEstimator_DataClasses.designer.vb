﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1022
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="PaycheckEstimatorDB")>  _
Partial Public Class PaycheckEstimator_DataClassesDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertList(instance As List)
    End Sub
  Partial Private Sub UpdateList(instance As List)
    End Sub
  Partial Private Sub DeleteList(instance As List)
    End Sub
  Partial Private Sub InsertListItem(instance As ListItem)
    End Sub
  Partial Private Sub UpdateListItem(instance As ListItem)
    End Sub
  Partial Private Sub DeleteListItem(instance As ListItem)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.Paycheck_Esitmator.My.MySettings.Default.PaycheckEstimatorDBConnectionString1, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Lists() As System.Data.Linq.Table(Of List)
		Get
			Return Me.GetTable(Of List)
		End Get
	End Property
	
	Public ReadOnly Property ListItems() As System.Data.Linq.Table(Of ListItem)
		Get
			Return Me.GetTable(Of ListItem)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Lists")>  _
Partial Public Class List
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ID As System.Guid
	
	Private _Name As String
	
	Private _PaystubID As System.Nullable(Of System.Guid)
	
	Private _ListItems As EntitySet(Of ListItem)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIDChanging(value As System.Guid)
    End Sub
    Partial Private Sub OnIDChanged()
    End Sub
    Partial Private Sub OnNameChanging(value As String)
    End Sub
    Partial Private Sub OnNameChanged()
    End Sub
    Partial Private Sub OnPaystubIDChanging(value As System.Nullable(Of System.Guid))
    End Sub
    Partial Private Sub OnPaystubIDChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._ListItems = New EntitySet(Of ListItem)(AddressOf Me.attach_ListItems, AddressOf Me.detach_ListItems)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ID", DbType:="UniqueIdentifier NOT NULL", IsPrimaryKey:=true)>  _
	Public Property ID() As System.Guid
		Get
			Return Me._ID
		End Get
		Set
			If ((Me._ID = value)  _
						= false) Then
				Me.OnIDChanging(value)
				Me.SendPropertyChanging
				Me._ID = value
				Me.SendPropertyChanged("ID")
				Me.OnIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Name", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Name() As String
		Get
			Return Me._Name
		End Get
		Set
			If (String.Equals(Me._Name, value) = false) Then
				Me.OnNameChanging(value)
				Me.SendPropertyChanging
				Me._Name = value
				Me.SendPropertyChanged("Name")
				Me.OnNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PaystubID", DbType:="UniqueIdentifier")>  _
	Public Property PaystubID() As System.Nullable(Of System.Guid)
		Get
			Return Me._PaystubID
		End Get
		Set
			If (Me._PaystubID.Equals(value) = false) Then
				Me.OnPaystubIDChanging(value)
				Me.SendPropertyChanging
				Me._PaystubID = value
				Me.SendPropertyChanged("PaystubID")
				Me.OnPaystubIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="List_ListItem", Storage:="_ListItems", ThisKey:="ID", OtherKey:="ListID")>  _
	Public Property ListItems() As EntitySet(Of ListItem)
		Get
			Return Me._ListItems
		End Get
		Set
			Me._ListItems.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_ListItems(ByVal entity As ListItem)
		Me.SendPropertyChanging
		entity.List = Me
	End Sub
	
	Private Sub detach_ListItems(ByVal entity As ListItem)
		Me.SendPropertyChanging
		entity.List = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.ListItems")>  _
Partial Public Class ListItem
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ListID As System.Guid
	
	Private _Name As String
	
	Private _Amount As Decimal
	
	Private _Quantity As Integer
	
	Private _IsComplete As Boolean
	
	Private _List As EntityRef(Of List)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnListIDChanging(value As System.Guid)
    End Sub
    Partial Private Sub OnListIDChanged()
    End Sub
    Partial Private Sub OnNameChanging(value As String)
    End Sub
    Partial Private Sub OnNameChanged()
    End Sub
    Partial Private Sub OnAmountChanging(value As Decimal)
    End Sub
    Partial Private Sub OnAmountChanged()
    End Sub
    Partial Private Sub OnQuantityChanging(value As Integer)
    End Sub
    Partial Private Sub OnQuantityChanged()
    End Sub
    Partial Private Sub OnIsCompleteChanging(value As Boolean)
    End Sub
    Partial Private Sub OnIsCompleteChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._List = CType(Nothing, EntityRef(Of List))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ListID", DbType:="UniqueIdentifier NOT NULL", IsPrimaryKey:=true)>  _
	Public Property ListID() As System.Guid
		Get
			Return Me._ListID
		End Get
		Set
			If ((Me._ListID = value)  _
						= false) Then
				If Me._List.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnListIDChanging(value)
				Me.SendPropertyChanging
				Me._ListID = value
				Me.SendPropertyChanged("ListID")
				Me.OnListIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Name", DbType:="NVarChar(50) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property Name() As String
		Get
			Return Me._Name
		End Get
		Set
			If (String.Equals(Me._Name, value) = false) Then
				Me.OnNameChanging(value)
				Me.SendPropertyChanging
				Me._Name = value
				Me.SendPropertyChanged("Name")
				Me.OnNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Amount", DbType:="Money NOT NULL")>  _
	Public Property Amount() As Decimal
		Get
			Return Me._Amount
		End Get
		Set
			If ((Me._Amount = value)  _
						= false) Then
				Me.OnAmountChanging(value)
				Me.SendPropertyChanging
				Me._Amount = value
				Me.SendPropertyChanged("Amount")
				Me.OnAmountChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Quantity", DbType:="Int NOT NULL")>  _
	Public Property Quantity() As Integer
		Get
			Return Me._Quantity
		End Get
		Set
			If ((Me._Quantity = value)  _
						= false) Then
				Me.OnQuantityChanging(value)
				Me.SendPropertyChanging
				Me._Quantity = value
				Me.SendPropertyChanged("Quantity")
				Me.OnQuantityChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_IsComplete", DbType:="Bit NOT NULL")>  _
	Public Property IsComplete() As Boolean
		Get
			Return Me._IsComplete
		End Get
		Set
			If ((Me._IsComplete = value)  _
						= false) Then
				Me.OnIsCompleteChanging(value)
				Me.SendPropertyChanging
				Me._IsComplete = value
				Me.SendPropertyChanged("IsComplete")
				Me.OnIsCompleteChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="List_ListItem", Storage:="_List", ThisKey:="ListID", OtherKey:="ID", IsForeignKey:=true)>  _
	Public Property List() As List
		Get
			Return Me._List.Entity
		End Get
		Set
			Dim previousValue As List = Me._List.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._List.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._List.Entity = Nothing
					previousValue.ListItems.Remove(Me)
				End If
				Me._List.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.ListItems.Add(Me)
					Me._ListID = value.ID
				Else
					Me._ListID = CType(Nothing, System.Guid)
				End If
				Me.SendPropertyChanged("List")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
