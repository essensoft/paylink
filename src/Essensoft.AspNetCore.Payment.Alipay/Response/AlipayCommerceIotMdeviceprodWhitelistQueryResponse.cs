using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodWhitelistQueryResponse.
    /// </summary>
    public class AlipayCommerceIotMdeviceprodWhitelistQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 白名单所属应用的appID
        /// </summary>
        [JsonPropertyName("app_project_id")]
        public string AppProjectId { get; set; }

        /// <summary>
        /// 白名单所属应用的状态。 OPEN：开启；CLOSE：关闭；
        /// </summary>
        [JsonPropertyName("app_white_list_status")]
        public string AppWhiteListStatus { get; set; }

        /// <summary>
        /// 白名单开始生效时间。不指定时表示有记录则生效。
        /// </summary>
        [JsonPropertyName("effective_time")]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 白名单过期时间。不指定时表示有记录则永不过期。
        /// </summary>
        [JsonPropertyName("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 白名单的扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 白名单记录创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 白名单记录更新时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 白名单分组类型。 BIZ_TYPE：表示已IoT业务类型划分的用户白名单； URL：表示已URL划分的用户白名单； SERVICE_ID：表示已接口ID划分的用户白名单；
        /// </summary>
        [JsonPropertyName("group_type")]
        public string GroupType { get; set; }

        /// <summary>
        /// 白名单分组值，与白名单分组类型相关。 白名单分组类型为IoT业务类型时，白名单分组值为对应的某个具体的业务类型； 白名单分组类型为URL时，白名单分组值为对应的具体的URL字符串； 白名单分组类型为服务ID时，白名单分组值为对应的具体的某个服务的ID；
        /// </summary>
        [JsonPropertyName("group_value")]
        public string GroupValue { get; set; }

        /// <summary>
        /// 白名单的文本备注信息
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 用户标识类型,表示用户ID的类型。 ALIPAY_USER: 支付宝PID;
        /// </summary>
        [JsonPropertyName("user_identify_type")]
        public string UserIdentifyType { get; set; }

        /// <summary>
        /// 用于标识值，与user_identify_type相关，user_identify_type为ALIPAY_USER时，该值表示用户PID。
        /// </summary>
        [JsonPropertyName("user_identify_value")]
        public string UserIdentifyValue { get; set; }
    }
}
