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
    public partial class CreateHero : Form
    {
        public Bitmap myHero;
        public Graphics DrawSpace;
        public SolidBrush myBrush;
        public Color myColor = Color.Black;
        public int mySize = 10;
        public bool isDraw = false;
        public List<int> SizeList;
        public CreateHero()
        {
            InitializeComponent();
           
            //YourHero = new Bitmap(this.HeroBox.Image);
            myHero = new Bitmap(HeroBox.Size.Width, HeroBox.Size.Height);
            DrawSpace = HeroBox.CreateGraphics();
            DrawSpace = Graphics.FromImage(myHero);
           
            //HeroBox.Focus();
            //HeroBox.BringToFront();
        }

        private void CreateHero_Load(object sender, EventArgs e)
        {
            
            SizeList=new List<int>();
            for(int i=0;i<=10;i++)
                SizeList.Add(10+i);
            BrushSize.DataSource=SizeList;
            HeroBox.Focus();
            HeroBox.BringToFront();
            
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            //HeroBox.Image = DrawSpace.DrawImage;
            try
            {
                HeroBox.Image.Save("myHero.jpg");
                MessageBox.Show("創建成功!");
            }
            catch
            {
                MessageBox.Show("創建失敗!");
            }
            this.Close();
        }

     

        private void HeroBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDraw = true;
            myBrush = new SolidBrush(myColor);
        }

        private void HeroBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraw)
            {
                DrawSpace.FillEllipse(myBrush, e.X, e.Y, mySize, mySize);
                HeroBox.Image = myHero;
            }
        }

        private void HeroBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDraw = false;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            DrawSpace.Clear(Color.White);
            HeroBox.Image = myHero;
        }

        private void Pcolor_MouseClick(object sender, MouseEventArgs e)
        {
            BrushColor.ShowDialog();
            Pcolor.BackColor = BrushColor.Color;
            myColor = BrushColor.Color;
        }

        private void BrushSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            mySize = BrushSize.SelectedIndex + 10;
            HeroBox.Focus();
            HeroBox.BringToFront();
        }
    }
}
