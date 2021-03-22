using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BusinessItem Data Structure.
    /// </summary>
    public class BusinessItem : AlipayObject
    {
        /// <summary>
        /// 业务归属appid
        /// </summary>
        [JsonPropertyName("business_appid")]
        public string BusinessAppid { get; set; }

        /// <summary>
        /// 业务收款pid，business_type为AGREEMENT_PAY时，此参数必传
        /// </summary>
        [JsonPropertyName("business_payee_id")]
        public string BusinessPayeeId { get; set; }

        /// <summary>
        /// 业务归属pid
        /// </summary>
        [JsonPropertyName("business_pid")]
        public string BusinessPid { get; set; }

        /// <summary>
        /// 业务类型ONLINE_PAY(在线缴费) 、AGREEMENT_PAY(无感停车)
        /// </summary>
        [JsonPropertyName("business_type")]
        public string BusinessType { get; set; }
    }
}
