using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public static class ColorCommands
    {
        public static readonly RoutedUICommand RedCommand = new RoutedUICommand("Red Command", "RedCommand", typeof(ColorCommands));
        public static readonly RoutedUICommand GreenCommand = new RoutedUICommand("Green Command", "GreenCommand", typeof(ColorCommands));
        public static readonly RoutedUICommand BlueCommand = new RoutedUICommand("Blue Command", "BlueCommand", typeof(ColorCommands));

        static ColorCommands()
        {
            CommandManager.RegisterClassCommandBinding(typeof(UIElement), new CommandBinding(RedCommand, RedCommand_Executed));
            CommandManager.RegisterClassCommandBinding(typeof(UIElement), new CommandBinding(GreenCommand, GreenCommand_Executed));
            CommandManager.RegisterClassCommandBinding(typeof(UIElement), new CommandBinding(BlueCommand, BlueCommand_Executed));
        }

        private static void RedCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var control = Keyboard.FocusedElement as Control;
            if (control != null)
                control.Background = Brushes.Red;
        }

        private static void GreenCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var control = Keyboard.FocusedElement as Control;
            if (control != null)
                control.Background = Brushes.Green;
        }

        private static void BlueCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var control = Keyboard.FocusedElement as Control;
            if (control != null)
                control.Background = Brushes.Blue;
        }
    }
}
