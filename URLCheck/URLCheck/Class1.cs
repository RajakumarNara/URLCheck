using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
namespace URLCheck
{
    public class Class1
    {
        //string url;
        //void getURL(string _url)
        //{
        //    this.url = _url;
        //}
        public string processURL(string url)
        {
            try
            {
                //Creating the HttpWebRequest
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                //Setting the Request method HEAD, you can also use GET too.
                request.Method = "HEAD";
                //Getting the Web Response.
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                //Returns TRUE if the Status code == 200
                response.Close();
                return (response.StatusCode).ToString();
            }
            catch(Exception ex)
            {
                //Any exception will returns false.
                return ex.Message.ToString();
            }           
        }

       

    }
}
