using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinFinanceOrderSubmitModel Data Structure.
    /// </summary>
    public class AnttechBlockchainDefinFinanceOrderSubmitModel : AlipayObject
    {
        /// <summary>
        /// 业务参数
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
