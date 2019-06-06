using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Homework_6
{
    struct DirectoryRepository
    {

        /// <summary>
        /// Функция создания корневой директории ежедневника
        /// </summary>
        public void CreateMainDirectory()
        {
            if (CreateNewDirectory(GetRootDirectoryPath() + "/MyDiary"))
            {
                Console.WriteLine("Создана директория ежедневника");
            } else
            {
                Console.WriteLine("Директория ежедневника уже существует");
            }
        }

        /// <summary>
        /// Функция создания директории
        /// </summary>
        /// <param name="directoryPath">Путь к директории</param>
        /// <returns>Была ли создана директория</returns>
        public bool CreateNewDirectory(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Получить путь к корневой директории проекта
        /// </summary>
        /// <returns>Строка с путем</returns>
        public static string GetRootDirectoryPath()
        {
            string workingDirectory = Environment.CurrentDirectory;
            DirectoryInfo directoryInfo = new DirectoryInfo(workingDirectory);
            DirectoryInfo rootDirectoryInfo = directoryInfo.Parent.Parent.Parent;

            return rootDirectoryInfo.FullName;
        }

        public static void PrintDir()
        {
            string startupPath = Environment.CurrentDirectory;
            Console.WriteLine(startupPath);
        }
    }


}
