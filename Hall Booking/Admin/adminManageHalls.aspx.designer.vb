﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated. 
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Partial Public Class adminManageHalls
    
    '''<summary>
    '''titleText control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents titleText As Global.System.Web.UI.WebControls.Label
    
    '''<summary>
    '''Halls control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents Halls As Global.System.Web.UI.WebControls.PlaceHolder
    
    '''<summary>
    '''HallTable control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents HallTable As Global.System.Web.UI.WebControls.Table
    
    '''<summary>
    '''Master property.
    '''</summary>
    '''<remarks>
    '''Auto-generated property.
    '''</remarks>
    Public Shadows ReadOnly Property Master() As Hall_Booking.adminMaster
        Get
            Return CType(MyBase.Master,Hall_Booking.adminMaster)
        End Get
    End Property
End Class
