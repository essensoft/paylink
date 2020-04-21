using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiAdvertCommissionMissionCreateResponse.
    /// </summary>
    public class KoubeiAdvertCommissionMissionCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 分佣任务ID，需要保存，后续任务管理以及任务认领都需要任务ID  1、如果商户创建分佣任务，则出参会返回任务ID  2、如果服务商代创建分佣任务，由于需要审批，因此出参不返回任务ID，而是需要通过任务查询接口（koubei.advert.commission.mission.query）获取
        /// </summary>
        [JsonPropertyName("mission_id")]
        public string MissionId { get; set; }
    }
}
