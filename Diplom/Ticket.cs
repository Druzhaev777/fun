using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "funDataSet.Game". При необходимости она может быть перемещена или удалена.
            this.gameTableAdapter.Fill(this.funDataSet.Game);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            Table tableForm = new Table();
            tableForm.Show();
        }

        private void ReadyT_Click(object sender, EventArgs e)
        {

        }
    }
}
