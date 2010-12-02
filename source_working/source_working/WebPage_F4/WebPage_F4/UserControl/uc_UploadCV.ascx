<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_UploadCV.ascx.cs" Inherits="WebPage_F4.UserControl.uc_UploadCV" %>
<script language="javascript" type="text/javascript">
// <!CDATA[

function File1_onclick() {
    
}

// ]]>
</script>



<style type="text/css">
    .style1
    {
        width: 60px;
    }
</style>


<div id="MainFrame">
    <table style="width: 629px">
        <tr>
            <td class="style1">
            
                <asp:Label ID="Label1" runat="server" Text="File upload"></asp:Label>
            
            </td>
            <td>
            
                <input id="FileInput" size="90" runat="server" type="file" onclick="return File1_onclick()" /></td>
        </tr>
        <tr>
            <td class="style1">
            
            </td>
             <td>
            
                 <asp:Button ID="butUploadCV" runat="server" BorderStyle="Solid" 
                     onclick="butUploadCV_Click" Text="Upload" Width="82px" />
            
            </td>
        </tr>
    </table>
</div>
