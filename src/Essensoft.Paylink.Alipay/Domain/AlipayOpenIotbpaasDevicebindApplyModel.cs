using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenIotbpaasDevicebindApplyModel Data Structure.
    /// </summary>
    public class AlipayOpenIotbpaasDevicebindApplyModel : AlipayObject
    {
        /// <summary>
        /// 绑定token，用于查询绑定状态
        /// </summary>
        [JsonPropertyName("bind_token")]
        public string BindToken { get; set; }

        /// <summary>
        /// 非必传，传入为INIT时，强制生成新绑定token
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
