using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopingLabTask1
{
    public partial class Form1 : Form
    {
        string[] names = new[] { "John", "Han", "Lee" };
        string[] emails = new[] { "john@hotmail.com", "han123@yahoo.com", "lee222@gmail.com" };


        public Form1()
        {
            InitializeComponent();
              	for (int index = 0; index <= names.GetUpperBound(0); index++)
            	{
             	cboNames.Items.Add(names[index]);
       }
       	cboNames.SelectedIndex = 2;
       }

        

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Array.Resize(ref names, names.Length + 1);
            Array.Resize(ref emails, emails.Length + 1);

            //add the new name into array names eg: names [4-1]→ names [3] names[names.Length-1]=txtName.Text;
            names[names.Length - 1] = txtName.Text;
            emails[emails.Length - 1] = txtEmail.Text;

            //add element into combo box cboName.Items.Add(names[names.Length - 1]);

            cboNames.Items.Add(names[names.Length - 1]);

            //clear textboxes
            txtName.Clear();
            txtEmail.Clear();

        }

        private void cboNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEmail.Text = emails[cboNames.SelectedIndex];
        }
    }
}
