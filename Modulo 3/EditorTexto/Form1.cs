using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorTexto
{
    public partial class Form1 : Form
    {
        Stream textaoStream;
        string file = "textao.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(file))
            {
                using (textaoStream = File.Open(file, FileMode.Open))
                using (StreamReader streamReader = new StreamReader(textaoStream))
                {
                    string content = streamReader.ReadToEnd();
                    txtTextao.Text = content;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (textaoStream = File.Open(file, FileMode.Create))
            using (StreamWriter streamWriter = new StreamWriter(textaoStream))
            {
                streamWriter.Write(txtTextao.Text);
            }
        }
    }
}
