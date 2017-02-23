using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using StackArray;

namespace Undo_Stack
{
    public class UndoAction
    {
        Button button;
        //Brush brush;
        SolidColorBrush brush;
        Color color;
        public UndoAction(Button b)
        {
            button = b;
            brush = button.Background as SolidColorBrush;
            color = brush.Color;
        }

        public void execute()
        {
            button.Background = brush;
        }
        public override string ToString()
        {
            return string.Format("{0},{1}",button.Content,color.ToString());
        }
    }
}
