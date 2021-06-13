using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// TradeFundBillDetail Data Structure.
    /// </summary>
    public class TradeFundBillDetail : AlipayObject
    {
        /// <summary>
        /// 交易金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 资产类型编码
        /// </summary>
        [JsonPropertyName("asset_type_code")]
        public string AssetTypeCode { get; set; }

        /// <summary>
        /// 资产的属主
        /// </summary>
        [JsonPropertyName("asset_user_id")]
        public string AssetUserId { get; set; }

        /// <summary>
        /// 支付业务类型  PAY-支付  REFUND-退款
        /// </summary>
        [JsonPropertyName("biz_pay_type")]
        public string BizPayType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 支付单据号
        /// </summary>
        [JsonPropertyName("payment_no")]
        public string PaymentNo { get; set; }
    }
}
