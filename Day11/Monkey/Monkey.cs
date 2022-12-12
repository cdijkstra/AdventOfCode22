using System.Numerics;

namespace Monkey;

class Monkey
{
    public int Number { get; set; } = new();

    public Func<UInt64, UInt64> Operation { get; set; }
    public List<UInt64> Items { get; set; } = new();
    
    public uint DivisibleBy { get; set; } = new();

    public List<int> ThrowToMonkey { get; set; } = new();

    public UInt64 Inspections { get; set; } = 0;
}