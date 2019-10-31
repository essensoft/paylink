using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasRemitFundTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasRemitFundTransferModel : AlipayObject
    {
        /// <summary>
        /// 汇率的基准币种
        /// </summary>
        [JsonProperty("base_currency")]
        public string BaseCurrency { get; set; }

        /// <summary>
        /// 发端生成的单据号
        /// </summary>
        [JsonProperty("bc_remit_id")]
        public string BcRemitId { get; set; }

        /// <summary>
        /// 汇率
        /// </summary>
        [JsonProperty("exchange_rate")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// 收端用户收到的金额
        /// </summary>
        [JsonProperty("receiver_amount")]
        public string ReceiverAmount { get; set; }

        /// <summary>
        /// 收端用户收到的金额币种
        /// </summary>
        [JsonProperty("receiver_currency")]
        public string ReceiverCurrency { get; set; }

        /// <summary>
        /// 接收端的mid
        /// </summary>
        [JsonProperty("receiver_mid")]
        public string ReceiverMid { get; set; }

        /// <summary>
        /// 发端用户的金额
        /// </summary>
        [JsonProperty("sender_amount")]
        public string SenderAmount { get; set; }

        /// <summary>
        /// 发端用户金额的币种
        /// </summary>
        [JsonProperty("sender_currency")]
        public string SenderCurrency { get; set; }

        /// <summary>
        /// 发端的mid
        /// </summary>
        [JsonProperty("sender_mid")]
        public string SenderMid { get; set; }
    }
}
