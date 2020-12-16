using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NotifyParam Data Structure.
    /// </summary>
    public class NotifyParam : AlipayObject
    {
        /// <summary>
        /// 消息push的内容，根据serviceCode对应的模版中的key进行值替换模版中的具体文案，格式为Map<String, String>转json
        /// </summary>
        [JsonPropertyName("params")]
        public string Params { get; set; }

        /// <summary>
        /// 消息push是否自动带出发消息者的个性化名称，个性化名称获取顺序为备注名>群昵称>全局昵称
        /// </summary>
        [JsonPropertyName("personal_name")]
        public bool PersonalName { get; set; }

        /// <summary>
        /// 消息push是否有短信类通知
        /// </summary>
        [JsonPropertyName("send_sms")]
        public bool SendSms { get; set; }

        /// <summary>
        /// 消息push的serviceCode，一个serviceCode在push平台对应一个模版，业务接入时如果要发非默认模版的push，需要自行申请，如果想发默认模版，请传： C2C：MOBILE_CHAT_NOTIFY_N C2B：MOBILE_CHAT_BC_TO_M_NOTIFY_N B2C：MOBILE_CHAT_BC_TO_C_NOTIFY_N
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }
    }
}
