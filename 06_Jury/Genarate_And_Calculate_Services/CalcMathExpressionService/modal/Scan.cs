﻿using System.IO;
using System.Text;
using Common;

namespace CalcMathExpressionService.modal
{
    internal static class Scan
    {
        // папка для сканирования
        private static readonly string FolderToScan =
            Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
            + @"\files\Tocount\";

        // папка для записи результата
        private static readonly string FolderResult =
            Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
            + @"\files\Result\";

        // папка для перемещения решенных примеров
        private static readonly string FolderCompleted =
            Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
            + @"\files\Completed\";

        private static void CreateFolders()
        {
            // создание директорий, если не существуют
            Directory.CreateDirectory(FolderToScan);
            Directory.CreateDirectory(FolderResult);
            Directory.CreateDirectory(FolderCompleted);
        }

        public static void StartCalculation()
        {
            CreateFolders();
            var scanResult = ScanFolder(); // сканирование директории FolderToScan 
            foreach (var pathfile in scanResult) // цикл для перебора найденных файлов
            {
                // Получение имени файла для дальнейшей записи файла з результатом
                var fileName = Path.GetFileName(pathfile);
                Logger.Write(Level.Info, $"Файл {fileName}");
                var count = 1;

                if (File.Exists(FolderResult + $"Result of {fileName}"))
                    File.Delete(FolderResult + $"Result of {fileName}");

                var result = new StringBuilder(); // запись в стрингбилдер обработки файла

                foreach (var textInFile in File.ReadLines(pathfile)) // цикл для считывания файла
                {
                    var separator = new Separator(textInFile);     // отправка в сепаратор для решения
                    result.Append(textInFile + " = " + separator.WriteOut()).AppendLine();    // результат 
                    Logger.Write(Level.Info, $"Выражение {count++}: {textInFile}. Решение:");
                }
                File.WriteAllText(FolderResult + $"Result of {fileName}", $"{result}"); // запись в папку FolderResult
                // перемещение отработаных файлов в папку FolderCompleted
                if (File.Exists(FolderCompleted + fileName))
                    File.Delete(FolderCompleted + fileName);
                File.Move(pathfile, FolderCompleted + fileName);
            }
        }

        private static string[] ScanFolder()
        {
            // поиск файлов с расширением txt
            var scanResult = Directory.GetFiles(FolderToScan, "*.txt");
            if (scanResult.Length != 0)
            {
                Logger.Write(Level.Info, $"Обнаружены файлы в рабочей папке. Найдено {scanResult.Length} файлов.");
            }
            Logger.Write(Level.Error,"В рабочей папке нет файлов.");
            return scanResult;
        }
    }
}
