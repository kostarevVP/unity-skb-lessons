using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1
            // Задание 1.
            // Заказчик просит вас написать приложение по учёту финансов
            // и продемонстрировать его работу.
            // Суть задачи в следующем: 
            // Руководство фирмы по 12 месяцам ведет учет расходов и поступлений средств. 
            // За год получены два массива – расходов и поступлений.
            // Определить прибыли по месяцам
            // Количество месяцев с положительной прибылью.
            // Добавить возможность вывода трех худших показателей по месяцам, с худшей прибылью, 
            // если есть несколько месяцев, в некоторых худшая прибыль совпала - вывести их все.
            // Организовать дружелюбный интерфейс взаимодействия и вывода данных на экран

            // Пример
            //       
            // Месяц      Доход, тыс. руб.  Расход, тыс. руб.     Прибыль, тыс. руб.
            //     1              100 000             80 000                 20 000
            //     2              120 000             90 000                 30 000
            //     3               80 000             70 000                 10 000
            //     4               70 000             70 000                      0
            //     5              100 000             80 000                 20 000
            //     6              200 000            120 000                 80 000
            //     7              130 000            140 000                -10 000
            //     8              150 000             65 000                 85 000
            //     9              190 000             90 000                100 000
            //    10              110 000             70 000                 40 000
            //    11              150 000            120 000                 30 000
            //    12              100 000             80 000                 20 000
            // 
            // Худшая прибыль в месяцах: 7, 4, 1, 5, 12
            // Месяцев с положительной прибылью: 10
            #endregion

            #region Задание 2
            // * Задание 2
            // Заказчику требуется приложение строящее первых N строк треугольника паскаля. N < 25
            // 
            // При N = 9. Треугольник выглядит следующим образом:
            //                                 1
            //                             1       1
            //                         1       2       1
            //                     1       3       3       1
            //                 1       4       6       4       1
            //             1       5      10      10       5       1
            //         1       6      15      20      15       6       1
            //     1       7      21      35      35       21      7       1
            //                                                              
            //                                                              
            // Простое решение:                                                             
            // 1
            // 1       1
            // 1       2       1
            // 1       3       3       1
            // 1       4       6       4       1
            // 1       5      10      10       5       1
            // 1       6      15      20      15       6       1
            // 1       7      21      35      35       21      7       1
            // 
            // Справка: https://ru.wikipedia.org/wiki/Треугольник_Паскаля
            #endregion

            #region Задание 3.1
            // 
            // * Задание 3.1
            // Заказчику требуется приложение позволяющщее умножать математическую матрицу на число
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матрицы_на_число
            // Добавить возможность ввода количество строк и столцов матрицы и число,
            // на которое будет производиться умножение.
            // Матрицы заполняются автоматически. 
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //
            //      |  1  3  5  |   |  5  15  25  |
            //  5 х |  4  5  7  | = | 20  25  35  |
            //      |  5  3  1  |   | 25  15   5  |
            //
            //
            #endregion

            #region Задание 3.2
            // ** Задание 3.2
            // Заказчику требуется приложение позволяющщее складывать и вычитать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Сложение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
            //
            // Пример
            //  |  1  3  5  |   |  1  3  4  |   |  2   6   9  |
            //  |  4  5  7  | + |  2  5  6  | = |  6  10  13  |
            //  |  5  3  1  |   |  3  6  7  |   |  8   9   8  |
            //  
            //  
            //  |  1  3  5  |   |  1  3  4  |   |  0   0   1  |
            //  |  4  5  7  | - |  2  5  6  | = |  2   0   1  |
            //  |  5  3  1  |   |  3  6  7  |   |  2  -3  -6  |
            //
            #endregion

            #region Задание 3.3
            // *** Задание 3.3
            // Заказчику требуется приложение позволяющщее перемножать математические матрицы
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
            // Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матриц
            // Добавить возможность ввода количество строк и столцов матрицы.
            // Матрицы заполняются автоматически
            // Если по введённым пользователем данным действие произвести нельзя - сообщить об этом
            //  
            //  |  1  3  5  |   |  1  3  4  |   | 22  48  57  |
            //  |  4  5  7  | х |  2  5  6  | = | 35  79  95  |
            //  |  5  3  1  |   |  3  6  7  |   | 14  36  45  |
            //
            //  
            //                  | 4 |   
            //  |  1  2  3  | х | 5 | = | 32 |
            //                  | 6 |  
            //
            #endregion

            // Задание 1.
            //FinanceAccounting();

            // Задание 2.
            //MakePascalsTriangle();

            // Задание 3.1.
            //MatrixMultiplicationByNumber();

            // Задание 3.2.
            MatrixAddition();

            // Задание 3.3.

            Console.ReadKey();
        }

        /// <summary>
        /// Функция для учета финансов
        /// </summary>
        static void FinanceAccounting()
        {
            // количество месяцев
            int n = 12;

            // доходы
            int[] income = new int[n];
            // расходы
            int[] costs = new int[n];
            // прибыль
            int[,] profit = new int[2,n];
            // худшая прибыль
            int[,] worstProfit = new int[2,n];
            // количество месяцев с положительной прибылью
            int positiveProfit = 0;

            Console.WriteLine($"Введите данные по доходам за {n} месяцев");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1} месяц: ");
                income[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Введите данные по расходам за {n} месяцев");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1} месяц: ");
                costs[i] = Convert.ToInt32(Console.ReadLine());

                // рассчитывается прибыль
                profit[0, i] = i + 1;
                profit[1, i] = income[i] - costs[i];
                
                if (profit[1, i] > 0) positiveProfit++;
            }

            // сортировка прибыли для получения данных о худшей прибыли
            Array.Copy(profit, worstProfit, n * 2);
            for (int i = 1; i < n; i++)
            {
                for (int j = i; j > 0 && worstProfit[1, j-1] > worstProfit[1, j]; j--)
                {
                    int tmp = worstProfit[0, j - 1];
                    worstProfit[0, j - 1] = worstProfit[0, j];
                    worstProfit[0, j] = tmp;

                    tmp = worstProfit[1, j - 1];
                    worstProfit[1, j - 1] = worstProfit[1, j];
                    worstProfit[1, j] = tmp;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(worstProfit[0,i] + " " + worstProfit[1, i]);
            }
            // вывод таблицы доходов, расходов и прибыли
            string pattern = "{0,5} {1,20} {2,20} {3,20}";
            Console.WriteLine(pattern, "Месяц", "Доход, тыс. руб.", "Расход, тыс. руб.", "Прибыль, тыс. руб.");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(pattern, i + 1, income[i], costs[i], profit[1,i]);
            }

            //вывод данных о худшей прибыли
            Console.Write($"Худшая прибыль в месяцах: {worstProfit[0, 0]}");
            int worstCount = 1;
            int counter = 1;
            while ((worstCount < 4) && (counter < n))
            {
                Console.Write($", {worstProfit[0, counter]}");
                if (worstProfit[1, counter] != worstProfit[1, counter - 1])
                {
                    worstCount++;
                }
                counter++;
            }

            Console.WriteLine($"\nМесяцев с положительной прибылью: {positiveProfit}");
        }

        /// <summary>
        /// Функция вывода первых N строк треугольника паскаля
        /// </summary>
        static void MakePascalsTriangle()
        {
            int n = 1;
            Console.WriteLine("Введите желаемое количество строк треугольника < 25");

            // проверка на корректность ввода
            bool check = false;
            while (!check)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if ((n > 24) || (n < 1)) {
                    Console.WriteLine("Недопустимое число, повторите ввод");
                } else
                {
                    check = true;
                }
            }

            // вывод
            Console.WriteLine("Вывод треугольника Паскаля:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= (n - i); j++)
                {
                    Console.Write("    ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("{0, 8:0}", Factorial(i) / (Factorial(j) * Factorial(i - j)));
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Функция вычисления факториала
        /// </summary>
        /// <param name="n">Число факториала</param>
        /// <returns>Результат вычисления</returns>
        public static float Factorial(int n)
        {
            float result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        /// <summary>
        /// Функция вывода умножения матрицы на число
        /// </summary>
        static void MatrixMultiplicationByNumber()
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

            Console.WriteLine("\nРезультат вычислений:");
            // вывод примера в консоль
            for (int i = 0; i < n; i++)
            {
                if (i == (n - 1) / 2)
                {
                    Console.Write($"{number, 9} х |");
                } else
                {
                    Console.Write("{0,13}","|");
                }

                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{rand.Next(-9, 10),3}");
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
                    Console.Write($"{rand.Next(-9, 10) * number,9}");
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
                } else
                {
                    check = true;
                }
            }

            return n;
        }

        /// <summary>
        /// Функция вывода результата сложения матриц
        /// </summary>
        static void MatrixAddition()
        {
            Console.WriteLine("Введите число строк матрицы от 1 до 1000000:");
            int n = EnterValidNumber();

            Console.WriteLine("\nВведите число столбцов матрицы от 1 до 1000000:");
            int m = EnterValidNumber();

            Random rand = new Random();

            Console.WriteLine("\nРезультат вычислений:");
            // вывод примера в консоль
            for (int i = 0; i < n; i++)
            {
                Console.Write("  |");

                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{rand.Next(-9, 10),3}");
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
                    Console.Write($"{rand.Next(-9, 10) * number,9}");
                }

                Console.Write("  |");

                Console.WriteLine();
            }
        }
    }
}
