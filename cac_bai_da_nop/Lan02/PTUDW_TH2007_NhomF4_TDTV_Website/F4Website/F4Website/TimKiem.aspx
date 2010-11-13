<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile ="~/F4.Master" CodeBehind="TimKiem.aspx.cs" Inherits="F4Website.Tim_Kiem.TimKiem" %>

<%@ Register src="UserControl/SubBody.ascx" tagname="SubBody" tagprefix="uc1" %>

<asp:Content ID="TimKiemContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <uc1:SubBody ID="SubBody1" runat="server" />
    
</asp:Content>
