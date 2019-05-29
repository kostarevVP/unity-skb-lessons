using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6
{
    /// <summary>
    /// Структура "Запись в ежедневник"
    /// </summary>
    struct Note
    {
        /// <summary>
        /// Создание объекта записи
        /// </summary>
        /// <param name="NoteName">Название заметки</param>
        /// <param name="NoteText">Текст заметки</param>
        /// <param name="CreatedAt">Время создания</param>
        /// <param name="UpdatedAt">Время последнего редактирования</param>
        public Note(string NoteName, string NoteText, DateTime CreatedAt, DateTime UpdatedAt)
        {
            this.noteName = NoteName;
            this.noteText = NoteText;
            this.createdAt = CreatedAt;
            //this.createdAt = DateTime.Now;
            //this.updatedAt = DateTime.Now;
            this.updatedAt = UpdatedAt;
        }

        #region Свойства

        /// <summary>
        /// Название заметки
        /// </summary>
        public string NoteName { get { return this.noteName; } set { this.noteName = value; } }

        /// <summary>
        /// Текст заметки
        /// </summary>
        public string NoteText { get { return this.noteText; } set { this.noteText = value; } }

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
        private string noteName;

        /// <summary>
        /// Поле "Текст заметки"
        /// </summary>
        private string noteText;

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
