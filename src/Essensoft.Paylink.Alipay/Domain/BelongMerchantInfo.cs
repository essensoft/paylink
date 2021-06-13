using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BelongMerchantInfo Data Structure.
    /// </summary>
    public class BelongMerchantInfo : AlipayObject
    {
        /// <summary>
        /// 商户id
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户id类型。  枚举值： SMID  特别说明： 如果merchant_id_type选择SMID。则表明当前商家券活动的归属者是该SMID所绑定的支付宝PID。 因此要求该SMID必须绑定相应的支付宝PID。
        /// </summary>
        [JsonPropertyName("merchant_id_type")]
        public string MerchantIdType { get; set; }
    }
}
