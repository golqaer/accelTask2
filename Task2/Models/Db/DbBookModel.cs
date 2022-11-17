using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Task2.Models.Db
{
    public class DbBookModel
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Название книги
        /// </summary>
        public string? Name { get; set; }
        
        /// <summary>
        /// Автор книги
        /// </summary>
        public string? Author { get; set; }

        /// <summary>
        /// Название изображения обложки книги
        /// </summary>
        public string? CoverFileName { get; set; }

        /// <summary>
        /// Описание книги
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Кол-во страниц
        /// </summary>
        public int? PageCount { get; set; }

        /// <summary>
        /// Дата выхода книги
        /// </summary>
        public DateTime? Date { get; set; }
    }
}
