<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="EmployeeData.WebForm1" %>
<!DOCTYPE html>
<html>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            </p>
        <asp:Panel ID="Panel2" runat="server" BackColor="Silver" Height="42px" Width="755px">
            <asp:Label ID="Label5" runat="server" Text="Employee Data" Font-Size="20px"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="Panel1" runat="server" BackColor="Silver" ForeColor="Black" Height="366px" Width="755px">
            <asp:Label ID="Label1" runat="server" BackColor="#CCCCCC" Text="Emp Name" Width="100px"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" BackColor="#CCFFFF" Width="381px"></asp:TextBox>
            <p>
                <asp:Label ID="Label2" runat="server" BackColor="#CCCCCC" Text="Address" Width="100px"></asp:Label>
                <asp:TextBox ID="txtAdd" runat="server" BackColor="#CCFFFF" Height="16px" Width="381px"></asp:TextBox>
            </p>
            <p style="background-color: #C0C0C0">
                <asp:Label ID="Label3" runat="server" BackColor="#CCCCCC" Text="Phone" Width="100px"></asp:Label>
                <asp:TextBox ID="txtNo" runat="server" BackColor="#CCFFFF" Width="178px"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label4" runat="server" BackColor="#CCCCCC" Text="Gender" Width="100px"></asp:Label>
                <asp:TextBox ID="txtGender" runat="server" BackColor="#CCFFFF" Height="16px" Width="182px"></asp:TextBox>
            </p>
            <p>
                <asp:GridView ID="GrdEmp" runat="server" BackColor="#CCFFCC">
                </asp:GridView>
            </p>
            <p>
                <asp:Button ID="btnSave" runat="server" Text="Save" Width="70px" OnClick="btnSave_Click" />
<%--                <asp:Button ID="btnDelete" runat="server" OnClick="btnSave1_Click" Text="Delete" Width="70px" />--%>
<%--                <asp:Button ID="btnShow" runat="server" OnClick="btnSave1_Click" Text="Show" Width="70px" />--%>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnShow" runat="server" OnClick="Button1_Click" Text="ShowAllEmp" />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnShowEmp" runat="server" OnClick="Button1_Click1" Text="Show" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
            </p>
        </asp:Panel>
    </form>
</body>
</html>
