using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncSettleReceivableConfirmResponse.
    /// </summary>
    public class AlipayBossFncSettleReceivableConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 应收确认结果列表
        /// </summary>
        [JsonPropertyName("result_set")]
        public List<ConfirmReceivableDTO> ResultSet { get; set; }
    }
}
