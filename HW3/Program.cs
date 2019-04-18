using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Домашнее задание
            // Просматривая сайты по поиску работы, у вас вызывает интерес следующая вакансия:

            // Требуемый опыт работы: без опыта
            // Частичная занятость, удалённая работа
            //
            // Описание 
            //
            // Стартап «Micarosppoftle» занимающийся разработкой
            // многопользовательских игр ищет разработчиков в свою команду.
            // Компания готова рассмотреть C#-программистов не имеющих опыта в разработке, 
            // но желающих развиваться в сфере разработки игр на платформе .NET.
            //
            // Должность Интерн C#/
            //
            // Основные требования:
            // C#, операторы ввода и вывода данных, управляющие конструкции 
            // 
            // Конкурентным преимуществом будет знание процедурного программирования.
            //
            // Не технические требования: 
            // английский на уровне понимания документации и справочных материалов
            //
            // В качестве тестового задания предлагается решить следующую задачу.
            //
            // Написать игру, в которою могут играть два игрока.
            // При старте, игрокам предлагается ввести свои никнеймы.
            // Никнеймы хранятся до конца игры.
            // Программа загадывает случайное число gameNumber от 12 до 120 сообщая это число игрокам.
            // Игроки ходят по очереди(игра сообщает о ходе текущего игрока)
            // Игрок, ход которого указан вводит число userTry, которое может принимать значения 1, 2, 3 или 4,
            // введенное число вычитается из gameNumber
            // Новое значение gameNumber показывается игрокам на экране.
            // Выигрывает тот игрок, после чьего хода gameNumber обратилась в ноль.
            // Игра поздравляет победителя, предлагая сыграть реванш
            // 
            // * Бонус:
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)

            // *** Сложный бонус
            // Подумать над возможностью реализации однопользовательской игры
            // т е игрок должен играть с компьютером


            // Демонстрация
            // Число: 12,
            // Ход User1: 3
            //
            // Число: 9
            // Ход User2: 4
            //
            // Число: 5
            // Ход User1: 2
            //
            // Число: 3
            // Ход User2: 3
            //
            // User2 победил!
            #endregion

            Console.WriteLine("Вас приветсвует игра \"Обнули число!\"\n");

            // Задание 1.
            //SimpleGame();

            // Задание 2.
            //CustomGame();

            // Задание 3.
            //SinglePlayerGame();

            Console.ReadKey();
        }

        /// <summary>
        /// Код базовой игры
        /// </summary>
        static void SimpleGame()
        {
            int playersNumber = 2;
        
            int minGameNumber = 12;

            int maxGameNumber = 120;

            int minUserTry = 1;

            int maxUserTry = 4;

            // общий алгоритм игры вынесен в отдельную функцию
            Game(playersNumber, minGameNumber, maxGameNumber, minUserTry, maxUserTry);

            #region Первоначальный вариант строго для заданных условий
            /* string playerOneName; // имя первого игрока
            Console.WriteLine("Введите имя первого игрока:");
            playerOneName = Console.ReadLine();

            string playerTwoName; // имя второго игрока
            Console.WriteLine("Введите имя второго игрока:");
            playerTwoName = Console.ReadLine();

            Random randomize = new Random(); // переменная для получения псевдослучайных чисел
            int gameNumber = randomize.Next(12, 121); // загаданное случайное число

            Console.WriteLine("\nОтлично! Вам необходимо обнулить задуманное игрой число,");
            Console.WriteLine("последовательно вычитая из него целые числа в диапазоне от 1 до 4.");

            int playerNumber = 1; // номер ходящего игрока

            while (gameNumber > 0) // процесс игры
            {
                if (playerNumber == 1) // если ход первого игрока
                {
                    Console.WriteLine($"\nЧисло: {gameNumber}");
                    int userTry = 0;
                    
                    bool rightNumber = false; // проверка на попадание введенного числа в диапазон условия задачи
                    while (!rightNumber)
                    {
                        Console.Write($"Ход {playerOneName}: ");
                        userTry = Convert.ToInt32(Console.ReadLine());
                        if ((userTry < 1) || (userTry > 4))
                        {
                            Console.WriteLine("Неверное число!");
                        }
                        else rightNumber = true;
                    }

                    gameNumber -= userTry;
                    playerNumber = 2;
                } else
                {
                    Console.WriteLine($"\nЧисло: {gameNumber}");
                    int userTry;
                    Console.Write($"Ход {playerTwoName}: ");
                    userTry = Convert.ToInt32(Console.ReadLine());
                    gameNumber -= userTry;
                    playerNumber = 1;
                }
            }

            if (playerNumber == 1)
            {
                Console.WriteLine($"\n{playerTwoName} победил!");
            } else
            {
                Console.WriteLine($"\n{playerOneName} победил!");
            } */
            #endregion
        }

        /// <summary>
        /// Код бонусной игры
        /// </summary>
        static void CustomGame()
        {
            // Настройки сложности игры
            Console.WriteLine("Определите настройки сложности игры");

            Console.Write("Введите число игроков: ");
            int playersNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nОпределите диапазон загадываемого игрой числа");
            Console.Write("Введите минимальную границу: ");
            int minGameNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите максимальную границу: ");
            int maxGameNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nОпределите диапазон вводимых игроками чисел");
            Console.Write("Введите минимальную границу: ");
            int minUserTry = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите максимальную границу: ");
            int maxUserTry = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nНастройки закончены! Переходим к игре\n");

            // общий алгоритм игры вынесен в отдельную функцию
            Game(playersNumber, minGameNumber, maxGameNumber, minUserTry, maxUserTry);
        }

        static void Game(int playersNumber, int minGameNumber, int maxGameNumber, int minUserTry, int maxUserTry)
        {
            // Добавляем имена игроков
            string[] players = new string[playersNumber]; // массив с именами игроков
            for (int i = 0; i < playersNumber; i++)
            {
                Console.WriteLine($"Введите имя {i + 1}-го игрока:");
                players[i] = Console.ReadLine();
            }

            // Ход игры
            Random randomize = new Random(); // переменная для получения псевдослучайных чисел
            int gameNumber = randomize.Next(minGameNumber, maxGameNumber); // загаданное случайное число

            Console.WriteLine("\nОтлично! Вам необходимо обнулить задуманное игрой число,");
            Console.WriteLine($"последовательно вычитая из него целые числа в диапазоне от {minUserTry} до {maxUserTry}.");

            int playerNumber = 0; // номер ходящего игрока

            while (gameNumber > 0) // процесс игры
            {
                playerNumber = 0;
                for (; playerNumber < playersNumber; playerNumber++)
                {
                    if (gameNumber <= 0) break;

                    Console.WriteLine($"\nЧисло: {gameNumber}");
                    int userTry = 0;

                    bool rightNumber = false; // проверка на попадание введенного числа в диапазон условия задачи
                    while (!rightNumber)
                    {
                        Console.Write($"Ходит {players[playerNumber]}: ");
                        userTry = Convert.ToInt32(Console.ReadLine());
                        if ((userTry < minUserTry) || (userTry > maxUserTry))
                        {
                            Console.WriteLine("Неверное число!");
                        }
                        else rightNumber = true;
                    }

                    gameNumber -= userTry;
                }
            }

            Console.WriteLine($"\n{players[playerNumber - 1]} победил!");
        }

        /// <summary>
        /// Код однопользовательской игры
        /// </summary>
        static void SinglePlayerGame()
        {
            Console.WriteLine("Вы играете с Компьютером\n");
            // Настройки сложности игры
            Console.WriteLine("Определите настройки сложности игры");

            Console.WriteLine("\nОпределите диапазон загадываемого игрой числа");
            Console.Write("Введите минимальную границу: ");
            int minGameNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите максимальную границу: ");
            int maxGameNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nОпределите диапазон вводимых игроками чисел");
            Console.Write("Введите минимальную границу: ");
            int minUserTry = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите максимальную границу: ");
            int maxUserTry = Convert.ToInt32(Console.ReadLine());

            string[] players = new string[2]; // массив с именами игроков
            Console.WriteLine("\nВведите имя игрока:");
            players[0] = Console.ReadLine();
            players[1] = "Увы, Компьютер";

            // Ход игры
            Random randomize = new Random(); // переменная для получения псевдослучайных чисел
            int gameNumber = randomize.Next(minGameNumber, maxGameNumber); // загаданное случайное число

            Console.WriteLine("\nОтлично! Вам необходимо обнулить задуманное игрой число,");
            Console.WriteLine($"последовательно вычитая из него целые числа в диапазоне от {minUserTry} до {maxUserTry}\n");

            int playerNumber = 1; // номер ходящего игрока

            while (gameNumber > 0) // процесс игры
            {
                Console.WriteLine($"Число: {gameNumber}");

                if (playerNumber == 1) // если ход первого игрока
                {
                    int userTry = 0;

                    bool rightNumber = false; // проверка на попадание введенного числа в диапазон условия задачи
                    while (!rightNumber)
                    {
                        Console.Write($"Ходит {players[0]}: ");
                        userTry = Convert.ToInt32(Console.ReadLine());
                        if ((userTry < minUserTry) || (userTry > maxUserTry))
                        {
                            Console.WriteLine("Неверное число!");
                        }
                        else rightNumber = true;
                    }

                    Console.WriteLine();
                    gameNumber -= userTry;
                    playerNumber = 0;
                }
                else // ход Компьютера
                {
                    int userTry;

                    if (gameNumber <= maxUserTry)
                    {
                        userTry = gameNumber;
                        gameNumber = 0;
                    } else
                    {
                        userTry = new Random().Next(minUserTry, maxUserTry + 1);
                        gameNumber -= userTry;
                    }

                    Console.WriteLine($"Ходит Компьютер: {userTry}\n");

                    playerNumber = 1;
                }
            }
            
            Console.WriteLine($"{players[playerNumber]} победил!");
        }
    }
}
