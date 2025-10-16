//Program 2
//CIS 199-50
//Due Date: 10/19/2024
//By: Helen Le

//This GUI is to help users using Code Quest track
//the number of points gained from their inputted exercise.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class CodeQuest : Form
    {
        public CodeQuest()
        {
            InitializeComponent();
        }
        //When clicked, this event handler will calculate the points
        //a user has earned based on their completed exercise.
        private void calculateButton_Click(object sender, EventArgs e)
        {
            const int EASY_VALUE = 100; //Point value for easy exercise
            const int MEDIUM_VALUE = 200; //Point value for medium exercise
            const int HARD_VALUE = 300; //Point value for hard exercise
            const int VERY_HARD_VALUE = 400; //Point value for very hard exercise
            const int TIME_PENALTY = 5; //Point penalty for each minute spent
            const double ACTUAL_BONUS = 0.10; //10% bonus if exercise has appeared in actual interviews
            const int MIN_EXERCISE = 1; //Minimum exercise number
            const int MAX_EXERCISE = 1000; //Maximum exercise number
            const int MIN_TIME = 0; //Minimum time spent on exercise

            double score = 0; //User's score for the exercise
            string difficulty = difficultyComboBox.Text; //Difficulty of exercise
            int exerciseNum; //Exercise number
            int timeSpent; //Time spent on question
            bool actualQuestion = yesRadioButton.Checked; //Is the exercise an actual interview question?

           //Checks if a username was entered
           if(userTxt.Text != "")
            {
                //Checks if entered exercise number is an integer and within valid range
                if(int.TryParse(exerciseNumTxt.Text, out exerciseNum) && exerciseNum >= MIN_EXERCISE && exerciseNum <= MAX_EXERCISE) 
                {
                    //Check if a difficulty was chosen from the ComboBox
                    if(difficultyComboBox.SelectedIndex >= 0)
                    {
                        //Checks if the time spent is a valid integer and >= 0
                        if(int.TryParse(timeTxt.Text, out timeSpent) && timeSpent >= MIN_TIME)
                        {
                            //Checks if one of the radio buttons was checked
                            if (yesRadioButton.Checked || noRadioButton.Checked)
                            {
                                //Adds point values based off of difficulties
                                if (difficulty == "Easy")
                                {
                                    score += EASY_VALUE;
                                }
                                else if (difficulty == "Medium")
                                {
                                    score += MEDIUM_VALUE;
                                }
                                else if (difficulty == "Hard")
                                {
                                    score += HARD_VALUE;
                                }
                                else if (difficulty == "Very Hard")
                                {
                                    score += VERY_HARD_VALUE;
                                }

                                //Applies time penalty
                                score -= timeSpent * TIME_PENALTY;

                                //Applies bonus if actual interview question
                                if (actualQuestion)
                                {
                                    score += score * ACTUAL_BONUS;
                                }

                                //Outputs score
                                scoreOutLbl.Text = $"{score}";
                            }
                            else
                            {
                                //Error message if no radio button clicked
                                MessageBox.Show("Please select if the exercise was an actual interview question.");
                            }
                        }
                        else
                        {
                            //Error message if invalid or no time entered
                            MessageBox.Show("Please enter a valid time spent on the exercise.");
                        }
                    }
                    else
                    {
                        //Error message if no difficulty selected
                        MessageBox.Show("Please select a difficulty level for the exercise.");
                    }
                }
                else
                {
                    //Error message if exercise number not entered or invalid
                    MessageBox.Show("Please enter a valid Exercise Number between 1 and 1000.");
                }
            }
            else
            {
                //Error message if username not entered
                MessageBox.Show("Please enter your username.");
            }
        }
    }
}
