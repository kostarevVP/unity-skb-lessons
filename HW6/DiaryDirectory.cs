using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6
{
    /// <summary>
    /// Структура "Директория"
    /// </summary>
    struct DiaryDirectory
    {
        /// <summary>
        /// Создание объекта директории
        /// </summary>
        /// <param name="DirectoryName">Имя директории</param>
        /// <param name="ParentPath">Путь к родительской директории</param>
        public DiaryDirectory(string DirectoryName, string ParentPath)
        {
            this.name = DirectoryName;
            this.parentPath = ParentPath;
        }

        /// <summary>
        /// Имя директории
        /// </summary>
        public string DirectoryName { get { return this.name; } set { this.name = value; } }

        /// <summary>
        /// Путь к родительской директории
        /// </summary>
        public string ParentPath { get { return this.parentPath; } set { this.parentPath = value; } }

        /// <summary>
        /// Поле "Путь к директории"
        /// </summary>
        private string name;

        /// <summary>
        /// Поле "Путь к родительской дироектории"
        /// </summary>
        private string parentPath;
    }
}
