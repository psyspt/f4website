<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebPage_F4._Default" %>

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
            <a href="DangKi/DangKiTaiKhoanNguoiTimViec.aspx" title="Đăng Kí"></a>
        </div>
        <div id="dangnhapButton">
            <a href="DangKi/DangKiTaiKhoanNguoiTimViec.aspx" title="Đăng Nhập"></a>
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
        	<img src="images/tieudiem.jpg" width="611" height="71"  />
    	</div>
        <div id="tieudiem">
        	<div id="tieudiemFirst">
            	<img class="tieudiemPicture" src="images/tieudiem_picture01.jpg" />
            	<h1 class="tieudiemTitle">
                	Lương cao .
                </h1>
            	<p class="tieudiemParagraph">
                	M.U đã xác định rõ ràng mục tiêu chiến thắng trong trận đấu với W 25 năm nắm quyền ở Old Trafford. Tỏ ra rất khó khăn khi họ cũng không có được trong tay những gương mặt <a href="#">đủ sức tạo ra </a> nhiều đột biến trong lối chơi tấn công.
                </p>
                <div class="chitietButton">
					<a href="#">Chi Tiết</a>
                </div>
            </div>
            <div id="tieudiemSecond">
            	<img class="tieudiemPicture" src="images/tieudiem_picture01.jpg" />
            	<h1 class="tieudiemTitle">
                	Tiền nhiều .
                </h1>
            	<p class="tieudiemParagraph">
                	Nắm quyền kiểm soát thế trận nhưng những cơ hội mà M.U tạo ra chưa đhi cú sút của tiền vệ người Hàn Quốc - Park Ji Sung tung cú svào lưới. Tỷ số được mở cho M.U ngay trước khi hiệp một khép lại.
                </p>
                <div class="chitietButton">
					<a href="#">Chi Tiết</a>
                </div>
            </div>
            <div id="tieudiemThird">
            	<img class="tieudiemPicture" src="images/tieudiem_picture01.jpg" />
            	<h1 class="tieudiemTitle">
                	Chức lơn1 .
                </h1>
            	<p class="tieudiemParagraph">
                	Những tưởng lợi thế dẫn bàn sẽ giúp M.U chơi thăng hoa hơn trongi đbanks-Blake nhận bóng khá thoải mái trong vòng cấm địa rồi dễ dàng đánh bại Van der Sar để san bằng tỷ số ở phút thứ 66.
                </p>
                <div class="chitietButton">
					<a href="#">Chi Tiết</a>
                </div>
            </div>
        </div><!--- news , tin tuc -->
        
    </div><!-- right banner -->
</div><!-- content's herer -->
</asp:Content>