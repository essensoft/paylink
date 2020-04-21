using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCardQueryResponse.
    /// </summary>
    public class AlipayMarketingCardQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商户卡信息
        /// </summary>
        [JsonPropertyName("card_info")]
        public MerchantCard CardInfo { get; set; }

        /// <summary>
        /// 商户会员卡页面跳转到支付宝卡券详情页的pass_id，对应schema地址中的参数p，  主要用于小程序跳往会员卡详情的链接拼接
        /// </summary>
        [JsonPropertyName("pass_id")]
        public string PassId { get; set; }

        /// <summary>
        /// 商户会员卡页面跳转到支付宝卡券详情页面的schema地址
        /// </summary>
        [JsonPropertyName("schema_url")]
        public string SchemaUrl { get; set; }
    }
}
