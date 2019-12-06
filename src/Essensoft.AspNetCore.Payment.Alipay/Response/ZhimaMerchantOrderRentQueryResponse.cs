using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaMerchantOrderRentQueryResponse.
    /// </summary>
    public class ZhimaMerchantOrderRentQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否准入:  Y:准入  N:不准入
        /// </summary>
        [JsonPropertyName("admit_state")]
        public string AdmitState { get; set; }

        /// <summary>
        /// 资金流水号
        /// </summary>
        [JsonPropertyName("alipay_fund_order_no")]
        public string AlipayFundOrderNo { get; set; }

        /// <summary>
        /// 借用时间
        /// </summary>
        [JsonPropertyName("borrow_time")]
        public string BorrowTime { get; set; }

        /// <summary>
        /// 物品名称,最长不能超过14个汉字
        /// </summary>
        [JsonPropertyName("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 芝麻信用借还订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        [JsonPropertyName("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付金额类型  RENT:租金  DAMAGE:赔偿金
        /// </summary>
        [JsonPropertyName("pay_amount_type")]
        public string PayAmountType { get; set; }

        /// <summary>
        /// 支付状态  PAY_INIT:待支付  PAY_SUCCESS:支付成功  PAY_FAILED:支付失败  PAY_INPROGRESS:支付中
        /// </summary>
        [JsonPropertyName("pay_status")]
        public string PayStatus { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [JsonPropertyName("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 归还时间
        /// </summary>
        [JsonPropertyName("restore_time")]
        public string RestoreTime { get; set; }

        /// <summary>
        /// 订单状态:  borrow:借出  restore:归还  cancel:撤销
        /// </summary>
        [JsonPropertyName("use_state")]
        public string UseState { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
