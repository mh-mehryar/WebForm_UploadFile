<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebForm_UploadFile.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="UpFile" runat="server"></asp:FileUpload>
            <br />

            <asp:Button ID="BtnUp" Text="Upload" runat="server" OnClick="UpBtn_Click"></asp:Button>
            <br />

            <asp:Label ID="LabMsg" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
