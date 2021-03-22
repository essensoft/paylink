using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignPromotionvoucherConsumerviewBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignPromotionvoucherConsumerviewBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 单品id列表, 单品券场景返回货品信息. 最大支持5个条形码
        /// </summary>
        [JsonPropertyName("goods_ids")]
        public List<string> GoodsIds { get; set; }

        /// <summary>
        /// 忽略不可用的券(已过期、已使用)
        /// </summary>
        [JsonPropertyName("ignore_disabled_voucher")]
        public string IgnoreDisabledVoucher { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [JsonPropertyName("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 是否只查询当前ISV报名的活动
        /// </summary>
        [JsonPropertyName("only_current_isv")]
        public bool OnlyCurrentIsv { get; set; }
    }
}
