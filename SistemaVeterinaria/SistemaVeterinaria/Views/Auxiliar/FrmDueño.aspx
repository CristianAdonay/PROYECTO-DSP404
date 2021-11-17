<%@ Page Title="Registrar Dueño" Language="C#" MasterPageFile="~/Views/Plantilla.Master" AutoEventWireup="true" CodeBehind="FrmDueño.aspx.cs" Inherits="SistemaVeterinaria.Views.Auxiliar.FrmDueño" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <style type="text/css">
        .auto-style1 {
            width: 265px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" runat="server">
    <table align="center" style="width: 60%">
        <tr>
            <td colspan="2" align="center">REGISTRAR DUEÑO</td>
        </tr>
        <tr>
            <td>Nombre:</td>
            <td>
                <div>
                    <asp:TextBox ID="txtNombre" runat="server" required="required"></asp:TextBox>
                </div>
            </td>
        </tr>
        <tr>
            <td>DUI:</td>
            <td>
                <div>
                    <asp:TextBox ID="cbDUI" runat="server" required="required"></asp:TextBox>
                </div>
            </td>
        </tr>
        <tr>
            <td>Dirección:</td>
            <td>
                <div>
                    <asp:TextBox ID="txtDireccion" runat="server" required="required"></asp:TextBox>
                </div>
            </td>
        </tr>
        <tr>
            <td>Edad:</td>
            <td>
                <div>
                    <asp:TextBox ID="txtEdad" runat="server" required="required" Width="70px"></asp:TextBox>
                </div>
            </td>
        </tr>
        <tr>
            <td>Email:</td>
            <td>
                <div>
                    <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" required="required"></asp:TextBox>
                </div>
            </td>
        </tr>
        <tr>
            <td>Número de teléfono:</td>
            <td>
                <div>
                    <asp:TextBox ID="txtTelefono" runat="server" required="required"></asp:TextBox>
                </div>
            </td>
        </tr>
        <tr>
            <td>Fecha de Ingreso:</td>
            <td>
                <div>
                    <asp:TextBox ID="txtFechaingreso" runat="server" required="required"></asp:TextBox>
                </div>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <div>
                    <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" class="btn btn-success"></asp:Button>
                </div>
            </td>
        </tr>

    </table>
    <br />
    <% if (IsPostBack)
        {
     %>
        <div style="height:50px">
            <button type="button">&times;</button>
            <strong>
                <asp:Label ID="lblMensaje"  runat="server"></asp:Label>
            </strong>
        </div>
    <% } %>
</asp:Content>
