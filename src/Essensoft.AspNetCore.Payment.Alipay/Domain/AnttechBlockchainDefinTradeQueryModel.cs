using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinTradeQueryModel Data Structure.
    /// </summary>
    public class AnttechBlockchainDefinTradeQueryModel : AlipayObject
    {
        /// <summary>
        /// 企业/报关单查询请求 in Json string
        /// </summary>
        [JsonPropertyName("encoded_biz_param")]
        public string EncodedBizParam { get; set; }

        /// <summary>
        /// sys_param, 按其中字段function区分查询类型，如企业认证还是报关单查询。
        /// </summary>
        [JsonPropertyName("sys_param")]
        public SystemParam SysParam { get; set; }
    }
}
