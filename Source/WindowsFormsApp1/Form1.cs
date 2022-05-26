using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var yokoe = new NINGEN("Yokoe");
            var naitou = new NINGEN("Naitou");

            yokoe.Run(30);
            naitou.Run(60);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var yokoe = new NINGEN("Yokoe");
            var naitou = new NINGEN("Naitou");
            var menkyoHoyuushaList = new List<IKurumaMenkyo> { yokoe, naitou };
            var chourishiList = new List<IChourishi> { yokoe, naitou };
            //人間としての動作
            yokoe.Run(30);
            naitou.Run(60);
            //免許保有者とし動作
            foreach (var hito in menkyoHoyuushaList)
            {
                hito.MenkyowoWoMiseru();
                hito.MoveToByCar("Hamaootsu");
            }
            //調理師としての動作
            foreach (var hito in chourishiList)
            {
                hito.MakeChaHan();
                hito.MekeGyosa(6);
            }
        }
    }
}
