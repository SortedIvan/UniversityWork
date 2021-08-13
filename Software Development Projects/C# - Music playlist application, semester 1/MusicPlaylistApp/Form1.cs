using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MusicPlaylistApp //IVAN GEORGIEV OVCHAROV - PCB-02 - STUDENT NUMBER: 4090993
{
    

    public partial class Form1 : Form
    {
        private SoundPlayer _soundPlayer; // A little gimmick that I decided to implement for a song; hopefully no one sues for copyright!
        List<string> listOfSongs = new List<string>(); // 5 Different lists that are used to store all the data from the user!
        List<string> artistName = new List<string>();
        List<int> songsDuration = new List<int>();
        List<int> myPlaylist = new List<int>();
        List<string> Genre = new List<string>();


        string songName;
        string songArtist;
        int songDuration;
        string songGenre;
        int ID;
       
        private void ResetPlaylist() //Resets all the songs in the playlist, so when one is removed or added,
        {                            //it refreshes through them and adds everything that is still available.
            lbPlaylist.Items.Clear();
            int y = myPlaylist.Count;
            for(int i = 0; i < y; i++)
            {
                lbPlaylist.Items.Add(i + 1 + ") " + listOfSongs[myPlaylist[i]] + " - " + artistName[myPlaylist[i]] + " - " + Genre[myPlaylist[i]]);
                lbPlaylist.Items.Add("Duration: " + songsDuration[myPlaylist[i]] + " Seconds");
            }

        }
        private void Reset() //The reset or "refresh" method that is used to re-add all the available songs after adding/deleting something.
        {
            CountList();
            lbSongs.Items.Clear();
            for(int i = 0; i < ID; i++)
            {
                lbSongs.Items.Add( i+1 + ") " + listOfSongs[i] + " - " + artistName[i] + " - " + Genre[i]);
                lbSongs.Items.Add("Duration: " + songsDuration[i] + " Seconds");
            }
            
            
        }
        private void CountList() //Simple, but useful method that counts all the ID's of the songs
        {
            ID = listOfSongs.Count;
        }

        private void GetInfo() //This method is used to convert all the input from the user;
        {
            songName = Convert.ToString(tbName.Text);
            songArtist = Convert.ToString(tbBand.Text);
            songDuration = Convert.ToInt32(tbDuration.Text);
            songGenre = Convert.ToString(tbGenre.Text);

        }
        private void DefaultSong() //This method is used once upon launch, it adds some information on the listbox (songs);
        {
            
            listOfSongs.Add("Rockstar"); // Song name
            artistName.Add("Post Malone"); // Song artist
            Genre.Add("Rap"); // Song genre
            songsDuration.Add(143); //Song duration ( IN SECONDS, LATER CONVERTED TO MINUTES)

            listOfSongs.Add("Humble"); //1
            artistName.Add("Kendrick Lamar");
            Genre.Add("Rap");
            songsDuration.Add(145);


            listOfSongs.Add("Smooth Criminal"); //2
            artistName.Add("Michael Jackson");
            Genre.Add("Pop");
            songsDuration.Add(200);



            lbSongs.Items.Add(listOfSongs[0] + " - " + artistName[0] + " - " + Genre[0]);//0
            lbSongs.Items.Add("Duration: " + songsDuration[0] + " Seconds");
            lbSongs.Items.Add(listOfSongs[1] + " - " + artistName[1] + " - " + Genre[1]); //1
            lbSongs.Items.Add("Duration: " + songsDuration[1] + " Seconds");
            lbSongs.Items.Add(listOfSongs[2] + " - " + artistName[2] + " - " + Genre[2]); //2
            lbSongs.Items.Add("Duration: " + songsDuration[2] + " Seconds");
            CountList(); // ID = 3
        }


        public Form1()
        {
            InitializeComponent();
            DefaultSong();
            Reset();
            _soundPlayer = new SoundPlayer("Smooth_Criminal.wav");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            GetInfo();            
            listOfSongs.Add(songName); // This adds the name of the song.
            artistName.Add(songArtist); // This adds the artist.
            Genre.Add(songGenre); // This adds the genre.
            songsDuration.Add(songDuration); //This adds the duration of the song.
            Reset(); //This refreshes the songs overview.

        }

        private void btnDeleteSong_Click(object sender, EventArgs e) // The method that deletes songs entirely from both the playlist
                                                                    // and the other songs.
        {
            int idRemove = Convert.ToInt32(tbID.Text);
            listOfSongs.Remove(listOfSongs[idRemove - 1]);
            artistName.Remove(artistName[idRemove - 1]);
            Genre.Remove(Genre[idRemove - 1]);
            songsDuration.Remove(songsDuration[idRemove - 1]);

            Reset();
            int y = myPlaylist.Count;
            int changes = idRemove - 1;
            if(y > 0)
            {
                while (myPlaylist.Contains(changes))
                {
                    myPlaylist.Remove(idRemove - 1);
                    ResetPlaylist();
                }
               
            }


        }

        private void btnAddPlay_Click(object sender, EventArgs e) //Method to add songs in the playlist.
        {
            int idPlaylist = Convert.ToInt32(tbAddPlaylist.Text);
            myPlaylist.Add(idPlaylist - 1);
            ResetPlaylist();

        }

        private void btnChangeName_Click(object sender, EventArgs e) //Simple method to change the playlist's name.
        {
            string playlistName = Convert.ToString(tbPlaylistName.Text);
            lblPlaylist.Text = "Playlist: " + playlistName;
        }

        private void btnRemovePlay_Click(object sender, EventArgs e) //This button is used to remove songs from the playlist.
        {
           
            int y = myPlaylist.Count;
            if(y > 0)
            {
                int changes = Convert.ToInt32(tbRemPlaylist.Text);
                myPlaylist.Remove(myPlaylist[changes - 1]);
                ResetPlaylist();
            }
           
        }

        private void btnGenreCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pop, Rap, Rock, Country"); //A simple message box to show the available genres the user can pick from.
        }

        private void DurationCountTotal() //This method counts the total duration of all songs available.
        {
            lbTotalDuration.Items.Clear();
            double b = 0;
            for (int i = 0; i < songsDuration.Count; i++)
            {
                
                b += songsDuration[i];
            }

            b /= 60;
            b = Math.Round(b, 2);
            lbTotalDuration.Items.Add(b + " Minutes");
            

        }
        private void DurationCountPlaylist() // This method counts the total duration of the playlist.
        {
            lbPlaylistDuration.Items.Clear();
            double b = 0;
            for(int i = 0; i<myPlaylist.Count; i++)
            {
                b += songsDuration[myPlaylist[i]]; 
            }
            b /= 60;
            b = Math.Round(b, 2);
            lbPlaylistDuration.Items.Add(b + " Minutes");
        }

        private void showArtist() //This method is used to find a specific artist in the available songs.
        {
            string artistNames = Convert.ToString(tbFindSong.Text);
            string findingArtist = "";
            string findingArtist1 = "";
            for (int i = 0; i < artistName.Count; i++)
            {
                findingArtist = artistName[i];
                findingArtist1 = listOfSongs[i];
                if(artistNames == findingArtist)
                {
                    lbFindSong.Items.Add(findingArtist + " - " + findingArtist1);
                }
                
            }
        }
        private void showSong() //This method is to find a specific song in the list of songs.
        {
            string pesenName = Convert.ToString(tbFindSong.Text);
            string findingPesen = "";
            string findingPesen1 = "";
            for(int i = 0; i < listOfSongs.Count; i++)
            {
                findingPesen = listOfSongs[i];
                findingPesen1 = artistName[i];
                if(pesenName == findingPesen)
                {
                    lbFindSong.Items.Add(findingPesen + " - " + findingPesen1);
                }
            }
        }

        private void btnDurationResult_Click(object sender, EventArgs e) //Button for the duration result.
        {
            DurationCountTotal();
        }

        private void btnPlayDuration_Click(object sender, EventArgs e) // Button for the duration, but for the playlist.
        {
            DurationCountPlaylist();
        }

        private void btnFindArtist_Click(object sender, EventArgs e) //Button that finds the artist.
        {
            showArtist();
        }

        private void btnFindSong_Click(object sender, EventArgs e) //Button that finds the song.
        {
            showSong();
        }

        private void cbPlay_CheckedChanged(object sender, EventArgs e) //Method that allows the use of WAV files to be played.
        {                                                              //WARNING - LOUD!!!
            if (cbPlay.Checked)
            {
                _soundPlayer.Play();
            }
            else
            {
                _soundPlayer.Stop();
            }
        }
        private void sortByArtist() //This method sorts the artists by checking which ones repeat eachother.
        {                           //This method also took 3 hours and lots of tears to make.
            lbFindSong.Items.Clear();
           string songVariable = "";
            for (int g = 0; g < listOfSongs.Count; g++)
            {
                string checkVariable = artistName[g];
                for (int i = 0; i < listOfSongs.Count; i++)
                {
                    if (artistName[i].Contains(checkVariable))
                    {
                        songVariable = artistName[i];
                        lbFindSong.Items.Add(songVariable + " - " + listOfSongs[i]);
                    }
                    else if (listOfSongs.Count == lbFindSong.Items.Count) {
                        break;
                    }
                }
            }
         

        }

        private void label8_Click(object sender, EventArgs e) //Accidental method....
        {

        }

        private void btnSortByArtist_Click(object sender, EventArgs e)
        {
            sortByArtist();
        }
    }
}
//Wow! First time I have ever reached 300 lines of code.