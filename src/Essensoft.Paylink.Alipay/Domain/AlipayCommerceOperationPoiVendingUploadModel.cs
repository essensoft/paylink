using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceOperationPoiVendingUploadModel Data Structure.
    /// </summary>
    public class AlipayCommerceOperationPoiVendingUploadModel : AlipayObject
    {
        /// <summary>
        /// 地址描述
        /// </summary>
        [JsonPropertyName("address_desc")]
        public string AddressDesc { get; set; }

        /// <summary>
        /// 营业时间，json格式，days_in_week：一周中的哪几天，范围1~7，hours：一天中的时间，24小时制。 例如：[{"days_in_week":[1,2,3,4,5], "hours":"08:00-20:00"},{"days_in_week":[6,7], "hours":"00:00-24:00"}]，代表周一到周五早8点到晚8点，周六日全天
        /// </summary>
        [JsonPropertyName("business_hours_desc")]
        public List<BusinessHoursDesc> BusinessHoursDesc { get; set; }

        /// <summary>
        /// 点位类型，可取值如下：  vending(自助售卖机),  water_dispenser(饮水机),  washing(洗衣机）
        /// </summary>
        [JsonPropertyName("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 客服电话
        /// </summary>
        [JsonPropertyName("contact_number")]
        public string ContactNumber { get; set; }

        /// <summary>
        /// 点位是否可用，Y：可用，N：不可用，不可用点位不会展示给C端
        /// </summary>
        [JsonPropertyName("enabled")]
        public string Enabled { get; set; }

        /// <summary>
        /// 外部实体编号，唯一标识一个实体，如售卖机编号 注1：商户维度下，点位类型（category_code）+ 实体编号（entity_code）唯一，一个商户下相同类型+实体编号多次调用，以最新一次调用数据为准 注2：此编号需要可用于反查商家数据，如调用商家ISP接口获取编号对应设备点位的实时信息
        /// </summary>
        [JsonPropertyName("entity_code")]
        public string EntityCode { get; set; }

        /// <summary>
        /// 点位名称，无需包含品牌信息及设备类型，如：Z空间，XX小区，XX商场1号机。 展示给消费者时，可通过配置选择需要展示的字段，如是否显示品牌及设备类型，或是否不显示点位名称
        /// </summary>
        [JsonPropertyName("entity_name")]
        public string EntityName { get; set; }

        /// <summary>
        /// 扩展信息字段，具体内容根据商家及设备类型不同另行约定。json格式，请将需要传递的key和value字段放入map中，转成json string传入
        /// </summary>
        [JsonPropertyName("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// 地址位置纬度，使用国标GCJ-02坐标系，取值范围：纬度-90~90，中国地区经度范围：纬度3.86~53.55
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 地址位置经度，使用国标GCJ-02坐标系，取值范围：经度-180~180，中国地区经度范围：73.66~135.05
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 点位上传时间，某一点位信息多次上传，以最新上传时间数据为当前最新快照，格式：yyyy-mm-dd hh:MM:ss
        /// </summary>
        [JsonPropertyName("upload_time")]
        public string UploadTime { get; set; }
    }
}
