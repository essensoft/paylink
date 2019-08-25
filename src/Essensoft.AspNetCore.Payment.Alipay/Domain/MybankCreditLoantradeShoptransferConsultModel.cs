using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditLoantradeShoptransferConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeShoptransferConsultModel : AlipayObject
    {
        /// <summary>
        /// 咨询业务类型,TRANSFER(转让)/RECEIVE(接收)
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 接收方支付宝id
        /// </summary>
        [JsonProperty("receive_alipay_id")]
        public string ReceiveAlipayId { get; set; }

        /// <summary>
        /// 淘宝userId
        /// </summary>
        [JsonProperty("taobao_id")]
        public string TaobaoId { get; set; }

        /// <summary>
        /// 转让流程编号
        /// </summary>
        [JsonProperty("trans_no")]
        public string TransNo { get; set; }

        /// <summary>
        /// 转让方支付宝id
        /// </summary>
        [JsonProperty("transfer_alipay_id")]
        public string TransferAlipayId { get; set; }
    }
}
