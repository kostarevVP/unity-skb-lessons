using System;

namespace Homework_theme_05
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Домашнее задание
            // Требуется написать несколько методов
            //
            // Задание 1.
            // Воспользовавшись решением задания 3 четвертого модуля
            // 1.1. Создать метод, принимающий число и матрицу, возвращающий матрицу умноженную на число

            //MatrixMultiplicationByNumberOperate();

            // 1.2. Создать метод, принимающий две матрицы, возвращающий их сумму

            //MatrixAdditionOperate();

            // 1.3. Создать метод, принимающий две матрицы, возвращающий их произведение

            //MatrixMultiplicationOperate();

            // Задание 2.
            // 1. Создать метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв

            //MinWordFinderOperate();

            // 2.* Создать метод, принимающий  текст и возвращающий слово(слова) с максимальным количеством букв

            //MaxWordsFinderOperate();

            // Примечание: слова в тексте могут быть разделены символами (пробелом, точкой, запятой) 
            // Пример: Текст: "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ"
            // 1. Ответ: А
            // 2. ГГГГ, ДДДД
            //
            // Задание 3. Создать метод, принимающий текст. 
            // Результатом работы метода должен быть новый текст, в котором
            // удалены все кратные рядом стоящие символы, оставив по одному 
            // Пример: ПППОООГГГООООДДДААА >>> ПОГОДА
            // Пример: Ххххоооорррооошшшиий деееннннь >>> хороший день

            //RemoveRepeatedLettersOperate();

            // Задание 4. Написать метод принимающий некоторое количесво чисел, выяснить
            // является заданная последовательность элементами арифметической или геометрической прогрессии
            // 
            // Примечание
            //             http://ru.wikipedia.org/wiki/Арифметическая_прогрессия
            //             http://ru.wikipedia.org/wiki/Геометрическая_прогрессия
            //

            //CheckProgressionTypeOperate();

            // *Задание 5
            // Вычислить, используя рекурсию, функцию Аккермана:
            // A(2, 5), A(1, 2)
            // A(n, m) = m + 1, если n = 0,
            //         = A(n - 1, 1), если n <> 0, m = 0,
            //         = A(n - 1, A(n, m - 1)), если n> 0, m > 0.
            // 

            //AckermannCountOperate();

            // Весь код должен быть откоммментирован
            #endregion

            Console.ReadKey();
        }

        /// <summary>
        /// Функция вывода умножения матрицы на число
        /// </summary>
        static void MatrixMultiplicationByNumberOperate()
        {
            Console.WriteLine("Введите число строк матрицы от 1 до 1000000:");
            int n = EnterValidNumber();

            Console.WriteLine("\nВведите число столбцов матрицы от 1 до 1000000:");
            int m = EnterValidNumber();

            Console.WriteLine("\nВведите число, на которое будет производиться умножение, значением от -1000000 до 1000000:");
            bool check = false;
            int number = 1;
            while (!check)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if ((n < -1000000) || (n > 1000000))
                {
                    Console.WriteLine("Неверный ввод числа, повторите!");
                }
                else
                {
                    check = true;
                }
            }

            Random rand = new Random();
            int[,] matrix = new int[n, m];

            // генерация данных матрицы
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rand.Next(-9, 10);
                }
            }

            int[,] newMatrix = MatrixMultiplicationByNumber(matrix, number, n, m);

            Console.WriteLine("\nРезультат вычислений:");
            // вывод примера в консоль
            for (int i = 0; i < n; i++)
            {
                if (i == (n - 1) / 2)
                {
                    Console.Write($"{number,9} х |");
                }
                else
                {
                    Console.Write("{0,13}", "|");
                }

                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matrix[i, j],3}");
                }

                Console.Write("  |");

                if (i == (n - 1) / 2)
                {
                    Console.Write(" = |");
                }
                else
                {
                    Console.Write("{0,4}", "|");
                }

                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{newMatrix[i, j],9}");
                }

                Console.Write("  |");

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Функция ввода числа в указанном диапазоне
        /// </summary>
        /// <returns>Введенное из консоли число</returns>
        static int EnterValidNumber()
        {
            bool check = false;
            int n = 1;
            while (!check)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if ((n < 1) || (n > 1000000))
                {
                    Console.WriteLine("Неверный ввод числа, повторите!");
                }
                else
                {
                    check = true;
                }
            }

            return n;
        }

        /// <summary>
        /// Функция, умножающая матрицу на число
        /// </summary>
        /// <param name="matrix">Исходная матрица</param>
        /// <param name="number">Множитель</param>
        /// <param name="n">Число строк матрицы</param>
        /// <param name="m">Число столбцов матрицы</param>
        /// <returns>Произведение матрицы на число</returns>
        static int[,] MatrixMultiplicationByNumber(int[,] matrix, int number, int n, int m)
        {
            int[,] newMatrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    newMatrix[i, j] = matrix[i, j] * number;
                }
            }

            return newMatrix;
        }

        /// <summary>
        /// Функция вывода результата сложения двух матриц
        /// </summary>
        static void MatrixAdditionOperate()
        {
            Console.WriteLine("Введите число строк матрицы от 1 до 1000000:");
            int n = EnterValidNumber();

            Console.WriteLine("\nВведите число столбцов матрицы от 1 до 1000000:");
            int m = EnterValidNumber();

            Random rand = new Random();
            int[,] firstMatrix = new int[n, m];
            int[,] secondMatrix = new int[n, m];

            // генерация данных матриц
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    firstMatrix[i, j] = rand.Next(-1000, 1001);
                    secondMatrix[i, j] = rand.Next(-1000, 1001);
                }
            }

            int[,] newMatrix = MatrixAddition(firstMatrix, secondMatrix, n, m);

            Console.WriteLine("\nРезультат вычислений:");
            // вывод примера в консоль
            for (int i = 0; i < n; i++)
            {
                Console.Write("  |");

                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{firstMatrix[i, j],5}");
                }

                Console.Write("  |");

                if (i == (n - 1) / 2)
                {
                    Console.Write(" + |");
                }
                else
                {
                    Console.Write("{0,4}", "|");
                }

                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{secondMatrix[i, j],5}");
                }

                Console.Write("  |");

                if (i == (n - 1) / 2)
                {
                    Console.Write(" = |");
                }
                else
                {
                    Console.Write("{0,4}", "|");
                }

                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{newMatrix[i, j],5}");
                }

                Console.Write("  |");

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Функция сложения матриц
        /// </summary>
        /// <param name="firstMatrix">Первая слагаемая матрица</param>
        /// <param name="secondMatrix">Вторая слагаемая матрица</param>
        /// <param name="n">Число строк матрицы</param>
        /// <param name="m">Число столбцов матрицы</param>
        /// <returns>Результат сложения</returns>
        static int[,] MatrixAddition(int[,] firstMatrix, int[,] secondMatrix, int n, int m)
        {
            int[,] newMatrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    newMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                }
            }

            return newMatrix;
        }

        /// <summary>
        /// Функция вывода результата перемножения двух матриц
        /// </summary>
        static void MatrixMultiplicationOperate()
        {
            Console.WriteLine("Введите число строк первой матрицы от 1 до 1000000:");
            int n = EnterValidNumber();

            Console.WriteLine("\nВведите число столбцов первой матрицы от 1 до 1000000, оно же число строк второй матрицы:");
            int m = EnterValidNumber();

            Console.WriteLine("\nВведите число столбцов второй матрицы от 1 до 1000000:");
            int k = EnterValidNumber();

            Random rand = new Random();
            int[,] firstMatrix = new int[n, m];
            int[,] secondMatrix = new int[m, k];

            // генерация данных матриц
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    firstMatrix[i, j] = rand.Next(-9, 10);
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    secondMatrix[i, j] = rand.Next(-9, 10);
                }
            }

            // подсчет значений финальной матрицы
            int[,] newMatrix = MatrixMultiplication(firstMatrix, secondMatrix, n, m, k);

            Console.WriteLine("\nРезультат вычислений:");

            int line = (n > m) ? n : m; // количество строк вывода
            int column = m + k * 2 + 8; // количество столбцов вывода
            string[,] outputMatrix = new string[line, column]; // общая матрица вывода

            // инициализация матрицы вывода
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    outputMatrix[i, j] = "";
                }
            }

            // заполнение матрицы вывода данными из первой и финальной матриц
            for (int i = 0; i < n; i++)
            {
                outputMatrix[i, 0] = "|";
                outputMatrix[i, m + 1] = "|";
                outputMatrix[i, m + k + 6] = "|";
                outputMatrix[i, column - 1] = "|";

                for (int j = 0; j < m; j++)
                {
                    outputMatrix[i, j + 1] = firstMatrix[i, j].ToString();
                }

                for (int j = 0; j < k; j++)
                {
                    outputMatrix[i, j + (m + k + 7)] = newMatrix[i, j].ToString();
                }
            }

            // заполнение матрицы вывода данными из второй матрицы
            for (int i = 0; i < m; i++)
            {
                outputMatrix[i, m + 3] = "|";
                outputMatrix[i, m + k + 4] = "|";
                for (int j = 0; j < k; j++)
                {
                    outputMatrix[i, j + m + 4] = secondMatrix[i, j].ToString();
                }
            }

            outputMatrix[0, m + 2] = "х";
            outputMatrix[0, m + k + 5] = "=";

            // вывод данных на экран
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write("{0,5}", outputMatrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Функция подсчета произведения матриц
        /// </summary>
        /// <param name="firstMatrix">Первая матрица</param>
        /// <param name="secondMatrix">Вторая матрица</param>
        /// <param name="n">Число строк первой матрицы</param>
        /// <param name="m">Число столбцов первой матрицы</param>
        /// <param name="k">Число столбцов второй матрицы</param>
        /// <returns>Результат произведения матриц</returns>
        static int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix, int n, int m, int k)
        {
            int[,] newMatrix = new int[n, k];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    newMatrix[i, j] = 0;
                    for (int l = 0; l < m; l++)
                    {
                        newMatrix[i, j] += firstMatrix[i, l] * secondMatrix[l, j];
                    }

                }
            }

            return newMatrix;
        }

        /// <summary>
        /// Функция, обрабатывающая ввод текста и вывод результата для поиска минимального слова
        /// </summary>
        static void MinWordFinderOperate()
        {
            Console.WriteLine("Введите текст:");

            string text = Console.ReadLine();

            string findWord = MinWordFinder(text);

            Console.WriteLine($"\nМинимальное слово в тексте: {findWord}");
        }

        /// <summary>
        /// Функция для нахождения минимального слова в тексте
        /// </summary>
        /// <param name="text">Исходный текст</param>
        /// <returns>Минимальное слово</returns>
        static string MinWordFinder(string text)
        {
            string minWord = text;
            string word = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (((text[i] >= 'а') && (text[i] <= 'я')) || ((text[i] >= 'А') && (text[i] <= 'Я')) ||
                    ((text[i] >= 'a') && (text[i] <= 'z')) || ((text[i] >= 'A') && (text[i] <= 'Z')) ||
                    ((text[i] >= '0') && (text[i] <= '9')))
                {
                    word += text[i];
                    if (i == text.Length - 1)
                    {
                        if ((minWord.Length > word.Length) && (word.Length > 0))
                        {
                            minWord = word;
                        }
                    }
                } else
                {
                    //Console.WriteLine(i + " " + word);
                    if ((minWord.Length > word.Length) && (word.Length > 0))
                    {
                        minWord = word;
                    }

                    word = "";
                }
            }

            return minWord;
        }

        /// <summary>
        /// Функция, обрабатывающая ввод текста и вывод результата для поиска максимальных слов
        /// </summary>
        static void MaxWordsFinderOperate()
        {
            Console.WriteLine("Введите текст:");

            string text = Console.ReadLine();

            string[] findWords = MaxWordsFinder(text);

            Console.WriteLine($"\nМаксимальные слова в тексте:");
            Console.Write($"{findWords[0]}");
            for (int i = 1; i < findWords.Length; i++)
            {
                if (findWords[i] == "") break;
                Console.Write($", {findWords[i]}");
            }
        }

        /// <summary>
        /// Функция для нахождения максимальных слов в тексте
        /// </summary>
        /// <param name="text">Исходный текст</param>
        /// <returns>Список максимальных слов</returns>
        static string[] MaxWordsFinder(string text)
        {
            string[] words = new string[text.Length / 2 + 1];
            string word = "";
            int wordsCount = 0;
            int maxWordLength = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (((text[i] >= 'а') && (text[i] <= 'я')) || ((text[i] >= 'А') && (text[i] <= 'Я')) ||
                    ((text[i] >= 'a') && (text[i] <= 'z')) || ((text[i] >= 'A') && (text[i] <= 'Z')) ||
                    ((text[i] >= '0') && (text[i] <= '9')))
                {
                    word += text[i];
                    if (i == text.Length - 1)
                    {
                        if (word.Length > maxWordLength)
                        {
                            wordsCount = 0;
                            Array.Clear(words, 0, words.Length);
                            words[wordsCount] = word;
                        }
                        else if (word.Length == maxWordLength)
                        {
                            wordsCount++;
                            words[wordsCount] = word;
                        }
                    }
                }
                else
                {
                    if (word.Length > maxWordLength)
                    {
                        maxWordLength = word.Length;
                        wordsCount = 0;
                        Array.Clear(words, 0, words.Length);
                        words[wordsCount] = word;
                    } else if ((word.Length == maxWordLength) && (word.Length > 0))
                        {
                        wordsCount++;
                        words[wordsCount] = word;
                    }
                    //wordsCount++;
                    word = "";
                }
            }

            string[] maxWords = new string[wordsCount + 1];

            Array.Copy(words, maxWords, wordsCount + 1);
            //Console.WriteLine(wordsCount);
            return maxWords;
        }

        /// <summary>
        /// Функция, обрабатывающая ввод текста и вывод результата для удаления кратных рядом стоящих символов в тексте
        /// </summary>
        static void RemoveRepeatedLettersOperate()
        {
            Console.WriteLine("Введите текст:");

            string text = Console.ReadLine();

            string newText = RemoveRepeatedLetters(text);

            Console.WriteLine("Новый текст:");
            Console.WriteLine(newText);
        }

        /// <summary>
        /// Функция для удаления кратных рядом стоящих символов в тексте
        /// </summary>
        /// <param name="text">Исходный текст</param>
        /// <returns>Измененный текст</returns>
        static string RemoveRepeatedLetters(string text)
        {
            string newText = "";
            newText += text[0];
            string lowerText = text.ToLower();

            for (int i = 1; i < text.Length; i++)
            {
                if (lowerText[i] != lowerText[i - 1]) newText += text[i];
            }

            return newText;
        }

        /// <summary>
        /// Функция, обрабатывающая ввод текста и вывод результата для определения типа прогрессии
        /// </summary>
        static void CheckProgressionTypeOperate()
        {
            Console.WriteLine("Введите последовательность чисел через пробел (можно также вводить десятичные с , и отрицательные):");

            string numbers = Console.ReadLine();

            int checkProgressionType = CheckProgressionType(numbers);

            if (checkProgressionType == 1)
            {
                Console.WriteLine("Арифметическая прогрессия");
            } else if (checkProgressionType == 2)
            {
                Console.WriteLine("Геометрическая прогрессия");
            } else
            {
                Console.WriteLine("Прогрессии нет");
            }
        }

        /// <summary>
        /// Функция определения типа прогрессии
        /// </summary>
        /// <param name="numbersString">Строка с числами</param>
        /// <returns>Номер типа прогрессии или ошибки, если ее нет</returns>
        static int CheckProgressionType(string numbersString)
        {
            double[] numbersArray = GetNumbers(numbersString);

            int result = 1;

            if (numbersArray.Length < 2) return 0;

            double arithmeticStep = numbersArray[1] - numbersArray[0];
            //Console.WriteLine(arithmeticStep);

            for (int i = 2; i < numbersArray.Length; i++)
            {
                if ((numbersArray[i] - numbersArray[i - 1]) != arithmeticStep)
                {
                    result = 2;
                    break;
                }
            }

            if (result == 2)
            {
                if (numbersArray[0] != 0) return 0;
                double geomethricStep = numbersArray[1] / numbersArray[0];
                //Console.WriteLine("step:" +geomethricStep);

                for (int i = 2; i < numbersArray.Length; i++)
                {
                    //Console.WriteLine(numbersArray[i - 1] * geomethricStep);
                    if (numbersArray[i] != numbersArray[i - 1] * geomethricStep)
                    {
                        result = 0;
                        break;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Функция перевода строки с числами в массив чисел
        /// </summary>
        /// <param name="numbers">Строка с числами</param>
        /// <returns>Массив чисел</returns>
        static double[] GetNumbers(string numbers)
        {
            string[] rawNumbers = new string[numbers.Length / 2 + 1];

            int numbersCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (((numbers[i] >= '0') && (numbers[i] <= '9')) || (numbers[i] == ',') || (numbers[i] == '-'))
                {
                    rawNumbers[numbersCount] += numbers[i];
                }
                else
                {
                    numbersCount++;
                }
            }

            double[] numbersArray = new double[numbersCount + 1];

            for (int i = 0; i <= numbersCount; i++)
            {
                numbersArray[i] = double.Parse(rawNumbers[i]);
            }

            return numbersArray;
        }

        /// <summary>
        /// Функция, обрабатывающая ввод текста и вывод результата для вычисления функции Аккермана
        /// </summary>
        static void AckermannCountOperate()
        {
            Console.WriteLine("Введите два числа через enter:");

            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Ответ: {AckermannCount(n, m)}");
        }

        /// <summary>
        /// Вычисление функции Аккермана
        /// </summary>
        /// <param name="n">Первое число</param>
        /// <param name="m">Второе число</param>
        /// <returns>Результат вычисления функции</returns>
        static int AckermannCount(int n, int m)
        {
            if ((n > 0) && (m == 0))
            {
                return AckermannCount(n - 1, 1);
            }
            else if ((n > 0) && (m > 0))
            {
                return AckermannCount(n - 1, AckermannCount(n, m - 1));
            } else return (m + 1);
        }
    }
}
