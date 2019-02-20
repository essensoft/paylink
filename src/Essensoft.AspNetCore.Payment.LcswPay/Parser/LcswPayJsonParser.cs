using Newtonsoft.Json;
using System;

namespace Essensoft.AspNetCore.Payment.LcswPay.Parser
{
    /// <summary>
    /// 利楚商务扫呗支付json解析器
    /// </summary>
    /// <typeparam name="T">响应类型</typeparam>
    public class LcswPayJsonParser<T> : ILcswPayParser<T> where T : LcswPayResponse
    {
        public T Parse(string body)
        {
            if (string.IsNullOrWhiteSpace(body))
            {
                throw new ArgumentNullException(nameof(body));
            }
            var response = JsonConvert.DeserializeObject<T>(body);
            if(response != null)
            {
                response.Body = body;
            }
            return response;
        }
    }
}
