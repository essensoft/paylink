using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataTradeHabbitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataTradeHabbitQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务日期
        /// </summary>
        [JsonProperty("biz_date")]
        [XmlElement("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 门店列表,门店用逗号分割，最多支持10个门店。  不填时,则为商户维度汇总数据
        /// </summary>
        [JsonProperty("store_ids")]
        [XmlElement("store_ids")]
        public string StoreIds { get; set; }
    }
}
