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
    public partial class Request : Form
    {
        private string[] RequestMsg = new string[256];
        private string[] RequestHint = new string[256];
        private string[] RequestQue = new string[256];
        private int num;
        private int index = 0;
        public string name;
        private int nameid=4;
        public Request(int id)
        {
            InitializeComponent();
            SetRequest();
            num = id;
            RequestBox.Text = RequestQue[num];
        }

        private void RequestBox_Load(object sender, EventArgs e)
        {
            HintBox.Hide();
        }

        private void Hint_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Hint_Click(object sender, EventArgs e)
        {
            if(Hint.Checked)
            {
                HintBox.Show();
                HintBox.Text = RequestHint[num];
            }
            else
            {
                HintBox.Hide();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            myText.Clear();
        }

        private bool CheckANS(string myAns,string requestText,int type)
        {
            myAns = myAns.Replace("\n", null);
            myAns = myAns.Replace(" ", null);
            requestText = requestText.Replace("\n", null);
            requestText = requestText.Replace(" ", null);
            
            if (num == nameid)
            {
                char[] a = myAns.ToCharArray();
                char[] b = requestText.ToCharArray();
                for(int i=0;i<9;i++)
                {
                    if (a[i] != b[i])
                        return false;
                }
                if (a[a.Length - 1] != ';')
                    return false;
                String[] temp = myAns.Split('=');
                name = temp[1];
                name = name.Replace("\"", null);
                name = name.Substring(0, name.Length - 1);
                return true;
            }

            if (myAns == requestText)
                return true;
            
            return false;
            
        }

        private void Complete_Click(object sender, EventArgs e)
        {
            if(CheckANS(myText.Text,RequestMsg[num],1))
            {
                MessageBox.Show("任務成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("請再確認答案一次！");
            }
        }
        private void SetRequest()
        {
            RequestQue[index] = "請用\"printf\"向小精靈Amber打招呼\n（Hello Amber）!";
            RequestHint[index] = "printf(\"Hello Amber\");";
            RequestMsg[index++] = "printf(\"Hello Amber\");";


            RequestQue[index] = "第一行用未給定初始值的方式宣告一個資料型態為int的變數HP。\n第二行我們給這個變數HP一個10的值。";
            RequestHint[index] = "int HP;\nHP=10;";
            RequestMsg[index++] = "int HP;\nHP=10;";

            RequestQue[index] = "宣告一個資料型態為int的變數Damage,並給定初始值為10";
            RequestHint[index] = "int Damage=10;";
            RequestMsg[index++] = "int Damage=10;";

            RequestQue[index] = "宣告一個資料型態為char的變數Level,並給定初始值為C";
            RequestHint[index] = "char Level='C';";
            RequestMsg[index++] = "char Level='C';";

            RequestQue[index] = "宣告一個資料型態為char的陣列Name,給給予一個自己喜歡的名字";
            RequestHint[index] = "char Name[]=\"Username\";";
            RequestMsg[index++] = "char Name[]=;";


            RequestQue[index] = "int MonsterHP=45(怪物血量);\nint Damage=10;(攻擊力)\nint num;\n請把怪物的血量除上自己的攻擊力+5，計算所需要攻擊的次數，並用num記錄下來。";
            RequestHint[index] = "num=MonsterHP/(Damage+5);";
            RequestMsg[index++] = "num=MonsterHP/(Damage+5);";

            RequestQue[index] = "你有以下資訊:\n病毒攻擊力(VirusDa)\n自己的血量(HP)\n逃跑功能(Escape())\n戰鬥功能(Fight())\n請用以上的資訊寫出if else的判斷式。\n當自己的血量小於病毒的攻擊力，則逃跑;反之則戰鬥。\n注意:判斷式必須用{}包起來。";
            RequestHint[index] = "if(HP<VirusDa){\n  Escape();\n}\nelse{\n   Fight();\n}";
            RequestMsg[index++] = "if(HP<VirusDa){Escape();}else{Fight();}";
        }

        public string GetName()
        { return name; }
    }
}
