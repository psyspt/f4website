<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_TimKiem.ascx.cs" Inherits="WebPage_F4.UserControl.uc_TimKiem" %>
<link href="../CSS/timKiem.css" rel="Stylesheet" type="text/css" />
<style type="text/css">
    .style1
    {
        width: 91%;
        height: 453px;
    }
    .style2
    {
        height: 38px;
    }
    .style3
    {
        height: 31px;
    }
    .style4
    {
        height: 30px;
    }
    .style7
    {
        height: 34px;
    }
    .style8
    {
        height: 36px;
    }
    .style9
    {
        height: 37px;
    }
    .style11
    {
        height: 33px;
    }
    .style12
    {
        height: 35px;
    }
</style>
<div id="mainframe">
    <div id="table">
        
        <table cellspacing="1" class="style1">
            <tr>
                <td class="style2" 
                    style="font-family: Arial, Helvetica, sans-serif; font-size: large; font-weight: normal; color: #FFFFFF">
                    Tìm Kiếm</td>
            </tr>
            <tr>
                <td class="style3" valign="bottom">
                    Từ khóa</td>
            </tr>
            <tr>
                <td class="style4" valign="bottom">
                    <asp:TextBox ID="txtTuKhoa" runat="server" Width="217px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style4" valign="bottom">
                    Lĩnh vực ngành nghề</td>
            </tr>
            <tr>
                <td class="style9" valign="bottom">
                    <asp:DropDownList ID="ddlNganhNghe" runat="server" Height="18px" Width="217px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style3" valign="bottom">
                    Tỉnh&nbsp;/Thành phố</td>
            </tr>
            <tr>
                <td class="style7" valign="bottom">
                    <asp:DropDownList ID="ddlTinhThanh" runat="server" Height="16px" Width="217px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style7" valign="bottom">
                    Trình độ</td>
            </tr>
            <tr>
                <td class="style8" valign="bottom">
                    <asp:DropDownList ID="ddlTrinhDo" runat="server" Height="16px" Width="217px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style7" valign="bottom">
                    Mức lương</td>
            </tr>
            <tr>
                <td class="style11" valign="bottom">
                    <asp:DropDownList ID="ddlMucLuong" runat="server" Width="217px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style12" valign="bottom">
                    Hình thức làm việc</td>
            </tr>
            <tr>
                <td class="style8" valign="bottom">
                    <asp:DropDownList ID="ddlHinhThucLamViec" runat="server" Width="217px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style8" valign="bottom">
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="center" class="style8" valign="middle">
                    <asp:Button ID="btTimKiem" runat="server" Text="Tìm Kiếm" Width="83px" />
                </td>
            </tr>
        </table>
        
    </div>
</div>