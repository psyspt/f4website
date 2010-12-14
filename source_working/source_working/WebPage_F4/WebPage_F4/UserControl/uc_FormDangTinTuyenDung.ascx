<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_FormDangTinTuyenDung.ascx.cs" Inherits="WebPage_F4.UserControl.uc_FormDangTinTuyenDung" %>
<script language="javascript" type="text/javascript">
// <!CDATA[




// ]]>
</script>

<style type="text/css">
    .style2
    {
        font-size: x-large;
        color: #CC33FF;
    }
    .style3
    {
        width: 162px;
        text-align: right;
    }
    #Text1
    {
        width: 250px;
    }
    #TextArea1
    {
        height: 110px;
        width: 370px;
    }
    #TextArea2
    {
        height: 110px;
        width: 370px;
    }
    .style4
    {
        color: #FF0000;
    }
    #Text2
    {
        width: 250px;
    }
    #Text3
    {
        width: 250px;
    }
    #Select1
    {
        width: 150px;
    }
    #Select2
    {
        width: 150px;
    }
    #Select3
    {
        width: 150px;
    }
    #Select4
    {
        width: 150px;
    }
    #Text6
    {
        width: 200px;
    }
    #TextArea3
    {
        height: 110px;
        width: 370px;
    }
    #Select5
    {
        width: 220px;
    }
    #Select6
    {
        width: 150px;
    }
    #Select7
    {
        width: 150px;
    }
    #Select6
    {
        width: 220px;
    }
    #Select7
    {
        width: 220px;
    }
    #Text8
    {
        width: 250px;
    }
    #Text9
    {
        width: 250px;
    }
    #Text10
    {
        width: 250px;
    }
    #Text11
    {
        width: 250px;
    }
    #Text12
    {
        width: 250px;
    }
    #Text13
    {
        width: 250px;
    }
    #Text14
    {
        width: 250px;
    }
    #Text15
    {
        width: 250px;
    }
    .style5
    {
        width: 162px;
        text-align: right;
        height: 31px;
    }
    .style6
    {
        height: 31px;
    }
    #main
    {
    	width:612px;
    	height:680px;
    }
    
    #TenCongTy
    {
        width: 242px;
    }
    #TenLienLac
    {
        width: 242px;
    }
    
    #Email
    {
        width: 242px;
    }
    #DiaChi
    {
        width: 242px;
    }
    #QuocGia
    {
        width: 242px;
    }
    #TinhThanh
    {
        width: 242px;
    }
    #DienThoai
    {
        width: 242px;
    }
    #Fax
    {
        width: 242px;
    }
    
    .style7
    {
        width: 162px;
        text-align: right;
        height: 30px;
    }
    .style8
    {
        height: 30px;
    }
    
    #NganhNghe
    {
        width: 218px;
    }
    
    #CapBac
    {
        width: 218px;
    }
    #BangCap
    {
        width: 218px;
    }
    
    #GioiTinh
    {
        width: 72px;
    }
    #KinhNghiem
    {
        width: 124px;
    }
    #QuocGiaList
    {
        width: 124px;
    }
    #TinhThanhList
    {
        width: 124px;
    }
    
