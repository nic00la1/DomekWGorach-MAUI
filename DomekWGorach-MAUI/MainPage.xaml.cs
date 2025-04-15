namespace DomekWGorach_MAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void OnIncrement_Clicked(object sender, EventArgs e)
        {
            count++;
            CounterBtn.Text = $"{count} polubień";
        }

        private void OnDecrement_Clicked(object sender, EventArgs e)
        {
            if (count <= 0)
                CounterBtn.Text = $"{count} polubień";
            else
            {
                count--;
                CounterBtn.Text = $"{count} polubień";
            }
        }
    }

}
