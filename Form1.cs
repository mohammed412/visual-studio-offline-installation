using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace offline_installation
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            ProcessStartInfo prcs = new ProcessStartInfo();
            prcs.FileName = "cmd";
            prcs.Arguments = "/K" + "py visual_studio_downloader.py";

            Process.Start(prcs);
            InitializeComponent();
        }
    }
}
