using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundTransAacollectPayorderCreateResponse.
    /// </summary>
    public class AlipayFundTransAacollectPayorderCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 批次号
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 业务类型,客户端透传给收银台。默认值：biz_account_transfer
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 付款订单号,小程序传给收银台
        /// </summary>
        [JsonPropertyName("transfer_no")]
        public string TransferNo { get; set; }
    }
}
