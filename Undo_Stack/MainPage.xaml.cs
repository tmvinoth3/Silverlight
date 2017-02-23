using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Undo_Stack
{
    public partial class MainPage : UserControl
    {
        Stack<UndoAction> undoOps = new Stack<UndoAction>();
        Random rng = new Random();

        public MainPage()
        {
            InitializeComponent();
        }

        private Brush getRandomBrush()
        {
            byte[] rgb = new byte[4];
            rng.NextBytes(rgb);
            return new SolidColorBrush(Color.FromArgb(rgb[0], rgb[1], rgb[2],rgb[3]));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            undoOps.Push(new UndoAction(button1));
            button1.Background = getRandomBrush();
            updateList();
        }

        public void updateList()
        {
            listBox1.Items.Clear();
            foreach (UndoAction action in undoOps)
            {
                listBox1.Items.Add(action.ToString());
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            undoOps.Push(new UndoAction(button2));
            button2.Background = getRandomBrush();
            updateList();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            undoOps.Push(new UndoAction(button3));
            button3.Background = getRandomBrush();
            updateList();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (undoOps.Count > 0)
            {
                undoOps.Pop().execute();
                updateList();
            }
        }

    }
}
