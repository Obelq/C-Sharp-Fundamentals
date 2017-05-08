using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSplit
{
    class StartUp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "System Split")
                {
                    Hardware.SystemSplit();
                    break;
                }
                try
                {
                    var inputArr = command
                        .Split(new[] { ' ', ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                    var action = inputArr[0];

                    switch (action)
                    {
                        case "RegisterPowerHardware":
                            {
                                var name = inputArr[1];
                                var capacity = long.Parse(inputArr[2]);
                                var memory = long.Parse(inputArr[3]);
                                Hardware.RegisterPowerHardware(name, capacity, memory);
                                break;
                            }
                        case "RegisterHeavyHardware":
                            {
                                var name = inputArr[1];
                                var capacity = long.Parse(inputArr[2]);
                                var memory = long.Parse(inputArr[3]);
                                Hardware.RegisterHeavyHardware(name, capacity, memory);
                                break;
                            }
                        case "RegisterExpressSoftware":
                            {
                                var hardwareName = inputArr[1];
                                var name = inputArr[2];
                                var capacity = long.Parse(inputArr[3]);
                                var memory = long.Parse(inputArr[4]);

                                Hardware.RegisterExpressSoftware(hardwareName, name, capacity, memory);
                                break;
                            }
                        case "RegisterLightSoftware":
                            {
                                var hardwareName = inputArr[1];
                                var name = inputArr[2];
                                var capacity = long.Parse(inputArr[3]);
                                var memory = long.Parse(inputArr[4]);

                                Hardware.RegisterLightSoftware(hardwareName, name, capacity, memory);
                                break;
                            }
                        case "ReleaseSoftwareComponent":
                            {
                                var hardwareName = inputArr[1];
                                var softwareName = inputArr[2];

                                Hardware.ReleaseSoftwareComponent(hardwareName, softwareName);

                                break;
                            }

                        case "Analyze":
                            {
                                Hardware.Analize();

                                break;
                            }
                        case "Dump":
                            {
                                var hardwareName = inputArr[1];
                                Hardware.Dump(hardwareName);

                                break;
                            }
                        case "Restore":
                            {
                                var hardwareName = inputArr[1];
                                Hardware.Restore(hardwareName);

                                break;
                            }
                        case "Destroy":
                        {
                            var hardwareName = inputArr[1];
                            Hardware.Destroy(hardwareName);

                            break;
                        }
                        case "DumpAnalyze":
                        {
                            Hardware.DumpAnalyze();

                            break;
                        }

                    }


                }
                catch (Exception e)
                {

                }

            }
        }
    }
}
