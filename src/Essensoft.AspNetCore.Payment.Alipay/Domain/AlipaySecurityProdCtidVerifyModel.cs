using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdCtidVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdCtidVerifyModel : AlipayObject
    {
        /// <summary>
        /// 身份证号码
        /// </summary>
        [JsonProperty("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// 认证模式
        /// </summary>
        [JsonProperty("identify_model")]
        public string IdentifyModel { get; set; }

        /// <summary>
        /// 图片的base64编码
        /// </summary>
        [JsonProperty("picture")]
        public string Picture { get; set; }

        /// <summary>
        /// 个人用户姓名
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }
    }
}
