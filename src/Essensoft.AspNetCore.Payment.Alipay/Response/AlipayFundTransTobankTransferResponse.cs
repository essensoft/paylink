using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundTransTobankTransferResponse.
    /// </summary>
    public class AlipayFundTransTobankTransferResponse : AlipayResponse
    {
        /// <summary>
        /// 预计到账时间，格式为yyyy-MM-ddHH:mm:ss，转账受理失败不返回。  仅在进入提现流程时提供。  请求正在等待处理时将不返回此值。  此参数为预计时间，可能与实际到账时间有较大误差，不能作为实际到账时间使用，仅供参考用途。
        /// </summary>
        [JsonPropertyName("arrival_time_end")]
        public string ArrivalTimeEnd { get; set; }

        /// <summary>
        /// 支付宝转账单据号，成功一定返回，失败可能不返回也可能返回。
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 发起转账来源方定义的转账单据号。  请求时对应的参数，原样返回。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
