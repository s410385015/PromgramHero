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
    public partial class LevelUP : Form
    {
        public int tp, udp, l, lsn;
        public int hp, da, def;
        public string[] list=new string[256]; 
        public LevelUP()
        {
            InitializeComponent();
        }
        public LevelUP(int p,int lv,int ls,string extx)
        {
            InitializeComponent();
            SetList();
            SetLv(lv);
            hp = da = def = 0;
            tp=udp=p;
            l = lv;
            lsn = ls;
            Point.Text = Point.Text + p.ToString();
            for (int i = 0; i < ls; i++)
                ablitylist.Items.Add(list[i]);
            ex.Text = extx;
        }
        private void LevelUP_Load(object sender, EventArgs e)
        {

        }
        private void SetLv(int c)
        {
            if(c==1)
            {
                this.Text=this.Text+" C>>D";
            }
            
        }
        public void SetList()
        {
            int index = 0;
            list[index++] = "血量(HP)";
            list[index++] = "攻擊力(Damage)";
            list[index++] = "防禦力(Def)";
        }

        private void addrequest_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private bool StrCheck(string tx)
        {
            if(tx=="HP++;"||tx=="++HP;")
            {
                hp++;
                udp--;
                Point.Text = "剩餘點數： " + udp.ToString();
                return true;
            }
            if(tx=="Damage++;"||tx=="++Damage;")
            {
               
                da++;
                udp--;
                Point.Text = "剩餘點數： " + udp.ToString();
                return true;
            }
            return false;
        }

        private void addrequest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
                if (StrCheck(addrequest.Text))
                {
                    MessageBox.Show("配點成功!");
                }
                else
                {
                    MessageBox.Show("選項錯誤!");
                }
                addrequest.Text = "";
            }
        }

        private void lvup_Click(object sender, EventArgs e)
        {
            if (udp == 0)
            {
                MessageBox.Show("成功升等!");
                this.Close();
            }
            else
                MessageBox.Show("點數尚未用完!");
        }

        private void ablitylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ablitylist.SelectedIndex==0)
            {
                ex.Text = "HP-已經在這項配置了: " + hp.ToString() + "點";
            }

            if (ablitylist.SelectedIndex == 1)
            {
                ex.Text = "Damage-已經在這項配置了: " + da.ToString() + "點";
            }

            if (ablitylist.SelectedIndex == 2)
            {
                ex.Text = "已經在這項配置了: " + def.ToString() + "點";
            }
        }

        private void Hint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("若想要升級血量，則打\"HP++;\"，並在輸入欄中按下enter鍵");
        }
    }
}
