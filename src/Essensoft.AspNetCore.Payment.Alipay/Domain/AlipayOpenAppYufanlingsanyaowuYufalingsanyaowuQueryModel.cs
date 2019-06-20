using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppYufanlingsanyaowuYufalingsanyaowuQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppYufanlingsanyaowuYufalingsanyaowuQueryModel : AlipayObject
    {
        /// <summary>
        /// 省份编码，国标码
        /// </summary>
        [JsonProperty("province_code")]
        public List<string> ProvinceCode { get; set; }
    }
}
