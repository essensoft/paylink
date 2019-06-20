using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EduOneCardBalanceQueryResult Data Structure.
    /// </summary>
    [Serializable]
    public class EduOneCardBalanceQueryResult : AlipayObject
    {
        /// <summary>
        /// 校园一卡通机构
        /// </summary>
        [JsonProperty("agent_code")]
        public string AgentCode { get; set; }

        /// <summary>
        /// 校园一卡通可用余额
        /// </summary>
        [JsonProperty("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 校园一卡通姓名
        /// </summary>
        [JsonProperty("card_name")]
        public string CardName { get; set; }

        /// <summary>
        /// 校园一卡通卡号
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 余额最后更新时间
        /// </summary>
        [JsonProperty("last_update_time")]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// 校园一卡通待领金额
        /// </summary>
        [JsonProperty("pound_amount")]
        public string PoundAmount { get; set; }
    }
}
