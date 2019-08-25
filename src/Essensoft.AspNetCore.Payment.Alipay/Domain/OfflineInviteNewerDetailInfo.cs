using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OfflineInviteNewerDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OfflineInviteNewerDetailInfo : AlipayObject
    {
        /// <summary>
        /// 城市
        /// </summary>
        [JsonProperty("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 扩展信息字段
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 被邀请手机号
        /// </summary>
        [JsonProperty("invited_phone")]
        public string InvitedPhone { get; set; }

        /// <summary>
        /// 地域系数
        /// </summary>
        [JsonProperty("lbs_rate")]
        public string LbsRate { get; set; }

        /// <summary>
        /// 二级渠道
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 一级渠道
        /// </summary>
        [JsonProperty("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [JsonProperty("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 是否可结算核销用户
        /// </summary>
        [JsonProperty("settled")]
        public bool Settled { get; set; }

        /// <summary>
        /// 是否可结算的绑卡用户
        /// </summary>
        [JsonProperty("settled_and_bind")]
        public bool SettledAndBind { get; set; }

        /// <summary>
        /// 绑卡时间
        /// </summary>
        [JsonProperty("user_bind_card_time")]
        public string UserBindCardTime { get; set; }

        /// <summary>
        /// 用户实名时间
        /// </summary>
        [JsonProperty("user_cert_time")]
        public string UserCertTime { get; set; }

        /// <summary>
        /// 用户领奖时间
        /// </summary>
        [JsonProperty("user_prize_time")]
        public string UserPrizeTime { get; set; }
    }
}
