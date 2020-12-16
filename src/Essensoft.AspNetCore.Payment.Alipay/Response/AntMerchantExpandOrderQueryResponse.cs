using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandOrderQueryResponse.
    /// </summary>
    public class AntMerchantExpandOrderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 申请单创建时间
        /// </summary>
        [JsonPropertyName("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 返回申请单相关参数。当前返回内容有cardAliasNo，smid
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商户角色id。间连商户或平台商二级商户业务中，本字段表示smid。审核通过后生成。
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public List<string> IpRoleId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 申请单状态。支持： 99:已完结； -1:失败； 031:已提交审核。
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
