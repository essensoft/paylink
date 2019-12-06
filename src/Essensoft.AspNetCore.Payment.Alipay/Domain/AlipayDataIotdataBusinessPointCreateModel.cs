using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataIotdataBusinessPointCreateModel Data Structure.
    /// </summary>
    public class AlipayDataIotdataBusinessPointCreateModel : AlipayObject
    {
        /// <summary>
        /// 业务id
        /// </summary>
        [JsonPropertyName("business_id")]
        public long BusinessId { get; set; }

        /// <summary>
        /// 点位描述，可以是点位的具体地址
        /// </summary>
        [JsonPropertyName("point_desc")]
        public string PointDesc { get; set; }

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
    }
}
