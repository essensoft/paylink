using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 小程序场景
    /// </summary>
    public class MiniProgramInfo : WeChatPayObject
    {
        /// <summary>
        /// 服务商小程序APPID
        /// </summary>
        /// <remarks>
        /// 1、服务商小程序APPID与商家小程序APPID，二选一必填。
        /// 2、可填写当前服务商商户号已绑定的小程序APPID。
        /// <para>示例值：wx1234567890123456</para>
        /// </remarks>
        [JsonPropertyName("mini_program_appid")]
        public string MiniProgramAppid { get; set; }

        /// <summary>
        /// 商家小程序APPID
        /// </summary>
        /// <remarks>
        /// 1、服务商小程序APPID与商家小程序APPID，二选一必填；
        /// 2、请填写已认证的小程序APPID；
        /// 3、完成进件后，系统发起特约商户号与该AppID的绑定（即配置为sub_appid可在发起支付时传入）
        /// （1）若APPID主体与商家主体/服务商主体一致，则直接完成绑定；
        /// （2）若APPID主体与商家主体/服务商主体不一致，则商户签约时显示《联合营运承诺函》，并且AppID的管理员需登录公众平台确认绑定意愿；
        /// <para>示例值：wx1234567890123456</para>
        /// </remarks>
        [JsonPropertyName("mini_program_sub_appid")]
        public string MiniProgramSubAppid { get; set; }

        /// <summary>
        /// 小程序截图
        /// </summary>
        /// <remarks>
        /// 1、请提供展示商品/服务的页面截图/设计稿（最多5张），若小程序未建设完善或未上线 请务必提供；
        /// 2、请填写通过图片上传API预先上传图片生成好的MediaID。
        /// <para>示例值：0P3ng6KTIW4-Q_l2FjmFJBZR9FwczhJehHhAZN6BKXQPcs-VvdSo</para>
        /// </remarks>
        [JsonPropertyName("mini_program_pics")]
        public List<string> MiniProgramPics { get; set; }
    }
}
