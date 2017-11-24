using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingParkinglotinfoCreateModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarParkingParkinglotinfoCreateModel : AlipayObject
    {
        /// <summary>
        /// 城市编号（国家统一标准编码），请务必填写正确，详见 <a href="http://park-cityid.oss-cn-hangzhou.aliyuncs.com/%E5%9F%8E%E5%B8%82%E7%BC%96%E7%A0%81%28%E5%9B%BD%E6%A0%87%E7%A0%81%29.xls">点此下载</a>
        /// </summary>
        [JsonProperty("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 停车场联系人支付宝账户，如果有则填入
        /// </summary>
        [JsonProperty("contact_alipay")]
        public string ContactAlipay { get; set; }

        /// <summary>
        /// 停车场联系人邮箱，如果有则填入
        /// </summary>
        [JsonProperty("contact_emali")]
        public string ContactEmali { get; set; }

        /// <summary>
        /// 停车场联系人手机，如果有则填入
        /// </summary>
        [JsonProperty("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 停车场联系人，如果有则填入
        /// </summary>
        [JsonProperty("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 停车场联系人座机，如果有则填入
        /// </summary>
        [JsonProperty("contact_tel")]
        public string ContactTel { get; set; }

        /// <summary>
        /// 停车场联系人微信，如果有则填入
        /// </summary>
        [JsonProperty("contact_weixin")]
        public string ContactWeixin { get; set; }

        /// <summary>
        /// 设备商名称
        /// </summary>
        [JsonProperty("equipment_name")]
        public string EquipmentName { get; set; }

        /// <summary>
        /// 纬度，最长15位字符(包括小数点)，注：高德坐标系。经纬度是门店搜索和活动推荐的重要参数，录入时请确保经纬度参数的准确。高德经纬度询：http://lbs.amap.com/console/show/picker
        /// </summary>
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度，最长15位字符(包括小数点)，注：高德坐标系。经纬度是门店搜索和活动推荐的重要参数，录入时请确保经纬度参数的准确。高德经纬度询：http://lbs.amap.com/console/show/picker
        /// </summary>
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// ISV停车场ID，由ISV提供，同一个isv或商户范围内唯一
        /// </summary>
        [JsonProperty("out_parking_id")]
        public string OutParkingId { get; set; }

        /// <summary>
        /// 停车场地址
        /// </summary>
        [JsonProperty("parking_address")]
        public string ParkingAddress { get; set; }

        /// <summary>
        /// 停车场结束营业时间，格式 "HH:mm:ss"
        /// </summary>
        [JsonProperty("parking_end_time")]
        public string ParkingEndTime { get; set; }

        /// <summary>
        /// 收费说明
        /// </summary>
        [JsonProperty("parking_fee_description")]
        public string ParkingFeeDescription { get; set; }

        /// <summary>
        /// 停车场类型，1为小区停车场、2为商圈停车场、3为路面停车场、4为园区停车场、5为写字楼停车场、6为私人停车场
        /// </summary>
        [JsonProperty("parking_lot_type")]
        public string ParkingLotType { get; set; }

        /// <summary>
        /// 停车场名称
        /// </summary>
        [JsonProperty("parking_name")]
        public string ParkingName { get; set; }

        /// <summary>
        /// 停车位数目
        /// </summary>
        [JsonProperty("parking_number")]
        public string ParkingNumber { get; set; }

        /// <summary>
        /// 停车场开始营业时间，格式 "HH:mm:ss"
        /// </summary>
        [JsonProperty("parking_start_time")]
        public string ParkingStartTime { get; set; }

        /// <summary>
        /// 停车场类型(1为地面，2为地下，3为路边)（多个类型，中间用,隔开
        /// </summary>
        [JsonProperty("parking_type")]
        public string ParkingType { get; set; }

        /// <summary>
        /// 支付方式（1为支付宝在线缴费，2为支付宝代扣缴费，3当面付)，如支持多种方式以','进行间隔
        /// </summary>
        [JsonProperty("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 缴费模式（1为停车卡缴费，2为物料缴费，3为中央缴费机）
        /// </summary>
        [JsonProperty("payment_mode")]
        public string PaymentMode { get; set; }

        /// <summary>
        /// 商圈id
        /// </summary>
        [JsonProperty("shopingmall_id")]
        public string ShopingmallId { get; set; }

        /// <summary>
        /// 用户支付未离场的超时时间(以分钟为单位)
        /// </summary>
        [JsonProperty("time_out")]
        public string TimeOut { get; set; }
    }
}
