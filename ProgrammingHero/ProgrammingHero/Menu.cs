using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingHero
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CreateHero a = new CreateHero();
            //MainScreen b = new MainScreen();
            //Request c = new Request();
            //LevelUP d = new LevelUP(1, 1, 2, "ths");
            //a.Show();
            //b.Show();
            //d.Show();
            //c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen b = new MainScreen();
            b.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("整個遊戲的概念是源至於靠北工程師的某篇文章，看到蠻有趣的，就想自己來嘗試一下。這算是第一版，也是我第一次試作有故事的劇情遊戲，整體來說還蠻多BUG，也有很多地方不完善。還請多多包涵。大部分圖片都是來自於GOOGLE搜尋，若有侵犯版權，請通知我s410385015@gmail.com.tw。");
        }
    }
}
