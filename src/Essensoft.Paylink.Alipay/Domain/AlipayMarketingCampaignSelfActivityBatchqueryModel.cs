using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignSelfActivityBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignSelfActivityBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 是否需要券核销范围信息（包括pid列表、门店id列表和小程序appid列表，由于字段可能较大默认不返回，业务方也请慎用。pid列表:PID，门店id列表:SHOP_ID，小程序appid列表:APP_ID）
        /// </summary>
        [JsonPropertyName("need_use_scope_info")]
        public List<string> NeedUseScopeInfo { get; set; }

        /// <summary>
        /// 分页查询的当前页号，从1开始（默认1）
        /// </summary>
        [JsonPropertyName("page_number")]
        public string PageNumber { get; set; }

        /// <summary>
        /// 分页查询的单页活动数量，不大于20（默认10）
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 场景码：默认(DEFAULT)
        /// </summary>
        [JsonPropertyName("scene_code")]
        public List<string> SceneCode { get; set; }
    }
}
