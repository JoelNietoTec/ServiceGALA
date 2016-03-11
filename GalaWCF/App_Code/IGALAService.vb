<ServiceContract()>
Public Interface IGALAService
    <OperationContract()>
    <WebGet(UriTemplate:="/GetAllClients", RequestFormat:=WebMessageFormat.Json, ResponseFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped)>
    Function GetAllClients() As List(Of ClientsData)


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
    Public Property CodEmpleado() As Nullable(Of Integer)
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

End Class

