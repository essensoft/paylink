using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPassInstanceAddModel Data Structure.
    /// </summary>
    public class AlipayPassInstanceAddModel : AlipayObject
    {
        /// <summary>
        /// 支付宝用户识别信息：uid发券组件。对接文档：https://docs.open.alipay.com/199/sy3hs4
        /// </summary>
        [JsonPropertyName("recognition_info")]
        public string RecognitionInfo { get; set; }

        /// <summary>
        /// Alipass添加对象识别类型：1–订单信息
        /// </summary>
        [JsonPropertyName("recognition_type")]
        public string RecognitionType { get; set; }

        /// <summary>
        /// 支付宝pass模版ID，即调用模板创建接口时返回的tpl_id。
        /// </summary>
        [JsonPropertyName("tpl_id")]
        public string TplId { get; set; }

        /// <summary>
        /// 模版动态参数信息：对应模板中$变量名$的动态参数，见模板创建接口返回值中的tpl_params字段
        /// </summary>
        [JsonPropertyName("tpl_params")]
        public string TplParams { get; set; }
    }
}
