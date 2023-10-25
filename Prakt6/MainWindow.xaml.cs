using System;
using System.Windows;
using Lib_4;

namespace Prakt6
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

        Pair pair1 = new Pair(0, 0),
            pair2 = new Pair(0, 0);

        private void btnSavePair1_Click(object sender, RoutedEventArgs e) // Сохранить изменения в паре 1
        {
            if (Int32.TryParse(tbPair1First.Text, out int p1) && Int32.TryParse(tbPair1Second.Text, out int p2))
                pair1.SetParams(p1, p2);
            else MessageBox.Show("Введите правильные значения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        private void btnSavePair2_Click(object sender, RoutedEventArgs e) // Сохранить изменения в паре 2
        {
            if (Int32.TryParse(tbPair2First.Text, out int p1) && Int32.TryParse(tbPair2Second.Text, out int p2))
                pair2.SetParams(p1, p2);
            else MessageBox.Show("Введите правильные значения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void btnSavePairs_Click(object sender, RoutedEventArgs e) // Сохранить изменения в обеих парах
        {
            if (Int32.TryParse(tbPair1First.Text, out int p1) && Int32.TryParse(tbPair1Second.Text, out int p2) &&
                Int32.TryParse(tbPair2First.Text, out int q1) && Int32.TryParse(tbPair2Second.Text, out int q2))
            {
                pair1.SetParams(p1, p2);
                pair2.SetParams(q1, q2);
            }
            else MessageBox.Show("Введите правильные значения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void btnCompare_Click(object sender, RoutedEventArgs e) // Сравнить пары
        {
            if (pair1 > pair2) tbResult.Text = "Пара 1 больше пары 2";
            else tbResult.Text = "Пара 1 меньше пары 2";
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e) // О программе
        {
            MessageBox.Show("Разработчик: Антонишин Кирилл Сергеевич\n" +
                "Практическая работа №6\n" +
                "Использовать класс Pair (пара чисел). Разработать операции сравнения пар: пара p1 больше пары p2, " +
                "если (first.p1 > first.p2) или (first.p1 = first.p2) и (second.p1 > second.p2). ",
                "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnExit_Click(object sender, RoutedEventArgs e) // Выход
        {
            this.Close();
        }
    }
}
