Imports GALAModels
Imports System.Data.EntityClient

Public Class GALAService
    Implements IGALAService

    Public Function GetAllClients() As List(Of ClientsData) Implements IGALAService.GetAllClients
        Dim contexto As GALA_ServiceEntities = New GALA_ServiceEntities()
        Using contexto

            Dim MyClients As List(Of ClientsData) = New List(Of ClientsData)

            Dim MyQuery = (From cl In contexto.Clientes
                           Select cl).Take(10)

            For Each c In MyQuery
                Dim cData As ClientsData = New ClientsData()
                cData.EmpleadoData = New EmpleadosData()
                cData.PaisData = New PaisesData()
                cData.IdCliente = c.IdCliente
                cData.Nombre = c.Nombre
                cData.NombreFact = c.NombreFact
                cData.DireccionCobro = c.DireccionCobro
                cData.DireccionEnviar = c.DireccionEnviar
                cData.CodPais = c.CodPais
                cData.Ter = c.Ter
                cData.Telefono = c.Telefono
                cData.Fax = c.Fax
                cData.CodEmpleado = c.CodEmpleado
                cData.FechaApertura = c.FechaApertura
                cData.Email = c.Email
                cData.CodGrupo = c.CodGrupo
                cData.ClasificacionIndustria = c.ClasificacionIndustria
                cData.Observaciones = c.Observaciones
                cData.CodClase = c.CodClase
                cData.FechaModificacion = c.FechaModificacion
                cData.EmpleadoData.NombreEmpleado = c.Empleado.NombreEmpleado
                cData.PaisData.Nombre = c.Pais.Nombre
                MyClients.Add(cData)
            Next
            Return MyClients
        End Using
    End Function

    Public Function GetLastClients(Limit As String) As List(Of ClientsData) Implements IGALAService.GetLastClients
        Dim contexto As GALA_ServiceEntities = New GALA_ServiceEntities()

        Dim iLimit As Integer = Integer.Parse(Limit)

        Using contexto

            Dim MyClients As List(Of ClientsData) = New List(Of ClientsData)

            Dim MyQuery = (From cl In contexto.Clientes
                           Order By cl.FechaApertura Descending
                           Select cl).Take(iLimit)

            For Each c In MyQuery
                Dim cData As ClientsData = New ClientsData()
                cData.IdCliente = c.IdCliente
                cData.Nombre = c.Nombre
                cData.NombreFact = c.NombreFact
                cData.DireccionCobro = c.DireccionCobro
                cData.DireccionEnviar = c.DireccionEnviar
                cData.CodPais = c.CodPais
                cData.Ter = c.Ter
                cData.Telefono = c.Telefono
                cData.Fax = c.Fax
                cData.CodEmpleado = c.CodEmpleado
                cData.FechaApertura = c.FechaApertura
                cData.Email = c.Email
                cData.CodGrupo = c.CodGrupo
                cData.ClasificacionIndustria = c.ClasificacionIndustria
                cData.Observaciones = c.Observaciones
                cData.CodClase = c.CodClase
                cData.FechaModificacion = c.FechaModificacion
                MyClients.Add(cData)
            Next
            Return MyClients
        End Using

    End Function

End Class
