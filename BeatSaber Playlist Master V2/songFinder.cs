using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeatSaber_Playlist_Master_V2
{
    public partial class songFinder : Form
    {
        Form1 mainForm;
        public songFinder(Form1 form1)
        {
            InitializeComponent();
            // Get access to main form resources
            mainForm = form1;

            // Populate Playlists treeview
            mainForm.populatePlaylists(mainForm.playlists, playlistTreeView, true);

            // Add headers for the list
            /*
             * 1 - Song Name
             * 2 - Rating
             * 3 - Author
             * 4 - Difficulties
             * 5 - Download
             */

            //            DataGridViewColumn nameHeader = new DataGridViewComboBoxColumn();


            DataGridViewRow dataGridViewRow = new DataGridViewRow();
            DataGridViewCell nameCell = new DataGridViewHeaderCell();

            dataGridViewRow.Cells.Add(nameCell);
            //songListView.Rows.Add(dataGridViewRow);


            Button newButton = new Button();
            this.Controls.Add(newButton);
            newButton.Text = "Download";

            int counter = 0;

            //Create new button.
            Button button = new Button();

            //Set name for a button to recognize it later.
            button.Name = "Butt" + counter;

            // you can added other attribute here.
            button.Text = "New";
            button.Location = new Point(70, 70);
            button.Size = new Size(100, 100);

            // Increase counter for adding new button later.
            counter++;

            // add click event to the button.
            button.Click += new EventHandler(NewButton_Click);


            void NewButton_Click(object sender, EventArgs e)
            {
                Button btn = (Button)sender;

                for (int i = 0; i < counter; i++)
                {
                    if (btn.Name == ("Butt" + i))
                    {
                        // When find specific button do what do you want.
                        //Then exit from loop by break.
                        break;
                    }
                }
            }

            //songListView.Rows.Add("name1", "name2", "name3", "name4");
          



        }

        private void playlistTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
