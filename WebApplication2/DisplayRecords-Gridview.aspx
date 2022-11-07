
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h1>Search Records from the Database</h1>
                <h2>Display in a Gridview Control !</h2>
                <hr />
            Search :<asp:TextBox ID="Textsearch" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonSearch" runat="server" Text="Search" OnClick="ButtonSearch_Click"  ForeColor=/>
            <hr />
              <asp:GridView ID="GridView1" runat="server" ShowHeaderWhenEmpty="true" EmptyDataText="No Records Found!">

            </asp:GridView>
                      </center>
           

          
                   

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayRecords-Gridview.aspx.cs" Inherits="WebApplication2.DisplayRecords_Gridview" %>

            </script>


        </div>
    </form>
</body>
</html>
