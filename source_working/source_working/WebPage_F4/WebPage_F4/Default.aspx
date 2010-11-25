<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebPage_F4._Default" %>

<%@ Register src="UserControl/uc_Feed.ascx" tagname="uc_Feed" tagprefix="uc1" %>

<asp:Content ID="MyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<link href="CSS/styleSheet.css" rel="Stylesheet" type="text/css" />
<div id="menu">
	<div id="mainmenu">
    	<ul>
        	<li><a href="Default.aspx" class="current">Trang Chủ</a></li>
			<li><a href="KiemViec.aspx">Kiếm Việc</a></li>
	        <li><a href="MyTimViec.aspx">My Tìm Việc</a></li>
	        <li><a href="TaoHoSo.aspx">Tạo Hồ Sơ</a></li>
	        <li><a href="TạoThongBaoViec.aspx">Tạo Thông Báo Việc</a></li>
    		<li><a href="CamNangNghe.aspx">Cẩm Nang Nghề</a></li>
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
            <a href="DangKi/DangKi.aspx"title="Đăng Kí"></a>
        </div>
        <div id="dangnhapButton">
            <a href="DangNhap/DangNhap.aspx"title="Đăng Nhập"></a>
        </div>
    </div>
</div><!-- banner -->
        
<div id="maincontent">
	<div id="backgroundmaincontent">     
    	<div id="leftSideBar">
        	
        </div>
        <div id="middleContent">
        
        </div>
    	<div id="rightSideBar">
          <p>
        	Kiểm tra máy tính xách tay của ông Vũ, lực 					lượng chức năng phát hiện nhiều tài liệu 		 					"có nội dung tuyên truyền, xuyên tạc phỉ 	 					báng chính quyền nhân dân, tuyên truyền luận điệu chiến tranh tâm lý, đòi lật đổ chế độ, thực hiện đa nguyên, đa đảng..."

Theo lời trung tướng Hoàng Kông Tư, (Thủ trưởng Cơ quan An ninh điều tra, Bộ Công an), ông Vũ đã làm ra tài liệu, đưa thông tin thất thiệt, bịa đặt, xuyên tạc sự lãnh đạo và quản lý của nhà nước, chính phủ; vu khống, xúc phạm danh dự lãnh đạo nhà nước, chính quyền...
          </p>
        </div> 
        <div id="tieudiembar">
        	<img src="images/tieudiem.jpg" width="611" height="71"  alt="can't display"/>
    	</div>
        <div id="tieudiem">
        	<div id="tieudiemFirst">
            	<img class="tieudiemPicture" src="images/timviecnhanhlogo.jpg" width="289" height="85" alt="can't display"/>
            	<h1 class="tieudiemTitle">
                	TimViecNhanh.com</h1>
            	<p class="tieudiemParagraph">
            	    <uc1:uc_Feed ID="uc_Feed1" runat="server" />
                </p>
            </div>
            <div id="tieudiemSecond">
            	<img class="tieudiemPicture" src="images/chonvieclogo.jpg" width="289" height="85" alt="can't display"/>
                <h1 class="tieudiemTitle">
                	ChonViec.com</h1>
                <p class="tieudiemParagraph">
                    <uc1:uc_Feed ID="uc_Feed2" runat="server" />
                </p>
            </div>
            <div id="tieudiemThird">
            	<img class="tieudiemPicture" src="images/kiemvieclogo.jpg" width="289" height="85" alt="can't display"/>
            	<h1 class="tieudiemTitle">
                	KiemViec.com</h1>
            	<p class="tieudiemParagraph">
                	<uc1:uc_Feed ID="uc_Feed3" runat="server" />
                </p>
            </div>
        </div><!--- news , tin tuc -->
        
    </div><!-- right banner -->
</div><!-- content's herer -->
</asp:Content>