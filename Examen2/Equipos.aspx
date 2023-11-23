﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Inicio.Master" AutoEventWireup="true" CodeBehind="Equipos.aspx.cs" Inherits="Examen2.Equipos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <section class="container">
    <h1 class="text-center">Equipos</h1>
    <div class="container">
        <div class="col--12 p-4">
            <asp:GridView runat="server" ID="dgEquipos" PageSize="10" HorizontalAlign="Center"
                CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header"
                RowStyle-CssClass="rows" AllowPaging="True"    />
        </div>
        <div class="row">
            <div class="col-3 p-2 d-inline-block">
                <label for="id" class="form-label ">CodigoEquipo:</label>
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control" />
            </div>
            <div class="col-3 p-2 d-inline-block">
                <label for="notxtTipoEquipombre" class="form-label ">Tipo Equipo:</label>
                <asp:TextBox runat="server" ID="txtTipoEquipo" CssClass="form-control" />
            </div>
            <div class="col-3 p-2 d-inline-block">
                <label for="txModelo" class="form-label ">Modelo:</label>
                <asp:TextBox runat="server" ID="txtModelo" CssClass="form-control" />
            </div>
            <div class="col-3 p-2 d-inline-block">
                <label for="ddUsuario" class="form-label">Usuario:</label>
                <asp:DropDownList runat="server" ID="ddUsuario" CssClass="form-select" />
            </div>
        </div>
        <div class="row">
            <div class="btn-group mr-2" role="group" aria-label="Actions group">
                <asp:Button runat="server" ID="BtnAgregar" CssClass="btn btn-dark" Text="Agregar" OnClick="BtnAdd_Click"/>
                <asp:Button runat="server" ID="BtnModificar" CssClass="btn btn-dark" Text="Modificar" OnClick="BtnMod_Click"/>
                <asp:Button runat="server" ID="BtnBorrar" CssClass="btn btn-dark" Text="Borrar" OnClick="BtnDel_Click"/>
                <asp:Button runat="server" IB="BtnConsultar" CssClass="btn btn-dark" Text="Consultar"  OnClick="BtnCheck_Click"/>
                <asp:Button runat="server" IB="BtnReset" CssClass="btn btn-dark" Text="Default"  OnClick="BtnDefault_Click"/>
            </div>
        </div>
        
    </div>
</section>
</asp:Content>
