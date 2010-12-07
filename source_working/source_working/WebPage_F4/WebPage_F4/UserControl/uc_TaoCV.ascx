<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uc_TaoCV.ascx.cs" Inherits="WebPage_F4.UserControl.uc_TaoCV" %>

<style type="text/css">
    .style1
    {
        width: 162px;
        text-align: right;
    }
    .style2
    {
        width: 162px;
        text-align: right;
    }
    .style3
    {
        width: 162px;
        text-align: right;
    }
    .style5
    {
        width: 162px;
    }
    #Text1
    {
        width: 200px;
    }
    #Text2
    {
        width: 200px;
    }
    #Text2
    {
        width: 200px;
    }
    #Text3
    {
        width: 200px;
    }
    #Text4
    {
        width: 200px;
    }
    #Text5
    {
        width: 200px;
    }
    #Text5
    {
        width: 200px;
    }
    #Select1
    {
        width: 47px;
    }
    #Select2
    {
        width: 76px;
    }
    #Select3
    {
        width: 50px;
    }
    #Select4
    {
        width: 80px;
    }
    #Select5
    {
        width: 200px;
    }
    #Select6
    {
        width: 200px;
    }
    #Select7
    {
        width: 200px;
    }
    #Select8
    {
        width: 200px;
    }
    #Select9
    {
        width: 90px;
    }
    #Select10
    {
        width: 97px;
    }
    #Select11
    {
        width: 200px;
    }
    #Select12
    {
        width: 200px;
    }
    #Select13
    {
        width: 90px;
    }
    #Select14
    {
        width: 95px;
    }
    #Select13
    {
        width: 200px;
    }
    .style6
    {
        font-size: x-large;
        font-weight: bold;
        color: #0033CC;
    }
    #Text6
    {
        width: 200px;
    }
    #Text6
    {
        width: 200px;
    }
    #Text7
    {
        width: 200px;
    }
    #Text7
    {
        width: 200px;
    }
    #Select14
    {
        width: 200px;
    }
    #Select15
    {
        width: 200px;
    }
    #Select16
    {
        width: 80px;
    }
    #Select17
    {
        width: 107px;
    }
    #TextArea1
    {
        width: 270px;
        height: 100px;
    }
    #Text8
    {
        width: 200px;
    }
    #Text8
    {
        width: 200px;
    }
    #Text9
    {
        width: 200px;
    }
    #Text9
    {
        width: 200px;
    }
    #Select18
    {
        width: 80px;
    }
    #Select19
    {
        width: 107px;
    }
    #Select20
    {
        width: 80px;
    }
    #Select21
    {
        width: 107px;
    }
    #Select22
    {
        width: 200px;
    }
    #TextArea2
    {
        width: 270px;
        height: 100px;
    }
    #TextArea3
    {
        width: 270px;
        height: 100px;
    }
    #TextArea4
    {
        width: 270px;
        height: 100px;
    }
    #TextArea5
    {
        width: 270px;
        height: 100px;
    }
    #TextArea6
    {
        width: 270px;
        height: 100px;
    }
</style>

<div runat="server" style="width: 500px">

    <span class="style6">Tạo CV</span><br />
    <br />
    <b>:: THÔNG TIN LIÊN HỆ</b><table style="width: 100%;">
        <tr>
            <td class="style1">
                Họ và tên:</td>
            <td>
                <input id="Text1" type="text" /></td>
        </tr>
        <tr>
            <td class="style1">
                Ngày sinh:</td>
            <td>
                &nbsp;<select id="Select1" name="D1">
                    <option></option>
                </select>&nbsp;&nbsp;
                <select id="Select2" name="D2">
                    <option></option>
                </select>&nbsp;&nbsp;
                <select id="Select3" name="D3">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style1">
                Giới tính:</td>
            <td>
                <select id="Select4" name="D4">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style1">
                Tình trạng hôn nhân:</td>
            <td>
                <select id="Select5" name="D5">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style1">
                Địa chỉ:</td>
            <td>
                <input id="Text2" type="text" /></td>
        </tr>
        <tr>
            <td class="style1">
                Điện thoại:</td>
            <td>
                <input id="Text3" type="text" /></td>
        </tr>
        <tr>
            <td class="style1">
                Email:</td>
            <td>
                <input id="Text4" type="text" /></td>
        </tr>
    </table>

    <br />
    <b>:: THÔNG TIN ỨNG DỤNG</b><table style="width:100%;">
        <tr>
            <td class="style2">
                Kinh nghiệm làm việc:</td>
            <td>
                <select id="Select6" name="D6">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style2">
                Cấp bậc:</td>
            <td>
                <select id="Select7" name="D7">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style2">
                Bằng cấp:</td>
            <td>
                <select id="Select8" name="D8">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style2">
                Ngoại ngữ:</td>
            <td>
                <select id="Select9" name="D9">
                    <option></option>
                </select>&nbsp;&nbsp;
                <select id="Select10" name="D10">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style2">
                Có thể đi công tác:</td>
            <td>
                <input id="Radio1" name="R1" type="radio" value="V1" />Có&nbsp;&nbsp;
                <input id="Radio2" name="R2" type="radio" value="V1" />Tùy trường 
                hợp&nbsp;&nbsp;
                <input id="Radio3" name="R3" type="radio" value="V1" />Không</td>
        </tr>
        <tr>
            <td class="style2">
                Có thể chuyển chổ ở:</td>
            <td>
                <input id="Radio4" name="R4" type="radio" value="V1" />Có&nbsp;&nbsp;
                <input id="Radio5" name="R5" type="radio" value="V1" />Tùy trường 
                hợp&nbsp;&nbsp;
                <input id="Radio6" name="R6" type="radio" value="V1" />Không</td>
        </tr>
        <tr>
            <td class="style2">
                Có thể làm thêm ngoài giờ:</td>
            <td>
                <input id="Radio7" name="R7" type="radio" value="V1" />Có&nbsp;&nbsp;
                <input id="Radio8" name="R8" type="radio" value="V1" />Tùy trường 
                hợp&nbsp;&nbsp;
                <input id="Radio9" name="R9" type="radio" value="V1" />Không</td>
        </tr>
    </table>
    <br />
    <b>:: VIỆC LÀM MONG MUỐN</b><table style="width:100%;">
        <tr>
            <td class="style3" style="text-align: right">
                Ngành nghề:</td>
            <td>
                <select id="Select11" name="D11">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style3">
                Vị trí mong muốn:</td>
            <td>
                <input id="Text5" type="text" /></td>
        </tr>
        <tr>
            <td class="style3">
                Mức lương đề nghị:</td>
            <td>
                <select id="Select12" name="D12">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style3">
                Hình thức làm việc:</td>
            <td>
                <input id="Checkbox1" type="checkbox" />Nhân viên chính thức&nbsp;
                <input id="Checkbox2" type="checkbox" />Thời vụ/Dự án&nbsp;
                <input id="Checkbox3" type="checkbox" />Tự do</td>
        </tr>
        <tr>
            <td class="style3">
                Loại hình:</td>
            <td>
                <input id="Checkbox4" type="checkbox" />Toàn thời gian&nbsp;&nbsp;
                <input id="Checkbox5" type="checkbox" />Bán thời gian</td>
        </tr>
        <tr>
            <td class="style3">
                Nơi làm việc:
            <td>
