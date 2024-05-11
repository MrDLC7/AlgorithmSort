namespace AlgorithmSort
{
    public partial class AlgorithmSort : Form
    {
        public AlgorithmSort()
        {
            InitializeComponent();
        }

        private int size = 0;                   //  Кількість елементів масиву
        private IComparable[]? array;           //  Основний масив елементів
        private IComparable[]? arrayTemp;       //  Масив для сортування


        //  Генерація масиву випадкових чисел
        private void button_GenerateArray_Click(object sender, EventArgs e)
        {
            //  Діапазон чисел для масиву
            int range = Convert.ToInt32(textBox_Range.Text);

            //  Розмір масиву
            size = Convert.ToInt32(textBox_SizeArray.Text);

            //  Виділення пам'яті
            array = new IComparable[size];
            arrayTemp = new IComparable[size];

            //  Створення масиву випадкових чисел
            Generate generate = new Generate(array, size, range);

            //  Увімкнути керування сортуванням
            panelSort.Enabled = true;

            //  Відобразити масив і виконані дії
            richTextBox_Array.Text = Print.InfoArray("Згенерований масив", array);
            richTextBox_Log.Text += Print.InfoLog("Генерація масиву", size, generate.Time, "мк");
        }

        //  Сортування бульбашкою
        private void button_BubbleSort_Click(object sender, EventArgs e)
        {
            Sort sort = new Sort();

            //  Копіювання для сортування з порівнням до початкового стану
            CopyArray(array, arrayTemp);

            sort.Bubble(arrayTemp);

            richTextBox_Array.Text = Print.InfoArray("Згенерований масив", array);
            richTextBox_Array.Text += Print.InfoArray("Відсортований масив", arrayTemp);

            richTextBox_Log.Text += Print.InfoLog("Сортування бульбашкою", size, sort.Time, "мк");
        }

        //  Сортування вставками
        private void button_InsertSort_Click(object sender, EventArgs e)
        {
            Sort sort = new Sort();

            //  Копіювання для сортування з порівнням до початкового стану
            CopyArray(array, arrayTemp);

            sort.Insert(arrayTemp);

            richTextBox_Array.Text = Print.InfoArray("Згенерований масив", array);
            richTextBox_Array.Text += Print.InfoArray("Відсортований масив", arrayTemp);

            richTextBox_Log.Text += Print.InfoLog("Сортування вставками", size, sort.Time, "мк");
        }

        //  Сортування злиттям
        private void button_MergeSort_Click(object sender, EventArgs e)
        {
            Sort sort = new Sort();

            //  Копіювання для сортування з порівнням до початкового стану
            CopyArray(array, arrayTemp);

            sort.Merge(arrayTemp);

            richTextBox_Array.Text = Print.InfoArray("Згенерований масив", array);
            richTextBox_Array.Text += Print.InfoArray("Відсортований масив", arrayTemp);

            richTextBox_Log.Text += Print.InfoLog("Сортування злиттям", size, sort.Time, "мк");
        }

        //  Швидке сортування
        private void button_QuickSort_Click(object sender, EventArgs e)
        {
            Sort sort = new Sort();

            //  Копіювання для сортування з порівнням до початкового стану
            CopyArray(array, arrayTemp);

            sort.Quick(arrayTemp);

            richTextBox_Array.Text = Print.InfoArray("Згенерований масив", array);
            richTextBox_Array.Text += Print.InfoArray("Відсортований масив", arrayTemp);

            richTextBox_Log.Text += Print.InfoLog("Швидке сортування", size, sort.Time, "мк");
        }

        //  Автопрокручування "Лог" в залежності від наповнення
        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            RichTextBox richTextBox = sender as RichTextBox;
            richTextBox.SelectionStart = richTextBox.Text.Length;
            richTextBox.ScrollToCaret();
        }

        //  Перевірка коректності введення кількості елементів масиву
        private void textBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int result = 0;             //  Для поточної кількості елементів
            int min = 10;               //  Мінімальна кількість елементів
            int max = 150000;           //  Максимальна кількусть елементів

            TextBox? textBox = sender as TextBox;

            if (int.TryParse(textBox.Text, out result))
            {
                if (result >= min && result <= max)
                {
                    //  Збереження правильної кількості елементів
                    size = result;
                }
                else
                {
                    textBox.Focus();
                    textBox.SelectAll();
                    MessageBox.Show("Не правильно вказано кількість елементів масиву");
                }
            }
            else
            {
                textBox.Focus();
                textBox.SelectAll();
                MessageBox.Show("Невірне значення кількості елементів масиву");
                return;
            }
        }

        //  Вибрати весь текст при натиску на поле ТекстБокс
        private void textBox_Click(object sender, EventArgs e)
        {
            TextBox? textBox = sender as TextBox;
            textBox.SelectAll();
        }

        //  Очищення вікна "Масив" і самого масиву
        private void button_ClearArray_Click(object sender, EventArgs e)
        {
            richTextBox_Array.Text = "";
            panelSort.Enabled = false;
        }

        //  Очищення вікна проведених дій "Лог"
        private void button_ClearLog_Click(object sender, EventArgs e)
        {
            richTextBox_Log.Text = "";
        }

        //  Копіювання масиву
        private void CopyArray(IComparable[]? fromArray, IComparable[]? toArray)
        {
            int i = 0;
            foreach (var item in fromArray)
            {
                toArray[i++] = item;
            }
        }
    }
}
