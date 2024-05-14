namespace fiche1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstListe = new ListBox();
            btnAjouter = new Button();
            btnSupprimer = new Button();
            btnQuitter = new Button();
            txtSaisie = new TextBox();
            lstListeDeroulante = new Label();
            SuspendLayout();
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 15;
            lstListe.Location = new Point(194, 82);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(120, 94);
            lstListe.TabIndex = 0;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(466, 82);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 1;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(466, 153);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(75, 23);
            btnSupprimer.TabIndex = 2;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.Location = new Point(466, 243);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(75, 23);
            btnQuitter.TabIndex = 3;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // txtSaisie
            // 
            txtSaisie.Location = new Point(194, 243);
            txtSaisie.Name = "txtSaisie";
            txtSaisie.Size = new Size(100, 23);
            txtSaisie.TabIndex = 4;
            // 
            // lstListeDeroulante
            // 
            lstListeDeroulante.AutoSize = true;
            lstListeDeroulante.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lstListeDeroulante.Location = new Point(141, 20);
            lstListeDeroulante.Name = "lstListeDeroulante";
            lstListeDeroulante.Size = new Size(223, 24);
            lstListeDeroulante.TabIndex = 5;
            lstListeDeroulante.Text = "Une liste deroulante";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstListeDeroulante);
            Controls.Add(txtSaisie);
            Controls.Add(btnQuitter);
            Controls.Add(btnSupprimer);
            Controls.Add(btnAjouter);
            Controls.Add(lstListe);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstListe;
        private Button btnAjouter;
        private Button btnSupprimer;
        private Button btnQuitter;
        private TextBox txtSaisie;
        private Label lstListeDeroulante;
    }
}