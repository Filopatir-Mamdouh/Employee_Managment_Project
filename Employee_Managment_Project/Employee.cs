using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Managment_Project
{
    public partial class Employee : Form
    {
        Function con;
        public Employee()
        {
            InitializeComponent();
            con = new Function();
            
        }

        

        private void Employee_Load(object sender, EventArgs e)
        {

        }
    }
}
