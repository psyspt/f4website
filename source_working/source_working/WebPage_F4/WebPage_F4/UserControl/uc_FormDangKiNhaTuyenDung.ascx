<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_FormDangKiNhaTuyenDung.ascx.cs" Inherits="WebPage_F4.UserControl.uc_FormDangKiNhaTuyenDung" %>
<style type="text/css">
    #thongTinDangKi 
{
	float:left;
	height:1080px;
	width: 680px;
        margin-right: 0px;
    }

#title p{
	font-family:Arial, Helvetica, sans-serif;
	font-size:24px;
	color:#639;
	float:left;
	bottom: 0px;
        height: 22px;
        width: 210px;
    }

    #form7
    {
        height: 15px;
    }
    .style3
    {
        height: 38px;
    }
    .style4
    {
        height: 176px;
    }
    .style5
    {
        height: 37px;
    }
    .style6
    {
        height: 113px;
    }
    .style7
    {
        height: 232px;
    }
    .style8
    {
        height: 46px;
    }

    .style9
    {
        height: 31px;
    }

    .style10
    {
        height: 32px;
    }

</style>
<div id="thongTinDangKi">
<div id="title">
  	<p>
    	Thông Tin Đăng Kí
    </p>
  </div>
  <table width="680" height="475" border="0" cellpadding="1" cellspacing="1">
  <tr>
    <td width="192" align="right" valign="middle" class="style3"><label>Email : </label></td>
    <td width="481" align="left" valign="middle" class="style3" style="color: #FF0000">
        <asp:TextBox ID="username" runat="server" Width="212px"></asp:TextBox>
                (*)</td>
  </tr>
  <tr>
    <td align="right" valign="middle" class="style3">Mật khẩu : </td>
    <td align="left" valign="middle" class="style3" style="color: #FF0000">
        <asp:TextBox ID="password" runat="server" TextMode="Password" Width="212px"></asp:TextBox>
                (*)</td>
  </tr>
  <tr>
    <td align="right" valign="middle" class="style5">Nhập lại mật khẩu :</td>
    <td align="left" valign="middle" class="style5" style="color: #FF0000">
        <asp:TextBox ID="retypePassword" runat="server" TextMode="Password" 
            Width="212px"></asp:TextBox>
                (*)</td>
  </tr>
  <tr>
    <td align="right" valign="middle" class="style5">Tên công ty : </td>
    <td align="left" valign="middle" class="style5" style="color: #FF0000">
        <asp:TextBox ID="tenCongTy" runat="server" Width="212px"></asp:TextBox>
                (*)</td>
  </tr>
  <tr>
    <td align="right" valign="middle" class="style5">Địa chỉ : </td>
    <td align="left" valign="middle" class="style5" style="color: #FF0000">
        <asp:TextBox ID="diaChi" runat="server" Width="212px"></asp:TextBox>
                (*)</td>
  </tr>
  <tr>
    <td align="right" valign="middle" class="style4">Lĩnh vực ngành nghề : </td>
    <td align="left" valign="middle" class="style4">
        <asp:ListBox ID="nganhNghe" runat="server" Height="158px" Width="330px">
        </asp:ListBox>
      </td>
  </tr>
  <tr>
    <td align="right" valign="middle" class="style6">Mô tả sơ lược về công ty : </td>
    <td align="left" valign="middle" class="style6">
        <asp:TextBox ID="TextBox1" runat="server" Height="98px" TextMode="MultiLine" 
            Width="330px"></asp:TextBox>
      </td>
  </tr>
  <tr>
    <td align="right" valign="middle" class="style5">Website : </td>
    <td align="left" valign="middle" class="style5">
        <asp:TextBox ID="website" runat="server" Width="212px"></asp:TextBox>
      </td>
  </tr>
  <tr>
    <td align="right" valign="middle" class="style5">Email liên hệ : </td>
    <td align="left" valign="middle" class="style5" style="color: #FF0000">
        <asp:TextBox ID="emailLienHe" runat="server" Width="212px"></asp:TextBox>
        (*)</td>
  </tr>
  <tr>
    <td align="right" valign="middle" class="style7">Điều khoản sử dụng : </td>
    <td align="left" valign="middle" class="style7">
        <asp:TextBox ID="dieuKhoanSuDung" runat="server" Height="212px" 
            TextMode="MultiLine" Width="450px" ReadOnly="True" 
            style="margin-bottom: 0px"></asp:TextBox>
                </td>
  </tr>
  <tr>
    <td align="right" valign="middle" class="style9"> </td>
    <td align="left" valign="middle" class="style9">
        <asp:CheckBox ID="CheckBox1" runat="server" 
            Text="Tôi đồng ý với các điều khoản trên" />
                </td>
  </tr>
  <tr>
    <td align="right" valign="middle" class="style10"> Captchar :</td>
    <td align="left" valign="middle" class="style10">
        <asp:Image ID="Image1" runat="server" Width="60px" />
                </td>
  </tr>
  <tr>
    <td align="right" valign="middle" class="style10"> Xác nhận :</td>
    <td align="left" valign="middle" class="style10">
        <asp:TextBox ID="xacNhanCaptchar" runat="server" Width="212px"></asp:TextBox>
                </td>
  </tr>
  <tr>
    <td align="center" valign="middle" class="style8" colspan="2">
        <asp:Button ID="Button1" runat="server" Text="Đăng Kí" Width="114px" 
            onclick="Button1_Click" />
      </td>
  </tr>
</table>

</div>
