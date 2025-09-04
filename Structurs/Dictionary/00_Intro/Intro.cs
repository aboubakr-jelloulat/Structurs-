using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    /*
    Introduction
        A Dictionary in C# is a generic collection that stores key-value pairs, optimized for fast lookups using hashing. 

        It belongs to the System.Collections.Generic namespace and is the preferred modern alternative to Hashtable. 
        By enforcing strong typing for both keys and values, Dictionary<TKey, TValue> ensures type safety, better performance, 
        and avoids boxing/unboxing overhead.

    Key Features
        * Generic: Strongly typed, eliminating the need for casting and reducing runtime errors.
        * Efficient Lookups: Uses hash codes internally to provide near O(1) search, insert, and delete operations.
        * Uniqueness: Each key must be unique, while values can be duplicated.
        * Type Safety: Enforces compile-time checks, preventing invalid data types.
        * Order: Does not guarantee ordering, though in .NET Core 3.0+ the insertion order is preserved.
        * 
    */



    /*
     * 
    Dictionary vs Hashtable
        Both Dictionary and Hashtable store key-value pairs, but they differ in type safety,
        performance, and usage scenarios.

    Dictionary<TKey, TValue>
        * Generic (type-safe): Keys and values must be of specific types (no casting needed).
        * Performance: Very fast lookups (≈ O(1)), no boxing/unboxing → better with value types.
        * Order: No guaranteed order (in .NET Core 3.0+, insertion order is preserved).
        * Thread Safety: Not thread-safe by default, external sync needed.
        * Use Case: Modern apps (introduced in .NET 2.0), preferred for new development.

    Hashtable
        * Non-Generic: Stores keys and values as objects (requires casting on retrieval).
        * Performance: Fast lookups but slower than Dictionary with value types
          (due to boxing/unboxing overhead).
        * Order: No guaranteed order of elements.
        * Thread Safety: Can be wrapped with Hashtable.Synchronized, but still limited.
        * Use Case: Legacy codebases (introduced in .NET 1.0), rarely used in modern apps.

    Comparison Summary
        * Type Safety → Dictionary is strongly typed, Hashtable is not.
        * Performance → Dictionary is faster (no boxing/unboxing).
        * Compatibility → Hashtable is older, Dictionary is the modern replacement.
        * Thread Safety → Neither fully thread-safe without extra synchronization.

    👉 Best Practice:
        - Use Dictionary<TKey, TValue> in real-world projects (safer, faster, modern).
        - Use Hashtable only for maintaining legacy code.

    */




namespace Dictionary._00_Intro
{
    internal class Intro
    {


    }
}
