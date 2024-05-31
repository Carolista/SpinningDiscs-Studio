using System;
namespace SpinningDiscs
{
	public abstract class BaseDisc
	{
        public string Name { get; set; }
        public int StorageCapacity { get; set; } // MB
        public int RemainingCapacity { get; set; }
        public int CapacityUsed { get; set; }
        public string DiskType { get; set; }
        public List<string> Contents { get; set; } // Never gets used

        public BaseDisc(string name, int maxCapacity, string disktype, int someUsedCapacity)
        {
            Name = name;
            StorageCapacity = maxCapacity;
            DiskType = disktype;
            CapacityUsed = CheckCapacity(someUsedCapacity);
            RemainingCapacity = SpaceLeft();
        }

        // Used only in constructor
        public int CheckCapacity(int data)
        {
            if (StorageCapacity < data)
            {
                return StorageCapacity;
            }
            else
            {
                return data;
            }
        }

        // Used only in constructor
        public int SpaceLeft()
        {
            return StorageCapacity - CapacityUsed;
        }

        public string DiskInfo()
        {
            string output = 
                "Disk name: " + Name 
                + "\nMax Capacity: " + StorageCapacity 
                + "\nSpace Used: " + CapacityUsed 
                + "\nAvailable Space: " + RemainingCapacity;
            return output;
        }

        public string WriteData(int size)
        {
            if (size > RemainingCapacity)
            {
                return "Not enough disc space!";
            }
            CapacityUsed += size;
            RemainingCapacity -= size; // mistake! need to subtract instead of add

            return "Data written to disc. Remaining space = " + RemainingCapacity;
        }
    }
}

