<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="DangKiTaiKhoanNguoiTimViec.aspx.cs" Inherits="WebPage_F4.DangKi.DangKiTaiKhoanNguoiTimViec" %>

<%@ Register src="../UserControl/uc_FormDangKiNhaTuyenDung.ascx" tagname="uc_FormDangKiNhaTuyenDung" tagprefix="uc1" %>

<%@ Register src="../UserControl/uc_FormDangKiNguoiTimViec.ascx" tagname="uc_FormDangKiNguoiTimViec" tagprefix="uc2" %>

<asp:Content ID="MyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<link href="../CSS/dangkiStyleSheet.css" rel="Stylesheet" type="text/css" />

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
<div id="maincontent">
    	<div id="leftcontent">
        </div>
        <div id="contentinfo">
        	<div id="title">
            	<p>
                Đăng kí
                </p>
            </div>
            <div id="logodangki">
            	<img src="../images/logoDangki.jpg" />
                <img src="../images/advertisement.jpg" />
            </div>
            <div id="line">            
            </div>
            <div id="thongtindangki">
            
                
            
                <uc2:uc_FormDangKiNguoiTimViec ID="uc_FormDangKiNguoiTimViec1" runat="server" />
            
                
            
            </div>
            
        </div>
            <div id="rightcontent">
            </div>
    </div>
</asp:Content>