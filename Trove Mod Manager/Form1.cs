using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Microsoft.Win32;
using System.Security.Permissions;

using System.IO;
using System.IO.Compression;
using System.Windows.Forms;



namespace Trove_Mod_Manager
{
    public partial class Form1 : Form 
    {
        

        public Form1()
        {
            InitializeComponent();
            logwriter("initialize");
           
            //
            //Writes line for exiting program...
            //
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);

            string exeDirect = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            // Sets debug feedback to not be visible. This is located in "My Mods" under remove button for further use
            feedBackThing.Visible = false;
            checkT.Visible = false;

            //
            //Centers Text Boxes
            //
            richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

            richTextBox2.SelectAll();
            richTextBox2.SelectionAlignment = HorizontalAlignment.Center;

            setupTextBox.SelectAll();
            setupTextBox.SelectionAlignment = HorizontalAlignment.Center;

            label3.TextAlign = ContentAlignment.MiddleCenter;

            feedbackPageText.SelectAll();
            feedbackPageText.SelectionAlignment = HorizontalAlignment.Center;

            //
            //Create ModLoader text file if not already created. This is used for finding the Trove Live folder
            //
            if (!File.Exists(exeDirect + "\\" + "ModLoader.txt"))
            {
                File.Create(exeDirect + "\\" + "ModLoader.txt");
            }

            //
            // Read Modloader file and Set the Path Text under the Initial Setup tab.
            //
            string txtFileName = exeDirect + "\\" + "ModLoader.txt";
            
            StreamReader reader = new StreamReader(txtFileName, false);
            pathName.Text = reader.ReadLine();
            reader.Close();
            //
            // Start on home tab if a path was already found.
            //
                                                                          //tabControl1.SelectedTab = HomeTab;
;
            //
            // Check / Create ModList Directory to unzip mods into
            //
            if (!System.IO.Directory.Exists(exeDirect + "\\" + "ModList"))
            {
                System.IO.Directory.CreateDirectory(exeDirect + "\\" + "ModList");
                logwriter("ModList Directory Created.");
            }
            string storageName = exeDirect + "\\" + "Modlist";

            //
            // Creates the Mod List found in the My Mods tab.
            //
            string[] modLister = System.IO.Directory.GetDirectories(storageName + "\\");
            
            for (int i=0; i <= modLister.Length-1; i++)
            {
                modLister[i] = modLister[i].Remove(0, modLister[i].LastIndexOf("\\") + 1);
            }
     
            modList.DataSource = modLister;
            modList.Select();

            //
            // Download Trovesaurus Mod List [JSON FORMAT]
            //
            
            logwriter("Attempting to Connect to Trovesaurus...");
            try
            {
                using (WebClient wc = new WebClient())
                {
                    
                    string json = wc.DownloadString("https://www.trovesaurus.com/modsapi.php?mode=list");
                    
                    System.IO.File.WriteAllText(exeDirect + "\\" + "Data.txt", json);
                }
                logwriter("Successfully Downloaded Json file from Trovesaurus");
                
            }
            catch
            {
                logwriter("Could not download Json file from Trovesaurus");
            }
            
