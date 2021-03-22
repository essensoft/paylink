using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ActivityVoucherInfo Data Structure.
    /// </summary>
    public class ActivityVoucherInfo : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [JsonPropertyName("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动状态： 草稿(INIT),已提交审核(P_AUDIT),已审核(AUDIT),待激活(WAIT_ACTIVE),激活(ACTIVE),暂停(PAUSE),已结束(FINISHED),已废弃(DISCARD)
        /// </summary>
        [JsonPropertyName("activity_status")]
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 商户logo
        /// </summary>
        [JsonPropertyName("merchant_logo")]
        public string MerchantLogo { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 券列表
        /// </summary>
        [JsonPropertyName("voucher_list")]
        public List<VoucherItem> VoucherList { get; set; }
    }
}
