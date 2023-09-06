using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lesson7
{
    internal class MyCommands
    {
        public static RoutedCommand Exit { get; set; }
        public static RoutedCommand FontBox_SelectionChanged { get; set; }

        static MyCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.O, ModifierKeys.Control, "Cttl+O"));
            Exit = new RoutedCommand("Exit", typeof(MyCommands), inputs);
            FontBox_SelectionChanged = new RoutedCommand("FontBox_SelectionChanged", typeof(MyCommands));
        }
    }
}
