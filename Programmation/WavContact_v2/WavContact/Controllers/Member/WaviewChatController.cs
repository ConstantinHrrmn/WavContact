using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WavContact.Views.Member;
using WavContact.DB;
using WavContact.Models;

namespace WavContact.Controllers.Waview
{
    public class WaviewChatController
    {
        private FrmWaviewChat frm;
        private List<User> clients;

        public WaviewChatController(FrmWaviewChat a_frm)
        {
            this.frm = a_frm;
            this.clients = new List<User>();
            this.LoadClients();
        }

        public void LoadClients()
        {
            this.clients = WavContactPDO.Clients();
            this.frm.LoadClientsList(this.clients);
        }
    }
}
