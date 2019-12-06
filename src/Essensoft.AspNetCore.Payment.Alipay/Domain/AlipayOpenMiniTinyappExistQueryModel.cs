using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniTinyappExistQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniTinyappExistQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝账号ID
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
    }
}
