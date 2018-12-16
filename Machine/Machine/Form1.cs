using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machine
{
    public partial class Form1 : Form
    {
        Worker worker = new Worker();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = worker.Stock.Details;            
            worker.Work();            
        }

        private void DrawDetail()
        {

        }

        private void MoveDetail()
        {

        }

        private void RemoveDetail()
        {

        }

    }
}
