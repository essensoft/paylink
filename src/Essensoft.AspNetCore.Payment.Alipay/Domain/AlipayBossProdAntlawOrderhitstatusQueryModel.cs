using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossProdAntlawOrderhitstatusQueryModel Data Structure.
    /// </summary>
    public class AlipayBossProdAntlawOrderhitstatusQueryModel : AlipayObject
    {
        /// <summary>
        /// 请求来源系统英文名称
        /// </summary>
        [JsonPropertyName("request_app_name")]
        public string RequestAppName { get; set; }

        /// <summary>
        /// 关联业务数据编号
        /// </summary>
        [JsonPropertyName("request_biz_num")]
        public string RequestBizNum { get; set; }

        /// <summary>
        /// 请求token
        /// </summary>
        [JsonPropertyName("request_hash_value")]
        public string RequestHashValue { get; set; }

        /// <summary>
        /// 请求时间戳（请求时间的毫秒值）
        /// </summary>
        [JsonPropertyName("request_time_stamp")]
        public string RequestTimeStamp { get; set; }
    }
}
