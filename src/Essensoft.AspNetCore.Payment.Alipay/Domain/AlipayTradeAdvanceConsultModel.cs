using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeAdvanceConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeAdvanceConsultModel : AlipayObject
    {
        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonProperty("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 行业产品信息，咨询是，会从该产品对应的销售方案中获取相关垫资规则配置
        /// </summary>
        [JsonProperty("industry_product_code")]
        public string IndustryProductCode { get; set; }

        /// <summary>
        /// 子商户id
        /// </summary>
        [JsonProperty("sub_merchant_id")]
        public string SubMerchantId { get; set; }

        /// <summary>
        /// 子商户类型
        /// </summary>
        [JsonProperty("sub_merchant_type")]
        public string SubMerchantType { get; set; }
    }
}
