using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_sınıf_Imtahan
{
    internal class Weapon : IWeapon
    {
     
        public Weapon(int bullentCapasty , int bullentCount , FireMode bullentMode )
        {
            this.BullentCapasty = bullentCapasty;
            this.BullnetCount = bullentCount;
            this.BUllentMode = bullentMode;

        
        }

        public int BullentCapasty { get; set ; }
        public int BullnetCount { get; set; }
        public FireMode BUllentMode { get; set; }
        public void ChangeFireMode()
        {
            if (this.BUllentMode == FireMode.Fire )
            {
                BUllentMode = FireMode.Fire;
            }
            else
            {
                BUllentMode = FireMode.Single;

            }
        }

        public int Fire()
        {
            BullentCapasty = 0;
            return BullentCapasty;

        }

        public int GetRemainBullentCount()
        {
            return BullentCapasty - BullnetCount;
        }

        public void Reload()
        {
            BullnetCount = BullentCapasty;
        }

        public void Shut()
        {
            BullnetCount-= 1;
            
           
        }
    }
}
