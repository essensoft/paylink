using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityCreateModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignItemMerchantactivityCreateModel : AlipayObject
    {
        /// <summary>
        /// 活动优惠次数限制  活动优惠总次数限制不能小于1,且不能为不限制  活动优惠总次数限制不能大于99999999
        /// </summary>
        [JsonPropertyName("count_limit")]
        public long CountLimit { get; set; }

        /// <summary>
        /// 活动优惠单日次数限制  0表示不限制  活动优惠单日次数限制不能为负数  活动优惠单日次数限制不能大于99999999
        /// </summary>
        [JsonPropertyName("count_limit_per_day")]
        public long CountLimitPerDay { get; set; }

        /// <summary>
        /// 活动单用户限次  0表示不限制  活动单用户总限次不能为负数  活动单用户总限次不能大于999
        /// </summary>
        [JsonPropertyName("count_limit_per_user")]
        public long CountLimitPerUser { get; set; }

        /// <summary>
        /// 活动单用户单日限次  0表示不限制  活动单用户单日限次不能为负数  活动单用户单日限次不能大于999
        /// </summary>
        [JsonPropertyName("count_limit_per_user_per_day")]
        public long CountLimitPerUserPerDay { get; set; }

        /// <summary>
        /// 人群规则：  DEFAULT： 全部用户  ONLINE_NEWCOMER：在线购买新人  MEMBER：会员
        /// </summary>
        [JsonPropertyName("crowd")]
        public string Crowd { get; set; }

        /// <summary>
        /// 代金券面额  代金券面额 单位为元  代金券面额格式必须为#.##  代金券面额需小于49999
        /// </summary>
        [JsonPropertyName("deduct_amount")]
        public string DeductAmount { get; set; }

        /// <summary>
        /// 外部回调地址  外部回调地址最大字符数不能超过500
        /// </summary>
        [JsonPropertyName("external_callback_url")]
        public string ExternalCallbackUrl { get; set; }

        /// <summary>
        /// 外部Id  最大长度不能超过64  最小长度不能低于13
        /// </summary>
        [JsonPropertyName("external_unique_id")]
        public string ExternalUniqueId { get; set; }

        /// <summary>
        /// 活动结束时间  格式必须为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 活动开始时间  格式必须为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 商品列表  参加活动的商品列表不能为空  参加活动的商品列表最大个数不能超过100
        /// </summary>
        [JsonPropertyName("item_ids")]
        public List<string> ItemIds { get; set; }

        /// <summary>
        /// 备注  备注最大字符数不能超过500
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 使用门槛，满X元可用，使用门槛必须大于券面额  使用门槛单位为元  使用门槛格式必须为#.##
        /// </summary>
        [JsonPropertyName("min_cost")]
        public string MinCost { get; set; }

        /// <summary>
        /// 是否手动领取，本期只支持true
        /// </summary>
        [JsonPropertyName("obtain_manually")]
        public bool ObtainManually { get; set; }

        /// <summary>
        /// 券信息
        /// </summary>
        [JsonPropertyName("voucher_info")]
        public MerchantActivityVoucherInfo VoucherInfo { get; set; }
    }
}
