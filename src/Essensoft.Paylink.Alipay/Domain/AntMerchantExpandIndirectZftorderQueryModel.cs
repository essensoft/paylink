using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
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
        /// 申请单id。通过 ant.merchant.expand.indirect.zft.create(直付通二级商户创建)接口返回。与 external_id 二选一必填，若同时传入将以 order_id 为准进行查询。
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }
}
