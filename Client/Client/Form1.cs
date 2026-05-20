using System;
using System.IO;
using System.Net.Sockets;
using System.IO.Compression;
using System.Windows.Forms;

namespace Client
{

    public partial class Form1 : Form
    {
        string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                lblStatus.Text = "Selected: " + filePath;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient("127.0.0.1", 5000);
            NetworkStream stream = client.GetStream();

            byte[] fileData = File.ReadAllBytes(filePath);

            byte[] size = BitConverter.GetBytes(fileData.Length);
            stream.Write(size, 0, 4);

            stream.Write(fileData, 0, fileData.Length);

            byte[] compSize = new byte[4];
            stream.Read(compSize, 0, 4);
            int sizeComp = BitConverter.ToInt32(compSize, 0);

            byte[] compData = new byte[sizeComp];
            int read = 0;

            while (read < sizeComp)
            {
                read += stream.Read(compData, read, sizeComp - read);
            }

            string originalName = Path.GetFileName(filePath);

            string savePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                originalName + ".gz"
            );

            File.WriteAllBytes(savePath, compData);

            MessageBox.Show("Compressed file saved!");

            lblStatus.Text = "Done! File received";
            client.Close();
        }
    }
}
