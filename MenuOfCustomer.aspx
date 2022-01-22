<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuOfCustomer.aspx.cs" Inherits="ProjectCoffee.MenuOfCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
<%--<script type="text/javascript">
    function
</script>--%>
    
    </head>
<body>
    <form id="form1" runat="server">
        <link rel="stylesheet" href="~/Content/css/CustomerPage.css">

        <div>
            <asp:GridView ID="product" runat="server" AutoGenerateColumns="false" Height="275px" Width="613px">
                <Columns>
                    <asp:BoundField DataField="NameProduct" HeaderText="Name Product"/>
                    <asp:BoundField DataField="price" HeaderText="Price"/>
                    <asp:BoundField DataField="image" HeaderText="Image"/>
                   
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
