using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundTransBatchCreateorderResponse.
    /// </summary>
    public class AlipayFundTransBatchCreateorderResponse : AlipayResponse
    {
        /// <summary>
        /// 业务类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 扩展信息；创建付款单时传入的相关数据
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 单据号
        /// </summary>
        [JsonPropertyName("transfer_no")]
        public string TransferNo { get; set; }
    }
}
