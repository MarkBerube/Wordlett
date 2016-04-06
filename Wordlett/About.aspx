<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Wordlett.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Created by Mark Berube -->
    <!-- Basic about page for the app -->
 <div class="jumbotron">
        <h1><%: Title %></h1>
        <p class="lead">About the game</p>
    </div>
    <ul class="well" >
    <li><h2>So how many words are there?</h2></li>
        <h4>There are currently 58111 words added to the dictionary.</h4>

        <li><h2>How in the world are you parsing all that data efficiently?</h2></li>
        <h4>Averagely, the application will only go through half of those words because of the way I parse the words. I only parse to the index number of the word I want.</h4>
    </ul>
</asp:Content>
