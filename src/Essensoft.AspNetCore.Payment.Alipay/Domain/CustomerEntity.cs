using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CustomerEntity Data Structure.
    /// </summary>
    public class CustomerEntity : AlipayObject
    {
        /// <summary>
        /// 实体英文名
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 实体描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 实体id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 实体中文名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// tag列表
        /// </summary>
        [JsonPropertyName("tags")]
        public List<CustomerTag> Tags { get; set; }
    }
}
