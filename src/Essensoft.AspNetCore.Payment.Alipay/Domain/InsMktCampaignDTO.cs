using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsMktCampaignDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsMktCampaignDTO : AlipayObject
    {
        /// <summary>
        /// 保险营销活动id
        /// </summary>
        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 活动奖品发行量
        /// </summary>
        [JsonProperty("circulation")]
        public long Circulation { get; set; }

        /// <summary>
        /// 活动权益配置
        /// </summary>
        [JsonProperty("coupon_config")]
        public InsMktCouponConfigDTO CouponConfig { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [JsonProperty("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 活动备注
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 活动标的列表
        /// </summary>
        [JsonProperty("mkt_objects")]
        public List<InsMktObjectDTO> MktObjects { get; set; }

        /// <summary>
        /// 保险营销活动名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 发奖金额算法
        /// </summary>
        [JsonProperty("send_algorithm")]
        public string SendAlgorithm { get; set; }

        /// <summary>
        /// 发奖规则类型：  1. 基于账户做发奖控制  2. 基于身份证做发奖控制  3. 基于业务单号做发奖控制
        /// </summary>
        [JsonProperty("send_frqnc_type")]
        public long SendFrqncType { get; set; }

        /// <summary>
        /// 发奖规则值，频次为3
        /// </summary>
        [JsonProperty("send_frqnc_value")]
        public long SendFrqncValue { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [JsonProperty("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 活动状态：  5：活动已发布，待生效  6：活动已生效  7：活动已失效  8：活动已下线
        /// </summary>
        [JsonProperty("status")]
        public long Status { get; set; }
    }
}
