using System.Text;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;

namespace DocumentParser
{
    /// <summary>
    /// word парсер.
    /// </summary>
    public class WordParser : IParser
    {
        /// <summary>
        /// Получение текста файла.
        /// </summary>
        /// <param name="fileName">Путь к тексту файла.</param>
        /// <returns>Текст файла.</returns>
        public string GetString(string fileName)
        {
            using var wordDocument = WordprocessingDocument.Open(fileName, false);

            return GetPlainText(wordDocument.MainDocumentPart.Document.Body);
        }

        /// <summary>
        /// Получение текста с файла.
        /// </summary>
        /// <param name="element">Файл.</param>
        /// <returns></returns>
        private static string GetPlainText(OpenXmlElement element)
        {
            var text = new StringBuilder();
            foreach (var section in element.Elements())
            {
                switch (section.LocalName)
                {
                    // Text 
                    case "t":
                        text.Append(section.InnerText);
                        break;
                    case "cr":                           
                    case "br":                           
                        text.Append(Environment.NewLine);
                        break;
                    // Tab 
                    case "tab":
                        text.Append("\t");
                        break;
                    // Paragraph 
                    case "p":
                        text.Append(GetPlainText(section));
                        text.AppendLine(Environment.NewLine);
                        break;
                    default:
                        text.Append(GetPlainText(section));
                        break;
                }
            }
            return text.ToString();
        }

    }
}
 
