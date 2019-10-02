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
using AppOOP;
namespace AppOOP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnTalk_Click(object sender, RoutedEventArgs e)
        {
            StudentCollege studentCollege = new StudentCollege();
            studentCollege.StudentName = "Minh";
            studentCollege.Talk();
            StudentUniversity studentUniversity = new StudentUniversity();
            studentUniversity.StudentName = "Dung";
            studentUniversity.Talk();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
