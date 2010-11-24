<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_FormDangKiNguoiTimViec.ascx.cs" Inherits="WebPage_F4.UserControl.uc_Register_Nguoi_Tim_Viec" %>
<link href="../CSS/styleSheet.css" rel="Stylesheet" type="text/css" />
 <link rel="stylesheet" type="text/css" href="../CSS/jquery-ui-1.8.6.custom.css" />
 <script type="text/javascript" src="../JavaScript/jquery-1.4.2.min.js"> </script>
 <script type="text/javascript" src="../JavaScript/jquery-ui-1.8.6.custom.min.js"> </script>

	<script>
	    $(function() {
	        $("#datepicker").datepicker({
	            showOn: "button",
	            buttonImage: "../Images/calendar.gif",
	            buttonImageOnly: true
	        });
	    });
	</script>
	
<div id= "Register" 
    style="height: 468px; width: 652px; margin-left: 0px; margin-right: 0px;">
    <div class="RegisterHeader"> Đăng ký tài khoản</div>
    
    <div class="spacer"> <span class="Registertieude">Nhập thông tin cá nhân </span></div>
    
    <div class="RegisterLabel"> Họ:</div>
    <div class="RegisterTextbox"> 
        <asp:TextBox ID="Ho" runat="server" Height="20px" Width="225px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="*Bạn phải nhập họ" ControlToValidate="Ho"></asp:RequiredFieldValidator>
    </div>
    
    <div class="RegisterLabel"> Tên:</div>
    <div class="RegisterTextbox"> 
        <asp:TextBox ID="Ten" runat="server" Height="20px" Width="225px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="Ten" ErrorMessage="*Bạn phải nhập tên"></asp:RequiredFieldValidator>
    </div>
    
    <div class="RegisterLabel"> Giới tính:</div>
    <div class="RegisterTextbox"> 
        <select id="gioitinh">
            <option value="Nam">Nam</option>
            <option value="Nu">Nu</option>
            <option value="Khac">Khac</option>
        </select>
    </div>
    
    <div class="RegisterLabel"> Địa chỉ:</div>
    <div class="RegisterTextbox"> 
        <asp:TextBox ID="DiaChi" runat="server" Height="20px" Width="225px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="DiaChi" ErrorMessage="*Bạn phải nhập địa chỉ"></asp:RequiredFieldValidator>
    </div>
    
    <div class="RegisterLabel"> Điện thoại:</div>
    <div class="RegisterTextbox"> 
        <asp:TextBox ID="DienThoai" runat="server" Height="20px" Width="225px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ControlToValidate="DienThoai" ErrorMessage="*Bạn phải nhập điện thoại"></asp:RequiredFieldValidator>
    </div>
    
    <div class="RegisterLabel"> Tỉnh/Thành Phố:</div>
    <div class="RegisterTextbox"> 
        
        <asp:DropDownList ID="ThanhPho" runat="server" Height="21px" Width="154px">
        </asp:DropDownList>
        
    </div>
    
    <div class="RegisterLabel"> Ngày sinh:</div>
    <div class="RegisterTextbox"> 
        <input type="text" id="datepicker" style="width: 225px; height: 25px"></div>
    
    <div class="spacer"> <span class="Registertieude">Nhập thông tin tài khoản</span></div>
    
    <div class="RegisterLabel"> Username:</div>
    <div class="RegisterTextbox"> 
        <asp:TextBox ID="Username" runat="server" Height="20px" Width="225px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
            ControlToValidate="Username" ErrorMessage="*Bạn phải nhập Username"></asp:RequiredFieldValidator>
    </div>
    
    <div class="RegisterLabel"> Password:</div>
    <div class="RegisterTextbox"> 
        <asp:TextBox ID="Password" runat="server" Height="20px" Width="225px" 
            TextMode="Password"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
            ControlToValidate="Password" ErrorMessage="*Password phải có 4-12 ký tự" 
            ValidationExpression="[^\s]{4,12}"></asp:RegularExpressionValidator>
    </div>
    
    <div class="RegisterLabel"> Nhập lại Password:</div>
    <div class="RegisterTextbox"> 
        <asp:TextBox ID="RePassword" runat="server" Height="20px" Width="225px" 
            TextMode="Password"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator2" runat="server" 
            ErrorMessage="*Password nhập lại sai" ControlToCompare="Password" 
            ControlToValidate="RePassword"></asp:CompareValidator>
    </div>
    
    <div class="RegisterLabel"> Nhập Email:</div>
    <div class="RegisterTextbox"> 
        <asp:TextBox ID="Email" runat="server" Height="20px" Width="225px"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ErrorMessage="*Nhập sai Email" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
            ControlToValidate="Email"></asp:RegularExpressionValidator>
    </div>
    
    <div class="RegisterLabel"> Nhập lại Email:</div>
    <div class="RegisterTextbox"> 
        <asp:TextBox ID="ReEmail" runat="server" Height="20px" Width="225px"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ControlToCompare="Email" ControlToValidate="ReEmail" 
            ErrorMessage="*Email xác nhận sai"></asp:CompareValidator>
    </div>
    <div class = "RegisterXacNhan"> 
        <div class="RegisterLabel"> Xác minh từ:</div>
        <div class="RegisterTextbox">Nhập lại các từ bạn thấy trong bức hình dưới đây: </div>
        <div class="captchar">
            <asp:Image ID="captchaImage" runat="server" />
            <asp:ImageButton ID="ImageButton1" runat="server" Height="16px" 
                ImageUrl="~/images/Refresh-icon.png" Width="16px" 
                onclick="ImageButton1_Click" />
        </div>
        <div class = "captchaTextbox"><asp:TextBox ID="CaptchaText" runat="server" Height="20px" Width="100px"/> 
        </div>
    </div>
    
    <div class="registerbutton"> 
        <asp:Button ID="DongY" runat="server" Text="Đăng ký" onclick="Button1_Click"/>
    </div>
    <div class="RegisterTextbox"> 
    
        <asp:Label ID="LbLoi" runat="server" Font-Names="Times New Roman" 
            ForeColor="Red"></asp:Label>
    
    </div>
</div>
