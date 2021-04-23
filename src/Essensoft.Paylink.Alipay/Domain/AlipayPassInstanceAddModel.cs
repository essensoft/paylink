using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayPassInstanceAddModel Data Structure.
    /// </summary>
    public class AlipayPassInstanceAddModel : AlipayObject
    {
        /// <summary>
        /// 支付宝用户识别信息，详见 <a href="https://opendocs.alipay.com/open/199/popvoucher#%E7%AC%AC%E4%BA%94%E6%AD%A5%EF%BC%9A%E8%B0%83%E7%94%A8%E6%8E%A5%E5%8F%A3%E5%8F%91%E5%88%B8">调用接口发券</a>。
        /// </summary>
        [JsonPropertyName("recognition_info")]
        public string RecognitionInfo { get; set; }

        /// <summary>
        /// Alipass添加对象识别类型，枚举如下： 1：订单信息； 2：基于用户信息识别。 说明：支付宝卡包场景暂仅支持 2。
        /// </summary>
        [JsonPropertyName("recognition_type")]
        public string RecognitionType { get; set; }

        /// <summary>
        ///  支付宝pass模版ID。通过<a href="https://opendocs.alipay.com/apis/api_24/alipay.pass.template.add">alipay.pass.template.add</a>(卡券模板创建接口)创建模板后返回的tpl_id。
        /// </summary>
        [JsonPropertyName("tpl_id")]
        public string TplId { get; set; }

        /// <summary>
        /// 模版动态参数信息，对应模板中$变量名$的动态参数。对应<a href="https://opendocs.alipay.com/apis/api_24/alipay.pass.template.add">alipay.pass.template.add</a>(卡券模板创建接口)创建模板后返回tpl_params字段。
        /// </summary>
        [JsonPropertyName("tpl_params")]
        public string TplParams { get; set; }
    }
}
