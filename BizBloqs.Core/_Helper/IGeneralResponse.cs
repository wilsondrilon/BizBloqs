namespace BizBloqs.Core._Helper
{
    public interface IGeneralResponse
    {
        GeneralModel Response(dynamic data, int statusCode, string message, bool isSuccessful);
    }
}