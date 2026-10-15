namespace ExceptionTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileManager.Instance.SavePoznamky(new List<Poznamka>()
            {
                new Poznamka()
                {
                    id = 1,
                    nazev = "Test",
                    text = "Zkoušim jak to fachá",
                    jeHotova = false,
                    casVytvoreni = DateTime.Now
                }
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var poznamky = FileManager.Instance.LoadPoznamky();
            MessageBox.Show(poznamky.First().text);
        }
    }
}
