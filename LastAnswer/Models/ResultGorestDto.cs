namespace LastAnswer.Models
{
    public class ResultGorestDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
    }
    // API'den dönen verileri JSON'dan C# nesnelerine dönüştüreceğimiz model
    public class UserListResponse
    {
        public List<ResultGorestDto> Data { get; set; }

    }
}
