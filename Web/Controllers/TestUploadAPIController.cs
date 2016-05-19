using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Model.Service;

namespace Web.Controllers
{
    public class TestUploadAPIController : ApiController
    {
        UploadPictureService test = new UploadPictureService();

        public void upload(HttpPostedFileBase file)
        {
             test.UploadPicture(file);
        }
    }
}
