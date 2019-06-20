using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniPoiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniPoiQueryModel : AlipayObject
    {
        /// <summary>
        /// 页码，起始页码为1
        /// </summary>
        [JsonProperty("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页大小，默认为10
        /// </summary>
        [JsonProperty("page_size")]
        public string PageSize { get; set; }
    }
}
