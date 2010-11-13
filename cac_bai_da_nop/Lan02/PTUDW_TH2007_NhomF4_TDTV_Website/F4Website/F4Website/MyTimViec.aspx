<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile ="~/F4.Master" CodeBehind="MyTimViec.aspx.cs" Inherits="F4Website.MyTimViec.MyTimViec" %>

<%@ Register src="UserControl/SubBody.ascx" tagname="SubBody" tagprefix="uc1" %>

<asp:Content ID="TimKiem" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <uc1:SubBody ID="SubBody1" runat="server" />
    
</asp:Content>
