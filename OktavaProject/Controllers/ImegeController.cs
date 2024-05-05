

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using System.IO;


namespace OktavaProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImegeController : ControllerBase
    {
        [HttpPost]
        [Route("uploadImage")]
        public ActionResult UploadImage(IFormFile image)
        {
            var file = image;
            //var file = Request.Form.Files[0];
            //var folderPath = "your/image/folder/path";
            var folderPath = "C:\\Users\\yafit\\Documents\\react\\myoktavaproject\\public\\images";

            var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            var filePath = Path.Combine(folderPath, uniqueFileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            var imageUrl = "/images/" + uniqueFileName;

            return Ok(imageUrl);
        }
    }
}
