<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormationOfStudentGroup.aspx.cs" Inherits="FinalProject.GroupID" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gropus</title>
</head>
<body>
    <h1>Group Formation</h1>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Student List :<asp:CheckBoxList ID="CheckBoxList1" runat="server"></asp:CheckBoxList></td>
                    
                </tr>

                <tr>
                    <td>Advisor List :<asp:CheckBoxList ID="CheckBoxList2" runat="server"></asp:CheckBoxList></td>
                    
                </tr>

                <tr>
                    <td>Project List :<asp:CheckBoxList ID="CheckBoxList3" runat="server"></asp:CheckBoxList></td>
                    
                </tr>

                <tr>
                    <td><h3>FINAL GROUPS :</h3></td>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="ProjectTitle" HeaderText="ProjectTitle" />
                            <asp:BoundField DataField="Name" HeaderText="Name" />
                            <asp:BoundField DataField="ID" HeaderText="ID" />
                            <asp:BoundField DataField="Category" HeaderText="Category" />
                            
                        </Columns>
                    </asp:GridView>
                    
                </tr>
            </table>

            
            
            <br />

            <asp:Button ID="Button1" runat="server" Text="CREATE GROUP" OnClick="Button1_Click" />
            
            <asp:Button ID="Button2" runat="server" Text="EVALUATION" />

        </div>
    </form>
</body>
</html>
