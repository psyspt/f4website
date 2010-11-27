<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_ThongBao.ascx.cs" Inherits="WebPage_F4.UserControl.uc_ThongBao" %>
<link href="../CSS/dangkiStyleSheet.css" rel="Stylesheet" type="text/css" />
<div id = "thongbao">
    
    <asp:Label ID="Label1" runat="server" 
        Text="Chúc mừng bạn đã đăng ký thành công vào website của chúng tôi"></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" 
        Text="Xin hãy kiểm tra mail để xác nhận đăng ký"></asp:Label>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Click vào "></asp:Label>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">đây </asp:HyperLink>
    <asp:Label ID="Label4" runat="server" Text="để trở về trang chủ"></asp:Label>
    
</div>