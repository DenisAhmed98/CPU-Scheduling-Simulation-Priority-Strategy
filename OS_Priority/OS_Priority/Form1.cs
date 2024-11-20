using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_Priority
{
    public partial class OS_Priority : Form
    {
        int processcounter = 0;
        public OS_Priority()
        {
            InitializeComponent();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            processcounter++;
            int PTB = int.Parse(PriorityTB.Text);
            this.dataGridView1.Rows.Add(processcounter, PTB, "wait");
        }

        private void DispatchBtn_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["Priority"], ListSortDirection.Descending);


        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            DispatchBtn_Click(sender, e);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (this.dataGridView1.Rows[i].Cells[2].Value == "wait")
                {
                    this.dataGridView1.Rows[i].Cells[2].Value = "Finished";
                    break;
                }
            }
        }
    }
}
