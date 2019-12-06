using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantOperatorBatchDeleteModel Data Structure.
    /// </summary>
    public class KoubeiMerchantOperatorBatchDeleteModel : AlipayObject
    {
        /// <summary>
        /// 授权码
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 要删除的操作员ID列表，类型是List<String>； 一次最多删除16个操作员；  删除规则：   1. 传入的操作员ID对应的操作员必须都存在  2.传入的操作员ID对应的操作员必须是未激活状态，即未激活的操作员才能被删除  3.管理员和权限复核员不能删除
        /// </summary>
        [JsonPropertyName("operators")]
        public List<string> Operators { get; set; }
    }
}
