using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.LcswPay.Utility
{
    /// <summary>
    /// 利楚商务扫呗支付签名信息
    /// </summary>
    public class LcswPaySignInfo
    {
        /// <summary>
        /// 所有参数信息
        /// </summary>
        public List<LcswPayParaInfo> ParaInfos { get; set; }
        /// <summary>
        /// 签名计算方式
        /// </summary>
        public LcswPaySignType SignType { get; set; }
        /// <summary>
        /// 获取用于请求的所有参数信息，包含计算好的签名
        /// </summary>
        /// <param name="option">配置信息</param>
        /// <returns>用于请求的所有参数信息</returns>
        public Dictionary<string,string> GetAllParasAndSign(LcswPayOption option)
        {
            var result = new Dictionary<string, string>();
            //先增加所有参数
            foreach(var para in ParaInfos)
            {
                result.Add(para.ParaName, para.ParaValue);
            }
            //计算签名
            var sign = CalcSign(option);
            result.Add("key_sign", sign);
            return result;
        }
        /// <summary>
        /// 计算签名
        /// </summary>
        /// <param name="option">配置信息</param>
        /// <returns>签名值</returns>
        private string CalcSign(LcswPayOption option)
        {
            string sign = "";
            switch (SignType)
            {
                case LcswPaySignType.AllRequiredPara:
                    sign = LcswPaySignature.CalcSignWithAllRequiredPara(ParaInfos);
                    break;
                case LcswPaySignType.AllRequiredParaAndToken:
                    sign = LcswPaySignature.CalcSignWithAllRequiredParaAndToken(ParaInfos,option.Token);
                    break;
            }
            return sign;
        }

    }
}
