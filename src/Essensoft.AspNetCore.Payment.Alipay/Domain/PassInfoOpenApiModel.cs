using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PassInfoOpenApiModel Data Structure.
    /// </summary>
    [Serializable]
    public class PassInfoOpenApiModel : AlipayObject
    {
        /// <summary>
        /// 凭证信息
        /// </summary>
        [JsonProperty("data_info")]
        public string DataInfo { get; set; }

        /// <summary>
        /// 有效期结束时间
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 券创建时间
        /// </summary>
        [JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 卡券第一行文字
        /// </summary>
        [JsonProperty("logo_text")]
        public string LogoText { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [JsonProperty("mechant_name")]
        public string MechantName { get; set; }

        /// <summary>
        /// 券ID
        /// </summary>
        [JsonProperty("pass_id")]
        public string PassId { get; set; }

        /// <summary>
        /// 卡券第二行文字
        /// </summary>
        [JsonProperty("second_logo_text")]
        public string SecondLogoText { get; set; }

        /// <summary>
        /// 可用门店信息
        /// </summary>
        [JsonProperty("shop_id_list")]
        public List<string> ShopIdList { get; set; }

        /// <summary>
        /// 有效期开始时间
        /// </summary>
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 券状态,"can_use", "可使用";"used", "已使用";"expired", "已过期";"closed", "已失效"
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
