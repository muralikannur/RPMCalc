<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RPNForm.aspx.cs" Inherits="WwbForm.RPNForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:TextBox ID="inputRPN" runat="server" />
            <input type="submit" value ="Calculate" />
            <asp:TextBox ID="outputRPN" runat="server" />


        </div>
    </form>
</body>
</html>
