using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataIotdataBusinessPointCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataIotdataBusinessPointCreateModel : AlipayObject
    {
        /// <summary>
        /// 业务id
        /// </summary>
        [JsonProperty("business_id")]
        public long BusinessId { get; set; }

        /// <summary>
        /// 点位描述，可以是点位的具体地址
        /// </summary>
        [JsonProperty("point_desc")]
        public string PointDesc { get; set; }

        /// <summary>
        /// 点位名称
        /// </summary>
        [JsonProperty("point_name")]
        public string PointName { get; set; }

        /// <summary>
        /// 点位备注信息
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }
    }
}
