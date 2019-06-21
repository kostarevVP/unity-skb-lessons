using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Homework_6
{
    struct DirectoryRepository
    {

        /// <summary>
        /// Функция создания новой директории
        /// </summary>
        /// <param name="parentDirectory">Информация о родительской директории</param>
        /// <param name="newDirName">Имя новой директории</param>
        /// <returns></returns>
        public bool CreateNewDirectory(DirectoryInfo parentDirectory, string newDirName)
        {
            string newDirPath = parentDirectory.FullName + "/" + newDirName;
            if (!Directory.Exists(newDirPath))
            {
                Directory.CreateDirectory(newDirPath);
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
        public DirectoryInfo GetRootDirectoryInfo()
        {
            string workingDirectory = Environment.CurrentDirectory;
            DirectoryInfo directoryInfo = new DirectoryInfo(workingDirectory);
            DirectoryInfo rootDirectoryInfo = directoryInfo.Parent.Parent.Parent;

            return rootDirectoryInfo;
        }

        public static void PrintDir()
        {
            string startupPath = Environment.CurrentDirectory;
            Console.WriteLine(startupPath);
        }
    }


}
