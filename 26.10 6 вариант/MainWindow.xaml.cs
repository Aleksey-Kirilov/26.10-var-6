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

namespace _26._10_6_вариант
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int firstNum = int.Parse(TxtNum1.Text);
            int secondNum = int.Parse(TxtNum2.Text);
            if (firstNum%secondNum == 0)
            LblResult.Content = "Число делится без остатка\nЧастное: " + (firstNum / secondNum).ToString(); 
            else
                LblResult.Content = "Число делится с остатком\nЧастное: " + (firstNum / secondNum).ToString() + "\n Остаток:" + (firstNum % secondNum).ToString();
        }
    }
}
