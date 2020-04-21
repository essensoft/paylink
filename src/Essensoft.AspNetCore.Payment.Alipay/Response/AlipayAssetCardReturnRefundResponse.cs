using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAssetCardReturnRefundResponse.
    /// </summary>
    public class AlipayAssetCardReturnRefundResponse : AlipayResponse
    {
        /// <summary>
        /// 账务操作时间
        /// </summary>
        [JsonPropertyName("account_dt")]
        public string AccountDt { get; set; }

        /// <summary>
        /// 系统退卡订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 退卡资金，单位元，包含手续费
        /// </summary>
        [JsonPropertyName("return_amount")]
        public string ReturnAmount { get; set; }

        /// <summary>
        /// 退款面额，单位元，包含手续费
        /// </summary>
        [JsonPropertyName("return_asset_amont")]
        public string ReturnAssetAmont { get; set; }

        /// <summary>
        /// 退卡手续费资金，单位元
        /// </summary>
        [JsonPropertyName("return_fee_amount")]
        public string ReturnFeeAmount { get; set; }

        /// <summary>
        /// 退卡手续费面额，单位元
        /// </summary>
        [JsonPropertyName("return_fee_asset_amount")]
        public string ReturnFeeAssetAmount { get; set; }
    }
}
