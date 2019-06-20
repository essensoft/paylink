using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BusinessPoint Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessPoint : AlipayObject
    {
        /// <summary>
        /// 点位描述
        /// </summary>
        [JsonProperty("point_desc")]
        public string PointDesc { get; set; }

        /// <summary>
        /// 业务点位id
        /// </summary>
        [JsonProperty("point_id")]
        public long PointId { get; set; }

        /// <summary>
        /// 点位名称
        /// </summary>
        [JsonProperty("point_name")]
        public string PointName { get; set; }

        /// <summary>
        /// 点位备注
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 点位状态
        /// </summary>
        [JsonProperty("status")]
        public long Status { get; set; }
    }
}
