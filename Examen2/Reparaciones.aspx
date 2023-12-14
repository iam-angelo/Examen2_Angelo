﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="Reparaciones.aspx.cs" Inherits="Examen2.Reparaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="container">
    <h1 class="text-center">Catalogo de Reparaciones</h1>
    <div class="container">
        <div class="col--12 p-4">
            <asp:GridView runat="server" ID="dgReparaciones" PageSize="10" HorizontalAlign="Center"
                CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header"
                RowStyle-CssClass="rows" AllowPaging="True"    />
        </div>
        <div class="row">
            <div class="col-3 p-2 d-inline-block">
                <label for="id" class="form-label ">Codigo Reparacion:</label>
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control" />
            </div>
            <div class="col-3 p-2 d-inline-block">
                <label for="ddUsuario" class="form-label">Equipo:</label>
                    <asp:DropDownList runat="server" ID="ddEquipo" CssClass="form-select" />
                </div>
            <div class="col-3 p-2 d-inline-block">
                <label for="txModelo" class="form-label ">Fecha de Solicitud:</label>
                <asp:TextBox runat="server" type="date" ID="txtFecha" CssClass="form-control" />
            </div>
            <div class="col-3 p-2 d-inline-block">
                <label for="txModelo" class="form-label ">Estado:</label>
                <asp:TextBox runat="server" ID="txtEstado" CssClass="form-control" />
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
