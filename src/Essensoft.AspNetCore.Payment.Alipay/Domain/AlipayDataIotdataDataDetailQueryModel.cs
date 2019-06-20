using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataIotdataDataDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataIotdataDataDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务id
        /// </summary>
        [JsonProperty("business_id")]
        public long BusinessId { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("end_time")]
        public long EndTime { get; set; }

        /// <summary>
        /// 点位id
        /// </summary>
        [JsonProperty("point_id")]
        public long PointId { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("start_time")]
        public long StartTime { get; set; }

        /// <summary>
        /// 子业务id
        /// </summary>
        [JsonProperty("sub_biz_id")]
        public string SubBizId { get; set; }
    }
}
