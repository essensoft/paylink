using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossProdAntlegalchainOrderModifyModel Data Structure.
    /// </summary>
    public class AlipayBossProdAntlegalchainOrderModifyModel : AlipayObject
    {
        /// <summary>
        /// 发起签约接口返回的baseDataId
        /// </summary>
        [JsonPropertyName("bas_data_id")]
        public string BasDataId { get; set; }

        /// <summary>
        /// 业务数据请求唯一标识，需要保证唯一性
        /// </summary>
        [JsonPropertyName("biz_unique_id")]
        public string BizUniqueId { get; set; }

        /// <summary>
        /// 公司名称和公司社会信用编码二者必传
        /// </summary>
        [JsonPropertyName("corp_code")]
        public string CorpCode { get; set; }

        /// <summary>
        /// 公司名称和公司社会信用编码二者必传
        /// </summary>
        [JsonPropertyName("corp_name")]
        public string CorpName { get; set; }

        /// <summary>
        /// 操作人邮箱
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// 签约操作原因，撤回签约操作建议传参
        /// </summary>
        [JsonPropertyName("op_reason")]
        public string OpReason { get; set; }

        /// <summary>
        /// 签约操作类型 (CANCEL: 撤回签约；APPROVE: 确认签约)
        /// </summary>
        [JsonPropertyName("op_type")]
        public string OpType { get; set; }

        /// <summary>
        /// 请求来源系统英文名称
        /// </summary>
        [JsonPropertyName("request_app_name")]
        public string RequestAppName { get; set; }

        /// <summary>
        /// 请求时间戳（请求时间的毫秒值）
        /// </summary>
        [JsonPropertyName("request_time_stamp")]
        public string RequestTimeStamp { get; set; }

        /// <summary>
        /// 请求token
        /// </summary>
        [JsonPropertyName("request_token")]
        public string RequestToken { get; set; }

        /// <summary>
        /// 阿里账号统一ID，特殊需求时使用
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
