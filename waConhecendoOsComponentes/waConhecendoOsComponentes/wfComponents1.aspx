<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfComponents1.aspx.cs" Inherits="waConhecendoOsComponentes.wfComponents1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 285px;
        }
        .auto-style2 {
            width: 331px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Site</td>
                <td class="auto-style2">Endereço</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:TextBox ID="txtSite" runat="server" Width="270px"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtEndereco" runat="server" Width="315px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:ListBox ID="lbEndereco" runat="server" Width="319px">
                    </asp:ListBox>
                </td>
                <td class="auto-style2">
                    Opções</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:DropDownList ID="dlSite" runat="server" Width="323px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btInserir" runat="server" Text="Inserir site" OnClick="btInserir_Click" />
                    <asp:Button ID="btSelecionar" runat="server" OnClick="btSelecionar_Click" Text="Selecionar Site" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
