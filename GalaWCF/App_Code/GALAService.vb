Imports GALAModels
Imports System.Data.EntityClient

Public Class GALAService
    Implements IGALAService

    Public Function GetAllClients() As List(Of ClientsData) Implements IGALAService.GetAllClients
        Dim contexto As GALA_ServiceEntities = New GALA_ServiceEntities()
        Using contexto

            Dim MyClients As List(Of ClientsData) = New List(Of ClientsData)

            For Each c In contexto.Clientes
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
