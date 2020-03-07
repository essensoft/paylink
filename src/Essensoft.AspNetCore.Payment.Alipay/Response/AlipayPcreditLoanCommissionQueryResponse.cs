using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditLoanCommissionQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanCommissionQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动期间累计佣金金额
        /// </summary>
        [JsonPropertyName("activity_commission_amt")]
        public string ActivityCommissionAmt { get; set; }

        /// <summary>
        /// 活动期间累计佣金排名
        /// </summary>
        [JsonPropertyName("activity_commission_rank")]
        public string ActivityCommissionRank { get; set; }

        /// <summary>
        /// 是否活动期内
        /// </summary>
        [JsonPropertyName("activity_period")]
        public bool ActivityPeriod { get; set; }

        /// <summary>
        /// 企业ID，如居然之家、红星美凯龙等
        /// </summary>
        [JsonPropertyName("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
