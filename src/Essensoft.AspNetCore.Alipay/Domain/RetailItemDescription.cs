using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// RetailItemDescription Data Structure.
    /// </summary>
    public class RetailItemDescription : AlipayObject
    {
        /// <summary>
        /// 标题下的描述列表，列表类型，每项不得超过100个中文字符,最多10项
        /// </summary>
        [JsonProperty("details")]
        public List<string> Details { get; set; }

        /// <summary>
        /// 商品描述title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
