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
    public static class SegmentExtension
    {
        public static Color SaveColor;
        
        public static Color GetColor(this Segment segment)
        {
            return SaveColor;
        }
        public static void SetColor(this Segment segment, Color color)
        {
            Color SaveColor = color;
        }
    }
}