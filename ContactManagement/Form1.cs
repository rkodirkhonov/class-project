namespace ContactManagement
{
    public partial class Form1 : Form
    {
        ContactManagement[] myContacts;
        int size;
        public Form1()
        {
            InitializeComponent();
            myContacts = new ContactManagement[100];
            size = 0;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void addContact_Click(object sender, EventArgs e)
        {
            outputBox.Clear();

            if (nameTxt.Text == "")
            {
                MessageBox.Show("Please enter the contact name!");
                return;
            }

            if (phoneTxt.Text == "")
            {
                MessageBox.Show("Please enter the contact phone number!");
                return;
            }

            if (cityTxt.Text == "")
            {
                MessageBox.Show("Plese enter the contact's city!");
                return;
            }

            this.myContacts[size] = new ContactManagement(nameTxt.Text, phoneTxt.Text, bDayPicker.Text, cityTxt.Text);
            size += 1;

            MessageBox.Show("New contact registered successfully!");
            //outputBox.Text += "Registered Contacts: " + size;
            nameTxt.Clear();
            phoneTxt.Clear();
            cityTxt.Clear();
            label4.ResetText();
            label4.Text += size;
            bDayPicker.ResetText();
        }

        private void printOne_Click(object sender, EventArgs e)
        {
            outputBox.Clear();

            String key = nameTxt.Text;

            if (key == "")
            {
                MessageBox.Show("Please enter the contact name to be printed!");
                return;
            }

            for (int i = 0; i < size; i++)
            {
                if (this.myContacts[i].Name.ToLower().Equals(key.ToLower()))
                {
                    outputBox.Text += this.myContacts[i].Name + ", " + this.myContacts[i].PhoneNo + ", " +
                        "" + this.myContacts[i].BirthDay + ", " + this.myContacts[i].City + "\n";
                    nameTxt.Clear();
                    return;
                }
            }
            MessageBox.Show("No Record Found!");
        }

        private void printAll_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            for (int i = 0; i < size; i++)
            {
                outputBox.Text += this.myContacts[i].Name + ", " +
                    "" + this.myContacts[i].PhoneNo + ", " + this.myContacts[i].BirthDay + ", " + this.myContacts[i].City + "\n";
            }
        }

        private void deleteOne_Click(object sender, EventArgs e)
        {
            outputBox.Clear();

            String key = nameTxt.Text;

            if (key == "")
            {
                MessageBox.Show("Please enter the name of contact to be removed!");
                return;
            }

            ContactManagement c = null;

            for (int i = 0; i < size; i++)
            {
                if (this.myContacts[i].Name.ToLower().Equals(key.ToLower()))
                {
                    c = myContacts[i];
                    break;
                }
            }


            if (c == null)
            {
                MessageBox.Show("No Record Found!");
                return;
            }


            this.myContacts = this.myContacts.Except(new ContactManagement[] {c}).ToArray();
            size -= 1;
            label4.ResetText();
            label4.Text += size;
            MessageBox.Show("Record Deleted Successfully!");
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            outputBox.Clear();
            this.myContacts = new ContactManagement[100];
            this.size = 0;
            label4.ResetText();
            label4.Text += size;
            MessageBox.Show("All Contacts Deleted!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bDayPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dear Mr or Mrs! \nWelcome to our \"Contact Management\" application.\n\n" +
                "This application has the capacity to record 500 contacts information " +
                "(including: contact's name, phone number, city and date contact was added).\n" +
                "\nThere are these buttons on the menu in our application:\n" +
                "   Add Contact - for adding a new contact into your list.\n" +
                "   Print One Contact - prints the contact information after you enter its name.\n" +
                "   Print All Contact - prints out all registered contacts with their information\n" +
                "   Delete One Contact - removes the contact information from the registered contacts' list in case" +
                " you press this button after filling name field on the menu.\n" +
                "   Delete All Contacts - removes all the registered contacts and their information.\n" +
                "   Clear - this button frees all the input field.\n" +
                "   Exit - stops our application and closes the application window!\n\n" +
                "© 2022 \nAll Rights Reserved!       \nby developer6229");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nameTxt.Clear();
            phoneTxt.Clear();
            cityTxt.Clear();
            bDayPicker.ResetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void outputBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}