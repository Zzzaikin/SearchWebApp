using System.Text;
using BitMiracle.Docotic.Pdf;

namespace DocumentParser
{
    /// <summary>
    /// PDF парсер
    /// </summary>
    public class PdfParser : IParser
    {
        /// <summary>
        /// Получение текста файла.
        /// </summary>
        /// <param name="fileName">Путь к тексту файла.</param>
        /// <returns>Текст файла.</returns>
        public string GetString(string fileName)
        {
            var documentText = new StringBuilder();

            using (var pdf = new PdfDocument(fileName))
            {
                for (int i = 0; i < pdf.PageCount; ++i)
                {
                    if (documentText.Length > 0)
                        documentText.Append("\r\n\r\n");

                    var page = pdf.Pages[i];
                    var searchableText = page.GetText();
                    if (!string.IsNullOrEmpty(searchableText.Trim()))
                    {
                        documentText.Append(searchableText);
                        continue;
                    }
                }
            }

            return documentText.ToString();
        }
    }
}
