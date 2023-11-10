namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnContinueClicked(object sender, EventArgs e)
        {
            OnEntryCompleted(entry, e);
        }

        private void OnEntryCompleted(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;

            bool checkNumber = int.TryParse(text, out int number);

            if (checkNumber == true)
            {
                VerifyTxt.Text = ("Ви ввели число N");
            }
            else
            {
                VerifyTxt.Text = ("error");
            }
        }

        private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
            string myText = entry.Text;
        }
    }
}