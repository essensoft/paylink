using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IotDevicePrincipal Data Structure.
    /// </summary>
    public class IotDevicePrincipal : AlipayObject
    {
        /// <summary>
        /// 绑定关系id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 绑定关系类型  可选项[COMMON_ISV,COMMON_MERCHANT,COMMON_SHOP,PARKING,AFFAIRS,COMMON_PRODUCT,COMMON_ASSOCIATE,COMMON_APPLICANT,ALIPAY_USERID,SEPERATE_MERCHANT]    COMMON_ISV--ISV  COMMON_MERCHANT--商户  COMMON_SHOP--门店  PARKING--停车场  AFFAIRS--政务  COMMON_PRODUCT--供应商ID  COMMON_PRODUCT_PID--供应商PID  COMMON_ASSOCIATE--合作伙伴  COMMON_APPLICANT--申请人  ALIPAY_USERID--用户  SEPERATE_MERCHANT--间联商户
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
