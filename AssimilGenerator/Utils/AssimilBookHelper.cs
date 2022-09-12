using Assimil;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AssimilGenerator.Utils
{
    public static class AssimilBook
    {

        public static void Generate(string path)
        {
            DeletePrevFiles(path);
            CreateHtmlFiles(Units(path), path);
            CopyAudioCssImagesToResultFolder(path);
        }


        #region Private Methods

        private static void CopyAudioCssImagesToResultFolder(string folderName)
        {
            string sourceDirName = $@"..\..\..\Assimil\{folderName}\content";
            string destDirName = $@".\{folderName}\content";
            FileSystem.CopyDirectory(sourceDirName, destDirName);
        }

        private static void DeletePrevFiles(string folderName)
        {
            if (Directory.Exists(folderName))
            {
                DirectoryInfo directory = new DirectoryInfo(folderName);

                foreach (FileInfo file in directory.EnumerateFiles())
                {
                    file.Delete();
                }

                foreach (DirectoryInfo dir in directory.EnumerateDirectories())
                {
                    dir.Delete(true);
                }
            }
        }

        private static void CreateHtmlFiles(IEnumerable<LessonBase> units, string folderPath)
        {
            foreach (var unit in units)
            {
                unit.AddHtmlFileToFolder(folderPath);
            }
        }

        private static IEnumerable<Type> FindSubClassesOf<TBaseType>(string namespaceName) =>
             typeof(TBaseType)
                        .Assembly
                        .GetTypes()
                        .Where(t => t.IsSubclassOf(typeof(TBaseType)))
                        .Where(t => t.Namespace.Contains(namespaceName));


        private static IEnumerable<LessonBase> Units(string path) =>
             FindSubClassesOf<LessonBase>(path)
                .Select(type => (LessonBase)Activator.CreateInstance(type));

        #endregion 

    }
}