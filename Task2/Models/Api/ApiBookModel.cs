using Microsoft.AspNetCore.Http;
using Task2.Models.Db;

namespace Task2.Models.Api
{
    public class ApiBookModel
    {
        public string? Name { get; set; }
        public string? Author { get; set; }
        public string? Description { get; set; }
        public int? PageCount { get; set; }
        public IFormFile? Image { get; set; }
        public DateTime? Date { get; set; }
    }
}
