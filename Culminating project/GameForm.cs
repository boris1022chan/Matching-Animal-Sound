// Boris Chan, Angela Chen, Mitchell Tai
// Due June 12 2015
// Our program is an animal sound game in which children learn to associate animals and their respective sounds together

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
    public partial class GameForm : Form
    {        
        // Create constants for the number of animals and positions where animals can be placed
        const int NUMBER_OF_ANIMALS = 15;
        const int NUMBER_OF_POSITIONS = 12;

        // Create a number generator to generate the question
        Random numberGenerator = new Random();

        // Create an array to save all the buttons in the game
        Button[] buttons;

        // Create an array to store all the images in the game
        Image[] animalPictures;
       
        // Create an array to store all the sounds in the game
        Stream[] animalSounds;

        // Create a sound player for all the sounds in the game
        SoundPlayer player = new SoundPlayer();

        // Determine if the user just started the game
        bool accessGetQuestion = false;
        int previousQuestion;
        bool accessGetSlot = false;
        int previousSlot;

        // Declare variables that save each environment's unique parameters
        int smallestNumber;
        int biggestNumber;

        const int FARM_BIGGEST = 4;
        const int FARM_SMALLEST = 0;

        const int JUNGLE_BIGGEST = 9;
        const int JUNGLE_SMALLEST = 5;

        const int PET_STORE_BIGGEST = 14;
        const int PET_STORE_SMALLEST = 10;

        // Make a variable that saves the slot in which the animal that corresponds to the sound played is placed
        int question = -1;
        int slot;

        // Save the score of the player. Set it to 0 at the beginning
        int currentScore = 0;
        int highScore;

        MenuForm frmMenu;

        public GameForm(MenuForm frmCreator, int oldHighScore)
        {
            InitializeComponent();

            frmMenu = frmCreator;
            highScore = oldHighScore;

            // Assign the buttons in the array  
            buttons = new Button[NUMBER_OF_POSITIONS] 
                    { btnOption1, btnOption2, btnOption3, btnOption4, btnOption5, btnOption6, btnOption7, btnOption8, btnOption9, btnOption10, btnOption11, btnOption12 };

            // Use a loop to change all of the button appearances
            foreach (Button b in buttons)
            {
                // Remove the borders from all of the buttons 
                b.FlatAppearance.BorderSize = 0;
                // Remove all text from the buttons
                b.Text = "";
                // Make the button mouseover color equal to the form color
                b.FlatAppearance.MouseOverBackColor = BackColor;
            }

            // Assign images into the array
            animalPictures = new Image[NUMBER_OF_ANIMALS] 
                    { Properties.Resources.cow, Properties.Resources.horse, Properties.Resources.pig, Properties.Resources.rooster, Properties.Resources.sheep,
                    Properties.Resources.tiger, Properties.Resources.bear, Properties.Resources.gorilla, Properties.Resources.monkey, Properties.Resources.snake,
                    Properties.Resources.dog, Properties.Resources.hamster, Properties.Resources.fish, Properties.Resources.cat, Properties.Resources.bird};

           

            // Assign sounds into the array
            animalSounds = new Stream[NUMBER_OF_ANIMALS] 
                    { Properties.Resources.cow_sound, Properties.Resources.horse_sound, Properties.Resources.pig_sound, Properties.Resources.rooster_sound, Properties.Resources.sheep_sound, 
                    Properties.Resources.tiger_sound,  Properties.Resources.bear_sound,  Properties.Resources.gorilla_sound,  Properties.Resources.monkey_sound,  Properties.Resources.snake_sound,
                    Properties.Resources.dog_sound,  Properties.Resources.rat_sound, Properties.Resources.fish_sound, Properties.Resources.cat_sound,  Properties.Resources.bird_sound};

            // Run the subprogram that handles the button click
            PictureClick();

            // Show score
            lblScore.Text = "Score: " + currentScore;


        }

        /// <summary>
        /// Boris
        /// This subprogram states the parameter for GetQuestion
        /// It also opens the subprogram that handles the game
        /// </summary>
        public void Farm()
        {
            // Declare the array parameter for this environment
            biggestNumber = FARM_BIGGEST;
            smallestNumber = FARM_SMALLEST;

            // Make the scene picturebox contain the farm environment picture
            BackgroundImage = Properties.Resources.Farm;

            // Call subprogram to start the game
            activateGame();
        }

        /// <summary>
        /// Mitchell
        /// This subprogram states the parameter for GetQuestion
        /// It also opens the subprogram that handles the game
        /// </summary>
        public void PetStore()
        {
            // Declare the array parameter for this environment
            biggestNumber = PET_STORE_BIGGEST;
            smallestNumber = PET_STORE_SMALLEST;

            // Make the scene picturebox contain the pet store environment picture
            BackgroundImage = Properties.Resources.PetStore;

            // Call subprogram to start the game
            activateGame();
        }

        /// <summary>
        /// Angela
        /// This subprogram states the parameter for GetQuestion
        /// It also opens the subprogram that handles the game
        /// </summary>
        public void Jungle()
        {
            // Declare the array parameter for this environment
            biggestNumber = JUNGLE_BIGGEST;
            smallestNumber = JUNGLE_SMALLEST;

            // Make the scene picturebox contain the jungle environment picture
            BackgroundImage = Properties.Resources.Jungle;

            // Call subprogram to start the game
            activateGame();
        }

        /// <summary>
        /// Boris
        /// This subprogram does various things in order to make the game work
        /// It passes through 2 parameters: smallestNumber and biggestNumber, from the subprogram from which it was called (Farm, PetStore, or Jungle)
        /// It first gets a question (the animal whose sound will be played), and the slot that the animal's picture (correct answer) will be placed
        /// Lastly, it randomly fills in the other buttons with other animals
        /// </summary>
        void activateGame()
        {
            // Get the question and the slot position
            question = GetQuestion();            
            RandomPicturePositionGenerator();
            
            // Fill in all of the buttons with animal pictures (including the correct answer)
            FillInTheSlot();
            
            // Open the subprogram that plays the sound of the correct answer animal
            PlayLooping();
        }

        /// <summary>
        /// Boris
        /// This function subprogram generates an integer with the parameters BIGGEST_NUMBER, SMALLEST_NUMBER
        /// The integer will be equal to the corresponding animal in the array
        /// Then, it returns the integer to the subprogram from which it was called (Farm, PetStore, or Jungle)
        /// </summary>
        /// <param name="smallestNumber"></param>
        /// <param name="biggestNumber"></param>
        /// <returns></returns>
        int GetQuestion()
        {
            // Create a variable that stores the question
            int currentQuestion;

            // If the computer gets the question for the first time, generate any number within the parameter
            if (accessGetQuestion == false)
            {
                accessGetQuestion = true;
                currentQuestion = numberGenerator.Next(smallestNumber, biggestNumber + 1);
            }
            // If the computer gets the question for the second or more times, generate a number that is not the same as the previous one
            else 
            {
                // Loop until the currentQuestion is not equal to the previous number
                do
                {
                    currentQuestion = numberGenerator.Next(smallestNumber, biggestNumber + 1);
                } while(currentQuestion == previousQuestion);

            }
            
            // Make the previous question equal to the current question for the next generate
            previousQuestion = currentQuestion;

            // Make the instance variable answer be the generated question
            return currentQuestion;
        }

        /// <summary>
        /// Boris
        /// This subprogram generates an integer that represents the option slot
        /// It will ensure that the slot of the question will not equal the previous one
        /// Make the instance variable that saves the slot equal the choosen slot
        /// </summary>
        /// <returns></returns>
        void RandomPicturePositionGenerator()
        {
            // If the computer gets the slot for the first time, generate any number within the parameter
            if (accessGetSlot == false)
            {
                accessGetSlot = true;
                slot = numberGenerator.Next(0, NUMBER_OF_POSITIONS);
            }
            // If the computer gets the slot for the second or more times, generate a number that is not same as the previous one
            else
            {
                // Loop until the slot is not equal to the previous slot
                do
                {
                    slot = numberGenerator.Next(0, NUMBER_OF_POSITIONS);
                } while (slot == previousSlot);

            }

            // Make the previous slot equal to the current slot for the next generate
            previousSlot = slot;
        }
       
        /// <summary>
        /// Boris
        /// This subprogram shuffles an integer array and puts the shuffled animal pictures into the buttons
        /// It also makes the question go into the generated slot
        /// </summary>
        /// <param name="question"></param>
        /// <param name="correctSlot"></param>
        void FillInTheSlot()
        {
            // Create an integer array to store 15 numbers used for the shuffle
            int[] order = new int[NUMBER_OF_ANIMALS] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            
            // Use a for loop to shuffle the array by switching the i element by a generated element 
            for (int i = 0; i < order.Length; i++)
            {
                // Create a temporary variable to store element i
                int temp = order[i];
                
                // Create a variable to store the generated number between i and the last element of array
                int shuffledNumber = numberGenerator.Next(i, NUMBER_OF_ANIMALS);
                
                // Make the element i equal to the value of element generated
                order[i] = order[shuffledNumber];
                
                // Make the generated element equal to the value of the element i
                order[shuffledNumber] = temp;
            }
            
            // Go through each button to add the pictures by the order
            for (int i = 0; i < buttons.Length; i++)
            {
                // If the generated value is equal to the question, make that button have the picture of the last element array order
                if (order[i] == question)
                {
                    buttons[i].BackgroundImage = animalPictures[order[NUMBER_OF_ANIMALS - 1]];
                }
                // If the generated value is not equal to the question, the button will have the picture of the generated value
                else
                {
                    buttons[i].BackgroundImage = animalPictures[order[i]];
                }
            }

            // Put the picture of the correct animal into the generated slot
            buttons[slot].BackgroundImage = animalPictures[question];
        }

               
        /// <summary>
        /// Angela
        /// This subprogram controls all of the sound playing from the generated answer in order to play the sound that corresponds to that animal
        /// </summary>
        /// <param name="question"></param>
        void PlayLooping()
        {
            // Access the sound file of the randomly selected answer
            player.Stream = animalSounds[question];

            // Set the sound stream back to the beginning so that it is able to replay
            if (player.Stream != null)
            {
                player.Stream.Position = 0;
            }

            // Play the sound
            player.Play();            
        }
                 
        /// <summary>
        /// Angela
        /// This subprogram organizes what happens when a picture is clicked in the game
        /// </summary>
        void PictureClick()
        {
            // Go through all of the buttons using a counting loop
            for (int i = 0; i < buttons.Length; i++)
            {
                // When that button is clicked, go to CheckCorrectOrNot eventhandler
                buttons[i].Click += new System.EventHandler(CountScore);
            }
        }

        
        /// <summary>
        /// Angela
        /// This subprogram opens the function subprogram CheckCorrectOrNot() to determine score changes for the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CountScore(object sender, EventArgs e)
        {
            // Open subprogram to see if user enter a correct answer
            bool answer = CheckCorrectOrNot(sender);

            // Check if the user got the correct answer
            if (answer == true)
            {
                // User gets one point added to their score
                currentScore = currentScore + 1;

                bool newScore = CheckHighScore();

                if (newScore == true)
                {
                    // 
                    highScore = currentScore; 

                    // 
                    frmMenu.AddHighScore(highScore);
                    lblScore.Text = "New High Score: " + currentScore;
                }
                else 
                {
                    // Show score
                    lblScore.Text = "Score: " + currentScore;
                }                
            }
        }

        /// <summary>
        /// Angela
        /// // This subprogram determines whether the user got the correct answer or not
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        bool CheckCorrectOrNot(object sender)
        {
            // Check if the user pressed the picture of the animal that corresponds to the sound that was played
            if (((Button)sender).Name == buttons[slot].Name)
            {
                // User has selected the right answer! Display the "correct" message
                MessageBox.Show("Correct! You got it!");
                activateGame();
                return true;
            }
            else
            {
                // User has clicked the wrong animal! Display the "wrong" message 
                MessageBox.Show("Oops! Wrong answer");
                return false;
            }
        }

        /// <summary>
        /// Mitchell
        /// if new highscore, return true, else return false
        /// </summary>
        /// <param name="currentScore"></param>
        /// <returns></returns>
        bool CheckHighScore()
        {
            if (currentScore > highScore)
            {                
                return true;
            }
            else
            {                
                return false;
            }
        }
        
        private void btnAudioReplay_Click_1(object sender, EventArgs e)
        {
            PlayLooping();
        }   
        

    }
}
