using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradePrecreateConfirmResponse.
    /// </summary>
    public class AlipayTradePrecreateConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 收单模式  银行代理收单，取值：bankAgentMode  平台直连收单，取值：  normalOrderMode
        /// </summary>
        [JsonPropertyName("acquiring_mode")]
        public string AcquiringMode { get; set; }

        /// <summary>
        /// 间联商户信息,若商户是间联商户则必选 格式为json
        /// </summary>
        [JsonPropertyName("indirect_merchant_info")]
        public TradePrecreateConfirmIndirectMerchantInfo IndirectMerchantInfo { get; set; }

        /// <summary>
        /// 直连商户信息，当商户为直连商户会有非空的值 格式为json
        /// </summary>
        [JsonPropertyName("merchant_info")]
        public TradePrecreateConfirmTradeMerchantInfo MerchantInfo { get; set; }

        /// <summary>
        /// 商户原始订单号
        /// </summary>
        [JsonPropertyName("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonPropertyName("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单信息 格式为json
        /// </summary>
        [JsonPropertyName("order_info")]
        public TradePrecreateConfirmOrderInfo OrderInfo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 预下单的码信息 格式为json
        /// </summary>
        [JsonPropertyName("precreate_code_info")]
        public TradePrecreateConfirmPrecreateCodeInfo PrecreateCodeInfo { get; set; }

        /// <summary>
        /// 清算机构流水号（如网联流水号）
        /// </summary>
        [JsonPropertyName("settle_serial_no")]
        public string SettleSerialNo { get; set; }

        /// <summary>
        /// 店铺信息 格式为json
        /// </summary>
        [JsonPropertyName("store_info")]
        public TradePrecreateConfirmTradeStoreInfo StoreInfo { get; set; }

        /// <summary>
        /// 订单金额 币种：人民币 单位：元
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
