<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmInputValid.aspx.cs" Inherits="ValidaitonWebApp.FrmInputValid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>유효성검사</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TxtAge" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="ValAge" runat="server" ControlToValidate="TxtAge"
                ErrorMessage="나이는 1~150 사이의 정수입니다." MinimumValue="1" MaximumValue="150" Type="Integer"
                display="Dynamic" ForeColor="DarkRed" SetFocusOnError="true"></asp:RangeValidator>
            <br />
            <asp:TextBox ID="TxtScroe" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="ValScroe" runat="server" ControlToValidate="TxtScroe"
                ErrorMessage="학점은 A~F입니다" MinimumValue="A" MaximumValue="F" Type="String"
                display="Dynamic" SetFocusOnError="true" />

            <asp:RequiredFieldValidator ID="ValUserId" runat="server" ControlToValidate="TxtUserId"
                ErrorMessage="아이디를 입력하세요" ForeColor="Red" Display="Dynamic" />(필수)<br />
            <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password" />
            <asp:RequiredFieldValidator ID="ValPassword" runat="server" ControlToValidate="TxtPassword"
                ErrorMessage="암호를 입력하세요" Display="Dynamic" />(필수)<br />

            <asp:Button ID="BtnLogin" runat="server" OnClick="BtnLogin_Click" Text="로그인"/>
        </div>
    </form>
</body>
</html>
