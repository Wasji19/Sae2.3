namespace CalculMasqueReseau
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxAdresseIP1 = new System.Windows.Forms.TextBox();
            this.textBoxBitsSousReseau = new System.Windows.Forms.TextBox();
            this.buttonCalculerMasqueReseau = new System.Windows.Forms.Button();
            this.labelMasqueReseau = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMSR = new System.Windows.Forms.Label();
            this.lblCB = new System.Windows.Forms.Label();
            this.lblCH = new System.Windows.Forms.Label();
            this.labelAdresseBinaire = new System.Windows.Forms.Label();
            this.labelAdresseHexa = new System.Windows.Forms.Label();
            this.radioButtonCIDR = new System.Windows.Forms.RadioButton();
            this.radioButtonMasque = new System.Windows.Forms.RadioButton();
            this.textBoxMasqueSR = new System.Windows.Forms.TextBox();
            this.groupBoxMasque = new System.Windows.Forms.GroupBox();
            this.panelBG = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAdresseClasse = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIP1 = new System.Windows.Forms.Label();
            this.lblLastIP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNbIP = new System.Windows.Forms.Label();
            this.lblNbMachines = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.lblBroadcast = new System.Windows.Forms.Label();
            this.lblResNet = new System.Windows.Forms.Label();
            this.lblResBroadcast = new System.Windows.Forms.Label();
            this.lblNames = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxMasque.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxAdresseIP1
            // 
            this.textBoxAdresseIP1.Location = new System.Drawing.Point(24, 43);
            this.textBoxAdresseIP1.Name = "textBoxAdresseIP1";
            this.textBoxAdresseIP1.Size = new System.Drawing.Size(245, 22);
            this.textBoxAdresseIP1.TabIndex = 0;
            // 
            // textBoxBitsSousReseau
            // 
            this.textBoxBitsSousReseau.Location = new System.Drawing.Point(28, 51);
            this.textBoxBitsSousReseau.Name = "textBoxBitsSousReseau";
            this.textBoxBitsSousReseau.Size = new System.Drawing.Size(245, 22);
            this.textBoxBitsSousReseau.TabIndex = 1;
            // 
            // buttonCalculerMasqueReseau
            // 
            this.buttonCalculerMasqueReseau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCalculerMasqueReseau.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCalculerMasqueReseau.Location = new System.Drawing.Point(298, 188);
            this.buttonCalculerMasqueReseau.Name = "buttonCalculerMasqueReseau";
            this.buttonCalculerMasqueReseau.Size = new System.Drawing.Size(101, 34);
            this.buttonCalculerMasqueReseau.TabIndex = 2;
            this.buttonCalculerMasqueReseau.Text = "Calculer";
            this.buttonCalculerMasqueReseau.UseVisualStyleBackColor = false;
            this.buttonCalculerMasqueReseau.Click += new System.EventHandler(this.buttonCalculerMasqueReseau_Click);
            // 
            // labelMasqueReseau
            // 
            this.labelMasqueReseau.AutoSize = true;
            this.labelMasqueReseau.BackColor = System.Drawing.Color.White;
            this.labelMasqueReseau.Location = new System.Drawing.Point(65, 280);
            this.labelMasqueReseau.Name = "labelMasqueReseau";
            this.labelMasqueReseau.Size = new System.Drawing.Size(16, 16);
            this.labelMasqueReseau.TabIndex = 3;
            this.labelMasqueReseau.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adresse IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 5;
            // 
            // lblMSR
            // 
            this.lblMSR.AutoSize = true;
            this.lblMSR.BackColor = System.Drawing.Color.White;
            this.lblMSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSR.Location = new System.Drawing.Point(65, 255);
            this.lblMSR.Name = "lblMSR";
            this.lblMSR.Size = new System.Drawing.Size(159, 16);
            this.lblMSR.TabIndex = 6;
            this.lblMSR.Text = "Masque de sous-réseau :";
            // 
            // lblCB
            // 
            this.lblCB.AutoSize = true;
            this.lblCB.BackColor = System.Drawing.Color.White;
            this.lblCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCB.Location = new System.Drawing.Point(394, 255);
            this.lblCB.Name = "lblCB";
            this.lblCB.Size = new System.Drawing.Size(125, 16);
            this.lblCB.TabIndex = 7;
            this.lblCB.Text = "Conversion binaire :";
