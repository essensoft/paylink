using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BelongMerchantInfo Data Structure.
    /// </summary>
    public class BelongMerchantInfo : AlipayObject
    {
        /// <summary>
        /// 合作业务类型,默认为ISV_FOR_MERCHANT  枚举值: ISV 服务商平台模式 ISV_FOR_MERCHANT 服务商代运营模式
        /// </summary>
        [JsonPropertyName("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 商户id  限制: 服务商代运营模式必传
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户id类型。  枚举值： SMID 间连SMID PID    直连PID   特别说明： 如果merchant_id_type选择SMID。则表明当前商家券活动的归属者是该SMID所绑定的支付宝PID。 因此要求该SMID必须绑定相应的支付宝PID。  限制: 服务商代运营模式必传
        /// </summary>
        [JsonPropertyName("merchant_id_type")]
        public string MerchantIdType { get; set; }
    }
}
