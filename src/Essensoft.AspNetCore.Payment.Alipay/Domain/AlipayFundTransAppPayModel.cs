using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransAppPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransAppPayModel : AlipayObject
    {
        /// <summary>
        /// 描述特定的业务场景，可传值如下：  PERSONAL_PAY: 发红包
        /// </summary>
        [JsonProperty("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// JSON格式，传递业务扩展参数.  业务扩展字段，JSON格式。支持如下属性：  sub_biz_scene 子场景，必填，传REDPACKET  payer_binded_alipay_id 创建红包的商户会员绑定的支付宝userId，必填
        /// </summary>
        [JsonProperty("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 支付订单的标题，用于在收银台和消费记录展示
        /// </summary>
        [JsonProperty("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户端的唯一订单号，对于同一笔转账请求，商户需保证该订单号唯一。
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 公用回传参数，如果请求时传递了该参数，则异步通知商户时会回传该参数。
        /// </summary>
        [JsonProperty("passback_params")]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 收款方信息
        /// </summary>
        [JsonProperty("payee_info")]
        public Participant PayeeInfo { get; set; }

        /// <summary>
        /// 付款方信息
        /// </summary>
        [JsonProperty("payer_info")]
        public Participant PayerInfo { get; set; }

        /// <summary>
        /// 销售产品码，商家和支付宝签约的产品码。  STD_RED_PACKET：现金红包
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 退款超时时间，格式yyyy-MM-dd HH:mm。到指定时间后，系统会自动触发退款，并原路退回到付款账户。如果指定了退款时间，必须早于销售方案里设置的最晚退款时间。
        /// </summary>
        [JsonProperty("refund_time_expire")]
        public string RefundTimeExpire { get; set; }

        /// <summary>
        /// 支付备注
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 商户发起请求的系统时间，格式yyyy-MM-dd HH:mm。基于安全的考虑，支付宝会对请求时间间隔进行控制，超过一定时间会拒绝支付请求。
        /// </summary>
        [JsonProperty("request_time")]
        public string RequestTime { get; set; }

        /// <summary>
        /// 绝对超时时间，格式为yyyy-MM-dd HH:mm
        /// </summary>
        [JsonProperty("time_expire")]
        public string TimeExpire { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,9999999999999.99]
        /// </summary>
        [JsonProperty("trans_amount")]
        public string TransAmount { get; set; }
    }
}
