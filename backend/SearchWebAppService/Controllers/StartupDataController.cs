using Microsoft.AspNetCore.Mvc;
using Models;

namespace SearchWebAppService.Controllers
{
    /// <summary>
    /// Контроллер, осуществляющий доступ к данным
    /// </summary>
    public class StartupDataController : ControllerBase, IStartupDataController
    {
        /// <summary>
        /// Добавляет стартап в базу данных.
        /// </summary>
        /// <param name="startup">Стартап.</param>
        /// <returns>Результат работы метода.</returns>
        [HttpGet("CreateStartup")]
        public IActionResult CreateStartup(Startup startup)
        {
            using var db = new DataBaseContext();
            db.Startups.Add(startup);
            return Ok();
        }

        /// <summary>
        /// Удаляет стартап из базы данных.
        /// </summary>
        /// <param name="id">Id стартапа.</param>
        /// <returns>Результат работы метода.</returns>
        [HttpGet("DeleteStartupById")]
        public IActionResult DeleteStartupById(Guid id)
        {
            using var db = new DataBaseContext();
            var startup = db.Startups.FirstOrDefault(x => x.Id == id);

            if(startup != null)
            {
                db.Startups.Remove(startup);
            }

            return Ok();
        }

        /// <summary>
        /// Получение стартапа по его Id.
        /// </summary>
        /// <param name="id">Id стартапа.</param>
        /// <returns>Запрашиваемый стартап.</returns>
        [HttpGet("GetStartupById")]
        public IActionResult GetStartupById(Guid id)
        {
            using var db = new DataBaseContext();
            var startup = db.Startups.FirstOrDefault(x => x.Id == id);

            return Ok(startup);
        }

        /// <summary>
        /// Обновление стартапа по его Id.
        /// </summary>
        /// <param name="id">Id стартапа.</param>
        /// <param name="startup">Стартап.</param>
        /// <returns>Результат работы метода.</returns>
        [HttpGet("UpdateStartupById")]
        public IActionResult UpdateStartupById(Guid id, Startup startup)
        {
            using var db = new DataBaseContext();
            var oldStartup = db.Startups.FirstOrDefault(x => x.Id == id);

            if (oldStartup != null)
            {
                db.Startups.Remove(oldStartup);
                db.Startups.Add(startup);
            }

            return Ok();
        }

        /// <summary>
        /// Плучение отфильтрованных стартапов.
        /// </summary>
        /// <param name="filter">Фильтр.</param>
        /// <returns>Отфильтрованные данные.</returns>
        [HttpGet("GetStartupByFilter")]
        public IActionResult GetStartupByFilter(Filter filter)
        {
            return Ok(ApplyFilter(filter));
        }
    }
}
