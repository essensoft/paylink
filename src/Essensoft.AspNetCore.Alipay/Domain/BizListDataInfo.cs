using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// BizListDataInfo Data Structure.
    /// </summary>
    public class BizListDataInfo : AlipayObject
    {
        /// <summary>
        /// 下拉列表编号
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 下拉列表名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
