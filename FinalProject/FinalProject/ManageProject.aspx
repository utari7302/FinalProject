<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageProject.aspx.cs" Inherits="FinalProject.ManageProject" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Project Description</title>
</head>
<body>
    <h1>Project Detail</h1>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1"> 
               <tr>  
                    <td>Project ID :</td>  
                    <td>  
                        <asp:TextBox ID="txtProjectID" runat="server"></asp:TextBox> 
                    </td>  
               </tr>
                <tr>  
                    <td>Project Title :</td>  
                    <td>  
                        <asp:TextBox ID="txtProjectTitle" runat="server"></asp:TextBox> 
                    </td>  
               </tr>
               
                <tr>  
                    <td>Project Type :</td>  
                    <td>  
                        <asp:TextBox ID="txtProjectType" runat="server"></asp:TextBox> 
                    </td>  
               </tr> 
                <tr>  
                    <td>Project Descriptions :</td>  
                    <td>  
                        <asp:TextBox ID="txtProjectDescription" runat="server"></asp:TextBox> 
                    </td>  
               </tr>
                <tr>  
                    <td>Project Applications :</td>  
                    <td>  
                        <asp:TextBox ID="txtProjectApplication" runat="server"></asp:TextBox> 
                    </td>  
               </tr>
            </table>
            <p>
            <asp:Button ID="btnInsert" runat="server" Text="INSERT" OnClick="btnInsert_Click" />
            <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="DELETE" OnClick="btnDelete_Click" />
            <asp:Button ID="btnReset" runat="server" Text="RESET" OnClick="btnReset_Click" />
        </p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Back" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Next" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
