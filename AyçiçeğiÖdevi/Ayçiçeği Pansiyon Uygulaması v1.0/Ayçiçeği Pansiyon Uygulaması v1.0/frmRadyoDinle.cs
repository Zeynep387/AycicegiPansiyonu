﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayçiçeği_Pansiyon_Uygulaması_v1._0
{
    public partial class frmRadyoDinle : Form
    {
        public frmRadyoDinle()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://n10101m.mediatriple.net/numberoneturk";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://n10101m.mediatriple.net/trdamar";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://n10101m.mediatriple.net/numberone";
        }
    }
}
