<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Menu.ascx.cs" Inherits="F4Website.Menu" %>


<link href="../img.css" rel="stylesheet" type="text/css" />
<link href="../styleSheet.css" rel="stylesheet" type="text/css" />

<table id="Table_01" width="1200" border="0" cellpadding="0" cellspacing="0">
	<tr>
		<td>
			<img id="menu_01" src="../images/menu_01.jpg" width="102" height="44" alt=""/></td>
		<td>
			<img id="menu_02" src="../images/menu_02.jpg" width="39" height="44" alt="" /></td>
		<td>
			<asp:HyperLink ID="HyperLink1" runat="server" ImageUrl="~/images/menu_03.jpg"  
                NavigateUrl="~/index.aspx" >
                </asp:HyperLink>
        </td>
		<td>
			<asp:HyperLink ID="HyperLink2"  runat="server" ImageUrl="~/images/menu_04.jpg" 
                NavigateUrl="~/TimKiem.aspx"></asp:HyperLink>
        </td>
		<td>
			<asp:HyperLink ID="HyperLink3" runat="server" ImageUrl="~/images/menu_05.jpg" 
                NavigateUrl="~/MyTimViec.aspx"></asp:HyperLink>
		</td>
		<td>
			<asp:HyperLink ID="HyperLink4" runat="server" ImageUrl="~/images/menu_06.jpg" 
                NavigateUrl="~/TaoHoSo.aspx"></asp:HyperLink>
        </td>
		<td>
			<asp:HyperLink ID="HyperLink5" runat="server" ImageUrl="~/images/menu_07.jpg" 
                NavigateUrl="~/TaoThongBaoViec.aspx"></asp:HyperLink>
        </td>
		<td>
			<asp:HyperLink ID="HyperLink6" runat="server" ImageUrl="~/images/menu_08.jpg" 
                NavigateUrl="~/CamNangNghe.aspx"></asp:HyperLink>
        </td>
		<td>
			<img id="menu_09" src="../images/menu_09.jpg" width="69" height="44" alt="" /></td>
		<td>
			<img id="menu_10" src="../images/menu_10.jpg" width="100" height="44" alt="" /></td>
	</tr>
</table>

