using Newtonsoft.Json;
using System.Collections.Generic;

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
        [JsonProperty("descriptions")]
        public List<string> Descriptions { get; set; }

        /// <summary>
        /// 说明title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
