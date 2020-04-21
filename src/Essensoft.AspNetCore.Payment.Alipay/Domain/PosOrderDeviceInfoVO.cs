using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PosOrderDeviceInfoVO Data Structure.
    /// </summary>
    public class PosOrderDeviceInfoVO : AlipayObject
    {
        /// <summary>
        /// 对应单个设备的金额，单位元，精确到小数点后两位
        /// </summary>
        [JsonPropertyName("device_amt")]
        public string DeviceAmt { get; set; }

        /// <summary>
        /// pos机设备当前的状态值，枚举值为：已出厂(1)，已入仓(2)，已出售(3)，已报单(4)，已发货(5)，已收货(6)，已激活(7)、已绑定(8)、运行中(9)、设备失联(10)、已解绑(11)
        /// </summary>
        [JsonPropertyName("device_status")]
        public string DeviceStatus { get; set; }

        /// <summary>
        /// pos机设备类型，枚举值为: 旗舰(FLAG_SHIP),高端(HIGH_END),标准(STANDARD),手持(IN_HAND)
        /// </summary>
        [JsonPropertyName("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// pos机设备型号，如荣焱P10CC、商米D1、荣焱P10S、商米P1、荣焱HD01、商米V1、商米M1、荣焱P8K、商米T1、商米T2lite、荣焱P8G、商米T1、商米T2Lite等
        /// </summary>
        [JsonPropertyName("device_version")]
        public string DeviceVersion { get; set; }

        /// <summary>
        /// pos机对应服务的实施状态，目前只对应安装服务,该字段只对带有安装服务的设备有效，枚举值包括：安装完成(FINISHED),未完成安装(UNFINISHED),
        /// </summary>
        [JsonPropertyName("implement_status")]
        public string ImplementStatus { get; set; }

        /// <summary>
        /// pos机对应的服务状态，目前只包括安装服务，枚举值为：购买了安装服务(INSTALL),没有购买安装服务(NO_INSTALL)
        /// </summary>
        [JsonPropertyName("service_status")]
        public string ServiceStatus { get; set; }

        /// <summary>
        /// 口碑门店id，激活设备才有口碑门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 设备id，唯一标识设备的ID,SN号
        /// </summary>
        [JsonPropertyName("sn_no")]
        public string SnNo { get; set; }

        /// <summary>
        /// pos机对应仓id：出厂仓的id
        /// </summary>
        [JsonPropertyName("warehouse_id")]
        public string WarehouseId { get; set; }

        /// <summary>
        /// 设备对应仓类型，枚举值为: isv仓(ISV),硬件仓(HARD_WARD)
        /// </summary>
        [JsonPropertyName("warehouse_type")]
        public string WarehouseType { get; set; }
    }
}
