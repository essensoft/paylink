using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VulInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VulInfo : AlipayObject
    {
        /// <summary>
        /// 漏洞附件下载链接
        /// </summary>
        [JsonProperty("attachment")]
        public string Attachment { get; set; }

        /// <summary>
        /// 漏洞所属业务
        /// </summary>
        [JsonProperty("business")]
        public string Business { get; set; }

        /// <summary>
        /// 漏洞安全币奖励
        /// </summary>
        [JsonProperty("coin")]
        public long Coin { get; set; }

        /// <summary>
        /// 漏洞所属公司
        /// </summary>
        [JsonProperty("company")]
        public long Company { get; set; }

        /// <summary>
        /// 确认漏洞等级
        /// </summary>
        [JsonProperty("confirm_level")]
        public long ConfirmLevel { get; set; }

        /// <summary>
        /// 漏洞确认时间
        /// </summary>
        [JsonProperty("confirm_time")]
        public string ConfirmTime { get; set; }

        /// <summary>
        /// 漏洞详情
        /// </summary>
        [JsonProperty("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// 漏洞修复时间
        /// </summary>
        [JsonProperty("fix_time")]
        public string FixTime { get; set; }

        /// <summary>
        /// 用户上报等级
        /// </summary>
        [JsonProperty("level")]
        public long Level { get; set; }

        /// <summary>
        /// 白帽子提交漏洞时填写的手机号
        /// </summary>
        [JsonProperty("mobile_phone")]
        public string MobilePhone { get; set; }

        /// <summary>
        /// 漏洞名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 白帽子昵称
        /// </summary>
        [JsonProperty("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 漏洞被驳回原因
        /// </summary>
        [JsonProperty("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 漏洞评分奖励
        /// </summary>
        [JsonProperty("score")]
        public long Score { get; set; }

        /// <summary>
        /// 漏洞状态
        /// </summary>
        [JsonProperty("status")]
        public long Status { get; set; }

        /// <summary>
        /// 漏洞提交时间
        /// </summary>
        [JsonProperty("submit_time")]
        public string SubmitTime { get; set; }

        /// <summary>
        /// 一级类型ID
        /// </summary>
        [JsonProperty("type_sub_first_id")]
        public long TypeSubFirstId { get; set; }

        /// <summary>
        /// 一级漏洞类型名称
        /// </summary>
        [JsonProperty("type_sub_first_name")]
        public string TypeSubFirstName { get; set; }

        /// <summary>
        /// 二级类型ID
        /// </summary>
        [JsonProperty("type_sub_second_id")]
        public long TypeSubSecondId { get; set; }

        /// <summary>
        /// 二级漏洞类型名称
        /// </summary>
        [JsonProperty("type_sub_second_name")]
        public string TypeSubSecondName { get; set; }

        /// <summary>
        /// 漏洞 URL
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// 漏洞id
        /// </summary>
        [JsonProperty("vul_id")]
        public long VulId { get; set; }
    }
}
