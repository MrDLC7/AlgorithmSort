namespace AlgorithmSort
{
    public partial class AlgorithmSort : Form
    {
        public AlgorithmSort()
        {
            InitializeComponent();
        }

        //  Вибрати весь текст при натиску на поле ТекстБокс
        private void textBox_SellectAll_Click(object sender, EventArgs e)
        {
            TextBox? clickedTextBox = sender as TextBox;
            if (clickedTextBox != null)
            {
                clickedTextBox.SelectAll();
            }
        }

        //  Автопрокручування "Лог" в залежності від наповнення
        private void richTextBox_Log_TextChanged(object sender, EventArgs e)
        {
            richTextBox_Log.SelectionStart = richTextBox_Log.Text.Length;
            richTextBox_Log.ScrollToCaret();
        }
    }
}
