using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OperatorQuery Data Structure.
    /// </summary>
    public class OperatorQuery : AlipayObject
    {
        /// <summary>
        /// 查询操作员的唯一ID。类型由id_type决定
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// id参数的类型。取值如下： OPERATOR_ID=id填操作员ID USER_ID=id填支付宝登录userId LOGON_ID=id填操作员的登录号
        /// </summary>
        [JsonPropertyName("id_type")]
        public string IdType { get; set; }

        /// <summary>
        /// 操作员登录号类型。id_type为LOGON_ID时必填。 枚举值参考LogonIdTypeEnum 范围如下：  1=手机号 2=Email 3=企业操作员昵称方式
        /// </summary>
        [JsonPropertyName("logon_id_type")]
        public string LogonIdType { get; set; }
    }
}
