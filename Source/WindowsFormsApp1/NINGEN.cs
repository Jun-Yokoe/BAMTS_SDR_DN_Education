using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class NINGEN : IChourishi, IKurumaMenkyo
    {
        public string Name { get; set; }
        public NINGEN(string name)
        {
            this.Name = name;
        }
        public void Run(int speed)
        {
            MessageBox.Show($"{this.Name}が時速{speed}Kmで走りました！");
        }

        public void MakeChaHan()
        {
            MessageBox.Show($"{this.Name}がチャーハンを作りました。");
        }

        public void MekeGyosa(int kosuu)
        {
            MessageBox.Show($"{this.Name}が餃子を{kosuu}個を作りました。");
        }
        public void MenkyowoWoMiseru()
        {
            MessageBox.Show($"{this.Name}が免許を提示しました。");
        }
        public void MoveToByCar(string destination)
        {
            MessageBox.Show($"{this.Name}が{destination}に到着しました。");
        }
    }
}
