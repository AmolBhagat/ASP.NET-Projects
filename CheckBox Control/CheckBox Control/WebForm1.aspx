<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CheckBox_Control.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <fieldset style="width:350px">
            <legend>Education</legend>
            <asp:CheckBox ID="GraduateCheckBox" Text="Graduate" runat="server" AutoPostBack="True" OnCheckedChanged="GraduateCheckBox_CheckedChanged" />
               <asp:CheckBox ID="PostGraduateCheckBox" Text="Post-Graduate" runat="server" />
               <asp:CheckBox ID="DoctorateCheckBox" Text="Doctorate" runat="server" />
        </fieldset>
        <br />
        <br />
        <asp:Button ID="Button1" Text="Button" runat="server" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
