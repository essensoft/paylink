using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectZftorderQueryModel Data Structure.
    /// </summary>
    public class AntMerchantExpandIndirectZftorderQueryModel : AlipayObject
    {
        /// <summary>
        /// 进件申请时的外部商户id，与order_id二选一必填
        /// </summary>
        [JsonPropertyName("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 进件接口返回的申请单id。与external_id二选一必填。若都传以order_id的查询为准。
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }
}
