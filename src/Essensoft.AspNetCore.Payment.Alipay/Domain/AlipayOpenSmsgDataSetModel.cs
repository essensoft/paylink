using Newtonsoft.Json;

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
        [JsonProperty("paramone")]
        public string Paramone { get; set; }

        /// <summary>
        /// 测试参数2
        /// </summary>
        [JsonProperty("paramtwo")]
        public string Paramtwo { get; set; }
    }
}
