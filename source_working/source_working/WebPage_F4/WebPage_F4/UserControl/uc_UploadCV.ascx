<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_UploadCV.ascx.cs" Inherits="WebPage_F4.UserControl.uc_UploadCV" %>
<script language="javascript" type="text/javascript">
// <!CDATA[

function File1_onclick() {
    
}

// ]]>
</script>



<style type="text/css">
    .style3
    {
        width: 89px;
    }
    .style4
    {
        width: 200px;
        height: 35px;
    }
    .style5
    {
        height: 35px;
    }
</style>


<div id="MainFrame">
    <table style="width: 629px">
        <tr>
            <td class="style4">
            
                <asp:Label ID="Label1" runat="server" Text="File upload"></asp:Label>
            
            &nbsp;&nbsp;&nbsp;
            
            </td>
            <td class="style5">
            
                <input id="FileInput" size="90" runat="server" type="file" onclick="return File1_onclick()" /></td>
        </tr>
        <tr>
            <td class="style3">
            
            </td>
             <td>
            
                 <asp:Button ID="butUploadCV" runat="server" 
                     onclick="butUploadCV_Click" Text="Upload" Width="82px" />
            
            </td>
        </tr>
    </table>
</div>
