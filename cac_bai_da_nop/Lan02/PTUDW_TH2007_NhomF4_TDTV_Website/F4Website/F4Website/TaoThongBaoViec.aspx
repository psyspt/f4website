<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/F4.Master" CodeBehind="TaoThongBaoViec.aspx.cs" Inherits="F4Website.TaoThongBaoViec.TaoThongBaoViec" %>

<%@ Register src="UserControl/SubBody.ascx" tagname="SubBody" tagprefix="uc1" %>

<asp:Content ID="TaoThongBaoViecContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:SubBody ID="SubBody1" runat="server" />
</asp:Content>
