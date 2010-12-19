<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test_TaoHoSo.aspx.cs" Inherits="WebPage_F4.Test_TaoHoSo" %>

<%@ Register src="UserControl/uc_TaoCV.ascx" tagname="uc_TaoCV" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:uc_TaoCV ID="uc_TaoCV1" runat="server" />
    
    </div>
    </form>
</body>
</html>
