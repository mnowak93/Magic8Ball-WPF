using System.Windows;

namespace Magic8Ball
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAsk_Click(object sender, RoutedEventArgs e)
        {
            if(question.Text == "Ask your question here")
            {
                anwser.Text = "Ask a question first";
            }
            else
            {
                AnwserList a = new AnwserList();
                question.Text = "Ask your question here";
                anwser.Text = a.ReturnAnwser();
            }
        }
    }
}
