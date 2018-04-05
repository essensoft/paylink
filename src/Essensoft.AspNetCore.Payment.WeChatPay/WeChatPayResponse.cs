using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public abstract class WeChatPayResponse : WeChatPayObject
    {
        /// <summary>
        /// 原始内容
        /// </summary>
        [JsonIgnore]
        public string Body { get; set; }

        /// <summary>
        /// 原始参数
        /// </summary>
        [JsonIgnore]
        public WeChatPayDictionary Parameters { get; internal set; }
    }
}
