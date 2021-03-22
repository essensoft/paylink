using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// TreeInfo Data Structure.
    /// </summary>
    public class TreeInfo : AlipayObject
    {
        /// <summary>
        /// 类目树ID
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// 知识库对应的类目树名称，与treeId不可同时为空
        /// </summary>
        [JsonPropertyName("instance_code")]
        public string InstanceCode { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
