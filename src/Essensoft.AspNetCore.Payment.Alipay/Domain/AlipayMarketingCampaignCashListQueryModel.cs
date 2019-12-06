using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignCashListQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignCashListQueryModel : AlipayObject
    {
        /// <summary>
        /// 要查询的活动状态,不填默认返回所有类型。  可填:  ALL:所有类型的活动  CREATED: 已创建未打款  PAID:已打款  READY:活动已开始  PAUSE:活动已暂停  CLOSED:活动已结束  SETTLE:活动已清算
        /// </summary>
        [JsonPropertyName("camp_status")]
        public string CampStatus { get; set; }

        /// <summary>
        /// 分页查询时的页码，从1开始
        /// </summary>
        [JsonPropertyName("page_index")]
        public string PageIndex { get; set; }

        /// <summary>
        /// 分页查询时每页返回的列表大小,最大为50
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }
    }
}
