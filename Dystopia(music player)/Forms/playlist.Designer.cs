namespace Dystopia_music_player_.Forms
{
    partial class playlist
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playlist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.import_button = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tracklist = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.text_volume = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.skip = new System.Windows.Forms.Button();
            this.track_volume = new System.Windows.Forms.TrackBar();
            this.button7 = new System.Windows.Forms.Button();
            this.label_timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.import_button);
            this.panel1.Location = new System.Drawing.Point(16, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 415);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dystopia_music_player_.Properties.Resources.headset_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 139);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(19, 290);
            this.player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(107, 87);
            this.player.TabIndex = 24;
            this.player.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("SimSun-ExtB", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(8, 231);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 52);
            this.button1.TabIndex = 15;
            this.button1.Text = "LogOut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // import_button
            // 
            this.import_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.import_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.import_button.Font = new System.Drawing.Font("SimSun-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.import_button.ForeColor = System.Drawing.Color.Black;
            this.import_button.Location = new System.Drawing.Point(8, 161);
            this.import_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.import_button.Name = "import_button";
            this.import_button.Size = new System.Drawing.Size(135, 63);
            this.import_button.TabIndex = 15;
            this.import_button.Text = "Import music";
            this.import_button.UseVisualStyleBackColor = true;
            this.import_button.Click += new System.EventHandler(this.import_button_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.progressBar1.Location = new System.Drawing.Point(263, 330);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(463, 12);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // tracklist
            // 
            this.tracklist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tracklist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tracklist.FormattingEnabled = true;
            this.tracklist.ItemHeight = 16;
            this.tracklist.Location = new System.Drawing.Point(171, 6);
            this.tracklist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tracklist.Name = "tracklist";
            this.tracklist.Size = new System.Drawing.Size(613, 276);
            this.tracklist.TabIndex = 19;
            this.tracklist.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.text_volume);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.Delete);
            this.panel2.Controls.Add(this.skip);
            this.panel2.Controls.Add(this.track_volume);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(161, 350);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 65);
            this.panel2.TabIndex = 20;
            // 
            // text_volume
            // 
            this.text_volume.AutoSize = true;
            this.text_volume.Font = new System.Drawing.Font("SimSun-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_volume.Location = new System.Drawing.Point(572, 17);
            this.text_volume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text_volume.Name = "text_volume";
            this.text_volume.Size = new System.Drawing.Size(61, 15);
            this.text_volume.TabIndex = 21;
            this.text_volume.Text = "label1";
            // 
            // button6
            // 
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("SimSun-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(207, 11);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 37);
            this.button6.TabIndex = 20;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("SimSun-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(284, 11);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 37);
            this.button5.TabIndex = 19;
            this.button5.Text = "Random";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Delete
            // 
            this.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.Font = new System.Drawing.Font("SimSun-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.Black;
            this.Delete.Location = new System.Drawing.Point(9, 11);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(112, 37);
            this.Delete.TabIndex = 17;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Play_Click);
            // 
            // skip
            // 
            this.skip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.skip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.skip.Font = new System.Drawing.Font("SimSun-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skip.ForeColor = System.Drawing.Color.Black;
            this.skip.Location = new System.Drawing.Point(129, 11);
            this.skip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.skip.Name = "skip";
            this.skip.Size = new System.Drawing.Size(69, 37);
            this.skip.TabIndex = 18;
            this.skip.Text = "Next";
            this.skip.UseVisualStyleBackColor = true;
            this.skip.Click += new System.EventHandler(this.skip_Click);
            // 
            // track_volume
            // 
            this.track_volume.Location = new System.Drawing.Point(388, 11);
            this.track_volume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.track_volume.Maximum = 100;
            this.track_volume.Name = "track_volume";
            this.track_volume.Size = new System.Drawing.Size(188, 56);
            this.track_volume.TabIndex = 1;
            this.track_volume.Scroll += new System.EventHandler(this.track_volume_Scroll);
            // 
            // button7
            // 
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("SimSun-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button7.Location = new System.Drawing.Point(445, 290);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 32);
            this.button7.TabIndex = 21;
            this.button7.Text = "Pause";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label_timer
            // 
            this.label_timer.AutoSize = true;
            this.label_timer.Font = new System.Drawing.Font("SimSun-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label_timer.Location = new System.Drawing.Point(364, 298);
            this.label_timer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(64, 19);
            this.label_timer.TabIndex = 22;
            this.label_timer.Text = "00:00";
            this.label_timer.Click += new System.EventHandler(this.label_timer_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(560, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "00:00";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(801, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_timer);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tracklist);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "playlist";
            this.Text = "Dystopia";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track_volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button import_button;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox tracklist;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button skip;
        private System.Windows.Forms.TrackBar track_volume;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.Label text_volume;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AxWMPLib.AxWindowsMediaPlayer player;
    }
}