using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ScheduledTask;

namespace Test_TS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ScheduledTask.ScheduledTask obj = new ScheduledTask.ScheduledTask();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                obj.MonitorTasks();
            }
            catch (Exception ex)
            {
            }
        }
    }
}