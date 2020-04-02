using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaMerchantContractPageQueryResponse.
    /// </summary>
    public class ZhimaMerchantContractPageQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 合约详情信息
        /// </summary>
        [JsonPropertyName("biz_data")]
        public List<ZmContractDetail> BizData { get; set; }

        /// <summary>
        /// 业务结果描述，成功则为空，失败才会有
        /// </summary>
        [JsonPropertyName("biz_desc")]
        public string BizDesc { get; set; }

        /// <summary>
        /// 业务成功标识，success/failed
        /// </summary>
        [JsonPropertyName("biz_result")]
        public string BizResult { get; set; }

        /// <summary>
        /// 是否有下一页
        /// </summary>
        [JsonPropertyName("has_next")]
        public bool HasNext { get; set; }
    }
}
