Type.registerNamespace("Alchemy.Plugins.Big_Box_Of_Samples.Views");
Alchemy.Plugins.Big_Box_Of_Samples.Views.BigBoxSamplePopup = function BigBoxSamplePopup() {
	Tridion.OO.enableInterface(this, "Alchemy.Plugins.Big_Box_Of_Samples.Views.BigBoxSamplePopup");
	this.addInterface("Tridion.Cme.View");
};

Alchemy.Plugins.Big_Box_Of_Samples.Views.BigBoxSamplePopup.prototype.initialize = function () {
    var controls = this.properties.controls;

    alert("BigBoxSamplePopup.js resource initialized successfully!!");

    this.callBase("Tridion.Cme.View", "initialize");

    controls.contextMenu = $controls.getControl($("ul.contextmenu"), "Tridion.Controls.ContextMenu");
    $evt.addEventHandler($("body"), "contextmenu", function (event) {
        controls.contextMenu.show(event);
    });
    $evt.addEventHandler(controls.contextMenu, "click", this.getDelegate(this.onMenuItemClick));
};

Alchemy.Plugins.Big_Box_Of_Samples.Views.BigBoxSamplePopup.prototype.onMenuItemClick = function (event) {
    var commandName = event.data.command;

    if ($cme.containsCommand(commandName))
	{
		$log.debug("Executing command \"{0}\"", commandName);
		$cme.executeCommand(commandName);
	}
	else
	{
		$log.debug("Command \"{0}\" is not registered", commandName);
	}
};

$display.registerView(Alchemy.Plugins.Big_Box_Of_Samples.Views.BigBoxSamplePopup); 