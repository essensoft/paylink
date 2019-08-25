using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotMdeviceprodWhitelistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotMdeviceprodWhitelistQueryModel : AlipayObject
    {
        /// <summary>
        /// 白名单所属应用的appID
        /// </summary>
        [JsonProperty("app_project_id")]
        public string AppProjectId { get; set; }

        /// <summary>
        /// 白名单分组类型。 BIZ_TYPE：表示已IoT业务类型划分的用户白名单； URL：表示已URL划分的用户白名单； SERVICE_ID：表示已接口ID划分的用户白名单；
        /// </summary>
        [JsonProperty("group_type")]
        public string GroupType { get; set; }

        /// <summary>
        /// 白名单分组值，与白名单分组类型相关。 白名单分组类型为IoT业务类型时，白名单分组值为对应的某个具体的业务类型； 白名单分组类型为URL时，白名单分组值为对应的具体的URL字符串； 白名单分组类型为服务ID时，白名单分组值为对应的具体的某个服务的ID；
        /// </summary>
        [JsonProperty("group_value")]
        public string GroupValue { get; set; }

        /// <summary>
        /// 用户标识类型,表示用户ID的类型。 ALIPAY_USER: 支付宝PID;
        /// </summary>
        [JsonProperty("user_identify_type")]
        public string UserIdentifyType { get; set; }

        /// <summary>
        /// 用于标识值，与user_identify_type相关，user_identify_type为ALIPAY_USER时，该值表示用户PID。
        /// </summary>
        [JsonProperty("user_identify_value")]
        public string UserIdentifyValue { get; set; }
    }
}
