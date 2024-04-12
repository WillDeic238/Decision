using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Decision
{
    public partial class Form1 : Form
    {

        int page = 1;

        Random randGen = new Random();
        public Form1()
        {
            InitializeComponent();
            SoundPlayer player = new SoundPlayer(Properties.Resources.f1intro);
            player.Play();
        }
      

        private void option1Button_Click(object sender, EventArgs e)
        {

            if(page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 1;
            }
            else if (page == 3)
            {
                page = 5;
            }
            else if (page == 4)
            {
                page = 1;
            }
            else if (page == 5)
            {
                page = 6;
            }
            else if (page == 6)
            {
                page = 1;
            }
            else if(page == 7)
            {
                page = 8;
            }
            else if (page == 8)
            {
                page = 1;
            }
            else if (page == 9)
            {
                page = 11;
            }
            else if (page == 10)
            {
                page = 1;
            }
            else if (page == 11)
            {
                page = 12;
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page ==13)
            {
                page = 15;
            }
            else if (page ==14)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 17;
            }
            else if (page == 16)
            {
                page = 1;
            }
            else if (page == 17)
            {
                page = 20;
            }
            else if (page == 18)
            {
                page = 1;
            }
            else if (page == 19)
            {
                page = 1;
            }
            else if (page == 20)
            {
                page = 1;
            }
            else if (page == 21)
            {
                page = 22;
            }
            else if (page == 22)
            {
                page = 1;
            }
            else if (page == 23)
            {
                page = 1;
            }

            Displaypage();
       
        } 
        private void option2Button_Click(object sender, EventArgs e)
        {
           
            if(page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 99;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 99;
            }
            else if (page == 5)
            {
                page = 7;
            }
            else if (page==6)
            {
                page = 99;
            }
            else if (page == 7)
            {
                page = 9;
            }
            else if (page == 8)
            {
                page = 99;
            }
            else if (page == 9)
            {
                page = 10;
            }
            else if (page == 10)
            {
                page = 99;
            }
            else if (page == 11)
            {
                page = 13;
            }
            else if (page == 12)
            {
                page = 99;
            }
            else if (page == 13)
            {
                page = 14;
            }
            else if (page == 14)
            {
                page = 99;
            }
            else if (page == 15)
            {
                page = 18;
            }
            else if (page == 16)
            {
                page = 99;
            }
            else if (page == 17)
            {
                int randValue = randGen.Next(1, 101);

                if(randValue <30)
                {
                    page = 21;
                }
                else
                {
                    page = 19;
                }

            }
            else if (page ==18)
            {
                page = 99;
            }
            else if (page == 19)
            {
                page = 99;
            }
            else if (page == 20)
            {
                page = 99;
            }
            else if (page == 21)
            {
                page = 23;
            }
            else if (page == 22)
            {
                page = 99;
            }
            else if (page == 23)
            {
                Close();
            }
            
            Displaypage();
        }
        
        private void option3Button_Click(object sender, EventArgs e)
        {
        if (page == 13)
            {
                page = 16;
            }
        Displaypage();

        }
        private void Displaypage()
        {

            switch (page)
            {
                case 1:
                    titleLabel.Text = "You are Lewis Hamilton and it is race Sunday. Due to an unfourtunate crash in Q1 you are P20 on the grid. ";
                    questionLabel.Text = "You See P19 ahead do you pass him or stay where you are ?";
                    option1Button.Text = "Overtake";
                    option2Button.Text = "Stay put";
                    option3Button.Text = "";
                    positionLabel.Text = "Position: 20/20";
                    SoundPlayer player = new SoundPlayer(Properties.Resources.f1intro);
                    player.Play();
                    break;

                case 2:
                    titleLabel.Text = "You missed your only chance to pass and you stay in P20 for the entire race.";
                    questionLabel.Text = "Play Again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    positionLabel.Text = "Position: 20/20";
                    SoundPlayer player1 = new SoundPlayer(Properties.Resources.wompwomp);
                    player1.Play();
                    break ;

                case 3:
                    titleLabel.Text = "You successfully overtake and move to P19.";
                    questionLabel.Text = "There is a big fight for P16 between you and 4 other drivers. Do you attempt to over take or stay where you are?";
                    option1Button.Text = "Overtake";
                    option2Button.Text = "Stay put";
                    option3Button.Text = "";
                    positionLabel.Text = "Position: 19/20";
                    SoundPlayer player14 = new SoundPlayer(Properties.Resources.passing_sound);
                    player14.Play();
                    break;

                case 4:
                    titleLabel.Text = "You waited far too long and P20 crashes into the back of your car. You both DNF";
                    questionLabel.Text = "Play Again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    positionLabel.Text = "Position: 19/20";
                    SoundPlayer player2 = new SoundPlayer(Properties.Resources.wompwomp);
                    player2.Play();
                    break;

                case 5:
                    titleLabel.Text = "You successfully win the fight and move to P16.";
                    questionLabel.Text = "It has started raining very heavily. Do you pit and get Wet tyres or stay out?";
                    option1Button.Text = "Stay out";
                    option2Button.Text = "Pit";
                    option3Button.Text = "";
                    positionLabel.Text = "Position: 16/20";
                    SoundPlayer player15 = new SoundPlayer(Properties.Resources.rain);
                    player15.Play();
                    break;

                case 6:
                    titleLabel.Text = "You crahed because the track is so slippery. Unfourtunatley you die and are burned beyond recognition";
                    questionLabel.Text = "Play Again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    positionLabel.Text = "Position: 16/20";
                    SoundPlayer player3 = new SoundPlayer(Properties.Resources.wompwomp);
                    player3.Play();
                    break;

                case 7:
                    titleLabel.Text = "You succesfully pit and are lucky enough to move up to P13 upon pit exit";
                    questionLabel.Text = "You see your enemy Max Verstappen ahead of you in P12. Do you try to overtake or stay put and let him pass P11?";
                    option1Button.Text = "Overtake";
                    option2Button.Text = "Stay Put";
                    option3Button.Text = "";
                    positionLabel.Text = "Position: 13/20";
                    SoundPlayer player13 = new SoundPlayer(Properties.Resources.max);
                    player13.Play();
                    break;

                case 8:
                    titleLabel.Text = "You accidentally rear end him and you both crash. He then prompty beats you up in the pits.";
                    questionLabel.Text = "Play Again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    positionLabel.Text = "Position: 13/20";
                    SoundPlayer player4 = new SoundPlayer(Properties.Resources.wompwomp);
                    player4.Play();
                    break;

                case 9:
                    titleLabel.Text = "You stay in P13 but you didnt risk crashing.";
                    questionLabel.Text = "You see a cloud of smoke ahead and lose all visibility ahead. Do you send it full speed into the smoke or play it cautious?";
                    option1Button.Text = "Send it";
                    option2Button.Text = "Slow Down";
                    option3Button.Text = "";
                    positionLabel.Text = "Position: 13/20";
                    SoundPlayer player22 = new SoundPlayer(Properties.Resources.f1pass);
                    player22.Play();
                    break;

                case 10:
                    titleLabel.Text = "A fast moving car behind you cant see and he crashes into you at 180 MPH. You are out of the race";
                    questionLabel.Text = "Play Again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    positionLabel.Text = "Position: 13/20";
                    SoundPlayer player5 = new SoundPlayer(Properties.Resources.wompwomp);
                    player5.Play();
                    break;

                case 11:
                    titleLabel.Text = "The driver in front of you was much farther ahead and you fly through the smoke without any problems.";
                    questionLabel.Text = "All of a sudden you see Lance Stroll coming quickly behind you. Do you defend or let him pass because he is much quicker.";
                    option1Button.Text = "Defend";
                    option2Button.Text = "Let him pass";
                    option3Button.Text = "";
                    positionLabel.Text = "Position: 10/20";
                    SoundPlayer player21 = new SoundPlayer(Properties.Resources.f1pass);
                    player21.Play();
                    break;

                case 12:
                    titleLabel.Text = "What did you expect it's Stroll he crashes into you and you both DNF.";
                    questionLabel.Text = "Play Again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    positionLabel.Text = "Position: 10/20";
                    SoundPlayer player6 = new SoundPlayer(Properties.Resources.wompwomp);
                    player6.Play();
                    break;

                case 13:
                    titleLabel.Text = "He's Stroll so naturally he crashes into the P9 Driver and they both hit the wall you advance to P9";
                    questionLabel.Text = "You see your Teammate Russell ahead. Do you pass him, ask the team for permission to pass him or stay put?";
                    option1Button.Text = "Overtake";
                    option2Button.Text = "Stay put";
                    option3Button.Text = "Ask";
                    positionLabel.Text = "Postion: 9/20";
                    SoundPlayer player16 = new SoundPlayer(Properties.Resources.Stroll_radio_I_m_in_the__wall_at_Saudi_Arabian_Grand_Prix_F1);
                    player16.Play();
                    break;

                case 14:
                    titleLabel.Text = "His battery dies and you accidentally rear end him";
                    questionLabel.Text = "Play Again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    positionLabel.Text = "Position: 9/20";
                    SoundPlayer player7 = new SoundPlayer(Properties.Resources.wompwomp);
                    player7.Play();
                    break;

                case 15:
                    titleLabel.Text = "His battery suddenly dies and you pass him easily P8";
                    questionLabel.Text = "There is a fight for P5 between you and three other drivers. Do you pass or wait";
                    option1Button.Text = "Stay Put";
                    option2Button.Text = "Overtake";
                    option3Button.Text = "";
                    positionLabel.Text = "Position: 8/20";
                    SoundPlayer player20 = new SoundPlayer(Properties.Resources.f1pass);
                    player20.Play();
                    break;

                case 16:
                    titleLabel.Text = "The team says you arent allowed to pass him and you stay in P9 the rest of the race";
                    questionLabel.Text = "Play Again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    positionLabel.Text = "Position: 9/20";
                    SoundPlayer player8 = new SoundPlayer(Properties.Resources.wompwomp);
                    player8.Play();
                    break;

                case 17:
                    titleLabel.Text = "All the cars in front of you crash and you advance to P5";
                    questionLabel.Text = "You Have the opportunity to pit. Do you stay out with you old tyres or do you get a change.";
                    option1Button.Text = "Dont pit";
                    option2Button.Text = "Pit";
                    option3Button.Text = "";
                    positionLabel.Text = "Position: 5/20";
                    SoundPlayer player19 = new SoundPlayer(Properties.Resources.crash);
                    player19.Play();
                    break;

                case 18:
                    titleLabel.Text = "You make a move to overtake but you crash into the current P5 and you die.";
                    questionLabel.Text = "Play Again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    positionLabel.Text = "Position: 8/20";
                    SoundPlayer player9 = new SoundPlayer(Properties.Resources.wompwomp);
                    player9.Play();
                    break;

                case 19:
                    titleLabel.Text = "Your pitcrew put the wrong tyres on and you lose because of it.";
                    questionLabel.Text = "Play Again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    positionLabel.Text = "Position: 5/20";
                    SoundPlayer player10 = new SoundPlayer(Properties.Resources.wompwomp);
                    player10.Play();
                    break;

                case 20:
                    titleLabel.Text = "You didnt pit and you ran out of fuel.";
                    questionLabel.Text = "Play Again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    positionLabel.Text = "Position: 5/20";
                    SoundPlayer player11 = new SoundPlayer(Properties.Resources.wompwomp);
                    player11.Play();
                    break;

                case 21:
                    titleLabel.Text = "You had the fastest pitstop in F1 histroy and you leave the pits P3.";
                    questionLabel.Text = "Its a final fight for P1 between you Max and Charles.";
                    option1Button.Text = "Stayput";
                    option2Button.Text = "Overtake";
                    option3Button.Text = "";
                    positionLabel.Text = "Position: 3/20";
                    SoundPlayer player18 = new SoundPlayer(Properties.Resources.pit);
                    player18.Play();
                    Refresh();
                    Thread.Sleep(1500);
                    questionLabel.Text = "Its a final fight for P1 between you Max and Charles.\n Do you overtake or stayput.";
                    break;
                     
                case 22:
                    titleLabel.Text = "You waited too long and you lost.";
                    questionLabel.Text = "Play Again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    positionLabel.Text = "Position: 3/20";
                    SoundPlayer player12 = new SoundPlayer(Properties.Resources.wompwomp);
                    player12.Play();
                    break;

                case 23:
                    titleLabel.Text = "The pass worked you win the GrandPrix.";
                    questionLabel.Text = "Play Again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    option3Button.Text = "";
                    positionLabel.Text = "Position: 1/20";
                    SoundPlayer player17 = new SoundPlayer(Properties.Resources.win);
                    player17.Play();
                    break;


                case 99:
                    titleLabel.Text = "Thanks for playing";
                    questionLabel.Text = "Have a nice day";
                    option1Button.Text = "";
                    option2Button.Text = "";
                    option3Button.Text = "";
                    positionLabel.Text = "";
                    SoundPlayer player23 = new SoundPlayer(Properties.Resources.f1intro);
                    player23.Play();
                    Thread.Sleep(1000);
                    Close();
                    break;
            }
        }
    }
}