using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserStepcounterSyncModel Data Structure.
    /// </summary>
    public class AlipayUserStepcounterSyncModel : AlipayObject
    {
        /// <summary>
        /// 年龄数据。是外部商户系统中录入的用户年龄数据
        /// </summary>
        [JsonPropertyName("age")]
        public long Age { get; set; }

        /// <summary>
        /// 卡路里。是商户系统通过用户运动设备(如手环)读取到的用户运动卡路里值
        /// </summary>
        [JsonPropertyName("calorie")]
        public string Calorie { get; set; }

        /// <summary>
        /// 步数。商户系统通过用户运动设备(如手环)读取到的用户当日步数值
        /// </summary>
        [JsonPropertyName("count")]
        public long Count { get; set; }

        /// <summary>
        /// 业务方标识。步数来源的唯一标识，每一个外部商户都会分配一个业务方标识，请使用钉钉联系支付宝小二骁然获取此标识
        /// </summary>
        [JsonPropertyName("data_provider")]
        public string DataProvider { get; set; }

        /// <summary>
        /// 运动距离。是外部商户系统从用户设备中读取到的用户步行距离，单位:米
        /// </summary>
        [JsonPropertyName("distance")]
        public long Distance { get; set; }

        /// <summary>
        /// 身高数据。是外部商户系统中录入的用户身高数据，单位:cm
        /// </summary>
        [JsonPropertyName("height")]
        public string Height { get; set; }

        /// <summary>
        /// 位置纬度。是商户系统从用户设备中读取到的用户位置纬度，必须使用wgs84坐标集
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 位置经度。是商户系统从用户客户端设备中读取到的用户位置经度，必须使用wgs84坐标集
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 商户系统的用户uid。是外部商户系统中的用户唯一id
        /// </summary>
        [JsonPropertyName("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 步数更新时间。用户步数上报到商户服务端的时间
        /// </summary>
        [JsonPropertyName("time")]
        public string Time { get; set; }

        /// <summary>
        /// 用户时区。外部商户系统从用户运动设备中读取到的设备时区
        /// </summary>
        [JsonPropertyName("time_zone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// 支付宝用户id。为2088开头id号，需通过alipay.user.userinfo.share接口获取此值
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 体重数据。是外部商户系统中录入的用户体重数据，单位:kg
        /// </summary>
        [JsonPropertyName("weight")]
        public string Weight { get; set; }
    }
}
