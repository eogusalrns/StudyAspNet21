<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmControls.aspx.cs" Inherits="FirstWebApp.FrmControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>대체컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HiddenField ID="CtlHidden" runat="server" />
            <asp:Button ID="BtnOK" runat="server" Text="히든필드값 출력" OnClick="BtnOK_Click" /><br />

            <asp:HyperLink ID="LnkMicrosoft" runat="server" NavigateUrl="https://www.microsoft.com" text="MS"/>

            <asp:Image ID="ImgChange" runat="server" ImageUrl="~/Images/ASP-NET-Banners-01.png" />
            <asp:Button ID="BtnChange" runat="server" Text="이미지변경" OnClick="BtnChange_Click" />
            <br />
            <asp:DropDownList ID="CboPhoneNum" runat="server">
                <asp:ListItem Text="010" />
                <asp:ListItem>010</asp:ListItem>
                <asp:ListItem Value="011">010</asp:ListItem>
                <asp:ListItem Value="011" Text="012"></asp:ListItem>
            </asp:DropDownList>
            <asp:ListBox ID="LsbHobby" runat="server">
                <asp:ListItem Text="축구" />
            </asp:ListBox>
        </div>
    </form>
</body>
</html>
