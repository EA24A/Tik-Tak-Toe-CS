using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {

        public int randomRange = 10;
        public int generatedBox;
        public int turns;

        int círculoCounter;
        int yaeburCounter;

        public bool player1Turn;
        public bool player2Turn;

        public string player1 = "Spieler 1 ";
        public string player2 = "Spieler 2 ";

        public string o = "O";
        public string x = "X";

        public List<Button> row1 = new List<Button>();
        public List<Button> row2 = new List<Button>();
        public List<Button> row3 = new List<Button>();
        public List<Button> row4 = new List<Button>();
        public List<Button> row5 = new List<Button>();
        public List<Button> row6 = new List<Button>();
        public List<Button> row7 = new List<Button>();
        public List<Button> row8 = new List<Button>();

        public List<List<Button>> fields = new List<List<Button>>();

        public Form1()
        {
            InitializeComponent();
            loadLists();
            winnerLabel.Visible = false;
            player1Turn = true;
            player2Turn = false;
            infoLabel.Text = "Das Spiel hat begonnen! " + player1 + "ist am Zug!";
            Text = "Tic Tac Toe";
        }

        public void loadLists()
        {
            row1 = new List<Button>() { field1, field2, field3 };
            row2 = new List<Button>() { field4, field5, field6 };
            row3 = new List<Button>() { field7, field8, field9 };

            row4 = new List<Button>() { field1, field4, field7 };
            row5 = new List<Button>() { field2, field5, field8 };
            row6 = new List<Button>() { field3, field6, field9 };

            row7 = new List<Button>() { field1, field5, field9 };
            row8 = new List<Button>() { field3, field5, field7 };

            fields = new List<List<Button>>() { row1, row2, row3, row4, row5, row6, row7, row8 };
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boxClickEvent(object sender, EventArgs e)
        {
            if (player1Turn == true)
            {
                if((sender as Button).Text.Length == 0)
                {
                    turns++;
                    (sender as Button).Text = o;
                    (sender as Button).ForeColor = Color.Blue;
                    player1Turn = false;
                    player2Turn = true;
                    infoLabel.Text = player2 + "ist am Zug!";
                    checkBoxes();

                }

            }
            else if (player2Turn == true)
            {
                if ((sender as Button).Text.Length == 0)
                {
                    turns++;
                    (sender as Button).Text = x;
                    (sender as Button).ForeColor = Color.Red;
                    player1Turn = true;
                    player2Turn = false;
                    infoLabel.Text = player1 + "ist am Zug!";
                    checkBoxes();
                }
            }

            if (turns == 9)
            {
                infoLabel.Text = "Unentschieden!";
                stopGame();
            }
            checkBoxes();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void checkBoxes()
        {
            for (int i = 0; i < 3; i++)
            {
                if (fields[i][0].Text == fields[i][1].Text && fields[i][1].Text == fields[i][2].Text)
                {
                    if (fields[i][0].Text == "O")
                    {
                        infoLabel.Text = player1 + "hat gewonnen!";
                        player1Win();
                        stopGame();
                        
                    }
                    else if (fields[i][0].Text == "X")
                    {
                        infoLabel.Text = player2 + "hat gewonnen!";
                        player2Win();
                        stopGame();
                    }
                    return;
                }
            }

            for (int j = 0; j < 3; j++)
            {
                if (fields[0][j].Text == fields[1][j].Text && fields[1][j].Text == fields[2][j].Text)
                {
                    if (fields[0][j].Text == "O")
                    {
                        infoLabel.Text = player1 + "hat gewonnen!";
                        player1Win();
                        stopGame();

                    }
                    else if (fields[0][j].Text == "X")
                    {
                        infoLabel.Text = player2 + "hat gewonnen!";
                        player2Win();
                        stopGame();
                    }
                    return;
                }
            }

            if (fields[0][0].Text == fields[1][1].Text && fields[1][1].Text == fields[2][2].Text)
            {
                if (fields[0][0].Text == "O")
                {
                    infoLabel.Text = player1 + "hat gewonnen!";
                    player1Win();
                    stopGame();
                }
                else if (fields[0][0].Text == "X")
                {
                    infoLabel.Text = player2 + "hat gewonnen!";
                    player2Win();
                    stopGame();
                }
                return;
            }

            if (fields[0][2].Text == fields[1][1].Text && fields[1][1].Text == fields[2][0].Text)
            {
                if (fields[0][2].Text == "O")
                {
                    infoLabel.Text = player1 + "hat gewonnen!";
                    player1Win();
                    stopGame();
                }
                else if (fields[0][2].Text == "X")
                {
                    infoLabel.Text = player2 + "hat gewonnen!";
                    player2Win();
                    stopGame();
                }
                return;
            }
            
            

        }


        private void pn1Text_Click(object sender, EventArgs e)
        {
            player1 = pn1Text.Text + " ";
            if (player1 == " ")
                player1 = "Spieler 1 ";
            infoLabel.Text = infoLabel.Text;
        }

        private void pn2Name_Click(object sender, EventArgs e)
        {
            player2 = pn2Name.Text + " ";
            if (player2 == " ")
                player2 = "Spieler 2 ";
            infoLabel.Text = infoLabel.Text;
        }

        private void zurücksetzenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        public void resetGame()
        {
            turns = 0;
            field1.Enabled = true;
            field2.Enabled = true;
            field3.Enabled = true;
            field4.Enabled = true;
            field5.Enabled = true;
            field6.Enabled = true;
            field7.Enabled = true;
            field8.Enabled = true;
            field9.Enabled = true;
            field1.Visible = true;
            field2.Visible = true;
            field3.Visible = true;
            field4.Visible = true;
            field5.Visible = true;
            field6.Visible = true;
            field7.Visible = true;
            field8.Visible = true;
            field9.Visible = true;
            winnerLabel.Visible = false;
            field1.ForeColor = Color.Black;
            field2.ForeColor = Color.Black;
            field3.ForeColor = Color.Black;
            field4.ForeColor = Color.Black;
            field5.ForeColor = Color.Black;
            field6.ForeColor = Color.Black;
            field7.ForeColor = Color.Black;
            field8.ForeColor = Color.Black;
            field9.ForeColor = Color.Black;
            field1.Text = "";
            field2.Text = "";
            field3.Text = "";
            field4.Text = "";
            field5.Text = "";
            field6.Text = "";
            field7.Text = "";
            field8.Text = "";
            field9.Text = "";
            infoLabel.Text = "Das Spiel wurde zurückgesetzt! " + player1 + "ist am Zug!";
            player1Turn = true;
            player2Turn = false;
        }

        public void stopGame()
        {
            turns = 0;
            field1.Enabled = false;
            field2.Enabled = false;
            field3.Enabled = false;
            field4.Enabled = false;
            field5.Enabled = false;
            field6.Enabled = false;
            field7.Enabled = false;
            field8.Enabled = false;
            field9.Enabled = false;
        }

        public void player1Win()
        {
            field1.Visible = false;
            field2.Visible = false;
            field3.Visible = false;
            field4.Visible = false;
            field5.Visible = false;
            field6.Visible = false;
            field7.Visible = false;
            field8.Visible = false;
            field9.Visible = false;
            winnerLabel.Visible = true;
            winnerLabel.ForeColor = Color.Lime;
            winnerLabel.Text = player1 + "hat gewonnen!";
        }

        public void player2Win()
        {
            field1.Visible = false;
            field2.Visible = false;
            field3.Visible = false;
            field4.Visible = false;
            field5.Visible = false;
            field6.Visible = false;
            field7.Visible = false;
            field8.Visible = false;
            field9.Visible = false;
            winnerLabel.Visible = true;
            winnerLabel.ForeColor = Color.Lime;
            winnerLabel.Text = player2 + "hat gewonnen!";
        }

    }
}
