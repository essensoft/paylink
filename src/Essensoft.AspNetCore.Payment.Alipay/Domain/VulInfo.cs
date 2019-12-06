using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VulInfo Data Structure.
    /// </summary>
    public class VulInfo : AlipayObject
    {
        /// <summary>
        /// 漏洞附件下载链接
        /// </summary>
        [JsonPropertyName("attachment")]
        public string Attachment { get; set; }

        /// <summary>
        /// 漏洞所属业务
        /// </summary>
        [JsonPropertyName("business")]
        public string Business { get; set; }

        /// <summary>
        /// 漏洞安全币奖励
        /// </summary>
        [JsonPropertyName("coin")]
        public long Coin { get; set; }

        /// <summary>
        /// 漏洞所属公司
        /// </summary>
        [JsonPropertyName("company")]
        public long Company { get; set; }

        /// <summary>
        /// 确认漏洞等级
        /// </summary>
        [JsonPropertyName("confirm_level")]
        public long ConfirmLevel { get; set; }

        /// <summary>
        /// 漏洞确认时间
        /// </summary>
        [JsonPropertyName("confirm_time")]
        public string ConfirmTime { get; set; }

        /// <summary>
        /// 漏洞详情
        /// </summary>
        [JsonPropertyName("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// 漏洞修复时间
        /// </summary>
        [JsonPropertyName("fix_time")]
        public string FixTime { get; set; }

        /// <summary>
        /// 用户上报等级
        /// </summary>
        [JsonPropertyName("level")]
        public long Level { get; set; }

        /// <summary>
        /// 白帽子提交漏洞时填写的手机号
        /// </summary>
        [JsonPropertyName("mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 漏洞名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 白帽子昵称
        /// </summary>
        [JsonPropertyName("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 漏洞被驳回原因
        /// </summary>
        [JsonPropertyName("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 漏洞评分奖励
        /// </summary>
        [JsonPropertyName("score")]
        public long Score { get; set; }

        /// <summary>
        /// 漏洞状态
        /// </summary>
        [JsonPropertyName("status")]
        public long Status { get; set; }

        /// <summary>
        /// 漏洞提交时间
        /// </summary>
        [JsonPropertyName("submit_time")]
        public string SubmitTime { get; set; }

        /// <summary>
        /// 一级类型ID
        /// </summary>
        [JsonPropertyName("type_sub_first_id")]
        public long TypeSubFirstId { get; set; }

        /// <summary>
        /// 一级漏洞类型名称
        /// </summary>
        [JsonPropertyName("type_sub_first_name")]
        public string TypeSubFirstName { get; set; }

        /// <summary>
        /// 二级类型ID
        /// </summary>
        [JsonPropertyName("type_sub_second_id")]
        public long TypeSubSecondId { get; set; }

        /// <summary>
        /// 二级漏洞类型名称
        /// </summary>
        [JsonPropertyName("type_sub_second_name")]
        public string TypeSubSecondName { get; set; }

        /// <summary>
        /// 漏洞 URL
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// 漏洞id
        /// </summary>
        [JsonPropertyName("vul_id")]
        public long VulId { get; set; }
    }
}
