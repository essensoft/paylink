using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BaseInfoConfig Data Structure.
    /// </summary>
    public class BaseInfoConfig : AlipayObject
    {
        /// <summary>
        /// 商户联系人邮箱，需为合法的邮箱。
        /// </summary>
        [JsonPropertyName("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 商户联系人电话，需为合法的电话号码。
        /// </summary>
        [JsonPropertyName("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 信用服务logo地址，为必传字段，需为合法的链接。
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 信用服务名称，为必传字段。
        /// </summary>
        [JsonPropertyName("service_name")]
        public string ServiceName { get; set; }
    }
}
