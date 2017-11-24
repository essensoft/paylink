using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// VoucherTermInfo Data Structure.
    /// </summary>
    public class VoucherTermInfo : AlipayObject
    {
        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("descriptions")]
        public List<string> Descriptions { get; set; }

        /// <summary>
        /// 详情title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
