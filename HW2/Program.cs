using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Theme_01
{
    class Program
    {
        public static int i = 0;
        static void Main(string[] args)
        {
            #region Домашнее задание
            // Заказчик просит написать программу «Записная книжка». Оплата фиксированная - $ 120.

            // В данной программе, должна быть возможность изменения значений нескольких переменных для того,
            // чтобы персонифецировать вывод данных, под конкретного пользователя.

            // Для этого нужно: 
            // 1. Создать несколько переменных разных типов, в которых могут храниться данные
            //    - имя;
            //    - возраст;
            //    - рост;
            //    - баллы по трем предметам: история, математика, русский язык;

            // 2. Реализовать в системе автоматический подсчёт среднего балла по трем предметам, 
            //    указанным в пункте 1.

            // 3. Реализовать возможность печатки информации на консоли при помощи 
            //    - обычного вывода;
            //    - форматированного вывода;
            //    - использования интерполяции строк;

            // 4. Весь код должен быть откомментирован с использованием обычных и хml-комментариев

            // **
            // 5. В качестве бонусной части, за дополнительную оплату $50, заказчик просит реализовать 
            //    возможность вывода данных в центре консоли.

            #endregion

            string name; // имя
            byte age; // возраст
            float growth; // рост 

            uint historyMark; // баллы по истории
            uint mathMark; // баллы по математике
            uint russianMark; // баллы по русскому языку

            bool isCentered; // нужно ли выводить по центру

            /* 1. Печать при помощи обычного вывода */

            // инициализация переменных
            name = "Иван Иванов";
            age = 15;
            growth = 170.56F;
            historyMark = 4;
            mathMark = 5;
            russianMark = 5;
            isCentered = true;

            // печать
            SimplePrint(name, age, growth, historyMark, mathMark, russianMark, isCentered);

            /* 2. Печать при помощи форматированного вывода */

            // инициализация переменных
            name = "Михаил Романов";
            age = 14;
            growth = 164.3333F;
            historyMark = 5;
            mathMark = 3;
            russianMark = 5;
            isCentered = true;

            // печать
            FormattedPrint(name, age, growth, historyMark, mathMark, russianMark, isCentered);

            /* 3. Печать при помощи использования интерполяции строк */

            // инициализация переменных
            name = "Анна Павлова";
            age = 13;
            growth = 150.1F;
            historyMark = 3;
            mathMark = 3;
            russianMark = 3;
            isCentered = true;

            // печать
            InterpolatedPrint(name, age, growth, historyMark, mathMark, russianMark, isCentered);

            Console.ReadKey();
        }

        /// <summary>
        /// Подсчёт среднего балла по трем предметам
        /// </summary>
        /// <param name="historyMark">баллы по истории</param>
        /// <param name="mathMark">баллы по математике</param>
        /// <param name="russianMark">баллы по русскому языку</param>
        static double AverageMarkCount(uint historyMark, uint mathMark, uint russianMark)
        {
            return (double)(historyMark + mathMark + russianMark) / 3;
        }

        /// <summary>
        /// Обычный вывод
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="age">возраст</param>
        /// <param name="growth">рост</param>
        /// <param name="historyMark">баллы по истории</param>
        /// <param name="mathMark">баллы по математике</param>
        /// <param name="russianMark">баллы по русскому языку</param>
        /// <param name="isCentered">необходимо ли выводить по центру</param>
        static void SimplePrint(string name, byte age,  float growth, uint historyMark, uint mathMark, uint russianMark, bool isCentered)
        {
            // средний балл по трем предметам
            double averageMark = AverageMarkCount(historyMark, mathMark, russianMark);
            string averageMarkFormatted = averageMark.ToString("#.##");

            // вывод в консоль
            if (isCentered) // если по центру
            {
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + i++);
                Console.WriteLine("Печать при помощи обычного вывода");

                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + i++);
                Console.WriteLine(name + " " + age + " " + growth.ToString("#.##") + " " + historyMark +
                    " " + mathMark + " " + russianMark + " " + averageMarkFormatted);
                Console.WriteLine();
                i++;
            }
            else // обычное положение курсора
            {
                Console.WriteLine("Печать при помощи обычного вывода");
                Console.WriteLine(name + " " + age + " " + growth.ToString("#.##") + " " + historyMark +
                    " " + mathMark + " " + russianMark + " " + averageMarkFormatted);
                Console.WriteLine();
                i += 3;
            }
            
        }

        /// <summary>
        /// Форматированный вывод
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="age">возраст</param>
        /// <param name="growth">рост</param>
        /// <param name="historyMark">баллы по истории</param>
        /// <param name="mathMark">баллы по математике</param>
        /// <param name="russianMark">баллы по русскому языку</param>
        /// <param name="isCentered">необходимо ли выводить по центру</param>
        static void FormattedPrint(string name, byte age, float growth, uint historyMark, uint mathMark, uint russianMark, bool isCentered)
        {
            // средний балл по трем предметам
            double averageMark = AverageMarkCount(historyMark, mathMark, russianMark);
            string averageMarkFormatted = averageMark.ToString("#.##");

            if (isCentered) // если по центру
            {
                // вывод в консоль
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + i++);
                Console.WriteLine("Печать при помощи форматированного вывода");

                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + i++);
                Console.WriteLine("Имя: {0}", name);
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + i++);
                Console.WriteLine("Возраст: {0}", age);
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + i++);
                Console.WriteLine("Рост: {0}", growth.ToString("#.##"));
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + i++);
                Console.WriteLine("Баллы по истории: {0}", historyMark);
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + i++);
                Console.WriteLine("Баллы по математике: {0}", mathMark);
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + i++);
                Console.WriteLine("Баллы по русскому языку: {0}", russianMark);
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + i++);
                Console.WriteLine("Средний балл: {0}", averageMarkFormatted);
                Console.WriteLine();
                i++;
            }
            else // обычное положение курсора
            {
                // формат вывода
                string pattern = "Имя: {0} \nВозраст: {1} \nРост: {2} \nБаллы по истории: {3} \n" +
                "Баллы по математике: {4} \nБаллы по русскому языку: {5} \nСредний балл: {6} \n";

                // вывод в консоль
                Console.WriteLine("Печать при помощи форматированного вывода");
                Console.WriteLine(pattern, name, age, growth.ToString("#.##"), historyMark, mathMark, russianMark, averageMarkFormatted);
                i += 9;
            }
        }

        /// <summary>
        /// Вывод с использованием интерполяции строк
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="age">возраст</param>
        /// <param name="growth">рост</param>
        /// <param name="historyMark">баллы по истории</param>
        /// <param name="mathMark">баллы по математике</param>
        /// <param name="russianMark">баллы по русскому языку</param>
        /// <param name="isCentered">необходимо ли выводить по центру</param>
        static void InterpolatedPrint(string name, byte age, float growth, uint historyMark, uint mathMark, uint russianMark, bool isCentered)
        {
            // средний балл по трем предметам
            double averageMark = AverageMarkCount(historyMark, mathMark, russianMark);
            string averageMarkFormatted = averageMark.ToString("#.##");

            if (isCentered) // если по центру
            {
                // вывод в консоль
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + i++);
                Console.WriteLine("Печать при помощи использования интерполяции строк");
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + i++);
                Console.WriteLine($"Имя: {name}");
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + i++);
                Console.WriteLine($"Возраст: {age}");
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + i++);
                Console.WriteLine($"Рост: {growth.ToString("#.##")}");
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + i++);
                Console.WriteLine($"Баллы по истории: {historyMark}");
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + i++);
                Console.WriteLine($"Баллы по математике: {mathMark}");
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + i++);
                Console.WriteLine($"Баллы по русскому языку: {russianMark}");
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + i++);
                Console.WriteLine($"Cредний балл: {averageMarkFormatted}");
                Console.WriteLine();
                i++;
            }
            else // обычное положение курсора
            {
                // вывод в консоль
                Console.WriteLine("Печать при помощи использования интерполяции строк");
                Console.WriteLine($"Имя: {name} \nВозраст: {age} \nРост: {growth.ToString("#.##")} \nБаллы по истории: {historyMark} \n" +
                    $"Баллы по математике: {mathMark} \nБаллы по русскому языку: {russianMark} \nСредний балл: {averageMarkFormatted} \n");
                Console.WriteLine();
                i += 9;
            }
                
        }
    }
}
