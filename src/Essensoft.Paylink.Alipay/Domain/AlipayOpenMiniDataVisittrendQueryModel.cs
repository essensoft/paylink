using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniDataVisittrendQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniDataVisittrendQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询小程序访问趋势数据的粒度，如HOUR-小时级
        /// </summary>
        [JsonPropertyName("time_unit")]
        public string TimeUnit { get; set; }
    }
}
