<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="HuongDan.aspx.cs" Inherits="WebPage_F4.XacNhanDangKy" %>

<asp:Content ID="MyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<link href="CSS/styleSheet.css" rel="Stylesheet" type="text/css" />
<div id="menu">
	<div id="mainmenu">
    	<ul>
        	<li><a href="Default.aspx">Trang Chủ</a></li>
			<li><a href="KiemViec.aspx">Kiếm Việc</a></li>
	        <li><a href="MyTimViec.aspx">My Tìm Việc</a></li>
	        <li><a href="TaoHoSo.aspx">Tạo Hồ Sơ</a></li>
	        <li><a href="TaoThongBaoViec.aspx">Tạo Thông Báo Việc</a></li>
    		<li><a href="CamNangNghe.aspx">Cẩm Nang Nghề</a></li>
        </ul>
    </div>
</div><!-- Menu --->
<br />
<br />
<div id = "HuongDan" style="text-align:center">
    <img src="./images/hdTaoTaiKhoan.jpg"/><br />
    <br />
    <br />
    <img src="./images/hdTaoHoSo.jpg"/>
</div>
<div id = "KhoangTrang">
</div>
</asp:Content>

