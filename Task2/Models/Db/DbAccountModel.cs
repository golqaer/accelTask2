namespace Task2.Models.Db
{
    public class DbAccountModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
