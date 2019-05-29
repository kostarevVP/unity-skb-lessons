using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6
{
    /// <summary>
    /// Структура "Ежедневник"
    /// </summary>
    struct Diary
    {
        /// <summary>
        /// Создание объекта ежедневника
        /// </summary>
        /// <param name="DiaryName">Название ежедневника</param>
        /// <param name="DirectoryPath">Путь к ежедневнику</param>
        /// <param name="CreatedAt">Время создания</param>
        /// <param name="UpdatedAt">Время последнего редактирования</param>
        public Diary(string DiaryName, string DirectoryPath, DateTime CreatedAt, DateTime UpdatedAt)
        {
            this.diaryName = DiaryName;
            this.path = DirectoryPath;
            this.createdAt = CreatedAt;
            this.updatedAt = UpdatedAt;
        }

        #region Свойства

        /// <summary>
        /// Название
        /// </summary>
        public string DiaryName { get { return this.diaryName; } set { this.diaryName = value; } }

        /// <summary>
        /// Путь
        /// </summary>
        public string DirectoryPath { get { return this.path; } set { this.path = value; } }

        /// <summary>
        /// Время создания
        /// </summary>
        public DateTime CreatedAt { get { return this.createdAt; } set { this.createdAt = value; } }

        /// <summary>
        /// Время последнего редактирования
        /// </summary>
        public DateTime UpdatedAt { get { return this.updatedAt; } set { this.updatedAt = value; } }

        #endregion

        #region Поля

        /// <summary>
        /// Поле "Название"
        /// </summary>
        private string diaryName;

        
        /// <summary>
        /// Поле "Путь к файлу"
        /// </summary>
        private string path;

        /// <summary>
        /// Поле "Время создания"
        /// </summary>
        private DateTime createdAt;

        /// <summary>
        /// Поле "Время последнего редактирования"
        /// </summary>
        private DateTime updatedAt;

        #endregion
    }
}
