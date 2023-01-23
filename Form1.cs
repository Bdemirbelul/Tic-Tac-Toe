namespace Tik_Tak_Toe
{
    public partial class Form1 : Form
    {
        int player1;
        int player2;
        char who = 'o';
        short movement = 0;
      
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
           
            if ( who == 'o')
            {
                

                bt.Text = "o";
                if ((button1.Text == button2.Text && button2.Text == button3.Text && button2.Text != "") ||
                    (button4.Text == button5.Text && button5.Text == button6.Text && button5.Text != "") ||
                    (button7.Text == button8.Text && button8.Text == button9.Text && button8.Text != "")||
                    (button1.Text == button4.Text && button4.Text == button7.Text && button4.Text != "")||
                    (button2.Text == button5.Text && button5.Text == button8.Text && button5.Text != "")||
                    (button3.Text == button6.Text && button6.Text == button9.Text && button6.Text != "")||
                    (button1.Text == button5.Text && button5.Text == button9.Text && button5.Text != "")||
                    (button1.Text == button2.Text && button2.Text == button3.Text && button2.Text != "")||
                    (button3.Text == button5.Text && button5.Text == button7.Text && button5.Text != ""))     
                {
                   
                  
                    MessageBox.Show("Player 1 wins !");
                    player1++;

                }


                bt.BackColor = Color.Red;
                who = 'x';
                movement++;
                

            }
           
            else if ( who == 'x')
            {
                bt.Text="x";
                if ((button1.Text == button2.Text && button2.Text == button3.Text && button2.Text != "") ||
                  (button4.Text == button5.Text && button5.Text == button6.Text && button5.Text != "") ||
                  (button7.Text == button8.Text && button8.Text == button9.Text && button8.Text != "") ||
                  (button1.Text == button4.Text && button4.Text == button7.Text && button4.Text != "") ||
                  (button2.Text == button5.Text && button5.Text == button8.Text && button5.Text != "") ||
                  (button3.Text == button6.Text && button6.Text == button9.Text && button6.Text != "") ||
                  (button1.Text == button5.Text && button5.Text == button9.Text && button5.Text != "") ||
                  (button1.Text == button2.Text && button2.Text == button3.Text && button2.Text != "") ||
                  (button3.Text == button5.Text && button5.Text == button7.Text && button5.Text != ""))
                {
               
               
                    MessageBox.Show("Player 2 wins !");
                    player2++;

                }
                bt.BackColor = Color.Green;
                who = 'o';
                movement++;
            }
            else if (movement == 7)
            {
                MessageBox.Show("Draw !");
            }
            movement++;
           
            label3.Text = player1.ToString();
            label4.Text = player2.ToString();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            who = 'o';
            movement = 0;
            button1.Enabled = true; button1.Text = "";
            button2.Enabled = true; button2.Text = "";
            button3.Enabled = true; button3.Text = "";
            button4.Enabled = true; button4.Text = "";
            button5.Enabled = true; button5.Text = "";
            button6.Enabled = true; button6.Text = "";
            button7.Enabled = true; button7.Text = "";
            button8.Enabled = true; button8.Text = "";
            button9.Enabled = true; button9.Text = "";
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
           
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           MessageBox.Show("This is a Tic Tac Toe game by balamir demirkan belul " , "Have Fun ", MessageBoxButtons.OK );
            //... . -. .. / ... . ...- .. -.-- --- .-. ..- -- / -. . .... .. .-.
        }
    }
}
