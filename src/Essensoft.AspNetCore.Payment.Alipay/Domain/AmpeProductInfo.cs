using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AmpeProductInfo Data Structure.
    /// </summary>
    public class AmpeProductInfo : AlipayObject
    {
        /// <summary>
        /// 类目描述
        /// </summary>
        [JsonPropertyName("category_desc")]
        public string CategoryDesc { get; set; }

        /// <summary>
        /// 类目id
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 设备机型列表
        /// </summary>
        [JsonPropertyName("device_model_list")]
        public List<AmpeDeviceModelInfo> DeviceModelList { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [JsonPropertyName("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备类型描述
        /// </summary>
        [JsonPropertyName("device_type_desc")]
        public string DeviceTypeDesc { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 调用的appId
        /// </summary>
        [JsonPropertyName("invoke_app_id")]
        public string InvokeAppId { get; set; }

        /// <summary>
        /// 产品id
        /// </summary>
        [JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonPropertyName("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 产品图片
        /// </summary>
        [JsonPropertyName("product_pic")]
        public string ProductPic { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        [JsonPropertyName("reject_memo")]
        public string RejectMemo { get; set; }

        /// <summary>
        /// 出货量
        /// </summary>
        [JsonPropertyName("ship_quantity")]
        public long ShipQuantity { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 审核状态描述
        /// </summary>
        [JsonPropertyName("status_desc")]
        public string StatusDesc { get; set; }
    }
}
