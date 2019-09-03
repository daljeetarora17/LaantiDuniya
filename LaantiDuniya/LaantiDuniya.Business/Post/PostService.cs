using LaantiDuniya.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaantiDuniya.Business.Post
{
    public class PostService : IPostService
    {
        public async void AddPost(PostModel postModel)
        {
            TblPost tblPost = new TblPost
            {
                Title = postModel.Title,
                CreatedDate = postModel.CreatedDate,
                Description = postModel.Description,
                IsActive = postModel.IsActive,
                IsDeleted = postModel.IsDeleted,
                ModifiedDate = postModel.ModifiedDate,
                Tags = postModel.Tags
            };

            using (LaantiDuniyaContext dbContext = new LaantiDuniyaContext())
            {
                dbContext.TblPost.Add(tblPost);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
