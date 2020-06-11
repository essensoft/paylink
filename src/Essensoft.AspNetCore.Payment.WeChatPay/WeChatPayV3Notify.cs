#if NETCOREAPP3_1

using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public abstract class WeChatPayV3Notify : WeChatPayObject
    {
        /// <summary>
        /// 原始内容
        /// </summary>
        [JsonIgnore]
        public string Body { get; set; }

        /// <summary>
        /// HTTP状态码
        /// </summary>
        [JsonIgnore]
        public int StatusCode { get; set; }
    }
}

#endif
