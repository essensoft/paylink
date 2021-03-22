using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwLibraryDeleteModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmSwLibraryDeleteModel : AlipayObject
    {
        /// <summary>
        /// 子部门ID，不传为默认部门
        /// </summary>
        [JsonPropertyName("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 知识库ID
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
