using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace Trove_Mod_Manager
{
    public partial class Form3 : Form
    {
        public Form3(string name, string author, string type, string subtype, string totaldownloads, string image, string id, Form1.Downloads downloads, string replaces)
        {
            InitializeComponent();
            /*string exeDirect = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            mod jsonArray = JsonConvert.DeserializeObject<mod>(File.ReadAllText(exeDirect + "\\" + "modTransfer.txt"));
           
            jsonArray.name = modSearchedName.Text;
            */
            modSearchedName.Text = name;
            authorText.Text = author;
            typeLabel.Text = type;
            subTypeLabel.Text = subtype;
            totalDownloadsLabel.Text = "Total Downloads : " + totaldownloads;
            try
            {
                modImage.Load(@"https://www.trovesaurus.com/" + image);
                modImage.SizeMode = PictureBoxSizeMode.CenterImage;
                modImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            { }

            searchedModReplaces.Text = replaces;

            //modDLFeedback.Text = modImage.ImageLocation;
            IDBox.Text = id;
            fileIDBox.Text = downloads.fileid;

            string link = @"https://www.trovesaurus.com/mod=" + id + "/" + name.Replace(" ", "-").Replace(",", "").Replace(":", "");
            linkTEXT.Text = link;
            try
            {
                tSaurusLoc.ImageLocation = (@"https://www.trovesaurus.com/images/trovesauruslogo.png");
                tSaurusLoc.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            

        }
        public class mod
        {
             public string id;
            
            public string name;
            public string author;
            public string type;
            public string subtype;
            public string status2;
            public string replaces;
            public string totaldownloads;
            public int votes;
            public int rating;
            public string[] downloads;
            public string image;
            

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void downloadMod_Click(object sender, EventArgs e)
        {

            try
            {
                string exeDirect = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                string txtFileName = exeDirect + "\\" + "ModLoader.txt";

                StreamReader reader = new StreamReader(txtFileName, false);
                string liveFolderLoc = reader.ReadLine();
                reader.Close();




                if (!(liveFolderLoc == null))
                {

                    string zipFileName = modSearchedName.Text;
                    using (WebClient wc = new WebClient())
                    {

                        string zipFile = @"http://www.Trovesaurus.com/mod.php?id=" + IDBox.Text + "&download=" + fileIDBox.Text;


                        wc.DownloadFile(zipFile, exeDirect + "\\ModList" + "\\" + modSearchedName.Text + ".zip");


                    }

                    string zipLoc = exeDirect + "\\Modlist\\" + modSearchedName.Text + ".zip";



                    string storageName = exeDirect + "\\" + "Modlist";



                    //
                    // Extracts from Zip File to modList Directory
                    //
                    if (!System.IO.Directory.Exists(storageName + "\\" + zipFileName))
                    {
                        try
                        {
                            ZipFile.ExtractToDirectory(zipLoc, storageName + "\\" + zipFileName);
                        }
                        catch
                        {

                        }
                    }
                    else
                    {
                        System.IO.Directory.Delete(storageName + "\\" + zipFileName, true);
                        ZipFile.ExtractToDirectory(zipLoc, storageName + "\\" + zipFileName);
                    }
                    try
                    {
                        string[] dirNames = System.IO.Directory.GetDirectories(storageName + "\\" + zipFileName);

                        //
                        // Applies Files to corresponding overrides
                        //

                        foreach (string dirName in dirNames)
                        {
                            string dirNameEdit = dirName.Remove(0, dirName.LastIndexOf("\\") + 1);
                            
                            string[] dirFiles = System.IO.Directory.GetFiles(dirName);
                            foreach (string d in dirFiles)
                            {
                                if (!System.IO.Directory.Exists(liveFolderLoc + "\\" + dirNameEdit + "\\" + "override"))
                                {
                                    System.IO.Directory.CreateDirectory(liveFolderLoc + "\\" + dirNameEdit + "\\" + "override");
                                }
                                string mFileName = System.IO.Path.GetFileName(d);
                                string overFileName = System.IO.Path.Combine(liveFolderLoc + "\\" + dirNameEdit + "\\" + "override", mFileName);
                                System.IO.File.Delete(overFileName);
                            }
                            foreach (string d in dirFiles)
                            {

                                string mFileName = System.IO.Path.GetFileName(d);
                                string overFileName = System.IO.Path.Combine(liveFolderLoc + "\\" + dirNameEdit + "\\" + "override", mFileName);
                                System.IO.File.Copy(d, overFileName, true);
                            }
                        }

                        modDLFeedback.ForeColor = Color.Green;
                        modDLFeedback.Text = "Mod Installed";

                    }
                    catch
                    {
                        modDLFeedback.Text = "couldn't Download";
                    }



                }
                else
                {
                    modDLFeedback.ForeColor = Color.Red;
                    modDLFeedback.Text = "Choose a Live Path";
                }

            }
            catch
            {
                modDLFeedback.ForeColor = Color.Red;
                modDLFeedback.Text = "Could not connect to Trovesaurus";
            }
        }

        private void subTypeLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(subTypeLabel.Text);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tSaurusLoc_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(linkTEXT.Text);
            }
            catch {
                modDLFeedback.ForeColor = Color.Red;
                modDLFeedback.Text = "Could not connect to Trovesaurus";
            }
            
        }
    }
}
