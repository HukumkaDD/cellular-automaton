using GenProgram;
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

namespace GenProgram_v2._0
{
    public partial class Form1 : Form
    {

        private Config config;
        public Form1()
        {
            string exeFolder = Application.StartupPath;
            string reportPath = Path.Combine(exeFolder, @"SetupConfigs/SetupConfig.xml");

            XmlManager<Config> configLoader = new XmlManager<Config>();
            config = configLoader.Load(reportPath);

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbPrimaryPopulation.DataBindings.Add("Text", config,(string)"PopSize");
            tbCurrentPopulation.DataBindings.Add("Text", config, (string)"PopSizeCurrent");
        }

        private void drawTest1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            drawTest1.Refresh();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            drawTest1.Refresh();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            drawTest1 = new GenProgram_v2._0.DrawTest(ref config);
        }

        private void cbEnergyMoveCenter_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chb = (CheckBox)sender;
            config.EnergyMoveCenter = chb.Checked;
        }

        private void cbEnergyMoveUp_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chb = (CheckBox)sender;
            config.EnergyMoveUp = chb.Checked;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            config.RateRefresh = cb.SelectedIndex;
        }

        private void cbEnergyMoveDown_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chb = (CheckBox)sender;
            config.EnergyMoveDown = chb.Checked;
        }

        private void cbEnergyMoveLeft_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chb = (CheckBox)sender;
            config.EnergyMoveLeft = chb.Checked;
        }

        private void cbEnergyMoveRight_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chb = (CheckBox)sender;
            config.EnergyMoveRight = chb.Checked;
        }

        private void lFieldSize_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }
    }
}
