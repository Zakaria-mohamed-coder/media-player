using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace smx_media_player
{
    public partial class panelsidemenu : Form
    {
      
        private string FileName;
        public panelsidemenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listfile_selectedindex(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd=new OpenFileDialog (){ Multiselect=true,ValidateNames=true,Filter="WMV|*.wmv|WAV|*.wav*|.MP3|mp3|MP4|*.mp4|MKV|*.mkv"})
            {
                if(ofd.ShowDialog()==DialogResult.OK)
                {
                    List<MEDIAFILE> File = new List<MEDIAFILE>();
                    foreach(string FileName in ofd.FileNames)
                    {
                        FileInfo fi =new FileInfo(FileName);
                        files.Add(new MEDIAFILE() { FileName = Path.GetFileNameWithoutExtension(fi.FullName), Path = fi.FullName });
                    }
                    listFile.DataSource = files;
                    
                }
                   
            }
        }

        private void filesA(MEDIAFILE mEDIAFILE)
        {
            throw new NotImplementedException();
        }

        private void filesAdd(MEDIAFILE mEDIAFILE)
        {
            throw new NotImplementedException();
        }

        private void bntOpen_Click(object sender, EventArgs e)
        {

        }

        public string fileNames { get; set; }

        public object files { get; set; }

        private void panelsidemenu_Load(object sender, EventArgs e)
        {
            listFile.ValueMember = "Path";
            listFile.DisplayMember = "FileName";
        }

        private void listFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            MEDIAFILE File = listFile.SelectedItem as MEDIAFILE;
            if( file !=null)
            {
                axWindowsMediaPlayer.URL = file.path;
                axWindowsMediaPlayer.Ctlcontrols.play();
            }
        }

        public object file { get; set; }
    }
}
