using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TransOrderDetail Data Structure.
    /// </summary>
    public class TransOrderDetail : AlipayObject
    {
        /// <summary>
        /// JSON格式，传递业务扩展参数，使用前请与支付宝工程师联系！  sub_biz_scene: 子业务场景，取值：BAOXIAO\TRANSFER\...  withdraw_timeliness:到卡申请到账时效， T0：当日到账 T1：次日到账，如果未设置或者值为空默认T0
        /// </summary>
        [JsonPropertyName("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 转账订单的标题，用于在收银台和消费记录展示
        /// </summary>
        [JsonPropertyName("order_title")]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// JSON格式，传递业务扩展参数，使用前请与支付宝工程师联系！
        /// </summary>
        [JsonPropertyName("passback_params")]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 收款方信息
        /// </summary>
        [JsonPropertyName("payee_info")]
        public Participant PayeeInfo { get; set; }

        /// <summary>
        /// 转账备注，收、付款方均可见，收款方如果是支付宝账号，会展示在收款方账单里。
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 转账金额
        /// </summary>
        [JsonPropertyName("trans_amount")]
        public string TransAmount { get; set; }
    }
}
