using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SupplierAssetResponse Data Structure.
    /// </summary>
    [Serializable]
    public class SupplierAssetResponse : AlipayObject
    {
        /// <summary>
        /// 审核备注
        /// </summary>
        [JsonProperty("approval_remark")]
        public string ApprovalRemark { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        [JsonProperty("approval_status")]
        public string ApprovalStatus { get; set; }

        /// <summary>
        /// 审核状态文案
        /// </summary>
        [JsonProperty("approval_status_text")]
        public string ApprovalStatusText { get; set; }

        /// <summary>
        /// 是否支持蓝牙
        /// </summary>
        [JsonProperty("bluetooth_mode")]
        public string BluetoothMode { get; set; }

        /// <summary>
        /// bluetooth mode文案
        /// </summary>
        [JsonProperty("bluetooth_mode_text")]
        public string BluetoothModeText { get; set; }

        /// <summary>
        /// 联系地址
        /// </summary>
        [JsonProperty("contact_address")]
        public string ContactAddress { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [JsonProperty("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [JsonProperty("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 设备CPU
        /// </summary>
        [JsonProperty("cpu")]
        public string Cpu { get; set; }

        /// <summary>
        /// 产品设计图片
        /// </summary>
        [JsonProperty("device_design_img")]
        public string DeviceDesignImg { get; set; }

        /// <summary>
        /// 产品设计图id
        /// </summary>
        [JsonProperty("device_design_img_id")]
        public string DeviceDesignImgId { get; set; }

        /// <summary>
        /// 产品图片
        /// </summary>
        [JsonProperty("device_img")]
        public string DeviceImg { get; set; }

        /// <summary>
        /// 产品图片id
        /// </summary>
        [JsonProperty("device_img_id")]
        public string DeviceImgId { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonProperty("device_name")]
        public string DeviceName { get; set; }

        /// <summary>
        /// 设备其他说明
        /// </summary>
        [JsonProperty("device_other_desc")]
        public string DeviceOtherDesc { get; set; }

        /// <summary>
        /// 人脸摄像头
        /// </summary>
        [JsonProperty("face_camera")]
        public string FaceCamera { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [JsonProperty("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 记录主键id
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// 物料id（蚂蚁设备id）
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 是否支持有线网络
        /// </summary>
        [JsonProperty("line_network_mode")]
        public string LineNetworkMode { get; set; }

        /// <summary>
        /// line network mode文案
        /// </summary>
        [JsonProperty("line_network_mode_text")]
        public string LineNetworkModeText { get; set; }

        /// <summary>
        /// 设备内存
        /// </summary>
        [JsonProperty("memory")]
        public string Memory { get; set; }

        /// <summary>
        /// 最低系统版本
        /// </summary>
        [JsonProperty("min_os_version")]
        public string MinOsVersion { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [JsonProperty("model_number")]
        public string ModelNumber { get; set; }

        /// <summary>
        /// 是否支持移动网络
        /// </summary>
        [JsonProperty("network_mode")]
        public string NetworkMode { get; set; }

        /// <summary>
        /// network mode文案
        /// </summary>
        [JsonProperty("network_mode_text")]
        public string NetworkModeText { get; set; }

        /// <summary>
        /// 操作系统
        /// </summary>
        [JsonProperty("os_type")]
        public string OsType { get; set; }

        /// <summary>
        /// 是否支持打印机
        /// </summary>
        [JsonProperty("printer")]
        public string Printer { get; set; }

        /// <summary>
        /// ram大小
        /// </summary>
        [JsonProperty("ram")]
        public long Ram { get; set; }

        /// <summary>
        /// rom大小
        /// </summary>
        [JsonProperty("rom")]
        public long Rom { get; set; }

        /// <summary>
        /// 扫码方式
        /// </summary>
        [JsonProperty("scan_code_mode")]
        public string ScanCodeMode { get; set; }

        /// <summary>
        /// 扫码距离
        /// </summary>
        [JsonProperty("scan_code_read_dista")]
        public string ScanCodeReadDista { get; set; }

        /// <summary>
        /// 显示屏分辨率
        /// </summary>
        [JsonProperty("screen_dpi")]
        public string ScreenDpi { get; set; }

        /// <summary>
        /// 屏幕尺寸
        /// </summary>
        [JsonProperty("screen_size")]
        public string ScreenSize { get; set; }

        /// <summary>
        /// sdk自动打包文件下载地址
        /// </summary>
        [JsonProperty("sdk_auto_file")]
        public string SdkAutoFile { get; set; }

        /// <summary>
        /// sdk文件id
        /// </summary>
        [JsonProperty("sdk_auto_file_id")]
        public string SdkAutoFileId { get; set; }

        /// <summary>
        /// sdk名称
        /// </summary>
        [JsonProperty("sdk_name")]
        public string SdkName { get; set; }

        /// <summary>
        /// sdk版本号
        /// </summary>
        [JsonProperty("sdk_version")]
        public string SdkVersion { get; set; }

        /// <summary>
        /// 设备存储
        /// </summary>
        [JsonProperty("storage")]
        public string Storage { get; set; }

        /// <summary>
        /// 供应商名称
        /// </summary>
        [JsonProperty("supplier_name")]
        public string SupplierName { get; set; }

        /// <summary>
        /// 供应商pid
        /// </summary>
        [JsonProperty("supplier_pid")]
        public string SupplierPid { get; set; }

        /// <summary>
        /// 供应商sn
        /// </summary>
        [JsonProperty("supplier_sn")]
        public string SupplierSn { get; set; }

        /// <summary>
        /// 设备交易模式，ONE/ZERO
        /// </summary>
        [JsonProperty("tranaction_model")]
        public string TranactionModel { get; set; }

        /// <summary>
        /// tranaction model文案
        /// </summary>
        [JsonProperty("tranaction_model_text")]
        public string TranactionModelText { get; set; }

        /// <summary>
        /// 是否支持wifi
        /// </summary>
        [JsonProperty("wifi_mode")]
        public string WifiMode { get; set; }

        /// <summary>
        /// wifi mode文案
        /// </summary>
        [JsonProperty("wifi_mode_text")]
        public string WifiModeText { get; set; }
    }
}
