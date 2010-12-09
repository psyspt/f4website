<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_MyTimViec_NTV.ascx.cs" Inherits="WebPage_F4.UserControl.uc_MyTimViec_NTV" %>

<%@ Register src="uc_ThongTinNTV.ascx" tagname="uc_ThongTinNTV" tagprefix="uc1" %>

<%@ Register src="uc_DanhSachCongViec.ascx" tagname="uc_DanhSachCongViec" tagprefix="uc2" %>

<html>
    <head>
     <link rel="stylesheet" type="text/css" href="../CSS/MyTimViec.css" />
     <script type="text/javascript" src="../JavaScript/tabs.js"> </script>
     <script type="text/javascript" src="../JavaScript/jquery-1.4.2.min.js"> </script>
     <script type="text/javascript">
         $(document).ready(function() {
         $(".menu > li").click(function(e) {
                 switch (e.target.id) {
                     case "About":
                         //change status & style menu
                         $("#About").addClass("active");
                         $("#Dshoso").removeClass("active");
                         $("#Dscongviec").removeClass("active");
                         $("#Dstinnhan").removeClass("active");
                         
                         //display selected division, hide others
                         $("div.About").fadeIn();
                         $("div.DSHoSo").css("display", "none");
                         $("div.DSCongViec").css("display", "none");
                         $("div.DSTinNhan").css("display", "none");
                         break;
                     case "Dshoso":
                         //change status & style menu
                         $("#About").removeClass("active");
                         $("#Dshoso").addClass("active");
                         $("#Dscongviec").removeClass("active");
                         $("#Dstinnhan").removeClass("active");
                         
                         //display selected division, hide others
                         $("div.DSHoSo").fadeIn();
                         $("div.About").css("display", "none");
                         $("div.DSCongViec").css("display", "none");
                         $("div.DSTinNhan").css("display", "none");
                         
                         break;
                     case "Dscongviec":
                         //change status & style menu
                         $("#About").removeClass("active");
                         $("#Dshoso").removeClass("active");
                         $("#Dscongviec").addClass("active");
                         $("#Dstinnhan").removeClass("active");
                         
                         //display selected division, hide others
                         $("div.DSCongViec").fadeIn();
                         $("div.About").css("display", "none");
                         $("div.DSHoSo").css("display", "none");
                         $("div.DSTinNhan").css("display", "none");
                         break;
                     case "Dstinnhan":
                         //change status & style menu
                         $("#About").removeClass("active");
                         $("#Dshoso").removeClass("active");
                         $("#Dscongviec").removeClass("active");
                         $("#Dstinnhan").addClass("active");
                            
                         //display selected division, hide others
                         $("div.DSTinNhan").fadeIn();
                         $("div.About").css("display", "none");
                         $("div.DSHoSo").css("display", "none");
                         $("div.DSCongViec").css("display", "none");
                         break;    
                 }
                 return false;
             });
         });
     </script> 
    </head>
    <body>
        <div class="spacer">
        </div>
        <div id = "containertieuDe">
            <div class="imageTD">
            
                <asp:Image ID="Image1" runat="server" Height="150px" 
                    ImageUrl="../images/no_avatar.gif" Width="150px" />
            
            </div>
            <div class = "TextTD">
            
                <asp:Label ID="Username" runat="server"></asp:Label>
            
            </div>
        </div>
        <div class="spacer">
        </div>
        <div>
            <div id = "container">        
		        <ul class="menu">
			        <li id="About" class="active">About me</li>
			        <li id="Dshoso">Hồ Sơ</li>
			        <li id="Dscongviec">Công Việc</li>
			        <li id="Dstinnhan">Tin Nhắn</li>
		        </ul>
		        
		        <div class="About">
			        <div>
        			
			          <uc1:uc_ThongTinNTV ID="uc_ThongTinNTV1" runat="server" />
        			  <div class ="Link">
                          <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Thay Đổi</asp:HyperLink>   
        			      
        			  </div>  
			        </div>
		        </div>
		        <div class="DSHoSo">
			        <div>
			            HOSO
			        </div>
        			
		        </div>
		        <div class="DSCongViec">
		        
		            <uc2:uc_DanhSachCongViec ID="uc_DanhSachCongViec1" runat="server" />
                    
		        </div>
		        <div class="DSTinNhan">
			        <div>
			           TinNhan 
			        </div>	
		        </div>
	        </div>	
        </div>
        
    </body>
</html>