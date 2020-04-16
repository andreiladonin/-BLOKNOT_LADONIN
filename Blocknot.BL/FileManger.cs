using System.Text;
using System.IO;

namespace Blocknot.BL
{
    public interface IFileMamger
    {
        bool IsExit(string filepath);
        string GetContent(string filePath);
        string GetContent(string filePath, Encoding encoding);
        void SaveContent(string content, string filePath);

        void SaveContent(string content, string filePath, Encoding encoding);
        int GetSymbolCount(string content);

    }



    public class FileManger: IFileMamger
    {
        private readonly Encoding _defaultEncoding = Encoding.GetEncoding(1251);

        // проверка сущестовование файла
        public bool  IsExit (string filepath)
        {
            bool isExit = File.Exists(filepath);
            return isExit;
        }



        // получаем файл
        public string GetContent(string filePath)
        {
            return GetContent(filePath, _defaultEncoding); // перегруженный метод 
        }
        public string GetContent(string filePath, Encoding encoding)
        {
            string content = File.ReadAllText(filePath, encoding);// получение файла с кодировкой

            return content;
        }

        // СОХРАНЕИНЕ
        public void SaveContent(string content, string filePath)
        {
            SaveContent(content, filePath, _defaultEncoding);
        } 

        public void SaveContent(string content, string filePath, Encoding encoding)
        {
            File.WriteAllText(filePath, content, encoding);
        }

        // длина символов подсчет
        public int GetSymbolCount(string content)
        {
            int count = content.Length;
            return count;
        }
    }
}
