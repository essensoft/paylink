using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PosOrderInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class PosOrderInfoVO : AlipayObject
    {
        /// <summary>
        /// 设备数量
        /// </summary>
        [JsonProperty("device_amount")]
        [XmlElement("device_amount")]
        public long DeviceAmount { get; set; }

        /// <summary>
        /// 数据回流ISV名称
        /// </summary>
        [JsonProperty("isv_name")]
        [XmlElement("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// 数据回流ISV_PID
        /// </summary>
        [JsonProperty("isv_pid")]
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 订单绑定设备信息列表
        /// </summary>
        [JsonProperty("machine_infos")]
        [XmlArray("machine_infos")]
        [XmlArrayItem("pos_order_device_info_v_o")]
        public List<PosOrderDeviceInfoVO> MachineInfos { get; set; }

        /// <summary>
        /// 商户手机号
        /// </summary>
        [JsonProperty("merchant_mobile")]
        [XmlElement("merchant_mobile")]
        public string MerchantMobile { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [JsonProperty("merchant_name")]
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 购买pos机订单总价格，单位元，精确到小数点后2位
        /// </summary>
        [JsonProperty("order_amt")]
        [XmlElement("order_amt")]
        public string OrderAmt { get; set; }

        /// <summary>
        /// 购买pos机设备订单来源，分为线下和线上,枚举值为: 线上(ONLINE),线下(OFFLINE)
        /// </summary>
        [JsonProperty("order_channel")]
        [XmlElement("order_channel")]
        public string OrderChannel { get; set; }

        /// <summary>
        /// 购买pos机设备订单编号：线上来源订单为订单编号，线下来源订单为合同编号
        /// </summary>
        [JsonProperty("order_no")]
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 销售人员id
        /// </summary>
        [JsonProperty("seller_id")]
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 销售人员名称
        /// </summary>
        [JsonProperty("seller_name")]
        [XmlElement("seller_name")]
        public string SellerName { get; set; }

        /// <summary>
        /// 淘宝账号
        /// </summary>
        [JsonProperty("taobao_login_id")]
        [XmlElement("taobao_login_id")]
        public string TaobaoLoginId { get; set; }
    }
}
