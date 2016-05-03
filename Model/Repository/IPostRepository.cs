using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Model.Entity;

namespace Model.Repository
{
    public interface IPostRepository : IDisposable
    {
        List<Post> GetAll();
        Post GetPostById(int id);
        void CreatePost(Post post);
        void UpdatePost(Post post);
        void DeletePost(int id);

        List<Post> Find(Expression<Func<Post, bool>> predicate);
    }
}