using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPassInstanceAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPassInstanceAddModel : AlipayObject
    {
        /// <summary>
        /// 支付宝用户识别信息：  包括partner_id（商户的签约账号）和out_trade_no（某笔订单号）
        /// </summary>
        [JsonProperty("recognition_info")]
        [XmlElement("recognition_info")]
        public string RecognitionInfo { get; set; }

        /// <summary>
        /// Alipass添加对象识别类型：1–订单信息
        /// </summary>
        [JsonProperty("recognition_type")]
        [XmlElement("recognition_type")]
        public string RecognitionType { get; set; }

        /// <summary>
        /// 支付宝pass模版ID
        /// </summary>
        [JsonProperty("tpl_id")]
        [XmlElement("tpl_id")]
        public string TplId { get; set; }

        /// <summary>
        /// 模版动态参数信息：对应模板中$变量名$的动态参数，见模板创建接口返回值中的tpl_params字段
        /// </summary>
        [JsonProperty("tpl_params")]
        [XmlElement("tpl_params")]
        public string TplParams { get; set; }
    }
}
