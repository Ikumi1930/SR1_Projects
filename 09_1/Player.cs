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

        private string item;
        List<Item> items;

        //メソッド
        //コンストラクタ
        public Player(string name)
        {
            this.name = name;
        }

        public Player()
        {
            items = new List<Item>();
        }

        //アイテムを使う
        public void UseItem()
        {
            Console.WriteLine("{0}を使った", item);
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
