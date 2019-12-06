using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipassInstanceOpInfo Data Structure.
    /// </summary>
    public class AlipassInstanceOpInfo : AlipayObject
    {
        /// <summary>
        /// alipass实例信息顺序，正整数，按order顺排，不可重复。
        /// </summary>
        [JsonPropertyName("order")]
        public long Order { get; set; }

        /// <summary>
        /// 支付宝alipass模版ID，即调用模板创建接口时返回的tpl_id。
        /// </summary>
        [JsonPropertyName("tpl_id")]
        public string TplId { get; set; }

        /// <summary>
        /// 模版动态参数信息：对应模板中$变量名$的动态参数，见模板创建接口返回值中的tpl_params字段。
        /// </summary>
        [JsonPropertyName("tpl_params")]
        public string TplParams { get; set; }
    }
}
