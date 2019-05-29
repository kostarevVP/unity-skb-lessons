using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6
{
    /// <summary>
    /// Структура "Директория"
    /// </summary>
    struct Directory
    {
        /// <summary>
        /// Создание объекта директории
        /// </summary>
        /// <param name="DirectoryPath"></param>
        public Directory(string DirectoryPath)
        {
            this.path = DirectoryPath;
        }

        /// <summary>
        /// Путь к директории
        /// </summary>
        public string DirectoryPath { get { return this.path; } set { this.path = value; } }

        /// <summary>
        /// Поле "Путь к директории"
        /// </summary>
        private string path;
    }
}
