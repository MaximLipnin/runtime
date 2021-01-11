// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

public static class Program
{
    // to be wired once https://github.com/dotnet/xharness/pull/46 is merged
    [DllImport("__Internal")]
    public extern static void mono_ios_append_output (string value);

    [DllImport("__Internal")]
    public extern static void mono_ios_set_summary (string value);
    
    public static async Task<int> Main(string[] args)
    {
        mono_ios_set_summary($"Starting functional test");
        Console.WriteLine("Done!");
        await Task.Delay(5000);

        return 42;
    }
}
