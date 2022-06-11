namespace ContactManagement
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.addContact = new System.Windows.Forms.Button();
            this.printOne = new System.Windows.Forms.Button();
            this.printAll = new System.Windows.Forms.Button();
            this.deleteOne = new System.Windows.Forms.Button();
            this.deleteAll = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cityTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bDayPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(353, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTACT MANAGEMENT SYSTEM";
            // 
            // addContact
            // 
            this.addContact.Location = new System.Drawing.Point(459, 391);
            this.addContact.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addContact.Name = "addContact";
            this.addContact.Size = new System.Drawing.Size(217, 50);
            this.addContact.TabIndex = 1;
            this.addContact.Text = "Add Contact";
            this.addContact.UseVisualStyleBackColor = true;
            this.addContact.Click += new System.EventHandler(this.addContact_Click);
            // 
            // printOne
            // 
            this.printOne.Location = new System.Drawing.Point(459, 463);
            this.printOne.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.printOne.Name = "printOne";
            this.printOne.Size = new System.Drawing.Size(217, 50);
            this.printOne.TabIndex = 2;
            this.printOne.Text = "Print One Contact";
            this.printOne.UseVisualStyleBackColor = true;
            this.printOne.Click += new System.EventHandler(this.printOne_Click);
            // 
            // printAll
            // 
            this.printAll.Location = new System.Drawing.Point(459, 538);
            this.printAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.printAll.Name = "printAll";
            this.printAll.Size = new System.Drawing.Size(217, 50);
            this.printAll.TabIndex = 3;
            this.printAll.Text = "Print All Contacts";
            this.printAll.UseVisualStyleBackColor = true;
            this.printAll.Click += new System.EventHandler(this.printAll_Click);
            // 
            // deleteOne
            // 
            this.deleteOne.Location = new System.Drawing.Point(459, 610);
            this.deleteOne.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deleteOne.Name = "deleteOne";
            this.deleteOne.Size = new System.Drawing.Size(217, 50);
            this.deleteOne.TabIndex = 4;
            this.deleteOne.Text = "Delete One Contact";
            this.deleteOne.UseVisualStyleBackColor = true;
            this.deleteOne.Click += new System.EventHandler(this.deleteOne_Click);
            // 
            // deleteAll
            // 
            this.deleteAll.Location = new System.Drawing.Point(459, 685);
            this.deleteAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(217, 50);
            this.deleteAll.TabIndex = 5;
            this.deleteAll.Text = "Delete All Contacts";
            this.deleteAll.UseVisualStyleBackColor = true;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(459, 757);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(217, 50);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(14, 71);
            this.outputBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(1209, 178);
            this.outputBox.TabIndex = 7;
            this.outputBox.Text = "";
            this.outputBox.TextChanged += new System.EventHandler(this.outputBox_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(62, 286);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(51, 21);
            this.label.TabIndex = 8;
            this.label.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Phone Number";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(134, 281);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(255, 28);
            this.nameTxt.TabIndex = 10;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(539, 281);
            this.phoneTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(255, 28);
            this.phoneTxt.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(814, 286);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date";
            // 
            // cityTxt
            // 
            this.cityTxt.Location = new System.Drawing.Point(539, 330);
            this.cityTxt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cityTxt.Name = "cityTxt";
            this.cityTxt.Size = new System.Drawing.Size(255, 28);
            this.cityTxt.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 333);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "City";
            // 
            // bDayPicker
            // 
            this.bDayPicker.Location = new System.Drawing.Point(886, 281);
            this.bDayPicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bDayPicker.Name = "bDayPicker";
            this.bDayPicker.Size = new System.Drawing.Size(281, 28);
            this.bDayPicker.TabIndex = 15;
            this.bDayPicker.ValueChanged += new System.EventHandler(this.bDayPicker_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1156, 216);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.MinimumSize = new System.Drawing.Size(45, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 16;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(875, 216);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.MinimumSize = new System.Drawing.Size(45, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "The number of registered contacts: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1171, 776);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(716, 391);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 50);
            this.button2.TabIndex = 19;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(380, 400);
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1276, 823);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bDayPicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cityTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.deleteOne);
            this.Controls.Add(this.printAll);
            this.Controls.Add(this.printOne);
            this.Controls.Add(this.addContact);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button addContact;
        private Button printOne;
        private Button printAll;
        private Button deleteOne;
        private Button deleteAll;
        private Button exit;
        private RichTextBox outputBox;
        private Label label;
        private Label label2;
        private TextBox nameTxt;
        private TextBox phoneTxt;
        private Label label3;
        private TextBox cityTxt;
        private Label label5;
        private DateTimePicker bDayPicker;
        private Label label4;
        private Label label6;
        private Button button1;
        private Button button2;
    }
}