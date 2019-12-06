using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VoucherTermInfo Data Structure.
    /// </summary>
    public class VoucherTermInfo : AlipayObject
    {
        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonPropertyName("descriptions")]
        public List<string> Descriptions { get; set; }

        /// <summary>
        /// 详情title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
