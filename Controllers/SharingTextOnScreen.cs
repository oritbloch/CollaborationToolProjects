using Microsoft.AspNetCore.Mvc;


namespace SharingTextWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SharingTextOnScreen : ControllerBase
    {
        

        private readonly ILogger<SharingTextOnScreen> _logger;
        


        public SharingTextOnScreen(ILogger<SharingTextOnScreen> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route ("GetSharedText")]
        public string Get(string dateTime)
        {
            
           return ChatHub.GetTextFromTime(Convert.ToDateTime(dateTime));
        }

        [HttpGet]
        [Route("SaveTextFromUser")]
        public string Save(string txt,string userid)
        {
            try
            {
                ChatHub.PublishText(txt, userid);
                return "";
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}