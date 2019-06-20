using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DepartmentLabel Data Structure.
    /// </summary>
    [Serializable]
    public class DepartmentLabel : AlipayObject
    {
        /// <summary>
        /// 部门标签码
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 部门标签id
        /// </summary>
        [JsonProperty("label_id")]
        public string LabelId { get; set; }

        /// <summary>
        /// 部门标签名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
