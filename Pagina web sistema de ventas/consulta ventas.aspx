<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="consulta ventas.aspx.cs" Inherits="Pagina_web_sistema_de_ventas.consulta_ventas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <p class="text-center">
        LISTADO DE VENTAS</p>
    <p>
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" BackColor="#33CCFF">
            <Columns>
                <asp:BoundField DataField="Id_Cliente" HeaderText="Id_Cliente" SortExpression="Id_Cliente" />
                <asp:BoundField DataField="Id_Usuario" HeaderText="Id_Usuario" SortExpression="Id_Usuario" />
                <asp:BoundField DataField="Id_Producto" HeaderText="Id_Producto" SortExpression="Id_Producto" />
                <asp:BoundField DataField="Fecha_de_Venta" HeaderText="Fecha_de_Venta" SortExpression="Fecha_de_Venta" />
                <asp:BoundField DataField="Hora_Venta" HeaderText="Hora_Venta" SortExpression="Hora_Venta" />
                <asp:BoundField DataField="Total_Venta" HeaderText="Total_Venta" SortExpression="Total_Venta" />
                <asp:BoundField DataField="Efectivo" HeaderText="Efectivo" SortExpression="Efectivo" />
                <asp:BoundField DataField="Vuelto" HeaderText="Vuelto" SortExpression="Vuelto" />
                <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Sistema de ventasConnectionString %>" SelectCommand="SELECT [Id_Cliente], [Id_Usuario], [Id_Producto], [Fecha_de_Venta], [Hora_Venta], [Total_Venta], [Efectivo], [Vuelto], [Cantidad] FROM [Ventas]"></asp:SqlDataSource>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Codigo_Producto" DataSourceID="SqlDataSource2" BackColor="#33CCFF">
            <Columns>
                <asp:BoundField DataField="Codigo_Producto" HeaderText="Codigo_Producto" ReadOnly="True" SortExpression="Codigo_Producto" />
                <asp:BoundField DataField="Nombre_del_Producto" HeaderText="Nombre_del_Producto" SortExpression="Nombre_del_Producto" />
                <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" SortExpression="Cantidad" />
                <asp:BoundField DataField="Valor_Unitario" HeaderText="Valor_Unitario" SortExpression="Valor_Unitario" />
                <asp:BoundField DataField="Valor_Total" HeaderText="Valor_Total" SortExpression="Valor_Total" />
                <asp:BoundField DataField="Codigo_de_Barra" HeaderText="Codigo_de_Barra" SortExpression="Codigo_de_Barra" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Sistema de ventasConnectionString %>" SelectCommand="SELECT [Codigo_Producto], [Nombre_del_Producto], [Cantidad], [Valor_Unitario], [Valor_Total], [Codigo_de_Barra] FROM [Productos]"></asp:SqlDataSource>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
