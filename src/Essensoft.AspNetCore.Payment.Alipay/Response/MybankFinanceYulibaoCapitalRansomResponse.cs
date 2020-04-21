using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankFinanceYulibaoCapitalRansomResponse.
    /// </summary>
    public class MybankFinanceYulibaoCapitalRansomResponse : AlipayResponse
    {
        /// <summary>
        /// 余利宝内部的交易流水号
        /// </summary>
        [JsonPropertyName("inner_biz_no")]
        public string InnerBizNo { get; set; }

        /// <summary>
        /// 交易结果备注信息
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 交易结果，目前会有3种状态值，1：success，表示交易成功、2：fail，表示交易失败:、3：inprocess，表示交易处理中。其中交易处理中的状态可以使用回查交易历史的方式查看其处理结果。
        /// </summary>
        [JsonPropertyName("trans_result")]
        public string TransResult { get; set; }
    }
}
