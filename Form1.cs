using System;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;
using Biblioteka;

namespace Client
{
    public partial class Form1 : Form
    {
        public ModelInfo Model { get; set; }
        public Form1()
        {
            InitializeComponent();
            textIP.Text = "127.2.3.9";
            textPort.Text = "8888";
            

        }

        private void TextBoxIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PrzyciskWybierzPlik_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    var fileStream = openFileDialog.OpenFile();

                    ModelInfo model = new ModelInfo();
                    model.FileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                    model.Extension = Path.GetExtension(openFileDialog.FileName);

                    using (var memoryStream = new MemoryStream())
                    {
                        fileStream.CopyTo(memoryStream);
                        model.Data = memoryStream.ToArray();
                    }

                    Model = model;

                    NazwaPliku.Text = openFileDialog.SafeFileName;
                }
            }
        }

        private void PrzyciskWyślijPlik(object sender, EventArgs e)
        {
            
            try
            {
                if (Model == null)
                {
                    MessageBox.Show("Brak wybranego pliku do wysłania.",
                        "Error", MessageBoxButtons.OK);
 
                    return;
                }

                var handleServer = new HandleServer(textIP.Text, Convert.ToInt32(textPort.Text), Model);
                handleServer.Start();
   
            }
            catch (SocketException)
            {
                MessageBox.Show("Nie można połączyć się z serwerem " + textIP.Text + ":" + textPort.Text + "!",
                    "Błąd",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
