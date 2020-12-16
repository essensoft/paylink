using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantShopcodeCategoryQueryModel Data Structure.
    /// </summary>
    public class AlipayMerchantShopcodeCategoryQueryModel : AlipayObject
    {
        /// <summary>
        /// 请求流水号，调用者可自定义传入，平台仅作为请求调用记录
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
