<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tính chu vi , diện tích và thể tích hình lập ph</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Tính Toán Diện Tích , Chu Vi Và Thể Tích Hình Lập Phương</h2>
            <asp:Label ID="lblRadius" runat="server" Text="Nhập Chiều dài 1 cạnh: "></asp:Label>
             <br /><br />
            <asp:TextBox ID="txtRadius" runat="server"></asp:TextBox>
            <asp:Button ID="btnCalculate" runat="server" Text="Tính Toán" OnClick="btnCalculate_Click" />
            <br /><br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>