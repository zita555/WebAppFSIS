<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SimpleQuery.aspx.cs" Inherits="WebApp.ExercisePages.SimpleQuery" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Simple Query by Primary Key</h1>
    <div class="row">
        <div class="col-md-6">
            <div class="offset-1">
                <asp:Label runat="server" Text="Enter a Player ID:"></asp:Label>&nbsp;&nbsp;
                <asp:TextBox id="PlayerIDArg" runat="server"></asp:TextBox>&nbsp;&nbsp;
                <asp:Button id="Fetch" runat="server" Text="Fetch" OnClick="Fetch_Click" />
                <br /><br />
                <asp:Label id="MessageLabel" runat="server" ></asp:Label>
            </div>
        </div>
        <div class="col-md-6">
            <asp:Label runat="server" Text="Player ID:"></asp:Label>&nbsp;&nbsp;
            <asp:Label id="PlayerID" runat="server" ></asp:Label>
            <br />
            <asp:Label runat="server" Text="Description:"></asp:Label>&nbsp;&nbsp;
            <asp:Label id="AlbertaHealthCareNumber" runat="server" ></asp:Label>
        </div>
    </div>
</asp:Content>
