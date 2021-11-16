<%@ Page Title=" Registrar Personal" Lenguaje ="C#" MasterPageFile="~/Views/Plantilla.Master" AutoEventWireup="true" CodeBehind="FrmRegistrarPersonal.aspx.cs" Inherits="SistemaVeterinaria.Views.Auxiliar.FrmRegistrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <style type="text/css">
        .auto-style1 {
            width: 265px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" style="width: 54%; height: 288px;">
        <tr>
            <td colspan="2" style="text-align:center">REGISTRAR PERSONAL</td>
        </tr>
        <tr>
            <td>Nombre de Usuario:</td>
            <td>
                <div>
                    <asp:TextBox ID="txtNombreUsuario" runat="server"></asp:TextBox>
                </div>
            </td>
        </tr>
         <tr>
             <td>Nombre Completo:</td>
            <td>
                <div>
                    <asp:TextBox ID="txtIngreseNombreCompleto" runat="server"></asp:TextBox>
                </div>
            </td>
        </tr>
         <tr>
             <td>Contraseña:</td>
            <td>
                <div>
                    <asp:TextBox ID="txtIngreseContraseña" runat="server"></asp:TextBox>
                </div>
            </td>
        </tr>
         <tr>
            <td>Edad:</td>
            <td>
                <div>
                    <asp:TextBox ID="txtIngreseEdad" runat="server"></asp:TextBox>
                </div>
            </td>
        </tr>
         <tr>
               <td>Gmail:</td>
                 <td>
                <div>
                    <asp:TextBox ID="txtIngreseGmail" runat="server"></asp:TextBox>
                     </div>
                <tr>
                    <td>Fecha de Ingreso :</td>
                    <td>
                <div>
                    <asp:Calendar id="cbFecha" runat="server"></asp:Calendar>
                </div>
            </td>
        </tr>
            <td colspan="2" align="center">
                <asp:button id="btnRegistrar" class="btn btn-success" runat="server" text="Registrar Personal"></asp:button>
            </td>
        </tr>
    </table>           
</asp:Content>

