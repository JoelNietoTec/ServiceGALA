<ServiceContract()>
Public Interface IGALAService
    <OperationContract()>
    Function GetAllClients() As List(Of ClientsData)


End Interface

<DataContract()>
Public Class ClientsData
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
    Public Property Ter As Integer
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
    Public Property CodGrupo() As Integer
    <DataMember()>
    Public Property ClasificacionIndustria() As String
    <DataMember()>
    Public Property Observaciones() As String
    <DataMember()>
    Public Property CodClase() As String
    <DataMember()>
    Public Property FechaModificacion() As DateTime

End Class

