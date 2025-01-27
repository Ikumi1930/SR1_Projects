using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeTest;
using System.Runtime.InteropServices;
using System.Globalization;

namespace TriangleTest
{
    internal class Triangle : Shape
    {
        //フィールド
        private float width;
        private float height;

        //コンストラクタ
        public Triangle(float width, float height)
        {
            this.width = width;
            this.height = height;

            area = width * height / 2;

        }

        public override void Draw()
        {
            Console.WriteLine("△");
        }
    }
}
