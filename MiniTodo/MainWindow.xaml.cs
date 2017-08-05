using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MiniTodo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    /// 
    public class TodoListItem
    {
        public int ID { set; get; }
        public string Text { set; get; }
    }
    public partial class MainWindow : Window
    {
        public List<TodoListItem> tdl;
        public int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
            tdl = new List<TodoListItem>();
            TaskList.ItemsSource = tdl;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tdl.Add(new TodoListItem() { ID = counter, Text = NewTask.Text });
            NewTask.Text = "";
            TaskList.Items.Refresh();
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                Button_Click(sender, e);
            }
        }
    }
}
