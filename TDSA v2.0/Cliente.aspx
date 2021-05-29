<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="TDSA_v2._0.Cliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cadastro de Clientes</title>
    <style type="text/css">
        .auto-style1 {
            width: 132px;
        }
        .auto-style2 {
            width: 20px;
        }
        .auto-style3 {
            width: 20px;
            text-align: center;
        }
        .auto-style4 {
            text-align: right;
        }
        .auto-style5 {
            text-align: left;
        }
        .auto-style6 {
            text-align: center;
        }
    </style>
</head>
<body>
    <h2 class="auto-style6">Cadastro de Clientes</h2>
    <form id="form1" runat="server">
        <table align="center">
            <tr>
                <td class="auto-style1">Id</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:TextBox ID="intID" runat="server"  Width="48px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Nome</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:TextBox ID="TextNome" runat="server" Width="227px"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td class="auto-style1">Data de Nascimento</td>
                <td class="auto-style3">:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextNasc" runat="server" type="date"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Status</td>
                <td class="auto-style3">:</td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="225px">
                        <asp:ListItem Selected="True">Ativo</asp:ListItem>
                        <asp:ListItem>Inativo</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Button ID="btnCadastrar" runat="server" OnClick="Cadastrar_Click" Text="Gravar" />
                    <asp:Button ID="Carregar" runat="server" OnClick="Carregar_Click" Text="Carregar" />
                    <asp:Button ID="Excluir" runat="server" OnClick="Excluir_Click" Text="Excluir" />
                </td>
            </tr>
        </table>
        <div class="auto-style6">
            <div>
            </div>
            <asp:GridView ID="gridClientes" runat="server" HorizontalAlign="Center" Width="306px" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Height="243px">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
