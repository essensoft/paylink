using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 补充材料
    /// </summary>
    public class AdditionInfo : WeChatPayObject
    {
        /// <summary>
        /// 法人开户承诺函
        /// </summary>
        /// <remarks>
        /// 1、请上传法定代表人或负责人亲笔签署的开户承诺函扫描件（下载模板）。亲笔签名承诺函内容清晰可见，不得有涂污，破损，字迹不清晰现象。
        /// 2、请填写通过《图片上传API》预先上传图片生成好的MediaID。
        /// <para>示例值：47ZC6GC-vnrIUv0OF4wFNIO4kqg05InE4d2I6_H7I4</para>
        /// </remarks>
        [JsonPropertyName("legal_person_commitment")]
        public string LegalPersonCommitment { get; set; }

        /// <summary>
        /// 法人开户意愿视频
        /// </summary>
        /// <remarks>
        /// 1、建议法人按如下话术录制“法人开户意愿视频”：
        /// 我是#公司全称#的法定代表人（或负责人），特此证明本公司申请的商户号为我司真实意愿开立且用于XX业务（或XX服务）。我司现有业务符合法律法规及腾讯的相关规定。
        /// 2、支持上传20M内的视频，格式可为avi、wmv、mpeg、mp4、mov、mkv、flv、f4v、m4v、rmvb。
        /// 3、请填写通过《视频上传API》预先上传视频生成好的MediaID。
        /// <para>示例值：47ZC6GC-NIO4kqg05InE4d2I6_H7I4</para>
        /// </remarks>
        [JsonPropertyName("legal_person_video")]
        public string LegalPersonVideo { get; set; }

        /// <summary>
        /// 补充材料
        /// </summary>
        /// <remarks>
        /// 1、根据驳回要求提供额外信息，如：
        /// （1）业务模式不清晰时，需详细描述支付场景或提供相关材料（如业务说明/门店照/ 手持证件照等）；
        /// （2）特殊业务要求提供相关的协议材料等；
        /// 2、请填写通过《图片上传API》预先上传图片生成好的MediaID。
        /// </remarks>
        [JsonPropertyName("business_addition_pics")]
        public List<string> BusinessAdditionPics { get; set; }

        /// <summary>
        /// 补充说明
        /// </summary>
        /// <remarks>
        /// 根据驳回要求提供额外信息，如：业务模式不清晰时，请详细描述支付场景。
        /// <para>示例值：特殊情况，说明原因</para>
        /// </remarks>
        [JsonPropertyName("business_addition_msg")]
        public string BusinessAdditionMsg { get; set; }
    }
}
