using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenIotbpaasLavidabilldetailQueryResponse.
    /// </summary>
    public class AlipayOpenIotbpaasLavidabilldetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 交易号
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 订单金额 or 订单退款金额
        /// </summary>
        [JsonPropertyName("biz_order_amt")]
        public string BizOrderAmt { get; set; }

        /// <summary>
        /// 商家优惠金额或者退商家优惠金额，根据rpRecordType字段值判断方向，rpRecordType=1，则为商家优惠金额，rpRecordType=2，则为退商家优惠金额
        /// </summary>
        [JsonPropertyName("mercht_disc_amt")]
        public string MerchtDiscAmt { get; set; }
    }
}
