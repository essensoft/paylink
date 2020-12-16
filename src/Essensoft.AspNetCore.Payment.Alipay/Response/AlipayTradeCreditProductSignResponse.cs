using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeCreditProductSignResponse.
    /// </summary>
    public class AlipayTradeCreditProductSignResponse : AlipayResponse
    {
        /// <summary>
        /// 合约批次号；成功场景下才会返回
        /// </summary>
        [JsonPropertyName("contract_batch_no")]
        public string ContractBatchNo { get; set; }

        /// <summary>
        /// 合约号；成功场景下才会返回
        /// </summary>
        [JsonPropertyName("contract_no_list")]
        public string ContractNoList { get; set; }

        /// <summary>
        /// 第三方错误上下文；只有失败情况下才会返回
        /// </summary>
        [JsonPropertyName("third_error_context")]
        public ThirdErrorContext ThirdErrorContext { get; set; }
    }
}
