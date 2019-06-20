using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransAacollectPayorderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransAacollectPayorderCreateModel : AlipayObject
    {
        /// <summary>
        /// 批次号，创建批次返回
        /// </summary>
        [JsonProperty("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 创建批次返回的batchToken
        /// </summary>
        [JsonProperty("batch_token")]
        public string BatchToken { get; set; }

        /// <summary>
        /// 调用方扩充参数，json格式map
        /// </summary>
        [JsonProperty("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        [JsonProperty("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 当前支付宝userId，即付款方支付宝用户uid
        /// </summary>
        [JsonProperty("payer_user_id")]
        public string PayerUserId { get; set; }

        /// <summary>
        /// 进入付款来源，仅记录      吱口令：shakeCode      二维码：qrCode      小程序：mini      其他来源（包括正常流程）：null
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }
    }
}
