using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoEmbed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string _ytUrl;

        public string VideoId
        {
            get
            {
                var ytMatch = new Regex("//insert youtube flash here").Match(_ytUrl);
                return ytMatch.Success ? ytMatch.Groups[1].Value : string.Empty;
            }
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            _ytUrl = txtUrl.Text;
            webBrowser.Navigate($"http://youtube.com/v/{VideoId}?version=3");
        }
    }
}
