using MES_system_third.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace MES_system_third.ViewModel
{
    class Rectangle
    {
        //public int X { get { return 0; } }
        //public int Y { get { return 27 + 23; } }
        //public int Width { get { return 55; } }
        //public string DuringString { get { return "hour"; } }
        public double X { get; set; }
        public double Y { get; set; }
        public double Width { get; set; }
        public string DuringString { get; set; }
        public Brush Color { get; set; }
    }
    static class ListOfRectanglesClass
    {
        public static List<Rectangle> CreateListRectangle(List<process> list_processes)
        {
            List<Rectangle> ListOfRectangles = new List<Rectangle>();
            DateTime min_X = list_processes[0].dateTimeStart.Value;
            double tmp_Y = 23;
            double tmp_widht;
            Brush color;
            foreach (process proc in list_processes)
            {
                tmp_widht = (proc.dateTimeFinish.Value - proc.dateTimeStart.Value).TotalHours;
                if (proc.operation != null)
                    color = proc.operation.ColorBrush;
                else
                    color = (Brush)(new BrushConverter()).ConvertFrom("Red");
                ListOfRectangles.Add(new Rectangle()
                {
                    X = (proc.dateTimeStart.Value - min_X).TotalHours * 10,
                    Y = tmp_Y,
                    Width = tmp_widht*10,
                    DuringString = (((double)((int)(tmp_widht*10)))/10).ToString() + " hours",
                    Color = color
                });
                tmp_Y += 27;
            }
            return ListOfRectangles;
        }
    }
}
