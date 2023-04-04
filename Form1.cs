namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private int buttonCount = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //function to create a lot of buttons
            Button button1 = new Button();
            button1.Text = "Button " + buttonCount;
            button1.Location = new Point(25, 40+(buttonCount -1)*40);
            this.Controls.Add(button1);
            buttonCount++;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button Button2 = new Button();
            Button2.Text = "Button " + buttonCount;
            Button2.Location = new Point(25, 40 + (buttonCount - 1) * 40);
            this.Controls.Add(Button2);
            buttonCount++;

        }
    }
}