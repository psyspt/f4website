<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/F4.Master" CodeBehind="CamNangNghe.aspx.cs" Inherits="F4Website.CamNangNghe.CamNangNghe" %>

<%@ Register src="UserControl/SubBody.ascx" tagname="SubBody" tagprefix="uc1" %>

<asp:Content ID="CamNangNgheContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:SubBody ID="SubBody1" runat="server" />
</asp:Content>
