namespace AlgorithmSort
{
    public partial class AlgorithmSort : Form
    {
        public AlgorithmSort()
        {
            InitializeComponent();
        }
        int size = 0;

        //  Автопрокручування "Лог" в залежності від наповнення
        private void richTextBox_Log_TextChanged(object sender, EventArgs e)
        {
            richTextBox_Log.SelectionStart = richTextBox_Log.Text.Length;
            richTextBox_Log.ScrollToCaret();
        }

        //  Перевірка коректності введення кількості елементів масиву
        private void textBox_SizeArray_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int result = 0;             //  Для поточної кількості елементів
            int min = 10;               //  Мінімальна кількість елементів
            int max = 150000;           //  Максимальна кількусть елементів

            if (int.TryParse(textBox_SizeArray.Text, out result))
            {
            }
            else
            {
                MessageBox.Show("Не правильно вказано кількість елементів масиву");
                return;
            }

            if (result >= min && result <= max)
            {
                //  Збереження правильної кількості елементів
                size = result;
            }
            else
            {
                MessageBox.Show("Не правильно вказано кількість елементів масиву");
            }
        }

        //  Вибрати весь текст при натиску на поле ТекстБокс
        private void textBox_SizeArray_Click(object sender, EventArgs e)
        {
            textBox_SizeArray.SelectAll();
        }
    }
}
