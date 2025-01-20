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
        private Item item;

        //メソッド
        //コンストラクタ
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
