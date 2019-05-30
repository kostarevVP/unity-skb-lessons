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
        /// ID заметки
        /// </summary>
        public int NoteId { get; set; }

        /// <summary>
        /// Название заметки
        /// </summary>
        public string NoteName { get; set; }

        /// <summary>
        /// Текст заметки
        /// </summary>
        public string NoteText { get; set; }

        /// <summary>
        /// Время создания
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Время последнего редактирования
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Место события
        /// </summary>
        public string Place { get; set; }

        /// <summary>
        /// Дата события
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Теги события
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}
