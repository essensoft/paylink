using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundTransAppPayResponse.
    /// </summary>
    public class AlipayFundTransAppPayResponse : AlipayResponse
    {
        /// <summary>
        /// 该笔转账在支付宝系统内部的单据ID
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户端的唯一订单号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// SUCCESS：转账成功；  WAIT_PAY：转账订单等待支付；  CLOSED：订单超时关闭，截止订单支付超时时间(time_expire)仍未支付，单据状态会变更为CLOSED；
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
