using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingOrderPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingOrderPayModel : AlipayObject
    {
        /// <summary>
        /// 代扣返佣的支付宝用户号。  以2088开头的纯16位数。
        /// </summary>
        [JsonProperty("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 订单描述
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// 车牌，需要进行停车缴费代扣的车辆牌照
        /// </summary>
        [JsonProperty("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 车牌颜色
        /// </summary>
        [JsonProperty("car_number_color")]
        public string CarNumberColor { get; set; }

        /// <summary>
        /// 车场服务商指定是否开启垫付功能（若需开启，须实现签约支付宝停车垫资协议）：  true开启，  false不开启(默认)
        /// </summary>
        [JsonProperty("is_advance")]
        public bool IsAdvance { get; set; }

        /// <summary>
        /// ISV停车场ID，由ISV定义的停车场标识，系统唯一，parking_id和out_parking_id不能同时为空
        /// </summary>
        [JsonProperty("out_parking_id")]
        public string OutParkingId { get; set; }

        /// <summary>
        /// 支付宝合作商户网站唯一订单号
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付宝停车平台ID，由支付宝定义的该停车场标识，系统唯一, parking_id和out_parking_id不能同时为空
        /// </summary>
        [JsonProperty("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 卖家支付宝用户号  卖家支付宝账号对应的支付宝唯一用户号。  以2088开头的纯16位数。
        /// </summary>
        [JsonProperty("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 卖家支付宝账号，可以为email或者手机号。  如果seller_id不为空，则以seller_id的值作为卖家账号，忽略本参数。
        /// </summary>
        [JsonProperty("seller_logon_id")]
        public string SellerLogonId { get; set; }

        /// <summary>
        /// 订单标题，描述订单用途
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 订单金额，精确到小数点后两位
        /// </summary>
        [JsonProperty("total_fee")]
        public string TotalFee { get; set; }
    }
}
