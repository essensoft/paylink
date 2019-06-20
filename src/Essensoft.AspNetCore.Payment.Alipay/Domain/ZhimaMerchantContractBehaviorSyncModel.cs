using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantContractBehaviorSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantContractBehaviorSyncModel : AlipayObject
    {
        /// <summary>
        /// 履约动作发生时间，如果重试需要保证为首次动作发生的时间
        /// </summary>
        [JsonProperty("action_time")]
        public string ActionTime { get; set; }

        /// <summary>
        /// 履约接口操作类型，必须在以下列表中：  CREATE - 创建履约  FINISH - 完成履约  CANCEL - 取消履约
        /// </summary>
        [JsonProperty("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 承诺消费合约号，唯一定位用户的一笔合约
        /// </summary>
        [JsonProperty("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 商户业务订单号。使用pid+out_biz_no做幂等。每次反馈pid+out_biz_no需保持唯一，重试除外。
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝交易单号，由支付宝交易接口生成，唯一定位一次交易。如果合约涉及支付宝交易，必传
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易订单金额，单位为分，表示该次履约的订单金额，与trade_no配合使用
        /// </summary>
        [JsonProperty("trade_order_amount")]
        public string TradeOrderAmount { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，唯一键标识用户身份。
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
