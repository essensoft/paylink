using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsInvoiceApplyItem Data Structure.
    /// </summary>
    [Serializable]
    public class InsInvoiceApplyItem : AlipayObject
    {
        /// <summary>
        /// 申请发票开票维度;BUSINESS_ORDER:业务单;
        /// </summary>
        [JsonProperty("apply_scope")]
        [XmlElement("apply_scope")]
        public string ApplyScope { get; set; }

        /// <summary>
        /// 费用类型;PREMIUM:保费;
        /// </summary>
        [JsonProperty("expense_type")]
        [XmlElement("expense_type")]
        public string ExpenseType { get; set; }

        /// <summary>
        /// 业务单号;apply_scope为BUSINESS_ORDER时必填;
        /// </summary>
        [JsonProperty("ins_biz_no")]
        [XmlElement("ins_biz_no")]
        public string InsBizNo { get; set; }

        /// <summary>
        /// 业务单类型;APPLICATION:投保订单;POLICY:保单;ENDORSEMENT:批单;RECOVERY;追偿单.  apply_scope为BUSINESS_ORDER时必填;
        /// </summary>
        [JsonProperty("ins_biz_type")]
        [XmlElement("ins_biz_type")]
        public string InsBizType { get; set; }
    }
}
