using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FaceMachineInfo Data Structure.
    /// </summary>
    public class FaceMachineInfo : AlipayObject
    {
        /// <summary>
        /// 摄像头驱动版本号
        /// </summary>
        [JsonPropertyName("camera_drive_ver")]
        public string CameraDriveVer { get; set; }

        /// <summary>
        /// 摄像头型号
        /// </summary>
        [JsonPropertyName("camera_model")]
        public string CameraModel { get; set; }

        /// <summary>
        /// 摄像头名称
        /// </summary>
        [JsonPropertyName("camera_name")]
        public string CameraName { get; set; }

        /// <summary>
        /// 摄像头版本号
        /// </summary>
        [JsonPropertyName("camera_ver")]
        public string CameraVer { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// 机具编码
        /// </summary>
        [JsonPropertyName("machine_code")]
        public string MachineCode { get; set; }

        /// <summary>
        /// 机具型号
        /// </summary>
        [JsonPropertyName("machine_model")]
        public string MachineModel { get; set; }

        /// <summary>
        /// 机具版本号
        /// </summary>
        [JsonPropertyName("machine_ver")]
        public string MachineVer { get; set; }
    }
}
