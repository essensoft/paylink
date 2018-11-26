using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsInboundorderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsInboundorderQueryModel : AlipayObject
    {
        /// <summary>
        /// 入库通知单id（与外部单号二选一，必填其中一个）
        /// </summary>
        [JsonProperty("inbound_order_id")]
        [XmlElement("inbound_order_id")]
        public string InboundOrderId { get; set; }

        /// <summary>
        /// 是否需要明细。true返回明细，false不返回。
        /// </summary>
        [JsonProperty("need_detail")]
        [XmlElement("need_detail")]
        public bool NeedDetail { get; set; }

        /// <summary>
        /// 外部业务单号（与入库通知单id二选一，必填一个）
        /// </summary>
        [JsonProperty("out_biz_no")]
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
