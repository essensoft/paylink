using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopInfo : AlipayObject
    {
        /// <summary>
        /// 企业门店名称
        /// </summary>
        [JsonProperty("shop_name")]
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺内景图片，如要签约当面付产品，需上传3张店铺内景图片
        /// </summary>
        [JsonProperty("shop_scene_pic")]
        [XmlArray("shop_scene_pic")]
        [XmlArrayItem("string")]
        public List<string> ShopScenePic { get; set; }

        /// <summary>
        /// 店铺门头照图片
        /// </summary>
        [JsonProperty("shop_sign_board_pic")]
        [XmlElement("shop_sign_board_pic")]
        public string ShopSignBoardPic { get; set; }
    }
}
