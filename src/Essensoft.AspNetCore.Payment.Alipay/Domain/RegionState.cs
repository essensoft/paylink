using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RegionState Data Structure.
    /// </summary>
    [Serializable]
    public class RegionState : AlipayObject
    {
        /// <summary>
        /// 区域所在层
        /// </summary>
        [JsonProperty("floor")]
        public long Floor { get; set; }

        /// <summary>
        /// 左端最大可放坐标(单位:毫米)
        /// </summary>
        [JsonProperty("left_max")]
        public long LeftMax { get; set; }

        /// <summary>
        /// 左端最小可放坐标(单位:毫米)
        /// </summary>
        [JsonProperty("left_min")]
        public long LeftMin { get; set; }

        /// <summary>
        /// 黄色区域插入选取商品后最左端坐标(单位:毫米)
        /// </summary>
        [JsonProperty("left_push")]
        public long LeftPush { get; set; }
    }
}
