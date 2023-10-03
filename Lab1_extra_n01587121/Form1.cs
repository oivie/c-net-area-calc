using static System.Windows.Forms.MonthCalendar;

namespace Lab1_extra_n01587121
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // double click and get enter
            this.AcceptButton = btnCalculate;

            //click esc to exit
            this.CancelButton = btnExit;
        }


        //btn logic for calculate button on click
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Those two lines of code are converting the text values  into decimal data types
                decimal length = Convert.ToDecimal(txtLength.Text);
                decimal width = Convert.ToDecimal(txtWidth.Text);

                // Calculate area and perimeter
                decimal area = length * width;
                decimal perimeter = 2 * length + 2 * width;

                // Display the results
                txtArea.Text = area.ToString("n2");  // Formats the result to two decimal places
                txtPerimeter.Text = perimeter.ToString("n2");  // Formats the result to two decimal places

                // Move the focus to the Length text box
                txtLength.Focus();
            }
            catch (Exception ex) // Catch any unexpected errors
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        //btn logic for exit button on click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}