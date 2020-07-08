<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="indexGrid.aspx.cs" Inherits="Lab4.indexGrid" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <asp:GridView ID="GridFactura" runat="server" 
            AutoGenerateColumns="false"
            DataKeyNames="idFactura"
            BackColor="#DEBA84" 
            BorderColor="#DEBA84" 
            BorderStyle="None" 
            BorderWidth="1px" 
            CellPadding="3" 
            CellSpacing="2"
            OnRowDataBound="GridFactura_RowDataBound" 
            OnSelectedIndexChanged="GridFactura_SelectedIndexChanged">
            
            <Columns>
                <asp:BoundField DataField="idFactura" HeaderText="#Factura" />
                <asp:BoundField DataField="numLinea" HeaderText="Linea" />
                <asp:BoundField DataField="codProducto" HeaderText="Codigo Producto" />
                <asp:BoundField DataField="detProducto" HeaderText="Detalle Producto" />
                <asp:BoundField DataField="cantProducto" HeaderText="Cantidad" />
                <asp:BoundField DataField="costUnitario" HeaderText="Costo Unidad" />
                <asp:BoundField DataField="totalLinea" HeaderText="Total" />
            </Columns>

            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <br />
        <br />
        <table>
            <tr>
                <td>Id Factura</td>
                <td><asp:TextBox ID="txtidFactura" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Numero Factura</td>
                <td><asp:TextBox ID="txtnumLinea" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Codigo Producto</td>
                <td><asp:TextBox ID="txtcodProducto" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Detalle Producto</td>
                <td><asp:TextBox ID="txtdetProducto" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Cantidad</td>
                <td><asp:TextBox ID="txtcantProducto" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Costo Unidad</td>
                <td><asp:TextBox ID="txtcostUnitario" runat="server"></asp:TextBox></td>
            </tr>
              <tr>
                <td>Total</td>
                <td><asp:TextBox ID="txttotalLinea" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        </div>
       
    </form>
</body>
</html>
