namespace GrafischeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = ReadTextboxA();
            int b = ReadTextboxB();
            int result = a + b;
            WriteToAnswer(result);
        }
        int ReadTextboxA()
        {
            string sA = txtA.Text;
            int.TryParse(sA, out int a);
            return a;
        }
        int ReadTextboxB()
        {
            string sB = txtB.Text;
            int.TryParse (sB, out int b);
            return b;
        }
        void WriteToAnswer(int result)
        {
            lblAnswer.Text = result.ToString();
        }
    }
}
