using Friday13th.Logic;

namespace Friday13th.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private readonly Friday13Service _service = new Friday13Service();
        private List<DateTime> _thirteenths = new();

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ShowDates_Click(object sender, EventArgs e)
        {
            _thirteenths = _service.Get13List(5);
            listBox1.DataSource = _thirteenths;

        }

        private void Friday_Only_Click(object sender, EventArgs e)
        {
            var fridays = _service.GetFriday13(_thirteenths);

            listBox1.DataSource = null;          
            listBox1.DataSource = fridays;

        }
    }
}
