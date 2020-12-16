using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceLogisticsWaybillIstddetailQueryResponse.
    /// </summary>
    public class AlipayCommerceLogisticsWaybillIstddetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 预计还剩多久送达 单位：秒
        /// </summary>
        [JsonPropertyName("reach_duration")]
        public long ReachDuration { get; set; }

        /// <summary>
        /// 骑手位置纬度
        /// </summary>
        [JsonPropertyName("rider_lat")]
        public long RiderLat { get; set; }

        /// <summary>
        /// 骑手位置经度
        /// </summary>
        [JsonPropertyName("rider_lng")]
        public long RiderLng { get; set; }

        /// <summary>
        /// 骑手电话
        /// </summary>
        [JsonPropertyName("rider_mobile_no")]
        public string RiderMobileNo { get; set; }

        /// <summary>
        /// 骑手姓名
        /// </summary>
        [JsonPropertyName("rider_name")]
        public string RiderName { get; set; }

        /// <summary>
        /// 即时配送运单状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
