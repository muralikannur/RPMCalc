<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RPNForm.aspx.cs" Inherits="WwbForm.RPNForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label>Enter RPN string : </asp:Label>
            <asp:TextBox ID="inputRPN" runat="server" />

            <br /><br />
            <input type="submit" value ="Calculate" />
            <br /><br />
            <asp:Label>Result : </asp:Label>
            <asp:TextBox ID="outputRPN" runat="server" ReadOnly="true" />


        </div>
    </form>
</body>
</html>
