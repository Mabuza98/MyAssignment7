using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWhatsAppStatusSaver
{
    public class StatusSaverMasterDetailPageMasterMenuItem
    {
        public StatusSaverMasterDetailPageMasterMenuItem()
        {
            TargetType = typeof(StatusSaverMasterDetailPageMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}