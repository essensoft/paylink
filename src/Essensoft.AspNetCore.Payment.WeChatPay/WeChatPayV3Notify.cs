#if NETCOREAPP3_1

using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.WeChatPay.Domain;

namespace Essensoft.AspNetCore.Payment.WeChatPay
{
    public abstract class WeChatPayV3Notify : WeChatPayObject
    {
        /// <summary>
        /// 通知原始内容
        /// </summary>
        [JsonIgnore]
        public string Body { get; set; }

        /// <summary>
        /// 通知密文
        /// </summary>
        [JsonIgnore]
        public NotifyCiphertext NotifyCiphertext { get; set; }

        /// <summary>
        /// 通知明文内容
        /// </summary>
        [JsonIgnore]
        public string ResourcePlaintext { get; set; }
    }
}

#endif
