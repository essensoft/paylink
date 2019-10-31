using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasRemitFundInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasRemitFundInitializeModel : AlipayObject
    {
        /// <summary>
        /// 发端生成的单据号
        /// </summary>
        [JsonProperty("bc_remit_id")]
        public string BcRemitId { get; set; }

        /// <summary>
        /// 区块链上需要做合规检查的mid
        /// </summary>
        [JsonProperty("compliance_mid")]
        public string ComplianceMid { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonProperty("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 报价和路由信息
        /// </summary>
        [JsonProperty("quote_route_info")]
        public string QuoteRouteInfo { get; set; }

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
        /// 収端用户信息
        /// </summary>
        [JsonProperty("receiver_info")]
        public string ReceiverInfo { get; set; }

        /// <summary>
        /// 接收端的mid
        /// </summary>
        [JsonProperty("receiver_mid")]
        public string ReceiverMid { get; set; }

        /// <summary>
        /// 汇款附言
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 汇款用途
        /// </summary>
        [JsonProperty("remit_purpose")]
        public string RemitPurpose { get; set; }

        /// <summary>
        /// 汇款发起的时间
        /// </summary>
        [JsonProperty("send_date")]
        public string SendDate { get; set; }

        /// <summary>
        /// 发端用户的地址
        /// </summary>
        [JsonProperty("sender_address")]
        public string SenderAddress { get; set; }

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
        /// 发端用户的用户id
        /// </summary>
        [JsonProperty("sender_id")]
        public string SenderId { get; set; }

        /// <summary>
        /// 发端用户信息
        /// </summary>
        [JsonProperty("sender_info")]
        public string SenderInfo { get; set; }

        /// <summary>
        /// 发端的mid
        /// </summary>
        [JsonProperty("sender_mid")]
        public string SenderMid { get; set; }

        /// <summary>
        /// 发端用户的国籍
        /// </summary>
        [JsonProperty("sender_nationality")]
        public string SenderNationality { get; set; }

        /// <summary>
        /// 交易币种
        /// </summary>
        [JsonProperty("trans_currency")]
        public string TransCurrency { get; set; }
    }
}
