using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CustomerEntity Data Structure.
    /// </summary>
    [Serializable]
    public class CustomerEntity : AlipayObject
    {
        /// <summary>
        /// 实体英文名
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 实体描述
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 实体id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 实体中文名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// tag列表
        /// </summary>
        [JsonProperty("tags")]
        public List<CustomerTag> Tags { get; set; }
    }
}
