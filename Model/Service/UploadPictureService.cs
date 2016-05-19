using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using NUnit.Engine.Internal;

namespace Model.Service
{
   public class UploadPictureService
    {
       public void UploadPicture(HttpPostedFileBase file)
       {
           if (file != null && file.ContentLength > 0)
           {

               String timestamp = DateTime.Now.ToString("HH:mm:ss.fff",
                   System.Globalization.DateTimeFormatInfo.InvariantInfo);
               String name = file.FileName + timestamp;
               String ext = Path.GetExtension(file.FileName);
               String fname = name.GetHashCode().ToString() + ext;

               string path = Path.Combine(Server("~/Images"), fname);
               file.SaveAs(path);

           }


       }
    }
}
