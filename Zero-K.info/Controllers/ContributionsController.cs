﻿using System.Linq;
using System.Web.Mvc;
using ZkData;

namespace ZeroKWeb.Controllers
{
    public class ContributionsController: Controller
    {
        //
        // GET: /PayPal/
        public ActionResult Index() {
            return View("ContributionsIndex");
        }


        public ActionResult Ipn() {
            Global.Nightwatch.PayPalInterface.ImportIpnPayment(Request.Params, Request.BinaryRead(Request.ContentLength));
            return Content("");
        }


        [Auth]
        public ActionResult Redeem(string code) {
            var db = new ZkDataContext();
            if (string.IsNullOrEmpty(code)) return Content("Code is empty");
            var contrib = db.Contributions.SingleOrDefault(x => x.RedeemCode == code);
            if (contrib == null) return Content("No contribution with that code found");
            if (contrib.Account != null) return Content(string.Format("This contribution has been assigned to {0}, thank you.", contrib.Account.Name));
            var acc = Account.AccountByAccountID(db, Global.AccountID);
            acc.Kudos += contrib.KudosValue;
            contrib.Account = acc;
            db.SubmitAndMergeChanges();

            return Content(string.Format("Thank you!! {0} Kudos have been added to your account {1}", contrib.KudosValue, contrib.Account.Name));
        }

        public ActionResult ThankYou() {
            return View("ThankYou");
        }
    }
}