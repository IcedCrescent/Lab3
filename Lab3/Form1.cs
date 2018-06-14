using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private string _conStr = "Data Source=localhost;Initial Catalog=\"PRN292 Lab3\";Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            ADO.BindDataToGridView(dataGridViewBook, "SELECT * FROM [tbl_Book]");
            ADO.BindDataToGridView(dataGridViewCopy, "SELECT * FROM [tbl_Copy]");
        }

        void LoadData()
        {
            //SqlConnection con = new SqlConnection(_conStr);
            //SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Register", con);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //dataGridViewMember.DataSource = dt;

            //textBoxMemberCode.DataBindings.Clear();
            //textBoxNameMember.DataBindings.Clear();
            //textBoxSexMember.DataBindings.Clear();
            //textBoxAddressMember.DataBindings.Clear();
            //textBoxTelMember.DataBindings.Clear();
            //textBoxEmailMember.DataBindings.Clear();
            //textBoxMemberCode.DataBindings.Add("Text", dataGridViewMember.DataSource, "Member");

        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature not available because of insufficent requirements", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature not available because of insufficent requirements", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature not available because of insufficent requirements", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature not available because of insufficent requirements", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAddCopy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature not available because of insufficent requirements", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEditCopy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature not available because of insufficent requirements", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDeleteCopy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature not available because of insufficent requirements", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            int selectedTabIndex = e.TabPageIndex;
            switch (selectedTabIndex)
            {
                case 0:
                    ADO.BindDataToGridView(dataGridViewBook, "SELECT * FROM [tbl_Book]");
                    ADO.BindDataToGridView(dataGridViewCopy, "SELECT * FROM [tbl_Copy]");
                    break;
                case 1:
                    ADO.BindDataToGridView(dataGridViewMember, "SELECT * FROM tbl_Member");
                    break;
                case 2:
                    break;
                case 3:

                    break;
                case 4:
                    ADO.BindDataToGridView(dataGridViewReserved, "select * from [tbl_ReserveCopy]");
                    break;
            }
        }

        private void dataGridViewBook_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridViewBook.CurrentRow.Index;
            if (i >= 0)
            {
                string bookNum = dataGridViewBook.Rows[i].Cells[0].Value.ToString();
                string bookTitle = dataGridViewBook.Rows[i].Cells[1].Value.ToString();
                string bookAuthor = dataGridViewBook.Rows[i].Cells[2].Value.ToString();
                string bookPublisher = dataGridViewBook.Rows[i].Cells[3].Value.ToString();
                textBoxBookNumBook.Text = bookNum;
                textBoxTitleBook.Text = bookTitle;
                textBoxAuthorBook.Text = bookAuthor;
                textBoxPublisherBook.Text = bookPublisher;
            }
        }

        private void dataGridViewCopy_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridViewCopy.CurrentRow.Index;
            if (i >= 0)
            {
                textBoxBookNumCopy.Text = dataGridViewCopy.Rows[i].Cells[1].Value.ToString();
                textBoxCopyNumCopy.Text = dataGridViewCopy.Rows[i].Cells[2].Value.ToString();
                textBoxSequenceCopy.Text = dataGridViewCopy.Rows[i].Cells[3].Value.ToString();
                textBoxTypeCopy.Text = dataGridViewCopy.Rows[i].Cells[4].Value.ToString();
                textBoxPriceCopy.Text = dataGridViewCopy.Rows[i].Cells[5].Value.ToString();
            }
        }
    }
}
