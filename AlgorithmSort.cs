namespace AlgorithmSort
{
    public partial class AlgorithmSort : Form
    {
        public AlgorithmSort()
        {
            InitializeComponent();
        }

        private int size = 0;           //  Кількість елементів масиву
        private object[]? array;


        //  Генерація масиву випадкових чисел
        private void button_GenerateArray_Click(object sender, EventArgs e)
        {
            size = Convert.ToInt32(textBox_SizeArray.Text);
            array = new object[size];

            Generate generate = new Generate(array, size, 1000);

            panelSort.Enabled = true;

            richTextBox_Array.Text = Print.InfoArray(array);
            richTextBox_Log.Text += Print.InfoLog("Генерація масиву", size, generate.Time, "мк");
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
                    textBox_SizeArray.Focus();
                    textBox_SizeArray.SelectAll();
                    MessageBox.Show("Не правильно вказано кількість елементів масиву");
                }
            }
            else
            {
                textBox_SizeArray.Focus();
                textBox_SizeArray.SelectAll();
                MessageBox.Show("Невірне значення кількості елементів масиву");
                return;
            }
        }

        //  Вибрати весь текст при натиску на поле ТекстБокс
        private void textBox_SizeArray_Click(object sender, EventArgs e)
        {
            textBox_SizeArray.SelectAll();
        }

        private void button_ClearArray_Click(object sender, EventArgs e)
        {
            richTextBox_Array.Text = "";
            panelSort.Enabled = false;
        }

        private void button_ClearLog_Click(object sender, EventArgs e)
        {
            richTextBox_Log.Text = "";
        }

        private void button_BubbleSort_Click(object sender, EventArgs e)
        {
            Sort sort = new Sort();

            sort.Bubble(ConvertTo<int>(array));

            richTextBox_Array.Text += Print.InfoArray(array);

            richTextBox_Log.Text += Print.InfoLog("Сортування бульбашкою", size, sort.Time, "мк");
        }

        private void button_InsertSort_Click(object sender, EventArgs e)
        {
            Sort sort = new Sort();

            sort.Insert(ConvertTo<int>(array));

            richTextBox_Array.Text += Print.InfoArray(array);

            richTextBox_Log.Text += Print.InfoLog("Сортування вставками", size, sort.Time, "мк");
        }

        private void button_MergeSort_Click(object sender, EventArgs e)
        {
            Sort sort = new Sort();

            sort.Merge(ConvertTo<int>(array));

            richTextBox_Array.Text += Print.InfoArray(array);

            richTextBox_Log.Text += Print.InfoLog("Сортування злиттям", size, sort.Time, "мк");
        }

        private void button_QuickSort_Click(object sender, EventArgs e)
        {
            Sort sort = new Sort();

            sort.Quick(ConvertTo<int>(array));

            richTextBox_Array.Text += Print.InfoArray(array);

            richTextBox_Log.Text += Print.InfoLog("Швидке сортування", size, sort.Time, "мк");
        }

        private T[] ConvertTo<T>(object[]? array)
        {
            T[] result = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = (T)array[i];
            }
            return result;
        }
    }
}
