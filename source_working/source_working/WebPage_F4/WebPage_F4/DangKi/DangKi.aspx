<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="DangKi.aspx.cs" Inherits="WebPage_F4.DangKi.DangKi" %>

<asp:Content ID="MyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<link href="../CSS/dangkiStyleSheet.css" rel="Stylesheet" type="text/css" />

<div id="menu">
	<div id="mainmenu">
    	<ul>
        	<li><a href="../Default.aspx" class="current">Trang Chủ</a></li>
			<li><a href="../KiemViec.aspx">Kiếm Việc</a></li>
	        <li><a href="../MyTimViec.aspx">My Tìm Việc</a></li>
	        <li><a href="../TaoHoSo.aspx">Tạo Hồ Sơ</a></li>
	        <li><a href="../TaoThongBaoViec.aspx">Tạo Thông Báo Việc</a></li>
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
            <a href="DangKi.aspx" title="Đăng Kí"></a>
        </div>
        <div id="dangnhapButton">
            <a href="../DangNhap/DangNhap.aspx" title="Đăng Nhập"></a>
        </div>
    </div>
</div><!-- banner -->
<div id="maincontent">
	<div id="leftcontent">
        </div>
        <div id="contentinfo">
        	<div id="title">
            	<p>
                Đăng kí
                </p>
            </div>
            
            <div id="contentDangKi">
                <div id="dangkiNguoiTimViec">
                    <p class="dangkiparagraph">
                        Người Tìm Việc
                    </p>
                    <div id="buttonNguoiTimViec">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/DangKi/DangKiTaiKhoanNguoiTimViec.aspx"><asp:Button ID="Button1" runat="server" Text="Đăng Kí" Height="28px" 
                            Width="96px" /></asp:HyperLink>
                    </div>
                </div>
                <div id="dangkiNhaTuyenDung">
                    <p class="dangkiparagraph">
                        Nhà Tuyển Dụng
                    </p>
                    <div id="buttonNhaTuyenDung">
                        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/DangKi/DangKiTaiKhoanNhaTuyenDung.aspx"><asp:Button ID="Button2" runat="server" Text="Đăng Kí"  Height="28px" 
                            Width="96px" /></asp:HyperLink>
                    </div>
                </div>
            </div>
            
        </div>
            <div id="rightcontent">
            </div>
</div><!-- content's herer -->

</asp:Content>


