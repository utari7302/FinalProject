<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageAdvisor.aspx.cs" Inherits="FinalProject.ManageAdvisor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Advisor Information</title>
</head>
<body>
    <h1>Advisor Information</h1>
    <form id="form1" runat="server">
        <div>
             <table class="auto-style1"> 
                  <tr>  
                    <td>Categorey_Name :</td>  
                    <td>  
                        <asp:DropDownList ID="DropDownList2" runat="server" Height="31px">
                            <asp:ListItem>Advisor</asp:ListItem>
                        </asp:DropDownList>
                    </td>  
               </tr> 
               <tr>  
                    <td>Name :</td>  
                    <td>  
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox> 
                    </td>  
               </tr>
               
                <tr>  
                    <td>Email :</td>  
                    <td>  
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox> 
                    </td>  
               </tr>
              
                <tr>  
                    <td>Rank :</td>  
                    <td>  
                        <asp:TextBox ID="txtRank" runat="server"></asp:TextBox> 
                    </td>  
               </tr> 
                <tr>  
                    <td>Contact Number :</td>  
                    <td>  
                        <asp:TextBox ID="txtContactNumber" runat="server"></asp:TextBox> 
                    </td>  
               </tr> 
                <tr>  
                    <td>CNIC :</td>  
                    <td>  
                        <asp:TextBox ID="txtCNIC" runat="server"></asp:TextBox> 
                    </td>  
               </tr> 
            </table>
        </div>
        <p>
            <asp:Button ID="btnInsert" runat="server" Text="INSERT" OnClick="btnInsert_Click" />
            <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="DELETE" OnClick="btnDelete_Click" />
            <asp:Button ID="btnReset" runat="server" Text="RESET" OnClick="btnReset_Click" />
        </p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click"/>
        <asp:Button ID="btnNext" runat="server" Text="Next" OnClick="btnNext_Click"/>
       
    </form>
</body>
</html>
