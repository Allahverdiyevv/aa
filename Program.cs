namespace _13_sınıf_Imtahan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon(40,15 ,FireMode.Fire );
            bool finish = (true);
            do
            {

                Console.WriteLine("0__Informasiya almaq ucun");
                Console.WriteLine("1__Shoot methodu ucun" );
                Console.WriteLine("2__Fire metodu ucun");
                Console.WriteLine("3__GetRemainBullentCount");
                Console.WriteLine("4__Rellod methodu ucun");
                Console.WriteLine("5__ChangeFireMode methodu ucun");
                Console.WriteLine("6__Proqrami dayandirmaq ucun qisayoldur");
                Console.WriteLine("7__Edit");
                string dongu = Console.ReadLine();


                switch (dongu)
                {
                    case "0":
                        Console.WriteLine("Fire Mode :" + weapon.Fire);
                        Console.WriteLine("GetRemainBullentCount" + weapon.GetRemainBullentCount());
                        Console.WriteLine(" Bullent count" + weapon.BUllentMode);
                        Console.WriteLine(" Bulent capasity" + weapon.BullentCapasty);
                        break;

                    case "1":
                        weapon.Shut();
                        Console.WriteLine("Shut");
                        break;


                    case "2":
                        weapon.Fire();
                        Console.WriteLine("Fire");
                        break;


                    case "3":
                        weapon.GetRemainBullentCount();
                        Console.WriteLine("GetRemainBullentCount");
                        break;

                    case "4":
                        weapon.Reload();
                        Console.WriteLine("Reload");
                        break;

                    case "5":
                        weapon.ChangeFireMode();
                        Console.WriteLine("ChangeFireMode");
                        break;
                    case "6":
                        finish = false;
                        Console.WriteLine("Finish");
                        break;

                    case "7":
                        bool Finsh = true;
                        do
                        {
                            Console.WriteLine("1__ Tutumu Deyis");
                            Console.WriteLine("2__Gulle sayini deyis ");
                            Console.WriteLine("3__Cixis");
                            string edit = Console.ReadLine();
                            if (edit == "1")
                            {
                                
                                ChangeBullentCapasity(weapon);
                                Console.WriteLine("Isledi");

                            }
                            else if (edit == "2") 
                            {
                                Console.WriteLine("Salam isledi");
                                ChangeBullentCount(weapon);
                            }
                            else if (edit == "3")
                            {
                                Finsh = false;

                            }




                        } while (Finsh);
                        break;
                    default:
                        Console.WriteLine("daxil ol");
                        break;







                }       


            } while (true);

           

        }
        public static void ChangeBullentCapasity(Weapon weapon)
        {
            int c;
            string capasty = Console.ReadLine();
            bool cc = int.TryParse(capasty, out c);

            if (cc)
            {
                weapon.BullentCapasty = c;
            }


            else
            {
                Console.WriteLine("Yeniden daxil et");
            }


        }



        public static void ChangeBullentCount(Weapon weapon)
        {
            int c;
            string capasity = Console.ReadLine();
            bool cc = int.TryParse(capasity, out c);

            int Bullent = weapon.GetRemainBullentCount();
            if (cc)
            {
                if (c <= Bullent)
                {
                    weapon.BullentCapasty = c;
                }
                else
                {
                    Console.WriteLine( weapon.BullentCapasty);
                }
            }


            else
            {
                Console.WriteLine("Yeniden daxil et!");
            }
        }


    }
}