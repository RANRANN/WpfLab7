using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfLab7
{
    internal class MyCommands
    {
        public static RoutedCommand Open { get; set; }
        public static RoutedUICommand Help { get; set; }
        public static RoutedUICommand Contacts { get; set; }

        static MyCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.O, ModifierKeys.Control, "Ctrl+O"));
            Open = new RoutedCommand("Open", typeof(MyCommands), inputs);

            InputGestureCollection inputs1 = new InputGestureCollection();
            inputs1.Add(new KeyGesture(Key.H, ModifierKeys.Control, "Ctrl+H"));
            Help = new RoutedUICommand("Помощь", "Help", typeof(MyCommands), inputs1);
            
            Contacts = new RoutedUICommand("Контакты", "Contacts", typeof(MyCommands));
        }
    }
}
