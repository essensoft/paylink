using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OrderLogisticsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderLogisticsInfo : AlipayObject
    {
        /// <summary>
        /// 消费者下单线下服务时，填写的服务地址
        /// </summary>
        [JsonProperty("address")]
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [JsonProperty("contact_name")]
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 订单的物流扩展信息，包括服务开始时间、服务结束时间
        /// </summary>
        [JsonProperty("ext_info")]
        [XmlElement("ext_info")]
        public OrderLogisticsExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 消费者地址纬度（高德坐标系）
        /// </summary>
        [JsonProperty("latitude")]
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 消费者地址经度（高德坐标系）
        /// </summary>
        [JsonProperty("longitude")]
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 商家电话绑定的消费者手机号（阿里小号）
        /// </summary>
        [JsonProperty("merchant_bind_mobile")]
        [XmlElement("merchant_bind_mobile")]
        public string MerchantBindMobile { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [JsonProperty("mobile")]
        [XmlElement("mobile")]
        public string Mobile { get; set; }
    }
}
