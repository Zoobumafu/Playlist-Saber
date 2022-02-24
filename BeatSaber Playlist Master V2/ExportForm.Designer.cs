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
            this.pathTextbox = new System.Windows.Forms.TextBox();
            this.chooseLocationButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.playlistsToExportTreeview = new System.Windows.Forms.TreeView();
            this.allPlaylistsCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // allPlaylistsTreeView
            // 
            this.allPlaylistsTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.allPlaylistsTreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.allPlaylistsTreeView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.allPlaylistsTreeView.HideSelection = false;
            this.allPlaylistsTreeView.LabelEdit = true;
            this.allPlaylistsTreeView.Location = new System.Drawing.Point(10, 10);
            this.allPlaylistsTreeView.Name = "allPlaylistsTreeView";
            this.allPlaylistsTreeView.ShowLines = false;
            this.allPlaylistsTreeView.ShowPlusMinus = false;
            this.allPlaylistsTreeView.ShowRootLines = false;
            this.allPlaylistsTreeView.Size = new System.Drawing.Size(269, 158);
            this.allPlaylistsTreeView.TabIndex = 2;
            this.allPlaylistsTreeView.DoubleClick += new System.EventHandler(this.allPlaylistsTreeView_DoubleClick);
            // 
            // pathTextbox
            // 
            this.pathTextbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pathTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathTextbox.Location = new System.Drawing.Point(10, 201);
            this.pathTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pathTextbox.Name = "pathTextbox";
            this.pathTextbox.Size = new System.Drawing.Size(417, 23);
            this.pathTextbox.TabIndex = 5;
            // 
            // chooseLocationButton
            // 
            this.chooseLocationButton.BackColor = System.Drawing.SystemColors.GrayText;
            this.chooseLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chooseLocationButton.Location = new System.Drawing.Point(432, 201);
            this.chooseLocationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chooseLocationButton.Name = "chooseLocationButton";
            this.chooseLocationButton.Size = new System.Drawing.Size(128, 22);
            this.chooseLocationButton.TabIndex = 6;
            this.chooseLocationButton.Text = "Choose Location";
            this.chooseLocationButton.UseVisualStyleBackColor = false;
            this.chooseLocationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exportButton
            // 
            this.exportButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.exportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exportButton.Location = new System.Drawing.Point(285, 228);
            this.exportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(275, 22);
            this.exportButton.TabIndex = 7;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = false;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.IndianRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(10, 228);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(269, 22);
            this.button3.TabIndex = 8;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // playlistsToExportTreeview
            // 
            this.playlistsToExportTreeview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.playlistsToExportTreeview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playlistsToExportTreeview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playlistsToExportTreeview.HideSelection = false;
            this.playlistsToExportTreeview.Location = new System.Drawing.Point(285, 10);
            this.playlistsToExportTreeview.Name = "playlistsToExportTreeview";
            this.playlistsToExportTreeview.Size = new System.Drawing.Size(273, 157);
            this.playlistsToExportTreeview.TabIndex = 9;
            this.playlistsToExportTreeview.DoubleClick += new System.EventHandler(this.playlistsToExportTreeview_DoubleClick);
            // 
            // allPlaylistsCheckBox
            // 
            this.allPlaylistsCheckBox.AutoSize = true;
            this.allPlaylistsCheckBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.allPlaylistsCheckBox.Location = new System.Drawing.Point(10, 177);
            this.allPlaylistsCheckBox.Name = "allPlaylistsCheckBox";
            this.allPlaylistsCheckBox.Size = new System.Drawing.Size(120, 19);
            this.allPlaylistsCheckBox.TabIndex = 10;
            this.allPlaylistsCheckBox.Text = "Export all playlists";
            this.allPlaylistsCheckBox.UseVisualStyleBackColor = true;
            this.allPlaylistsCheckBox.CheckedChanged += new System.EventHandler(this.allPlaylistsCheckBox_CheckedChanged);
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(570, 257);
            this.Controls.Add(this.allPlaylistsCheckBox);
            this.Controls.Add(this.playlistsToExportTreeview);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.chooseLocationButton);
            this.Controls.Add(this.pathTextbox);
            this.Controls.Add(this.allPlaylistsTreeView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ExportForm";
            this.Text = "ExportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TreeView allPlaylistsTreeView;
        private System.Windows.Forms.TextBox pathTextbox;
        private System.Windows.Forms.Button chooseLocationButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TreeView playlistsToExportTreeview;
        private System.Windows.Forms.CheckBox allPlaylistsCheckBox;
    }
}