namespace Presence_Days_Calculator
{
    partial class PresenceDaysCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresenceDaysCalculator));
            detailsPanel = new Panel();
            detailsLabel = new Label();
            presencePanel = new Panel();
            monthTextBox15 = new TextBox();
            monthTextBox14 = new TextBox();
            monthTextBox13 = new TextBox();
            monthTextBox12 = new TextBox();
            monthTextBox11 = new TextBox();
            monthTextBox10 = new TextBox();
            monthTextBox9 = new TextBox();
            monthTextBox7 = new TextBox();
            monthTextBox6 = new TextBox();
            monthTextBox5 = new TextBox();
            monthTextBox4 = new TextBox();
            monthTextBox3 = new TextBox();
            monthTextBox2 = new TextBox();
            monthTextBox8 = new TextBox();
            monthTextBox1 = new TextBox();
            presenceLabel = new Label();
            daysLeftPanel = new Panel();
            daysLeftLabel = new Label();
            calculateButton = new Button();
            saveValuesButton = new Button();
            loadValuesButton = new Button();
            detailsPanel.SuspendLayout();
            presencePanel.SuspendLayout();
            daysLeftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // detailsPanel
            // 
            detailsPanel.BackgroundImage = Properties.Resources.gray_concrete_wall_with_scratches;
            detailsPanel.BackgroundImageLayout = ImageLayout.Stretch;
            detailsPanel.BorderStyle = BorderStyle.FixedSingle;
            detailsPanel.Controls.Add(detailsLabel);
            detailsPanel.ForeColor = SystemColors.ControlText;
            detailsPanel.Location = new Point(12, 12);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.Size = new Size(365, 244);
            detailsPanel.TabIndex = 2;
            // 
            // detailsLabel
            // 
            detailsLabel.BackColor = Color.Transparent;
            detailsLabel.Font = new Font("Felix Titling", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            detailsLabel.ForeColor = SystemColors.ControlText;
            detailsLabel.Location = new Point(3, 10);
            detailsLabel.Name = "detailsLabel";
            detailsLabel.Size = new Size(357, 232);
            detailsLabel.TabIndex = 0;
            detailsLabel.Text = resources.GetString("detailsLabel.Text");
            // 
            // presencePanel
            // 
            presencePanel.BackgroundImage = Properties.Resources.gray_concrete_wall_with_scratches;
            presencePanel.BackgroundImageLayout = ImageLayout.Stretch;
            presencePanel.BorderStyle = BorderStyle.FixedSingle;
            presencePanel.Controls.Add(monthTextBox15);
            presencePanel.Controls.Add(monthTextBox14);
            presencePanel.Controls.Add(monthTextBox13);
            presencePanel.Controls.Add(monthTextBox12);
            presencePanel.Controls.Add(monthTextBox11);
            presencePanel.Controls.Add(monthTextBox10);
            presencePanel.Controls.Add(monthTextBox9);
            presencePanel.Controls.Add(monthTextBox7);
            presencePanel.Controls.Add(monthTextBox6);
            presencePanel.Controls.Add(monthTextBox5);
            presencePanel.Controls.Add(monthTextBox4);
            presencePanel.Controls.Add(monthTextBox3);
            presencePanel.Controls.Add(monthTextBox2);
            presencePanel.Controls.Add(monthTextBox8);
            presencePanel.Controls.Add(monthTextBox1);
            presencePanel.Controls.Add(presenceLabel);
            presencePanel.ForeColor = SystemColors.ControlText;
            presencePanel.Location = new Point(423, 12);
            presencePanel.Name = "presencePanel";
            presencePanel.Size = new Size(365, 244);
            presencePanel.TabIndex = 3;
            // 
            // monthTextBox15
            // 
            monthTextBox15.BackColor = SystemColors.ScrollBar;
            monthTextBox15.BorderStyle = BorderStyle.FixedSingle;
            monthTextBox15.Cursor = Cursors.IBeam;
            monthTextBox15.Location = new Point(212, 183);
            monthTextBox15.MaxLength = 2;
            monthTextBox15.Name = "monthTextBox15";
            monthTextBox15.Size = new Size(20, 23);
            monthTextBox15.TabIndex = 15;
            monthTextBox15.Text = "0";
            monthTextBox15.Click += monthTextBox_Click;
            monthTextBox15.KeyPress += monthTextBox_KeyPress;
            // 
            // monthTextBox14
            // 
            monthTextBox14.BackColor = SystemColors.ScrollBar;
            monthTextBox14.BorderStyle = BorderStyle.FixedSingle;
            monthTextBox14.Cursor = Cursors.IBeam;
            monthTextBox14.Location = new Point(212, 154);
            monthTextBox14.MaxLength = 2;
            monthTextBox14.Name = "monthTextBox14";
            monthTextBox14.Size = new Size(20, 23);
            monthTextBox14.TabIndex = 14;
            monthTextBox14.Text = "0";
            monthTextBox14.Click += monthTextBox_Click;
            monthTextBox14.KeyPress += monthTextBox_KeyPress;
            // 
            // monthTextBox13
            // 
            monthTextBox13.BackColor = SystemColors.ScrollBar;
            monthTextBox13.BorderStyle = BorderStyle.FixedSingle;
            monthTextBox13.Cursor = Cursors.IBeam;
            monthTextBox13.Location = new Point(212, 125);
            monthTextBox13.MaxLength = 2;
            monthTextBox13.Name = "monthTextBox13";
            monthTextBox13.Size = new Size(20, 23);
            monthTextBox13.TabIndex = 13;
            monthTextBox13.Text = "0";
            monthTextBox13.Click += monthTextBox_Click;
            monthTextBox13.KeyPress += monthTextBox_KeyPress;
            // 
            // monthTextBox12
            // 
            monthTextBox12.BackColor = SystemColors.ScrollBar;
            monthTextBox12.BorderStyle = BorderStyle.FixedSingle;
            monthTextBox12.Cursor = Cursors.IBeam;
            monthTextBox12.Location = new Point(212, 96);
            monthTextBox12.MaxLength = 2;
            monthTextBox12.Name = "monthTextBox12";
            monthTextBox12.Size = new Size(20, 23);
            monthTextBox12.TabIndex = 12;
            monthTextBox12.Text = "0";
            monthTextBox12.Click += monthTextBox_Click;
            monthTextBox12.KeyPress += monthTextBox_KeyPress;
            // 
            // monthTextBox11
            // 
            monthTextBox11.BackColor = SystemColors.ScrollBar;
            monthTextBox11.BorderStyle = BorderStyle.FixedSingle;
            monthTextBox11.Cursor = Cursors.IBeam;
            monthTextBox11.Location = new Point(212, 67);
            monthTextBox11.MaxLength = 2;
            monthTextBox11.Name = "monthTextBox11";
            monthTextBox11.Size = new Size(20, 23);
            monthTextBox11.TabIndex = 11;
            monthTextBox11.Text = "0";
            monthTextBox11.Click += monthTextBox_Click;
            monthTextBox11.KeyPress += monthTextBox_KeyPress;
            // 
            // monthTextBox10
            // 
            monthTextBox10.BackColor = SystemColors.ScrollBar;
            monthTextBox10.BorderStyle = BorderStyle.FixedSingle;
            monthTextBox10.Cursor = Cursors.IBeam;
            monthTextBox10.Location = new Point(212, 38);
            monthTextBox10.MaxLength = 2;
            monthTextBox10.Name = "monthTextBox10";
            monthTextBox10.Size = new Size(20, 23);
            monthTextBox10.TabIndex = 10;
            monthTextBox10.Text = "0";
            monthTextBox10.Click += monthTextBox_Click;
            monthTextBox10.KeyPress += monthTextBox_KeyPress;
            // 
            // monthTextBox9
            // 
            monthTextBox9.BackColor = SystemColors.ScrollBar;
            monthTextBox9.BorderStyle = BorderStyle.FixedSingle;
            monthTextBox9.Cursor = Cursors.IBeam;
            monthTextBox9.Location = new Point(212, 9);
            monthTextBox9.MaxLength = 2;
            monthTextBox9.Name = "monthTextBox9";
            monthTextBox9.Size = new Size(20, 23);
            monthTextBox9.TabIndex = 9;
            monthTextBox9.Text = "0";
            monthTextBox9.Click += monthTextBox_Click;
            monthTextBox9.KeyPress += monthTextBox_KeyPress;
            // 
            // monthTextBox7
            // 
            monthTextBox7.BackColor = SystemColors.ScrollBar;
            monthTextBox7.BorderStyle = BorderStyle.FixedSingle;
            monthTextBox7.Cursor = Cursors.IBeam;
            monthTextBox7.Location = new Point(12, 183);
            monthTextBox7.MaxLength = 2;
            monthTextBox7.Name = "monthTextBox7";
            monthTextBox7.Size = new Size(20, 23);
            monthTextBox7.TabIndex = 8;
            monthTextBox7.Text = "0";
            monthTextBox7.Click += monthTextBox_Click;
            monthTextBox7.KeyPress += monthTextBox_KeyPress;
            // 
            // monthTextBox6
            // 
            monthTextBox6.BackColor = SystemColors.ScrollBar;
            monthTextBox6.BorderStyle = BorderStyle.FixedSingle;
            monthTextBox6.Cursor = Cursors.IBeam;
            monthTextBox6.Location = new Point(12, 154);
            monthTextBox6.MaxLength = 2;
            monthTextBox6.Name = "monthTextBox6";
            monthTextBox6.Size = new Size(20, 23);
            monthTextBox6.TabIndex = 7;
            monthTextBox6.Text = "0";
            monthTextBox6.Click += monthTextBox_Click;
            monthTextBox6.KeyPress += monthTextBox_KeyPress;
            // 
            // monthTextBox5
            // 
            monthTextBox5.BackColor = SystemColors.ScrollBar;
            monthTextBox5.BorderStyle = BorderStyle.FixedSingle;
            monthTextBox5.Cursor = Cursors.IBeam;
            monthTextBox5.Location = new Point(12, 125);
            monthTextBox5.MaxLength = 2;
            monthTextBox5.Name = "monthTextBox5";
            monthTextBox5.Size = new Size(20, 23);
            monthTextBox5.TabIndex = 6;
            monthTextBox5.Text = "0";
            monthTextBox5.Click += monthTextBox_Click;
            monthTextBox5.KeyPress += monthTextBox_KeyPress;
            // 
            // monthTextBox4
            // 
            monthTextBox4.BackColor = SystemColors.ScrollBar;
            monthTextBox4.BorderStyle = BorderStyle.FixedSingle;
            monthTextBox4.Cursor = Cursors.IBeam;
            monthTextBox4.Location = new Point(12, 96);
            monthTextBox4.MaxLength = 2;
            monthTextBox4.Name = "monthTextBox4";
            monthTextBox4.Size = new Size(20, 23);
            monthTextBox4.TabIndex = 5;
            monthTextBox4.Text = "0";
            monthTextBox4.Click += monthTextBox_Click;
            monthTextBox4.KeyPress += monthTextBox_KeyPress;
            // 
            // monthTextBox3
            // 
            monthTextBox3.BackColor = SystemColors.ScrollBar;
            monthTextBox3.BorderStyle = BorderStyle.FixedSingle;
            monthTextBox3.Cursor = Cursors.IBeam;
            monthTextBox3.Location = new Point(12, 67);
            monthTextBox3.MaxLength = 2;
            monthTextBox3.Name = "monthTextBox3";
            monthTextBox3.Size = new Size(20, 23);
            monthTextBox3.TabIndex = 4;
            monthTextBox3.Text = "0";
            monthTextBox3.Click += monthTextBox_Click;
            monthTextBox3.KeyPress += monthTextBox_KeyPress;
            // 
            // monthTextBox2
            // 
            monthTextBox2.BackColor = SystemColors.ScrollBar;
            monthTextBox2.BorderStyle = BorderStyle.FixedSingle;
            monthTextBox2.Cursor = Cursors.IBeam;
            monthTextBox2.Location = new Point(12, 38);
            monthTextBox2.MaxLength = 2;
            monthTextBox2.Name = "monthTextBox2";
            monthTextBox2.Size = new Size(20, 23);
            monthTextBox2.TabIndex = 3;
            monthTextBox2.Text = "0";
            monthTextBox2.Click += monthTextBox_Click;
            monthTextBox2.KeyPress += monthTextBox_KeyPress;
            // 
            // monthTextBox8
            // 
            monthTextBox8.BackColor = SystemColors.ScrollBar;
            monthTextBox8.BorderStyle = BorderStyle.FixedSingle;
            monthTextBox8.Cursor = Cursors.IBeam;
            monthTextBox8.Location = new Point(12, 212);
            monthTextBox8.MaxLength = 2;
            monthTextBox8.Name = "monthTextBox8";
            monthTextBox8.Size = new Size(20, 23);
            monthTextBox8.TabIndex = 2;
            monthTextBox8.Text = "0";
            monthTextBox8.Click += monthTextBox_Click;
            monthTextBox8.KeyPress += monthTextBox_KeyPress;
            // 
            // monthTextBox1
            // 
            monthTextBox1.BackColor = SystemColors.ScrollBar;
            monthTextBox1.BorderStyle = BorderStyle.FixedSingle;
            monthTextBox1.Cursor = Cursors.IBeam;
            monthTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            monthTextBox1.Location = new Point(12, 9);
            monthTextBox1.MaxLength = 2;
            monthTextBox1.Name = "monthTextBox1";
            monthTextBox1.Size = new Size(20, 23);
            monthTextBox1.TabIndex = 0;
            monthTextBox1.Text = "0";
            monthTextBox1.Click += monthTextBox_Click;
            monthTextBox1.KeyPress += monthTextBox_KeyPress;
            // 
            // presenceLabel
            // 
            presenceLabel.BackColor = Color.Transparent;
            presenceLabel.Font = new Font("Felix Titling", 18.75F, FontStyle.Regular, GraphicsUnit.Point);
            presenceLabel.ForeColor = SystemColors.ControlText;
            presenceLabel.Location = new Point(3, 5);
            presenceLabel.Name = "presenceLabel";
            presenceLabel.Size = new Size(357, 232);
            presenceLabel.TabIndex = 1;
            presenceLabel.Text = resources.GetString("presenceLabel.Text");
            // 
            // daysLeftPanel
            // 
            daysLeftPanel.BackgroundImage = Properties.Resources.gray_concrete_wall_with_scratches;
            daysLeftPanel.BackgroundImageLayout = ImageLayout.Stretch;
            daysLeftPanel.BorderStyle = BorderStyle.FixedSingle;
            daysLeftPanel.Controls.Add(daysLeftLabel);
            daysLeftPanel.ForeColor = SystemColors.ControlText;
            daysLeftPanel.Location = new Point(252, 356);
            daysLeftPanel.Name = "daysLeftPanel";
            daysLeftPanel.Size = new Size(299, 72);
            daysLeftPanel.TabIndex = 4;
            // 
            // daysLeftLabel
            // 
            daysLeftLabel.BackColor = Color.Transparent;
            daysLeftLabel.Font = new Font("Felix Titling", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            daysLeftLabel.ForeColor = SystemColors.ControlText;
            daysLeftLabel.Location = new Point(3, 8);
            daysLeftLabel.Name = "daysLeftLabel";
            daysLeftLabel.Size = new Size(291, 62);
            daysLeftLabel.TabIndex = 7;
            daysLeftLabel.Text = "Here you'll be able to see the total number of days you've been present in the classroom, and how many you still need.";
            // 
            // calculateButton
            // 
            calculateButton.BackColor = SystemColors.ActiveCaptionText;
            calculateButton.BackgroundImage = Properties.Resources.old_black_background_grunge_texture_dark_wallpaper_blackboard_chalkboard_room_wall;
            calculateButton.BackgroundImageLayout = ImageLayout.Stretch;
            calculateButton.Cursor = Cursors.Hand;
            calculateButton.FlatAppearance.BorderColor = Color.Black;
            calculateButton.FlatStyle = FlatStyle.Popup;
            calculateButton.Font = new Font("Chiller", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            calculateButton.ForeColor = SystemColors.HighlightText;
            calculateButton.Location = new Point(319, 276);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(162, 56);
            calculateButton.TabIndex = 6;
            calculateButton.Text = "CALCULATE";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // saveValuesButton
            // 
            saveValuesButton.BackColor = SystemColors.ActiveCaptionText;
            saveValuesButton.BackgroundImage = Properties.Resources.old_black_background_grunge_texture_dark_wallpaper_blackboard_chalkboard_room_wall;
            saveValuesButton.BackgroundImageLayout = ImageLayout.Stretch;
            saveValuesButton.Cursor = Cursors.Hand;
            saveValuesButton.FlatAppearance.BorderColor = Color.Black;
            saveValuesButton.FlatStyle = FlatStyle.Popup;
            saveValuesButton.Font = new Font("Chiller", 18F, FontStyle.Regular, GraphicsUnit.Point);
            saveValuesButton.ForeColor = SystemColors.HighlightText;
            saveValuesButton.Location = new Point(103, 397);
            saveValuesButton.Name = "saveValuesButton";
            saveValuesButton.Size = new Size(143, 41);
            saveValuesButton.TabIndex = 7;
            saveValuesButton.Text = "SAVE VALUES";
            saveValuesButton.UseVisualStyleBackColor = false;
            saveValuesButton.Click += saveValuesButton_Click;
            // 
            // loadValuesButton
            // 
            loadValuesButton.BackColor = SystemColors.ActiveCaptionText;
            loadValuesButton.BackgroundImage = Properties.Resources.old_black_background_grunge_texture_dark_wallpaper_blackboard_chalkboard_room_wall;
            loadValuesButton.BackgroundImageLayout = ImageLayout.Stretch;
            loadValuesButton.Cursor = Cursors.Hand;
            loadValuesButton.FlatAppearance.BorderColor = Color.Black;
            loadValuesButton.FlatStyle = FlatStyle.Popup;
            loadValuesButton.Font = new Font("Chiller", 18F, FontStyle.Regular, GraphicsUnit.Point);
            loadValuesButton.ForeColor = SystemColors.HighlightText;
            loadValuesButton.Location = new Point(557, 397);
            loadValuesButton.Name = "loadValuesButton";
            loadValuesButton.Size = new Size(143, 41);
            loadValuesButton.TabIndex = 8;
            loadValuesButton.Text = "LOAD VALUES";
            loadValuesButton.UseVisualStyleBackColor = false;
            loadValuesButton.Click += loadValuesButton_Click;
            // 
            // PresenceDaysCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaptionText;
            BackgroundImage = Properties.Resources.old_black_background_grunge_texture_dark_wallpaper_blackboard_chalkboard_room_wall;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(loadValuesButton);
            Controls.Add(saveValuesButton);
            Controls.Add(calculateButton);
            Controls.Add(daysLeftPanel);
            Controls.Add(presencePanel);
            Controls.Add(detailsPanel);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PresenceDaysCalculator";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Presence Days Calculator";
            detailsPanel.ResumeLayout(false);
            presencePanel.ResumeLayout(false);
            presencePanel.PerformLayout();
            daysLeftPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel detailsPanel;
        private Panel presencePanel;
        private Panel daysLeftPanel;
        private Button calculateButton;
        private Label detailsLabel;
        private TextBox monthTextBox1;
        private Label presenceLabel;
        private TextBox monthTextBox5;
        private TextBox monthTextBox4;
        private TextBox monthTextBox3;
        private TextBox monthTextBox2;
        private TextBox monthTextBox8;
        private TextBox monthTextBox7;
        private TextBox monthTextBox6;
        private TextBox monthTextBox15;
        private TextBox monthTextBox14;
        private TextBox monthTextBox13;
        private TextBox monthTextBox12;
        private TextBox monthTextBox11;
        private TextBox monthTextBox10;
        private TextBox monthTextBox9;
        private Label daysLeftLabel;
        private Button saveValuesButton;
        private Button loadValuesButton;
    }
}