using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ServiceRecordCatRequest Data Structure.
    /// </summary>
    public class ServiceRecordCatRequest : AlipayObject
    {
        /// <summary>
        /// 类目名称(需要每一级用;分隔封装)
        /// </summary>
        [JsonPropertyName("cat_name")]
        public string CatName { get; set; }

        /// <summary>
        /// 一级类目编码
        /// </summary>
        [JsonPropertyName("first_cat")]
        public string FirstCat { get; set; }

        /// <summary>
        /// 四级类目编码
        /// </summary>
        [JsonPropertyName("fourth_cat")]
        public string FourthCat { get; set; }

        /// <summary>
        /// 类目树编码
        /// </summary>
        [JsonPropertyName("instence_code")]
        public string InstenceCode { get; set; }

        /// <summary>
        /// 二级类目编码
        /// </summary>
        [JsonPropertyName("second_cat")]
        public string SecondCat { get; set; }

        /// <summary>
        /// 三级类目编码
        /// </summary>
        [JsonPropertyName("third_cat")]
        public string ThirdCat { get; set; }
    }
}
