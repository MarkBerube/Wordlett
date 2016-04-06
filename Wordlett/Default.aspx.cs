using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wordlett
{
   
    public partial class _Default : Page
    {//Created by Mark Berube
        protected void Page_Load(object sender, EventArgs e)
        { //Change the session and controls to start up a new, fresh game on page load
            GInput.Focus();
            if (IsPostBack != true)
            {
                Session["Chances"] = 5;
                Session["Place"] = 0;
                Session["Guessed"] = "";
                string buff = "";

                Guessbox.InnerText = "";
                Letterbox.InnerHtml = "";
                int x = (int)Session["Chances"];
                Chances.InnerText = x.ToString();
                Random num = new Random();


                x = num.Next(58112);
                int y = 0;
                //load up the dictionary and grab a word
                System.IO.StreamReader file = new System.IO.StreamReader(Server.MapPath("~/App_Data/dict.txt"));
                while(x != y){

                    buff = file.ReadLine();
                    y++;

                }
                file.Close();
                Session["Word"] = buff;
                //shuffle said word to make it not easy to just guess
                buff = new string(buff.ToCharArray().OrderBy(s => (num.Next(2) % 2) == 0).ToArray());
                buff = new string(buff.ToCharArray().OrderBy(s => (num.Next(2) % 2) == 0).ToArray());
                buff = new string(buff.ToCharArray().OrderBy(s => (num.Next(2) % 2) == 0).ToArray());
                buff = new string(buff.ToCharArray().OrderBy(s => (num.Next(2) % 2) == 0).ToArray());
                buff = new string(buff.ToCharArray().OrderBy(s => (num.Next(2) % 2) == 0).ToArray());
                buff = new string(buff.ToCharArray().OrderBy(s => (num.Next(2) % 2) == 0).ToArray());
                buff = new string(buff.ToCharArray().OrderBy(s => (num.Next(2) % 2) == 0).ToArray());
                buff = new string(buff.ToCharArray().OrderBy(s => (num.Next(2) % 2) == 0).ToArray());
                buff = new string(buff.ToCharArray().OrderBy(s => (num.Next(2) % 2) == 0).ToArray());
                Session["Rand"] = new string(buff.ToCharArray().OrderBy(s => (num.Next(2) % 2) == 0).ToArray());
                Letterbox.InnerHtml = (String)Session["Rand"];
                

            }


        }

        protected void GuessButton_Click(object sender, EventArgs e)
        {//when the user clicks the guess button control to guess the letter arrangement
            string guesschar = GInput.Text;
            GInput.Text = "";
            

            if (guesschar.Length != 1 || guesschar == String.Empty )
            {//they didn't guess a letter
                
                pop.Attributes["class"] = "alert alert-warning text-center";
                pop.InnerHtml = "You need to put a letter in to guess.";

            }
            else {
                string se = (string)Session["Word"];
                if (guesschar[0] ==  se[(int)Session["Place"]])
            {//they guessed the right letter, it might lead to a win condition

                pop.Attributes["class"] = "alert alert-success text-center";
                pop.InnerHtml = "Yep. Keep going!";
                Session["Guessed"] = (string)Session["Guessed"] + guesschar[0];

                Session["Place"] = (int)Session["Place"] + 1;
                Guessbox.InnerHtml = (string)Session["Guessed"];
                if ((string)Session["Guessed"] == (string)Session["Word"])
                {
                    pop.Attributes["class"] = "alert alert-success text-center";
                    pop.InnerHtml = "YOU WIN! <a href='javascript:history.go(0)'>Try again?</a>";
                    GuessButton.Visible = false;
                    
                }
            }
            else
            {//they guessed the wrong letter, it might lead to a lose condition


                Session["Chances"] = (int)Session["Chances"] - 1;

                if ((int)Session["Chances"] < 0)
                {
                    pop.Attributes["class"] = "alert alert-danger text-center";
                    pop.InnerHtml = "GAME OVER!  The word was: " + (string)Session["Word"] + " <p><a href='javascript:history.go(0)'>Try again?</a></p>";
                    GuessButton.Visible = false;
              
                } else {
                    int c = (int)Session["Chances"];
                    Chances.InnerText = c.ToString();
                pop.InnerHtml = "Nope. Guess again!";
                pop.Attributes["class"] = "alert alert-warning text-center";

                }
            }

            }

        }
    }
}