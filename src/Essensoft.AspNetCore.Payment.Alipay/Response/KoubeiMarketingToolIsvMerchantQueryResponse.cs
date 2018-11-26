using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingToolIsvMerchantQueryResponse.
    /// </summary>
    public class KoubeiMarketingToolIsvMerchantQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商户信息列表
        /// </summary>
        [JsonProperty("merchant_infos")]
        [XmlArray("merchant_infos")]
        [XmlArrayItem("isv_merchant_info")]
        public List<IsvMerchantInfo> MerchantInfos { get; set; }

        /// <summary>
        /// 门店总量
        /// </summary>
        [JsonProperty("shop_count")]
        [XmlElement("shop_count")]
        public string ShopCount { get; set; }

        /// <summary>
        /// 门店详情列表信息
        /// </summary>
        [JsonProperty("shop_summary_infos")]
        [XmlArray("shop_summary_infos")]
        [XmlArrayItem("shop_summary_info")]
        public List<ShopSummaryInfo> ShopSummaryInfos { get; set; }
    }
}
