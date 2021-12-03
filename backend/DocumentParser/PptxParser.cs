using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using System.Text;

namespace DocumentParser
{
    /// <summary>
    /// pptx парсер.
    /// </summary>
    public class PptxParser : IParser
    {
        /// <summary>
        /// Получение текста файла.
        /// </summary>
        /// <param name="fileName">Путь к тексту файла.</param>
        /// <returns>Текст файла.</returns>
        public string GetString(string fileName)
        {
            using PresentationDocument presentationDocument = PresentationDocument.Open(fileName, false);

            return GetAllTextInSlide(presentationDocument);
        }

        /// <summary>
        /// Получение всего текста из презентации.
        /// </summary>
        /// <param name="presentationDocument">Слайд</param>
        /// <returns>Презентация.</returns>
        /// <exception cref="ArgumentNullException">Ссылка на презентацию null.</exception>
        private static string GetAllTextInSlide(PresentationDocument presentationDocument)
        {
            if (presentationDocument == null)
            {
                throw new ArgumentNullException(nameof(presentationDocument));
            }

            var presentationPart = presentationDocument.PresentationPart;

            if (presentationPart != null && presentationPart.Presentation != null)
            {
                var presentation = presentationPart.Presentation;

                if (presentation.SlideIdList != null)
                {
                    var slideIds = presentation.SlideIdList.ChildElements;

                    var text = new StringBuilder();

                    for (var currentSlide = 0; currentSlide < slideIds.Count; currentSlide++)
                    {
                        string slidePartRelationshipId = (slideIds[currentSlide] as SlideId).RelationshipId;

                        if(slidePartRelationshipId != null)
                        {
                            var slidePart = (SlidePart)presentationPart.GetPartById(slidePartRelationshipId);

                            var currentSlideText = GetAllTextInSlide(slidePart);

                            text.Append(currentSlideText + string.Empty);
                        }
                    }

                    return text.ToString();
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Получение всего текста со слайда.
        /// </summary>
        /// <param name="slidePart">Слайд.</param>
        /// <returns>Текст со слайда.</returns>
        /// <exception cref="ArgumentNullException">Ссылка на слайд null.</exception>
        private static string GetAllTextInSlide(SlidePart slidePart)
        {
            if (slidePart == null)
            {
                throw new ArgumentNullException(nameof(slidePart));
            }

            var slideText = new StringBuilder();

            if (slidePart.Slide != null)
            {
                foreach (var paragraph in slidePart.Slide.Descendants<Paragraph>())
                {                 
                    var paragraphText = new StringBuilder();

                    foreach (var text in paragraph.Descendants<DocumentFormat.OpenXml.Drawing.Text>())
                    {
                        paragraphText.Append(text.Text);
                    }

                    if (paragraphText.Length > 0)
                    {
                        slideText.Append(paragraphText.ToString());
                    }
                }
            }

            return slideText.ToString();
        }
    }
}
