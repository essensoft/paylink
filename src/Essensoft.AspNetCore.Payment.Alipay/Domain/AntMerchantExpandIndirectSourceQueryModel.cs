using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectSourceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectSourceQueryModel : AlipayObject
    {
        /// <summary>
        /// 商户在支付宝入驻成功后，生成的支付宝内全局唯一的商户编号
        /// </summary>
        [JsonProperty("sub_merchant_id")]
        public string SubMerchantId { get; set; }
    }
}
