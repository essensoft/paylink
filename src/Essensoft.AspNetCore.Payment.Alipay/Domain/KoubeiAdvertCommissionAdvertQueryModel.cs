using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionAdvertQueryModel Data Structure.
    /// </summary>
    public class KoubeiAdvertCommissionAdvertQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询主键列表  identify_type=advert所有值都必须是推广ID  identify_type=mission所有值都必须是分佣任务ID  identify_type=voucher所有值都必须是券ID
        /// </summary>
        [JsonPropertyName("identifies")]
        public List<string> Identifies { get; set; }

        /// <summary>
        /// 查询主键类型(枚举值key对应于请求对象中查询主键列表的key)  advert-推广  mission-分佣任务  voucher-券
        /// </summary>
        [JsonPropertyName("identify_type")]
        public string IdentifyType { get; set; }
    }
}
