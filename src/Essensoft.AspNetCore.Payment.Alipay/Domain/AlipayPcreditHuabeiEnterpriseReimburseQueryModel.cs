using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiEnterpriseReimburseQueryModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiEnterpriseReimburseQueryModel : AlipayObject
    {
        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 获取数据的code，在消息发送时会带出
        /// </summary>
        [JsonPropertyName("record_code")]
        public string RecordCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
