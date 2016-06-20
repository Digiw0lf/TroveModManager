using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;
using System.Windows.Forms;

namespace Trove_Mod_Manager
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            string bpEX = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Trove\\Games\\Trove\\Live\\extracted\\blueprints\\";

            Class_ boomer = new Class_();
            boomer.name = "Boomeranger";
            boomer.downloadLocs = new List<string>();
            boomer.downloadLocs.Add(bpEX + "c_p_adventurer_lvl3_ui.blueprint");
            boomer.downloadLocs.Add(bpEX + "c_p_adventurer_lvl3_torso.blueprint");
            boomer.downloadLocs.Add(bpEX + "c_p_adventurer_lvl3_thigh_r.blueprint");
            boomer.downloadLocs.Add(bpEX + "c_p_adventurer_lvl3_thigh_l.blueprint");
            boomer.downloadLocs.Add(bpEX + "c_p_adventurer_lvl3_shoulder_r.blueprint");
            boomer.downloadLocs.Add(bpEX + "c_p_adventurer_lvl3_shoulder_l.blueprint");
            boomer.downloadLocs.Add(bpEX + "c_p_adventurer_lvl3_shin_r.blueprint");
            boomer.downloadLocs.Add(bpEX + "c_p_adventurer_lvl3_shin_l.blueprint");
            boomer.downloadLocs.Add(bpEX + "c_p_adventurer_lvl3_pack.blueprint");
            boomer.downloadLocs.Add(bpEX + "c_p_adventurer_lvl3_hips.blueprint");
            boomer.downloadLocs.Add(bpEX + "c_p_adventurer_lvl3_hand_r.blueprint");
            boomer.downloadLocs.Add(bpEX + "c_p_adventurer_lvl3_hand_l.blueprint");
            boomer.downloadLocs.Add(bpEX + "c_p_adventurer_lvl3_foot_l.blueprint");
            boomer.downloadLocs.Add(bpEX + "c_p_adventurer_lvl3_foot_r.blueprint");
            

            Class_ chloro = new Class_();
            chloro.name = "Chloromancer";
            List<Class_> classList = new List<Class_>();
            classList.Add(boomer); classList.Add(chloro);

            List<string> classListName = new List<string>();
            classListName.Add(boomer.name); classListName.Add(chloro.name);
            classesList.DataSource = classListName;
            

        }

        public class Class_
        {
            public string name;
            public List<string> downloadLocs;
        }
       
        private void bigAssButton_Click(object sender, EventArgs e)
        {

            string bpEX = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Trove\\Games\\Trove\\Live\\extracted\\blueprints\\";
            List<string> bpExtractedFiles = System.IO.Directory.GetFiles(bpEX).ToList<string>();
            Class_ boomer = new Class_();
            boomer.name = "Boomeranger";

            List<string> fileBPUse = new List<string>();
            List<string> boomerDL = new List<string>();
            foreach (string bp in bpExtractedFiles)
            {
                if (bp.Contains("adventurer_"))
                {
                   // bp.Remove(bp.LastIndexOf("_")-1);
                    boomerDL.Add(bp);
                }
            }
            boomer.downloadLocs = boomerDL;
            foreach (string bp in boomer.downloadLocs)
            {
                /*
                 * //
                 * //WIPWIPWIPWIP
                 * //
                 * //
                if (costumeList.SelectedValue.ToString() == "lvl 1")
                {
                    string a = bp.Remove(bp.LastIndexOf("_"));
                    if (a.EndsWith("adventurer")) 
                    {
                       // if (!(bp.Contains("equip")))
                            //{
                            fileBPUse.Add(bp);
                       // }
                    }
                    
                }
                //
                //
                //
                */
                
                
                if (costumeList.SelectedValue.ToString().ToLower() == "magician")
                {
                    if (bp.Contains("magician"))
                    {
                        
                            fileBPUse.Add(bp);
                    }
                }
                else if (costumeList.SelectedValue.ToString().ToLower() == "comichero")
                {
                    if (bp.Contains("comichero"))
                    {
                        
                            fileBPUse.Add(bp);
                    }
                }
                else if (bp.Contains(costumeList.SelectedValue.ToString().ToLower()))
                {

                    if (!bp.Contains("magician"))
                        fileBPUse.Add(bp);
                }
                else if (bp.Contains("basic"))
                    {
                        if (!bp.Contains("magician"))
                            fileBPUse.Add(bp);
                    }
                
            }
            

    
            Class_ chloro = new Class_();
            chloro.name = "Chloromancer";
            List<Class_> classList = new List<Class_>();
            classList.Add(boomer); classList.Add(chloro);


            string exeDirect = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string txtFileName = exeDirect + "\\" + "ModLoader.txt";

            StreamReader reader = new StreamReader(txtFileName, false);
            string livePath = reader.ReadLine();
            reader.Close();

            string bptoqbBATCH =  @livePath + "\\" + "devtool_dungeon_blueprint_to_QB";
            List<string> bptoChange = fileBPUse;
           
           
            foreach (string bp in bptoChange)
            {



                var process = new Process
                {
                    StartInfo =
                {
                    FileName = bptoqbBATCH,
                    Arguments = string.Format("\"{0}\"",bp)
                }
                };
                process.StartInfo.FileName = bptoqbBATCH;
                process.Start();
                
                
            }
            
            
        }

        private void classesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //BOOMERANGER
            List<string> boomerList = new List<string>();
            
            boomerList.Add("Lvl2");
            boomerList.Add("Lvl3");
            boomerList.Add("WinterRanger");
            boomerList.Add("Moonsilver");
            boomerList.Add("Magician");
            boomerList.Add("DarkRanger");
            boomerList.Add("ComicHero");

            //CHLOROMANCER
            List<string> chloroList = new List<string>();
            chloroList.Add("Lvl2");
            chloroList.Add("Lvl3");
            chloroList.Add("Life");
            chloroList.Add("Spring");
            chloroList.Add("RedShroom");
            chloroList.Add("DubOMancer");
            chloroList.Add("Christmas");
            chloroList.Add("Cactus");


            //
            // Costume List change based on Class
            //
            if (classesList.SelectedValue.ToString() == "Boomeranger")
            {
                costumeList.DataSource = boomerList;
            }

            if (classesList.SelectedValue.ToString() == "Chloromancer")
            {
                costumeList.DataSource = chloroList;
            }

        }
    }
}
