using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ProgrammingHero
{
    public partial class MainScreen : Form
    {
        public string ShowText="";
        public int ShowTime=0;
        public StoryLine Story=new StoryLine();
        public bool nextflag = true;
        public int onType = 0;
        public int MAX = 256;
        public string name="";
        private bool Addflag,endflag=false;
        private int kill, hp, da=1;
        private char lv;
        private char[] Rank = new char[5];
        private int attacknum,monsterHP,monsterDa;

        public MainScreen()
        {
            InitializeComponent();
            //Story.SetNext(64);
            TutorialScreen.BringToFront();
            TutorialScreen.Show();
            CharacterName.Text="";
            LabelODa.Text=LabelOHP.Text=LabelDa.Text = LabelHP.Text = LabelLv.Text = "";
            kill = hp = da = 0;
            lv = 'C';
            Rank[1] = 'C';
            Rank[2] = 'B';
            Rank[3] = 'A';
            Rank[4] = 'S';
            FightButton.Hide();
            EscapeButton.Hide();
            FuncButton.Hide();
            da = 10;
            hp = 10;
            PocDefine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainCharacter.Image = Image.FromFile(Application.StartupPath + "\\myHero.jpg");
        }

       

      

        private void CharacterScreen_Enter(object sender, EventArgs e)
        {

        }

     

        private void AddText(string tx)
        {
            //Thread.Sleep(500);
            ShowText = tx;
            ShowTime = tx.Length;
            if (onType == 0)
                TutorialText.Text = "";
            else if (onType == 1)
                CharacterText.Text = "";
            Showntimer.Start();
        }

        private void Showntimer_Tick(object sender, EventArgs e)
        {
            if(ShowTime==0)
            {
                Showntimer.Stop();
              
            }
            else
            {
                if(onType==0)
                    TutorialText.Text = ShowText.Substring(0, ShowText.Length - ShowTime);
                else if(onType==1)
                    CharacterText.Text = ShowText.Substring(0, ShowText.Length - ShowTime);
                ShowTime--;
            }
        }

        private void TutorialSkip_Click(object sender, EventArgs e)
        {
            
        }

        private void TurtorialText_MouseClick(object sender, MouseEventArgs e)
        {
            TutorialText.Text = ShowText;
            Showntimer.Stop();
            ShowTime = 0;
        }

        private void SetTutorialPic(int num)
        {
            
            string filename = "\\" + num.ToString() + ".jpg";
            try
            {
                TutorialPic.Image = Image.FromFile(Application.StartupPath + filename);
            }
            catch
            {

            }
            
        }

        private void SetOtherPic(int num)
        {

            string filename = "\\" + num.ToString() + ".jpg";
            //string filename = "\\" +"t.jpg";
            try
            {
                OtherBox.Image = Image.FromFile(Application.StartupPath + filename);
            }
            catch
            {

            }

        }

        private void TutorialNext_Click(object sender, EventArgs e)
        {
            
            if (nextflag&&Story.next<MAX)
            {
                if (ShowTime >1)
                {
                    ShowTime = 0;
                    TutorialText.Text = ShowText;
                }
                else
                {
                    PocDefine();
                }
            }
            else
            {

            }
        }

        private void PocDefine()
        {
            if (endflag)
            {
                this.Close();
                return;
            }
            int type = Story.GetStoryType();
            Addflag = true;
            //0 as Normal Story Line
            //1 as chararcter Screen
            //2 as Request
            if (type == 0)
            {
                onType = 0;
                TutorialScreen.Show();
                CharacterScreen.Hide();
                SetTutorialPic(Story.GetPicID());
                AddText(Story.GetStoryText());
            }
            if(type==99)
            {
                onType = 0;
                CreateHero c = new CreateHero();
                AddText(Story.GetStoryText());
                c.ShowDialog();
                Story.next++;
                PocDefine();
                return;
            }
            if (type == 98)
            {
                onType = 1;
                TutorialScreen.Hide();
                CharacterScreen.Show();
                MainCharacter.Image = Image.FromFile(Application.StartupPath + "\\myHero.jpg");
                HandleEventString(Story.GetEventID());
                SetOtherPic(Story.GetPicID());
                AddText(Story.GetStoryText());
                Request r = new Request(Story.GetRequestID());
                r.ShowDialog();
                name = r.name;


            }
            if(type==97)
            {
                onType = 1;
                TutorialScreen.Hide();
                CharacterScreen.Show();
                MainCharacter.Image = Image.FromFile(Application.StartupPath + "\\myHero.jpg");
                HandleEventString(Story.GetEventID());
                SetOtherPic(Story.GetPicID());
                AddText(Story.GetStoryText());
                nextflag = false;
                attacknum = 3;
                FuncButton.Text = "攻擊鈕-剩餘3次";
                FuncButton.Show();
                
                
            }
            if(type==96)
            {
                onType = 1;
                TutorialScreen.Hide();
                CharacterScreen.Show();
                MainCharacter.Image = Image.FromFile(Application.StartupPath + "\\myHero.jpg");
                HandleEventString(Story.GetEventID());
                SetOtherPic(Story.GetPicID());
                AddText(Story.GetStoryText());
                LevelUP u = new LevelUP(1, 1, 2, "請使用++這個運算子來為想要提升之能力升級，請注意項目名稱和別忘了加上分號。打完後記得按ENTER確認唷！");
                u.ShowDialog();
                SetCharacter(u);
                Story.next++;
                PocDefine();
                return;
            }
            if (type == 95)
            {
                onType = 1;
                TutorialScreen.Hide();
                CharacterScreen.Show();
                MainCharacter.Image = Image.FromFile(Application.StartupPath + "\\myHero.jpg");
                HandleEventString(Story.GetEventID());
                SetOtherPic(Story.GetPicID());
                AddText(Story.GetStoryText());
                HandleEventString(Story.GetEventID());
                nextflag = false;
                FightButton.Show();
                EscapeButton.Show();
                Story.next++;
                return;
            }
            if(type==1)
            {
               
                onType = 1;
                TutorialScreen.Hide();
                CharacterScreen.Show();
                MainCharacter.Image = Image.FromFile(Application.StartupPath + "\\myHero.jpg");
                HandleEventString(Story.GetEventID());
                SetOtherPic(Story.GetPicID());
                if(Addflag)
                    AddText(Story.GetStoryText());
              
            }
           
            if(type==2)
            {
                onType = 1;
                TutorialScreen.Hide();
                CharacterScreen.Show();
                SetOtherPic(Story.GetPicID());
                HandleEventString(Story.GetEventID());
                AddText(Story.GetStoryText());
                MainCharacter.Image = Image.FromFile(Application.StartupPath + "\\myHero.jpg");
                Request r = new Request(Story.GetRequestID());
                r.ShowDialog();
                Story.next++;
                PocDefine();
                return;
         
            }
            if(type==999)
            {
                onType = 0;
                TutorialScreen.Show();
                CharacterScreen.Hide();
                SetTutorialPic(Story.GetPicID());
                AddText(Story.GetStoryText());
                endflag = true;
            }
            Story.next++;
        }
        private void SetCharacter(LevelUP u)
        {
            if(u.hp!=0)
            {
                for (int i = 0; i < u.hp; i++)
                    hp *= 2;
                LabelHP.Text = "血量: " + hp.ToString();
            }

            if (u.da != 0)
            {
                for (int i = 0; i < u.da; i++)
                    da *= 2;
                LabelDa.Text = "攻擊力: " + da.ToString();
            }
            lv = Rank[u.l];
            LabelLv.Text = "等級： " + Rank[u.l];
        }
        private void HandleEventString(string t)
        {
            string[] EventTemp =t.Split('.');
            if (EventTemp.Length > 1)
            {
                for (int i = 0; i < EventTemp.Length; i += 2)
                {
                    //OtherName.Text = t;
                    HandleEvent(EventTemp[i], EventTemp[i + 1]);

                }
            }
        }
        private void HandleEvent(string Eventid,string param)
        {
            
            if (Eventid == "/o")
                OtherName.Text = param;
            if (Eventid == "/t")
                Talker.Text = param+":";
            if (Eventid == "/shp")
            {
                if (param != "null")
                {
                    hp = Int32.Parse(param);
                    LabelHP.Text = "HP: " + param;
                }
                else
                    LabelHP.Text = "HP: " + hp.ToString();
            }
            if (Eventid == "/sda")
            {
                if (param != "null")
                {
                    da = Int32.Parse(param);
                    LabelDa.Text = "攻擊力: " + param;
                }
                else
                    LabelDa.Text = "攻擊力: " + da;
            }
            if (Eventid == "/slv")
            {
                if (param != "null")
                {
                    char[] temp = param.ToCharArray();
                    lv = temp[0];

                    LabelLv.Text = "等級: " + param;
                }
                else
                    LabelLv.Text = "等級: " + lv;
            }
            if (Eventid == "/sn")
                CharacterName.Text = name;
            if (Eventid == "/tn")
            {
                AddText(name + Story.GetStoryText());
                Addflag = false;
            }
            if (Eventid == "/sohp")
            {
                if (param == "null")
                    LabelOHP.Text="";
                else
                {
                    monsterHP = Int32.Parse(param);
                    if(da!=0)
                    attacknum = monsterHP / da;
                    LabelOHP.Text = "HP: " + param;
                }
            }
            if (Eventid == "/soda")
            {
                if (param == "null")
                    LabelODa.Text="";
                else
                {
                    monsterDa = Int32.Parse(param);
                    LabelODa.Text = "攻擊力: " + param;
                }
            }
            if(Eventid=="/setnext")
            {
                nextflag = true;
            }
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void CharacterNext_Click(object sender, EventArgs e)
        {
            if (nextflag && Story.next < MAX)
            {
                if (ShowTime != 0)
                {
                    ShowTime = 0;
                    CharacterText.Text = ShowText;
                }
                else
                {
                    Talker.Text = "";
                    PocDefine();
                }
            }
            else
            {

            }
        }

        private void TurtorialPic_Click(object sender, EventArgs e)
        {

        }

        private void MainCharacter_Click(object sender, EventArgs e)
        {

        }

        private void TurtorialText_TextChanged(object sender, EventArgs e)
        {
            TutorialText.SelectionStart = TutorialText.TextLength;
            TutorialText.ScrollToCaret();
        }

        private void CharacterName_Click(object sender, EventArgs e)
        {

        }

        private void FuncButton_Click(object sender, EventArgs e)
        {
            if (attacknum > 0)
            {
                attacknum--;
                for (int i = 0; i < 3; i++)
                {
                    OtherBox.Top += 10;
                    Thread.Sleep(50);
                    OtherBox.Top -= 10;
                    Thread.Sleep(50);
                    OtherBox.Left += 10;
                    Thread.Sleep(50);
                    OtherBox.Left -= 10;
                    Thread.Sleep(50);
                }
                
                FuncButton.Text = "攻擊鈕-剩餘" + attacknum + "次";
                monsterHP -= monsterHP / (attacknum + 1);
                LabelOHP.Text = "HP: " + monsterHP.ToString();
                
                if (attacknum == 0)
                {
                    kill++;
                    nextflag = true;
                    AddText("成功消滅怪物！");
                    OtherName.Text = OtherName.Text + "(消滅)";
                    FuncButton.Hide();
                    OtherBox.Image = Image.FromFile(Application.StartupPath + "\\dead.jpg");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EscapeButton_Click(object sender, EventArgs e)
        {
            FightButton.Hide();
            EscapeButton.Hide();
            PocDefine();
        }

        private void FightButton_Click(object sender, EventArgs e)
        {
            if(monsterDa>=hp)
            {
                MessageBox.Show("勇者，還是快逃吧！");
            }
            else
            {
                EscapeButton.Hide();
                FightButton.Hide();

                FuncButton.Show();
                FuncButton.Text = "攻擊鈕-剩餘" + attacknum + "次";
            }
        }

       
    }
}
