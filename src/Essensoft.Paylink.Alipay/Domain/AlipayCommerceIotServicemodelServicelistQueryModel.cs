using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotServicemodelServicelistQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotServicemodelServicelistQueryModel : AlipayObject
    {
        /// <summary>
        /// 服务的类型，如播报服务（service_voice），打印服务（service_print）
        /// </summary>
        [JsonPropertyName("service_key")]
        public string ServiceKey { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
