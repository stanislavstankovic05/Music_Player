using Dystopia_music_player_.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dystopia_music_player_
{
    public partial class LogIn : Form
    {
        public string username;
        string key = "dystopia";
        //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-SOEK9ED;Initial Catalog=Accounts;Integrated Security=True");
        MySqlConnection connection = new MySqlConnection("Data Source=127.0.0.1;port=3306;username=root;password=;database=dystopia");

        public LogIn()
        {
            InitializeComponent();
        }

        private void username_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = username_textBox.Text;
            string password = password_textBox.Text;
            StringBuilder pass = new StringBuilder(password);
            VigenereEncrypt(ref pass, key);
            
            String querry = "SELECT * FROM users WHERE username = '" + username_textBox.Text
                + "' AND password = '" + pass.ToString() + "'";
            MySqlDataAdapter sqlData = new MySqlDataAdapter(querry, connection);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                username = username_textBox.Text;
                password = password_textBox.Text;
                MessageBox.Show("succes");
                /*this.Hide();
                Main main = new Main();
                main.Show();
                

                 */
                this.Hide();
                playlist playlist = new playlist();
                playlist.Show();
            }
            else
            {
                MessageBox.Show("Invalid Account", "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create_Account create_Account = new Create_Account();
            create_Account.Show();
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            Application.Exit();
        }
    }
}
