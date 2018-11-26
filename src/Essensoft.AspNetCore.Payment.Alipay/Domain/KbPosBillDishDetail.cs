using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbPosBillDishDetail Data Structure.
    /// </summary>
    [Serializable]
    public class KbPosBillDishDetail : AlipayObject
    {
        /// <summary>
        /// pos本地订单菜明细流水号
        /// </summary>
        [JsonProperty("out_detail_no")]
        [XmlElement("out_detail_no")]
        public string OutDetailNo { get; set; }

        /// <summary>
        /// 优免分摊金额（包含内部和外部优惠），以元为单位，精度到分
        /// </summary>
        [JsonProperty("trans_amount")]
        [XmlElement("trans_amount")]
        public string TransAmount { get; set; }
    }
}
