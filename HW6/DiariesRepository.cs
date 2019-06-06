using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6
{
    /// <summary>
    /// Структура для работы с ежедневниками
    /// </summary>
    struct DiariesRepository
    {
        public DiariesRepository(string PathToDiaries)
        {
            this.pathToDiaries = PathToDiaries;
        }

        //private Diary[] diaries;

        /// <summary>
        /// Поле "Путь к хранению ежедневников"
        /// </summary>
        private string pathToDiaries;

        /// <summary>
        /// Представляет путь к хранению ежедневников.
        /// Разрешено работать в пределах одной директории.
        /// </summary>
        public string PathToDiaries { get { return this.pathToDiaries; } set { this.pathToDiaries = value; } }

        /// <summary>
        /// Метод для создания нового ежедневника.
        /// </summary>
        /// <param name="name">Название ежедневника</param>
        public bool CreateDiary(string name)
        {
            if (CheckValidName(name, PathToDiaries))
            {
                Diary newDiary = new Diary(name, DateTime.Now, DateTime.Now);
                return true;
            }

            return false;
        }

        public void ReadDiary()
        {

        }

        public void EditDiary()
        {

        }

        public void DeleteDiary()
        {

        }

        private static bool CheckValidName(string name, string pathToDiaries)
        {

            return true;
        }
    }
}
