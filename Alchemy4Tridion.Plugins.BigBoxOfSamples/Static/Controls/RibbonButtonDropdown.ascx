<%@ Control Language="C#" %>
<%@ Import Namespace="Tridion.Web.UI" %>

<!-- This is an example of a drop down ribbon toolbar button. You assign the filename of this control in the RibbonToolbar's
     Group property. -->
<c:RibbonButton runat="server" CommandName="OpenBigBoxPopup" IsDropdownButton="true" Title="Dropdown made with a .ascx control, unfortunately creates a new group. Maybe alchemy can remedy..." Label="Control Dropdown" ID="BigBoxRibbonButtonDropDownControl">
    <c:RibbonContextMenuItem runat="server" Command="OpenBigBoxPopup" Title="Opens the popup that includes a custom JS view" Label="Open Big Box Popup" />
    <c:RibbonContextMenuItem runat="server" Command="OpenBigBoxSimplePopup" Title="Opens the popup that contains no view" Label="Open Big Box Simple Popup" />
</c:RibbonButton>