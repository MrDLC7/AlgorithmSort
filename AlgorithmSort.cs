namespace AlgorithmSort
{
    public partial class AlgorithmSort : Form
    {
        public AlgorithmSort()
        {
            InitializeComponent();
        }

        private int size = 0;                               //  Кількість елементів масиву
        private IComparable[]? array;                       //  Основний масив елементів
        private IComparable[]? arrayTemp;                   //  Масив для сортування

        private string InfoArray = string.Empty;            //  Рядок для результату проведених дій
        private string Log = string.Empty;                  //  Рядок для виконаних дії

        #region Generate

        //  Генерація масиву випадкових чисел
        private void button_GenerateArray_Click(object sender, EventArgs e)
        {
            //  Очищення полів
            ClearAll();

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
            InfoArray = Print.InfoArray("Згенерований масив", array);
            Log += Print.InfoLog("Генерація масиву", size, generate.Time, "мк");

            //  Відображення результатів
            richTextBox_Array.Text = InfoArray;
            richTextBox_Log.Text = Log;
        }

        #endregion Generate

        #region BubbleSort

        //  Сортування бульбашкою
        private void button_BubbleSort_Click(object sender, EventArgs e)
        {
            Sort sort = new Sort();

            //  Копіювання для сортування з порівнням до початкового стану
            CopyArray(array, arrayTemp);

            //  Сотрування - випадкового масиву
            sort.Bubble(arrayTemp);
            InfoArray = Print.InfoArray("Згенерований масив", array);
            InfoArray += Print.InfoArray("Відсортований масив", arrayTemp);
            Log += Print.InfoLog("Сортування бульбашкою - Випадкового масиву", size, sort.Time, "мк");

            //  Сотрування вже - відсортованого масиву за зростанням - Зростаючого масиву
            InfoArray += Print.InfoArray("Масив - за зростанням", arrayTemp);
            sort.Bubble(arrayTemp);
            InfoArray += Print.InfoArray("Відсортований масив", arrayTemp);
            Log += Print.InfoLog("Сортування бульбашкою - Зростаючого масиву", size, sort.Time, "мк");

            //  Сотрування вже - відсортованого масиву за спаданням - Спадаючого масиву
            Array.Reverse(arrayTemp);
            InfoArray += Print.InfoArray("Масив - за спаданням", arrayTemp);
            sort.Bubble(arrayTemp);
            InfoArray += Print.InfoArray("Відсортований масив", arrayTemp);
            Log += Print.InfoLog("Сортування бульбашкою - Спадаючого масиву", size, sort.Time, "мк");

            //  Відображення результатів
            richTextBox_Array.Text = InfoArray;
            richTextBox_Log.Text = Log;
        }

        #endregion BubbleSort

        #region InsertSort

        //  Сортування вставками
        private void button_InsertSort_Click(object sender, EventArgs e)
        {
            Sort sort = new Sort();

            //  Копіювання для сортування з порівнням до початкового стану
            CopyArray(array, arrayTemp);

            //  Сотрування - випадкового масиву
            sort.Insert(arrayTemp);
            InfoArray = Print.InfoArray("Згенерований масив", array);
            InfoArray += Print.InfoArray("Відсортований масив", arrayTemp);
            Log += Print.InfoLog("Сортування вставками - Випадкового масиву", size, sort.Time, "мк");

            //  Сотрування вже - відсортованого масиву за зростанням - Зростаючого масиву
            InfoArray += Print.InfoArray("Масив - за зростанням", arrayTemp);
            sort.Insert(arrayTemp);
            InfoArray += Print.InfoArray("Відсортований масив", arrayTemp);
            Log += Print.InfoLog("Сортування вставками - Зростаючого масиву", size, sort.Time, "мк");

            //  Сотрування вже - відсортованого масиву за спаданням - Спадаючого масиву
            Array.Reverse(arrayTemp);
            InfoArray += Print.InfoArray("Масив - за спаданням", arrayTemp);
            sort.Insert(arrayTemp);
            InfoArray += Print.InfoArray("Відсортований масив", arrayTemp);
            Log += Print.InfoLog("Сортування вставками - Спадаючого масиву", size, sort.Time, "мк");

            //  Відображення результатів
            richTextBox_Array.Text = InfoArray;
            richTextBox_Log.Text = Log;
        }

        #endregion InsertSort

        #region MergeSort

        //  Сортування злиттям
        private void button_MergeSort_Click(object sender, EventArgs e)
        {
            Sort sort = new Sort();

            //  Копіювання для сортування з порівнням до початкового стану
            CopyArray(array, arrayTemp);

            //  Сотрування - випадкового масиву
            sort.Merge(arrayTemp);
            InfoArray = Print.InfoArray("Згенерований масив", array);
            InfoArray += Print.InfoArray("Відсортований масив", arrayTemp);
            Log += Print.InfoLog("Сортування злиттям - Випадкового масиву", size, sort.Time, "мк");

            //  Сотрування вже - відсортованого масиву за зростанням - Зростаючого масиву
            InfoArray += Print.InfoArray("Масив - за зростанням", arrayTemp);
            sort.Merge(arrayTemp);
            InfoArray += Print.InfoArray("Відсортований масив", arrayTemp);
            Log += Print.InfoLog("Сортування злиттям - Зростаючого масиву", size, sort.Time, "мк");

            //  Сотрування вже - відсортованого масиву за спаданням - Спадаючого масиву
            Array.Reverse(arrayTemp);
            InfoArray += Print.InfoArray("Масив - за спаданням", arrayTemp);
            sort.Merge(arrayTemp);
            InfoArray += Print.InfoArray("Відсортований масив", arrayTemp);
            Log += Print.InfoLog("Сортування злиттям - Спадаючого масиву", size, sort.Time, "мк");

            //  Відображення результатів
            richTextBox_Array.Text = InfoArray;
            richTextBox_Log.Text = Log;
        }

        #endregion MergeSort

        #region QuickSort
        //  Швидке сортування
        private void button_QuickSort_Click(object sender, EventArgs e)
        {
            Sort sort = new Sort();

            //  Копіювання для сортування з порівнням до початкового стану
            CopyArray(array, arrayTemp);

            //  Сотрування - випадкового масиву
            sort.Quick(arrayTemp);
            InfoArray = Print.InfoArray("Згенерований масив", array);
            InfoArray += Print.InfoArray("Відсортований масив", arrayTemp);
            Log += Print.InfoLog("Швидке сортування - Випадкового масиву", size, sort.Time, "мк");

            //  Сотрування вже - відсортованого масиву за зростанням - Зростаючого масиву
            InfoArray += Print.InfoArray("Масив - за зростанням", arrayTemp);
            sort.Quick(arrayTemp);
            InfoArray += Print.InfoArray("Відсортований масив", arrayTemp);
            Log += Print.InfoLog("Швидке сортування - Зростаючого масиву", size, sort.Time, "мк");

            //  Сотрування вже - відсортованого масиву за спаданням - Спадаючого масиву
            Array.Reverse(arrayTemp);
            InfoArray += Print.InfoArray("Масив - за спаданням", arrayTemp);
            sort.Quick(arrayTemp);
            InfoArray += Print.InfoArray("Відсортований масив", arrayTemp);
            Log += Print.InfoLog("Швидке сортування - Спадаючого масиву", size, sort.Time, "мк");

            //  Відображення результатів
            richTextBox_Array.Text = InfoArray;
            richTextBox_Log.Text = Log;
        }

        #endregion QuickSort

        #region OtherFunction

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
            richTextBox_Array.Text = InfoArray = "";
            panelSort.Enabled = false;
        }

        //  Очищення вікна проведених дій "Лог"
        private void button_ClearLog_Click(object sender, EventArgs e)
        {
            richTextBox_Log.Text = Log = "";
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
    
        //  Очищення полів
        private void ClearAll()
        {
            richTextBox_Array.Text =  richTextBox_Log.Text = InfoArray =  Log = "";
        }

        #endregion OtherFunction
    }
}
