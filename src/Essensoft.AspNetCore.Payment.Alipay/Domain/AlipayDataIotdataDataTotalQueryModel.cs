using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataIotdataDataTotalQueryModel Data Structure.
    /// </summary>
    public class AlipayDataIotdataDataTotalQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务id
        /// </summary>
        [JsonPropertyName("business_id")]
        public long BusinessId { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public long EndTime { get; set; }

        /// <summary>
        /// 点位id
        /// </summary>
        [JsonPropertyName("point_id")]
        public long PointId { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public long StartTime { get; set; }

        /// <summary>
        /// 子业务id
        /// </summary>
        [JsonPropertyName("sub_biz_id")]
        public string SubBizId { get; set; }
    }
}
