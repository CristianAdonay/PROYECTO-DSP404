<%@ Page Title="Agregar Mascotas" EnableEventValidation="false" Language="C#" MasterPageFile="~/Views/Plantilla.Master" AutoEventWireup="true" CodeBehind="FrmAnimal.aspx.cs" Inherits="SistemaVeterinaria.Views.Auxiliar.FrmAnimal" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">

    <style type="text/css">
        .auto-style1 {
            width: 265px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido" runat="server">
    <asp:HiddenField ID="IDDueño" runat="server" />
    <table align="center" style="width: 70%">
        <h5>REGISTRAR MASCOTA</h5>
        <tr>
            <td>Nombre del dueño:</td>
            <td class="auto-style1">
                <div>
                    <asp:TextBox ID="txtIDDueño" runat="server" TextMode="Number" required="required"></asp:TextBox>
                </div>
            </td>
            <td rowspan="7">
                <output></output>
            </td>
        </tr>
        <tr>
            <td>Nombre del animal:</td>
            <td class="auto-style1">
                <div>
                    <asp:TextBox ID="txtNombre" runat="server" required="required"></asp:TextBox>
                </div>
            </td>
        </tr>
        <tr>
            <td>Tipo de animal:</td>
            <td class="auto-style1">
                <div>
                    <asp:TextBox ID="txtTipoAnimal" runat="server" required="required">
                    </asp:TextBox>
                </div>
            </td>
        </tr>
        <tr>
            <td>Raza del animal:</td>
            <td class="auto-style1">
                <div>
                    <asp:TextBox ID="txtRazaAnimal" runat="server" required="required"></asp:TextBox>
                </div>
            </td>
        </tr>
        <tr>
            <td>Edad del animal:</td>
            <td class="auto-style1">
                <div>
                    <asp:TextBox ID="txtEdadAnimal" runat="server" required="required"></asp:TextBox>
                </div>
            </td>
        </tr>
    </table>
    <% if (IsPostBack)
        {
    %>
        <div style="height:50px">
           <button type="button" align="center" class="btn btn-success" data-dismiss="alert">Registrar</button>
        </div>
   <% } %>
</asp:Content>
