using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KdsInfoModel Data Structure.
    /// </summary>
    public class KdsInfoModel : AlipayObject
    {
        /// <summary>
        /// 是否删除 false删除，true删除
        /// </summary>
        [JsonPropertyName("delete_flag")]
        public bool DeleteFlag { get; set; }

        /// <summary>
        /// 设备列表
        /// </summary>
        [JsonPropertyName("device_list")]
        public List<KdsDeviceModel> DeviceList { get; set; }

        /// <summary>
        /// 就餐模式可多选枚举如下：  TO_GO("TO_GO", "外带"),  TAKE_OUT("TAKE_OUT", "外卖"),  FOR_HERE("FOR_HERE", "堂食"),  全选回传ALL，ALL与其它类型不兼容
        /// </summary>
        [JsonPropertyName("dinner_type")]
        public List<string> DinnerType { get; set; }

        /// <summary>
        /// 是否有设备绑定，false无，true有
        /// </summary>
        [JsonPropertyName("has_device")]
        public bool HasDevice { get; set; }

        /// <summary>
        /// 是否有档口，false没有，true有
        /// </summary>
        [JsonPropertyName("has_stall")]
        public bool HasStall { get; set; }

        /// <summary>
        /// KDSID
        /// </summary>
        [JsonPropertyName("kds_id")]
        public string KdsId { get; set; }

        /// <summary>
        /// KDS名称
        /// </summary>
        [JsonPropertyName("kds_name")]
        public string KdsName { get; set; }

        /// <summary>
        /// kds屏幕类型：  ("COOK", "制作屏"),  ("PREPARE", "备餐屏"),  ("TAKE", "取餐屏"),
        /// </summary>
        [JsonPropertyName("kds_type")]
        public string KdsType { get; set; }

        /// <summary>
        /// 是否打印，false不打印，true打印
        /// </summary>
        [JsonPropertyName("print_flag")]
        public bool PrintFlag { get; set; }

        /// <summary>
        /// kds绑定的打印机设备ID  print_flag为true时，该字段必填
        /// </summary>
        [JsonPropertyName("printer_device_id")]
        public string PrinterDeviceId { get; set; }

        /// <summary>
        /// 打印机列表
        /// </summary>
        [JsonPropertyName("printer_list")]
        public List<KdsPrinterModel> PrinterList { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
