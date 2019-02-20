using System.Text;

namespace Essensoft.AspNetCore.Payment.LcswPay.Utility
{
    /// <summary>
    /// 字符串扩展函数
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// 将apiUrl转换为完整的地址
        /// </summary>
        /// <param name="apiUrl">请求返回的api url</param>
        /// <param name="baseUrl">基本地址</param>
        /// <returns>完整的请求地址</returns>
        public static string ToFullApiUrl(this string apiUrl,string baseUrl)
        {
            //如果apiurl本身就是完整的，以http开头的则直接返回
            if (apiUrl.StartsWith("http"))
            {
                return apiUrl;
            }
            bool apiUrlHasSplit = apiUrl.StartsWith('/');
            bool baseUrlHasSplit = baseUrl.EndsWith('/');
            var result = new StringBuilder();
            result.Append(baseUrl);
            //如果都没有/，则需要增加一个进行分隔
            if (!baseUrlHasSplit && !apiUrlHasSplit)
            {
                result.Append('/');
            }
            //如果基本地址以/结尾，而apiurl以/开头，则需要去掉一个
            else if (baseUrlHasSplit && apiUrlHasSplit)
            {
                apiUrl = apiUrl.Substring(1);
            }
            result.Append(apiUrl);
            return result.ToString();
        }
    }
}
