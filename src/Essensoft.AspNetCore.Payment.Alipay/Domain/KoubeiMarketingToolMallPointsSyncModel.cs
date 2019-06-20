using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingToolMallPointsSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingToolMallPointsSyncModel : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 业务类型(目前只有点卡)
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 渲染截止时间
        /// </summary>
        [JsonProperty("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 卡片展示内容，卡片如果没有集的count设置为0，本次交易获取的卡片需设置is_new的值为true
        /// </summary>
        [JsonProperty("json_content")]
        public string JsonContent { get; set; }

        /// <summary>
        /// 商圈id
        /// </summary>
        [JsonProperty("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// trade|lottery|system，表示为交易|领取礼包|系统调整
        /// </summary>
        [JsonProperty("operate")]
        public string Operate { get; set; }

        /// <summary>
        /// 外部幂等id
        /// </summary>
        [JsonProperty("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// collecting|collectSuccess|finish字段中的一种
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("trade_id")]
        public string TradeId { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
