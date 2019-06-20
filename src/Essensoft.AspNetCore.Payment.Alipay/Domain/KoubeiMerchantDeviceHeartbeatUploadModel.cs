using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantDeviceHeartbeatUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantDeviceHeartbeatUploadModel : AlipayObject
    {
        /// <summary>
        /// 前台/后台app信息，name传递应用名称，version传递应用版本信息，status传递应用状态，枚举：active----运行，background----后台运行
        /// </summary>
        [JsonProperty("app_info")]
        public string AppInfo { get; set; }

        /// <summary>
        /// 心跳时间段内的机具异常原因，如有多个用“|”分隔。  HE_PRINTER——打印机异常；  HE_LOUDSPEAKER——音响异常；  HE_BOH-----后厨屏显异常  HE_OTHER——其他硬件异常
        /// </summary>
        [JsonProperty("exception_info")]
        public string ExceptionInfo { get; set; }

        /// <summary>
        /// 心跳信息发送方自定义，json格式
        /// </summary>
        [JsonProperty("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [JsonProperty("hardware_version")]
        public string HardwareVersion { get; set; }

        /// <summary>
        /// isv_appid
        /// </summary>
        [JsonProperty("isv_app_id")]
        public string IsvAppId { get; set; }

        /// <summary>
        /// isv商户pid
        /// </summary>
        [JsonProperty("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// ISV 心跳服务器时间
        /// </summary>
        [JsonProperty("isv_server_time")]
        public string IsvServerTime { get; set; }

        /// <summary>
        /// lbs 经纬度信息
        /// </summary>
        [JsonProperty("lbs")]
        public string Lbs { get; set; }

        /// <summary>
        /// lbs获取方式：WIFI/BASE-STATION/GPS/AGPS
        /// </summary>
        [JsonProperty("lbs_type")]
        public string LbsType { get; set; }

        /// <summary>
        /// MAC 地址
        /// </summary>
        [JsonProperty("mac")]
        public string Mac { get; set; }

        /// <summary>
        /// 机器制造商
        /// </summary>
        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// 局域网IP
        /// </summary>
        [JsonProperty("network_ip")]
        public string NetworkIp { get; set; }

        /// <summary>
        /// 网络名称
        /// </summary>
        [JsonProperty("network_name")]
        public string NetworkName { get; set; }

        /// <summary>
        /// pos设备连接的网络类型  ：2G,3G,4G,WIFI,LAN(有线网  络)
        /// </summary>
        [JsonProperty("network_type")]
        public string NetworkType { get; set; }

        /// <summary>
        /// 发送心跳的设备所依赖的支付宝产品（如 点餐的为 CO）
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 设备SN
        /// </summary>
        [JsonProperty("sn_id")]
        public string SnId { get; set; }

        /// <summary>
        /// isv点餐应用的版本信息
        /// </summary>
        [JsonProperty("soft_version")]
        public string SoftVersion { get; set; }

        /// <summary>
        /// 系统类型
        /// </summary>
        [JsonProperty("sys_type")]
        public string SysType { get; set; }

        /// <summary>
        /// 系统版本
        /// </summary>
        [JsonProperty("sys_version")]
        public string SysVersion { get; set; }

        /// <summary>
        /// 心跳发生时间
        /// </summary>
        [JsonProperty("time")]
        public string Time { get; set; }
    }
}
