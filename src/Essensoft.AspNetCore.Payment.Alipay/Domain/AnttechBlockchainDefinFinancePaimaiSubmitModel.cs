using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinFinancePaimaiSubmitModel Data Structure.
    /// </summary>
    public class AnttechBlockchainDefinFinancePaimaiSubmitModel : AlipayObject
    {
        /// <summary>
        /// base64编码的业务参数
        /// </summary>
        [JsonPropertyName("encoded_biz_param")]
        public string EncodedBizParam { get; set; }

        /// <summary>
        /// 系统参数
        /// </summary>
        [JsonPropertyName("sys_param")]
        public SystemParam SysParam { get; set; }
    }
}
