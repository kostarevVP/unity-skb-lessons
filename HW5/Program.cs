﻿using System;

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
            MatrixAdditionOperate();

            // 1.3. Создать метод, принимающий две матрицы, возвращающий их произведение
            //MatrixMultiplicationOperate();

            // Задание 2.
            // 1. Создать метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв
            // 2.* Создать метод, принимающий  текст и возвращающий слово(слова) с максимальным количеством букв 
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
            // 
            // Задание 4. Написать метод принимающий некоторое количесво чисел, выяснить
            // является заданная последовательность элементами арифметической или геометрической прогрессии
            // 
            // Примечание
            //             http://ru.wikipedia.org/wiki/Арифметическая_прогрессия
            //             http://ru.wikipedia.org/wiki/Геометрическая_прогрессия
            //
            // *Задание 5
            // Вычислить, используя рекурсию, функцию Аккермана:
            // A(2, 5), A(1, 2)
            // A(n, m) = m + 1, если n = 0,
            //         = A(n - 1, 1), если n <> 0, m = 0,
            //         = A(n - 1, A(n, m - 1)), если n> 0, m > 0.
            // 
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
        /// <returns>результат сложения</returns>
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
        static void MatrixMultiplication()
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
            int[,] newMatrix = new int[n, k];

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
    }
}
