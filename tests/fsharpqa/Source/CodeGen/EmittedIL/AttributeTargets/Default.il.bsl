
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.0.30319.17369
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly extern FSharp.Core
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )                         // .?_....:
  .ver 4:3:0:0
}
.assembly Default
{
  .custom instance void [FSharp.Core]Microsoft.FSharp.Core.FSharpInterfaceDataVersionAttribute::.ctor(int32,
                                                                                                      int32,
                                                                                                      int32) = ( 01 00 02 00 00 00 00 00 00 00 00 00 00 00 00 00 ) 

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 01 01 00 00 00 00 ) 

  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.mresource public FSharpSignatureData.Default
{
  // Offset: 0x00000000 Length: 0x0000043E
}
.mresource public FSharpOptimizationData.Default
{
  // Offset: 0x00000448 Length: 0x000000BA
}
.module Default.dll
// MVID: {4F1D0914-AAA9-67BB-A745-038314091D4F}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x000000460BBD0000


// =============== CLASS MEMBERS DECLARATION ===================

.class public abstract auto ansi sealed M
       extends [mscorlib]System.Object
{
  .custom instance void [FSharp.Core]Microsoft.FSharp.Core.CompilationMappingAttribute::.ctor(valuetype [FSharp.Core]Microsoft.FSharp.Core.SourceConstructFlags) = ( 01 00 07 00 00 00 00 00 ) 
  .class auto ansi serializable nested public ExportAttribute
         extends [mscorlib]System.Attribute
  {
    .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 80 01 00 00 00 00 ) 
    .custom instance void [FSharp.Core]Microsoft.FSharp.Core.CompilationMappingAttribute::.ctor(valuetype [FSharp.Core]Microsoft.FSharp.Core.SourceConstructFlags) = ( 01 00 03 00 00 00 00 00 ) 
    .method public specialname rtspecialname 
            instance void  .ctor() cil managed
    {
      // Code size       10 (0xa)
      .maxstack  8
      .language '{AB4F38C9-B6E6-43BA-BE3B-58080B2CCCE3}', '{994B45C4-E6E9-11D2-903F-00C04FA302A1}', '{5A869D0B-6611-11D3-BD2A-0000F80849BD}'
      .line 9,9 : 4,23
      IL_0000:  nop
      IL_0001:  ldarg.0
      IL_0002:  callvirt   instance void [mscorlib]System.Attribute::.ctor()
      IL_0007:  ldarg.0
      IL_0008:  pop
      .line 8,8 : 6,21 
      IL_0009:  ret
    } // end of method ExportAttribute::.ctor

  } // end of class ExportAttribute

  .method public specialname static int32 
          get_T() cil managed
  {
    // Code size       6 (0x6)
    .maxstack  8
    IL_0000:  ldsfld     int32 '<StartupCode$Default>'.$M::T@12
    IL_0005:  ret
  } // end of method M::get_T

  .property int32 T()
  {
    .custom instance void M/ExportAttribute::.ctor() = ( 01 00 00 00 ) 
    .custom instance void [FSharp.Core]Microsoft.FSharp.Core.CompilationMappingAttribute::.ctor(valuetype [FSharp.Core]Microsoft.FSharp.Core.SourceConstructFlags) = ( 01 00 09 00 00 00 00 00 ) 
    .get int32 M::get_T()
  } // end of property M::T
} // end of class M

.class private abstract auto ansi sealed '<StartupCode$Default>'.$M
       extends [mscorlib]System.Object
{
  .field static assembly initonly int32 T@12
  .custom instance void M/ExportAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .field static assembly int32 init@
  .custom instance void [mscorlib]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.Diagnostics.DebuggerNonUserCodeAttribute::.ctor() = ( 01 00 00 00 ) 
  .method private specialname rtspecialname static 
          void  .cctor() cil managed
  {
    // Code size       27 (0x1b)
    .maxstack  4
    .locals init ([0] int32 T)
    .line 12,12 : 1,29 
    IL_0000:  nop
    IL_0001:  nop
    .line 12,12 : 10,25 
    IL_0002:  ldstr      "hello"
    IL_0007:  newobj     instance void class [FSharp.Core]Microsoft.FSharp.Core.PrintfFormat`5<class [FSharp.Core]Microsoft.FSharp.Core.Unit,class [mscorlib]System.IO.TextWriter,class [FSharp.Core]Microsoft.FSharp.Core.Unit,class [FSharp.Core]Microsoft.FSharp.Core.Unit,class [FSharp.Core]Microsoft.FSharp.Core.Unit>::.ctor(string)
    IL_000c:  call       !!0 [FSharp.Core]Microsoft.FSharp.Core.ExtraTopLevelOperators::PrintFormatLine<class [FSharp.Core]Microsoft.FSharp.Core.Unit>(class [FSharp.Core]Microsoft.FSharp.Core.PrintfFormat`4<!!0,class [mscorlib]System.IO.TextWriter,class [FSharp.Core]Microsoft.FSharp.Core.Unit,class [FSharp.Core]Microsoft.FSharp.Core.Unit>)
    IL_0011:  pop
    .line 12,12 : 27,28 
    IL_0012:  ldc.i4.1
    IL_0013:  dup
    IL_0014:  stsfld     int32 '<StartupCode$Default>'.$M::T@12
    IL_0019:  stloc.0
    IL_001a:  ret
  } // end of method $M::.cctor

} // end of class '<StartupCode$Default>'.$M


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
