namespace PROJECT_PBO
{
    public partial class Menu_utama : Form
    {
        public Menu_utama()
        {
            InitializeComponent();
        }

        private void buttonLOGOUT_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();
            login.Show(); // Menampilkan form login sebagai modal
            this.Hide(); // Menutup form ini dengan aman
        }


        private void buttonKOMPONEN_Click(object sender, EventArgs e)
        {
            // Event handler untuk buttonKOMPONEN
        }

        private void buttonJASAPERBAIKAN_Click(object sender, EventArgs e)
        {
            // Event handler untuk buttonJASAPERBAIKAN
        }

        private void buttonTEKNISI_Click(object sender, EventArgs e)
        {
            // Event handler untuk buttonTEKNISI
        }

        private void buttonTRANSAKSI_Click(object sender, EventArgs e)
        {
            // Event handler untuk buttonTRANSAKSI
        }

        private void Menu_utama_Load(object sender, EventArgs e)
        {
            // Event handler untuk Menu_utama Load
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
