using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataRetailDmQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingDataRetailDmQueryModel : AlipayObject
    {
        /// <summary>
        /// 内容ID，调用koubei.marketing.campaign.retail.dm.create创建内容时返回的内容ID
        /// </summary>
        [JsonProperty("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("shop_ids")]
        public List<string> ShopIds { get; set; }
    }
}
