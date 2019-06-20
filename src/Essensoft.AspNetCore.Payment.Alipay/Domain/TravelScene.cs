using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TravelScene Data Structure.
    /// </summary>
    [Serializable]
    public class TravelScene : AlipayObject
    {
        /// <summary>
        /// 出行场景，综合体入参列表
        /// </summary>
        [JsonProperty("data_list")]
        public List<TravelMallRequest> DataList { get; set; }
    }
}
