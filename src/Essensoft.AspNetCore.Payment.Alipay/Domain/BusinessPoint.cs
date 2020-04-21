using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BusinessPoint Data Structure.
    /// </summary>
    public class BusinessPoint : AlipayObject
    {
        /// <summary>
        /// 点位描述
        /// </summary>
        [JsonPropertyName("point_desc")]
        public string PointDesc { get; set; }

        /// <summary>
        /// 业务点位id
        /// </summary>
        [JsonPropertyName("point_id")]
        public long PointId { get; set; }

        /// <summary>
        /// 点位名称
        /// </summary>
        [JsonPropertyName("point_name")]
        public string PointName { get; set; }

        /// <summary>
        /// 点位备注
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 点位状态
        /// </summary>
        [JsonPropertyName("status")]
        public long Status { get; set; }
    }
}
