<ServiceContract()>
Public Interface IGALAService
    <OperationContract()>
    <WebGet(UriTemplate:="/GetAllClients/", RequestFormat:=WebMessageFormat.Json, ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)>
    Function GetAllClients() As List(Of ClientsData)

    <OperationContract()>
    <WebGet(UriTemplate:="/GetLastClients/{limit}/clients", RequestFormat:=WebMessageFormat.Json, ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)>
    Function GetLastClients(Limit As String) As List(Of ClientsData)


End Interface

<DataContract()>
Public Class ClientsData
    <Key()>
    <DataMember()>
    Public Property IdCliente As Integer
    <DataMember()>
    Public Property Nombre() As String
    <DataMember()>
    Public Property NombreFact() As String
    <DataMember()>
    Public Property DireccionCobro() As String
    <DataMember()>
    Public Property DireccionEnviar() As String
    <DataMember()>
    Public Property CodPais() As String
    <DataMember()>
    Public Property Ter As Nullable(Of Integer)
    <DataMember()>
    Public Property Telefono() As String
    <DataMember()>
    Public Property Fax() As String
    <DataMember()>
    Public Property CodEmpleado() As Integer
    <DataMember()>
    Public Property FechaApertura() As DateTime
    <DataMember()>
    Public Property Email() As String
    <DataMember()>
    Public Property CodGrupo() As Nullable(Of Integer)
    <DataMember()>
    Public Property ClasificacionIndustria() As String
    <DataMember()>
    Public Property Observaciones() As String
    <DataMember()>
    Public Property CodClase() As String
    <DataMember()>
    Public Property FechaModificacion() As Nullable(Of DateTime)
    <DataMember()>
    Public Overridable Property PaisData() As PaisesData
    <DataMember()>
    Public Overridable Property EmpleadoData() As EmpleadosData
End Class

<DataContract()>
Public Class PaisesData
    <Key()>
    <DataMember()>
    Public Property CodPais() As String
    <DataMember()>
    Public Property Nombre() As String
End Class

Public Class EmpleadosData
    <Key()>
    <DataMember()>
    Public Property CodEmpleado() As Integer
    <DataMember()>
    Public Property NombreEmpleado() As String
    <DataMember()>
    Public Property Cargo() As String
End Class
