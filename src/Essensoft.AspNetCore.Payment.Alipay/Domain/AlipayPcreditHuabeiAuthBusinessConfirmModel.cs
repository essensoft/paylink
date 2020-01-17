using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiAuthBusinessConfirmModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiAuthBusinessConfirmModel : AlipayObject
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号。
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 商户业务信息确认时带入的业务信息
        /// </summary>
        [JsonPropertyName("biz_params")]
        public BizExtParams BizParams { get; set; }

        /// <summary>
        /// 用于描述商户需要回执的业务类型。如签约：SIGN
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 商户业务确认说明描述
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号，用于标示请求流水的唯一性，不能包含除英文、数字以外的字符，需要保证在商户端不重复。
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户的支付宝用户id。如果该值为空，则默认为商户签约账号对应的支付宝用户ID。
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }
    }
}
