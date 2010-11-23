<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="WebPage_F4.DangNhap.DangNhap" %>


<asp:Content ID="MyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<link href="../CSS/dangnhapStyleSheet.css" rel="Stylesheet" type="text/css" />

<div id="menu">
	<div id="mainmenu">
    	<ul>
        	<li><a href="../Default.aspx" class="current">Trang Chủ</a></li>
			<li><a href="../KiemViec.aspx">Kiếm Việc</a></li>
	        <li><a href="../MyTimViec.aspx">My Tìm Việc</a></li>
	        <li><a href="../TaoHoSo.aspx">Tạo Hồ Sơ</a></li>
	        <li><a href="../TạoThongBaoViec.aspx">Tạo Thông Báo Việc</a></li>
    		<li><a href="../CamNangNghe.aspx">Cẩm Nang Nghề</a></li>
        </ul>
    </div>
</div><!-- Menu --->

<div id="banner">
	<div id="bannercontent">
		<p> Bí Quyết Thành Công </p>
        <p> Và Thăng Tiến </p>
    </div>
    <div id="textboxLogin">
    	<!-- <input id="username" class="inputBox inputBoxWith1 inputBoxMarginLeft1" value="user name" name="username" type="text" />
        <input id="password" class="inputBox inputBoxWith2 inputBoxMarginLeft2" value="password" type="password" /> --->
        <div id="dangkiButton">
            <a href="#" title="Đăng Kí"></a>
        </div>
        <div id="dangnhapButton">
            <a href="#" title="Đăng Nhập"></a>
        </div>
    </div>
</div><!-- banner -->

<div id="maincontent">
	
</div><!-- content's herer -->

</asp:Content>


