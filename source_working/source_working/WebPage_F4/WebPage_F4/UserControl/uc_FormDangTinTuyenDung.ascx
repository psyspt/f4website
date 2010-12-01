<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_FormDangTinTuyenDung.ascx.cs" Inherits="WebPage_F4.UserControl.uc_FormDangTinTuyenDung" %>
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
                <input ID="Text1" type="text" /> <span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Mô tả công việc:</td>
            <td>
                <textarea ID="TextArea1" name="S1"></textarea> <span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Kỹ năng công việc:</td>
            <td>
                <textarea ID="TextArea2" cols="20" name="S2" rows="1"></textarea><span 
                    class="style4">(*)</span></td>
        </tr>
    </table>
    <br />
    <b>:: THÔNG TIN VIỆC LÀM</b><table style="width:100%;">
        <tr>
            <td class="style3">
                Mã số công việc:</td>
            <td>
                <input ID="Text2" type="text" /></td>
        </tr>
        <tr>
            <td class="style3">
                Số lượng:</td>
            <td>
                <input ID="Text3" type="text" /></td>
        </tr>
        <tr>
            <td class="style3">
                Giới tính:</td>
            <td>
                <select ID="Select1" name="D1">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style3">
                Tuổi:</td>
            <td>
                <input ID="Text4" type="text" /> đến:
                <input ID="Text5" type="text" /></td>
        </tr>
        <tr>
            <td class="style3">
                Số năm kinh nghiệm:</td>
            <td>
                <select ID="Select2" name="D2">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style3">
                Quốc gia:</td>
            <td>
                <select ID="Select3" name="D3">
                    <option></option>
                </select><span class="style4"> (*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Tỉnh/Thành phố:</td>
            <td>
                <select ID="Select4" name="D4">
                    <option></option>
                </select> <span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Loại hình:</td>
            <td>
                <input ID="Checkbox1" type="checkbox" />Toàn thời gian&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <input ID="Checkbox2" type="checkbox" />Bán thời gian <span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Hình thức:</td>
            <td>
                <input ID="Checkbox3" type="checkbox" />Nhân viên chính thức&nbsp;&nbsp;&nbsp;&nbsp;
                <input ID="Checkbox4" type="checkbox" />Thời vụ/Dự án&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <input ID="Checkbox5" type="checkbox" />Nghề tự do <span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Mức lương:</td>
            <td>
                <input ID="Text6" type="text" /></td>
        </tr>
        <tr>
            <td class="style3">
                Phụ cấp khác:</td>
            <td>
                <textarea ID="TextArea3" cols="20" name="S3" rows="1"></textarea></td>
        </tr>
        <tr>
            <td class="style3">
                Hạn nộp hồ sơ:</td>
            <td>
                <input ID="Text7" type="text" /> (dd/mm/yyyy)</td>
        </tr>
    </table>
    <b>
    <br />
    :: THÔNG TIN PHÂN LOẠI ỨNG VIÊN</b><table style="width:100%;">
        <tr>
            <td class="style3">
                Ngành nghề:</td>
            <td>
                <select ID="Select5" name="D5">
                    <option></option>
                </select> <span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style5">
                Cấp bậc:</td>
            <td class="style6">
                <select ID="Select6" name="D6">
                    <option></option>
                </select> <span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Bằng cấp:</td>
            <td>
                <select ID="Select7" name="D7">
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
                <input ID="Text8" type="text" />&nbsp;<span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Tên liên lạc:</td>
            <td>
                <input ID="Text9" type="text" />&nbsp;<span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Email:</td>
            <td>
                <input ID="Text10" type="text" />&nbsp;<span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Địa chỉ:</td>
            <td>
                <input ID="Text11" type="text" />&nbsp;<span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Quốc gia:</td>
            <td>
                <input ID="Text12" type="text" />&nbsp;<span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Tỉnh/Thành phố:</td>
            <td>
                <input ID="Text13" type="text" />&nbsp;<span class="style4">(*)</span></td>
        </tr>
        <tr>
            <td class="style3">
                Điện thoại:</td>
            <td>
                <input ID="Text14" type="text" /></td>
        </tr>
        <tr>
            <td class="style3">
                Fax:</td>
            <td>
                <input ID="Text15" type="text" /></td>
        </tr>
    </table>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <input ID="Button1" type="button" value="Đồng ý" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <input ID="Button2" type="button" value="Thoát" />
</div>
