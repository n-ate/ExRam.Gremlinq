﻿using System.Runtime.CompilerServices;
using DiffEngine;

public static class ModuleInit
{
    [ModuleInitializer]
    public static void Init()
    {
        DiffRunner.Disabled = true;

#if DEBUG
        VerifierSettings.AutoVerify();
#endif
    }
}
