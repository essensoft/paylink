using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MerchantOnlineActivityOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantOnlineActivityOpenModel : AlipayObject
    {
        /// <summary>
        /// 活动Id
        /// </summary>
        [JsonProperty("activity_id")]
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 营销活动Id
        /// </summary>
        [JsonProperty("camp_id")]
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 活动优惠次数限制
        /// </summary>
        [JsonProperty("count_limit")]
        [XmlElement("count_limit")]
        public long CountLimit { get; set; }

        /// <summary>
        /// 活动优惠单日次数限制
        /// </summary>
        [JsonProperty("count_limit_per_day")]
        [XmlElement("count_limit_per_day")]
        public long CountLimitPerDay { get; set; }

        /// <summary>
        /// 活动单用户限次
        /// </summary>
        [JsonProperty("count_limit_per_user")]
        [XmlElement("count_limit_per_user")]
        public long CountLimitPerUser { get; set; }

        /// <summary>
        /// 活动单用户单日限次
        /// </summary>
        [JsonProperty("count_limit_per_user_per_day")]
        [XmlElement("count_limit_per_user_per_day")]
        public long CountLimitPerUserPerDay { get; set; }

        /// <summary>
        /// 人群规则  DEFAULT：全部用户  ONLINE_NEWCOMER：在线购买新人  MEMBER：会员
        /// </summary>
        [JsonProperty("crowd")]
        [XmlElement("crowd")]
        public string Crowd { get; set; }

        /// <summary>
        /// 代金券面额
        /// </summary>
        [JsonProperty("deduct_amount")]
        [XmlElement("deduct_amount")]
        public string DeductAmount { get; set; }

        /// <summary>
        /// 外部Id
        /// </summary>
        [JsonProperty("external_unique_id")]
        [XmlElement("external_unique_id")]
        public string ExternalUniqueId { get; set; }

        /// <summary>
        /// 活动结束时间  格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("gmt_end")]
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 活动开始时间，格式为:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("gmt_start")]
        [XmlElement("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        [JsonProperty("item_ids")]
        [XmlArray("item_ids")]
        [XmlArrayItem("string")]
        public List<string> ItemIds { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("memo")]
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 使用门槛，满X元可用，使用门槛必须大于券面额
        /// </summary>
        [JsonProperty("min_cost")]
        [XmlElement("min_cost")]
        public string MinCost { get; set; }

        /// <summary>
        /// 是否手动领取，本期只支持true
        /// </summary>
        [JsonProperty("obtain_manually")]
        [XmlElement("obtain_manually")]
        public bool ObtainManually { get; set; }

        /// <summary>
        /// 券信息
        /// </summary>
        [JsonProperty("voucher_info")]
        [XmlElement("voucher_info")]
        public MerchantActivityVoucherInfo VoucherInfo { get; set; }
    }
}
