using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicAccountQueryResponse.
    /// </summary>
    public class AlipayMobilePublicAccountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("code")]
        public override string Code { get; set; }

        /// <summary>
        /// 菜单唯一标识
        /// </summary>
        [JsonPropertyName("menu_key")]
        public string MenuKey { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [JsonPropertyName("msg")]
        public override string Msg { get; set; }

        /// <summary>
        /// 绑定账户列表
        /// </summary>
        [JsonPropertyName("public_bind_accounts")]
        public List<PublicBindAccount> PublicBindAccounts { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }
    }
}
