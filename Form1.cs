namespace Presence_Days_Calculator
{
    public partial class PresenceDaysCalculator : Form
    {
        public PresenceDaysCalculator()
        {
            InitializeComponent();
        }

        private void PresenceDaysCalculator_FormClosing1(object? sender, FormClosingEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void monthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (e.KeyChar != '\b')
            {
                string newText = ((TextBox)sender).Text + e.KeyChar;

                if (!int.TryParse(newText, out int number) || number > 21 || newText.Length > 2)
                {
                    e.Handled = true;
                }
            }
        }

        private void CalculateDays()
        {
            try
            {
                int daysPresent = int.Parse(monthTextBox1.Text) + int.Parse(monthTextBox2.Text) + int.Parse(monthTextBox3.Text) + int.Parse(monthTextBox4.Text) + int.Parse(monthTextBox5.Text) + int.Parse(monthTextBox6.Text) + int.Parse(monthTextBox7.Text) + int.Parse(monthTextBox8.Text) + int.Parse(monthTextBox9.Text) + int.Parse(monthTextBox10.Text) + int.Parse(monthTextBox11.Text) + int.Parse(monthTextBox12.Text) + int.Parse(monthTextBox13.Text) + int.Parse(monthTextBox14.Text) + int.Parse(monthTextBox15.Text);

                daysLeftLabel.Text = $"Presence days so far: {daysPresent}";

                if (daysPresent >= 131)
                {
                    MessageBox.Show("Congratulations!\nYou've met the required days set by the German IHK.");
                    daysLeftLabel.Text += $"\n\nNo more days required!";
                }
                else
                {
                    int daysRemaining = 131 - daysPresent;
                    MessageBox.Show($"The German IHK requires you to attend {daysRemaining} more days to be eligible for the final exams.");
                    daysLeftLabel.Text += $"\n\n{daysRemaining} days still required";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR: Please ensure that each month has a corresponding number of present days. (use 0 for none/none yet)");
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            CalculateDays();
        }

        private void monthTextBox_Click(object sender, EventArgs e)
        {
            TextBox clickedTextBox = (TextBox)sender;
            if (clickedTextBox.Text == "0")
            {
                clickedTextBox.Text = "";
            }
        }

        private void saveValuesButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.LastUsedValue1 = monthTextBox1.Text;
            Properties.Settings.Default.LastUsedValue2 = monthTextBox2.Text;
            Properties.Settings.Default.LastUsedValue3 = monthTextBox3.Text;
            Properties.Settings.Default.LastUsedValue4 = monthTextBox4.Text;
            Properties.Settings.Default.LastUsedValue5 = monthTextBox5.Text;
            Properties.Settings.Default.LastUsedValue6 = monthTextBox6.Text;
            Properties.Settings.Default.LastUsedValue7 = monthTextBox7.Text;
            Properties.Settings.Default.LastUsedValue8 = monthTextBox8.Text;
            Properties.Settings.Default.LastUsedValue9 = monthTextBox9.Text;
            Properties.Settings.Default.LastUsedValue10 = monthTextBox10.Text;
            Properties.Settings.Default.LastUsedValue11 = monthTextBox11.Text;
            Properties.Settings.Default.LastUsedValue12 = monthTextBox12.Text;
            Properties.Settings.Default.LastUsedValue13 = monthTextBox13.Text;
            Properties.Settings.Default.LastUsedValue14 = monthTextBox14.Text;
            Properties.Settings.Default.LastUsedValue15 = monthTextBox15.Text;

            Properties.Settings.Default.Save();

            MessageBox.Show("Values successfully saved.");
        }

        private void loadValuesButton_Click(object sender, EventArgs e)
        {
            monthTextBox1.Text = Properties.Settings.Default.LastUsedValue1;
            monthTextBox2.Text = Properties.Settings.Default.LastUsedValue2;
            monthTextBox3.Text = Properties.Settings.Default.LastUsedValue3;
            monthTextBox4.Text = Properties.Settings.Default.LastUsedValue4;
            monthTextBox5.Text = Properties.Settings.Default.LastUsedValue5;
            monthTextBox6.Text = Properties.Settings.Default.LastUsedValue6;
            monthTextBox7.Text = Properties.Settings.Default.LastUsedValue7;
            monthTextBox8.Text = Properties.Settings.Default.LastUsedValue8;
            monthTextBox9.Text = Properties.Settings.Default.LastUsedValue9;
            monthTextBox10.Text = Properties.Settings.Default.LastUsedValue10;
            monthTextBox11.Text = Properties.Settings.Default.LastUsedValue11;
            monthTextBox12.Text = Properties.Settings.Default.LastUsedValue12;
            monthTextBox13.Text = Properties.Settings.Default.LastUsedValue13;
            monthTextBox14.Text = Properties.Settings.Default.LastUsedValue14;
            monthTextBox15.Text = Properties.Settings.Default.LastUsedValue15;

            MessageBox.Show("Values successfully loaded.");
            CalculateDays();
        }
    }
}