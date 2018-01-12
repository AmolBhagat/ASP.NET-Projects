<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="IsPostaback.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 28%;
            height: 121px;
            border:1px solid black;
            border-collapse:collapse;
        }
        .auto-style2 {
            width: 165px;
        }
        .auto-style3 {
            width: 211px;
        }
        tr,td{
            border:1px solid black;
            
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
    
        <table class="auto-style1">
            <tr>
                <td colspan="2" style="text-align:center"><b>Employee Details Form</b></td>
                
            </tr>
            <tr>
                <td class="auto-style2">FirstName</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtFirstName" runat="server" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">LastName</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtLastName" runat="server" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">City</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="ddlCity" runat="server" Width="94px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="btnRegister" runat="server" Text="Register Employee" Width="154px" OnClick="btnRegister_Click" />
                </td>
            </tr>
        </table>
        
    
    </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
