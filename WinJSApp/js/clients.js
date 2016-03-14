angular.module("clientBrowser", [])
    .service("clientService", function($http) {
        return {
            getClients: function() {
                return $http.get("http://localhost:49920/GALAService.svc/GetAllClients");
            }
        }
    })
    .controller("clientList", function ($scope, clientService) {
        clientService.getClients()
            .success(function (result) {
                $scope.clients = result;
            })
            .error(function () {
                $scope.message = "Error en la conexión"
            })
    })