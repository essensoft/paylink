using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AntfortuneYebAssetOrderQueryResponse.
    /// </summary>
    public class AntfortuneYebAssetOrderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 订单关闭方
        /// </summary>
        [JsonPropertyName("close_by")]
        public string CloseBy { get; set; }

        /// <summary>
        /// 订单关闭原因
        /// </summary>
        [JsonPropertyName("close_reason")]
        public string CloseReason { get; set; }

        /// <summary>
        /// 订单关闭时间
        /// </summary>
        [JsonPropertyName("gmt_close")]
        public string GmtClose { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单超时时间
        /// </summary>
        [JsonPropertyName("order_timeout")]
        public string OrderTimeout { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
