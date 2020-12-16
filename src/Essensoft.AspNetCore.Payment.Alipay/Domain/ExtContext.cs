using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExtContext Data Structure.
    /// </summary>
    public class ExtContext : AlipayObject
    {
        /// <summary>
        /// ebank_form，银行返回格式类型
        /// </summary>
        [JsonPropertyName("ebank_form")]
        public string EbankForm { get; set; }

        /// <summary>
        /// 机构返回描述
        /// </summary>
        [JsonPropertyName("return_message")]
        public string ReturnMessage { get; set; }
    }
}
