namespace BeatSaber_Playlist_Master_V2
{
    partial class ExportForm
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
            this.allPlaylistsTreeView = new System.Windows.Forms.TreeView();
            this.playlistsToExportTreeview = new System.Windows.Forms.TreeView();
            this.pathTextbox = new System.Windows.Forms.TextBox();
            this.chooseLocationButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allPlaylistsTreeView
            // 
            this.allPlaylistsTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.allPlaylistsTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allPlaylistsTreeView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.allPlaylistsTreeView.HideSelection = false;
            this.allPlaylistsTreeView.LabelEdit = true;
            this.allPlaylistsTreeView.Location = new System.Drawing.Point(12, 13);
            this.allPlaylistsTreeView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.allPlaylistsTreeView.Name = "allPlaylistsTreeView";
            this.allPlaylistsTreeView.ShowLines = false;
            this.allPlaylistsTreeView.ShowPlusMinus = false;
            this.allPlaylistsTreeView.ShowRootLines = false;
            this.allPlaylistsTreeView.Size = new System.Drawing.Size(322, 210);
            this.allPlaylistsTreeView.TabIndex = 2;
            this.allPlaylistsTreeView.DoubleClick += new System.EventHandler(this.allPlaylistsTreeView_DoubleClick);
            // 
            // playlistsToExportTreeview
            // 
            this.playlistsToExportTreeview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.playlistsToExportTreeview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlistsToExportTreeview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playlistsToExportTreeview.HideSelection = false;
            this.playlistsToExportTreeview.LabelEdit = true;
            this.playlistsToExportTreeview.Location = new System.Drawing.Point(340, 13);
            this.playlistsToExportTreeview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playlistsToExportTreeview.Name = "playlistsToExportTreeview";
            this.playlistsToExportTreeview.ShowLines = false;
            this.playlistsToExportTreeview.ShowPlusMinus = false;
            this.playlistsToExportTreeview.ShowRootLines = false;
            this.playlistsToExportTreeview.Size = new System.Drawing.Size(300, 210);
            this.playlistsToExportTreeview.TabIndex = 4;
            this.playlistsToExportTreeview.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.playlistsToExportTreeview_AfterSelect);
            // 
            // pathTextbox
            // 
            this.pathTextbox.Location = new System.Drawing.Point(12, 230);
            this.pathTextbox.Name = "pathTextbox";
            this.pathTextbox.Size = new System.Drawing.Size(476, 27);
            this.pathTextbox.TabIndex = 5;
            // 
            // chooseLocationButton
            // 
            this.chooseLocationButton.Location = new System.Drawing.Point(494, 230);
            this.chooseLocationButton.Name = "chooseLocationButton";
            this.chooseLocationButton.Size = new System.Drawing.Size(146, 29);
            this.chooseLocationButton.TabIndex = 6;
            this.chooseLocationButton.Text = "Choose Location";
            this.chooseLocationButton.UseVisualStyleBackColor = true;
            this.chooseLocationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(340, 265);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(300, 29);
            this.exportButton.TabIndex = 7;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(322, 29);
            this.button3.TabIndex = 8;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 304);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.chooseLocationButton);
            this.Controls.Add(this.pathTextbox);
            this.Controls.Add(this.playlistsToExportTreeview);
            this.Controls.Add(this.allPlaylistsTreeView);
            this.Name = "ExportForm";
            this.Text = "ExportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TreeView allPlaylistsTreeView;
        public System.Windows.Forms.TreeView playlistsToExportTreeview;
        private System.Windows.Forms.TextBox pathTextbox;
        private System.Windows.Forms.Button chooseLocationButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button button3;
    }
}