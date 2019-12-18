<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageResult.aspx.cs" Inherits="FinalProject.ManageResult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Result</title>
</head>
<body>
    <h1>Result</h1>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td> Project title List : <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td>Groups :</td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                    </td>
                </tr>
            </table>

            <table>
                <tr> 
                    <td>Obtained Marks: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Toatl Marks: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Button ID="Button1" runat="server" Text="INSERT" /></td>
                </tr>
                <tr>
                    <td><asp:Button ID="Button2" runat="server" Text="REPORT" /></td>
                </tr>
            </table>
            


            
            
        </div>
    </form>
</body>
</html>
