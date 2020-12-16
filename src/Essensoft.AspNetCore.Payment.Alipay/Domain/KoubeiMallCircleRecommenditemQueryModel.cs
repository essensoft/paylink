using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMallCircleRecommenditemQueryModel Data Structure.
    /// </summary>
    public class KoubeiMallCircleRecommenditemQueryModel : AlipayObject
    {
        /// <summary>
        /// 口碑城市编码（示例：杭州市330100）
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 身份ID，识别合作方身份（可联系口碑综合体业务获取）
        /// </summary>
        [JsonPropertyName("data_set_id")]
        public string DataSetId { get; set; }

        /// <summary>
        /// 展示渠道：ALIPAY_APP KOUBEI_APP TAOBAO_APP（默认ALIPAY_APP）
        /// </summary>
        [JsonPropertyName("display_channel")]
        public string DisplayChannel { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 每页查询量，默认为10，每页最大查询量不能超过50，最小查询量不能低于1
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询起始值，默认为0
        /// </summary>
        [JsonPropertyName("start")]
        public long Start { get; set; }

        /// <summary>
        /// 终端设备描述(中、英文均可)
        /// </summary>
        [JsonPropertyName("terminal_type")]
        public string TerminalType { get; set; }

        /// <summary>
        /// 生活圈ID；参数不为空，表明指定是生活圈
        /// </summary>
        [JsonPropertyName("tribe_id")]
        public string TribeId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
