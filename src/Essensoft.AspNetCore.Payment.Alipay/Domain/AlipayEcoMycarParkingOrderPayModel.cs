using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingOrderPayModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarParkingOrderPayModel : AlipayObject
    {
        /// <summary>
        /// 代扣返佣的支付宝用户号。  以2088开头的纯16位数。
        /// </summary>
        [JsonPropertyName("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 订单描述
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; set; }

        /// <summary>
        /// 车牌，需要进行停车缴费代扣的车辆牌照
        /// </summary>
        [JsonPropertyName("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 车牌颜色，可选蓝-BLUE、绿-GREEN、黄-YELLOW、白-WHITE、黑-BLACK、黄绿色-LIMEGREEN
        /// </summary>
        [JsonPropertyName("car_number_color")]
        public string CarNumberColor { get; set; }

        /// <summary>
        /// 车场服务商指定是否开启垫付功能（若需开启，须实现签约支付宝停车垫资协议）：  true开启，  false不开启(默认)
        /// </summary>
        [JsonPropertyName("is_advance")]
        public bool IsAdvance { get; set; }

        /// <summary>
        /// ISV停车场ID，由ISV定义的停车场标识，系统唯一，必填
        /// </summary>
        [JsonPropertyName("out_parking_id")]
        public string OutParkingId { get; set; }

        /// <summary>
        /// 支付宝合作商户网站唯一订单号
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付宝停车平台ID，由支付宝定义的该停车场标识，系统唯一, 必填
        /// </summary>
        [JsonPropertyName("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 卖家支付宝用户号  卖家支付宝账号对应的支付宝唯一用户号。  以2088开头的纯16位数。
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 卖家支付宝账号，可以为email或者手机号。  如果seller_id不为空，则以seller_id的值作为卖家账号，忽略本参数。
        /// </summary>
        [JsonPropertyName("seller_logon_id")]
        public string SellerLogonId { get; set; }

        /// <summary>
        /// 支付宝业务流水号，用于记录车辆从驶入到驶出的全流程
        /// </summary>
        [JsonPropertyName("serial_no")]
        public string SerialNo { get; set; }

        /// <summary>
        /// 订单标题，描述订单用途
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 订单金额，精确到小数点后两位
        /// </summary>
        [JsonPropertyName("total_fee")]
        public string TotalFee { get; set; }
    }
}
