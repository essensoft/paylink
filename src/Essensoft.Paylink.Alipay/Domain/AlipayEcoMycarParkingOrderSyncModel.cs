using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingOrderSyncModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarParkingOrderSyncModel : AlipayObject
    {
        /// <summary>
        /// 车牌
        /// </summary>
        [JsonPropertyName("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 如果是停车卡缴费，则填入停车卡卡号，否则为'*'
        /// </summary>
        [JsonPropertyName("card_number")]
        public string CardNumber { get; set; }

        /// <summary>
        /// 停车时长（以分为单位）
        /// </summary>
        [JsonPropertyName("in_duration")]
        public string InDuration { get; set; }

        /// <summary>
        /// 入场时间，格式"YYYY-MM-DD HH:mm:ss"，24小时制
        /// </summary>
        [JsonPropertyName("in_time")]
        public string InTime { get; set; }

        /// <summary>
        /// 支付宝支付流水，系统唯一
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 设备商订单状态，枚举支持： * 0：成功。 * 1：失败。
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单创建时间，格式"YYYY-MM-DD HH:mm:ss"，24小时制
        /// </summary>
        [JsonPropertyName("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 设备商订单号，由ISV系统生成
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// ISV停车场ID，由ISV定义的停车场标识，同一个isv或商户范围内唯一。需与 <a href="https://opendocs.alipay.com/apis/api_19/alipay.eco.mycar.parking.parkinglotinfo.create">alipay.eco.mycar.parking.parkinglotinfo.create</a>(录入停车场信息)接口传入值一致。
        /// </summary>
        [JsonPropertyName("out_parking_id")]
        public string OutParkingId { get; set; }

        /// <summary>
        /// 支付宝停车平台ID，由支付宝定义的该停车场标识，同一个isv或商户范围内唯一。通过 <a href="https://opendocs.alipay.com/apis/api_19/alipay.eco.mycar.parking.parkinglotinfo.create">alipay.eco.mycar.parking.parkinglotinfo.create</a>(录入停车场信息)接口获取。
        /// </summary>
        [JsonPropertyName("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 停车场名称，需与<a href="https://opendocs.alipay.com/apis/api_19/alipay.eco.mycar.parking.parkinglotinfo.create">alipay.eco.mycar.parking.parkinglotinfo.create</a>(录入停车场信息)接口传入值一致。
        /// </summary>
        [JsonPropertyName("parking_name")]
        public string ParkingName { get; set; }

        /// <summary>
        /// 缴费金额，保留小数点后两位
        /// </summary>
        [JsonPropertyName("pay_money")]
        public string PayMoney { get; set; }

        /// <summary>
        /// 缴费时间, 格式"YYYYMM-DD HH:mm:ss"，24小时制
        /// </summary>
        [JsonPropertyName("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 付款方式，枚举支持： *1：支付宝在线缴费 。 *2：支付宝代扣缴费。
        /// </summary>
        [JsonPropertyName("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 停车缴费用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 注意：ISV需保证用户 id的正确性，以免导致用户在停车平台查询不到相关的订单信息。
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
