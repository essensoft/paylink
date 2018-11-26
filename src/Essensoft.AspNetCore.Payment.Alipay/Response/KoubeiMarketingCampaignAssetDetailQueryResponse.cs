using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignAssetDetailQueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignAssetDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 适用门店:门店与门店之间用“,”隔开，适用门店的意思：就是该资产只能在返回的门店中核销该资产。
        /// </summary>
        [JsonProperty("limit_shops")]
        [XmlElement("limit_shops")]
        public string LimitShops { get; set; }
    }
}
