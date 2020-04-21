using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MarketingSelectionInfo Data Structure.
    /// </summary>
    public class MarketingSelectionInfo : AlipayObject
    {
        /// <summary>
        /// 指定营销列表
        /// </summary>
        [JsonPropertyName("selection_list")]
        public List<MarketingItemSelection> SelectionList { get; set; }

        /// <summary>
        /// 指定营销模式。AUTO:表示由系统决策最大优惠的模式。MANUAL:表示由外部指定的营销模式。模式为MANUAL时，指定营销券ID信息通过items_list传入，如果不传入表示不使用商户营销券（若有平台营销，仍然会返回）。若use_mode为空同时seleciont_list为空则表示不使用所有前置营销（包括商户营销券以及平台营销）
        /// </summary>
        [JsonPropertyName("use_mode")]
        public string UseMode { get; set; }
    }
}
