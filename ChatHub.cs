
namespace SharingTextWebApi
{
    //static class for collaboration
    public static class ChatHub
    {

        private static List<UserMessages> messages = new List<UserMessages>();
        
        public static string GetTextFromTime(DateTime loginT )
        {

            return String.Join("</br>", messages.Where(x => x.sendingTime > loginT).Select(x=>x.username+": "+x.message));

        }

        public static  void PublishText(string text, string userid)
        {
            messages.Add(new UserMessages
            {
                username = userid,
                sendingTime = DateTime.Now,
                message = text
            });
        }
    }
}
