using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Shapes;


namespace WpfApp1
{
    public class Packman
    {
        public Rectangle Position { get; set; }
        public Packman(Canvas Canvas) 
        {
            Position = new Rectangle();
            Position.Name = "pacman";
            Position.Width = 30;
            Position.Height = 30;
            SolidColorBrush mySolidColorBrush = new SolidColorBrush();
            mySolidColorBrush.Color = Color.FromArgb(255, 255, 255, 0);
            Position.Fill = mySolidColorBrush;
        }
        //<Rectangle Name = "pacman" Width="30" Height="30" Fill="Yellow" Canvas.Left="100" Canvas.Top="260" />

    }
}
