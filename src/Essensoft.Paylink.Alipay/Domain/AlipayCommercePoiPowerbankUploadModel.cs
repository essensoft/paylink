using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommercePoiPowerbankUploadModel Data Structure.
    /// </summary>
    public class AlipayCommercePoiPowerbankUploadModel : AlipayObject
    {
        /// <summary>
        /// 地址描述
        /// </summary>
        [JsonPropertyName("address_desc")]
        public string AddressDesc { get; set; }

        /// <summary>
        /// 是否可借用，Y:可借，N:不可借。如果不可借用，则不在支付宝首页标准服务推荐以及中心场小程序地图展示
        /// </summary>
        [JsonPropertyName("can_borrow")]
        public string CanBorrow { get; set; }

        /// <summary>
        /// 充电宝机柜总共可以借还的充电宝数量（一共能放几个充电宝）.
        /// </summary>
        [JsonPropertyName("can_borrow_cnt")]
        public string CanBorrowCnt { get; set; }

        /// <summary>
        /// 联系电话，手机11位数字，座机：区号－数字
        /// </summary>
        [JsonPropertyName("contact_number")]
        public string ContactNumber { get; set; }

        /// <summary>
        /// 外部实体编号，唯一标识一个实体，如自行车编号，机柜编号 注：商户维度下，类目Code（categoryCode）+实体编号（entity_code）唯一，一个商户下相同类目code+实体编号多次调用
        /// </summary>
        [JsonPropertyName("entity_code")]
        public string EntityCode { get; set; }

        /// <summary>
        /// 点位名称，点位的描述，如XX充电宝
        /// </summary>
        [JsonPropertyName("entity_name")]
        public string EntityName { get; set; }

        /// <summary>
        /// 扩展信息字段，格式:json。请将需要传递的key和value字段放入map中,然后转成json传入
        /// </summary>
        [JsonPropertyName("ext_properties")]
        public string ExtProperties { get; set; }

        /// <summary>
        /// 地址位置纬度，取值范围：纬度-90~90，中国地区经度范围：纬度3.86~53.55
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 地址位置经度，取值范围：经度-180~180，中国地区经度范围：73.66~135.05
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 营业时间，格式：xx:xx-xx:xx，24小时制，如果是昼夜00:00—24:00
        /// </summary>
        [JsonPropertyName("office_hours_desc")]
        public string OfficeHoursDesc { get; set; }

        /// <summary>
        /// 实体上传时间，某一借还实体信息多次上传，以最新上传时间数据为当前最新快照，格式：yyyy-mm-dd hh:MM:ss
        /// </summary>
        [JsonPropertyName("upload_time")]
        public string UploadTime { get; set; }
    }
}
