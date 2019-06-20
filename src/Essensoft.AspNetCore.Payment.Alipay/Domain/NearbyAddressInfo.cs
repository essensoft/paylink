using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NearbyAddressInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NearbyAddressInfo : AlipayObject
    {
        /// <summary>
        /// 审核状态,AUDIT-审核中，AUDIT_SUCCESS-审核通过，AUDIT_FAIL-审核不通过，AUDIT_CANCEL-取消审核
        /// </summary>
        [JsonProperty("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 营业执照号
        /// </summary>
        [JsonProperty("certificate")]
        public string Certificate { get; set; }

        /// <summary>
        /// 地点展示状态,UNDISPLAYED-未展示,DISPLAYED-已展示
        /// </summary>
        [JsonProperty("display_status")]
        public string DisplayStatus { get; set; }

        /// <summary>
        /// 审核失败原因
        /// </summary>
        [JsonProperty("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [JsonProperty("poi_address")]
        public string PoiAddress { get; set; }

        /// <summary>
        /// poi id，地理位置标记信息
        /// </summary>
        [JsonProperty("poi_id")]
        public string PoiId { get; set; }
    }
}
