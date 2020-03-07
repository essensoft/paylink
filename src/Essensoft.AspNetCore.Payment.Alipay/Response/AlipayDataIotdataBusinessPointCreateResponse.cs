using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataIotdataBusinessPointCreateResponse.
    /// </summary>
    public class AlipayDataIotdataBusinessPointCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 点位描述
        /// </summary>
        [JsonPropertyName("point_desc")]
        public string PointDesc { get; set; }

        /// <summary>
        /// 生成的点位id
        /// </summary>
        [JsonPropertyName("point_id")]
        public long PointId { get; set; }

        /// <summary>
        /// 点位名称
        /// </summary>
        [JsonPropertyName("point_name")]
        public string PointName { get; set; }

        /// <summary>
        /// 点位备注信息
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
