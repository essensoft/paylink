using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwLibraryModifyModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmSwLibraryModifyModel : AlipayObject
    {
        /// <summary>
        /// 子部门ID，不传为默认部门
        /// </summary>
        [JsonPropertyName("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 知识库Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 知识库名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
