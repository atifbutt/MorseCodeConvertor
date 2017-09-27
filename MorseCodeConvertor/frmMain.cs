using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseCodeConvertor
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        Dictionary<string, string> Codes = new Dictionary<string, string>()
        {
            { "A" , ".-" },
            { "B" , "-..." },
            { "C" , "-.-." },
            { "D" , "-.." },
            { "E" , "." },
            { "F" , "..-." },
            { "G" , "--." },
            { "H" , "...." },
            { "I" , ".." },
            { "J" , ".---" },
            { "K", "-.-" },
            { "L", ".-.." },
            { "M", "--" },
            { "N", "-." },
            { "O", "---" },
            { "P", ".--." },
            { "Q", "--.-" },
            { "R", ".-." },
            { "S", "..." },
            { "T", "-" },
            { "U", "..-" },
            { "V", "...-" },
            { "W", ".--" },
            { "X", "-..-" },
            { "Y", "-.--" },
            { "Z", "--.." },
            { " ", " " }
        };

        private void BtnSender_Click(object sender, EventArgs e)
        {
            Conversion(TbxSender.Text);
        }

        void Conversion(string inputString)
        {
            foreach(var s in inputString.ToUpper())
            {
                TbxReciever.Text += $"{Codes[$"{s}"]}";
            }
        }
    }
}
