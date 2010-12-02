<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test_UploadFile.aspx.cs" Inherits="WebPage_F4.Test_UploadFile" %>

<%@ Register src="UserControl/uc_UploadCV.ascx" tagname="uc_UploadCV" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:uc_UploadCV ID="uc_UploadCV1" runat="server" />
    
    </div>
    </form>
</body>
</html>
