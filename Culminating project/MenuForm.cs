/* Mitchell Tai
 * June 3 2015
 * this program is a sound to animal matching game, which comes with 3 different environments and 15 different animals
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FinalCulminating
{
    public partial class MenuForm : Form
    {
        // Timer setting 
        bool isMenuRunning = false;
        int currentTime;
        int timePassed;
        int previousTime;
        const int FRAME_RATE = 1000;

        //
        int glowCount = 0;
        // declare glow array
        Image[] nameGlow = new Image[4];
        
        //play sounds
        SoundPlayer player = new SoundPlayer();

        //instance variables declared
        bool firstTime = true;
        string username;
        bool musicLoop;

        int highScore = 0;

        public MenuForm()
        {
            InitializeComponent();

            // System Time
            currentTime = Environment.TickCount;
            previousTime = currentTime;

            // Assign glow array
            nameGlow = new Image[4] { Properties.Resources.blue2, Properties.Resources.red2, Properties.Resources.green2, Properties.Resources.orange2 };


            pnlStart.Visible = true;
            lblLogin.Visible = true;
            lblLogin.Text = "";

            // start playing background music when the form loads
            player.Stream = Properties.Resources.Totoro_Theme;
            player.PlayLooping();

        }
                
        /// <summary>
        /// Mitchell
        /// returns the username of the player
        /// </summary>
        /// <returns></returns>
        string GetUserName()
        {
            txtUsername.MaxLength = 15;
            return txtUsername.Text;
        }
                
        /// <summary>
        /// Mitchell
        /// makes menu panel visible. also checks if it is the first time accessing the menu. also plays music until user clicks a button
        /// </summary>
        void Menu()
        {
            // Make menu panel appear
            pnlMenu.Visible = true;

            // start playing music as background
            musicLoop = true;     
            if (musicLoop == true)
            {
                player.Stream= Properties.Resources.Totoro_Theme;
                player.PlayLooping();
            }

        }
                
        /// <summary>
        /// Mitchell
        /// switches the color of the glow based one second interval
        /// </summary>
        void SwitchGlow()
        {
            //count glow interval by 1
            glowCount++;
            //change the image based on the remainder after dividing the glow counter by 1 each time (eg. 1 / 4 remainder = 1)
            picAskName.Image = nameGlow[glowCount % 4];
        }
                
        /// <summary>
        /// Mitchell
        /// times one second intervals as long as the menu is running
        /// </summary>
        void CustomTimer()
        {
            do
            {
                //current time equals the time
                currentTime = Environment.TickCount;
                //the time passed = the current time - previous time
                timePassed = currentTime - previousTime;

                //if timePassed is greater than or equals to 1000 (1 second) then change value of previous time to current time and run "SwitchGlow" subprogram
                if (timePassed >= FRAME_RATE)
                {
                    previousTime = currentTime;

                    SwitchGlow();
                }
                //does all the other events, such as mouse down
                Application.DoEvents();
            } while (isMenuRunning == true); // loop as long as menu is running
        }
                
        

       
        /// <summary>
        /// mitchell
        /// when clicked, it saves username to a variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnterName_Click(object sender, EventArgs e)
        {
            //if it is the first time running, save the username. else write "you have already logged in"
            if (firstTime == true)
            {
                //change variable to false and continue
                firstTime = false;

                //call GetUserName subprogram
                username = GetUserName();
                lblLogin.Visible = true;
                lblLogin.Text = "Welcome " + username + "!";
                //change firstTime to false
                firstTime = false;
            }
            else
            {
                lblLogin.Text = username + " has already logged in!";
            }
            
        }

        
        /// <summary>
        /// Mitchell
        /// hides pnlStart when button is clicked. also sets isMenuRunning to true, which allows custom timer to run
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
            isMenuRunning = true;

            Menu();
            //call custom timer subprogram
            CustomTimer();
        }
        
        /// <summary>
        /// Mitchell
        /// when btnPetStore is clicked, the music stops and the pet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPetStore_Click(object sender, EventArgs e)
        {
            musicLoop = false;
            
            // Go to petstore subprogram
            GameForm frmGameForm = new GameForm(this, highScore);
            frmGameForm.Show();
            frmGameForm.PetStore();
        }        
        
        /// <summary>
        /// Mitchell
        /// when btnFarm is clicked, the music stops and the farm environment loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFarm_Click(object sender, EventArgs e)
        {
            //stop the music
            musicLoop = false;

            // Go to farm subprogram
            GameForm frmGameForm = new GameForm(this, highScore);
            frmGameForm.Show();
            frmGameForm.Farm();
        }

        /// <summary>
        /// Mitchell
        /// when the jungle button is clicked, the music stops and the game progresses to the jungle environment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJungle_Click(object sender, EventArgs e)
        {
            //set the musicloop to false, which stops the music from playing
            musicLoop = false;
            
            //Go to jungle subprogram
            GameForm frmGameForm = new GameForm(this, highScore);
            frmGameForm.Show();
            frmGameForm.Jungle();
            
        }

        /// <summary>
        /// Boris
        /// This subprogram saves the highscore from GameForm
        /// </summary>
        /// <param name="scoreToAdd"></param>
        public void AddHighScore(int scoreToAdd)
        {
            highScore = scoreToAdd;
            lblHighScore.Text = "High Score: " + highScore;
        }


       

           
    }
}
