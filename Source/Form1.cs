using Source.Properties;

namespace Source
{
    public partial class Form1 : Form
    {
        private readonly User _user = new User("Tural", "tural123");


        public Form1()
        {
            InitializeComponent();

            Image image = Resources.Flag_map_of_Azerbaijan;

            PictureBox picture = new()
            {
                BackgroundImage = image,
                Size = new Size(Width, Height - 40),
                BackgroundImageLayout = ImageLayout.Zoom,
            };

            // Controls.Add(picture);
            // Controls.Remove(picture);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // label1.SendToBack();
            // label2.BringToFront();
            // 
            // Controls.SetChildIndex(label1, 1);
            // Controls.SetChildIndex(label2, 2);
        }





        private void button1_Click(object sender, EventArgs e)
        {
            // // MessageBox.Show(textBox1.Text);
            // MessageBox.Show(textBox1.SelectionLength.ToString());
            // 
            // textBox1.Select(1, 2);
            // textBox1.DeselectAll();
            // 
            // 
            // MessageBox.Show(textBox1.SelectedText);
            // // MessageBox.Show();
            

            if(_user.UserName == textBox1.Text && _user.Password == textBox2.Text)
                MessageBox.Show("Welcome");
            else
                lbl_error.Text = "Error message";
        }

        private void button_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;


            switch(btn?.Text)
            {
                case "Copy":
                    richTextBox1.Copy();
                    break;
                case "Cut":
                    richTextBox1.Cut();
                    break;
                case "Paste":
                    richTextBox1.Paste();
                    break;
            }
        }
    }
}