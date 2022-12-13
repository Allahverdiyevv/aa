using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_sınıf_Imtahan
{
    interface IWeapon
    {
        int BullentCapasty { get; set; }
        int BullnetCount { get; set; }
        FireMode BUllentMode { get; set; }


        void Shut();
        int Fire();

        int GetRemainBullentCount();
        void Reload();
        void ChangeFireMode();

    }
}
