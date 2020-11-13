using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Game
{
    public partial class SimpleGameForm : Form
    {
        Class_SimpleGame Class_obj = new Class_SimpleGame();

        public SimpleGameForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
   


        private void Load_button_Click(object sender, EventArgs e)
        {
            Class_obj.load();

           //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("Simple_Game.Resources.rename.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            picDisplay.Image = bmp_Object;
           
            //code to display sound in picture box on button click  

            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Properties.Resources.gun_cocking_01);

            Sound_Object.Play();

            spin_button.Enabled = true;
            Load_button.Enabled = false;



        }

        private void spin_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Class_obj.spin().ToString());

            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("Simple_Game.Resources.sspin.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            picDisplay.Image = bmp_Object;
          
            //code to display sound in picture box on button click  

            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Properties.Resources.gun_chamber);

            Sound_Object.Play();

            spin_button.Enabled = false;
            shoot_on_head_button.Enabled = true;
            shoot_away_button.Enabled = true;
        }

        private void shoot_on_head_button_Click(object sender, EventArgs e)
        {
            if (Class_obj.shoot() == 0)
            {
                MessageBox.Show("Try again");
            }
            else
            {
                MessageBox.Show("you don't have anthor chance");

            }
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("Simple_Game.Resources.gameshoot4.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

            picDisplay.Image = bmp_Object;

            //code to display sound in picture box on button click  

            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Properties.Resources.gun_gunshot_01);

            Sound_Object.Play();
        }

        private void shoot_away_button_Click(object sender, EventArgs e)
        {
            if (Class_obj.chance< 2)
            {
                if (Class_obj.shoot() == 0)
                {
                    MessageBox.Show("Hurrahh!!!! YOU win");
                    shoot_on_head_button.Enabled = false;
                    shoot_away_button.Enabled = false;

                }
                else
                {
                    Class_obj.chance++;
                if (Class_obj.chance == 2)
                  {
                        MessageBox.Show("Try again");
                        shoot_on_head_button.Enabled = false;
                        shoot_away_button.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("you don't have anthor chance");
                    }
                }


            }
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            Stream myStream = myAssembly.GetManifestResourceStream("Simple_Game.Resources.shootme.gif");

            Bitmap bmp_Object = new Bitmap(myStream);

          picDisplay.Image = bmp_Object;
            
            //code to display sound in picture box on button click  

            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Properties.Resources.shootsound);

            Sound_Object.Play();
        }

       
        private void Exit_button_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

       

        private void playagain_button(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
    }
    
    

