using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwLibraryCreateModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmSwLibraryCreateModel : AlipayObject
    {
        /// <summary>
        /// 子部门ID，不传为默认部门
        /// </summary>
        [JsonPropertyName("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 知识库对应的类目树名称，与treeId不可同时为空
        /// </summary>
        [JsonPropertyName("instance_code")]
        public string InstanceCode { get; set; }

        /// <summary>
        /// 知识库名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 知识库对应的类目树Id，与instanceCode不可同时为空
        /// </summary>
        [JsonPropertyName("tree_id")]
        public long TreeId { get; set; }
    }
}
