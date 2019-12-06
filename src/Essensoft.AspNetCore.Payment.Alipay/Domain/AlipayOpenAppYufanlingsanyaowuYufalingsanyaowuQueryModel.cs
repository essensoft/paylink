using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppYufanlingsanyaowuYufalingsanyaowuQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppYufanlingsanyaowuYufalingsanyaowuQueryModel : AlipayObject
    {
        /// <summary>
        /// 省份编码，国标码
        /// </summary>
        [JsonPropertyName("province_code")]
        public List<string> ProvinceCode { get; set; }
    }
}
