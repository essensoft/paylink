using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditLoanCollateralCarModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanCollateralCarModifyModel : AlipayObject
    {
        /// <summary>
        /// 业务流水号，即用户授信申请的单号，每次授信申请由借呗平台生成的唯一编号，通知估值时给到机构
        /// </summary>
        [JsonProperty("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 车辆品牌标识，合作机构提供的车型库，如：  1表示奥迪
        /// </summary>
        [JsonProperty("car_brand_id")]
        public string CarBrandId { get; set; }

        /// <summary>
        /// 车辆品牌名称，合作机构提供的车型库
        /// </summary>
        [JsonProperty("car_brand_name")]
        public string CarBrandName { get; set; }

        /// <summary>
        /// 车辆颜色（中文），合作机构提供的颜色范围，如：  米色，棕色，金色，紫色，巧克力色，黑色，蓝色，灰色，绿色，红色，橙色，白色，香槟色，银色，黄色
        /// </summary>
        [JsonProperty("car_color")]
        public string CarColor { get; set; }

        /// <summary>
        /// 发动机号
        /// </summary>
        [JsonProperty("car_engine_no")]
        public string CarEngineNo { get; set; }

        /// <summary>
        /// 行驶里程数，单位：公里
        /// </summary>
        [JsonProperty("car_mileage")]
        public long CarMileage { get; set; }

        /// <summary>
        /// 车型标识，合作机构提供的车型库，如：  1127895表示2017款 奥迪A8L A8L 45 TFSI quattro舒适型
        /// </summary>
        [JsonProperty("car_model_id")]
        public string CarModelId { get; set; }

        /// <summary>
        /// 车型名称，合作机构提供的车型库
        /// </summary>
        [JsonProperty("car_model_name")]
        public string CarModelName { get; set; }

        /// <summary>
        /// 车辆注册日期（行驶证上注册时间），格式：yyyy-MM-dd
        /// </summary>
        [JsonProperty("car_reg_date")]
        public string CarRegDate { get; set; }

        /// <summary>
        /// 车系标识，合作机构提供的车型库，如：  10表示奥迪A8L
        /// </summary>
        [JsonProperty("car_series_id")]
        public string CarSeriesId { get; set; }

        /// <summary>
        /// 车系名称，合作机构提供的车型库
        /// </summary>
        [JsonProperty("car_series_name")]
        public string CarSeriesName { get; set; }

        /// <summary>
        /// 车架号（Vehicle Identification Number，车辆识别代码）
        /// </summary>
        [JsonProperty("car_vin")]
        public string CarVin { get; set; }

        /// <summary>
        /// 上牌地，合作机构提供支持办理贷款的省市，参考标准的行政区域编号（http://www.stats.gov.cn/tjsj/tjbz/xzqhdm/），如：  330100表示杭州市
        /// </summary>
        [JsonProperty("lic_plate_address")]
        public string LicPlateAddress { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonProperty("lic_plate_no")]
        public string LicPlateNo { get; set; }

        /// <summary>
        /// 机构请求流水号，请求的幂等字段，作为业务幂等性控制
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }
    }
}
