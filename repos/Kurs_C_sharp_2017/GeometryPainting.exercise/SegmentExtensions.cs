using System;
using GeometryTasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GeometryPainting
{
    //Напишите здесь код, который заставит работать методы segment.GetColor и segment.SetColor
    public class Segment
    {
        public Color SaveColor;
        public Vector Begin;
        public Vector End;

        public Color GetColor()
        {
            return SaveColor;
        }
        public void SetColor(Color color)
        {
            Color SaveColor = color;
        }
    }
}