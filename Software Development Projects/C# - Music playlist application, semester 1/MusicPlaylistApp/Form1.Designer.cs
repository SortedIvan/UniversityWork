namespace MusicPlaylistApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPlaylist = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSongs = new System.Windows.Forms.ListBox();
            this.lbPlaylist = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSortByArtist = new System.Windows.Forms.Button();
            this.lbFindSong = new System.Windows.Forms.ListBox();
            this.btnFindSong = new System.Windows.Forms.Button();
            this.btnFindArtist = new System.Windows.Forms.Button();
            this.tbFindSong = new System.Windows.Forms.TextBox();
            this.btnGenreCheck = new System.Windows.Forms.Button();
            this.lbGenres = new System.Windows.Forms.Label();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.lbDur = new System.Windows.Forms.Label();
            this.tbBand = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbOperation = new System.Windows.Forms.Label();
            this.cbPlay = new System.Windows.Forms.CheckBox();
            this.lbPlaylistDuration = new System.Windows.Forms.ListBox();
            this.btnPlayDuration = new System.Windows.Forms.Button();
            this.lbTotalDuration = new System.Windows.Forms.ListBox();
            this.btnDurationResult = new System.Windows.Forms.Button();
            this.tbPlaylistName = new System.Windows.Forms.TextBox();
            this.btnChangeName = new System.Windows.Forms.Button();
            this.tbRemPlaylist = new System.Windows.Forms.TextBox();
            this.tbAddPlaylist = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.btnDeleteSong = new System.Windows.Forms.Button();
            this.btnRemovePlay = new System.Windows.Forms.Button();
            this.btnAddPlay = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1164, 682);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPlaylist);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 72);
            this.panel1.TabIndex = 1;
            // 
            // lblPlaylist
            // 
            this.lblPlaylist.AutoSize = true;
            this.lblPlaylist.Location = new System.Drawing.Point(748, 47);
            this.lblPlaylist.Name = "lblPlaylist";
            this.lblPlaylist.Size = new System.Drawing.Size(63, 16);
            this.lblPlaylist.TabIndex = 1;
            this.lblPlaylist.Text = "Playlist:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "All songs available:";
            // 
            // lbSongs
            // 
            this.lbSongs.FormattingEnabled = true;
            this.lbSongs.ItemHeight = 16;
            this.lbSongs.Location = new System.Drawing.Point(396, 90);
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(341, 276);
            this.lbSongs.TabIndex = 3;
            // 
            // lbPlaylist
            // 
            this.lbPlaylist.FormattingEnabled = true;
            this.lbPlaylist.ItemHeight = 16;
            this.lbPlaylist.Location = new System.Drawing.Point(754, 90);
            this.lbPlaylist.Name = "lbPlaylist";
            this.lbPlaylist.Size = new System.Drawing.Size(384, 276);
            this.lbPlaylist.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnSortByArtist);
            this.panel2.Controls.Add(this.lbFindSong);
            this.panel2.Controls.Add(this.btnFindSong);
            this.panel2.Controls.Add(this.btnFindArtist);
            this.panel2.Controls.Add(this.tbFindSong);
            this.panel2.Controls.Add(this.btnGenreCheck);
            this.panel2.Controls.Add(this.lbGenres);
            this.panel2.Controls.Add(this.tbGenre);
            this.panel2.Controls.Add(this.tbDuration);
            this.panel2.Controls.Add(this.lbDur);
            this.panel2.Controls.Add(this.tbBand);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbName);
            this.panel2.Location = new System.Drawing.Point(3, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 553);
            this.panel2.TabIndex = 5;
            // 
            // btnSortByArtist
            // 
            this.btnSortByArtist.Location = new System.Drawing.Point(9, 309);
            this.btnSortByArtist.Name = "btnSortByArtist";
            this.btnSortByArtist.Size = new System.Drawing.Size(133, 23);
            this.btnSortByArtist.TabIndex = 21;
            this.btnSortByArtist.Text = "Sort by artists";
            this.btnSortByArtist.UseVisualStyleBackColor = true;
            this.btnSortByArtist.Click += new System.EventHandler(this.btnSortByArtist_Click);
            // 
            // lbFindSong
            // 
            this.lbFindSong.FormattingEnabled = true;
            this.lbFindSong.ItemHeight = 16;
            this.lbFindSong.Location = new System.Drawing.Point(6, 396);
            this.lbFindSong.Name = "lbFindSong";
            this.lbFindSong.Size = new System.Drawing.Size(378, 148);
            this.lbFindSong.TabIndex = 20;
            // 
            // btnFindSong
            // 
            this.btnFindSong.Location = new System.Drawing.Point(190, 338);
            this.btnFindSong.Name = "btnFindSong";
            this.btnFindSong.Size = new System.Drawing.Size(194, 23);
            this.btnFindSong.TabIndex = 19;
            this.btnFindSong.Text = "Find by name!";
            this.btnFindSong.UseVisualStyleBackColor = true;
            this.btnFindSong.Click += new System.EventHandler(this.btnFindSong_Click);
            // 
            // btnFindArtist
            // 
            this.btnFindArtist.Location = new System.Drawing.Point(9, 338);
            this.btnFindArtist.Name = "btnFindArtist";
            this.btnFindArtist.Size = new System.Drawing.Size(175, 23);
            this.btnFindArtist.TabIndex = 18;
            this.btnFindArtist.Text = "Find by artist!";
            this.btnFindArtist.UseVisualStyleBackColor = true;
            this.btnFindArtist.Click += new System.EventHandler(this.btnFindArtist_Click);
            // 
            // tbFindSong
            // 
            this.tbFindSong.Location = new System.Drawing.Point(6, 366);
            this.tbFindSong.Name = "tbFindSong";
            this.tbFindSong.Size = new System.Drawing.Size(378, 22);
            this.tbFindSong.TabIndex = 16;
            // 
            // btnGenreCheck
            // 
            this.btnGenreCheck.Location = new System.Drawing.Point(230, 219);
            this.btnGenreCheck.Name = "btnGenreCheck";
            this.btnGenreCheck.Size = new System.Drawing.Size(75, 23);
            this.btnGenreCheck.TabIndex = 15;
            this.btnGenreCheck.Text = "Check!";
            this.btnGenreCheck.UseVisualStyleBackColor = true;
            this.btnGenreCheck.Click += new System.EventHandler(this.btnGenreCheck_Click);
            // 
            // lbGenres
            // 
            this.lbGenres.AutoSize = true;
            this.lbGenres.Location = new System.Drawing.Point(204, 200);
            this.lbGenres.Name = "lbGenres";
            this.lbGenres.Size = new System.Drawing.Size(127, 16);
            this.lbGenres.TabIndex = 14;
            this.lbGenres.Text = "Genres available";
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(3, 219);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(100, 22);
            this.tbGenre.TabIndex = 13;
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(3, 164);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(100, 22);
            this.tbDuration.TabIndex = 12;
            // 
            // lbDur
            // 
            this.lbDur.AutoSize = true;
            this.lbDur.Location = new System.Drawing.Point(6, 145);
            this.lbDur.Name = "lbDur";
            this.lbDur.Size = new System.Drawing.Size(112, 16);
            this.lbDur.TabIndex = 11;
            this.lbDur.Text = "Song duration: ";
            // 
            // tbBand
            // 
            this.tbBand.Location = new System.Drawing.Point(3, 109);
            this.tbBand.Name = "tbBand";
            this.tbBand.Size = new System.Drawing.Size(256, 22);
            this.tbBand.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Name of the artist:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choose the genre!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name of the song:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add!";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add your custom song!";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(3, 56);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(256, 22);
            this.tbName.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lbOperation);
            this.panel3.Controls.Add(this.cbPlay);
            this.panel3.Controls.Add(this.lbPlaylistDuration);
            this.panel3.Controls.Add(this.btnPlayDuration);
            this.panel3.Controls.Add(this.lbTotalDuration);
            this.panel3.Controls.Add(this.btnDurationResult);
            this.panel3.Controls.Add(this.tbPlaylistName);
            this.panel3.Controls.Add(this.btnChangeName);
            this.panel3.Controls.Add(this.tbRemPlaylist);
            this.panel3.Controls.Add(this.tbAddPlaylist);
            this.panel3.Controls.Add(this.tbID);
            this.panel3.Controls.Add(this.btnDeleteSong);
            this.panel3.Controls.Add(this.btnRemovePlay);
            this.panel3.Controls.Add(this.btnAddPlay);
            this.panel3.Location = new System.Drawing.Point(396, 372);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(742, 271);
            this.panel3.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(564, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "To find a song by artist or by name, type in the full name/artist and hit the but" +
    "tons!";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(671, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "To delete a song, add it to  a playlist or remove it, simply type in the number o" +
    "f the desired song.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(688, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "To add a song, you simply type in the desired name, the artist, duration and genr" +
    "e and smash add! ";
            // 
            // lbOperation
            // 
            this.lbOperation.AutoSize = true;
            this.lbOperation.Location = new System.Drawing.Point(27, 177);
            this.lbOperation.Name = "lbOperation";
            this.lbOperation.Size = new System.Drawing.Size(117, 16);
            this.lbOperation.TabIndex = 22;
            this.lbOperation.Text = "How to operate:";
            // 
            // cbPlay
            // 
            this.cbPlay.AutoSize = true;
            this.cbPlay.Location = new System.Drawing.Point(30, 154);
            this.cbPlay.Name = "cbPlay";
            this.cbPlay.Size = new System.Drawing.Size(100, 20);
            this.cbPlay.TabIndex = 21;
            this.cbPlay.Text = "Play song!";
            this.cbPlay.UseVisualStyleBackColor = true;
            this.cbPlay.CheckedChanged += new System.EventHandler(this.cbPlay_CheckedChanged);
            // 
            // lbPlaylistDuration
            // 
            this.lbPlaylistDuration.FormattingEnabled = true;
            this.lbPlaylistDuration.ItemHeight = 16;
            this.lbPlaylistDuration.Location = new System.Drawing.Point(591, 71);
            this.lbPlaylistDuration.Name = "lbPlaylistDuration";
            this.lbPlaylistDuration.Size = new System.Drawing.Size(120, 36);
            this.lbPlaylistDuration.TabIndex = 20;
            // 
            // btnPlayDuration
            // 
            this.btnPlayDuration.Location = new System.Drawing.Point(371, 71);
            this.btnPlayDuration.Name = "btnPlayDuration";
            this.btnPlayDuration.Size = new System.Drawing.Size(214, 23);
            this.btnPlayDuration.TabIndex = 19;
            this.btnPlayDuration.Text = "Show playlist duration!";
            this.btnPlayDuration.UseVisualStyleBackColor = true;
            this.btnPlayDuration.Click += new System.EventHandler(this.btnPlayDuration_Click);
            // 
            // lbTotalDuration
            // 
            this.lbTotalDuration.FormattingEnabled = true;
            this.lbTotalDuration.ItemHeight = 16;
            this.lbTotalDuration.Location = new System.Drawing.Point(591, 16);
            this.lbTotalDuration.Name = "lbTotalDuration";
            this.lbTotalDuration.Size = new System.Drawing.Size(120, 36);
            this.lbTotalDuration.TabIndex = 18;
            // 
            // btnDurationResult
            // 
            this.btnDurationResult.Location = new System.Drawing.Point(371, 16);
            this.btnDurationResult.Name = "btnDurationResult";
            this.btnDurationResult.Size = new System.Drawing.Size(214, 23);
            this.btnDurationResult.TabIndex = 17;
            this.btnDurationResult.Text = "Show the total duration!";
            this.btnDurationResult.UseVisualStyleBackColor = true;
            this.btnDurationResult.Click += new System.EventHandler(this.btnDurationResult_Click);
            // 
            // tbPlaylistName
            // 
            this.tbPlaylistName.Location = new System.Drawing.Point(225, 114);
            this.tbPlaylistName.Name = "tbPlaylistName";
            this.tbPlaylistName.Size = new System.Drawing.Size(262, 22);
            this.tbPlaylistName.TabIndex = 8;
            // 
            // btnChangeName
            // 
            this.btnChangeName.Location = new System.Drawing.Point(19, 113);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(200, 23);
            this.btnChangeName.TabIndex = 2;
            this.btnChangeName.Text = "Change playlist name!";
            this.btnChangeName.UseVisualStyleBackColor = true;
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // tbRemPlaylist
            // 
            this.tbRemPlaylist.Location = new System.Drawing.Point(214, 84);
            this.tbRemPlaylist.Name = "tbRemPlaylist";
            this.tbRemPlaylist.Size = new System.Drawing.Size(100, 22);
            this.tbRemPlaylist.TabIndex = 7;
            // 
            // tbAddPlaylist
            // 
            this.tbAddPlaylist.Location = new System.Drawing.Point(147, 56);
            this.tbAddPlaylist.Name = "tbAddPlaylist";
            this.tbAddPlaylist.Size = new System.Drawing.Size(167, 22);
            this.tbAddPlaylist.TabIndex = 6;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(147, 27);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(167, 22);
            this.tbID.TabIndex = 5;
            // 
            // btnDeleteSong
            // 
            this.btnDeleteSong.Location = new System.Drawing.Point(19, 26);
            this.btnDeleteSong.Name = "btnDeleteSong";
            this.btnDeleteSong.Size = new System.Drawing.Size(122, 23);
            this.btnDeleteSong.TabIndex = 4;
            this.btnDeleteSong.Text = "Delete song!";
            this.btnDeleteSong.UseVisualStyleBackColor = true;
            this.btnDeleteSong.Click += new System.EventHandler(this.btnDeleteSong_Click);
            // 
            // btnRemovePlay
            // 
            this.btnRemovePlay.Location = new System.Drawing.Point(19, 84);
            this.btnRemovePlay.Name = "btnRemovePlay";
            this.btnRemovePlay.Size = new System.Drawing.Size(189, 23);
            this.btnRemovePlay.TabIndex = 2;
            this.btnRemovePlay.Text = "Remove from playlist!";
            this.btnRemovePlay.UseVisualStyleBackColor = true;
            this.btnRemovePlay.Click += new System.EventHandler(this.btnRemovePlay_Click);
            // 
            // btnAddPlay
            // 
            this.btnAddPlay.Location = new System.Drawing.Point(19, 55);
            this.btnAddPlay.Name = "btnAddPlay";
            this.btnAddPlay.Size = new System.Drawing.Size(122, 23);
            this.btnAddPlay.TabIndex = 0;
            this.btnAddPlay.Text = "Add to playlist!";
            this.btnAddPlay.UseVisualStyleBackColor = true;
            this.btnAddPlay.Click += new System.EventHandler(this.btnAddPlay_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "<---Simply click to sort by artists!";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Use spaces!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1150, 655);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbPlaylist);
            this.Controls.Add(this.lbSongs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Music App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPlaylist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbSongs;
        private System.Windows.Forms.ListBox lbPlaylist;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbBand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.Label lbDur;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRemovePlay;
        private System.Windows.Forms.Button btnAddPlay;
        private System.Windows.Forms.Button btnDeleteSong;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbRemPlaylist;
        private System.Windows.Forms.TextBox tbAddPlaylist;
        private System.Windows.Forms.TextBox tbPlaylistName;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.Button btnGenreCheck;
        private System.Windows.Forms.Label lbGenres;
        private System.Windows.Forms.Button btnDurationResult;
        private System.Windows.Forms.ListBox lbTotalDuration;
        private System.Windows.Forms.ListBox lbPlaylistDuration;
        private System.Windows.Forms.Button btnPlayDuration;
        private System.Windows.Forms.ListBox lbFindSong;
        private System.Windows.Forms.Button btnFindSong;
        private System.Windows.Forms.Button btnFindArtist;
        private System.Windows.Forms.TextBox tbFindSong;
        private System.Windows.Forms.CheckBox cbPlay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbOperation;
        private System.Windows.Forms.Button btnSortByArtist;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