<<<<<<< HEAD
=======
           
>>>>>>> 772c9bcbc72cadefda4870682b36ad7ca1689b00
            // 
            // lblCH
            // 
            this.lblCH.AutoSize = true;
            this.lblCH.BackColor = System.Drawing.Color.White;
            this.lblCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCH.Location = new System.Drawing.Point(394, 309);
            this.lblCH.Name = "lblCH";
            this.lblCH.Size = new System.Drawing.Size(161, 16);
            this.lblCH.TabIndex = 8;
            this.lblCH.Text = "Conversion héxadécimal :";
            // 
            // labelAdresseBinaire
            // 
            this.labelAdresseBinaire.AutoSize = true;
            this.labelAdresseBinaire.BackColor = System.Drawing.Color.White;
            this.labelAdresseBinaire.Location = new System.Drawing.Point(394, 280);
            this.labelAdresseBinaire.Name = "labelAdresseBinaire";
            this.labelAdresseBinaire.Size = new System.Drawing.Size(16, 16);
            this.labelAdresseBinaire.TabIndex = 9;
            this.labelAdresseBinaire.Text = "...";
            // 
            // labelAdresseHexa
            // 
            this.labelAdresseHexa.AutoSize = true;
            this.labelAdresseHexa.BackColor = System.Drawing.Color.White;
            this.labelAdresseHexa.Location = new System.Drawing.Point(394, 339);
            this.labelAdresseHexa.Name = "labelAdresseHexa";
            this.labelAdresseHexa.Size = new System.Drawing.Size(16, 16);
            this.labelAdresseHexa.TabIndex = 10;
            this.labelAdresseHexa.Text = "...";
            // 
            // radioButtonCIDR
            // 
            this.radioButtonCIDR.AutoSize = true;
            this.radioButtonCIDR.Location = new System.Drawing.Point(28, 25);
            this.radioButtonCIDR.Name = "radioButtonCIDR";
            this.radioButtonCIDR.Size = new System.Drawing.Size(60, 20);
            this.radioButtonCIDR.TabIndex = 11;
            this.radioButtonCIDR.TabStop = true;
            this.radioButtonCIDR.Text = "CIDR";
            this.radioButtonCIDR.UseVisualStyleBackColor = true;
            this.radioButtonCIDR.CheckedChanged += new System.EventHandler(this.radioButtonCIDR_CheckedChanged);
            // 
            // radioButtonMasque
            // 
            this.radioButtonMasque.AutoSize = true;
            this.radioButtonMasque.Location = new System.Drawing.Point(28, 103);
            this.radioButtonMasque.Name = "radioButtonMasque";
            this.radioButtonMasque.Size = new System.Drawing.Size(149, 20);
            this.radioButtonMasque.TabIndex = 12;
            this.radioButtonMasque.TabStop = true;
            this.radioButtonMasque.Text = "Adresse sur 4 octets";
            this.radioButtonMasque.UseVisualStyleBackColor = true;
            this.radioButtonMasque.CheckedChanged += new System.EventHandler(this.radioButtonMasque_CheckedChanged);
            // 
            // textBoxMasqueSR
            // 
            this.textBoxMasqueSR.Location = new System.Drawing.Point(28, 129);
            this.textBoxMasqueSR.Name = "textBoxMasqueSR";
            this.textBoxMasqueSR.Size = new System.Drawing.Size(245, 22);
            this.textBoxMasqueSR.TabIndex = 13;
            // 
            // groupBoxMasque
            // 
            this.groupBoxMasque.Controls.Add(this.radioButtonMasque);
            this.groupBoxMasque.Controls.Add(this.textBoxMasqueSR);
            this.groupBoxMasque.Controls.Add(this.textBoxBitsSousReseau);
            this.groupBoxMasque.Controls.Add(this.radioButtonCIDR);
            this.groupBoxMasque.Location = new System.Drawing.Point(369, 12);
            this.groupBoxMasque.Name = "groupBoxMasque";
            this.groupBoxMasque.Size = new System.Drawing.Size(321, 168);
            this.groupBoxMasque.TabIndex = 14;
            this.groupBoxMasque.TabStop = false;
            this.groupBoxMasque.Text = "Choix Masque";
            // 
            // panelBG
            // 
            this.panelBG.BackColor = System.Drawing.Color.White;
            this.panelBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBG.Location = new System.Drawing.Point(12, 237);
            this.panelBG.Name = "panelBG";
            this.panelBG.Size = new System.Drawing.Size(675, 317);
            this.panelBG.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Adresse de classe :";
