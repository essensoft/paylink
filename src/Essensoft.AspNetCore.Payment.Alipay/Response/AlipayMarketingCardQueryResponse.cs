using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

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
        [JsonProperty("card_info")]
        [XmlElement("card_info")]
        public MerchantCard CardInfo { get; set; }

        /// <summary>
        /// 商户会员卡页面跳转到支付宝卡券详情页面的schema地址
        /// </summary>
        [JsonProperty("schema_url")]
        [XmlElement("schema_url")]
        public string SchemaUrl { get; set; }
    }
}
