Alchemy.command("Big_Box_Of_Samples", "OpenBigBoxSimplePopup", {
    execute: function () {
        var url = "${ViewsUrl}SimplePopupSample.aspx",
            popup = $popup.create(url, "menubar=no,location=no,width=405,height=180", null);

        popup.open();
    }
});