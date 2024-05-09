namespace AlgorithmSort
{
    public partial class AlgorithmSort : Form
    {
        public AlgorithmSort()
        {
            InitializeComponent();
        }

        private int size = 0;           //  Кількість елементів масиву
        private object[] array;


        //  Генерація масиву випадкових чисел
        private void button_GenerateArray_Click(object sender, EventArgs e)
        {
            size = Convert.ToInt32(textBox_SizeArray.Text);
            array = new object[size];

            Generate generate = new Generate(array, size, 10000);

        }






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
            else
            {
                MessageBox.Show("Невірне значення кількості елементів масиву");
                return;
            }
        }

        //  Вибрати весь текст при натиску на поле ТекстБокс
        private void textBox_SizeArray_Click(object sender, EventArgs e)
        {
            textBox_SizeArray.SelectAll();
        }


    }
}
