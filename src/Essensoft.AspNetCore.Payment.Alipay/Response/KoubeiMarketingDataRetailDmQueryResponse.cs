using System.Collections.Generic;
using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingDataRetailDmQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataRetailDmQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 内容ID
        /// </summary>
        [JsonProperty("content_id")]
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 店面DM营销数据，包括商品的PV、UV、曝光。
        /// </summary>
        [JsonProperty("dm_marketing_datas")]
        [XmlArray("dm_marketing_datas")]
        [XmlArrayItem("dm_activity_shop_data")]
        public List<DmActivityShopData> DmMarketingDatas { get; set; }

        /// <summary>
        /// 商品码
        /// </summary>
        [JsonProperty("item_code")]
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonProperty("item_name")]
        [XmlElement("item_name")]
        public string ItemName { get; set; }
    }
}
