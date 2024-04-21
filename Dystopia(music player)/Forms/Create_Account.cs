using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Net;
using System.Net.Mail;
using static System.Net.Mime.MediaTypeNames;
using MySql.Data.MySqlClient;

namespace Dystopia_music_player_.Forms
{
    public partial class Create_Account : Form
    {
        /*INSERT INTO `users_dystopia` (`username`, `password`, `email`) VALUES ('my_name12', 'labus123', 'florinstan606@gmail.com');*/

        public Create_Account()
        {
            InitializeComponent();
        }
        //conexiunea cu baza de date SQL
        //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-SOEK9ED;Initial Catalog=Accounts;Integrated Security=True");
        string password = "";
        string connstring = "SERVER=127.0.0.1;DATABASE=users;UID=root;PASSWORD=" + "" + ";";
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;username=root;password=;database=dystopia");

        string key = "dystopia";//key pentru codificare
        private void button1_Click(object sender, EventArgs e)
        {
            if (username_textbox.Text == null || password_textbox == null || email_textbox.Text==null
                || !IsValidEmail(email_textbox.Text))
                MessageBox.Show("Invalid registration");
            else
            {
                StringBuilder cript = new StringBuilder(password_textbox.Text);
                VigenereEncrypt(ref cript, key);//se codifica parola
                connection.Open();//se deschide conexiunea cu baza de date
                //din serverul local



                String querry = "Insert into `users` (`username`, `password`, `email`) values " +
                    "('"+ username_textbox.Text.Trim()+"', '"+ cript.ToString().Trim()+"', '" +
                    email_textbox.Text.Trim()+"')";



                MySqlCommand sqlCommand = new MySqlCommand(querry, connection);
                //"useradd" - este un query creeat in baza de date
                //sqlCommand.CommandType = CommandType.StoredProcedure;
                // se adauga parametrii
                /*sqlCommand.Parameters.AddWithValue("@username", username_textbox.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@password", cript.ToString().Trim());
                sqlCommand.Parameters.AddWithValue("@email", email_textbox.Text.Trim());*/
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("The Registration has been succesfull!");
               
                Send_Email();
                Clear_TextBoxes();//in cazul in care dorim sa creeam un alt cont sa fie golite casetele
                //ascundem aceasta fereastra si o adaugam pe cea de LogIn
                this.Hide();
                LogIn login = new LogIn();
                login.Show();
            }
        }
        void Clear_TextBoxes()
        {
            username_textbox.Clear();
            password_textbox.Clear();
        }

        public static bool IsValidEmail(String Email)
        {
            if (Email != null && Email != "")
                return Regex.IsMatch(Email, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            else
                return false;
        }
        void Send_Email()
        {
            MailMessage mm = new MailMessage("florinstan606@gmail.com", email_textbox.Text);
            mm.Subject = "Welcome to Dystopia player";
            mm.Body = "Enjoy your stay!Here is your password " + password_textbox.Text;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            System.Net.NetworkCredential nc = new System.Net.NetworkCredential("florinstan606@gmail.com", "yzqelcevjlwfkovo");
            //System.Net.NetworkCredential nc = new System.Net.NetworkCredential("un_gmail", "parola_de_securitate");
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            smtp.Send(mm);
        }
        static void VigenereEncrypt(ref StringBuilder s, string key)
        {
            for (int i = 0; i < s.Length; i++) s[i] = Char.ToUpper(s[i]);
            key = key.ToUpper();
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                {
                    s[i] = (char)(s[i] + key[j] - 'A');
                    if (s[i] > 'Z')
                        s[i] = (char)(s[i] - 'Z' + 'A' - 1);
                }
                j = j + 1 == key.Length ? 0 : j + 1;
            }
        }

        static void VigenereDecrypt(ref StringBuilder s, string key)
        {
            for (int i = 0; i < s.Length; i++) s[i] = Char.ToUpper(s[i]);
            key = key.ToUpper();
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                {
                    s[i] = s[i] >= key[j] ?
                              (char)(s[i] - key[j] + 'A') :
                              (char)('A' + ('Z' - key[j] + s[i] - 'A') + 1);
                }
                j = j + 1 == key.Length ? 0 : j + 1;
            }
        }
        private void username_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
//StringBuilder decript = new StringBuilder();
// MessageBox.Show($"{cript} {decript}");
//decript = cript;
//VigenereDecrypt(ref cript, key);
//MessageBox.Show($"{cript} {decript}");
//mm.Body = "Enjoy your stay!Here is your password "+ password_textbox.Text;
