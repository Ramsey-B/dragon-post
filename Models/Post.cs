namespace dragon_post.Models
{
  public class Post 
  {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public string AuthorId { get; set; }

    public Post(string title, string body, string authorId)
    {
        Title = title;
        Body = body;
        AuthorId = authorId;
    }
  }
}