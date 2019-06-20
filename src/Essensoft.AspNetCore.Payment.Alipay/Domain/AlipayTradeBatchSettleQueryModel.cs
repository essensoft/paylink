using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeBatchSettleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeBatchSettleQueryModel : AlipayObject
    {
        /// <summary>
        /// 扩展参数
        /// </summary>
        [JsonProperty("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 批量结算时传入的外部流水号，与settle_no二者必填其一。 out_request_no和settle_no如果同时存在，优先取settle_no
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 结算单据号，与out_request_no二者必填其一
        /// </summary>
        [JsonProperty("settle_no")]
        public string SettleNo { get; set; }
    }
}
