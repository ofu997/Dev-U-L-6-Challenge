<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DevUL6Challenge.aspx.cs" Inherits="DevUL6.DevUL6Challenge" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            font-family: Impact;
            color: #800000;
        }
        .newStyle2 {
        }
        h1 {
            font-family: Impact;
            color: #800000;
        }
        h1 {
        }
        .auto-style1 {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>
            <img alt="" class="auto-style1" src="epic-spies-logo.jpg" width="150px" /><br />
            Asset Performance Tracker</h1>
        <p>
            asset name&nbsp; <asp:TextBox ID="spiesTextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            elections rigged&nbsp;
            <asp:TextBox ID="spiesTextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            acts of subterfuge performed&nbsp;
            <asp:TextBox ID="spiesTextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="*!~ Add Asset ~!* " />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
