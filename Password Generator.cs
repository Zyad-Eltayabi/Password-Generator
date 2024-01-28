using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Password_Generator;

namespace Password_Generator
{

    public partial class Form1 : Form
    {
        Color mainTextColor = Color.FromArgb(230, 229, 234);
        Color passwordColor = Color.FromArgb(86, 85, 93);
        Color primaryColor = Color.FromArgb(174, 249, 186);
        Color orangeColor = Color.FromArgb(250, 206, 103);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lbPassword.ForeColor = passwordColor;
            lbLength.ForeColor = primaryColor;
            tbLength.ThumbColor = primaryColor;
            lbLevel.ForeColor = passwordColor;
            btnLevel1.BackColor = orangeColor;
            btnLevel2.BackColor = orangeColor;
        }

        public void ChangeLevelOfPassword()
        {

            if (Convert.ToInt32(lbLength.Text) < 9)
            {
                lbLevelName.Text = "Easy";
                btnLevel3.BackColor = Color.Transparent;
                btnLevel4.BackColor = Color.Transparent;
                btnLevel5.BackColor = Color.Transparent;
                btnLevel6.BackColor = Color.Transparent;
                return;
            }

            if (Convert.ToInt32(lbLength.Text) < 17)
            {
                lbLevelName.Text = "Medium";
                btnLevel3.BackColor = orangeColor;
                btnLevel4.BackColor = orangeColor;
                btnLevel5.BackColor = Color.Transparent;
                btnLevel6.BackColor = Color.Transparent;
                return;
            }

            if (Convert.ToInt32(lbLength.Text) < 25)
            {
                lbLevelName.Text = "Hard";
                btnLevel5.BackColor = orangeColor;
                btnLevel6.BackColor = orangeColor;
                return;
            }
        }
        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            lbLength.Text = tbLength.Value.ToString();
            ChangeLevelOfPassword();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (uppercase.Checked == false)
                uppercase.Checked = true;
            else
                uppercase.Checked = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (lowercase.Checked == false)
                lowercase.Checked = true;
            else
                lowercase.Checked = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (numbers.Checked == false)
                numbers.Checked = true;
            else
                numbers.Checked = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (symbols.Checked == false)
                symbols.Checked = true;
            else
                symbols.Checked = false;
        }

        public string ConfirmUserChecks()
        {
            string userChecks = "";

            if (uppercase.Checked)
                userChecks += "65:90,";

            if (lowercase.Checked)
                userChecks += "97:122,";

            if (numbers.Checked)
                userChecks += "48:57,";

            if (symbols.Checked)
                userChecks += "33:38,";

            userChecks = userChecks.Substring(0, userChecks.Length - 1);

            return userChecks;

        }

        public void Swap2Values(ref char char1, ref char char2)
        {
            char temp = char2;
            char2 = char1;
            char1 = temp;
        }

        public string ShufflePassword(string password)
        {
            char[] copyPassword = password.ToCharArray();

            Random rnd = new Random();

            for (int i = 0; i < copyPassword.Length; i++)
            {
                int randomIndex = rnd.Next(0, copyPassword.Length);

                Swap2Values(ref copyPassword[i], ref copyPassword[randomIndex]);
            }

            return new string(copyPassword);
        }

        public string GeneratePassword(string userChecks, int passwordLength)
        {
            string password = "";
            string[] splitUserChecks = userChecks.Split(',');
            int counter = 0;
            Random rnd = new Random();

            for (int i = 0; i < passwordLength; i++)
            {
                string[] splithOne = splitUserChecks[counter].Split(':');
                int generateOneCharacter = rnd.Next((Convert.ToInt32(splithOne[0])), (Convert.ToInt32(splithOne[1])));
                password += (char)generateOneCharacter;
                counter++;
                if (counter == splitUserChecks.Length)
                    counter = 0;
            }
            password = ShufflePassword(password);
            return password;
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!lowercase.Checked && !uppercase.Checked && !numbers.Checked && !symbols.Checked)
            {
                MessageBox.Show("Please choose at least one option", "Warning",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string userChecks = ConfirmUserChecks();
            string generatePassword = GeneratePassword(userChecks, Convert.ToInt32(lbLength.Text));
            lbPassword.Text = generatePassword;
            lbPassword.ForeColor = mainTextColor;

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if (lbPassword.Text != "Password Here")
            {
                MessageBox.Show("The message has been copied", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clipboard.SetText(lbPassword.Text);
            }
        }
    }


}
