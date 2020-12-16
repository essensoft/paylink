using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAuthOperatorAddModel Data Structure.
    /// </summary>
    public class AlipayOpenAuthOperatorAddModel : AlipayObject
    {
        /// <summary>
        /// 添加蚂蚁操作员参数
        /// </summary>
        [JsonPropertyName("operator_add_vo")]
        public OperatorAddVO OperatorAddVo { get; set; }
    }
}
