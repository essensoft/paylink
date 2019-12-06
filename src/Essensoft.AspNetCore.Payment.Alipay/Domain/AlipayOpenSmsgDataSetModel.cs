using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenSmsgDataSetModel Data Structure.
    /// </summary>
    public class AlipayOpenSmsgDataSetModel : AlipayObject
    {
        /// <summary>
        /// 测试
        /// </summary>
        [JsonPropertyName("paramone")]
        public string Paramone { get; set; }

        /// <summary>
        /// 测试参数2
        /// </summary>
        [JsonPropertyName("paramtwo")]
        public string Paramtwo { get; set; }
    }
}
