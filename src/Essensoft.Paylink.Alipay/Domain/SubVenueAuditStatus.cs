using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SubVenueAuditStatus Data Structure.
    /// </summary>
    public class SubVenueAuditStatus : AlipayObject
    {
        /// <summary>
        /// 服务商对应的子场馆ID
        /// </summary>
        [JsonPropertyName("out_sub_venue_id")]
        public string OutSubVenueId { get; set; }

        /// <summary>
        /// 支付宝对应的子场馆ID
        /// </summary>
        [JsonPropertyName("sub_venue_id")]
        public string SubVenueId { get; set; }

        /// <summary>
        /// 场馆当前状态 安全审核中：infosec-audit 安全审核不通过：infosec-unpass 云验收中： cloud-audit 云验收不通过： cloud-unpass 上架： online 下架： offline 人工下架： manual-offline
        /// </summary>
        [JsonPropertyName("sub_venue_status")]
        public string SubVenueStatus { get; set; }
    }
}
