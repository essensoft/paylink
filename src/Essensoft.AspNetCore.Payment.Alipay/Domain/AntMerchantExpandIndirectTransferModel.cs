using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectTransferModel Data Structure.
    /// </summary>
    public class AntMerchantExpandIndirectTransferModel : AlipayObject
    {
        /// <summary>
        /// 商户编号，由机构定义，需要保证在机构下唯一，与sub_merchant_id二选一
        /// </summary>
        [JsonPropertyName("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 商户在支付宝入驻成功后，生成的支付宝内全局唯一的商户编号，与external_id二选一
        /// </summary>
        [JsonPropertyName("sub_merchant_id")]
        public string SubMerchantId { get; set; }

        /// <summary>
        /// 商户转移目标的id，填银联或者网联的id
        /// </summary>
        [JsonPropertyName("transfer_target_id")]
        public string TransferTargetId { get; set; }
    }
}
