// Para obtener una introducción a la plantilla En blanco, consulte la siguiente documentación:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
	"use strict";

	var app = WinJS.Application;
	var activation = Windows.ApplicationModel.Activation;

	app.onactivated = function (args) {
		if (args.detail.kind === activation.ActivationKind.launch) {
			if (args.detail.previousExecutionState !== activation.ApplicationExecutionState.terminated) {
				// TODO: esta aplicación se ha iniciado recientemente. Inicialice aquí su aplicación.
			} else {
				// TODO: Se ha suspendido y finalizado esta aplicación.
				// Para crear una experiencia de usuario fluida, restaure aquí el estado de la aplicación de forma que parezca que la aplicación no ha dejado de ejecutarse nunca.
			}
			args.setPromise(WinJS.UI.processAll());
		}
	};

	app.oncheckpoint = function (args) {
		// TODO: esta aplicación está a punto de suspenderse. Guarde aquí cualquier estado que deba conservarse en las suspensiones.
		// Puede utilizar el objeto WinJS.Application.sessionState, que se guarda y se restaura automáticamente en las suspensiones.
		// Si tiene que completar una operación asíncrona antes de que se suspenda su aplicación, llame a args.setPromise().
	};

	app.start();
})();
