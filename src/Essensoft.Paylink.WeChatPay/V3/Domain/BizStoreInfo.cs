using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 线下场所场景
    /// </summary>
    public class BizStoreInfo
    {
        /// <summary>
        /// 线下场所名称
        /// 示例值：大郎烧饼
        /// </summary>
        [JsonPropertyName("biz_store_name")]
        public string BizStoreName { get; set; }
        /// <summary>
        /// 线下场所省市编码
        /// 只能由数字组成
        /// 详细参见微信支付提供的省市对照表
        /// </summary>
        [JsonPropertyName("biz_address_code")]
        public string BizAddressCode { get; set; }
        /// <summary>
        /// 线下场所地址
        /// 请填写详细的经营场所信息，如有多个场所，选择一个主要场所填写即可。
        /// </summary>
        [JsonPropertyName("biz_store_address")]
        public string BizStoreAddress { get; set; }
        /// <summary>
        /// 线下场所门头照片
        /// 1、请上传门店照片（要求门店招牌清晰可见）。若为停车场、售卖机等无固定门头照片 的经营场所，请提供真实的经营现场照片即可；
        /// 2、请填写通过图片上传API接口预先上传图片生成好的MediaID。
        /// </summary>
        [JsonPropertyName("store_entrance_pic")]
        public List<string> StoreEntrancePic { get; set; }
        /// <summary>
        /// 线下场所内部照片
        /// 请上传门店内部环境照片。若为停车场、售卖机等无固定门头照片的经营场所，请提 供真实的经营现场照片即可；
        /// 请填写通过图片上传API接口预先上传图片生成好的MediaID。
        /// </summary>
        [JsonPropertyName("indoor_pic")]
        public List<string> IndoorPic { get; set; }
        /// <summary>
        /// 线下场所对应的商家AppID
        /// 1、可填写与商家主体一致且已认证的公众号、小程序、APP的AppID，其中公众号AppID需是已认证的服务号、政府或媒体类型的订阅号；
        /// 2、审核通过后，系统将额外为商家开通付款码支付、JSAPI支付的自有交易权限，并完成商家商户号与该AppID的绑定；
        /// </summary>
        [JsonPropertyName("biz_sub_appid")]
        public string BizSubAppid { get; set; }
    }
}
