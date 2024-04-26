using System.Diagnostics.Eventing.Reader;

namespace StudentGradeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            double eng, math, sci, fil, his, total, average;


            name = textBox1.Text;
            eng = double.Parse(textBox2.Text);
            math = double.Parse(textBox3.Text);
            sci = double.Parse(textBox4.Text);
            fil = double.Parse(textBox5.Text);
            his = double.Parse(textBox6.Text);

            total = eng + math + sci + fil + his;
            label1.Text = total.ToString();

            average = total / 5;
            label1.Text = average.ToString();

            if (average >= 75)
            {
                label1.Text = "The student passed. ";
            }
            else
            {
                label1.Text = "The student failed";
            }
            label2.Text = "The general average of " + name + " is " + average + ".";
        }

        

        }
    }
}

