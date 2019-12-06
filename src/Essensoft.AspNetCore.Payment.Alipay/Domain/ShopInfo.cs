using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ShopInfo Data Structure.
    /// </summary>
    public class ShopInfo : AlipayObject
    {
        /// <summary>
        /// 企业门店名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺内景图片，如要签约当面付产品，需上传3张店铺内景图片
        /// </summary>
        [JsonPropertyName("shop_scene_pic")]
        public List<string> ShopScenePic { get; set; }

        /// <summary>
        /// 店铺门头照图片
        /// </summary>
        [JsonPropertyName("shop_sign_board_pic")]
        public string ShopSignBoardPic { get; set; }
    }
}
