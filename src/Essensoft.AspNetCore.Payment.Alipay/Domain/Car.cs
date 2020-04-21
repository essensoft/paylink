using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Car Data Structure.
    /// </summary>
    public class Car : AlipayObject
    {
        /// <summary>
        /// 发动机号
        /// </summary>
        [JsonPropertyName("car_engine_no")]
        public string CarEngineNo { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        [JsonPropertyName("car_frame_no")]
        public string CarFrameNo { get; set; }

        /// <summary>
        /// 品牌型号
        /// </summary>
        [JsonPropertyName("car_model_code")]
        public string CarModelCode { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonPropertyName("car_no")]
        public string CarNo { get; set; }

        /// <summary>
        /// 该车辆数据来源，1 来自 ISV，2来自保险师内部数据
        /// </summary>
        [JsonPropertyName("data_source")]
        public string DataSource { get; set; }

        /// <summary>
        /// 初次登记日期
        /// </summary>
        [JsonPropertyName("first_register_date")]
        public string FirstRegisterDate { get; set; }

        /// <summary>
        /// 是否新车
        /// </summary>
        [JsonPropertyName("is_new")]
        public string IsNew { get; set; }

        /// <summary>
        /// 天津地区行驶证地址
        /// </summary>
        [JsonPropertyName("license_address")]
        public string LicenseAddress { get; set; }

        /// <summary>
        /// 贷款车标识
        /// </summary>
        [JsonPropertyName("loan_flag")]
        public string LoanFlag { get; set; }

        /// <summary>
        /// 座位数
        /// </summary>
        [JsonPropertyName("seat_number")]
        public string SeatNumber { get; set; }

        /// <summary>
        /// 是否过户车
        /// </summary>
        [JsonPropertyName("transfer_car")]
        public string TransferCar { get; set; }

        /// <summary>
        /// 过户日期
        /// </summary>
        [JsonPropertyName("transfer_date")]
        public string TransferDate { get; set; }

        /// <summary>
        /// 精友代码和精友主体编码
        /// </summary>
        [JsonPropertyName("vehicle_info")]
        public VehicleInfo VehicleInfo { get; set; }

        /// <summary>
        /// 所有需要报价机构对应的精友码
        /// </summary>
        [JsonPropertyName("vehicle_info_list")]
        public List<VehicleInfo> VehicleInfoList { get; set; }

        /// <summary>
        /// 天津地区行驶证车辆类型
        /// </summary>
        [JsonPropertyName("vehicle_type")]
        public string VehicleType { get; set; }
    }
}
