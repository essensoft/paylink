using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingEnterinfoSyncModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarParkingEnterinfoSyncModel : AlipayObject
    {
        /// <summary>
        /// 是否启用车牌代扣状态查询功能，true为启用，false为停用
        /// </summary>
        [JsonPropertyName("agreement_query")]
        public bool AgreementQuery { get; set; }

        /// <summary>
        /// 车牌颜色，车牌颜色，枚举支持： *BLUE：蓝。 *GREEN：绿。 *YELLOW：黄。 *WHITE：白。 *BLACK：黑。 *LIMEGREEN：黄绿色。
        /// </summary>
        [JsonPropertyName("car_color")]
        public string CarColor { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonPropertyName("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 用于识别车辆进口，多出入口车场适用
        /// </summary>
        [JsonPropertyName("entrance_id")]
        public string EntranceId { get; set; }

        /// <summary>
        /// 车辆入场的时间，格式"YYYY-MM-DD HH:mm:ss"，24小时制，请保证服务器时间准确，入场时间不应晚于当前网络时间
        /// </summary>
        [JsonPropertyName("in_time")]
        public string InTime { get; set; }

        /// <summary>
        /// 支付宝停车平台ID，由支付宝定义的该停车场标识，同一个isv或商户范围内唯一。通过 <a href="https://opendocs.alipay.com/apis/api_19/alipay.eco.mycar.parking.parkinglotinfo.create">alipay.eco.mycar.parking.parkinglotinfo.create</a>(录入停车场信息)接口获取。
        /// </summary>
        [JsonPropertyName("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 用于标识车辆停放车位编号，路侧适用
        /// </summary>
        [JsonPropertyName("space_number")]
        public string SpaceNumber { get; set; }

        /// <summary>
        /// 与parking_id对应的外部停车场编号，在门店中维护
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }
    }
}
