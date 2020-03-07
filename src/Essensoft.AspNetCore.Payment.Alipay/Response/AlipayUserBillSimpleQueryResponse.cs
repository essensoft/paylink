using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserBillSimpleQueryResponse.
    /// </summary>
    public class AlipayUserBillSimpleQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 交易金额/转账金额。单位为元
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 业务状态
        /// </summary>
        [JsonPropertyName("biz_state")]
        public string BizState { get; set; }

        /// <summary>
        /// 业务创建时间
        /// </summary>
        [JsonPropertyName("gmt_biz_create")]
        public string GmtBizCreate { get; set; }

        /// <summary>
        /// 资金流入流出类型 IN 表示收入 OUT表示支出
        /// </summary>
        [JsonPropertyName("in_out_type")]
        public string InOutType { get; set; }
    }
}
