using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Diagnostics;

namespace VRChat_Offline_World_Loader
{
    public partial class VRChatOfflineWorldLoader : Form
    {
        public VRChatOfflineWorldLoader()
        {
            InitializeComponent();
        }

        private void VRChatOfflineWorldLoader_Load(object sender, EventArgs e)
        {
            if (!File.Exists("Settings/errorworld.vrcw"))
            {
                Directory.CreateDirectory("Settings");
                byte[] errorworld = new WebClient().DownloadData("https://raw.githubusercontent.com/tuckerisapizza/VRCHATSERVER-Launcher/main/errorworld.vrcw");
                File.WriteAllBytes("Settings/errorworld.vrcw", errorworld);
                File.WriteAllText("Settings/vrchatpath.txt", "");
                File.WriteAllText("Settings/vrcwpath.txt", "");
            }
            else
            {
                textBox1.Text = File.ReadAllText("Settings/vrchatpath.txt");
                textBox2.Text = File.ReadAllText("Settings/vrcwpath.txt");
                vrchatpath = textBox1.Text;
                vrcwpath = textBox2.Text;
            }
        }



        private string vrchatpath = "";
        private string vrcwpath = "";

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult folder = folderBrowserDialog1.ShowDialog();
            if (folder == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            vrchatpath = textBox1.Text;
            File.WriteAllText("Settings/vrchatpath.txt", vrchatpath);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult file = openFileDialog1.ShowDialog();
            if (file == DialogResult.OK)
            {
                textBox2.Text = openFileDialog1.FileName;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            vrcwpath = textBox2.Text;
            File.WriteAllText("Settings/vrcwpath.txt", vrcwpath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //update world
            try
            {
                File.Copy(vrcwpath, vrchatpath + "/VRChat_Data/StreamingAssets/Worlds/errorworld.vrcw", true);
            }
            catch { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //open vrchat
            Process.Start(vrchatpath + "/VRChat.exe");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //resetworld
            try
            {
                File.Copy("Settings/errorworld.vrcw", vrchatpath + "/VRChat_Data/StreamingAssets/Worlds/errorworld.vrcw", true);
            }
            catch { }
        }
    }
}