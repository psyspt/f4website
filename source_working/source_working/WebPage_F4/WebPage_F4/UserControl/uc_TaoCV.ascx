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
    #cbxTTUngDung_LoaiNgoaiNgu
    {
        width: 24px;
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
                <input id="tbxThongTin_HoTen" type="text"  runat = "server"/></td>
        </tr>
        <tr>
            <td class="style1">
                Ngày sinh:</td>
            <td>
                &nbsp;<select id="cbxThongTin_NgaySinh" name="D1" runat = "server">
                    <option></option>
                </select>&nbsp;&nbsp;
                <select id="cbxThongTin_Thang" name="D2" runat = "server">
                    <option></option>
                </select>&nbsp;&nbsp;
                <select id="cbxThongTin_Nam" name="D3" runat = "server">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style1">
                Giới tính:</td>
            <td>
                <select id="cbxThongTin_GioiTinh" name="D4" runat = "server">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style1">
                Tình trạng hôn nhân:</td>
            <td>
                <select id="cbxThongTin_TinhTrangHonNhan"  runat = "server" name="D5">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style1">
                Địa chỉ:</td>
            <td>
                <input id="tbxThongTin_DiaChi" type="text"  runat = "server"/></td>
        </tr>
        <tr>
            <td class="style1">
                Điện thoại:</td>
            <td>
                <input id="tbxThongTin_DienThoai" type="text"  runat = "server"/></td>
        </tr>
        <tr>
            <td class="style1">
                Email:</td>
            <td>
                <input id="tbxThongTin_Email" type="text"  runat = "server"/></td>
        </tr>
    </table>

    <br />
    <b>:: THÔNG TIN ỨNG DỤNG</b><table style="width:100%;">
        <tr>
            <td class="style2">
                Kinh nghiệm làm việc:</td>
            <td>
                <select id="cbxTTUngDung_KinhNghiem" name="D6" runat = "server">
                    <option></option>
                </select> </td>
        </tr>
        <tr>
            <td class="style2">
                Cấp bậc:</td>
            <td>
                <select id="cbxTTUngDung_CapBac" name="D7" runat = "server">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style2">
                Bằng cấp:</td>
            <td>
                <select id="cbxTTUngDung_BangCap" name="D8" runat = "server">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style2">
                Ngoại ngữ:</td>
            <td>
                <select id="cbxTTUngDung_LoaiNgoaiNgu" name="D9" runat = "server">
                    <option></option>
                </select>&nbsp;&nbsp;
                <select id="cbxTTUngDung_TrinhDoNgoaiNgu" name="D10" runat = "server">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style2">
                Có thể đi công tác:</td>
            <td>
                <input id="rdTTUngDung_CongTac_Yes" name="R1" type="radio" value="V1"  runat = "server"/>Có&nbsp;&nbsp;
                <input id="rdTTUngDung_CongTac_Option" name="R2" type="radio" value="V1"  runat = "server"/>Tùy trường 
                hợp&nbsp;&nbsp;
                <input id="rdTTUngDung_CongTac_No" name="R3" type="radio" value="V1"  runat = "server"/>Không</td>
        </tr>
        <tr>
            <td class="style2">
                Có thể chuyển chổ ở:</td>
            <td>
                <input id="rbTTUngDung_ChuyenCho_Yes" name="R4" type="radio" value="V1"  runat = "server"/>Có&nbsp;&nbsp;
                <input id="rbTTUngDung_ChuyenCho_Option" name="R5" type="radio" value="V1"  runat = "server"/>Tùy trường 
                hợp&nbsp;&nbsp;
                <input id="rdTTUngDung_ChuyenCho_No" name="R6" type="radio" value="V1"  runat = "server"/>Không</td>
        </tr>
        <tr>
            <td class="style2">
                Có thể làm thêm ngoài giờ:</td>
            <td>
                <input id="rdTTUngDung_LamNgoaigio_Yes" name="R7" type="radio" value="V1"  runat = "server"/>Có&nbsp;&nbsp;
                <input id="rdTTUngDung_LamNgoaiGio_Option" name="R8" type="radio" value="V1" runat = "server" />Tùy trường 
                hợp&nbsp;&nbsp;
                <input id="rdTTUngDung_LamNgoaiGio_No" name="R9" type="radio" value="V1" runat = "server" />Không</td>
        </tr>
    </table>
    <br />
    <b>:: VIỆC LÀM MONG MUỐN</b><table style="width:100%;">
        <tr>
            <td class="style3" style="text-align: right">
                Ngành nghề:</td>
            <td>
                <select id="cbxVLMongMuon_NganhNghe" name="D11" runat = "server">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style3">
                Vị trí mong muốn:</td>
            <td>
                <input id="tbxVLMongMuon_ViTri" type="text"  runat = "server"/></td>
        </tr>
        <tr>
            <td class="style3">
                Mức lương đề nghị:</td>
            <td>
                <select id="cbxVLMongMuon_MucLuongDeNghi" name="D12" runat = "server">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style3">
                Hình thức làm việc:</td>
            <td>
                <input id="cbVLMongMuon_HinhThucCongViec_ChinhThuc" type="checkbox"  runat = "server"/>Nhân viên chính thức&nbsp;
                <input id="cbVLMongMuon_HinhThucCongViec_ThoiVu" type="checkbox"  runat = "server"/>Thời vụ/Dự án&nbsp;
                <input id="cbVLMongMuon_HinhThucCongViec_TuDo" type="checkbox"  runat = "server"/>Tự do</td>
        </tr>
        <tr>
            <td class="style3">
                Loại hình:</td>
            <td>
                <input id="cbVLMongMuon_LoaiCongViec_Fulltime" type="checkbox"  runat = "server"/>Toàn thời gian&nbsp;&nbsp;
                <input id="cbVLMongMuon_LaiCongViec_Parttime" type="checkbox"  runat = "server"/>Bán thời gian</td>
        </tr>
        <tr>
            <td class="style3">
                Nơi làm việc:
            <td>
&nbsp;<select id="cbxVLMongMuon_NoiLamViec" name="D13" runat = "server">
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
                <input id="tbxQuaTrinhHocTap_TenTruong" type="text"  runat = "server"/></td>
        </tr>
        <tr>
            <td class="style3" style="text-align: right">
                Chuyên ngành/Khóa học:</td>
            <td>
                <input id="tbxQuaTrinhHocTap_ChuyenNganh" type="text"  runat = "server"/></td>
        </tr>
        <tr>
            <td class="style3" style="text-align: right">
                Bằng cấp/Chứng chỉ:</td>
            <td>
                <select id="cbxQuaTrinhHocTap_BangCap" name="D14" runat = "server">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style3" style="text-align: right">
                Tỉnh/Thành phố:</td>
            <td>
                <select id="cbxQuaTrinhHocTap_TinhThanh" name="D15" runat = "server">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style3" style="text-align: right">
                Ngày tốt nghiệp:</td>
            <td>
                <asp:TextBox ID="tbxNgayTotNghiep" runat="server"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td class="style3" style="text-align: right">
                Mô tả thêm:</td>
            <td>
                <textarea id="QuaTrinhHocTap_Mota" name="S1" runat = "server"></textarea></td>
        </tr>
    </table>
    <br />
    <b>:: KINH NGHIỆM LÀM VIỆC</b><table style="width:100%;">
        <tr>
            <td class="style5" style="text-align: right">
                &nbsp;</td>
            <td>
                <input id="Radio10" name="R10" type="radio" value="V1" runat = "server" />Có&nbsp;&nbsp;
                <input id="Radio11" name="R11" type="radio" value="V1" runat = "server"/>Không</td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right" runat = "server">
                Tên công ty:</td>
            <td>
                <input id="tbxKNLV_TenCongTy" type="text" runat = "server"/></td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right">
                Vị trí công việc:</td>
            <td>
                <input id="tbxKNLV_ViTriCongViec" type="text" runat = "server"/></td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right">
                Từ thời gian:</td>
            <td>
                <select id="cbxKNLV_Begin_Month" name="D18" runat = "server">
                    <option></option>
                </select>&nbsp;&nbsp;
                <select id="cbxKNLV_Begin_Year" name="D19" runat = "server">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right">
                Đến thời gian:</td>
            <td>
                <select id="cbxKNLV_End_Month" name="D20" runat = "server">
                    <option></option>
                </select>&nbsp;&nbsp;
                <select id="cbxKNLV_End_Year" name="D21" runat = "server">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right">
                Tình/Thành phố:</td>
            <td>
                <select id="cbxKNLV_TinhTP" name="D22" runat = "server">
                    <option></option>
                </select></td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right" runat = "server">
                Mô tả công việc:</td>
            <td>
                <textarea id="tbxKNLV_MoTa" name="S2" cols="20" rows="1" runat = "server"></textarea></td>
        </tr>
    </table>
    <br />
    <b>:: THÔNG TIN BỔ SUNG</b><br />
    <table style="width:100%;">
        <tr>
            <td class="style5" style="text-align: right">
                Mục tiêu nghề nghiệp:</td>
            <td>
                <textarea id="TextArea3" name="S3" cols="20" rows="1"  runat = "server"></textarea></td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right">
                Kỹ năng:</td>
            <td>
                <textarea id="TextArea4" name="S4" cols="20" rows="1" runat = "server"></textarea></td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right">
                Ưu điểm - nhược điểm:</td>
            <td>
                <textarea id="TextArea5" name="S5" cols="20" rows="1" runat = "server"></textarea></td>
        </tr>
        <tr>
            <td class="style5" style="text-align: right">
                Năng khiếu - sở thích:</td>
            <td>
                <textarea id="TextArea6" name="S6" cols="20" rows="1" runat = "server"></textarea></td>
        </tr>
    </table>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="butCV" runat="server" onclick="butCV_Click" Text="Tạo CV" />
    <br />

</div>
