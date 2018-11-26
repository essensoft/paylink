using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAssetPointOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAssetPointOrderQueryModel : AlipayObject
    {
        /// <summary>
        /// isv提供的发放号订单号，由数字和字母组成，最大长度为32为，需要保证每笔发放的唯一性，集分宝系统会对该参数做唯一性控制。调用接口后集分宝系统会根据这个外部订单号查询发放的订单详情。
        /// </summary>
        [JsonProperty("merchant_order_no")]
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }
    }
}