<<<<<<< HEAD
=======
            
>>>>>>> 772c9bcbc72cadefda4870682b36ad7ca1689b00
            // 
            // lblAdresseClasse
            // 
            this.lblAdresseClasse.AutoSize = true;
            this.lblAdresseClasse.BackColor = System.Drawing.Color.White;
            this.lblAdresseClasse.Location = new System.Drawing.Point(65, 339);
            this.lblAdresseClasse.Name = "lblAdresseClasse";
            this.lblAdresseClasse.Size = new System.Drawing.Size(16, 16);
            this.lblAdresseClasse.TabIndex = 16;
            this.lblAdresseClasse.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "1ère IP :";
<<<<<<< HEAD
=======
         
>>>>>>> 772c9bcbc72cadefda4870682b36ad7ca1689b00
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(394, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Dernière IP :";
            // 
            // lblIP1
            // 
            this.lblIP1.AutoSize = true;
            this.lblIP1.BackColor = System.Drawing.Color.White;
            this.lblIP1.Location = new System.Drawing.Point(394, 400);
            this.lblIP1.Name = "lblIP1";
            this.lblIP1.Size = new System.Drawing.Size(16, 16);
            this.lblIP1.TabIndex = 19;
            this.lblIP1.Text = "...";
<<<<<<< HEAD
=======
            
>>>>>>> 772c9bcbc72cadefda4870682b36ad7ca1689b00
            // 
            // lblLastIP
            // 
            this.lblLastIP.AutoSize = true;
            this.lblLastIP.BackColor = System.Drawing.Color.White;
            this.lblLastIP.Location = new System.Drawing.Point(394, 458);
            this.lblLastIP.Name = "lblLastIP";
            this.lblLastIP.Size = new System.Drawing.Size(16, 16);
            this.lblLastIP.TabIndex = 20;
            this.lblLastIP.Text = "...";
<<<<<<< HEAD
=======
            
>>>>>>> 772c9bcbc72cadefda4870682b36ad7ca1689b00
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Nombre d\'IPs :";
<<<<<<< HEAD
=======
           
>>>>>>> 772c9bcbc72cadefda4870682b36ad7ca1689b00
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(394, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Nombre de machines :";
            // 
            // lblNbIP
            // 
            this.lblNbIP.AutoSize = true;
            this.lblNbIP.BackColor = System.Drawing.Color.White;
            this.lblNbIP.Location = new System.Drawing.Point(65, 523);
            this.lblNbIP.Name = "lblNbIP";
            this.lblNbIP.Size = new System.Drawing.Size(16, 16);
            this.lblNbIP.TabIndex = 23;
            this.lblNbIP.Text = "...";
<<<<<<< HEAD
=======
            
>>>>>>> 772c9bcbc72cadefda4870682b36ad7ca1689b00
            // 
            // lblNbMachines
            // 
            this.lblNbMachines.AutoSize = true;
            this.lblNbMachines.BackColor = System.Drawing.Color.White;
            this.lblNbMachines.Location = new System.Drawing.Point(394, 523);
            this.lblNbMachines.Name = "lblNbMachines";
            this.lblNbMachines.Size = new System.Drawing.Size(16, 16);
            this.lblNbMachines.TabIndex = 24;
            this.lblNbMachines.Text = "...";
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.BackColor = System.Drawing.Color.White;
            this.lblNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNet.Location = new System.Drawing.Point(65, 371);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(48, 16);
            this.lblNet.TabIndex = 25;
            this.lblNet.Text = "@Net :";
            // 
            // lblBroadcast
            // 
            this.lblBroadcast.AutoSize = true;
            this.lblBroadcast.BackColor = System.Drawing.Color.White;
            this.lblBroadcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBroadcast.Location = new System.Drawing.Point(65, 429);
            this.lblBroadcast.Name = "lblBroadcast";
            this.lblBroadcast.Size = new System.Drawing.Size(89, 16);
            this.lblBroadcast.TabIndex = 26;
            this.lblBroadcast.Text = "@Broadcast :";
            // 
            // lblResNet
            // 
            this.lblResNet.AutoSize = true;
            this.lblResNet.BackColor = System.Drawing.Color.White;
            this.lblResNet.Location = new System.Drawing.Point(65, 400);
            this.lblResNet.Name = "lblResNet";
            this.lblResNet.Size = new System.Drawing.Size(16, 16);
            this.lblResNet.TabIndex = 27;
            this.lblResNet.Text = "...";
            // 
            // lblResBroadcast
            // 
            this.lblResBroadcast.AutoSize = true;
            this.lblResBroadcast.BackColor = System.Drawing.Color.White;
            this.lblResBroadcast.Location = new System.Drawing.Point(65, 458);
            this.lblResBroadcast.Name = "lblResBroadcast";
            this.lblResBroadcast.Size = new System.Drawing.Size(16, 16);
            this.lblResBroadcast.TabIndex = 28;
            this.lblResBroadcast.Text = "...";
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNames.Location = new System.Drawing.Point(8, 571);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(586, 15);
            this.lblNames.TabIndex = 30;
            this.lblNames.Text = "Fait par Bastien DESHAYES, Youssef ABOUBI, Youcef OCHIBA, Wassim EL-JILALI et Sef" +
    "kan ACAR en 2023";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(620, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 34);
            this.button1.TabIndex = 31;
            this.button1.Text = "Aide";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(702, 596);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNames);
            this.Controls.Add(this.panelBG);
            this.Controls.Add(this.lblResBroadcast);
            this.Controls.Add(this.lblResNet);
            this.Controls.Add(this.lblBroadcast);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.lblNbMachines);
            this.Controls.Add(this.lblNbIP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblLastIP);
            this.Controls.Add(this.lblIP1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAdresseClasse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxMasque);
            this.Controls.Add(this.labelAdresseHexa);
            this.Controls.Add(this.labelAdresseBinaire);
            this.Controls.Add(this.lblCH);
            this.Controls.Add(this.lblCB);
            this.Controls.Add(this.lblMSR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMasqueReseau);
            this.Controls.Add(this.buttonCalculerMasqueReseau);
            this.Controls.Add(this.textBoxAdresseIP1);
            this.Name = "Form1";
            this.Text = "Calculateur de Masque Réseau";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxMasque.ResumeLayout(false);
            this.groupBoxMasque.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAdresseIP1;
        private System.Windows.Forms.TextBox textBoxBitsSousReseau;
        private System.Windows.Forms.Button buttonCalculerMasqueReseau;
        private System.Windows.Forms.Label labelMasqueReseau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMSR;
        private System.Windows.Forms.Label lblCB;
        private System.Windows.Forms.Label lblCH;
        private System.Windows.Forms.Label labelAdresseBinaire;
        private System.Windows.Forms.Label labelAdresseHexa;
        private System.Windows.Forms.RadioButton radioButtonCIDR;
        private System.Windows.Forms.RadioButton radioButtonMasque;
        private System.Windows.Forms.TextBox textBoxMasqueSR;
        private System.Windows.Forms.GroupBox groupBoxMasque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAdresseClasse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIP1;
        private System.Windows.Forms.Label lblLastIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNbIP;
        private System.Windows.Forms.Label lblNbMachines;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label lblBroadcast;
        private System.Windows.Forms.Label lblResNet;
        private System.Windows.Forms.Label lblResBroadcast;
        private System.Windows.Forms.Panel panelBG;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.Button button1;
    }
}

