using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantOrderCreditPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantOrderCreditPayModel : AlipayObject
    {
        /// <summary>
        /// 订单操作类型，包括取消(CANCEL)、完结(FINISH)
        /// </summary>
        [JsonProperty("order_operate_type")]
        [XmlElement("order_operate_type")]
        public string OrderOperateType { get; set; }

        /// <summary>
        /// 外部订单号,包含字母、数字、下划线，调用方需要保证订单号唯一
        /// </summary>
        [JsonProperty("out_order_no")]
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 外部资金订单号，可包含字母、数字、下划线
        /// </summary>
        [JsonProperty("out_trans_no")]
        [XmlElement("out_trans_no")]
        public string OutTransNo { get; set; }

        /// <summary>
        /// 支付总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]，无支付行为时为空，例如订单取消或者支付金额为0
        /// </summary>
        [JsonProperty("pay_amount")]
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 订单操作说明
        /// </summary>
        [JsonProperty("remark")]
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 芝麻订单号
        /// </summary>
        [JsonProperty("zm_order_no")]
        [XmlElement("zm_order_no")]
        public string ZmOrderNo { get; set; }
    }
}
