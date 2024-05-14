namespace fiche1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtSaisie.TextLength == 0 ) 
            {
                MessageBox.Show("Erreur case vide");
            }
            
            lstListe.Items.Add(txtSaisie.Text);
            txtSaisie.Text = ""; // ou
            txtSaisie.Clear();
            txtSaisie.Focus();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (lstListe.SelectedItems.Count == 0)
            {
                MessageBox.Show("Erreur vous n'avez rien selectionné");
            }
            else
            {
                lstListe.Items.RemoveAt(lstListe.SelectedIndex);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal; this.txtSaisie.Focus();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}