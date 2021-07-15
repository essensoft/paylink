using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AntfarmProjectTargetInfo Data Structure.
    /// </summary>
    public class AntfarmProjectTargetInfo : AlipayObject
    {
        /// <summary>
        /// 标的物当前捐赠的数量
        /// </summary>
        [JsonPropertyName("current_donation_count")]
        public long CurrentDonationCount { get; set; }

        /// <summary>
        /// 捐赠标的物 id
        /// </summary>
        [JsonPropertyName("donation_target_id")]
        public string DonationTargetId { get; set; }

        /// <summary>
        /// 捐赠标的物名称
        /// </summary>
        [JsonPropertyName("donation_target_name")]
        public string DonationTargetName { get; set; }

        /// <summary>
        /// 标的物额度
        /// </summary>
        [JsonPropertyName("quota")]
        public long Quota { get; set; }
    }
}
