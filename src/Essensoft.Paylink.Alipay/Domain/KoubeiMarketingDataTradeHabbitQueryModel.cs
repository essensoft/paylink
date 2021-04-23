using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingDataTradeHabbitQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingDataTradeHabbitQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务日期，格式：yyyyMMdd。
        /// </summary>
        [JsonPropertyName("biz_date")]
        public string BizDate { get; set; }

        /// <summary>
        /// 门店列表，多个门店用 ',' 分割，最多支持 10 个门店。不填时，默认为商户维度汇总数据。
        /// </summary>
        [JsonPropertyName("store_ids")]
        public string StoreIds { get; set; }
    }
}
