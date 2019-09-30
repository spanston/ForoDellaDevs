using ForoDellaDevs.Models.Forum;

namespace ForoDellaDevs.Models.Post
{
    public class PostListingModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int AuthorRating { get; set; }
        public string AuthorId { get; set; }//identity will generate string/guid
        public string DatePosted { get; set; }

        public ForumListingModel Forum { get; set; }
        public int RepliesCount { get; set; }
    }

}
