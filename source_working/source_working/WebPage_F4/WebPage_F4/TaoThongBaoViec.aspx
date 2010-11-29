   <%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.Master" AutoEventWireup="true" CodeBehind="TaoThongBaoViec.aspx.cs" Inherits="WebPage_F4.TạoThongBaoViec" %>

<%@ Register src="UserControl/uc_TimKiem.ascx" tagname="uc_TimKiem" tagprefix="uc1" %>

<asp:Content ID="MyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
<link href="CSS/styleSheet.css" rel="Stylesheet" type="text/css" />
<div id="menu">
	<div id="mainmenu">
    	<ul>
        	<li><a href="Default.aspx">Trang Chủ</a></li>
			<li><a href="KiemViec.aspx">Kiếm Việc</a></li>
	        <li><a href="MyTimViec.aspx">My Tìm Việc</a></li>
	        <li><a href="TaoHoSo.aspx">Tạo Hồ Sơ</a></li>
	        <li><a href="TaoThongBaoViec.aspx" class="current">Tạo Thông Báo Việc</a></li>
    		<li><a href="CamNangNghe.aspx">Cẩm Nang Nghề</a></li>
        </ul>
    </div>
</div><!-- Menu --->
<div id="maincontentsubpage">
    	<div id="leftcontent">
        </div>
        <div id="contentinfo">
        	<p>
            Danh sách nghề nghiệp.
            </p>
        </div>
        <div id="sidebarcontent">
        	
            <uc1:uc_TimKiem ID="uc_TimKiem1" runat="server" />
        	
        </div>
        <div id="rightcontent">
        </div>
    </div>
</asp:Content>
