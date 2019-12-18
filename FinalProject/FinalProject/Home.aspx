<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FinalProject.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Final Year Project</title>
</head>
<body>
    <h1>FINAL YEAR PROJECT MANAGEMENT SYSTEM</h1>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>  
                    <td>Categorey_ID :</td>  
                    <td>  
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="31px">
                            <asp:ListItem>1: Student</asp:ListItem>
                            <asp:ListItem>2: Advisor</asp:ListItem>
                            <asp:ListItem>3: Co-Advisor</asp:ListItem>
                        </asp:DropDownList>
                    </td>  
               </tr> 
               <tr>  
                    <td>Categorey_Name :</td>  
                    <td>  
                        <asp:DropDownList ID="DropDownList2" runat="server" Height="31px">
                            <asp:ListItem>Student</asp:ListItem>
                            <asp:ListItem>Advisor</asp:ListItem>
                            <asp:ListItem>Co-Advisor</asp:ListItem>
                        </asp:DropDownList>
                    </td>  
               </tr> 
               <tr>  
                    <td>Description :</td>  
                    <td>  
                        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>  
                    </td>  
               </tr> 
            </table>
        </div>
    </form>
</body>
</html>
