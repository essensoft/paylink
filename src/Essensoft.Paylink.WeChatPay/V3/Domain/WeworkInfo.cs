using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    public class WeworkInfo
    {
        /// <summary>
        /// 商家企业微信CorpID
        /// 1、可填写与商家主体一致且已认证的企业微信CorpID。
        /// 2、审核通过后，系统将为商家开通企业微信专区的自有交易权限，并完成商家商户号与该APPID的绑定，商家可自行发起交易。
        /// </summary>
        [JsonPropertyName("sub_corp_id")]
        public string SubCorpId { get; set; }

        /// <summary>
        /// 企业微信页面截图
        /// 1、最多可上传5张照片
        /// 2、请填写通过图片上传API接口预先上传图片生成好的MediaID
        /// </summary>
        [JsonPropertyName("wework_pics")]
        public List<string> WeworkPics { get; set; }
    }
}
