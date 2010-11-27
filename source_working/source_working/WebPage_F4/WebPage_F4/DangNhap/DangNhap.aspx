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
            <a href="../DangKi/DangKi.aspx" title="Đăng Kí"></a>
        </div>
        <div id="dangnhapButton">
            <a href="DangNhap.aspx" title="Đăng Nhập"></a>
        </div>
    </div>
</div><!-- banner -->

<div id="maincontent">
	<div id="leftcontent">
	    
	</div>
	<div id="centercontent">
	    <div id="title">
	        <p>
	            Đăng Nhập
	        </p>
	    </div>
	    <div id="nguoiTimViec">
	        <div id="headerNguoiTimViec">
	            <p class="paragraph marginNTV">Người Tìm Việc</p>
	        </div>
	        <div id="imgNguoiTimViec">
	        </div>
	        <div id="inputNguoiTimViec">
	            
	            <table class="style1">
                    <tr>
                        <td align="right" class="style11">
                            Username :</td>
                        <td class="style8">
                            <asp:TextBox ID="userNguoiTimViec" runat="server" Height="20px" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style11">
                            Password :</td>
                        <td class="style8">
                            <asp:TextBox ID="passNguoiTimViec" runat="server" Height="20px" Width="200px" 
                                TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" class="style7" colspan="2">
                            <asp:Button ID="dangNhapNguoiTimViec" runat="server" Text="Đăng Nhập" 
                                Width="90px" onclick="dangNhapNguoiTimViec_Click" />
                        </td>
                    </tr>
                </table>
	            
	        </div>
	    </div>
	    <div id="nhaTuyenDung">
	        <div id="headerNhaTuyenDung">
	            <p class="paragraph marginNTD">Nhà Tuyển Dụng</p>
	        </div>
	        <div id="imgNhaTuyenDung">
	        </div>
	        <div id="inputNhaTuyenDung">
	            
	            <table class="style1">
                    <tr>
                        <td align="right" class="style9">
                            Email :</td>
                        <td class="style7">
                            <asp:TextBox ID="userNhaTuyenDung" runat="server" Height="20px" Width="200px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" class="style9">
                            Password :</td>
                        <td class="style7">
                            <asp:TextBox ID="passNhaTuyenDung" runat="server" Height="20px" Width="200px" 
                                TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" class="style7" colspan="2">
                            <asp:Button ID="dangNhapNhaTuyenDung" runat="server" Text="Đăng Nhập" 
                                Width="90px" onclick="dangNhapNhaTuyenDung_Click" />
                        </td>
                    </tr>
                </table>
	            
	        </div>
	    </div>
	</div>
	<div id="rightcontent">
	    
	</div>
</div><!-- content's herer -->

</asp:Content>


<asp:Content ID="Content1" runat="server" contentplaceholderid="head">

    <style type="text/css">
        .style7
        {
            height: 38px;
        }
        .style8
        {
            height: 38px;
        }
        .style9
        {
            width: 180px;
            height: 38px;
        }
        .style11
        {
            height: 38px;
            width: 160px;
        }
    </style>

</asp:Content>



