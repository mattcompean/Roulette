using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Roulette
{
    public partial class Main : Form
    {
        List<string> roster = new List<string>();

        public Main()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            outputBox.Text = string.Empty;

            if (roster.Count > 0)
            {
                Tournament t = new Tournament((int)numSeeds.Value, roster);
                t.Generate(outputBox);
            }
            else
            {
                Tournament t = new Tournament((int)numSeeds.Value);
                t.Generate(outputBox);
            }
            
        }

        private void loadRosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofd.Filter = "Text Files (*.txt)|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofd.FileName))
                {
                    TextReader tr = new StreamReader(ofd.FileName);
                    string line = tr.ReadLine();
                    string[] _roster = line.Split(',');
                    roster = new List<string>(_roster);

                    for (int i = 0; i < roster.Count; i++)
                    {
                        roster[i] = roster[i].Trim();
                    }

                    if (roster.Count > (int)numSeeds.Value)
                    {
                        numSeeds.Value = roster.Count;
                    }
                }
            }
        }
    }
}
