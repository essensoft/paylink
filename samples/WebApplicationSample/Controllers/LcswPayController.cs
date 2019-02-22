using System;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.LcswPay;
using Essensoft.AspNetCore.Payment.LcswPay.Request;
using Microsoft.AspNetCore.Mvc;
using WebApplicationSample.Models;

namespace WebApplicationSample.Controllers
{
    public class LcswPayController : Controller
    {
        private ILcswPayClient _client;
        public LcswPayController(ILcswPayClient client)
        {
            _client = client;
        }
        public IActionResult Index()
        {
            return View();
        }
        #region 注册终端
        public ActionResult Sign()
        {
            var viewModel = new LcswPaySignViewModel
            {
                TerminalTime = DateTime.Now.ToString("yyyyMMddHHmmss"),
                TerminalTrace = $"trace{DateTime.Now.ToString("yyyyMMddHHmmssfff")}"
            };
            return View(viewModel);
        }
        [HttpPost]
        public async Task<ActionResult> Sign(LcswPaySignViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var signRequest = new LcswPaySignRequest
                {
                    ServiceId = "090",
                    TerminalTime = viewModel.TerminalTime,
                    TerminalTrace = viewModel.TerminalTrace
                };
                var response = await _client.ExecuteAsync(signRequest);
                ViewData["response"] = response.Body;
            }
            return View(viewModel);
        }
        #endregion
        #region 刷卡（条码）支付
        public IActionResult BarcodePay()
        {
            var viewModel = new LcswPayBarcodePayViewModel {
                PayType ="000",
                TotalFee = "1",
                TerminalTrace = "trace20190221162123197",
                TerminalTime = DateTime.Now.ToString("yyyyMMddHHmmss"),
                Attach = "这是附加数据，将会原样返回",
                OrderBody = "这是测试订单"
            };
            return View(viewModel);
        } 
        [HttpPost]
        public async Task<IActionResult> BarcodePay(LcswPayBarcodePayViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var request = new LcswPayBarcodePayRequest
                {
                    PayType = viewModel.PayType,
                    ServiceId = "010",
                    TerminalTrace = viewModel.TerminalTrace,
                    TerminalTime = viewModel.TerminalTime,
                    AuthNo = viewModel.AuthNo,
                    TotalFee = viewModel.TotalFee,
                    SubAppid = viewModel.SubAppid,
                    OrderBody = viewModel.OrderBody,
                    Attach = viewModel.Attach,
                    GoodsDetail = viewModel.GoodsDetail,
                    GoodsTag = viewModel.GoodsTag
                };
                var response = await _client.ExecuteAsync(request);
                ViewData["response"] = response.Body;
            }
            return View(viewModel);
        }
        #endregion
        #region 支付查询
        public IActionResult Query()
        {
            var viewModel = new LcswPayQueryViewModel
            {
                PayType = "000",
                OutTradeNo = "300559750021119022116220200005",
                TerminalTrace = $"trace{DateTime.Now.ToString("yyyyMMddHHmmssfff")}",
                TerminalTime = DateTime.Now.ToString("yyyyMMddHHmmss")
            };
            return View(viewModel);
        }
        [HttpPost]
        public async  Task<IActionResult> Query(LcswPayQueryViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var request = new LcswPayQueryRequest
                {
                    PayType = viewModel.PayType,
                    ServiceId = "020",
                    TerminalTrace = viewModel.TerminalTrace,
                    TerminalTime = viewModel.TerminalTime,
                    PayTrace = viewModel.PayTrace,
                    PayTime = viewModel.PayTime,
                    OutTradeNo = viewModel.OutTradeNo
                };
                var response = await _client.ExecuteAsync(request);
                ViewData["response"] = response.Body;
            }
            return View(viewModel);
        }
        #endregion
    }
}