</style>
<div id="main">
    <span class="style2">Tạo Tuyển Dụng</span><br />
    <br />
    <b>:: MÔ TẢ CÔNG VIỆC</b><br />
    <table style="width:100%;">
        <tr>
            <td class="style3">
                Vị trí tuyển dụng:</td>
            <td>
                <input id="ViTriTuyenDung" type="text" runat="server"/> <span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Mô tả công việc:</td>
            <td>
                <textarea id="MoTaCongViec" name="S1" runat="server"></textarea> <span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Kỹ năng công việc:</td>
            <td>
                <textarea id="KyNangCongViec" cols="20" name="S2" rows="1" runat="server"></textarea><span 
                    class="style4">(*)</span></td>
        </tr>
    </table>
    <br />
    <b>:: THÔNG TIN VIỆC LÀM</b><table style="width:100%;">
        <tr>
            <td class="style3">
                Mã số công việc:</td>
            <td>
                <input id="MaSoCongViec" type="text" runat = "server" /></td>
        </tr>
        <tr>
            <td class="style3">
                Số lượng:</td>
            <td>
                <input id="SoLuong" type="text" runat = "server"/></td>
        </tr>
        <tr>
            <td class="style3">
                Giới tính:</td>
            <td>
                <select id="GioiTinh" name="D1" runat = "server">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style3">
                Tuổi:</td>
            <td>
                <input id="TuoiMin" type="text" runat = "server"/> đến:
                <input id="TuoiMax" type="text" runat = "server"/></td>
        </tr>
        <tr>
            <td class="style3">
                Số năm kinh nghiệm:</td>
            <td>
                <select id="KinhNghiem" name="D2" runat="server">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style3">
                Quốc gia:</td>
            <td>
                <select id="QuocGiaList" name="D3" runat = "server">
                    <option></option>
                </select><span class="style4"> (*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Tỉnh/Thành phố:</td>
            <td>
                <select id="TinhThanhList" name="D4" runat = "server">
                    <option></option>
                </select> <span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Loại hình:</td>
            <td>
                <input id="Checkbox1" type="checkbox" runat = "server"/>Toàn thời gian&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <input id="Checkbox2" type="checkbox" runat = "server"/>Bán thời gian <span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Hình thức:</td>
            <td>
                <input id="Checkbox3" type="checkbox" runat = "server"/>Nhân viên chính thức&nbsp;&nbsp;&nbsp;&nbsp;
                <input id="Checkbox4" type="checkbox" runat = "server"/>Thời vụ/Dự án&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <input id="Checkbox5" type="checkbox" runat = "server"/>Nghề tự do <span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Mức lương:</td>
            <td>
                <input id="MucLuong" type="text" runat = "server"/></td>
        </tr>
        <tr>
            <td class="style3">
                Phụ cấp khác:</td>
            <td>
                <textarea id="PhuCap" cols="20" name="S3" rows="1" runat ="server" ></textarea></td>
        </tr>
        <tr>
            <td class="style3">
                Hạn nộp hồ sơ:</td>
            <td>
                <input id="HanNopHoSo" type="text"  runat = "server"/> (dd/mm/yyyy)</td>
        </tr>
    </table>
    <b>
    <br />
    :: THÔNG TIN PHÂN LOẠI ỨNG VIÊN</b><table style="width:100%;">
        <tr>
            <td class="style3">
                Ngành nghề:</td>
            <td>
                <select id="NganhNghe" name="D5" runat = "server">
                    <option></option>
                </select> <span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style5">
                Cấp bậc:</td>
            <td class="style6">
                <select id="CapBac" name="D6" runat = "server">
                    <option></option>
                </select> <span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Bằng cấp:</td>
            <td>
                <select id="BangCap" name="D7" runat = "server">
                    <option></option>
                </select> <span class="style4">(*)</span></td>
        </tr>
    </table>
    <br />
    <b>:: THÔNG TIN LIÊN HỆ </b>
    <table style="width:100%;">
        <tr>
            <td class="style3">
                Tên công ty:</td>
            <td>
                <input id="TenCongTy" type="text" runat ="server" />&nbsp;<span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Tên liên lạc:</td>
            <td>
                <input id="TenLienLac" type="text" runat ="server"/>&nbsp;<span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Email:</td>
            <td>
                <input id="Email" type="text" runat ="server" />&nbsp;<span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style7">
                Địa chỉ:</td>
            <td class="style8">
                <input id="DiaChi" type="text" runat ="server"/>&nbsp;<span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Quốc gia:</td>
            <td>
                <input id="QuocGia" type="text" runat ="server"/>&nbsp;<span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Tỉnh/Thành phố:</td>
            <td>
                <input id="TinhThanh" type="text" runat ="server"/>&nbsp;<span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Điện thoại:</td>
            <td>
                <input id="DienThoai" type="text" runat ="server"/></td>
        </tr>
        <tr>
            <td class="style3">
                Fax:</td>
            <td>
                <input id="Fax" type="text" runat ="server"/></td>
        </tr>
    </table>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
        ID="DongY" runat="server" onclick="DongY_Click" Text="Đồng Ý" />
    &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Thoat" runat="server" Text="Thoát" />
</div>
