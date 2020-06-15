using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKACIKChapterTen
    //LOUIE TKACIK 0290446 C# 2 CHAPTER 10 PROBLEMS 1-3
    //CLASSES: EMPLOYEE, PRODUCTION WORKER, SHIFT SUPERVISOR, AND TEAM LEADER
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void employeeButt_Click(object sender, EventArgs e)
        {
            Employee emp;
            string n; int num;
            if (nameInput.Text != "") //name must be entered
            {
                if(int.TryParse(numberInput.Text, out num))
                {
                    n = nameInput.Text;
                    emp = new Employee(n, num);
                    employeeOutput.Text = emp.displayData();
                }
                else
                {
                    MessageBox.Show("Enter a valid integer for the employee number.");
                }
            }
            else
            {
                MessageBox.Show("Enter a name for the employee");
            }
        }

        private void productionButton_Click(object sender, EventArgs e)
        {
            ProductionWorker emp;
            string n; int num, shiftnum; double pr;
            if (prodNameText.Text!="")//check for name
            {
                if(int.TryParse(prodNumText.Text, out num) && int.TryParse(prodShiftNumberText.Text, out shiftnum) && double.TryParse(prodPayRateText.Text, out pr))
                {
                    n = prodNameText.Text;
                    emp = new ProductionWorker(n, num, shiftnum, pr);
                    productionLabel.Text = emp.displayData();
                }
                else
                {
                    MessageBox.Show("Please enter valid numerical data.");
                }
            }
            else
            {
                MessageBox.Show("Please Enter name.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
