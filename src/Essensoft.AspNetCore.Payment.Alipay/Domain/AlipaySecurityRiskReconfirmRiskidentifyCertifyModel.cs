using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskReconfirmRiskidentifyCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskReconfirmRiskidentifyCertifyModel : AlipayObject
    {
        /// <summary>
        /// 登录对应的账号名
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// 接入的应用编号
        /// </summary>
        [JsonProperty("app_code")]
        public string AppCode { get; set; }

        /// <summary>
        /// 用户所属公司
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }

        /// <summary>
        /// 额外参数
        /// </summary>
        [JsonProperty("extend_param")]
        public string ExtendParam { get; set; }

        /// <summary>
        /// 具体场景对应的code
        /// </summary>
        [JsonProperty("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 用户关联的租户id list
        /// </summary>
        [JsonProperty("tenant_id_list")]
        public string TenantIdList { get; set; }

        /// <summary>
        /// 设备指纹id
        /// </summary>
        [JsonProperty("um_id")]
        public string UmId { get; set; }

        /// <summary>
        /// 采集设备指纹信息对应的token
        /// </summary>
        [JsonProperty("um_id_token")]
        public string UmIdToken { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