&nbsp;<select id="Select13" name="D13">
                    <option></option>
                </select></td>
        </tr>
    </table>
    <br />
    <b>:: QUÁ TRÌNH HỌC VẤN</b><table style="width:100%;">
        <tr>
            <td class="style1">
                Tên trường:</td>
            <td>
                <input id="Text6" type="text" /></td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right">
                Chuyên ngành/Khóa học:</td>
            <td>
                <input id="Text7" type="text" /></td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right">
                Bằng cấp/Chứng chỉ:</td>
            <td>
                <select id="Select14" name="D14">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right">
                Tỉnh/Thành phố:</td>
            <td>
                <select id="Select15" name="D15">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right">
                Ngày tốt nghiệp:</td>
            <td>
                <select id="Select16" name="D16">
                    <option></option>
                </select>&nbsp;&nbsp;
                <select id="Select17" name="D17">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right">
                Mô tả thêm:</td>
            <td>
                <textarea id="TextArea1" name="S1"></textarea></td>
        </tr>
    </table>
    <br />
    <b>:: KINH NGHIỆM LÀM VIỆC</b><table style="width:100%;">
        <tr>
            <td class="style5" style="text-align: right">
                &nbsp;</td>
            <td>
                <input id="Radio10" name="R10" type="radio" value="V1" />Có&nbsp;&nbsp;
                <input id="Radio11" name="R11" type="radio" value="V1" />Không</td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right">
                Tên công ty:</td>
            <td>
                <input id="Text8" type="text" /></td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right">
                Vị trí công việc:</td>
            <td>
                <input id="Text9" type="text" /></td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right">
                Từ thời gian:</td>
            <td>
                <select id="Select18" name="D18">
                    <option></option>
                </select>&nbsp;&nbsp;
                <select id="Select19" name="D19">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right">
                Đến thời gian:</td>
            <td>
                <select id="Select20" name="D20">
                    <option></option>
                </select>&nbsp;&nbsp;
                <select id="Select21" name="D21">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right">
                Tình/Thành phố:</td>
            <td>
                <select id="Select22" name="D22">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right">
                Mô tả công việc:</td>
            <td>
                <textarea id="TextArea2" name="S2" cols="20" rows="1"></textarea></td>
        </tr>
    </table>
    <br />
    <b>:: THÔNG TIN BỔ SUNG</b><br />
    <table style="width:100%;">
        <tr>
            <td class="style5" style="text-align: right">
                Mục tiêu nghề nghiệp:</td>
            <td>
                <textarea id="TextArea3" name="S3" cols="20" rows="1"></textarea></td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right">
                Kỹ năng:</td>
            <td>
                <textarea id="TextArea4" name="S4" cols="20" rows="1"></textarea></td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right">
                Ưu điểm - nhược điểm:</td>
            <td>
                <textarea id="TextArea5" name="S5" cols="20" rows="1"></textarea></td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right">
                Năng khiếu - sở thích:</td>
            <td>
                <textarea id="TextArea6" name="S6" cols="20" rows="1"></textarea></td>
        </tr>
    </table>
    <br />

</div>
