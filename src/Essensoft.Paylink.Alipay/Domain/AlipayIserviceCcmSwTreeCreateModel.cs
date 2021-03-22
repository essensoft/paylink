using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmSwTreeCreateModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmSwTreeCreateModel : AlipayObject
    {
        /// <summary>
        /// 子部门ID，不传为默认部门
        /// </summary>
        [JsonPropertyName("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
