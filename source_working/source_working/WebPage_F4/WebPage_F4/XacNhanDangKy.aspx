<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="XacNhanDangKy.aspx.cs" Inherits="WebPage_F4.XacNhanDangKy" %>

<asp:Content ID="MyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<link href="CSS/styleSheet.css" rel="Stylesheet" type="text/css" />
<div id="menu">
	<div id="mainmenu">
    	<ul>
        	<li><a href="Default.aspx">Trang Chủ</a></li>
			<li><a href="KiemViec.aspx">Kiếm Việc</a></li>
	        <li><a href="MyTimViec.aspx">My Tìm Việc</a></li>
	        <li><a href="TaoHoSo.aspx">Tạo Hồ Sơ</a></li>
	        <li><a href="TạoThongBaoViec.aspx" class="current">Tạo Thông Báo Việc</a></li>
    		<li><a href="CamNangNghe.aspx">Cẩm Nang Nghề</a></li>
        </ul>
    </div>
</div><!-- Menu --->
<div id = "KhoangTrang">
</div>
<div id = "XacNhanDangKy">
    
    <asp:Label ID="Label1" runat="server" 
        Text="Chúc mừng bạn đã kích hoạt tài khoản thành công vào website của chúng tôi. "></asp:Label>
    <asp:Label ID="Label2" runat="server" 
        Text=" Bạn đã có thể bắt đầu tham gia vào các hoạt động của website bằng cách click vào ."></asp:Label>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Đây </asp:HyperLink>
    <asp:Label ID="Label3" runat="server" Text="để trở về trang chủ."></asp:Label>
    
</div>
</asp:Content>
