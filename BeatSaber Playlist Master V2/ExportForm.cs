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
    public partial class ExportForm : Form
    {
        Form1 mainForm;
        public ExportForm(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            mainForm.populatePlaylists(mainForm.playlists, allPlaylistsTreeView);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    pathTextbox.Text = fbd.SelectedPath;
                }
            }

        }

        private void allPlaylistsTreeView_DoubleClick(object sender, EventArgs e)
        {
            TreeNode nodeToTransfer = allPlaylistsTreeView.SelectedNode;
            allPlaylistsTreeView.Nodes.Remove(nodeToTransfer);
            playlistsToExportTreeview.Nodes.Add(nodeToTransfer);
        }

       /* private void playlistsToExportTreeview_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode nodeToTransfer = playlistsToExportTreeview.SelectedNode;
            playlistsToExportTreeview.Nodes.Remove(nodeToTransfer);
            allPlaylistsTreeView.Nodes.Add(nodeToTransfer);
        }*/

        private void exportButton_Click(object sender, EventArgs e)
        {
            List<Playlist> playlistsToExport = new List<Playlist>();
            
            if (allPlaylistsCheckBox.Checked)
                playlistsToExport = mainForm.playlists;
            else
                for (int i = 0; i < playlistsToExportTreeview.Nodes.Count; i++)
                    playlistsToExport.Add((Playlist)playlistsToExportTreeview.Nodes[i].Tag);

            mainForm.exportPlaylists(playlistsToExport, pathTextbox.Text);

            this.Close();
            this.Dispose();
        }

        private void playlistsToExportTreeview_DoubleClick(object sender, EventArgs e)
        {
            TreeNode nodeToTransfer = playlistsToExportTreeview.SelectedNode;
            playlistsToExportTreeview.SelectedNode.Remove();
            allPlaylistsTreeView.Nodes.Add(nodeToTransfer);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void allPlaylistsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (allPlaylistsCheckBox.Checked)
            {
                allPlaylistsTreeView.Enabled = false;
                playlistsToExportTreeview.Enabled = false;
            }
            else
            {
                allPlaylistsTreeView.Enabled = true;
                playlistsToExportTreeview.Enabled = true;
            }
        }
    }
}
