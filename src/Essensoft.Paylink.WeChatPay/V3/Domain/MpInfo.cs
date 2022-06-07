using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 公众号场景
    /// </summary>
    public class MpInfo
    {
        /// <summary>
        /// 服务商公众号AppID
        /// </summary>
        /// <remarks>
        /// 1、服务商公众号APPID与商家公众号APPID，二选一必填。
        /// 2、可填写当前服务商商户号已绑定的公众号APPID。
        /// <para>示例值：wx1234567890123456</para>
        /// </remarks>
        [JsonPropertyName("mp_appid")]
        public string MpAppid { get; set; }

        /// <summary>
        /// 商家公众号AppID
        /// </summary>
        /// <remarks>
        /// 1、服务商公众号APPID与商家公众号APPID，二选一必填。
        /// 2、可填写与商家主体一致且已认证的公众号APPID，需是已认证的服务号、政府或媒体类型的订阅号。
        /// 3、审核通过后，系统将发起特约商家商户号与该AppID的绑定（即配置为sub_appid），服务商随后可在发起支付时选择传入该appid，以完成支付，并获取sub_openid用于数据统计，营销等业务场景 。
        /// <para>示例值：wx1234567890123456</para>
        /// </remarks>
        [JsonPropertyName("mp_sub_appid")]
        public string MpSubAppid { get; set; }

        /// <summary>
        /// 公众号页面截图
        /// </summary>
        /// <remarks>
        /// 1、请提供展示商品/服务的页面截图/设计稿（最多5张），若公众号未建设完善或未上线请务必提供。
        /// 2、请填写通过图片上传API预先上传图片生成好的MediaID。
        /// <para>示例值：0P3ng6KTIW4-Q_l2FjmFJBZR9FwczhJehHhAZN6BKXQPcs-VvdSo</para>
        /// </remarks>
        [JsonPropertyName("mp_pics")]
        public List<string> MpPics { get; set; }
    }
}
