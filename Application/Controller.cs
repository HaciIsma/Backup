﻿using Backup.Model;
using System;

namespace Backup
{
    class Controller
    {
        public void control()
        {

            Console.CursorVisible = false;
            Console.WriteLine("Choose: ");
            Console.WriteLine("1.DVD\n2.External\n3.Flash");
            bool check = default;
            int input = default;
            check = int.TryParse(Console.ReadLine(), out input);
            if (check)
            {
                switch (input)
                {
                    case 1:
                        Console.WriteLine("1.SingleSayt\n2.DoubleSayt");
                        check = int.TryParse(Console.ReadLine(), out input);
                        if (check)
                        {
                            DVD dvd = null;
                            switch (input)
                            {
                                case 1:
                                    dvd = new DVD(DVD.DVDType.SingleSayt);
                                    break;
                                case 2:
                                    dvd = new DVD(DVD.DVDType.DoubleSayt);
                                    break;
                            }
                        }
                        break;
                    case 2:
                        ExternalHDD externalHDD = null;
                        switch (input)
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                        }
                        break;
                    case 3:
                        Flash flash = new Flash(Flash.FlashType.f30, 500);
                        break;
                    default:
                        Console.WriteLine("Incorrect Choose");
                        break;
                }
            }
        }
    }
}
