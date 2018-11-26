using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AccessReturnQrcode Data Structure.
    /// </summary>
    [Serializable]
    public class AccessReturnQrcode : AlipayObject
    {
        /// <summary>
        /// 采购单ID
        /// </summary>
        [JsonProperty("asset_purchase_id")]
        [XmlElement("asset_purchase_id")]
        public string AssetPurchaseId { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [JsonProperty("express_no")]
        [XmlElement("express_no")]
        public string ExpressNo { get; set; }

        /// <summary>
        /// 外部单号（调用方业务主键）
        /// </summary>
        [JsonProperty("out_biz_no")]
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 二维码token值
        /// </summary>
        [JsonProperty("qrcode")]
        [XmlElement("qrcode")]
        public string Qrcode { get; set; }
    }
}
