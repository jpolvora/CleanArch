namespace CleanArch.Infra
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; } = null!;

        public List<Post> Posts { get; } = new();
    }
}
