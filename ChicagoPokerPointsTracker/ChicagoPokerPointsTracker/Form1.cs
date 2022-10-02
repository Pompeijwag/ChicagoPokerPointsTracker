namespace ChicagoPokerPointsTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button[] action = new Button[79];
        TextBox[] deduction = new TextBox[7];
        Label[] score = new Label[7];
        public static int pressed = 0;
        int[] scores = new int[7];
        public static int finished = 0;
        private void addpoints(object sender, EventArgs e)
        {
            int player = 0, scoring = 0, minus = 0;
            for (int i = 1; i < 79; i++)
            {
                if(action[i] == sender)
                {
                    pressed = i;
                }
            }
            player = ((pressed - 1) / 13) + 1;
            scoring = pressed % 13;
            switch (scoring)
            {
                case 1:
                    scores[player] = scores[player] + 1;
                    break;
                case 2:
                    scores[player] = scores[player] + 2;
                    break;
                case 3:
                    scores[player] = scores[player] + 3;
                    break;
                case 4:
                    scores[player] = scores[player] + 4;
                    break;
                case 5:
                    scores[player] = scores[player] + 5;
                    break;
                case 6:
                    scores[player] = scores[player] + 6;
                    break;
                case 7:
                    scores[player] = scores[player] + 8;
                    break;
                case 8:
                    for (int i = 1; i <= 6; i++)
                    {
                        if (i != player)
                        {
                            scores[i] = 0;
                        }
                    }
                    break;
                case 9:
                    scores[player] = scores[player] + 5;
                    break;
                case 10:
                    scores[player] = scores[player] + 52;
                    break;
                case 11:
                    scores[player] = scores[player] + 15;
                    break;
                case 12:
                    scores[player] = scores[player] - 15;
                    break;
                default:
                    if (deduction[player].Text != "")
                    {
                        minus = Convert.ToInt32(deduction[player].Text);
                        scores[player] = scores[player] - minus;
                        deduction[player].Text = "";
                    }
                    break;
            }
            for (int i = 1; i <= 6; i++)
            {
                score[i].Text = Convert.ToString(scores[i]);
            }
            int unfinished = 0;
            for (int i = 1; i <= 6; i++)
            {
                if(scores[i] >= 52)
                {
                    score[i].ForeColor = Color.ForestGreen;
                    finished = 1;
                }
                if(scores[i] < 52)
                {
                    score[i].ForeColor = SystemColors.ControlText;
                    unfinished++;
                }
            }
            if (finished == 1)
            {
                button80.Visible = true;
            }
            if (unfinished == 6)
            {
                button80.Visible = false;
                finished = 0;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            score[1] = label1;
            score[2] = label2;
            score[3] = label3;
            score[4] = label4;
            score[5] = label5;
            score[6] = label6;
            deduction[1] = textBox7;
            deduction[2] = textBox8;
            deduction[3] = textBox9;
            deduction[4] = textBox10;
            deduction[5] = textBox11;
            deduction[6] = textBox12;
            action[1] = button1;
            action[2] = button2;
            action[3] = button3;
            action[4] = button4;
            action[5] = button5;
            action[6] = button6;
            action[7] = button7;
            action[8] = button8;
            action[9] = button9;
            action[10] = button10;
            action[11] = button11;
            action[12] = button12;
            action[13] = button13;
            action[14] = button14;
            action[15] = button15;
            action[16] = button16;
            action[17] = button17;
            action[18] = button18;
            action[19] = button19;
            action[20] = button20;
            action[21] = button21;
            action[22] = button22;
            action[23] = button23;
            action[24] = button24;
            action[25] = button25;
            action[26] = button26;
            action[27] = button27;
            action[28] = button28;
            action[29] = button29;
            action[30] = button30;
            action[31] = button31;
            action[32] = button32;
            action[33] = button33;
            action[34] = button34;
            action[35] = button35;
            action[36] = button36;
            action[37] = button37;
            action[38] = button38;
            action[39] = button39;
            action[40] = button40;
            action[41] = button41;
            action[42] = button42;
            action[43] = button43;
            action[44] = button44;
            action[45] = button45;
            action[46] = button46;
            action[47] = button47;
            action[48] = button48;
            action[49] = button49;
            action[50] = button50;
            action[51] = button51;
            action[52] = button52;
            action[53] = button53;
            action[54] = button54;
            action[55] = button55;
            action[56] = button56;
            action[57] = button57;
            action[58] = button58;
            action[59] = button59;
            action[60] = button60;
            action[61] = button61;
            action[62] = button62;
            action[63] = button63;
            action[64] = button64;
            action[65] = button65;
            action[66] = button66;
            action[67] = button67;
            action[68] = button68;
            action[69] = button69;
            action[70] = button70;
            action[71] = button71;
            action[72] = button72;
            action[73] = button73;
            action[74] = button74;
            action[75] = button75;
            action[76] = button76;
            action[77] = button77;
            action[78] = button78;
            for (int i = 1; i < 79; i++)
            {
                action[i].Click += addpoints;
            }

        }

        private void button79_Click(object sender, EventArgs e)
        {
            int players = 0;
            if (textBox1.Text != "")
            {
                players++;
            }
            if (textBox2.Text != "")
            {
                players++;
            }
            if (textBox3.Text != "")
            {
                players++;
            }
            if (textBox4.Text != "")
            {
                players++;
            }
            if (textBox5.Text != "")
            {
                players++;
            }
            if (textBox6.Text != "")
            {
                players++;
            }
            if (players >= 2)
            {
                if (textBox1.Text != "")
                {
                    for (int i = 1; i <= 13; i++)
                    {
                        action[i].Enabled = true;
                    }
                }
                if (textBox2.Text != "")
                {
                    for (int i = 14; i <= 26; i++)
                    {
                        action[i].Enabled = true;
                    }
                }
                if (textBox3.Text != "")
                {
                    for (int i = 27; i <= 39; i++)
                    {
                        action[i].Enabled = true;
                    }
                }
                if (textBox4.Text != "")
                {
                    for (int i = 40; i <= 52; i++)
                    {
                        action[i].Enabled = true;
                    }
                }
                if (textBox5.Text != "")
                {
                    for (int i = 53; i <= 65; i++)
                    {
                        action[i].Enabled = true;
                    }
                }
                if (textBox6.Text != "")
                {
                    for (int i = 66; i <= 78; i++)
                    {
                        action[i].Enabled = true;
                    }
                }
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                button79.Visible = false;
            }
            
        }

        private void button80_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 6; i++)
            {
                scores[i] = 0;
                score[i].Text = Convert.ToString(scores[i]);
                score[i].ForeColor = SystemColors.ControlText;
                finished = 0;
                button80.Visible = false;
            }
        }
    }
}