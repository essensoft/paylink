using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OutboundOrder Data Structure.
    /// </summary>
    [Serializable]
    public class OutboundOrder : AlipayObject
    {
        /// <summary>
        /// 扩展字段，json格式
        /// </summary>
        [JsonProperty("ext_info")]
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [JsonProperty("out_biz_no")]
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 出库业务类型，CGCK=采购出库，DDCK=订单出库，PDCK=盘点出库
        /// </summary>
        [JsonProperty("outbound_type")]
        [XmlElement("outbound_type")]
        public string OutboundType { get; set; }

        /// <summary>
        /// 收货人信息（商家采购必须传，其他订单类型非必传）
        /// </summary>
        [JsonProperty("receiver_info_vo")]
        [XmlElement("receiver_info_vo")]
        public ReceiverInfoVO ReceiverInfoVo { get; set; }

        /// <summary>
        /// 备注信息。
        /// </summary>
        [JsonProperty("remark")]
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 发货人信息
        /// </summary>
        [JsonProperty("sender_info_vo")]
        [XmlElement("sender_info_vo")]
        public SenderInfoVO SenderInfoVo { get; set; }

        /// <summary>
        /// 仓库编号
        /// </summary>
        [JsonProperty("warehouse_code")]
        [XmlElement("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
