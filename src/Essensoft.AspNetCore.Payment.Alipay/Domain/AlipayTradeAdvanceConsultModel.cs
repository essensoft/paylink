using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeAdvanceConsultModel Data Structure.
    /// </summary>
    public class AlipayTradeAdvanceConsultModel : AlipayObject
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号（用户签约成功后的协议号 ） ，在进行单笔订单风险评估预咨询时必传。
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 支付宝用户id；除单笔订单风险预评估场景(即consult_scene指定ORDER_RISK_EVALUATION)外，其他场景必选。
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 订单咨询类型，用以选择咨询的服务。不传时默认为垫资咨询。其他的场景需要按照对接的服务传入指定的值。 单笔订单风险预评估-ORDER_RISK_EVALUATION
        /// </summary>
        [JsonPropertyName("consult_scene")]
        public string ConsultScene { get; set; }

        /// <summary>
        /// 预估订单总金额，单位为元，精确到小数点后两位，单笔订单风险预评估时使用，取值范围[0.01,100000000]。
        /// </summary>
        [JsonPropertyName("estimated_order_amount")]
        public string EstimatedOrderAmount { get; set; }

        /// <summary>
        /// 行业产品信息，咨询是，会从该产品对应的销售方案中获取相关垫资规则配置
        /// </summary>
        [JsonPropertyName("industry_product_code")]
        public string IndustryProductCode { get; set; }

        /// <summary>
        /// 商户请求时的外部订单号，在花芝场景下非空。
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 子商户id
        /// </summary>
        [JsonPropertyName("sub_merchant_id")]
        public string SubMerchantId { get; set; }

        /// <summary>
        /// 子商户类型
        /// </summary>
        [JsonPropertyName("sub_merchant_type")]
        public string SubMerchantType { get; set; }
    }
}
