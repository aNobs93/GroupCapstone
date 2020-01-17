using groupCapstoneMusic.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace groupCapstoneMusic.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //public jsonresult sendrating(string r, string s, string id, string url)
        //{
        //    int autoid = 0;
        //    int16 thisvote = 0;
        //    int16 sectionid = 0;
        //    int16.tryparse(s, out sectionid);
        //    int16.tryparse(r, out thisvote);
        //    int.tryparse(id, out autoid);

        //    if (!user.identity.isauthenticated)
        //    {
        //        return json("not authenticated!");
        //    }

        //    if (autoid.equals(0))
        //    {
        //        return json("sorry, record to vote doesn't exists");
        //    }

        //    switch (s)
        //    {
        //        case "5": //user voting
        //            //check if he has already voted
        // var isit = db.votemodels.where(v => v.sectionid == sectionid &&
        //     v.username.equals(user.identity.name, stringcomparison.currentcultureignorecase) && v.voteforid == autoid).firstordefault();
        //            if (isit != null)
        //            {
        //                // keep the school voting flag to stop voting by this member
        //                httpcookie cookie = new httpcookie(url, "true");
        //                response.cookies.add(cookie);
        //                return json("<br />you have already rated this post, thanks !");
        //            }

        //            var sch = db.schoolmodels.where(sc => sc.autoid == autoid).firstordefault();
        //            if (sch != null)
        //            {
        //                object obj = sch.votes;

        //                string updatedvotes = string.empty;
        //                string[] votes = null;
        //                if (obj != null && obj.tostring().length > 0)
        //                {
        //                    string currentvotes = obj.tostring(); // votes pattern will be 0,0,0,0,0
        //                    votes = currentvotes.split(',');
        //                    // if proper vote data is there in the database
        //                    if (votes.length.equals(5))
        //                    {
        //                        // get the current number of vote count of the selected vote, always say -1 than the current vote in the array 
        //                        int currentnumberofvote = int.parse(votes[thisvote - 1]);
        //                        // increase 1 for this vote
        //                        currentnumberofvote++;
        //                        // set the updated value into the selected votes
        //                        votes[thisvote - 1] = currentnumberofvote.tostring();
        //                    }
        //                    else
        //                    {
        //                        votes = new string[] { "0", "0", "0", "0", "0" };
        //                        votes[thisvote - 1] = "1";
        //                    }
        //                }
        //                else
        //                {
        //                    votes = new string[] { "0", "0", "0", "0", "0" };
        //                    votes[thisvote - 1] = "1";
        //                }

        //                //concatenate all arrays now
        //                foreach (string ss in votes)
        //                {
        //                    updatedvotes += ss + ",";
        //                }
        //                updatedvotes = updatedvotes.substring(0, updatedvotes.length - 1);

        //                db.entry(sch).state = entitystate.modified;
        //                sch.votes = updatedvotes;
        //                db.savechanges();

        //                votemodel vm = new votemodel()
        //                {
        //                    active = true,
        //                    sectionid = int16.parse(s),
        //                    username = user.identity.name,
        //                    vote = thisvote,
        //                    voteforid = autoid
        //                };

        //                db.votemodels.add(vm);

        //                db.savechanges();

        //                // keep the school voting flag to stop voting by this member
        //                httpcookie cookie = new httpcookie(url, "true");
        //                response.cookies.add(cookie);
        //            }
        //            break;
        //        default:
        //            break;
        //    }
        //    return json("<br />you rated " + r + " star(s), thanks !");
        //}
    }
}