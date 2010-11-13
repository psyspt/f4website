<%@ Page Language="C#" MasterPageFile="~/F4.Master"  AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="F4Website.WebForm1" %>

<%@ Register src="UserControl/BodyHomePage.ascx" tagname="BodyHomePage" tagprefix="uc1" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" ID="Content1" runat ="server">
  
    <uc1:BodyHomePage ID="BodyHomePage1" runat="server" />
  
</asp:Content>
