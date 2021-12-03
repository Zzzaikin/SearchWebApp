namespace DocumentParser
{
    /// <summary>
    /// Интерфейс для парсеров.
    /// </summary>
    public interface IParser
    {
        /// <summary>
        /// Получение текста файла.
        /// </summary>
        /// <param name="fileName">Путь к тексту файла.</param>
        /// <returns>Текст файла.</returns>
        public string GetString(string fileName);
    }
}
