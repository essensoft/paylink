using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CampaignExtInfo Data Structure.
    /// </summary>
    public class CampaignExtInfo : AlipayObject
    {
        /// <summary>
        /// 用户不活跃间隔时间，当用户集点满足阙值且满足不活跃间隔时间后，发送召回通知
        /// </summary>
        [JsonPropertyName("interval_time")]
        public string IntervalTime { get; set; }

        /// <summary>
        /// 针对每个用户而言的月召回次数上限，且必须不大于平台侧该值全局配置
        /// </summary>
        [JsonPropertyName("month_limit")]
        public string MonthLimit { get; set; }

        /// <summary>
        /// 集点阈值，即当用户集点进度达到阈值后才会根据间隔时间下发召回唤醒通知，且必须不小于平台侧该值全局配置
        /// </summary>
        [JsonPropertyName("threshold")]
        public string Threshold { get; set; }
    }
}
