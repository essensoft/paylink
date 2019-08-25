using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransAppConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransAppConsultModel : AlipayObject
    {
        /// <summary>
        /// 描述特定的业务场景，比如对党费缴纳场景需走党费专户。
        /// </summary>
        [JsonProperty("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// JSON格式，传递业务扩展参数，使用前请与支付宝工程师联系！
        /// </summary>
        [JsonProperty("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 商户端的唯一订单号。在咨询场景中该字段可为空。如果填写，将做格式、长度等检查。
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 收款的资金账号
        /// </summary>
        [JsonProperty("payee_info")]
        public Participant PayeeInfo { get; set; }

        /// <summary>
        /// 销售产品码，商家和支付宝签约的产品码。
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 咨询转账备注
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 如：trans_amount(转账金额)
        /// </summary>
        [JsonProperty("trans_amount")]
        public string TransAmount { get; set; }
    }
}
