using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web.Services.Description;
using System.Data.SqlClient;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dystopia_music_player_.Forms
{
    public partial class playlist : Form
    {
        private SqlConnection conect_music;
        public static AxWMPLib.AxWindowsMediaPlayer play = new AxWMPLib.AxWindowsMediaPlayer();
        int index = 0;
        int position = 0;
        bool paused = false;

        string[] paths = new string[10001];
        string[] melodie = new string[10001];
        string[] files = new string[10001];
        string[] aux;
        string prepath;
        int number = 0;
        int number_ofTracks = 0;
        bool delete_option = false;
       
        public playlist()
        {
            //play = wplayer;
            InitializeComponent();
            track_volume.Value = 50;
            text_volume.Text = track_volume.Value.ToString() + "%";
            conect_music = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Melodie.mdf;Integrated Security=True;Connect Timeout=30");
            string query1="SELECT *FROM Melodie WHERE playlist="+number;
            prepath = System.IO.Directory.GetCurrentDirectory();

            string query2;
            conect_music.Open();
            string read;
            using (SqlCommand com = new SqlCommand(query1, conect_music))
            {
                using (SqlDataReader reader = com.ExecuteReader())
                {
                    if(reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            paths[index] = System.IO.Path.Combine(prepath, reader["path"].ToString());
                            melodie[index] = reader["path"].ToString();
                            tracklist.Items.Add(reader["path"].ToString());
                            index++;
                        }
                    }
                }
            }
            number_ofTracks = index;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            this.Close();
            LogIn log = new LogIn();
            log.Show();
        }

        private void import_button_Click(object sender, EventArgs e)
        {
            //DE FACUT SA NU MAI ADAUGI CELE CE APAR DEJA
            player.Ctlcontrols.stop();
            OpenFileDialog import = new OpenFileDialog();
            import.Multiselect = true;
            string[] aux;
            aux = paths;
            /*if (import.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = import.SafeFileNames;
                aux = import.FileNames;
                for (int i = 0; i < files.Length; ++i)
                {
                    tracklist.Items.Add(files[i]);
                    string destination;
                    destination = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), files[i]);
                    MessageBox.Show($"{destination}");
                    System.IO.File.Copy(aux[i], destination, true);
                }
            }
            Array.Resize(ref paths, files.Length + index);
            Array.Resize(ref melodie, files.Length + index);
            SqlCommand com = new SqlCommand();
            
            for (int i = 0; i < files.Length; ++i)
            {
                paths[i + index] = aux[i];
                melodie[i + index] = files[i];
                //MessageBox.Show($"{paths[i+index]}");
                Random random = new Random();
                int id = random.Next(1000, 9999) * 10 + number;
                //int id = (i + index) * 10 + number;
                add_to_database(id, melodie[i + index]);
            }
            index += files.Length;
            number_ofTracks = index;
            tracklist.Update();
            for (int i = 0; i < paths.Length; ++i) 
            {
                MessageBox.Show($"{paths[i]}  {melodie[i]}");
            }
            */
            if (import.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = import.SafeFileNames;
                aux = import.FileNames;
                for (int i = 0; i < files.Length; ++i)
                {
                    if (System.IO.File.Exists(files[i]) == false) 
                    {
                        tracklist.Items.Add(files[i]);
                        string destination;
                        destination = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), files[i]);
                        MessageBox.Show($"{destination}");
                        /*paths[number_ofTracks] = aux[i];
                        melodie[number_ofTracks] = files[i];*/
                        //MessageBox.Show($"{paths[number_ofTracks]}");
                        Random random = new Random();
                        int id = random.Next(1, 9999) * 10 + number;
                        //int id = (i + number_ofTracks) * 10 + number;
                        //add_to_database(id, melodie[number_ofTracks]);
                        //number_ofTracks++;
                        System.IO.File.Copy(aux[i], destination, false);
                        paths[number_ofTracks] = destination;
                        melodie[number_ofTracks] = files[i];
                        add_to_database(id, melodie[number_ofTracks]);
                        number_ofTracks++;
                    }
                    else
                    {
                        MessageBox.Show("ALREADY ADDED");
                    }
                }
            }
            /*Array.Resize(ref paths, number_ofTracks);
            Array.Resize(ref melodie, number_ofTracks);*/
            tracklist.Update();
            for (int i = 0; i < number_ofTracks; ++i) 
            {
                MessageBox.Show($"{melodie[i]} ");
            }
        }
        void add_to_database(int id, string path)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Melodie.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand com = new SqlCommand("insert_melodie", sc); 
            com.CommandType = CommandType.StoredProcedure;
            com.Connection = sc;
            com.Parameters.AddWithValue("@IdMelodie", id);
            com.Parameters.AddWithValue("@path", path);
            com.Parameters.AddWithValue("@playlist", number);
            sc.Open();
            int i = com.ExecuteNonQuery();

            sc.Close();

            if (i != 0)
            {
                MessageBox.Show(i + "Data Saved");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show($"{index} {tracklist.SelectedIndex}");
            //MessageBox.Show($"{index} {tracklist.SelectedIndex}");
            if (delete_option == false)
            {
                if (tracklist.SelectedIndex >= 0)
                {
                    position = tracklist.SelectedIndex;
                    player.URL = paths[tracklist.SelectedIndex];
                    player.Ctlcontrols.play();
                    //play.URL = paths[tracklist.SelectedIndex];
                    //play.controls.play();
                    tracklist.SelectedIndex = -1;
                }
                else
                {
                    //MessageBox.Show("Invalid click");
                }
            }
            else
            {
                if (tracklist.SelectedIndex >= 0)
                {
                    MessageBox.Show($"{tracklist.SelectedIndex}");
                    deleteFrom_Database(tracklist.SelectedIndex);
                    deleteTrack(tracklist.SelectedIndex);
                    tracklist.Items.RemoveAt(tracklist.SelectedIndex);
                    tracklist.SelectedIndex = -1;
                    
                }
                else
                {

                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (paused == false)
            {
                player.Ctlcontrols.pause();
                paused = true;
            }
            else
            {
                player.Ctlcontrols.play();
                paused = false;
            }
        }

        private void skip_Click(object sender, EventArgs e)
        {
            if (position + 1 >= number_ofTracks)
            {
                player.URL = paths[0];
                position = 0;
                player.Ctlcontrols.play();
            }
            else
            {
                player.URL = paths[position + 1];
                position++;
                player.Ctlcontrols.play(); ;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int track = random.Next(0, number_ofTracks);
            while (track == position)
                track = random.Next(0, number_ofTracks);
            player.URL = paths[track];
            position = track;
            player.Ctlcontrols.play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (position - 1 < 0)
            {
                player.URL = paths[0];
                position = 0;
                player.Ctlcontrols.play();
            }
            else
            {
                player.URL = paths[position - 1];
                position--;
                player.Ctlcontrols.play(); ;
            }
        }

        private void track_volume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = track_volume.Value;
            text_volume.Text = track_volume.Value.ToString() + "%";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)player.Ctlcontrols.currentPosition;
                label_timer.Text = player.Ctlcontrols.currentPositionString;
                label1.Text = player.Ctlcontrols.currentItem.durationString.ToString();
                if ((int)player.Ctlcontrols.currentPosition == (int)player.Ctlcontrols.currentItem.duration)
                {
                    /*if (position + 1 >= number_ofTracks)
                    {
                        player.URL = paths[0];
                        position = 0;
                        player.Ctlcontrols.play();
                    }
                    else
                    {
                        player.URL = paths[position + 1];
                        position++;
                        player.Ctlcontrols.play(); ;
                     }*/
                    if (position + 1 >= number_ofTracks)
                    {
                        player.URL = paths[0];
                        position = 0;
                        player.Ctlcontrols.play();
                    }
                    else
                    {
                        player.URL = paths[position + 1];
                        position++;
                        player.Ctlcontrols.play(); ;
                    }
                }
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label_timer_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Play_Click(object sender, EventArgs e)
        {
            if (delete_option == true)
            {
                delete_option = false;
                MessageBox.Show(@"Delete option off");
            }
            else
            {
                delete_option = true;
                MessageBox.Show(@"Delete option on");
            }
            
        }
        void deleteTrack(int position)
        {
            MessageBox.Show($"{position} {number_ofTracks}");
            int lenght = 1;
            System.IO.File.Delete(paths[position]);
            for (int i = position + 1; i < number_ofTracks; ++i)//inainte era position+1 si <=number_ofTracks
            {
                paths[i - 1] = paths[i];//'Index was outside the bounds of the array.'
                melodie[i - 1] = paths[i];
            }
            number_ofTracks--;
            /*Array.Resize(ref paths, number_ofTracks + 1);
            Array.Resize(ref melodie, number_ofTracks + 1);*/
            
        }
        void deleteFrom_Database(int position)
        {
            MessageBox.Show($"{melodie[position]} ");
            string sql = "DELETE FROM Melodie WHERE path=" + "'" + melodie[position] + "'";
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Melodie.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter adapter = new SqlDataAdapter();
            try 
            {
                sc.Open();
                adapter.UpdateCommand = sc.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;
                adapter.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show($"Data {melodie[position]} deleted");
                sc.Close();

            }
            catch
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("pressed");
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        /*if (import.ShowDialog() == System.Windows.Forms.DialogResult.OK)
{
files = import.SafeFileNames;
aux = import.FileNames;
for (int i = 0; i < files.Length; ++i) 
{
tracklist.Items.Add(files[i]);
}
}
Array.Resize(ref paths, files.Length + index);
for (int i = 0; i < files.Length; ++i)
{
paths[i+index]= aux[i];
}
index += files.Length;
tracklist.Update();*/
        //MessageBox.Show($"{index} {tracklist.SelectedIndex}");
        //MessageBox.Show($"{index} {tracklist.SelectedIndex}");


        /*if (import.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        {
            file = import.SafeFileNames;
            aux = import.FileNames;
            for (int i = 0; i < file.Length; ++i)
            {
                File.Copy(aux[i], "C:\\Users\\flori\\source\\repos\\Dystopia(music player)\\Dystopia(music player)\\Music" + "\\" + file[i]);
            }
        }
        for (int i = 0; i < file.Length; ++i)
        {
            tracklist.Items.Add(file[i]);
        }
        Array.Resize(ref paths, file.Length + index);
        for (int i = 0; i < file.Length; ++i)
        {
            paths[i + index] = aux[i];
        }
        index += file.Length;
        tracklist.Update(); */
    }
}
