using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeBatchTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeBatchTransferModel : AlipayObject
    {
        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [JsonProperty("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 结算请求外部流水号，32个字符以内、可包含字母、数字、下划线；需保证在商户端不重复
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 分账条款明细 特别注意：最好一次只传一个分账条款。 如果传多个，则要求出账方只能有一个， 举例：A分给B+A分给C+A分给D=OK A分给B+C分给D=不行
        /// </summary>
        [JsonProperty("royalty_parameters")]
        public List<RoyaltyDetailInfo> RoyaltyParameters { get; set; }
    }
}
