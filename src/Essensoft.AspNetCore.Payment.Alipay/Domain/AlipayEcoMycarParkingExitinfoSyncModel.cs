using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingExitinfoSyncModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarParkingExitinfoSyncModel : AlipayObject
    {
        /// <summary>
        /// 车牌颜色，可选蓝-BLUE、绿-GREEN、黄-YELLOW、白-WHITE、黑-BLACK、黄绿色-LIMEGREEN
        /// </summary>
        [JsonPropertyName("car_color")]
        public string CarColor { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonPropertyName("car_number")]
        public string CarNumber { get; set; }

        /// <summary>
        /// 用于识别车辆出口，多出入口车场适用
        /// </summary>
        [JsonPropertyName("exit_id")]
        public string ExitId { get; set; }

        /// <summary>
        /// 车辆离场时间，格式"YYYY-MM-DD HH:mm:ss"，24小时制
        /// </summary>
        [JsonPropertyName("out_time")]
        public string OutTime { get; set; }

        /// <summary>
        /// 支付宝停车场ID，系统唯一
        /// </summary>
        [JsonPropertyName("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 支付宝业务流水号，用于记录车辆从驶入到驶出的全流程
        /// </summary>
        [JsonPropertyName("serial_no")]
        public string SerialNo { get; set; }

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
