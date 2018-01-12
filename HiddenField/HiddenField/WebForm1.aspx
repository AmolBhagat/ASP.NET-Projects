<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HiddenField.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hiddenfield Demo</title>
    <script lang="javascript" type="text/javascript">

        function GetHiddenFieldValue()
        {
            alert('EmployeeID =' + document.getElementById('HiddenField1').value);
        }


        function Button1_onclick()
        {
            GetHiddenFieldValue();
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HiddenField ID="HiddenField1" runat="server" />
        <br />
        <table>
            <tr>
                <td>Name</td><td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
            </tr>

             <tr>
                <td>Gender</td><td><asp:TextBox ID="txtGender" runat="server"></asp:TextBox></td>
            </tr>

             <tr>
                <td>Department</td><td><asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td>
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />

                </td>

                <td>
                    <asp:Button ID="btnLoad" runat="server" Text="Load Employee" OnClick="btnLoad_Click" Width="128px" />
                </td>
               <td>
                    <input id="Button1" type="button" value="button" />
               </td>
                   
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
