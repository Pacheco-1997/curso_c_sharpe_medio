<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfTabuada.aspx.cs" Inherits="waConhecendoOsComponentes.wfTabuada" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <h1>Tabuada</h1>
    <div>
    
        <asp:DropDownList ID="dlNumeros" runat="server" Width="80px">
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btExecutar" runat="server" Text="Executar" OnClick="btExecutar_Click" />
    
    </div>
        <asp:ListBox ID="lbDados" runat="server" Height="227px" Width="156px"></asp:ListBox>
    </form>
</body>
</html>
