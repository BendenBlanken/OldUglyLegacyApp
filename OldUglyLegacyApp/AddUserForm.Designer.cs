namespace OldUglyLegacyApp
{
    partial class AddUserForm
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
            this.Firstname = new System.Windows.Forms.TextBox();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.Middlename = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Street = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Postalcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Housenumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAutoNumber = new System.Windows.Forms.Label();
            this.labelValueAutonumber = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Firstname
            // 
            this.Firstname.AccessibleDescription = "Firstname";
            this.Firstname.AccessibleName = "Firstname";
            this.Firstname.Location = new System.Drawing.Point(96, 112);
            this.Firstname.Name = "Firstname";
            this.Firstname.Size = new System.Drawing.Size(188, 20);
            this.Firstname.TabIndex = 0;
            // 
            // Lastname
            // 
            this.Lastname.AccessibleDescription = "Lastname";
            this.Lastname.AccessibleName = "Lastname";
            this.Lastname.Location = new System.Drawing.Point(96, 216);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(188, 20);
            this.Lastname.TabIndex = 1;
            // 
            // Middlename
            // 
            this.Middlename.AccessibleDescription = "Middlename";
            this.Middlename.AccessibleName = "Middlename";
            this.Middlename.Location = new System.Drawing.Point(96, 161);
            this.Middlename.Name = "Middlename";
            this.Middlename.Size = new System.Drawing.Size(188, 20);
            this.Middlename.TabIndex = 2;
            // 
            // Gender
            // 
            this.Gender.AccessibleDescription = "Gender";
            this.Gender.AccessibleName = "Gender";
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Unknown"});
            this.Gender.Location = new System.Drawing.Point(84, 189);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(188, 21);
            this.Gender.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Middlename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lastname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gender";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Gender);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 239);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.City);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Street);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Postalcode);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Housenumber);
            this.groupBox2.Location = new System.Drawing.Point(412, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 239);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "City";
            // 
            // City
            // 
            this.City.AccessibleDescription = "City";
            this.City.AccessibleName = "City";
            this.City.Location = new System.Drawing.Point(98, 186);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(188, 20);
            this.City.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Postalcode";
            // 
            // Street
            // 
            this.Street.AccessibleDescription = "Street";
            this.Street.AccessibleName = "Street";
            this.Street.Location = new System.Drawing.Point(98, 29);
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(188, 20);
            this.Street.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Housenumber";
            // 
            // Postalcode
            // 
            this.Postalcode.AccessibleDescription = "Postalcode";
            this.Postalcode.AccessibleName = "Postalcode";
            this.Postalcode.Location = new System.Drawing.Point(98, 133);
            this.Postalcode.Name = "Postalcode";
            this.Postalcode.Size = new System.Drawing.Size(188, 20);
            this.Postalcode.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Street";
            // 
            // Housenumber
            // 
            this.Housenumber.AccessibleDescription = "Housenumber";
            this.Housenumber.AccessibleName = "Housenumber";
            this.Housenumber.Location = new System.Drawing.Point(98, 78);
            this.Housenumber.Name = "Housenumber";
            this.Housenumber.Size = new System.Drawing.Size(188, 20);
            this.Housenumber.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(209, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(336, 37);
            this.label11.TabIndex = 14;
            this.label11.Text = "Old Ugly Legacy App";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(723, 321);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // labelAutoNumber
            // 
            this.labelAutoNumber.AutoSize = true;
            this.labelAutoNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutoNumber.Location = new System.Drawing.Point(25, 20);
            this.labelAutoNumber.Name = "labelAutoNumber";
            this.labelAutoNumber.Size = new System.Drawing.Size(134, 25);
            this.labelAutoNumber.TabIndex = 16;
            this.labelAutoNumber.Text = "Autonumber:";
            this.labelAutoNumber.Visible = false;
            // 
            // labelValueAutonumber
            // 
            this.labelValueAutonumber.AutoSize = true;
            this.labelValueAutonumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueAutonumber.Location = new System.Drawing.Point(179, 20);
            this.labelValueAutonumber.Name = "labelValueAutonumber";
            this.labelValueAutonumber.Size = new System.Drawing.Size(48, 25);
            this.labelValueAutonumber.TabIndex = 17;
            this.labelValueAutonumber.Text = "123";
            this.labelValueAutonumber.Visible = false;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 416);
            this.Controls.Add(this.labelValueAutonumber);
            this.Controls.Add(this.labelAutoNumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Middlename);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.Firstname);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddUserForm";
            this.Text = "Add user";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Firstname;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.TextBox Middlename;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Street;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Postalcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Housenumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAutoNumber;
        private System.Windows.Forms.Label labelValueAutonumber;
    }
}

