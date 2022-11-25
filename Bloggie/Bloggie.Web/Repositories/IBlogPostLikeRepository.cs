namespace Bloggie.Web.Repositories
{
    public interface IBlogPostLikeRepository
    {
        Task<int> GetTotalLikesForBlog(Guid blogId);

        Task AddLikeForBlog(Guid blogPostId, Guid userId);
    }
}
