namespace MAUIApp2
{
    public partial class MainPage : ContentPage
    {
        String a = "Reality";

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnImageButtonaClicked(object sender, EventArgs e)
        {
            Expect1.Source = "Real1.png";
            Lbl1.Text = a;
        }

        private void OnImageButtonbClicked(object sender, EventArgs e)
        {
            Expect2.Source = "Real2.png";
            Lbl2.Text = a;
        }

    }
}