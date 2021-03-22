using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingParkinglotinfoQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarParkingParkinglotinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// ISV停车场ID，由ISV定义的停车场标识，同一个ISV或商户范围内唯一。需与 <a href="https://opendocs.alipay.com/apis/api_19/alipay.eco.mycar.parking.parkinglotinfo.create">alipay.eco.mycar.parking.parkinglotinfo.create</a>(录入停车场信息)接口传入值一致。 注意：parking_id和out_parking_id不能同时为空。
        /// </summary>
        [JsonPropertyName("out_parking_id")]
        public string OutParkingId { get; set; }

        /// <summary>
        /// 支付宝停车平台ID，由支付宝定义的该停车场标识，同一个ISV或商户范围内唯一。通过 <a href="https://opendocs.alipay.com/apis/api_19/alipay.eco.mycar.parking.parkinglotinfo.create">alipay.eco.mycar.parking.parkinglotinfo.create</a>(录入停车场信息)接口获取。 注意：parking_id和out_parking_id不能同时为空。
        /// </summary>
        [JsonPropertyName("parking_id")]
        public string ParkingId { get; set; }
    }
}
