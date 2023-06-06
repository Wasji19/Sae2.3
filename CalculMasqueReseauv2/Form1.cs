using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace CalculMasqueReseau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculerMasqueReseau_Click(object sender, EventArgs e)
        {
            try
            {
                string adresseIP = textBoxAdresseIP1.Text;
                int? bitsSousReseau = null;

                if (radioButtonCIDR.Checked)
                {
                    bitsSousReseau = int.Parse(textBoxBitsSousReseau.Text);

                    if (bitsSousReseau < 0 || bitsSousReseau > 32)
                    {
                        throw new Exception("Le nombre de bits de sous-réseau doit être compris entre 0 et 32.");
                    }
                }
                else if (radioButtonMasque.Checked)
                {
                    string masqueSousReseau = textBoxMasqueSR.Text;
                    string[] octetsMasque = masqueSousReseau.Split('.');

                    if (octetsMasque.Length != 4)
                    {
                        throw new Exception("Masque de sous-réseau invalide.");
                    }

                    byte[] masqueReseau = new byte[4];

                    for (int i = 0; i < octetsMasque.Length; i++)
                    {
                        masqueReseau[i] = byte.Parse(octetsMasque[i]);
                    }

                    bitsSousReseau = CalculerBitsSousReseau(masqueReseau);
                }

                if (bitsSousReseau.HasValue)
                {
                    byte[] masqueReseau = CalculerMasqueReseau(textBoxAdresseIP1.Text, bitsSousReseau.Value);


                    labelMasqueReseau.Text = string.Join(".", masqueReseau);
                    labelAdresseBinaire.Text = ConvertirEnBinaire(textBoxAdresseIP1.Text);
                    labelAdresseHexa.Text = ConvertirEnHexa(textBoxAdresseIP1.Text);
                    lblAdresseClasse.Text = AfficherAdresseClasse(textBoxAdresseIP1.Text);

                    string adresseReseau = CalculerAdresseReseau(textBoxAdresseIP1.Text, bitsSousReseau.Value);
                    string dernierIP = CalculerDernierIP(adresseReseau, bitsSousReseau.Value);

                    lblIP1.Text = CalculerPremiereIP(adresseReseau);
                    lblLastIP.Text = dernierIP;

                    int nombreIP = CalculerNombreIP(bitsSousReseau.Value);
                    lblNbIP.Text = nombreIP.ToString();

                    int nombreMachines = CalculerNombreMachines(bitsSousReseau.Value);
                    lblNbMachines.Text = nombreMachines.ToString();

                    string adresseNet = CalculerAdresseNet(adresseReseau, bitsSousReseau.Value);
                    string adresseBroadcast = CalculerAdresseBroadcast(adresseReseau, bitsSousReseau.Value);

                    lblResNet.Text = CalculerAdresseReseau(textBoxAdresseIP1.Text, bitsSousReseau.Value);
                    lblResBroadcast.Text = CalculerAdresseBroadcast(textBoxAdresseIP1.Text, bitsSousReseau.Value);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int CalculerBitsSousReseau(byte[] masqueReseau)
        {
            int bitsSousReseau = 0;

            for (int i = 0; i < 4; i++)
            {
                byte octet = masqueReseau[i];
                byte masque = 0x80;

                while (masque > 0 && (octet & masque) != 0)
                {
                    bitsSousReseau++;
                    masque >>= 1;
                }
            }

            return bitsSousReseau;
        }
        private string GetClasseLettre(int classe)
        {
            if (classe >= 1 && classe <= 126)
            {
                return "A";
            }
            else if (classe >= 128 && classe <= 191)
            {
                return "B";
            }
            else if (classe >= 192 && classe <= 223)
            {
                return "C";
            }
            else if (classe >= 224 && classe <= 239)
            {
                return "D";
            }
            else if (classe >= 240 && classe <= 255)
            {
                return "E";
            }
            else
            {
                throw new ArgumentException("Adresse IP invalide.");
            }
        }

        private byte[] CalculerMasqueReseau(string adresseIP, int bitsSousReseau)
        {
            string[] octetsIP = adresseIP.Split('.');
            byte[] masqueReseau = new byte[4];

            if (bitsSousReseau >= 0 && bitsSousReseau <= 32)
            {
                int classe = int.Parse(octetsIP[0]);
                int bitsClasse;

                if (classe >= 1 && classe <= 126)
                {
                    bitsClasse = 8;
                }
                else if (classe >= 128 && classe <= 191)
                {
                    bitsClasse = 16;
                }
                else if (classe >= 192 && classe <= 223)
                {
                    bitsClasse = 24;
                }
                else if (classe >= 224 && classe <= 239)
                {
                    bitsClasse = 32;
                }
                else
                {
                    throw new ArgumentException("Adresse IP invalide.");
                }

                if (bitsSousReseau < bitsClasse)
                {
                    string classeLettre = GetClasseLettre(classe);
                    throw new ArgumentException($"CIDR invalide pour une adresse de classe {classeLettre}.");
                }

                // Calcul du masque réseau
                for (int i = 0; i < masqueReseau.Length; i++)
                {
                    if (bitsSousReseau >= 8)
                    {
                        masqueReseau[i] = 0xFF;
                        bitsSousReseau -= 8;
                    }
                    else if (bitsSousReseau > 0)
                    {
                        masqueReseau[i] = (byte)(0xFF << (8 - bitsSousReseau));
                        bitsSousReseau = 0;
                    }
                }
            }
            else
            {
                throw new ArgumentException("Nombre de bits de sous-réseau invalide.");
            }

            return masqueReseau;
        }




        private string ConvertirEnBinaire(string adresseIP)
        {
            string[] octetsIP = adresseIP.Split('.');
            string adresseBinaire = "";

            for (int i = 0; i < octetsIP.Length; i++)
            {
                byte octet = byte.Parse(octetsIP[i]);
                adresseBinaire += Convert.ToString(octet, 2).PadLeft(8, '0');

                if (i < octetsIP.Length - 1)
                {
                    adresseBinaire += ".";
                }
            }

            return adresseBinaire;
        }

        private string ConvertirEnHexa(string adresseIP)
        {
            string[] octetsIP = adresseIP.Split('.');
            string adresseHexa = "";

            for (int i = 0; i < octetsIP.Length; i++)
            {
                byte octet = byte.Parse(octetsIP[i]);
                adresseHexa += Convert.ToString(octet, 16).ToUpper().PadLeft(2, '0');

                if (i < octetsIP.Length - 1)
                {
                    adresseHexa += ".";
                }
            }

            return adresseHexa;
        }

        private string AfficherAdresseClasse(string adresseIP)
        {
            string[] octetsIP = adresseIP.Split('.');
            byte premierOctet = byte.Parse(octetsIP[0]);

            if ((premierOctet & 0x80) == 0)
            {
                return "Classe A";
            }
            else if ((premierOctet & 0xC0) == 0x80)
            {
                return "Classe B";
            }
            else if ((premierOctet & 0xE0) == 0xC0)
            {
                return "Classe C";
            }
            else if ((premierOctet & 0xF0) == 0xE0)
            {
                return "Classe D";
            }
            else
            {
                return "Classe E";
            }
        }

        private string CalculerAdresseReseau(string adresseIP, int bitsSousReseau)
        {
            string[] octetsIP = adresseIP.Split('.');
            byte[] adresseReseau = new byte[4];

            for (int i = 0; i < octetsIP.Length; i++)
            {
                byte octetIP = byte.Parse(octetsIP[i]);
                byte octetMasque = 0x00;

                int bitsARetirer = Math.Min(bitsSousReseau, 8);
                octetMasque = (byte)(0xFF << (8 - bitsARetirer));

                adresseReseau[i] = (byte)(octetIP & octetMasque);
                bitsSousReseau -= bitsARetirer;
            }

            return string.Join(".", adresseReseau);
        }

        private string CalculerPremiereIP(string adresseReseau)
        {
            string[] octetsReseau = adresseReseau.Split('.');
            byte[] premiereIP = new byte[4];

            for (int i = 0; i < octetsReseau.Length; i++)
            {
                byte octetReseau = byte.Parse(octetsReseau[i]);
                premiereIP[i] = octetReseau;
            }
            premiereIP[3]++;

            return string.Join(".", premiereIP);
        }

        private string CalculerDernierIP(string adresseReseau, int bitsSousReseau)
        {
            string[] octetsReseau = adresseReseau.Split('.');
            byte[] adresseReseauBytes = new byte[4];

            // Conversion des octets de l'adresse réseau en valeurs entières
            for (int i = 0; i < octetsReseau.Length; i++)
            {
                adresseReseauBytes[i] = byte.Parse(octetsReseau[i]);
            }

            // Calcul du nombre de bits d'hôte
            int bitsHote = 32 - bitsSousReseau;

            // Calcul de l'adresse de diffusion
            uint adresseReseauValeur = (uint)(adresseReseauBytes[0] << 24 | adresseReseauBytes[1] << 16 | adresseReseauBytes[2] << 8 | adresseReseauBytes[3]);
            uint adresseBroadcastValeur = adresseReseauValeur | (uint)(Math.Pow(2, bitsHote) - 1);

            // Exclusion de l'adresse réseau et de l'adresse de diffusion
            adresseBroadcastValeur -= 1;

            byte[] dernierIPBytes = new byte[4];

            dernierIPBytes[0] = (byte)((adresseBroadcastValeur & 0xFF000000) >> 24);
            dernierIPBytes[1] = (byte)((adresseBroadcastValeur & 0x00FF0000) >> 16);
            dernierIPBytes[2] = (byte)((adresseBroadcastValeur & 0x0000FF00) >> 8);
            dernierIPBytes[3] = (byte)(adresseBroadcastValeur & 0x000000FF);

            // Conversion des valeurs entières en octets sous forme de chaîne
            string[] octetsDernierIP = new string[4];
            for (int i = 0; i < dernierIPBytes.Length; i++)
            {
                octetsDernierIP[i] = dernierIPBytes[i].ToString();
            }

            return string.Join(".", octetsDernierIP);
        }



        private int CalculerNombreIP(int bitsSousReseau)
        {
            if (bitsSousReseau == 0)
            {
                return 1; // Pour un CIDR de 0, il y a une seule adresse IP possible
            }
            else
            {
                int nombreIP = (int)Math.Pow(2, 32 - bitsSousReseau);
                return nombreIP;
            }
        }

        private int CalculerNombreMachines(int bitsSousReseau)
        {
            if (bitsSousReseau == 0)
            {
                return 0; // Pour un CIDR de 0, il n'y a aucune machine possible
            }
            else if (bitsSousReseau >= 1 && bitsSousReseau <= 30)
            {
                int nombreMachines = (int)Math.Pow(2, 32 - bitsSousReseau) - 2;
                return nombreMachines;
            }
            else if (bitsSousReseau == 31)
            {
                return 2; // Pour un CIDR de 31, il y a deux machines possibles (l'adresse réseau et l'adresse de diffusion)
            }
            else if (bitsSousReseau == 32)
            {
                return 1; // Pour un CIDR de 32, il y a seulement une machine possible (l'adresse réseau)
            }
            else
            {
                throw new ArgumentException("CIDR invalide.");
            }
        }





        private string CalculerAdresseNet(string adresseReseau, int bitsSousReseau)
        {
            string[] octetsReseau = adresseReseau.Split('.');
            byte[] adresseNet = new byte[4];

            for (int i = 0; i < octetsReseau.Length; i++)
            {
                byte octetReseau = byte.Parse(octetsReseau[i]);
                adresseNet[i] = octetReseau;
            }

            return string.Join(".", adresseNet);
        }


        private string CalculerAdresseBroadcast(string adresseIP, int bitsSousReseau)
        {
            string[] octetsIP = adresseIP.Split('.');
            byte[] adresseBroadcast = new byte[4];

            // Conversion des octets de l'adresse IP en valeurs entières
            for (int i = 0; i < octetsIP.Length; i++)
            {
                adresseBroadcast[i] = byte.Parse(octetsIP[i]);
            }

            // Calcul du nombre de bits d'hôte
            int bitsHote = 32 - bitsSousReseau;

            // Calcul de l'adresse de diffusion
            uint adresseIPValeur = (uint)(adresseBroadcast[0] << 24 | adresseBroadcast[1] << 16 | adresseBroadcast[2] << 8 | adresseBroadcast[3]);
            uint adresseBroadcastValeur = adresseIPValeur | (uint)(Math.Pow(2, bitsHote) - 1);

            adresseBroadcast[0] = (byte)((adresseBroadcastValeur & 0xFF000000) >> 24);
            adresseBroadcast[1] = (byte)((adresseBroadcastValeur & 0x00FF0000) >> 16);
            adresseBroadcast[2] = (byte)((adresseBroadcastValeur & 0x0000FF00) >> 8);
            adresseBroadcast[3] = (byte)(adresseBroadcastValeur & 0x000000FF);

            // Conversion des valeurs entières en octets sous forme de chaîne
            string[] octetsBroadcast = new string[4];
            for (int i = 0; i < adresseBroadcast.Length; i++)
            {
                octetsBroadcast[i] = adresseBroadcast[i].ToString();
            }

            return string.Join(".", octetsBroadcast);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelBG.SendToBack();
        }

<<<<<<< HEAD

=======
    
>>>>>>> 772c9bcbc72cadefda4870682b36ad7ca1689b00
        private void radioButtonCIDR_CheckedChanged(object sender, EventArgs e)
        {
            textBoxBitsSousReseau.Visible = radioButtonCIDR.Checked;
            textBoxMasqueSR.Visible = !radioButtonCIDR.Checked;
        }

        private void radioButtonMasque_CheckedChanged(object sender, EventArgs e)
        {
            textBoxBitsSousReseau.Visible = !radioButtonMasque.Checked;
            textBoxMasqueSR.Visible = radioButtonMasque.Checked;
            
        }
<<<<<<< HEAD
        private void button1_Click(object sender, EventArgs e)
        {
            Aide aide = new Aide();
            aide.Show();
        }
=======

       

        
>>>>>>> 772c9bcbc72cadefda4870682b36ad7ca1689b00
    }
}
