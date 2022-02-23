﻿using System;
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
    public partial class LoadingForm : Form
    {
        public LoadingForm(string topText, string bottomText)
        {
            InitializeComponent();
            topLabel.Text = topText;
            bottomLabel.Text = bottomText;
        }
    }
}
