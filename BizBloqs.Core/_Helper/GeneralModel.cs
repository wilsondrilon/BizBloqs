namespace BizBloqs.Core._Helper
{
    public class GeneralModel
    {
        public bool isSuccessful { get; set; }
        public int statusCode { get; set; }
        public string message { get; set; }
        public dynamic data { get; set; }
    }
}