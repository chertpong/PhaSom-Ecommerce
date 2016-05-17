using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entity;
using Model.Repository;
using Model.Service;
using Moq;


namespace Web.Tests.Service
{
    [TestFixture]
    public class PostServiceTest
    {
        private Mock<IPostRepository> postRepository;
        private Post po1;
        private Post po2;
        private Post po3;
        private Post po4;




        [SetUp]
        public void SetUpPostMock()
        {
            po1 = new Post
            {
                Id = 1,
                Title = "News",
                Content = "Research",
                Thumbnail = "Pic.com",
                Tags = new List<string> { "News" },
                Pictures = new List<string> { "EiEI.com" },
                UpdatedTime = new DateTime(2016, 5, 16),
                CreatedTime = new DateTime(2016, 5, 16),
                Priority = 10
            };
            po2 = new Post
            {
                Id = 2,
                Title = "Activity",
                Content = "Help",
                Thumbnail = "Piccc.com",
                Tags = new List<string> { "News" },
                Pictures = new List<string> { "eeeeee.com" },
                UpdatedTime = new DateTime(2016, 5, 16),
                CreatedTime = new DateTime(2016, 5, 16),
                Priority = 8
            };
            po3 = new Post
            {
                Id = 3,
                Title = "Make Check Dam",
                Content = "Help",
                Thumbnail = "PPPPPP.com",
                Tags = new List<string> { "Activity" },
                Pictures = new List<string> { "EiEI.com" },
                UpdatedTime = new DateTime(2016, 5, 16),
                CreatedTime = new DateTime(2016, 5, 16),
                Priority = 6
            };
            po4 = new Post
            {
                Id = 4,
                Title = "Big Cleanning Day",
                Content = "Help",
                Thumbnail = "Picture.com",
                Tags = new List<string> { "Activity" },
                Pictures = new List<string> { "EiEI.com" },
                UpdatedTime = new DateTime(2016, 5, 16),
                CreatedTime = new DateTime(2016, 5, 16),
                Priority = 7
            };
            postRepository = new Mock<IPostRepository>();
            postRepository.Setup(repository => repository.GetAll()).Returns(new List<Post> { po1, po2, po3, po4 });
        }

        [Test]
        public void GetAllPost()
        {
            var service = new PostService(postRepository.Object);
            service.GetAll();
            postRepository.Verify(po => po.GetAll());
        }

        [Test]
        public void GetPostByIdShouldPass()
        {
            var service = new PostService(postRepository.Object);
            service.GetById(1);
            postRepository.Verify(po => po.GetById(1));
        }

        
        
        
        
        [Test]
        public void SearchPostByTitleTest()
        {
            var service = new PostService(postRepository.Object);
            CollectionAssert.AreEqual(new List<Post> { po4 },service.SearchPostByTitle("Big Cleanning Day"));
            //CollectionAssert.AreEqual(new List<Post> { po2 }, service.SearchPostByTitle("Activity"));
        }
        [Test]
        public void TestGetAllSortedByPriority()
        {
            var service = new PostService(postRepository.Object);
            CollectionAssert.AreEqual(new List<Post> {po3,po4,po2,po1}, service.GetAllSortedByPriority());
        }

        [Test]
        public void CreatePost()
        {
            var service = new PostService(postRepository.Object);
            Post po5 = new Post
            {
                Id = 5,
                Title = "Weather Report",
                Content = "Let to Know",
                Thumbnail = "Picture.com",
                Tags = new List<string> { "News" },
                Pictures = new List<string> { "Weather.com" },
                UpdatedTime = new DateTime(2016, 5, 16),
                CreatedTime = new DateTime(2016, 5, 16),
                Priority = 4
            };
            service.CreatePost(po5);
            postRepository.Verify(po => po.Create(po5));
        }
        [Test]
        public void UpdatePost()
        {
            var service = new PostService(postRepository.Object);
            Post po3 = new Post
            {
                Id = 3,
                Title = "Make Check Dam",
                Content = "Help",
                Thumbnail = "PPPPPP.com",
                Tags = new List<string> { "Activity" },
                Pictures = new List<string> { "EiEI.com" },
                UpdatedTime = new DateTime(2016, 5, 16),
                CreatedTime = new DateTime(2016, 5, 16),
                Priority = 9
            };
            service.UpdatePost(po3);
            postRepository.Verify(po => po.Update(po3));
        }
        [Test]
        public void DetelePost()
        {
            var service = new PostService(postRepository.Object);
            service.DetelePost(2);
            postRepository.Verify(po => po.Delete(2));

        }
        

        


    }
}
