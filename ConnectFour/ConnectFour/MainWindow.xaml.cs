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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Grid gameGrid;
        int x = 0;
        public MainWindow()
        {
            InitializeComponent();
            gameGrid = new Grid();
            StatusText.Text = gameGrid.getCurrentPlayerAB() + " Turns";

            InputBoxDialog dlg = new InputBoxDialog();

            dlg.ShowDialog();
            PlayerInformations a = new PlayerInformations(dlg.Name1);
            PlayerInformations b = new PlayerInformations(dlg.Name2);
            gameGrid.setPlayerA(a);
            gameGrid.setPlayerB(b);

        }

        private void draw(int column)
        {
            if (!gameGrid.isFull(column))
            {
                gameGrid.drop(column);
                Rectangle square = new Rectangle();
                square.Height = 50;
                square.Width = 75;
                Canvas.SetTop(square, gameGrid.getRow()*50);
                Canvas.SetLeft(square, column*70);
                if (gameGrid.getCurrentPlayerAB() == Player.ONE)
                    square.Fill = Brushes.Red;
                else
                    square.Fill = Brushes.Blue;
                gameGrid.toggleCurrentPlayer();
                StatusText.Text = gameGrid.getCurrentPlayerAB() + " Turns";
                GameCanvas.Children.Add(square);
                if(gameGrid.hasWon())
                {
                    MessageBox.Show("win " + gameGrid.getCurrentPlayer().getName());
                    border.IsEnabled = false;
                }
                
            }
            else
            {
                Console.WriteLine("teli");
            }
        }

        private void InsertButton0_Click(object sender, RoutedEventArgs e)
        {
            draw(0);
        }
        private void InsertButton1_Click(object sender, RoutedEventArgs e)
        {
            draw(1);
        }
        private void InsertButton2_Click(object sender, RoutedEventArgs e)
        {
            draw(2);
        }
        private void InsertButton3_Click(object sender, RoutedEventArgs e)
        {
            draw(3);
        }
        private void InsertButton4_Click(object sender, RoutedEventArgs e)
        {
            draw(4);
        }
        private void InsertButton5_Click(object sender, RoutedEventArgs e)
        {
            draw(5);
        }
        private void InsertButton6_Click(object sender, RoutedEventArgs e)
        {
            draw(6);
        }


        private void OKButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DialogResult = true;
        }


    }
}