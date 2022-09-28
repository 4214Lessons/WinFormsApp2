namespace Source;

public partial class Form2 : Form
{
    public Form2()
    {
        InitializeComponent();
    }

    private void btn_print_Click(object sender, EventArgs e)
    {
        foreach (Control control in gBox_Colors.Controls)
        {
            if(control is CheckBox chk && chk.Checked)
            {
                MessageBox.Show(chk.Text);
            }
        }
    }

    private void checkBox_CheckedChanged(object sender, EventArgs e)
    {
        // var chk = sender as CheckBox;
        // MessageBox.Show($"{chk?.Text}  {chk?.Checked}");
    }

    private void button1_Click(object sender, EventArgs e)
    {
        //  MessageBox.Show(dateTimePicker1.Value.ToString());

        // MessageBox.Show(monthCalendar1.SelectionStart.ToString());
        // MessageBox.Show(monthCalendar1.SelectionEnd.ToString());

    }
}
