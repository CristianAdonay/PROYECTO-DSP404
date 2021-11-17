<%@ Page Title="Registrar Cita" Language="C#" MasterPageFile="~/Views/Plantilla.Master" AutoEventWireup="true" CodeBehind="FrmCita.aspx.cs" Inherits="SistemaVeterinaria.Views.Auxiliar.FrmCita" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <style type="text/css">
        .auto-style1 {
            width: 265px;
        }
    </style>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="contenido" runat="server">

    <table align="center" style="width: 50%">
        <tr>
            <td colspan="2" style="text-align:center">REGISTRAR CITA</td>
        </tr>
        <tr>
            <td>Nombre del animal:</td>
            <td>
                <div>
                    <asp:TextBox ID="txtNombreAnimal" runat="server"></asp:TextBox>
                </div>
            </td>
        </tr>
         <tr>
            <td>Tipo de animal:</td>
            <td>
                <div>
                    <asp:TextBox ID="txtTipoAnimal" runat="server"></asp:TextBox>
                </div>
            </td>
        </tr>
         <tr>
            <td>Raza del animal:</td>
            <td>
                <div>
                    <asp:TextBox ID="txtRazaAnimal" runat="server"></asp:TextBox>
                </div>
            </td>
        </tr>
         <tr>
            <td>Fecha:</td>
            <td>
                <div>
                    <asp:TextBox ID="txtFecha" runat="server" required="required" OnTextChanged="txtFecha_TextChanged" AutoPostBack="True"></asp:TextBox>
                </div>
            </td>
        </tr>
         <tr>
            <td>Hora:</td>
            <td>
                <div>
                    <asp:dropdownList id="cbHora" runat="server">
                    <asp:ListItem>07:00</asp:ListItem>
                    <asp:ListItem>07:30</asp:ListItem>
                    <asp:ListItem>08:00</asp:ListItem>
                    <asp:ListItem>08:30</asp:ListItem>
                    <asp:ListItem>09:00</asp:ListItem>
                    <asp:ListItem>09:30</asp:ListItem>
                    <asp:ListItem>10:00</asp:ListItem>
                    <asp:ListItem>10:30</asp:ListItem>
                    <asp:ListItem>11:00</asp:ListItem>
                    <asp:ListItem>11:30</asp:ListItem>
                    <asp:ListItem>12:00</asp:ListItem>
                    <asp:ListItem>13:00</asp:ListItem>
                    <asp:ListItem>13:30</asp:ListItem>
                    <asp:ListItem>14:00</asp:ListItem>
                    <asp:ListItem>14:30</asp:ListItem>
                    <asp:ListItem>15:00</asp:ListItem>
                    <asp:ListItem>15:30</asp:ListItem>
                    <asp:ListItem>16:00</asp:ListItem>
                    <asp:ListItem>16:30</asp:ListItem>
                    <asp:ListItem>17:00</asp:ListItem>
                    <asp:ListItem>17:30</asp:ListItem>
                    <asp:ListItem>18:00</asp:ListItem>
                    <asp:ListItem>18:30</asp:ListItem>
                    <asp:ListItem>19:00</asp:ListItem>
                    <asp:ListItem>19:30</asp:ListItem>
                </asp:dropdownList>
                </div>
            </td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:button id="btnRegistrar" class="btn btn-success" runat="server" text="Registrar Cita"></asp:button>
            </td>
        </tr>
    </table>
    <% if (IsPostBack)
        {
     %>
        <div style="height:50px">
            <button type="button" class="btn btn-success"></button>
            <strong>
                <asp:Label ID="lblMensaje"  runat="server"></asp:Label>
            </strong>
        </div>
    <% } %>
</asp:Content>
