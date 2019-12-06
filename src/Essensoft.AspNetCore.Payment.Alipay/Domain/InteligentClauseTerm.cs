using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InteligentClauseTerm Data Structure.
    /// </summary>
    public class InteligentClauseTerm : AlipayObject
    {
        /// <summary>
        /// 说明描述内容
        /// </summary>
        [JsonPropertyName("descriptions")]
        public List<string> Descriptions { get; set; }

        /// <summary>
        /// 说明title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
