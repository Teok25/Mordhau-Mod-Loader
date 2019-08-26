using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using Ionic.Zip;
using System.Xml;

namespace MordhauModManager
{
    public partial class Form1 : Form
    {

        List<modData> modList = new List<modData>(); //Full mod list.
        List<modData> active = new List<modData>(); //Active mods.
        List<modData> inactive = new List<modData>(); //Inactive mods.
        

        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle; //stops resizing
            MaximizeBox = false;
            string steamPath = FindSteam(); //gets 
           // TestUnzip();
            
            
        }
        public class modData
        {
            public string name;
            public string author;
            public string description;
            public string version;
            public string folderName;
            public string targetDirectory;
            public string releaseDate;
            public double fileSize;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadZip = new OpenFileDialog();
            loadZip.Title = "Locate Mod Zip Folder";
            loadZip.InitialDirectory = Environment.CurrentDirectory;
            loadZip.RestoreDirectory = true;
            loadZip.Filter = "Zip files (*.zip)|*.zip|All files (*.*)|*.*";
            loadZip.DefaultExt = "zip";

            if (loadZip.ShowDialog() == DialogResult.OK)
            {
                string file = loadZip.FileName;
                string sFile = loadZip.SafeFileName;
                Directory.CreateDirectory(Application.StartupPath + @"\Mods\ZipFileCache");
                Directory.CreateDirectory(Application.StartupPath + @"\Mods\tmp"); //creates temp directory for checking if mod is already in the list.
                string destinationTemp = AppDomain.CurrentDomain.BaseDirectory + @"Mods\ZipFileCache\";
                string destination = AppDomain.CurrentDomain.BaseDirectory+ @"Mods\ZipFileCache\";


                //CHECKING IF MOD ALREADY EXISTS IN MODLIST
                File.Copy(file, destinationTemp + sFile, true);
                ZipUnloader(file, sFile, true); //unloads zip into an unzipped file, allowing easy access, temp = true so unzips to temp
                var dirTemp = AppDomain.CurrentDomain.BaseDirectory + @"Mods\tmp\" + (sFile.TrimEnd('.', 'z', 'i', 'p') + @"\");
                bool existsInList = false;
                if (File.Exists(dirTemp + "about.xml") == true || modList == null)
                {
                    XmlDocument about = new XmlDocument();
                    about.Load(dirTemp + "about.xml");

                    XmlNodeList elemList = about.GetElementsByTagName("name");
                    string xName = elemList[0].InnerXml;
                    elemList = about.GetElementsByTagName("author");
                    string xAuthor = elemList[0].InnerXml;
                    elemList = about.GetElementsByTagName("version");
                    string xVers = elemList[0].InnerXml;
                    elemList = about.GetElementsByTagName("description");
                    string xDesc = elemList[0].InnerXml;
                    
                    foreach (modData mod in modList)
                    {
                        int i = 0;
                        if (xName == modList[i].name && xAuthor == modList[i].author && xVers == modList[i].version && xDesc == modList[i].description)
                        {
                            existsInList = true;
                            MessageBox.Show("Mod already exists in your library.", "Error");
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    Directory.Delete(AppDomain.CurrentDomain.BaseDirectory + @"Mods\tmp\", true);
                }
                if (existsInList == false)
                {
                    File.Copy(file, destination + sFile, true);
                    ZipUnloader(file, sFile, false);
                    var dir = AppDomain.CurrentDomain.BaseDirectory + @"Mods\" + (sFile.TrimEnd('.', 'z', 'i', 'p') + @"\");
                    if (File.Exists(dir + "about.xml") == true)
                    {
                        var about = new XmlDocument();
                        about.Load(dir + "about.xml");
                        var elemList = about.GetElementsByTagName("name");
                        string xName = elemList[0].InnerXml;
                        elemList = about.GetElementsByTagName("author");
                        string xAuthor = elemList[0].InnerXml;
                        elemList = about.GetElementsByTagName("version");
                        string xVers = elemList[0].InnerXml;
                        elemList = about.GetElementsByTagName("description");
                        string xDesc = elemList[0].InnerXml;
                        elemList = about.GetElementsByTagName("releaseDate");
                        string xReleaseDate = elemList[0].InnerXml;

                        var fi = new FileInfo(file);
                        double xFileSize = ((fi.Length) / 1000);



                        InactiveMods.Items.Add(xName);
                        modList.Add(new modData() { name = xName, author = xAuthor, version = xVers, description = xDesc, releaseDate = xReleaseDate, fileSize = xFileSize });
                        inactive.Add(new modData() { name = xName, author = xAuthor, version = xVers, description = xDesc, releaseDate = xReleaseDate, fileSize = xFileSize });


                    }
                    else { }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(InactiveMods.SelectedItem != null)
            {
                ActiveMods.Items.Add(InactiveMods.SelectedItem);
                modList.Sort();
                var ms = new ModSearch(InactiveMods.SelectedItem.ToString()); //finds the index
                int index = modList.FindIndex(ms.StartWith); //finds the index
                active.Add(modList[index]);
                inactive.Remove(modList[index]);
                InactiveMods.Items.RemoveAt(InactiveMods.SelectedIndex);
                
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(ActiveMods.SelectedItem != null)
            {
                InactiveMods.Items.Add(ActiveMods.SelectedItem);
                modList.Sort();
                var ms = new ModSearch(ActiveMods.SelectedItem.ToString());
                int index = modList.FindIndex(ms.StartWith);
                inactive.Add(modList[index]);
                active.Remove(modList[index]);
                ActiveMods.Items.RemoveAt(ActiveMods.SelectedIndex);
                
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (InactiveMods.SelectedItem != null)
            {
                for (int i = 0; i < modList.Count; i++)
                {
                    if (InactiveMods.SelectedItem.ToString() == modList[i].name)
                    {
                        modList.Remove(modList[i]);
                        
                    }
                }
                InactiveMods.Items.RemoveAt(InactiveMods.SelectedIndex);
                

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 help = new Form3();
            help.ShowDialog();
        }

        private string FindSteam()
        {
            var mhPath = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 629760", "InstallLocation", string.Empty);
            if (mhPath != null)
            {
                if (!File.Exists($@"{mhPath}\Mordhau.exe"))
                {
                    //Found, but invalid
                    mhPath = null;
                }
                else
                {
                    //found it successfully
                }
            }
                if (string.IsNullOrEmpty(mhPath))
                    mhPath = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Valve\Steam", "InstallPath", string.Empty);
                if (string.IsNullOrEmpty(mhPath))
                    mhPath = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", mhPath);
                return mhPath ?? string.Empty;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        public class ModSearch
        {
            string _s;

            public ModSearch(string s)
            {
                _s = s;
            }

            public bool StartWith(modData e)
            {
                return e.name.StartsWith(_s, StringComparison.InvariantCultureIgnoreCase);
            }
        }

        public void TestUnzip()
        {
            DirectoryInfo di = Directory.CreateDirectory(Application.StartupPath + @".\Mods\Temp"); //creates temp folder if not already there.
            string destination = AppDomain.CurrentDomain.BaseDirectory + @".\Mods\";
            string zipPath = destination + "TestMod.zip";
            string extractPath = destination + @"Temp\";

            using (ZipFile zip = ZipFile.Read(zipPath))
            {
                foreach (ZipEntry e in zip)
                {
                    e.Extract(extractPath, ExtractExistingFileAction.OverwriteSilently);
                }
            }
            
        }

        public void ZipUnloader(string zipDir, string safeZipDir, bool temp)
        {
            string destination;
            if (temp == true)
            {
                Directory.CreateDirectory(Application.StartupPath + @"\Mods\tmp\" + (safeZipDir.TrimEnd('.', 'z', 'i', 'p')));
                destination = AppDomain.CurrentDomain.BaseDirectory + @"\Mods\tmp\" + (safeZipDir.TrimEnd('.', 'z', 'i', 'p'));
            }
            else
            {
                Directory.CreateDirectory(Application.StartupPath + @"\Mods\" + (safeZipDir.TrimEnd('.', 'z', 'i', 'p')));
                destination = AppDomain.CurrentDomain.BaseDirectory + @"\Mods\" + (safeZipDir.TrimEnd('.', 'z', 'i', 'p'));
            }
            using (ZipFile zip = ZipFile.Read(zipDir)) //need to add a conditional to check if this zipDir is valid
            {
                
                foreach (ZipEntry entry in zip)
                {
                    
                    entry.Extract(destination, ExtractExistingFileAction.OverwriteSilently);
                }
            }
        }

        private void InactiveMods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InactiveMods.SelectedItem != null)
            {
                var ms = new ModSearch(InactiveMods.SelectedItem.ToString()); //finds the index
                int index = modList.FindIndex(ms.StartWith); //finds the index
                ModNameLabel.Text = modList[index].name;
                ModAuthorsLabel.Text = modList[index].author;
                ModDescriptionLabel.Text = modList[index].description;
                ModVersionLabel.Text = modList[index].version;
                ModReleaseDateLabel.Text = modList[index].releaseDate;
                ModSizeLabel.Text = modList[index].fileSize.ToString() + " KB";
            }
        }

        private void ActiveMods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ActiveMods.SelectedItem != null)
            {
                var ms = new ModSearch(ActiveMods.SelectedItem.ToString()); //finds the index
                int index = modList.FindIndex(ms.StartWith); //finds the index
                ModNameLabel.Text = modList[index].name;
                ModAuthorsLabel.Text = modList[index].author;
                ModDescriptionLabel.Text = modList[index].description;
                ModVersionLabel.Text = modList[index].version;
                ModReleaseDateLabel.Text = modList[index].releaseDate;
                ModSizeLabel.Text = modList[index].fileSize.ToString() + " KB";
            }
        }
    }
}

 

