using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishMaterialQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishMaterialQueryModel : AlipayObject
    {
        /// <summary>
        /// 加料的id，若不为空，则为单条查询，page_size和page_no失效；如果为空，则为批量查询，page_size和page_no必传，否则为默认值
        /// </summary>
        [JsonProperty("material_id")]
        public string MaterialId { get; set; }

        /// <summary>
        /// 要查询的加料库的商户id
        /// </summary>
        [JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 查询页码，表示第几页；兼顾老版本，批量查询不传时默认为1
        /// </summary>
        [JsonProperty("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小，表示每页查询数量，不超过200；兼容老版本，批量查询不传时默认为200
        /// </summary>
        [JsonProperty("page_size")]
        public string PageSize { get; set; }
    }
}
