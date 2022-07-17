using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace InputCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Demobtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "|*.csv";//為開啟檔案格式篩選 (  格式敘述| 篩選格式  ) 

            if (ofd.ShowDialog() == DialogResult.OK) //DialogResult 為 跳出確認框 .OK為確認value 
            {
                textBox.Text = ofd.FileName;
            }
            using (FileStream fs = new FileStream(textBox.Text, FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                string content = sr.ReadToEnd();
                readbox.Text = content;
            }
        }

    }
}