            //
            // Deserialize the Trovesaurus data and sort it out to be listed and filtered under the Search for Mods tab.
            //
            List<Obj> jsonArray = JsonConvert.DeserializeObject<List<Obj>>(File.ReadAllText(exeDirect + "\\" + "Data.txt"));
            List<string> nameString = new List<string>();
            List<string> typeString = new List<string>();
            typeString.Add("ALL");
            foreach (Obj obj in jsonArray)
            {
                if (!typeString.Contains(obj.type))
                {
                    typeString.Add(obj.type);
                }
            }
            typeString.Sort();
            filterBox.DataSource = typeString;

            
            foreach (Obj obj in jsonArray)
                {
                    nameString.Add(obj.name);
                }
                List<string> nameReverse = nameString;
                nameReverse.Reverse();
                modSearchNames.DataSource = nameReverse;

            

            

        }

        
        public class Obj
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
            public List<Downloads> downloads;
            public string image;

        }
        public class Downloads
        {
            public string fileid { get; set; }
            public string version { get; set; }
            public string date { get; set; }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest_1(object sender, EventArgs e)
        {

        }

        //
        // For manually choosing a Live Folder Path
        //
        private void button1_Click(object sender, EventArgs e)
        {
            logwriter("User manually choosing Live Folder Path...");
            
            //DECLARE VARIABLES TO BE USED

            string exeDirect = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string txtFileName = exeDirect + "\\" + "ModLoader.txt";

            selectPath.ShowDialog();
            string path = selectPath.SelectedPath;
            pathName.Text = path;

            logwriter("manual user path =" + path);
            
            //Checks if chosen path seems logical as a Live folder... by name.
            if (!path.EndsWith("Live"))
            {
                feedbackSetup.ForeColor = Color.Red;
                feedbackSetup.Text = "Path does not lead to a Live folder. Consider checking the path again";
                logwriter("manual user path did not lead to a live folder.");
            }
            else
            {
                feedbackSetup.ForeColor = Color.Green;
                feedbackSetup.Text = "Live folder path successfully recorded";
                logwriter("Live folder path successfully found");
            }
             
            // Overwrites the current ModLoader Text with new data   
            if (File.Exists(txtFileName))
            {
                File.Delete(txtFileName);
                logwriter("Overwriting ModLoader.txt... [DELETING]");
            }

            logwriter("Overwriting ModLoader.txt... [CREATING]");

            StreamWriter writer = new StreamWriter(txtFileName);
            writer.WriteLine(pathName.Text);
            writer.Close();

            logwriter("Overwriting ModLoader.txt... [READING AND ASSIGNING TO PATHNAME TEXT BOX]");

            StreamReader reader = new StreamReader(txtFileName, false);
            pathName.Text = reader.ReadLine();
            reader.Close();
        }

        void pathName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //
            // Installing mod via user dialog
            //
            
            
            try
            {
                logwriter("User choosing .zip file path");

                zipFileUser.FileName = "";
                zipFileUser.DefaultExt = ".zip";
                zipFileUser.ShowDialog();
                string zipFile = zipFileUser.FileName;

                logwriter("User .zip path = " + zipFile);

                string zipFileName = zipFile.Remove(0, zipFile.LastIndexOf("\\") + 1);
                zipFileName = zipFileName.Remove(zipFileName.Length - 4, 4);

                //IGNORE-For debug 
                //  {
                checkT.Text = zipFileName;
                checkT.Enabled = false;
                //  }

                //restate the storage area
                string exeDirect = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                string storageName = exeDirect + "\\" + "Modlist";
                logwriter("ModList Storage = " + storageName);


                //
                // Extracts from Zip File to modList Directory
                //
                if (!System.IO.Directory.Exists(storageName + "\\" + zipFileName))
                {
                    try
                    {
                        ZipFile.ExtractToDirectory(zipFile, storageName + "\\" + zipFileName);
                        logwriter(zipFileName + " has been extracted to ModList");
                    }
                    catch
                    {

                    }
                }
                else
                {
                    System.IO.Directory.Delete(storageName + "\\" + zipFileName, true);
                    logwriter(zipFileName + "already exists in " + storageName + "." + " Deleting " + storageName + "\\" + zipFileName + "...");
                    ZipFile.ExtractToDirectory(zipFile, storageName + "\\" + zipFileName);
                    logwriter(zipFileName + " has been extracted to ModList");
                }

                //
                // Applies Files to corresponding overrides
                //

                try
                {
                    string[] dirNames = System.IO.Directory.GetDirectories(storageName + "\\" + zipFileName);

                    foreach (string dirName in dirNames)
                    {
                        string dirNameEdit = dirName.Remove(0, dirName.LastIndexOf("\\") + 1);
                        string[] dirFiles = System.IO.Directory.GetFiles(dirName);
                        foreach (string d in dirFiles)
                        {
                            if (!System.IO.Directory.Exists(pathName.Text + "\\" + dirNameEdit + "\\" + "override"))
                            {
                                System.IO.Directory.CreateDirectory(pathName.Text + "\\" + dirNameEdit + "\\" + "override");
                                logwriter("Created Directory : " + pathName.Text + "\\" + dirNameEdit + "\\" + "override");
                            }
                            string mFileName = System.IO.Path.GetFileName(d);
                            string overFileName = System.IO.Path.Combine(pathName.Text + "\\" + dirNameEdit + "\\" + "override", mFileName);
                            System.IO.File.Delete(overFileName);
                            logwriter(mFileName + " in the override folder was deleted to be overwritten");
                        }
                        foreach (string d in dirFiles)
                        {

                            string mFileName = System.IO.Path.GetFileName(d);
                            string overFileName = System.IO.Path.Combine(pathName.Text + "\\" + dirNameEdit + "\\" + "override", mFileName);
                            System.IO.File.Copy(d, overFileName, true);
                            logwriter("Copying " + mFileName + "  to  " + overFileName);
                            logwriter("Copy Complete : " + mFileName);
                        }
                    }


                    //Refresh ModList
                    string[] modLister = System.IO.Directory.GetDirectories(storageName + "\\");

                    for (int i = 0; i <= modLister.Length - 1; i++)
                    {
                        modLister[i] = modLister[i].Remove(0, modLister[i].LastIndexOf("\\") + 1);
                    }
                    modList.DataSource = modLister;
                    //Feedback to User
                    feedbackMyMods.ForeColor = Color.Blue;
                    feedbackMyMods.Text = zipFileName + " has been added to My Mods";
                }
                catch
                {
                    logwriter("Dialogue closed");
                }
            }
            catch {
                logwriter("Dialogue closed");
            }
            
            
        }


        private void createOverride_Click(object sender, EventArgs e)
        {

            //NOW UNUSED : DYNAMICALLY CREATE OVERRIDES
            /*
            if (!System.IO.Directory.Exists(pathName.Text + "\blueprints\\override"))
            {
                System.IO.Directory.CreateDirectory(pathName.Text + "\\" + "blueprints" + "\\" + "override");
                System.IO.Directory.CreateDirectory(pathName.Text + "\\" + "particles" + "\\" + "VFX" + "\\" +"Particles" + "\\" + "override");
                feedbackSetup.ForeColor = Color.Green;
                feedbackSetup.Text = "Override Folders successfully created";
                logwriter("Override Folders Created.");
            }
            */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void modList_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void autoSteam_Click(object sender, EventArgs e)
        {
            //
            // Auto-Detect : Steam
            // Searches each drive for "Program Files (x86)\\Steam\\steamapps\\common\\Trove\\Games\\Trove\\Live"
            //

            logwriter("Checking for Steam Client Live Folder...");
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            List<string> directories = new List<string>();

            foreach (DriveInfo d in allDrives)
            {
                
                try
                {
                    logwriter("[STEAM] Searching Directories for Live Folder...");
                    directories.AddRange(Directory.GetDirectories(d.Name, "Program Files (x86)\\Steam\\steamapps\\common\\Trove\\Games\\Trove\\Live*", SearchOption.AllDirectories));
                    feedBackThing.Text = d.Name;
                    logwriter("Directory chosen : " + d.Name);
                    logwriter("Live Folder found at : " + d.Name + "Program Files (x86)\\Steam\\steamapps\\common\\Trove\\Games\\Trove\\Live");
                }
                catch
                {
                    logwriter("No Live folder found in " + d.Name);
                }


            }

            string checkPath = feedBackThing.Text + "Program Files (x86)\\Steam\\steamapps\\common\\Trove\\Games\\Trove\\Live";
            
            //
            // Assuming d.Name returns something, checkPath should lead to a legitimate directory and thus the if statement below will be active. 
            // If no directory is found, declares that no folder could be found.
            //
            if (System.IO.Directory.Exists(checkPath))
            {

                pathName.Text = checkPath;
                string exeDirect = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                string txtFileName = exeDirect + "\\" + "ModLoader.txt";


                if (File.Exists(txtFileName))
                {
                    File.Delete(txtFileName);
                    logwriter("ModLoader.txt was found; overwriting. [DELETE]");
                }

                StreamWriter writer = new StreamWriter(txtFileName);
                writer.WriteLine(pathName.Text);
                writer.Close();
                logwriter("ModLoader.txt was found; overwriting. [CREATING]");

                StreamReader reader = new StreamReader(txtFileName, false);
                pathName.Text = reader.ReadLine();
                reader.Close();

                if (!pathName.Text.EndsWith("Live"))
                {
                    feedbackSetup.ForeColor = Color.Red;
                    feedbackSetup.Text = "Path does not lead to a Live folder. Consider checking the path again";
                    logwriter("Could not find Live folder as the path found does not seem to end in 'Live'");
                }
                else
                {
                    feedbackSetup.ForeColor = Color.Green;
                    feedbackSetup.Text = "Live folder path successfully recorded";
                    logwriter("Live folder path found and recorded in ModLoader.txt");
                    
                }

            }
            else
            {
                feedbackSetup.ForeColor = Color.Red;
                feedbackSetup.Text = "Could not detect Steam Client Live Folder";
                logwriter("Could not detect Steam Client Live Folder");
            }
            
        }

        private void removeMod_Click(object sender, EventArgs e)
        {
            try
            {
                //Useful Variables for Removing mod
                int modListIndex = modList.SelectedIndex;
                string mLIndexString = modListIndex.ToString();
                string mLString = modList.SelectedItem.ToString();
                string exeDirect = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                string storageName = exeDirect + "\\" + "Modlist";

                //Remove Mod Process:
                //
                // Define ModList Directory based on mLString (which user chooses in ModList)
                // Compares files from ModList Directory (blueprints, particles, etc) with those in corresponding override folders
                // Deletes files with same name as in ModList
                // Deletes files in ModList

                try
                {
                    string[] dirNames = System.IO.Directory.GetDirectories(storageName + "\\" + mLString);

                    //
                    // Applies Files to corresponding overrides
                    //

                    foreach (string dirName in dirNames)
                    {
                        string dirNameEdit = dirName.Remove(0, dirName.LastIndexOf("\\") + 1);
                        string[] dirFiles = System.IO.Directory.GetFiles(dirName);
                        foreach (string d in dirFiles)
                        {
                            if (!System.IO.Directory.Exists(pathName.Text + "\\" + dirNameEdit + "\\" + "override"))
                            {
                                System.IO.Directory.CreateDirectory(pathName.Text + "\\" + dirNameEdit + "\\" + "override");
                                logwriter("Created Directory : " + pathName.Text + "\\" + dirNameEdit + "\\" + "override");
                            }
                            string mFileName = System.IO.Path.GetFileName(d);
                            string overFileName = System.IO.Path.Combine(pathName.Text + "\\" + dirNameEdit + "\\" + "override", mFileName);
                            System.IO.File.Delete(overFileName);
                            logwriter(mFileName + " in the override folder was deleted");
                        }

                    }

                    System.IO.Directory.Delete(storageName + "\\" + mLString, true);

                    //Refresh ModList
                    string[] modLister = System.IO.Directory.GetDirectories(storageName + "\\");

                    for (int i = 0; i <= modLister.Length - 1; i++)
                    {
                        modLister[i] = modLister[i].Remove(0, modLister[i].LastIndexOf("\\") + 1);
                    }
                    modList.DataSource = modLister;
                    //Feedback to User
                    feedbackMyMods.ForeColor = Color.Blue;
                    feedbackMyMods.Text = mLString + " has been removed from My Mods";
                }
                catch
                {
                    logwriter("Dialogue closed");
                }

            }
            catch
            {
                logwriter("No mod selected to be removed");
            }
            }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        

        private void bsButton_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void extractFileArchives_Click(object sender, EventArgs e)
        {
            //
            // FOR MODDERS : Extracts .tga archives with one click.
            //

            logwriter("Attempting to extract archives..");
            try
            {
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.WorkingDirectory = pathName.Text;
                p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardInput = true;


                p.Start();

                //Extractes all archives
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive blueprints extracted\\blueprints");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive particles\\vfx extracted\\particles\\vfx");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive particles\\vfx\\particles extracted\\particles\\vfx\\particles");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive particles\\vfx\\textures extracted\\particles\\vfx\\textures");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive particles\\vfx\\textures\\player extracted\\particles\\vfx\\textures\\player");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive particles\\vfx\\meshes extracted\\particles\\vfx\\meshes");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive particles\\vfx\\atlasdefinitions extracted\\particles\\vfx\\atlasdefinitions");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive particles\\vfx\\Animations extracted\\particles\\vfx\\Animations");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive particles\\vfx\\Cache extracted\\particles\\vfx\\Cache\\Meshes");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive particles\\vfx\\Config extracted\\particles\\vfx\\Config");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive particles\\vfx\\Editor\\Thumbnails\\Particles extracted\\particles\\vfx\\Thumbnails\\Particles");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive particles\\vfx\\Editor\\Thumbnails\\Meshes extracted\\particles\\vfx\\Thumbnails\\Meshes");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive particles\\vfx\\Editor\\MaterialProxies extracted\\particles\\vfx\\MaterialProxies");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive ui extracted\\ui");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive ui\\ability_icons extracted\\ui\\ability_icons");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive ui\\crafting_icons extracted\\ui\\crafting_icons");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive ui\\fonts extracted\\ui\\fonts");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive ui\\meta_icons extracted\\ui\\meta_icons");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive ui\\skins extracted\\ui\\skins");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive ui\\store extracted\\ui\\store");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive ui\\classes extracted\\ui\\classes");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive ui\\tutorial extracted\\ui\\tutorial");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive prefabs\\placeable extracted\\prefabs\\placeable");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive prefabs\\placeable\\block\\color extracted\\prefabs\\placeable\\block\\color");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive prefabs\\placeable\\block\\gameplay extracted\\prefabs\\placeable\\block\\gameplay");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive prefabs\\placeable\\block\\glass extracted\\prefabs\\placeable\\block\\glass");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive prefabs\\placeable\\block\\glow extracted\\prefabs\\placeable\\block\\glow");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive prefabs\\placeable\\block\\ice extracted\\prefabs\\placeable\\block\\ice");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive prefabs\\placeable\\block\\metal extracted\\prefabs\\placeable\\block\\metal");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive prefabs\\placeable\\block\\music extracted\\prefabs\\placeable\\block\\music");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive prefabs\\placeable\\block\\natural extracted\\prefabs\\placeable\\block\\natural");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive prefabs\\placeable\\block\\particles extracted\\prefabs\\placeable\\block\\particles");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive prefabs\\placeable\\block\\primal extracted\\prefabs\\placeable\\block\\primal");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive prefabs\\placeable\\block\\textured extracted\\prefabs\\placeable\\block\\textured");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive prefabs\\placeable\\block\\transmute extracted\\prefabs\\placeable\\block\\transmute\\Blocks");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive prefabs\\placeable\\collectible extracted\\prefabs\\placeable\\collectible");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive prefabs\\plant extracted\\prefabs\\plant");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive prefabs\\placeable\\crafting extracted\\prefabs\\placeable\\crafting");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive prefabs\\placeable\\deco extracted\\prefabs\\placeable\\deco");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive prefabs\\placeable\\mechanical extracted\\prefabs\\placeable\\mechanical");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive prefabs\\placeable\\npc extracted\\prefabs\\placeable\\npc");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive prefabs\\placeable\\portal extracted\\prefabs\\placeable\\portal");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive prefabs\\placeable\\quest extracted\\prefabs\\placeable\\quest");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive prefabs\\placeable\\sign extracted\\prefabs\\placeable\\sign");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive prefabs\\placeable\\tutorial extracted\\prefabs\\placeable\\tutorial");
                p.StandardInput.WriteLine("Trove.exe -tool extractarchive prefabs\\placeable\\vendor extracted\\prefabs\\placeable\\vendor");


                p.StandardInput.WriteLine("exit");

                feedbackExtract.ForeColor = Color.Blue;
                feedbackExtract.Text = "Files have been extracted successfully";
                logwriter("Files have been extracted successfully");
            }
            catch
            {
                logwriter("there was an issue extracting archives.");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            logwriter("Checking for Glyph Client Live Folder...");
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            List<string> directories = new List<string>();
            foreach (DriveInfo d in allDrives)
            {
                
                try
                {
                    logwriter("[GLYPH] Searching " + d.Name + " for Live Folder...");
                    directories.AddRange(Directory.GetDirectories(d.Name, "Program Files (x86)\\Glyph\\Games\\Trove\\Live*", SearchOption.AllDirectories));
                    feedBackThing.Text = d.Name;
                    logwriter("Directory chosen : " + d.Name);
                    logwriter("Live Folder found at : " + d.Name + "Program Files (x86)\\Glyph\\Games\\Trove\\Live");
                }
                catch
                {
                    
                }
            }
            string checkGlyphPath = feedBackThing.Text + "Program Files (x86)\\Glyph\\Games\\Trove\\Live";
            if (System.IO.Directory.Exists(checkGlyphPath))
            {

                pathName.Text = checkGlyphPath;
                string exeDirect = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                string txtFileName = exeDirect + "\\" + "ModLoader.txt";


                if (File.Exists(txtFileName))
                {
                    File.Delete(txtFileName);
                    logwriter("ModLoader.txt was found; overwriting. [DELETE]");
                }

                StreamWriter writer = new StreamWriter(txtFileName);
                writer.WriteLine(pathName.Text);
                writer.Close();
                logwriter("ModLoader.txt was found; overwriting. [CREATING]");

                StreamReader reader = new StreamReader(txtFileName, false);
                pathName.Text = reader.ReadLine();
                reader.Close();

                if (!pathName.Text.EndsWith("Live"))
                {
                    feedbackSetup.ForeColor = Color.Red;
                    feedbackSetup.Text = "Path does not lead to a Live folder. Consider checking the path again";
                    logwriter("Could not find Live folder as the path found does not seem to end in 'Live'");
                    
                }
                else
                {
                    feedbackSetup.ForeColor = Color.Green;
                    feedbackSetup.Text = "Live folder path successfully recorded";
                    logwriter("Live folder path found and recorded in ModLoader.txt");
                }
            }
            else
            {
                feedbackSetup.ForeColor = Color.Red;
                feedbackSetup.Text = "Could not detect Glyph Client Live Folder";
                logwriter("Could not detect Glyph Client Live Folder");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 instructions = new Form2();
            instructions.Show();
            logwriter("showing instructions");
        }

        private void sendMailButton_Click(object sender, EventArgs e)
        {
            try
            {
                string exeDirect = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("TroveModManager@gmail.com");
                mail.To.Add("TroveModManager@gmail.com");
                mail.Subject = "Trove Mod Manager Feedback or Issue";

                string bod = null;
                foreach (string s in feedbackTxt.Lines)
                     bod = bod + s;
                mail.Body = bod;

                System.Net.Mail.Attachment logAttach;
                logAttach = new System.Net.Mail.Attachment(exeDirect + "\\" + "proglog.txt");
                mail.Attachments.Add(logAttach);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("TroveModManager@gmail.com", "TMMPassword");
                SmtpServer.EnableSsl = true;


                SmtpServer.Send(mail);
                feedbackPageFeedback.ForeColor = Color.Green;
                feedbackPageFeedback.Text = "Your feedback has been successfully sent!";
                logwriter("Sent Feedback");
            }
            catch (SmtpException)
            {
                
                feedbackPageFeedback.ForeColor = Color.Red;
                feedbackPageFeedback.Text = "Could not send feedback. Consider checking antivirus settings or emailing directly!";


                logwriter("could not send mail");
                logwriter(" Error : SMTPException");



             
            }
            catch (Exception ex)
            {
                logwriter("Exception message: " + ex.Message);
            }

        }

        public void OnProcessExit(object sender, EventArgs e)
        {
            logwriter("-----------------");
            logwriter("Application Close");
            logwriter("-----------------");
        }

        public void logwriter(string text)
        {
            try
            {
                
                string exeDirect = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                StreamReader readLog = new StreamReader(exeDirect + "\\" + "proglog.txt");
                string logRead = readLog.ReadToEnd().ToString();
                readLog.Close();
                StreamWriter log = new StreamWriter(exeDirect + "\\" + "proglog.txt");
                log.WriteLine(logRead);
                //log.WriteLine("___________");
                log.WriteLine(text);
                //log.WriteLine("___________");
                log.Close();
            }
            catch
            {

            }
            

        }

        private void setupTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearMods_Click(object sender, EventArgs e)
        {

            logwriter("Attempting to Clear Mods...");



            try
            {
                string[] directories = Directory.GetDirectories(pathName.Text);
                try
                {

                    foreach (string d in directories)
                    {
                        string[] direct = Directory.GetDirectories(d, "override", SearchOption.AllDirectories);
                        //Directory.Delete(Directory.GetDirectories(d, "\\override", SearchOption.AllDirectories).ToString());
                        foreach (string t in direct)
                        {
                            Directory.Delete(t, true);
                            logwriter(t + " has been deleted");
                        }
                        // logwriter(Directory.GetDirectories(d, "override", SearchOption.AllDirectories).ToString());
                        //Directory.GetDirectories(d, "override", SearchOption.)
                    }
                    logwriter("Overrides cleared succesfully");
                }
                catch
                {
                    logwriter("No Live folder path name declared");
                }
            }
            catch
            {
                logwriter("Could not clear overrides... Unknown Error.");
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void viewMod_Click(object sender, EventArgs e)
        {
            string exeDirect = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
           
            List<Obj> jsonArray = JsonConvert.DeserializeObject<List<Obj>>(File.ReadAllText(exeDirect + "\\" + "Data.txt"));
            List<string> nameString = new List<string>();
            foreach (Obj obj in jsonArray)
            {
                nameString.Add(obj.name);
            }
            int nameIndex = nameString.IndexOf(modSearchNames.SelectedValue.ToString());

            Form3 form3 = new Form3(jsonArray[nameIndex].name, jsonArray[nameIndex].author, jsonArray[nameIndex].type, jsonArray[nameIndex].subtype, jsonArray[nameIndex].totaldownloads, jsonArray[nameIndex].image, jsonArray[nameIndex].id, jsonArray[nameIndex].downloads[0], jsonArray[nameIndex].replaces);
            form3.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void searchModButton__Click(object sender, EventArgs e)
        {
            string exeDirect = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string searchBoxTest = "";
            if (searchModBox.Text == "Search For a Name...")
            {
                searchBoxTest = "";    
            }
            else
            {
                searchBoxTest = searchModBox.Text;

            }
            string searchVal = searchBoxTest;
            List<Obj> jsonArray = JsonConvert.DeserializeObject<List<Obj>>(File.ReadAllText(exeDirect + "\\" + "Data.txt"));
            
            List<string> nameString = new List<string>();
            List<string> nameStringNew = new List<string>();
            foreach (Obj obj in jsonArray)
            {
                if (filterBox.SelectedValue.ToString() == "ALL")
                {
                    nameString.Add(obj.name);
                }
                else
                {
                    if (obj.type == filterBox.SelectedValue.ToString())
                    {
                        nameString.Add(obj.name);
                    }
                }
            }
          
            foreach (string s in nameString)
            {
                string n = s.ToLower();
                if (n.Contains(searchVal.ToLower()))
                {
                    nameStringNew.Add(s);
                }
            }
            List<string> nameReverse = nameStringNew;
            
            
            nameReverse.Reverse();
            
            modSearchNames.DataSource = nameReverse;
        }

        private void searchModBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
                searchModButton__Click(sender, e);
        }

        private void filterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string exeDirect = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            List<Obj> jsonArray = JsonConvert.DeserializeObject<List<Obj>>(File.ReadAllText(exeDirect + "\\" + "Data.txt"));
            List<string> nameString = new List<string>();
            string searchVal = searchModBox.Text;



            foreach (Obj obj in jsonArray)
                {
                    if (filterBox.SelectedValue.ToString() == "ALL")
                    {
                        nameString.Add(obj.name);
                    }
                    else
                    {
                        if (obj.type == filterBox.SelectedValue.ToString())
                        {
                            nameString.Add(obj.name);
                        }
                    }
                }
           
            
        }

        private void searchModBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchModBox_MouseClick(object sender, MouseEventArgs e)
        {
            searchModBox.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
           // Form4 form4 = new Form4();
            //form4.Show();
            
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            string exeDirect = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string storageName = exeDirect + "\\" + "Modlist";

            //Refresh ModList
            string[] modLister = System.IO.Directory.GetDirectories(storageName + "\\");

            for (int i = 0; i <= modLister.Length - 1; i++)
            {
                modLister[i] = modLister[i].Remove(0, modLister[i].LastIndexOf("\\") + 1);
            }
            modList.DataSource = modLister;
        }

        private void modSearchNames_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (tabControl1.SelectedIndex == 3)
            {
                AcceptButton = searchModButton_;

            }
            else
            {
                AcceptButton = null;
            }
            */
        }

        private void searchModBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchModButton__Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }
    }
}

