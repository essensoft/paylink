using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}