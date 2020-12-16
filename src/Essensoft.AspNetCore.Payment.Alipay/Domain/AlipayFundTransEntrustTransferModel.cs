using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransEntrustTransferModel Data Structure.
    /// </summary>
    public class AlipayFundTransEntrustTransferModel : AlipayObject
    {
        /// <summary>
        /// 描述特定的业务场景，可传的参数如下： CREDIT_SALE_TRANSFER委托支付诚e赊打款
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// JSON格式，传递业务扩展参数，使用前请与支付宝工程师联系！
        /// </summary>
        [JsonPropertyName("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 该笔委托支付在支付宝系统内部的单据ID（委托支付打款场景必传）
        /// </summary>
        [JsonPropertyName("entrust_order_id")]
        public string EntrustOrderId { get; set; }

        /// <summary>
        /// 转账业务的标题，用于在支付宝用户的账单里显示
        /// </summary>
        [JsonPropertyName("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户端的唯一订单号，对于同一笔转账请求，商户需保证该订单号唯一。
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 回传参数，如果请求时传递了该参数，则异步通知商户时会回传该参数。
        /// </summary>
        [JsonPropertyName("passback_params")]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 收款方信息
        /// </summary>
        [JsonPropertyName("payee_info")]
        public Participant PayeeInfo { get; set; }

        /// <summary>
        /// 付款方信息
        /// </summary>
        [JsonPropertyName("payer_info")]
        public Participant PayerInfo { get; set; }

        /// <summary>
        /// 业务产品码，委托支付传ENTRUSTED_PAYMENT_COLLECTION
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 业务备注
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]；
        /// </summary>
        [JsonPropertyName("trans_amount")]
        public string TransAmount { get; set; }
    }
}
