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
        private List<Item> items;

        //メソッド
        //コンストラクタ
        public Player()
        {
            items = new List<Item>();
        }

        //アイテムを受け取る
        public void AddItem(Item item)
        {
            items.Add(item);
        }

        //アイテムを使う
        public void UseItems()
        {
            foreach (Item item in items)
            {
                item.Use();
            }
        }
    }
}
