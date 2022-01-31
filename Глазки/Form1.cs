using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Глазки.Model;


namespace Глазки
{
    public partial class Form1 : Form
    {
        Model1 db = new Model1();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            agentBindingSource.DataSource = db.Agent.ToList();
        }
        private void agentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
