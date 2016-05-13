using System.Collections.Generic;
using System.Linq;
using Model.Entity;
using Model.Repository;

namespace Model.Service
{
    public class PostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            this._postRepository = postRepository;
        }

        public List<Post> GetAll()
        {
            return _postRepository.GetAll();
        }

        public Post GetById(int Id)
        {
            return _postRepository.GetPostById(Id);
        }

        public void CreatePost(Post post)
        {
            _postRepository.CreatePost(post);
        }

        public void UpdatePost(Post post)
        {
            _postRepository.UpdatePost(post);
        }

        public void DetelePost(int Id)
        {
            _postRepository.DeletePost(Id);
        }

        public List<Post> SearchPostByTitle(string title)
        {
            return _postRepository.Find(post => title.Contains(title));
        }

        public List<Post> GetAllSortedByPriority()
        {
            return _postRepository.GetAll().OrderBy(post => post.Priority).ToList();
        }
    }
}