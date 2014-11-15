namespace PFCM
{
    partial class CharacterCreation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Strength = new System.Windows.Forms.NumericUpDown();
            this.Dexterity = new System.Windows.Forms.NumericUpDown();
            this.Constitution = new System.Windows.Forms.NumericUpDown();
            this.Charisma = new System.Windows.Forms.NumericUpDown();
            this.Wisdom = new System.Windows.Forms.NumericUpDown();
            this.Intelligence = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.PointsLeft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Strength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dexterity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Constitution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Charisma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wisdom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Intelligence)).BeginInit();
            this.SuspendLayout();
            // 
            // Strength
            // 
            this.Strength.AccessibleDescription = "Strength Score";
            this.Strength.AccessibleName = "Strength Score Box";
            this.Strength.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Strength.ForeColor = System.Drawing.SystemColors.Info;
            this.Strength.Location = new System.Drawing.Point(27, 31);
            this.Strength.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.Strength.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.Strength.Name = "Strength";
            this.Strength.Size = new System.Drawing.Size(52, 22);
            this.Strength.TabIndex = 0;
            this.Strength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Strength.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Strength.ValueChanged += new System.EventHandler(this.Strength_ValueChanged);
            // 
            // Dexterity
            // 
            this.Dexterity.AccessibleDescription = "Dexterity Score";
            this.Dexterity.AccessibleName = "Dexterity Score Box";
            this.Dexterity.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Dexterity.ForeColor = System.Drawing.SystemColors.Info;
            this.Dexterity.Location = new System.Drawing.Point(27, 58);
            this.Dexterity.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.Dexterity.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.Dexterity.Name = "Dexterity";
            this.Dexterity.Size = new System.Drawing.Size(52, 22);
            this.Dexterity.TabIndex = 1;
            this.Dexterity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Dexterity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Dexterity.ValueChanged += new System.EventHandler(this.Dexterity_ValueChanged);
            // 
            // Constitution
            // 
            this.Constitution.AccessibleDescription = "Constitution Score";
            this.Constitution.AccessibleName = "Constitution Score Box";
            this.Constitution.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Constitution.ForeColor = System.Drawing.SystemColors.Info;
            this.Constitution.Location = new System.Drawing.Point(27, 87);
            this.Constitution.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.Constitution.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.Constitution.Name = "Constitution";
            this.Constitution.Size = new System.Drawing.Size(52, 22);
            this.Constitution.TabIndex = 2;
            this.Constitution.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Constitution.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Constitution.ValueChanged += new System.EventHandler(this.Constitution_ValueChanged);
            // 
            // Charisma
            // 
            this.Charisma.AccessibleDescription = "Charisma Score";
            this.Charisma.AccessibleName = "Charisma Score Box";
            this.Charisma.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Charisma.ForeColor = System.Drawing.SystemColors.Info;
            this.Charisma.Location = new System.Drawing.Point(27, 171);
            this.Charisma.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.Charisma.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.Charisma.Name = "Charisma";
            this.Charisma.Size = new System.Drawing.Size(52, 22);
            this.Charisma.TabIndex = 5;
            this.Charisma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Charisma.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Charisma.ValueChanged += new System.EventHandler(this.Charisma_ValueChanged);
            // 
            // Wisdom
            // 
            this.Wisdom.AccessibleDescription = "Wisdom Score";
            this.Wisdom.AccessibleName = "Wisdom Score Box";
            this.Wisdom.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Wisdom.ForeColor = System.Drawing.SystemColors.Info;
            this.Wisdom.Location = new System.Drawing.Point(27, 143);
            this.Wisdom.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.Wisdom.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.Wisdom.Name = "Wisdom";
            this.Wisdom.Size = new System.Drawing.Size(52, 22);
            this.Wisdom.TabIndex = 4;
            this.Wisdom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Wisdom.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Wisdom.ValueChanged += new System.EventHandler(this.Wisdom_ValueChanged);
            // 
            // Intelligence
            // 
            this.Intelligence.AccessibleDescription = "Intelligence Score";
            this.Intelligence.AccessibleName = "Intelligence Score Box";
            this.Intelligence.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Intelligence.ForeColor = System.Drawing.SystemColors.Info;
            this.Intelligence.Location = new System.Drawing.Point(27, 115);
            this.Intelligence.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.Intelligence.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.Intelligence.Name = "Intelligence";
            this.Intelligence.Size = new System.Drawing.Size(52, 22);
            this.Intelligence.TabIndex = 3;
            this.Intelligence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Intelligence.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Intelligence.ValueChanged += new System.EventHandler(this.Intelligence_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Strength";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dexterity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Constitution";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Intelligence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Wisdom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Charisma";
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Black;
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(349, 538);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(85, 31);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "CANCEL";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // PointsLeft
            // 
            this.PointsLeft.AutoSize = true;
            this.PointsLeft.Location = new System.Drawing.Point(11, 9);
            this.PointsLeft.Name = "PointsLeft";
            this.PointsLeft.Size = new System.Drawing.Size(68, 17);
            this.PointsLeft.TabIndex = 13;
            this.PointsLeft.Text = "Point Buy";
            // 
            // CharacterCreation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(525, 581);
            this.ControlBox = false;
            this.Controls.Add(this.PointsLeft);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Charisma);
            this.Controls.Add(this.Wisdom);
            this.Controls.Add(this.Intelligence);
            this.Controls.Add(this.Constitution);
            this.Controls.Add(this.Dexterity);
            this.Controls.Add(this.Strength);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CharacterCreation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "New Character";
            ((System.ComponentModel.ISupportInitialize)(this.Strength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dexterity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Constitution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Charisma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wisdom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Intelligence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Strength;
        private System.Windows.Forms.NumericUpDown Dexterity;
        private System.Windows.Forms.NumericUpDown Constitution;
        private System.Windows.Forms.NumericUpDown Charisma;
        private System.Windows.Forms.NumericUpDown Wisdom;
        private System.Windows.Forms.NumericUpDown Intelligence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label PointsLeft;
    }
}