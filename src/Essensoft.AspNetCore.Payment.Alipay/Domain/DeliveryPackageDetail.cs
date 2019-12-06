using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeliveryPackageDetail Data Structure.
    /// </summary>
    public class DeliveryPackageDetail : AlipayObject
    {
        /// <summary>
        /// 运单号
        /// </summary>
        [JsonPropertyName("express_code")]
        public string ExpressCode { get; set; }

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
        /// 货品编码
        /// </summary>
        [JsonPropertyName("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 货品数量
        /// </summary>
        [JsonPropertyName("goods_quantity")]
        public string GoodsQuantity { get; set; }

        /// <summary>
        /// 包裹编号
        /// </summary>
        [JsonPropertyName("package_code")]
        public string PackageCode { get; set; }
    }
}
