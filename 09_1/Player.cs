using ItemTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerTest
{
    internal class Player
    {
        //フィールド
        private string name;

        private Item item;

        //メソッド
        //コンストラクタ
        public Player(string name)
        {
            this.name = name;
        }

        public Player(Item item)
        {
            this.item = item;
        }

        //アイテムを使う
        public void UseItem()
        {
            item.Use();
        }
    }
}
