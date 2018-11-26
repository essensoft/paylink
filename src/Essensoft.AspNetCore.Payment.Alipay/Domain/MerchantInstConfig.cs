using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MerchantInstConfig Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantInstConfig : AlipayObject
    {
        /// <summary>
        /// 机构短名称，既是合作机构的英文简称，用来标识该机构的唯一性；
        /// </summary>
        [JsonProperty("en_name")]
        [XmlElement("en_name")]
        public string EnName { get; set; }

        /// <summary>
        /// 支付宝定义的业务类型，JF表示公共事业缴费，HK表示信用卡还款具体见附录描述
        /// </summary>
        [JsonProperty("order_type")]
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 业务场景；分为销帐(chargeoff)和输出(EXTERNAL)
        /// </summary>
        [JsonProperty("scene")]
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 合作机构中文名称，如HZCB，中文名称：杭州银行
        /// </summary>
        [JsonProperty("zh_name")]
        [XmlElement("zh_name")]
        public string ZhName { get; set; }
    }
}
