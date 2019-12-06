using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsMktCampaignDTO Data Structure.
    /// </summary>
    public class InsMktCampaignDTO : AlipayObject
    {
        /// <summary>
        /// 保险营销活动id
        /// </summary>
        [JsonPropertyName("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// 活动奖品发行量
        /// </summary>
        [JsonPropertyName("circulation")]
        public long Circulation { get; set; }

        /// <summary>
        /// 活动权益配置
        /// </summary>
        [JsonPropertyName("coupon_config")]
        public InsMktCouponConfigDTO CouponConfig { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 活动备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 活动标的列表
        /// </summary>
        [JsonPropertyName("mkt_objects")]
        public List<InsMktObjectDTO> MktObjects { get; set; }

        /// <summary>
        /// 保险营销活动名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 发奖金额算法
        /// </summary>
        [JsonPropertyName("send_algorithm")]
        public string SendAlgorithm { get; set; }

        /// <summary>
        /// 发奖规则类型：  1. 基于账户做发奖控制  2. 基于身份证做发奖控制  3. 基于业务单号做发奖控制
        /// </summary>
        [JsonPropertyName("send_frqnc_type")]
        public long SendFrqncType { get; set; }

        /// <summary>
        /// 发奖规则值，频次为3
        /// </summary>
        [JsonPropertyName("send_frqnc_value")]
        public long SendFrqncValue { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 活动状态：  5：活动已发布，待生效  6：活动已生效  7：活动已失效  8：活动已下线
        /// </summary>
        [JsonPropertyName("status")]
        public long Status { get; set; }
    }
}
