<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_DanhSachCongViec.ascx.cs" Inherits="WebPage_F4.UserControl.uc_DanhSachCongViec" %>


 
    <asp:DataList ID="DanhSachCongViecList" runat="server" RepeatLayout="Table" RepeatDirection ="Vertical"
    BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" 
    CellPadding="2" ForeColor="Black" Width="550px">
        <FooterStyle BackColor="Tan" />
        <ItemTemplate>
            <asp:Label ID="Label1" runat="server" Text="Tên công ty: "></asp:Label>
            <asp:Label ID="CongTy" runat="server" Text='<%#Bind("CongTy") %>'></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Ngành: "></asp:Label>
            <asp:Label ID="Nganh" runat="server" Text='<%#Bind("Nganh") %>'></asp:Label>
        </ItemTemplate> 
        <AlternatingItemStyle BackColor="PaleGoldenrod" />
        <SelectedItemStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
    </asp:DataList>