<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mascotas.aspx.cs" Inherits="MascotasWEB.Mascotas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p></p>
            <asp:Label ID="Label1" runat="server" Text="Buscar"></asp:Label>            
            <asp:TextBox ID="tbBuscar" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="Buscar" OnClick="Button2_Click" />
            <p></p>
            <asp:GridView ID="gvMascotas" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
                <Columns>
                    <asp:BoundField DataField="IdentCliente" HeaderText="id Cliente" />
                    <asp:BoundField DataField="NombreCliente" HeaderText="Nombre Cliente" />
                    <asp:BoundField DataField="Nombre" HeaderText="Mascota" />
                    <asp:BoundField DataField="NombreRaza" HeaderText="Raza" />
                    <asp:BoundField DataField="Especie.NombreEspecie" HeaderText="Especie" />
                    <asp:ButtonField Text="Borrar" />
                    <asp:ButtonField Text="Actualizar" />
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
        <div>
            <asp:Label ID="Label2" runat="server" Text="Id Cliente"></asp:Label>
            <input id="txtIdCliente" type="text" />
            <asp:Label ID="Label3" runat="server" Text="Nombre Cliente"></asp:Label>
            <input id="txtNombreCliente" type="text" />
            <asp:Label ID="Label4" runat="server" Text="Mascota"></asp:Label>
            <input id="txtMascota" type="text" />
            <asp:Label ID="Label5" runat="server" Text="Raza"></asp:Label>
            <input id="txtRaza" type="text" />
            <asp:Label ID="Label6" runat="server" Text="Especie"></asp:Label>
            <input id="txtEspecie" type="text" />
            <asp:Button ID="Button1" runat="server" Text="Crear" />
        </div>
    </form>
</body>
</html>
