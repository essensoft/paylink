using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public abstract class WeChatPayV3Response : WeChatPayObject
    {
        /// <summary>
        /// 原始内容
        /// </summary>
        [JsonIgnore]
        public string Body { get; set; }
    }
}
