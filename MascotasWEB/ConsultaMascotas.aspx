<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaMascotas.aspx.cs" Inherits="MascotasWEB.ConsultaMascotas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblRaza" runat="server" Text="Ingrese la raza a consultar"></asp:Label>
            <asp:TextBox ID="txtRaza" runat="server"></asp:TextBox>
            <asp:Button ID="btnRaza" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
        </div>
        <br />
        <div>
            <asp:GridView ID="gvRazas" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                <Columns>
                    <asp:BoundField DataField="idRaza" HeaderText="id Raza" />
                    <asp:BoundField DataField="NombreRaza" HeaderText="Nombre Raza" />
                    <asp:BoundField DataField="Especie.NombreEspecie" HeaderText="Especie" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
