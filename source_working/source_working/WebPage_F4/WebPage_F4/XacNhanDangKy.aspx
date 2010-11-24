<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="DangKiTaiKhoanNguoiTimViec.aspx.cs" Inherits="WebPage_F4.DangKi.DangKiTaiKhoanNguoiTimViec" %>


<asp:Content ID="MyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<link href="./CSS/dangkiStyleSheet.css" rel="Stylesheet" type="text/css" />

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
                Xác nhận đăng ký
                </p>
            </div>
            <div id="logodangki">
            	<img src="./images/logoDangki.jpg" alt="LogoDangKy"/>
                <img src="./images/advertisement.jpg" alt="LogoDangKy"/>
            </div>
            <div id="line">            
            </div>
            <div id="xacnhandangky">
            

            
                <asp:Label ID="Label1" runat="server" Font-Names="Arial" 
                    Text="Chào mừng bạn đã trở thành thành viên của website tìm việc click vào "></asp:Label>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">đây </asp:HyperLink>
                <asp:Label ID="Label2" runat="server" 
                    Text="  để trở về trang chủ và bắt đầu tham gia hoạt động với website của chúng tôi." 
                    Font-Names="Arial"></asp:Label>
            
            </div>
            
        </div>
            <div id="rightcontent">
            </div>
        
    </div>
</asp:Content>