using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsDataWeatherSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsDataWeatherSyncModel : AlipayObject
    {
        /// <summary>
        /// 天气信息描述信息
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 外部业务幂等字段
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
