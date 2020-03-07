using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsDataWeatherSyncModel Data Structure.
    /// </summary>
    public class AlipayInsDataWeatherSyncModel : AlipayObject
    {
        /// <summary>
        /// 天气信息描述信息
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 外部业务幂等字段
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
