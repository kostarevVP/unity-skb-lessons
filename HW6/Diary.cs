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
        /// <param name="CreatedAt">Время создания</param>
        /// <param name="UpdatedAt">Время последнего редактирования</param>
        public Diary(string DiaryName, DateTime CreatedAt, DateTime UpdatedAt)
        {
            this.DiaryName = DiaryName;
            this.CreatedAt = CreatedAt;
            this.UpdatedAt = UpdatedAt;
        }

        /// <summary>
        /// Название
        /// </summary>
        public string DiaryName { get; set; }

        /// <summary>
        /// Время создания
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Время последнего редактирования
        /// </summary>
        public DateTime UpdatedAt { get; set; }
    }
}
