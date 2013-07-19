<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApprovalForm2.aspx.cs" Inherits="HumbleUI.ApprovalForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <label title="lblRegion">Region</label>
            <asp:ListBox ID="lbRegion" runat="server" AutoPostBack="true" OnSelectedIndexChanged="lbRegion_SelectedIndexChanged" />
        </div>
        <div>
            <label title="lblCountry">Country(s):</label>
            <asp:ListBox ID="lbCountry" runat="server" SelectionMode="Multiple" AutoPostBack="true" OnSelectedIndexChanged="lbCountry_SelectedIndexChanged"/>
        </div>
        <div>
            <label title="lblProduct">Product(s):</label>
            <asp:ListBox ID="lbProduct" runat="server" />
        </div>
    </div>
    </form>
</body>
</html>
