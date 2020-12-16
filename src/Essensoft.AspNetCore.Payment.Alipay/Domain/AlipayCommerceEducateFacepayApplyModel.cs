using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateFacepayApplyModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateFacepayApplyModel : AlipayObject
    {
        /// <summary>
        /// 扩展信息, json格式. 例如, 对不使用银行代扣, 可以传入{"useBankChannel":"NO"}； 使用银行代扣且指定银行，{"useBankChannel":"YES","useBankMode":"BANK"}； 使用银行代扣且指定银行卡，{"useBankChannel":"YES","useBankMode":"BANK_CARD"}。且必须实现获取银行卡信息的SPIAPI，若不传useBankMode默认指定银行
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 采集人脸学生uid
        /// </summary>
        [JsonPropertyName("face_uid")]
        public string FaceUid { get; set; }

        /// <summary>
        /// 接入场景，可选项： K12   --  K12场景 COLLEGE  --  高校场景
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 学生所在学校外标(国标码)
        /// </summary>
        [JsonPropertyName("school_stdcode")]
        public string SchoolStdcode { get; set; }
    }
}
