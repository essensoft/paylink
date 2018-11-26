using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeliveryPackageDetail Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryPackageDetail : AlipayObject
    {
        /// <summary>
        /// 运单号
        /// </summary>
        [JsonProperty("express_code")]
        [XmlElement("express_code")]
        public string ExpressCode { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("gmt_create")]
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("gmt_modified")]
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 货品编码
        /// </summary>
        [JsonProperty("goods_code")]
        [XmlElement("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 货品数量
        /// </summary>
        [JsonProperty("goods_quantity")]
        [XmlElement("goods_quantity")]
        public string GoodsQuantity { get; set; }

        /// <summary>
        /// 包裹编号
        /// </summary>
        [JsonProperty("package_code")]
        [XmlElement("package_code")]
        public string PackageCode { get; set; }
    }
}
