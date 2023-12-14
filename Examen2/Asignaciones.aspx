﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="Asignaciones.aspx.cs" Inherits="Examen2.Asignaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="container">
     <h1 class="text-center">Catalogo de Asignaciones</h1>
     <div class="container">
         <div class="col--12 p-4">
             <asp:GridView runat="server" ID="dgAsignaciones" PageSize="10" HorizontalAlign="Center"
                 CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header"
                 RowStyle-CssClass="rows" AllowPaging="True"    />
         </div>
         <div class="row">
             <div class="col-3 p-2 d-inline-block">
                 <label for="id" class="form-label ">Codigo Asignacion:</label>
                 <asp:TextBox runat="server" ID="txtId" CssClass="form-control" />
             </div>
             <div class="col-3 p-2 d-inline-block">
                 <label for="ddUsuario" class="form-label">Reparacion:</label>
                 <asp:DropDownList runat="server" ID="ddRepracion" CssClass="form-select" />
             </div>
             <div class="col-3 p-2 d-inline-block">
                 <label for="ddUsuario" class="form-label">Tecnico:</label>
                 <asp:DropDownList runat="server" ID="ddTecnico" CssClass="form-select" />
             </div>
             <div class="col-3 p-2 d-inline-block">
                 <label for="txModelo" class="form-label ">Fecha de Asignacion:</label>
                 <asp:TextBox runat="server" type="date" ID="txtFecha" CssClass="form-control" />
             </div>
         </div>
         <div class="row">
             <div class="btn-group mr-2" role="group" aria-label="Actions group">
                 <asp:Button runat="server" ID="BtnAgregar" CssClass="btn btn-dark" Text="Agregar" OnClick="btnAgregar_Click"/>
                 <asp:Button runat="server" ID="BtnModificar" CssClass="btn btn-dark" Text="Modificar" OnClick="BtnModificar_Click"/>
                 <asp:Button runat="server" ID="BtnBorrar" CssClass="btn btn-dark" Text="Borrar" OnClick="btnBorrar_Click"/>
                 <asp:Button runat="server" IB="BtnConsultar" CssClass="btn btn-dark" Text="Consultar"  OnClick="BtnConsultar_Click"/>
                 <asp:Button runat="server" IB="BtnReset" CssClass="btn btn-dark" Text="Default"  OnClick="BtnReset_Click"/>
             </div>
         </div>

     </div>
 </section>
</asp:Content>
