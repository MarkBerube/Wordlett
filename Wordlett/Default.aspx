<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Wordlett._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <!-- Created by Mark Berube -->
    <!-- home page for the app, all of the controls for the app live here but are controlled on default.aspx.cs -->
    <div class="jumbotron">
        <h1>Wordlett</h1>
        <p class="lead">This is a game where you try to guess a word with a random assortment of letters. You try to guess the arrangement of each letter of the word within 5 chances. Good luck!</p>
    </div>
  
   
    
        <div class="row"><div class="col-md-8">
        <h3>Letter Box: </h3>
           <h1 id="Letterbox" runat="server" class="well text-center"></h1>

              <h3>What you've guessed correctly:</h3>
            <div><h1 id="Guessbox" runat="server" class="well text-center"></h1></div>
              
                         </div>
     
        
             <div class="col-md-4">
   <div class="alert alert-danger text-center"><h2 id="Chances" runat="server"></h2>Chances</div><h4 ID="pop" runat="server" class="text-center"></h4>
                 <div class="well">
   <p>Letter Guess: <asp:TextBox ID="GInput" runat="server" MaxLength="1"></asp:TextBox><asp:Button ID="GuessButton" runat="server" Text="Guess!" OnClick="GuessButton_Click" class="btn btn-default" /></p>
            
    
                 </div>

   </div>
            </div>

</asp:Content>
