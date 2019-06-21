using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Homework_6
{
    struct Operations
    {
        public static void Start()
        {
            //DiaryDirectory root = new DiaryDirectory("My Diary", DirectoryRepository.GetRootDirectoryPath());
            
            DirectoryRepository dr = new DirectoryRepository();
            DirectoryInfo parent = dr.GetRootDirectoryInfo();
            DirectoryInfo root = parent.CreateSubdirectory("My Diary");
            //DirectoryInfo root2 = root.CreateSubdirectory("My Diary 2");

            Console.WriteLine(root.Root);
            /*if (dr.CreateNewDirectory(parent, "My Diary"))
            {
                Console.WriteLine("Создана главная директория ежедневника.");
            }*/


        }

        private void CreateDir()
        {

        }

        private static void PrintAllFiles(DiaryDirectory diaryDirectory)
        {

        }

        private static void PrintDiaries()
        {

        }
    }
}
