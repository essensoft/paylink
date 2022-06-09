using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 银行账户证明材料
    /// </summary>
    public class AccountCertInfo
    {
        /// <summary>
        /// 结算证明函
        /// </summary>
        /// <remarks>
        /// 1. 请参照示例图打印结算证明函。
        /// 2、可上传1张图片，请填写通过图片上传API预先上传图片生成好的MediaID。
        /// <para>示例值：47ZC6GC-vnrbEny_Ie_An5-tCpqxucuxi-vByf3Gjm7KEIUv0OF4wFNIO4kqg05InE4d2I6_H7I4</para>
        /// </remarks>
        [JsonPropertyName("settlement_cert_pic")]
        public string SettlementCertPic { get; set; }

        /// <summary>
        /// 关系证明函
        /// </summary>
        /// <remarks>
        /// 1. 请参照示例图打印关系证明函。
        /// 2、可上传1张图片，请填写通过图片上传API预先上传图片生成好的MediaID。
        /// <para>示例值：47ZC6GC-vnrbEny_Ie_An5-tCpqxucuxi-vByf3Gjm7KEIUv0OF4wFNIO4kqg05InE4d2I6_H7I4</para>
        /// </remarks>
        [JsonPropertyName("relation_cert_pic")]
        public string RelationCertPic { get; set; }

        /// <summary>
        /// 其他补充证明
        /// </summary>
        /// <remarks>
        /// 1. 请提供非同名结算的法律法规、政策通知、政府或上级部门公文等证明文件，以作上述材料的补充证明。
        /// 2、可上传1-3张图片，请填写通过图片上传API预先上传图片生成好的MediaID。
        /// <para>示例值：47ZC6GC-vnrbEny_Ie_An5-tCpqxucuxi-vByf3Gjm7KEIUv0OF4wFNIO4kqg05InE4d2I6_H7I4</para>
        /// </remarks>
        [JsonPropertyName("other_cert_pics")]
        public List<string> OtherCertPics { get; set; }
    }
}
