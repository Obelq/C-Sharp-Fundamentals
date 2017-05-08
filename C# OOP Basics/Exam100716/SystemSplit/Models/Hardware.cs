using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace SystemSplit
{
    public abstract class Hardware
    {
        private static List<Hardware> dumpedHardwares = new List<Hardware>();
        private static List<Hardware> hardwares = new List<Hardware>();

        private string name;
        private long maximumCapacity;
        private long maximumMemory;
        private long capacityUsed = 0;
        private long memoryUsed = 0;
        private List<Software> softwares;

        protected Hardware(string name, long maximumCapacity, long maximumMemory)
        {            
            this.softwares = new List<Software>();
            this.name = name;
            this.maximumCapacity = maximumCapacity;
            this.maximumMemory = maximumMemory;
        }

        public static void RegisterHeavyHardware(string name, long capacity, long memory)
        {
            Hardware hardware = new HeavyHardware(name, capacity, memory);
            hardwares.Add(hardware);
        }

        public static void RegisterPowerHardware(string name, long capacity, long memory)
        {
            Hardware hardware = new PowerHardware(name, capacity, memory);
            hardwares.Add(hardware);
        }

        public string Name { get { return this.name; } }

        public static void RegisterExpressSoftware(string hardwareName, string softwareName, long capacity, long memory)
        {
            var currentHardware = hardwares.FirstOrDefault(h => h.Name == hardwareName);
            if (currentHardware == null)
            {
                throw new ArgumentException("Invalid hardware name!");
            }

            Software software = new ExpressSoftware(softwareName, capacity, memory);
            var freeCapacity = currentHardware.maximumCapacity - currentHardware.capacityUsed - software.CapacityConsumtion;
            if (freeCapacity < 0)
            {
                throw new ArgumentException("Not enough capacity!");
            }
            var freeMemory = currentHardware.maximumMemory - currentHardware.memoryUsed - software.MemoryConsumption;
            if (freeMemory < 0)
            {
                throw new ArgumentException("Not enough memory!");
            }
            currentHardware.capacityUsed += software.CapacityConsumtion;
            currentHardware.memoryUsed += software.MemoryConsumption;

            currentHardware.softwares.Add(software);
        }

        public static void RegisterLightSoftware(string hardwareName, string softwareName, long capacity, long memory)
        {
            var currentHardware = hardwares.FirstOrDefault(h => h.Name == hardwareName);
            if (currentHardware == null)
            {
                throw new ArgumentException("Invalid hardware name!");
            }

            Software software = new LightSoftware(softwareName, capacity, memory);
            var freeCapacity = currentHardware.maximumCapacity - currentHardware.capacityUsed - software.CapacityConsumtion;
            if (freeCapacity < 0)
            {
                throw new ArgumentException("Not enough capacity!");
            }
            var freeMemory = currentHardware.maximumMemory - currentHardware.memoryUsed - software.MemoryConsumption;
            if (freeMemory < 0)
            {
                throw new ArgumentException("Not enough memory!");
            }
            currentHardware.capacityUsed += software.CapacityConsumtion;
            currentHardware.memoryUsed += software.MemoryConsumption;

            currentHardware.softwares.Add(software);
        }

        public static void ReleaseSoftwareComponent(string hardwareName, string softwareName)
        {
            var currentHardware = hardwares.FirstOrDefault(h => h.Name == hardwareName);
            if (currentHardware == null)
            {
                throw new ArgumentException("Invalid hardware name!");
            }

            var currentSoftware = currentHardware.softwares.FirstOrDefault(s => s.Name == softwareName);
            if (currentSoftware == null)
            {
                throw new ArgumentException("Software doesn't exist.");
            }
            currentHardware.capacityUsed -= currentSoftware.CapacityConsumtion;
            currentHardware.memoryUsed -= currentSoftware.MemoryConsumption;
            currentHardware.softwares.Remove(currentSoftware);
        }

        public static void Analize()
        {
            var countHardwares = hardwares.Count;
            long countSoftwares = 0;
            long totalMemoryInUse = 0;
            long maximumMemory = 0;
            long totalCapacityInUse = 0;
            long maximumCapacity = 0;
            foreach (var hardware in hardwares)
            {
                countSoftwares += hardware.softwares.Count;
                totalCapacityInUse += hardware.capacityUsed;
                maximumCapacity += hardware.maximumCapacity;
                totalMemoryInUse += hardware.memoryUsed;
                maximumMemory += hardware.maximumMemory;
            }
            Console.WriteLine($"System Analysis{Environment.NewLine}" +
                              $"Hardware Components: {countHardwares}{Environment.NewLine}" +
                              $"Software Components: {countSoftwares}{ Environment.NewLine}" +
                              $"Total Operational Memory: {totalMemoryInUse} / {maximumMemory}{ Environment.NewLine}" +
                              $"Total Capacity Taken: {totalCapacityInUse} / {maximumCapacity}");
        }

        public abstract string HardwareType();

        public static void SystemSplit()
        {

            foreach (var hardware in hardwares.OrderByDescending(h => h.HardwareType()))
            {
                long countOfExpressSoftwareComponents = 0;
                long countOfLightSoftwareComponents = 0;
                foreach (var software in hardware.softwares)
                {
                    if (software.GetType() == typeof(ExpressSoftware))
                    {
                        countOfExpressSoftwareComponents++;
                    }
                    else
                    {
                        countOfLightSoftwareComponents++;
                    }
                }
                Console.WriteLine($"Hardware Component - {hardware.Name}");
                Console.WriteLine($"Express Software Components - {countOfExpressSoftwareComponents}");
                Console.WriteLine($"Light Software Components - {countOfLightSoftwareComponents}");
                Console.WriteLine($"Memory Usage: {hardware.memoryUsed} / {hardware.maximumMemory}");
                Console.WriteLine($"Capacity Usage: {hardware.capacityUsed} / {hardware.maximumCapacity}");
                Console.WriteLine($"Type: {hardware.HardwareType()}");
                Console.WriteLine(hardware.softwares.Count != 0
                    ? $"Software Components: {string.Join(", ", hardware.softwares.Select(s => s.Name))}"
                    : "Software Components: None");
            }
        }

        public static void Dump(string hardwareName)
        {
            var hardware = hardwares.FirstOrDefault(h => h.Name == hardwareName);
            if (hardware == null)
            {
                throw new ArgumentException("Hardware does not exist!");
            }

            dumpedHardwares.Add(hardware);
            hardwares.Remove(hardware);

        }

        public static void Restore(string hardwareName)
        {
            var hardware = dumpedHardwares.FirstOrDefault(h => h.Name == hardwareName);
            if (hardware == null)
            {
                throw new ArgumentException("Hardware does not exist!");
            }

            hardwares.Add(hardware);
            dumpedHardwares.Remove(hardware);
        }
        public static void Destroy(string hardwareName)
        {
            var hardware = dumpedHardwares.FirstOrDefault(h => h.Name == hardwareName);
            if (hardware == null)
            {
                throw new ArgumentException("Hardware does not exist!");
            }

            dumpedHardwares.Remove(hardware);
        }


        public static void DumpAnalyze()
        {
            long countPowerHardwares = 0;
            long countHeavyHardwares = 0;
            long countExpressSoftwares = 0;
            long countLightSoftwares = 0;

            long totalMemoryInUse = 0;
            long totalCapacityInUse = 0;
            foreach (var hardware in dumpedHardwares)
            {
                if (hardware.GetType() == typeof(PowerHardware))
                {
                    countPowerHardwares++;
                }
                else
                {
                    countHeavyHardwares++;
                }
                totalCapacityInUse += hardware.capacityUsed;
                totalMemoryInUse += hardware.memoryUsed;
                foreach (var software in hardware.softwares)
                {
                    if (software.GetType() == typeof(ExpressSoftware))
                    {
                        countExpressSoftwares++;
                    }
                    else
                    {
                        countLightSoftwares++;
                    }
                }
            }
            Console.WriteLine($"Dump Analysis{Environment.NewLine}" +
                              $"Power Hardware Components: {countPowerHardwares}{Environment.NewLine}" +
                              $"Heavy Hardware Components: {countHeavyHardwares}{Environment.NewLine}" +
                              $"Express Software Components: {countExpressSoftwares}{ Environment.NewLine}" +
                              $"Light Software Components: {countLightSoftwares}{ Environment.NewLine}" +
                              $"Total Dumped Memory: {totalMemoryInUse}{ Environment.NewLine}" +
                              $"Total Dumped Capacity: {totalCapacityInUse}");
        }
    }
}