<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_ThongTinNTV.ascx.cs" Inherits="WebPage_F4.UserControl.uc_ThongTinNTV" %>
<asp:DetailsView ID="DetailsNTV" runat="server" AutoGenerateRows="False" 
    BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" 
    CellPadding="4" GridLines="Vertical" Height="82px" Width="550px" 
    ForeColor="Black" 
    style="margin-left: 20px; padding-top:1px; margin-right: 20px; text-align: left; ">
    <FooterStyle BackColor="#CCCC99" />
    <RowStyle BackColor="#F7F7DE" />
    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
    <Fields>
        <asp:BoundField DataField="HoTen" HeaderText="Họ Tên" />
        <asp:BoundField DataField="UserName" HeaderText="UserName" />
        <asp:BoundField DataField="Password" HeaderText="Password" />
        <asp:BoundField DataField="Email" HeaderText="Email" />
        <asp:BoundField DataField="DiaChi" HeaderText="Địa Chỉ" />       
        <asp:BoundField DataField="NgaySinh" HeaderText="Ngày Sinh" />
        <asp:BoundField DataField="GioiTinh" HeaderText="Giới Tính" />
        <asp:BoundField DataField="DienThoai" HeaderText="Điện Thoại" />
        <asp:BoundField DataField="QuocGia" HeaderText="Quốc Gia" />
        <asp:BoundField DataField="NgonNgu" HeaderText="Ngôn Ngữ" />
        <asp:BoundField DataField="URLHinhAnh" HeaderText="URLHinhAnh" />
        <asp:BoundField DataField="TrangThai" HeaderText="Trạng Thái" />
    </Fields>
    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
    <EditRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
    <AlternatingRowStyle BackColor="White" />
</asp:DetailsView>
