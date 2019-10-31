using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiAuthBusinessConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiAuthBusinessConfirmModel : AlipayObject
    {
        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号。
        /// </summary>
        [JsonProperty("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        [JsonProperty("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 用于描述商户需要回执的业务类型。如签约：SIGN
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号，用于标示请求流水的唯一性，不能包含除英文、数字以外的字符，需要保证在商户端不重复。
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户的支付宝用户id。如果该值为空，则默认为商户签约账号对应的支付宝用户ID。
        /// </summary>
        [JsonProperty("seller_id")]
        public string SellerId { get; set; }
    }
}
