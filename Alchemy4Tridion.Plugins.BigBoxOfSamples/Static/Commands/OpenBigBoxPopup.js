Alchemy.command("Big_Box_Of_Samples", "OpenBigBoxPopup", {
    execute: function () {
        var url = "${ViewsUrl}PopupSample.aspx",
            popup = $popup.create(url, "menubar=no,location=no,resizable=no,scrollbars=no,status=no,width=405,height=180", null);

        popup.open();
    }
});