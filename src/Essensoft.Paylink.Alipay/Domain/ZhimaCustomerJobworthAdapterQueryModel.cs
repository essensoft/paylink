using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ZhimaCustomerJobworthAdapterQueryModel Data Structure.
    /// </summary>
    public class ZhimaCustomerJobworthAdapterQueryModel : AlipayObject
    {
        /// <summary>
        /// 匹配的参数"edu_level":"",//学历等级；"skill_certificate":""//证书和等级，证书和等级之间使用英文逗号隔开，等级可以为null eg:维修电工,四级/中级技能；"age":"",//两个数字 使用英文逗号隔开，-1代表没要求。eg:18,35表示18岁到35岁，-1,40表示40岁以下；"gender":"",//男｜女  要求这2个汉字二选一；"city":"",//cityCode 要求使用的高德cityCode；"recommend":""//推荐次数
        /// </summary>
        [JsonPropertyName("adapter")]
        public JobworthAdapter Adapter { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 匹配的职位的中文名称
        /// </summary>
        [JsonPropertyName("job_name")]
        public string JobName { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
