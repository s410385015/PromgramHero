using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingHero
{
    public class StoryLine
    {
        private string[] StoryString = new string[256];
        private int[] StoryType = new int[256];
        private int[] PicID = new int[256];
        private string[] EventType = new string[256];
        private int[] RequestID = new int[256]; 
        public int next = 0;
        public int index = 0;
        public int requestnum = 0;
        public StoryLine()
        {
           
            StoryString[index] = "在另一個平行時空裡，地球發生了異變…….";
            PicID[index] = index;
            StoryType[index++] = 0;
           

            StoryString[index] = "知名電腦病毒DaDaDoDo爆發，從網路世界入侵到人類世界，消滅了95%地球上的人口…….";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "僥倖活下來的你，決定要成為資工人，拯救這個世界…….";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "<請建立角色>.";
            PicID[index] = index;
            StoryType[index++] = 99;

            StoryString[index] = "勇者你好，我是前來助你一臂之力的小精靈\"Amber\",";
            PicID[index] = 3;
            EventType[index] = "/o.Amber./t.Amber";
            StoryType[index++] = 1;

            StoryString[index] = "我們從你身上看到了這個世界的希望，因此我們會助你一臂之力，讓你成為優秀的資工人.";
            PicID[index] = 3;
            EventType[index] = "/o.Amber./t.Amber";
            StoryType[index++] = 1;

            StoryString[index] = "那麼就開始我們的訓練吧…….";
            PicID[index] = 3;
            EventType[index] = "/o.Amber./t.Amber";
            StoryType[index++] = 1;

            StoryString[index] = "第0章<基礎入門>.";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "這是一個簡單的小程式.";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "程式的第一行，紅框部分叫做\"標頭檔\"。\n你可以把整個程式想像是一個房子，而標頭檔就像一個告示牌，告訴你這房子使用的物件是哪裡來的。舉例來說:你想使用Ikea買來的家具，那你就必須宣告一個ikea的標頭檔，這樣程式才能知道家具的樣式、種類。.";
            PicID[index] = index;
            StoryType[index++] = 0;

            //Here is 10
            StoryString[index] = "程式的第三行，前半部的\"int\"是一種變數型態，詳細說明會在下一章節提到。\n而後半的\"main\"，是程式的進入點，你可以把它想像是程式的大門，一切的程序都是從這裡開始執行。.";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "紅框空白的部分，就是給你撰寫程式要做的事情的的地方。如果在程式碼的前端加上\"//\"，程式在執行的時候會自動略過它，讓它變成一段註解。\n第八行，藍框的\"return\"，是當程式程式結束時，會回傳一段訊息，告訴整段程式運行的結果，後面的\"0\"這是和上方main旁邊的int型態互相對應，宣告甚麼型態就必須回傳怎樣的訊息型態。.";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "我們現在中央加入一小段程式。>>printf(\"Hello World\")。並按下執行。\n這時候會跑出一個黑色的視窗，上面寫著Hello World。\n這個黑色視窗我們叫做console，也就是程式顯示結果的地方。\n這裡要注意一點，每一段程式碼後面都必須要加上\";\"，來告訴系統這行已經結束了，否則可是會出現錯誤的呢！";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "printf()是一個定義在stdio.h標頭檔的函式(想像是一種功能)，它可以用來顯示一些話在console視窗上。\n簡單來說程式就是由這些函式和一些簡單的邏輯運算所組成的。";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "相信你對程式架構有基礎的瞭解了，現在來個小小的測驗吧!.";
            PicID[index] = 3;
            EventType[index] = "/o.Amber./t.Amber";
            StoryType[index++] = 1;

            StoryString[index] = "試著用printf和Amber打聲招呼.";
            PicID[index] = 3;
            EventType[index] = "/o.Amber";
            RequestID[index]=requestnum++;
            StoryType[index++] = 2;


            StoryString[index] = "Hello Amber.";
            PicID[index] = 3;
            EventType[index] = "/o.Amber./t.勇者";
            StoryType[index++] = 1;


            StoryString[index] = "你好，做的很好呢^^，那我們趕緊進入下一章吧！.";
            PicID[index] = 3;
            EventType[index] = "/o.Amber./t.Amber";
            StoryType[index++] = 1;

           
            StoryString[index] = "第1章 變數.";
            PicID[index] = index;
            StoryType[index++] = 0;
            
            StoryString[index] = "上面紅框部分，就是程式的變數。\n變數是什麼呢?它是程式語言中的資料儲存方式，你可以把它想像是家裡的各種家具，並且分別給它取個名字記錄下來，這就是變數。.";
            PicID[index] = index;
            StoryType[index++] = 0;
            //Here is 20
            StoryString[index] = "上述的藍色框框部分是變數的資料型態。\n旁邊綠色的部分則是變數的名字。.";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "這些是我們比較常用的基本變數型態。\n每個型態都有它所能表示的最大範圍，舉例來說整數型態int,最大的上限範圍就是2的31次方-1>>2147483647，相信大家對這個數字應該不陌生吧?";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "一般來說我們在宣告變數的時候，比較常用的有這兩種方式:\n．先宣告，但不給定初始值。之後再給予值。\n．宣告並給定初始值。.";
            PicID[index] = index;
            StoryType[index++] = 0;


            StoryString[index] = "這邊要特別注意的是，\"=\"在程式語言中是賦值(給定一個值)的意思，而不是數學符號中的等於，數學中的等於，在這裡是用\"==\"來表示。.";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "不同資料型態的變數宣告方式大同小異。\n不過在宣告char(字元)變數的時候，要記得所欲宣告的值要用' '包起來。";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "不知道勇者對變數瞭解了多少呢?我們來做點暖身吧，用剛剛所教的方式，來設定一下自己的資料吧！.";
            PicID[index] = 3;
            EventType[index] = "/o.Amber./t.Amber";
            StoryType[index++] = 1;

            StoryString[index] = "設定自己的血量.";
            PicID[index] = 3;
            EventType[index] = "/o.Amber";
            RequestID[index] = requestnum++;
            StoryType[index++] = 2;

            StoryString[index] = "好極了，接下來我們嘗試另一種來宣告變數吧！.";
            PicID[index] = 3;
            EventType[index] = "/o.Amber./t.Amber./shp.10";
            StoryType[index++] = 1;

            StoryString[index] = "設定自己的攻擊力.";
            PicID[index] = 3;
            EventType[index] = "/o.Amber";
            RequestID[index] = requestnum++;
            StoryType[index++] = 2;

            StoryString[index] = "接下來我們挑戰一點有難度的吧！.";
            PicID[index] = 3;
            EventType[index] = "/o.Amber./t.Amber./sda.10./shp.10";
            StoryType[index++] = 1;

            //Here is 30
            StoryString[index] = "設定自己的等級.";
            PicID[index] = 3;
            EventType[index] = "/o.Amber";
            RequestID[index] = requestnum++;
            StoryType[index++] = 2;

            StoryString[index] = "做的很好！不用擔心自己現在還很弱，繼續努力下去吧，勇者！.";
            PicID[index] = 3;
            EventType[index] = "/o.Amber./t.Amber./slv.C./sda.10./shp.10";
            StoryType[index++] = 1;

            StoryString[index] = "接下來我們要講的是陣列！陣列也是一種變數的宣告方式。\n假設今天我們有好幾十個變數要宣告，如果要一一幫他命名，那麼會十分的累人，且佔版面。如果這時候我們使用陣列，即可用一個名字，來管理這些變數。.";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "陣列的宣告方法，就是在原本的變數加上[]的框框，框框中的數字，代表你需要的變數個數。一樣有分成兩種方式：\n．給定初始值\n．不給定初始值\n如果是選擇不給定初使值的方式時，記得一定要告訴陣列大小（需要幾格）。.";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "陣列的起始編號是0，也就是你宣告一個5格大小的陣列，你的編號實際是0~4。如果你不小心使用了第5號陣列，那麼可能就會跳出錯誤訊息。.";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "當我們想宣告一個字串的時候，我們可以使用char陣列。\n跟原先不同的時候，單一字元時使用的是' '，但在宣告字串時則是使用\" \".";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "講到了字串，勇者，我好像還沒問你叫做什麼名字呢？.";
            PicID[index] = 3;
            EventType[index] = "/o.Amber./t.Amber./slv.C./sda.10./shp.10./sn.null";
            StoryType[index++] = 1;

            StoryString[index] = "設定名字.";
            PicID[index] = 3;
            EventType[index] = "/o.Amber";
            RequestID[index] = requestnum++;
            StoryType[index++] = 98;

            StoryString[index] = "你好！真是個好名字呢！";
            PicID[index] = 3;
            EventType[index] = "/o.Amber./t.Amber./slv.C./sda.10./shp.10./sn.null./tn.null";
            StoryType[index++] = 1;

            StoryString[index] = "此時，遠方傳來一陣巨響了";
            PicID[index] = index;
            //EventType[index] = "/o.Amber./t.Amber./slv.C./sda.10./shp.10./sn.null";
            StoryType[index++] = 0;

            StoryString[index] = "不好了！遠方有一波病毒要來了，我們得趕快教你一些戰鬥方法。.";
            PicID[index] = 3;
            EventType[index] = "/o.Amber./t.Amber./slv.C./sda.10./shp.10./sn.null./tn.null";
            StoryType[index++] = 1;
           
            //here is 40
            StoryString[index] = "第2章 基礎運算.";
            PicID[index] = index;
            StoryType[index++] = 0;


            StoryString[index] = "程式語言和數學一樣，都有加減乘除這些運算符號，我們稱之為運算子。.";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "使用上和數學的運算規則是一樣得。當我們打好一長串的數學式子，系統會自動幫我們作運算，得到答案。\n如果我們想把這個結果儲存下來，則必須用一個變數去接它。.";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "其他的運算子還有這些…….";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "++和--也是我們常用的運算子，它們代表遞增跟遞減1的意思。\n它們可以放在運算元的前方，也可以放在運算元的後方。如同紅框處:a++和++a，都表示a的值加1的意思。.";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "轟隆隆……..";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "不好了，是病毒螢光臭臭泥!快點運用剛剛所學，把它消滅吧！";
            PicID[index] = 101;
            EventType[index] = "/o.病毒-螢光臭臭泥./t.Amber./slv.C./sda.10./shp.10./sn.null./sohp.45";
            StoryType[index++] = 1;

            StoryString[index] = "請消滅怪物.";
            PicID[index] = 101;
            EventType[index] = "/o.病毒-螢光臭臭泥./slv.C./sda.10./shp.10./sn.null./sohp.45";
            RequestID[index] = requestnum++;
            StoryType[index++] = 2;

            StoryString[index] = "計算結果:需要攻擊三次!請點擊中央的攻擊鍵.";
            PicID[index] = 101;
            EventType[index] = "/o.病毒-螢光臭臭泥./slv.C./sda.10./shp.10./sn.null./sohp.45";
            StoryType[index++] = 97;
            
            //Here is 50
            StoryString[index] = "真厲害！你成功消滅怪了呢!\n恭喜你等級上升了唷!.";
            PicID[index] = 3;
            EventType[index] = "/o.Amber./t.Amber./slv.B./sda.10./shp.10./sn.null./sohp.null";
            StoryType[index++] = 1;

            
            StoryString[index] = "請嘗試升等.";
            PicID[index] = 3;
            EventType[index] = "/o.Amber./slv.B./sda.10./shp.10./sn.null";
            StoryType[index++] = 96;


            StoryString[index] = "雖然實力變強了，但也不能掉以輕心，讓我來教你更進階的東西吧！.";
            PicID[index] = 3;
            EventType[index] = "/o.Amber./t.Amber./slv.B./sda.null./shp.null./sn.null";
            StoryType[index++] = 1;

            StoryString[index] = "第3章 流程控制.";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "if是我們常用來控制流程的判斷式，後面紅線用( )包住的部分，是我們的條件。當我們滿足條件時，就會執行下面{ }包住的部分，否則就會跳過不執行。/n上面程式的範例:如果a>b的話，我們就將b的值加5。.";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "通常if會搭配else來使用。如果if表示滿足條件才作，那麼else所表示的就是所有if不滿足的條件。\n以上圖的程式為例:if的條件是a要大於b，那因a是10、b是15，不滿足條件，所以我們進入else，將b的值減掉5。.";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "有時候條件不只一個時，我們會用運算子&&(AND)及||(OR)來幫助我們。\n&&表示要同時滿足兩個條件才會成立，以上圖藍框來講，a>0且a<b要同時成立才算滿足if條件。\n||表示兩個條件中只要滿足一個條件就算成立，以上圖綠框來講，a<10或a>b只要其中一個條件成立就算成立。.";
            PicID[index] = index;
            StoryType[index++] = 0;


            StoryString[index] = "接下來將會有大量怪物來襲，趕快做好戰鬥準備吧!.";
            PicID[index] = 3;
            EventType[index] = "/o.Amber./t.Amber";
            StoryType[index++] = 1;

            StoryString[index] = "請做好戰鬥準備.";
            PicID[index] = 3;
            EventType[index] = "/o.Amber";
            RequestID[index] = requestnum++;
            StoryType[index++] = 2;

            StoryString[index] = "勇者加油！.";
            PicID[index] = 3;
            EventType[index] = "/o.Amber./t.Amber";
            StoryType[index++] = 1;

            StoryString[index] = "請根據剛剛的判斷式子選擇按鈕.";
            PicID[index] = 103;
            EventType[index] = "/o.病毒-三眼Yo./sohp.40./soda.5";
            StoryType[index++] = 95;

            StoryString[index] = "請根據剛剛的判斷式子選擇按鈕.";
            PicID[index] = 104;
            EventType[index] = "/o.病毒-邪惡謙./sohp.60./soda.7";
            StoryType[index++] = 95;

            StoryString[index] = "請根據剛剛的判斷式子選擇按鈕.";
            PicID[index] = 105;
            EventType[index] = "/o.病毒-紫色叮噹./sohp.200./soda.50";
            StoryType[index++] = 95;

            StoryString[index] = "，病毒太多了！這樣下去不行！你快退到後面！.";
            PicID[index] = 3;
            EventType[index] = "/o.Amber./t.Amber./tn.null./setnext.null./sohp.null./soda.null";
            StoryType[index++] = 1;

            StoryString[index] = "這時小精靈Amber飛到空中，全身發出了白光…….";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "白光漸漸消失，所有的病毒全都消失了……\n連Amber……也失去了蹤影……。";
            PicID[index] = index;
            StoryType[index++] = 0;
            
            StoryString[index] = "地上留下了一封信和一本書.";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "勇者大人，當你看到這封信的時候，代表我已經不在了……\n雖然我們認識不久，但是我很喜歡你，我從你身上看到了這個世界的希望……\n這是我們祖傳的程式寶典，希望你能好好的閱讀他，成為優秀的資工人，拯救這個世界。\n勇者，交給你了…….";
            PicID[index] = index;
            StoryType[index++] = 0;

            StoryString[index] = "序章-英雄誕生 完.";
            PicID[index] = 999;
            StoryType[index++] = 999;
        }

        public string GetStoryText()
        { return StoryString[next]; }
        public int GetStoryType()
        { return StoryType[next]; }

        public int GetPicID()
        { return PicID[next]; }
        public string GetEventID()
        { return EventType[next]; }
        public void SetNext(int num)
        { next = num; }
        public int GetRequestID()
        { return RequestID[next]; }
    }
}
