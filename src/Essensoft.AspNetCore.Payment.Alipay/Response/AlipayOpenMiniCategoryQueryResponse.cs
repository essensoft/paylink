using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniCategoryQueryResponse.
    /// </summary>
    public class AlipayOpenMiniCategoryQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序类目列表
        /// </summary>
        [JsonPropertyName("category_list")]
        public List<MiniAppCategory> CategoryList { get; set; }

        /// <summary>
        /// 小程序新类目列表。小程序新类目列表，为三级类目。创建、修改、提审传入mini_category_ids，资质相关请参考https://opendocs.alipay.com/mini/operation/material 
        /// </summary>
        [JsonPropertyName("mini_category_list")]
        public List<MiniAppCategory> MiniCategoryList { get; set; }
    }
}
